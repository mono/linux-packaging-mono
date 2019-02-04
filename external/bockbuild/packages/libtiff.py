class LibTiffPackage (Package):

    def __init__(self):
        Package.__init__(self, 'tiff', '4.0.9',
                         configure_flags=[
                         ],
                         sources=[
                             'http://download.osgeo.org/libtiff/tiff-%{version}.tar.gz',
                         ])

        self.needs_lipo = True

LibTiffPackage()
