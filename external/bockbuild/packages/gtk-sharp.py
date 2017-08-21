class GtkSharp212ReleasePackage (Package):

    def __init__(self):
        Package.__init__(self, 'gtk-sharp',
                         sources=['git://github.com/mono/gtk-sharp.git'],
                         git_branch='gtk-sharp-2-12-branch',
                         revision='43d38a806de8efe62a09a3284178880f2ae36a56',
                         override_properties={
                             'configure': './bootstrap-2.12 --prefix=%{package_prefix}',
                         }
                         )
        self.make = 'make CSC=mcs'

GtkSharp212ReleasePackage()
