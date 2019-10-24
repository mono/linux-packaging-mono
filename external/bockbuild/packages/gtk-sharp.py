class GtkSharp212ReleasePackage (Package):

    def __init__(self):
        Package.__init__(self, 'gtk-sharp',
                         sources=['git://github.com/mono/gtk-sharp.git'],
                         git_branch='gtk-sharp-2-12-branch',
                         revision='dedce8ddbe37ae467f18ff785255e04fd9ccd782',
                         override_properties={
                             'configure': './bootstrap-2.12 --prefix=%{package_prefix}',
                         }
                         )

GtkSharp212ReleasePackage()
