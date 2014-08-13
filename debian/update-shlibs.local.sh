#!/bin/sh -e

VERSION=$(dpkg-parsechangelog | grep ^Vers | cut -d\  -f2)
UPVERSION=$(echo $VERSION | sed 's,-.*,,' | sed 's,+dfsg,,')
MAJOR_MINOR_UPVERSION=$(perl -e '$_=pop; print m/^(\d+\.\d+)/g;' $UPVERSION)

dpkg-checkbuilddeps -d "\
	libcairo2-dev, \
	firebird2.0-dev, \
	libsqlite0-dev, \
	libsqlite3-dev, \
	libasound2-dev, \
	libgamin-dev, \
	libcups2-dev, \
	librsvg2-dev, \
	libgtk2.0-dev, \
	libgnomeui-dev
"
	
echo -n "Updating shlibs.local for Mono $UPVERSION..."

cp debian/shlibs.local debian/shlibs.local.backup
rm -f debian/shlibs.local.new

# libs that don't ship shlibs
echo "libMonoPosixHelper 0 mono-runtime (>= $MAJOR_MINOR_UPVERSION)"	>> debian/shlibs.local.new
echo "libMonoSupportW 0 mono-runtime (>= $MAJOR_MINOR_UPVERSION)"	>> debian/shlibs.local.new
echo "libgdiplus 0 libgdiplus (>= $MAJOR_MINOR_UPVERSION)"		>> debian/shlibs.local.new
echo "libgluezilla 0 libgluezilla (>= $MAJOR_MINOR_UPVERSION)"		>> debian/shlibs.local.new

for SONAME in \
	"^libcairo 2" \
	"^libfbclient 2" \
	"^libsqlite 0" \
	"^libsqlite3 0" \
	"^libasound 2" \
	"^libgamin-1 0" \
	"^libcups 2" \
	"^librsvg-2 2" \
	"^libgtk-x11-2.0 0" \
	"^libgnomeui-2 0" \
	; do
	grep --no-filename "$SONAME" /var/lib/dpkg/info/*.shlibs >> debian/shlibs.local.new || echo "ERROR: could not resolve $SONAME"
done

cp debian/shlibs.local.new debian/shlibs.local

echo "done."
