Package('xz', '5.0.4', sources=[
    'http://tukaani.org/xz/xz-%{version}.tar.bz2'],
    override_properties={'build_dependency': True}
)
