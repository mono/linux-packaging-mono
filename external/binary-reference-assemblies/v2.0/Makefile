PROFILE := v2.0
SOURCEDIR := ../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := Accessibility Commons.Xml.Relaxng CustomMarshalers I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N	\
	IBM.Data.DB2 ICSharpCode.SharpZipLib Microsoft.Build.Engine Microsoft.Build.Framework Microsoft.Build.Tasks	\
	Microsoft.Build.Utilities Microsoft.VisualBasic	\
	Microsoft.VisualC Mono.C5 Mono.CSharp Mono.Cairo Mono.Cecil Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser Mono.XBuild.Tasks	\
	Novell.Directory.Ldap PEAPI RabbitMQ.Client System.ComponentModel.DataAnnotations	\
	System.Configuration.Install System.Configuration System.Core System.Data.DataSetExtensions	\
	System.Data.Linq System.Data.OracleClient System.Data.Services.Client System.Data.Services	\
	System.Data System.Design System.DirectoryServices.Protocols System.DirectoryServices	\
	System.Drawing.Design System.Drawing System.EnterpriseServices System.IdentityModel.Selectors	\
	System.IdentityModel System.Json System.Management System.Messaging System.Net System.Runtime.Remoting	\
	System.Runtime.Serialization.Formatters.Soap System.Runtime.Serialization System.Security	\
	System.ServiceModel.Web System.ServiceModel System.ServiceProcess System.Transactions	\
	System.Web.Abstractions System.Web.DynamicData System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Mvc System.Web.Routing System.Web.Services System.Web System.Windows.Forms	\
	System.Xml.Linq System.Xml System WindowsBase cscompmgd mscorlib

ASSEMBLIES += bare/System bare/System.Xml bare/System.Configuration bare/System.Web

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
Accessibility_REFS := mscorlib
Commons.Xml.Relaxng_REFS := System.Xml mscorlib System
CustomMarshalers_REFS := mscorlib
I18N.CJK_REFS := mscorlib I18N
I18N.MidEast_REFS := mscorlib I18N
I18N.Other_REFS := mscorlib I18N
I18N.Rare_REFS := mscorlib I18N
I18N.West_REFS := mscorlib I18N
I18N_REFS := mscorlib
IBM.Data.DB2_REFS := mscorlib System.Data System
ICSharpCode.SharpZipLib_REFS := mscorlib System
Microsoft.Build.Engine_REFS := mscorlib System System.Xml Microsoft.Build.Framework Microsoft.Build.Utilities System.Core
Microsoft.Build.Framework_REFS := mscorlib
Microsoft.Build.Tasks_REFS := mscorlib Microsoft.Build.Utilities Mono.XBuild.Tasks Microsoft.Build.Framework System System.Core System.Xml Microsoft.Build.Engine
Microsoft.Build.Utilities_REFS := Microsoft.Build.Framework mscorlib System
Microsoft.VisualBasic_REFS := mscorlib System System.Windows.Forms System.Drawing
Microsoft.VisualC_REFS := mscorlib
Mono.C5_REFS := mscorlib
Mono.CSharp_REFS := mscorlib System.Core System System.Xml
Mono.Cairo_REFS := mscorlib
Mono.Cecil_REFS := mscorlib
Mono.CompilerServices.SymbolWriter_REFS := mscorlib System
Mono.Data.Sqlite_REFS := mscorlib System.Data System System.Transactions
Mono.Data.Tds_REFS := mscorlib System Mono.Security
Mono.Debugger.Soft_REFS := mscorlib Mono.Cecil System.Core System
Mono.Http_REFS := System mscorlib ICSharpCode.SharpZipLib Mono.Security System.Web System.Xml
Mono.Management_REFS := mscorlib Mono.Posix System
Mono.Messaging.RabbitMQ_REFS := RabbitMQ.Client Mono.Messaging mscorlib System
Mono.Messaging_REFS := mscorlib System.Configuration System
Mono.Posix_REFS := System mscorlib
Mono.Security.Win32_REFS := mscorlib
Mono.Security_REFS := mscorlib bare/System
Mono.Simd_REFS := mscorlib System.Core
Mono.Tasklets_REFS := mscorlib
Mono.WebBrowser_REFS := mscorlib System
Mono.XBuild.Tasks_REFS := mscorlib System.Xml System
Novell.Directory.Ldap_REFS := mscorlib System
PEAPI_REFS := mscorlib
RabbitMQ.Client_REFS := mscorlib System System.Xml
System.ComponentModel.DataAnnotations_REFS := mscorlib System System.Core
System.Configuration.Install_REFS := mscorlib System
System.Configuration_REFS := mscorlib System bare/System.Xml
System.Core_REFS := mscorlib System Mono.Posix
System.Data.DataSetExtensions_REFS := System System.Data mscorlib System.Core
System.Data.Linq_REFS := mscorlib System.Data System System.Core System.Xml System.Runtime.Serialization
System.Data.OracleClient_REFS := mscorlib System.Data System.Drawing System System.EnterpriseServices
System.Data.Services.Client_REFS := mscorlib System.Core System System.Xml WindowsBase System.Xml.Linq
System.Data.Services_REFS := mscorlib System.Core System System.ServiceModel System.ServiceModel.Web
System.Data_REFS := mscorlib System System.Xml Mono.Data.Tds System.Configuration System.Transactions System.EnterpriseServices
System.Design_REFS := mscorlib System System.Windows.Forms System.Data System.Drawing System.Xml bare/System.Web System.Configuration
System.DirectoryServices.Protocols_REFS := mscorlib System System.Xml System.DirectoryServices
System.DirectoryServices_REFS := Novell.Directory.Ldap mscorlib System
System.Drawing.Design_REFS := System.Windows.Forms System.Drawing mscorlib System
System.Drawing_REFS := mscorlib System
System.EnterpriseServices_REFS := mscorlib System.Transactions
System.IdentityModel.Selectors_REFS := System.Xml mscorlib System System.IdentityModel
System.IdentityModel_REFS := mscorlib System System.Web System.Xml System.Runtime.Serialization System.Security Mono.Security
System.Json_REFS := mscorlib System System.Core
System.Management_REFS := mscorlib System System.Configuration.Install
System.Messaging_REFS := mscorlib Mono.Messaging System System.Configuration.Install System.Xml System.Windows.Forms System.Drawing
System.Net_REFS := mscorlib System
System.Runtime.Remoting_REFS := mscorlib System.Runtime.Serialization.Formatters.Soap System System.Xml System.Web
System.Runtime.Serialization.Formatters.Soap_REFS := System.Xml mscorlib
System.Runtime.Serialization_REFS := System.Configuration mscorlib System System.Xml System.Core
System.Security_REFS := mscorlib System.Xml System Mono.Security
System.ServiceModel.Web_REFS := mscorlib System.Runtime.Serialization System.Xml System System.ServiceModel System.Configuration System.Core System.Web.Extensions
System.ServiceModel_REFS := mscorlib Mono.Security System System.Xml System.Runtime.Serialization System.Core System.Messaging System.Web System.Transactions System.IdentityModel System.Security System.Configuration System.Web.Services System.IdentityModel.Selectors
System.ServiceProcess_REFS := System mscorlib System.Configuration.Install System.Windows.Forms
System.Transactions_REFS := mscorlib System.Configuration
System.Web.Abstractions_REFS := System.Web mscorlib System
System.Web.DynamicData_REFS := mscorlib System.Core System.Data.Linq System System.Web System.Web.Extensions System.Web.Routing System.ComponentModel.DataAnnotations System.Drawing System.Web.Abstractions
System.Web.Extensions.Design_REFS := mscorlib System System.Design System.Drawing
System.Web.Extensions_REFS := mscorlib System.Core System System.Web System.Configuration System.Web.Services System.Xml System.ServiceModel System.Data.Linq System.Drawing
System.Web.Mvc_REFS := mscorlib System.Core System.Web.Abstractions System.Web.Routing System.Web System.ComponentModel.DataAnnotations System System.Web.Extensions System.Data.Linq System.Xml
System.Web.Routing_REFS := mscorlib System.Web.Abstractions System System.Core System.Web
System.Web.Services_REFS := System.EnterpriseServices bare/System.Web System.Configuration mscorlib System System.Xml
System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.Runtime.Serialization.Formatters.Soap System.Web.Services Mono.Data.Sqlite System.EnterpriseServices
System.Windows.Forms_REFS := mscorlib System System.Xml System.Drawing Mono.WebBrowser System.Configuration Mono.Posix System.Runtime.Serialization.Formatters.Soap Accessibility System.Data
System.Xml.Linq_REFS := mscorlib System.Xml System.Runtime.Serialization System.Core
System.Xml_REFS := mscorlib System System.Configuration
System_REFS := mscorlib Mono.Security bare/System.Configuration bare/System.Xml
WindowsBase_REFS := System mscorlib System.Xml
cscompmgd_REFS := mscorlib System
mscorlib_REFS :=

bare/System_REFS := mscorlib
bare/System.Xml_REFS := mscorlib bare/System
bare/System.Configuration_REFS := mscorlib bare/System bare/System.Xml
bare/System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.ComponentModel.DataAnnotations Mono.Data.Sqlite System.EnterpriseServices

mscorlib_CSC_ARGS := -runtimemetadataversion:v2.0.50727
System_CSC_ARGS := -d:CONFIG_DEP -d:XML_DEP
System.Configuration_CSC_ARGS := -d:CONFIG_DEP
System.Xml_CSC_ARGS := -d:CONFIG_DEP
System.Web_CSC_ARGS := -d:SERVICES_DEP

MONO_KEY := ../../../mcs/class/mono.pub
ECMA_KEY := ../../../mcs/class/ecma.pub
WINFX_KEY := ../../../mcs/class/winfx.pub
MSFINAL_KEY := ../../../mcs/class/msfinal.pub

Mono.C5_KEYFILE := ../../../mcs/class/Mono.C5/c5.pub
IBM.Data.DB2_KEYFILE := ../../../mcs/class/IBM.Data.DB2/ibm.pub
ICSharpCode.SharpZipLib_KEYFILE := ../../../mcs/class/ICSharpCode.SharpZipLib/SharpZipLib.pub

MONO_KEY_ASSEMBLIES := Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N	\
	Mono.CSharp Mono.Cairo Mono.Cecil Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite Mono.Data.Tds	\
	Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Mono.XBuild.Tasks Novell.Directory.Ldap PEAPI

ECMA_KEY_ASSEMBLIES := System.Core System.Data.DataSetExtensions System.Data.Linq System.Data.OracleClient	\
	System.Data.Services.Client System.Data.Services System.Data System.IdentityModel.Selectors	\
	System.IdentityModel System.Net System.Runtime.Remoting System.Runtime.Serialization System.ServiceModel	\
	System.Transactions System.Windows.Forms System.Xml.Linq System.Xml System mscorlib bare/System bare/System.Xml

WINFX_KEY_ASSEMBLIES := System.ComponentModel.DataAnnotations System.Json System.ServiceModel.Web	\
	System.Web.Abstractions System.Web.DynamicData System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Mvc System.Web.Routing WindowsBase

MSFINAL_KEY_ASSEMBLIES := Accessibility CustomMarshalers Microsoft.Build.Engine Microsoft.Build.Framework	\
	Microsoft.Build.Tasks Microsoft.Build.Utilities Microsoft.VisualC Microsoft.VisualBasic RabbitMQ.Client	\
	System.Configuration.Install System.Configuration System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.EnterpriseServices System.Management	\
	System.Messaging System.Runtime.Serialization.Formatters.Soap System.Security System.ServiceProcess	\
	System.Web.Services System.Web cscompmgd bare/System.Configuration bare/System.Web

all: $(addsuffix .dll, $(ASSEMBLIES))

clean:
	rm -f *.dll
	rm -f bare/*.dll

define KEYFILE_TEMPLATE
$(1)_KEYFILE := $(2)
endef

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addsuffix .dll, $($(1)_REFS)) $($(1)_KEYFILE)
	@mkdir -p bare/
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) -keyfile:$($(1)_KEYFILE) $($(1)_CSC_ARGS) $(addprefix -r:, $(addsuffix .dll, $($(1)_REFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(MONO_KEY_ASSEMBLIES),  $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MONO_KEY))))
$(foreach asm, $(ECMA_KEY_ASSEMBLIES),  $(eval $(call KEYFILE_TEMPLATE,$(asm), $(ECMA_KEY))))
$(foreach asm, $(WINFX_KEY_ASSEMBLIES),  $(eval $(call KEYFILE_TEMPLATE,$(asm), $(WINFX_KEY))))
$(foreach asm, $(MSFINAL_KEY_ASSEMBLIES), $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
