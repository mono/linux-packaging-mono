binfmt-detector-cli: binfmt-detector-cli.c cil-coff.h
	$(CC) $(CFLAGS) $(CPPFLAGS) $(LDFLAGS) binfmt-detector-cli.c -o binfmt-detector-cli
	strip binfmt-detector-cli

clean:
	rm -f binfmt-detector-cli
