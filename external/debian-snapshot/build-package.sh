#!/bin/bash
# amazeballs.sh
# Copyright 2012 Jo Shields
#
# because mono snapshots on debian are totes amazeballs
#
# Licensed under WTFPLv2


PACKAGING_ROOT="$( cd "$( dirname "$0" )" && pwd )"
BUILD_ARCH=$(dpkg-architecture -qDEB_BUILD_ARCH)
DEB_BUILD_OPTS="-us -uc"
if [ "${BUILD_ARCH}" != "amd64" ]
then
	DEB_BUILD_OPTS="-B ${DEB_BUILD_OPTS}"
else
	DEB_BUILD_OPTS="${DEB_BUILD_OPTS}"
fi

echo "Building package in ${PACKAGING_ROOT}"
cd ${PACKAGING_ROOT}/temp/* && debuild --no-lintian ${DEB_BUILD_OPTS}
