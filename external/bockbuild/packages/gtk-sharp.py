class GtkSharp212ReleasePackage (Package):

    def __init__(self):
        Package.__init__(self, 'gtk-sharp',
                         sources=['git://github.com/mono/gtk-sharp.git'],
                         git_branch='gtk-sharp-2-12-branch',
                         revision='a915b2c6726b99b58dd5c2ff79c6e825660f4416',
                         override_properties={
                             'configure': './bootstrap-2.12 --prefix=%{package_prefix}',
                         }
                         )

GtkSharp212ReleasePackage()
