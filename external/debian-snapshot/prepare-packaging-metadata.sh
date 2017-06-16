#!/bin/bash
# amazeballs.sh
# Copyright 2012 Jo Shields
#
# because mono snapshots on debian are totes amazeballs
#
# Licensed under WTFPLv2


PACKAGING_ROOT="$( cd "$( dirname "$0" )" && pwd )"
MONO_ROOT=${PACKAGING_ROOT}/../../
BUILD_ARCH=$(dpkg-architecture -qDEB_BUILD_ARCH)
TIMESTAMP=`date --date="@$(cd mono && git log -n1 --format="%at")" +%Y%m%d%H%M%S`
GITSTAMP=`git log -n1 --format="%H"`

echo "Building debian/ folder"
rm -rf ${MONO_ROOT}/debian/
cp -r ${PACKAGING_ROOT}/debian ${MONO_ROOT}
cd ${MONO_ROOT}
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/mono-snapshot.prerm.in > debian/mono-snapshot-${TIMESTAMP}.prerm
rm -f debian/mono-snapshot.prerm.in
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/mono-snapshot.postinst.in > debian/mono-snapshot-${TIMESTAMP}.postinst
rm -f debian/mono-snapshot.postinst.in
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/control.in > debian/control
sed -i "s/%GITVER%/$GITSTAMP/g" debian/control
rm -f debian/control.in
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/environment.in > debian/${TIMESTAMP}
rm -f debian/environment.in
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/install-unmanaged.in > debian/mono-snapshot-${TIMESTAMP}.install
sed -i "s/%GITVER%/$GITSTAMP/g" debian/mono-snapshot-${TIMESTAMP}.install
rm -f debian/install-unmanaged.in
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/install-managed.in > debian/mono-snapshot-${TIMESTAMP}-assemblies.install
sed -i "s/%GITVER%/$GITSTAMP/g" debian/mono-snapshot-${TIMESTAMP}-assemblies.install
rm -f debian/install-managed.in
mkdir -p debian/runtimes.d
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/gacinstall.in > debian/runtimes.d/mono-${TIMESTAMP}
sed -i "s/%GITVER%/$GITSTAMP/g" debian/runtimes.d/mono-${TIMESTAMP}
chmod a+x debian/runtimes.d/mono-${TIMESTAMP}
rm -f debian/gacinstall.in
sed "s/%SNAPVER%/$TIMESTAMP/g" debian/rules.in > debian/rules
chmod a+x debian/rules
rm -f debian/rules.in
DEBEMAIL="Xamarin MonkeyWrench <debian@wrench.mono-project.com>" \
	dch --create --distribution unstable --package mono-snapshot-${TIMESTAMP} --newversion ${TIMESTAMP} \
	--force-distribution --empty "Git snapshot (commit ID ${GITSTAMP})"
rm -fr ${PACKAGING_ROOT}/temp
mkdir -p ${PACKAGING_ROOT}/temp
tar xf ${MONO_ROOT}/mono*tar* -C ${PACKAGING_ROOT}/temp
mv ${PACKAGING_ROOT}/temp/mono* ${PACKAGING_ROOT}/temp/mono-snapshot-${TIMESTAMP}
mv debian ${PACKAGING_ROOT}/temp/mono-snapshot-${TIMESTAMP}
cd ${MONO_ROOT}
