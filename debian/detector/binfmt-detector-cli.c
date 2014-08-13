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
 *  binfmt PE executable helper, by Ilya Konstantinov <future@shiny.co.il>
 *  Based on PE headers structures courtesy of Mono .NET runtime project
 *  (http://www.go-mono.com).
 */
 
#include <errno.h>
#include <string.h>
#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <libintl.h>
#include <stdint.h>

#include "cil-coff.h"

//Change this to one MSDOS, MSDOS, NATIVE or CLR
#define DETECT CLR

#define _(String) gettext(String)

/* Globals */
enum execTypeEnum {
	UNKNOWN,
	MSDOS,
	NATIVE,
	CLR
} execType = UNKNOWN;

int main(int argc, char **argv)
{
	const char *filename;
	FILE *image;
	size_t read;
	
	if (argc < 2) exit(EXIT_FAILURE);
	
	filename = argv[1];
	image = fopen(filename, "r");
	if (image == NULL) exit(EXIT_FAILURE);
	
	/* Parse the MSDOS header */
	
	{
		MSDOSHeader msdos_header;
		uint32_t pe_offset;
		read = fread(&msdos_header, sizeof(msdos_header), 1, image);
		if (read < 1) exit(EXIT_FAILURE);
		pe_offset = msdos_header.pe_offset[0]
			  | msdos_header.pe_offset[1] << 8
			  | msdos_header.pe_offset[2] << 16
			  | msdos_header.pe_offset[3] << 24;
		if ((pe_offset == 0) ||
		    (fseek(image, pe_offset, SEEK_SET) != 0))
			execType = MSDOS;
	}
	
	/* Parse the PE header */

	if (execType == UNKNOWN)
	{
		DotNetHeader dotnet_header;
		uint16_t pe_magic;
		uint32_t rva;
		read = fread(&dotnet_header, sizeof(dotnet_header), 1, image);
		if (read < 1) exit(EXIT_FAILURE);
		pe_magic = dotnet_header.pe.pe_magic[0]
			 | dotnet_header.pe.pe_magic[1] << 8;
		if (dotnet_header.pesig[0] != 'P' || dotnet_header.pesig[1] != 'E' || pe_magic != 0x10B) exit(EXIT_FAILURE);
		rva = dotnet_header.datadir.pe_cli_header.rva[0]
		    | dotnet_header.datadir.pe_cli_header.rva[1] << 8
		    | dotnet_header.datadir.pe_cli_header.rva[2] << 16
		    | dotnet_header.datadir.pe_cli_header.rva[1] << 24;
		if ((dotnet_header.datadir.pe_cli_header.size != 0) &&
			(rva != 0) &&
			(fseek(image, rva, SEEK_SET) == 0))
			execType = CLR;
		else
			execType = NATIVE;
	}
	fclose(image);

	/* Return a value indicating success or failure */
	if (execType == DETECT) exit(EXIT_SUCCESS); else exit(EXIT_FAILURE);
}
