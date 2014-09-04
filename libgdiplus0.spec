#
# spec file for package libgdiplus0
#
# Copyright (c) 2013 SUSE LINUX Products GmbH, Nuernberg, Germany.
#
# All modifications and additions to the file contributed by third parties
# remain the property of their copyright owners, unless otherwise agreed
# upon. The license for this file, and modifications and additions to the
# file, is the same license as for the pristine package itself (unless the
# license for the pristine package is not an Open Source License, in which
# case the license is the MIT License). An "Open Source License" is a
# license that conforms to the Open Source Definition (Version 1.9)
# published by the Open Source Initiative.

# Please submit bugfixes or comments via http://bugs.opensuse.org/
#


%define real_name libgdiplus

Name:           libgdiplus0
Version:        3.8
Release:        0
Url:            http://go-mono.org/
Source0:        http://download.mono-project.com/sources/%{real_name}/%{real_name}-%{version}.tar.gz
Summary:        Open Source Implementation of the GDI+ API
License:        (LGPL-2.1+ or MPL-1.1) and MIT
Group:          Development/Libraries/Other
BuildRoot:      %{_tmppath}/%{name}-%{version}-build
Provides:       libgdiplus
BuildRequires:  autoconf
BuildRequires:  automake
BuildRequires:  libtool
%if 0%{?fedora} || 0%{?rhel} || 0%{?centos}
BuildRequires:  pkgconfig
%else
BuildRequires:  pkg-config
%endif
BuildRequires:  cairo-devel >= 1.6.4
BuildRequires:  fontconfig-devel
%if 0%{?fedora} || 0%{?rhel} || 0%{?centos}
BuildRequires:  freetype-devel
%else
BuildRequires:  freetype2-devel
%endif
BuildRequires:  giflib-devel
BuildRequires:  glib2-devel
BuildRequires:  libexif-devel
BuildRequires:  libjpeg-devel
BuildRequires:  libpng-devel
BuildRequires:  libtiff-devel
%if 0%{?fedora} || 0%{?rhel} || 0%{?centos}
BuildRequires:  libXrender-devel
BuildRequires:  libX11-devel
%else
BuildRequires:  xorg-x11-devel
BuildRequires:  xorg-x11-libXrender-devel
%endif

%description
Mono library that provide a GDI+ comptible API on non-Windows
operating systems.

%package -n     libgdiplus-devel
Summary:        Development files for libgdiplus
Group:          Development/Libraries/C and C++
Requires:       libgdiplus0 = %{version}
Provides:       pkgconfig(libgdiplus)

%description -n libgdiplus-devel
This library is part of the Mono project. It is required when
using System.Drawing.

%prep
%setup -q -n %{real_name}-%{version}

%build
autoreconf -fiv
%{?env_options}
%configure
make

%install
make install DESTDIR=%{buildroot}

# Remove generic non-usefull INSTALL file...
# (appeases suse rpmlint checks, saves 3kb)
find . -name INSTALL | xargs rm -f

%post -p /sbin/ldconfig

%postun -p /sbin/ldconfig

%files
%defattr(-, root, root)
%{_libdir}/libgdiplus.so*
%doc AUTHORS COPYING ChangeLog* NEWS README

%files -n libgdiplus-devel
%defattr(-, root, root)
%{_libdir}/pkgconfig/libgdiplus.pc
%{_libdir}/libgdiplus.a
# Unwanted statically linked files:
%exclude %{_libdir}/libgdiplus.la

%changelog

