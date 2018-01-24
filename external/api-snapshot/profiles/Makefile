
CSC=csc -nostdlib -noconfig -unsafe -t:library -nologo -deterministic -publicsign -nowarn:436,618,809,3001
ECMA_KEY:=ecma.pub
MS_KEY:=msfinal.pub
MOBILE_KEY:=silverlight.pub

all: build-net_4_x build-mobile-monotouch build-mobile-monodroid

build-mobile-%:
	$(CSC) $*/mscorlib.cs /out:$*/mscorlib.dll -runtimemetadataversion:v4.0.30319 -keyfile:$(MOBILE_KEY)
	$(CSC) $*/System.cs /out:$*/System.dll -keyfile:$(MOBILE_KEY) -r:$*/mscorlib.dll /r:System.Xml.dll
	$(CSC) $*/System.Core.cs /out:$*/System.Core.dll -keyfile:$(MOBILE_KEY) -r:$*/mscorlib.dll -r:$*/System.dll
	$(CSC) $*/System.Net.Http.cs /out:$*/System.Net.Http.dll -keyfile:$(MS_KEY) -r:$*/mscorlib.dll -r:$*/System.Core.dll -r:$*/System.dll
	$(CSC) $*/System.Numerics.cs /out:$*/System.Numerics.dll -keyfile:$(ECMA_KEY) -r:$*/mscorlib.dll -r:System.dll

build-%:
	$(CSC) $*/mscorlib.cs /out:$*/mscorlib.dll -runtimemetadataversion:v4.0.30319 -keyfile:$(ECMA_KEY)
	$(CSC) $*/System.cs /out:$*/System.dll -keyfile:$(ECMA_KEY) -r:$*/mscorlib.dll /r:System.Configuration.dll /r:System.Xml.dll
	$(CSC) $*/System.Core.cs /out:$*/System.Core.dll -keyfile:$(ECMA_KEY) -r:$*/mscorlib.dll -r:System.dll
	$(CSC) $*/System.Net.Http.cs /out:$*/System.Net.Http.dll -keyfile:$(MS_KEY) -r:$*/mscorlib.dll -r:$*/System.Core.dll -r:System.dll
	$(CSC) $*/System.Numerics.cs /out:$*/System.Numerics.dll -keyfile:$(ECMA_KEY) -r:$*/mscorlib.dll -r:System.dll
