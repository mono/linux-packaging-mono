DEB_MONO_ARCHS = amd64 armel armhf i386 mipsel kfreebsd-amd64 kfreebsd-i386 powerpc ppc64 s390x
# grep defined mono/metadata/sgen-archdep.h
#if defined(MONO_CROSS_COMPILE)
#elif defined(TARGET_X86)
#elif defined(TARGET_AMD64)
#elif defined(TARGET_POWERPC)
#elif defined(TARGET_ARM)
#elif defined(__mips__)
#elif defined(__s390x__)
#elif defined(__sparc__)
# SGen is default now - Every arch is expected to support it
DEB_MONO_SGEN_ARCHS = $(DEB_MONO_ARCHS)
