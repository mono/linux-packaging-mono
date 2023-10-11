/*
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Library General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program; if not, write to the Free Software
 *  Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA 02111-1307, USA.
 *
 *  Based on:
 *  binfmt PE executable helper, by Ilya Konstantinov <future@shiny.co.il>
 */

#include <errno.h>
#include <stdio.h>
#include <stdlib.h>
#include <stdint.h>

#define LOG_ENABLED 0
#define LOG(fmt, ...)					\
	if (LOG_ENABLED) {				\
		fprintf(stderr, fmt "\n"		\
			__VA_OPT__(,) __VA_ARGS__ );	\
	}


/* Read a big-endian, 16-bit value at the given offset from the given file. */
uint16_t fread_uint16(FILE* f, unsigned long offset)
{
	if (fseek(f, offset, SEEK_SET) != 0)
	{
		LOG("Failed to seek to %lu: %d", offset, errno);
		exit(EXIT_FAILURE);
	}

	unsigned char bytes[2];
	if (fread(&bytes, sizeof(bytes), 1, f) != 1)
	{
		LOG("Failed to read %zd bytes at %lu: %d", sizeof(bytes), offset, errno);
		exit(EXIT_FAILURE);
	}

	return bytes[0] | bytes[1] << 8;
}


/* Read a big-endian, 32-bit value at the given offset from the given file. */
uint32_t fread_uint32(FILE* f, unsigned long offset)
{
	if (fseek(f, offset, SEEK_SET) != 0)
	{
		LOG("Failed to seek to %lu: %d", offset, errno);
		exit(EXIT_FAILURE);
	}

	unsigned char bytes[4];
	if (fread(&bytes, sizeof(bytes), 1, f) != 1)
	{
		LOG("Failed to read %zd bytes at %lu: %d", sizeof(bytes), offset, errno);
		exit(EXIT_FAILURE);
	}

	return bytes[0] | bytes[1] << 8 | bytes[2] << 16 | bytes[3] << 24;
}


int main(int argc, char **argv)
{
	if (argc < 2) exit(EXIT_FAILURE);

	FILE* image = fopen(argv[1], "r");

	if (image == NULL) exit(EXIT_FAILURE);

	/*
	 * Assume the given file is at least an MS-DOS binary (it starts
	 * with the "MZ" magic).  Just need to disambiguate between a
	 * CLR-managed code binary vs. a traditional native binary.
	 */

	/* Offset to the PE structured is at fixed offset 0x3C */
	const uint32_t pe_offset = fread_uint32(image, 0x3C);

	/*
	 * PE structure should start with the "PE signature" ("PE\0\0", or
	 * 0x00004550 in big-endian).
	 */
	const uint32_t pe_signature = fread_uint32(image, pe_offset);
	if (pe_signature != 0x004550)
	{
		LOG("Wrong PE_signature (got %#08x)", pe_signature);
		exit(EXIT_FAILURE);
	}

	/*
	 * The PE format is stored after the 4-byte signature and 20-byte
	 * COFF header.  There are two formats PE32 or PE32+ that might
	 * contain a CLR-managed binary.  All other formats are native.
	 */
	const uint16_t pe_format = fread_uint16(image, pe_offset + 4 + 20);

	/*
	 * Compute the offset of the "CLR Runtime Header" (the 15th) entry
	 * in the Header Data Directories section.  This offset is
	 * computed relative to the pe_offset.
	 */
	size_t datadir_clr_offset = 0;
	if (pe_format == 0x10b)
	{
		LOG("PE32 format");

		/*
		 * +4 bytes for pe_signature
		 * +20 bytes for COFF header
		 * +28 bytes for PE32 "standard fields" header
		 * +68 bytes for "Windows-specific fields" header
		 * +(8 * 14) bytes for the 15th entry ("CLR Runtime")
		 *     in the Data Directories Header
		 */
		datadir_clr_offset = 4 + 20 + 28 + 68 + (8 * 14);
	}
	else if (pe_format == 0x20b)
	{
		LOG("PE32+ format");

		/*
		 * +4 bytes for pe_signature
		 * +20 bytes for COFF header
		 * +24 bytes for PE32 "standard fields" header
		 * +88 bytes for "Windows-specific fields" header
		 * +(8 * 14) bytes for the 15th entry ("CLR Runtime")
		 *     in the Data Directories Header
		 */
		datadir_clr_offset = 4 + 20 + 24 + 88 + (8 * 14);
	}
	else
	{
		/*
		 * This file may be in some other PE format, none of those
		 * format support CLR-managed binaries, so we are done.
		 */
		LOG("Not a PE32/PE32+ binary: %#04x", pe_format);
		exit(EXIT_FAILURE);
	}

	LOG("CLR Directory offset %#08zx", datadir_clr_offset);

	/*
	 * The CLR Data Directory entry (like all entries in the Data
	 * Directory) consists of a 4-byte virtual address and a 4-byte
	 * size.  (In both PE32 and PE32+ formats.)
	 */
	const uint32_t rva = fread_uint32(image, pe_offset + datadir_clr_offset);
	const uint32_t rsz = fread_uint32(image, pe_offset + datadir_clr_offset + 4);

	LOG("CLR Data rva=%#0x size=%#0x", rva, rsz);

	/* Empty CLR Data means its a native PE executable. */
	if ((rva == 0) || (rsz == 0))
	{
		LOG("No CLR content, not a Mono binary.");
		exit(EXIT_FAILURE);
	}

	/*
	 * At this point we assume the binary is a CLR one.  Technically, garbage
	 * files could get this far, but hopefully the Mono runtime is the best
	 * place to decode/explain such broken files (vs. the wine runtime).
	 */

	LOG("All checks passed.");
	fclose(image);

	exit(EXIT_SUCCESS);
}
