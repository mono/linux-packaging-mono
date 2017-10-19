PROFILE := mono
SOURCEDIR := ../src/$(PROFILE)/
BCL_PROFILE := ../v4.7/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N IBM.Data.DB2 ICSharpCode.SharpZipLib	\
	Mono.C5 Mono.CSharp Mono.Cairo Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Options Mono.Parallel Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI RabbitMQ.Client WebMatrix.Data bare/Mono.Cecil

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
Commons.Xml.Relaxng_REFS := mscorlib System.Xml System
I18N.CJK_REFS := mscorlib
I18N.MidEast_REFS := mscorlib
I18N.Other_REFS := mscorlib
I18N.Rare_REFS := mscorlib
I18N.West_REFS := mscorlib
I18N_REFS := mscorlib
IBM.Data.DB2_REFS := mscorlib System System.Data
ICSharpCode.SharpZipLib_REFS := mscorlib System
Mono.C5_REFS := mscorlib
Mono.CSharp_REFS := mscorlib System System.Core System.Xml
Mono.Cairo_REFS := mscorlib
Mono.CodeContracts_REFS := mscorlib System.Core System
Mono.CompilerServices.SymbolWriter_REFS := mscorlib System
Mono.Data.Sqlite_REFS := mscorlib System.Data System System.Transactions
Mono.Data.Tds_REFS := mscorlib System
Mono.Debugger.Soft_REFS := mscorlib System.Core System
Mono.Http_REFS := mscorlib System System.Web System.Xml
Mono.Management_REFS := mscorlib System
Mono.Messaging.RabbitMQ_REFS := mscorlib System
Mono.Messaging_REFS := mscorlib System System.Configuration
Mono.Options_REFS := mscorlib System
Mono.Parallel_REFS := mscorlib
Mono.Posix_REFS := mscorlib System
Mono.Security.Win32_REFS := mscorlib
Mono.Security_REFS := mscorlib System
Mono.Simd_REFS := mscorlib
Mono.Tasklets_REFS := mscorlib
Mono.WebBrowser_REFS := mscorlib System
Novell.Directory.Ldap_REFS := mscorlib System
PEAPI_REFS := mscorlib
RabbitMQ.Client_REFS := mscorlib System.Xml System
WebMatrix.Data_REFS := mscorlib System.Data System.Core System System.Configuration

bare/Mono.Cecil_REFS := mscorlib

I18N.CJK_MONOREFS := I18N
I18N.MidEast_MONOREFS := I18N
I18N.Other_MONOREFS := I18N
I18N.Rare_MONOREFS := I18N
I18N.West_MONOREFS := I18N
Mono.Debugger.Soft_MONOREFS := bare/Mono.Cecil
Mono.Messaging.RabbitMQ_MONOREFS := Mono.Messaging RabbitMQ.Client

MONO_KEY := ../../../mcs/class/mono.pub         # Public Key Token: 0738eb9f132ed756

IBM.Data.DB2_KEYFILE := ../../../mcs/class/IBM.Data.DB2/ibm.pub
ICSharpCode.SharpZipLib_KEYFILE := ../../../mcs/class/ICSharpCode.SharpZipLib/SharpZipLib.pub
Mono.C5_KEYFILE := ../../../mcs/class/Mono.C5/c5.pub
RabbitMQ.Client_KEYFILE := ../../../mcs/class/msfinal.pub

MONO_KEY_ASSEMBLIES := Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N	\
	Mono.CSharp Mono.Cairo Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Options Mono.Parallel Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI WebMatrix.Data bare/Mono.Cecil

all: $(addsuffix .dll, $(ASSEMBLIES))

clean:
	rm -f *.dll
	rm -f bare/*.dll

define KEYFILE_TEMPLATE
$(1)_KEYFILE := $(2)
endef

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addprefix $(BCL_PROFILE), $(addsuffix .dll, $($(1)_REFS))) $(addsuffix .dll, $($(1)_MONOREFS)) $($(1)_KEYFILE)
	@mkdir -p bare/
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) -keyfile:$($(1)_KEYFILE) $($(1)_CSC_ARGS) $(addprefix -r:$(BCL_PROFILE), $(addsuffix .dll, $($(1)_REFS))) $(addprefix -r:, $(addsuffix .dll, $($(1)_MONOREFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(MONO_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MONO_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
