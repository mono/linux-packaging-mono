PROFILE := v4.0
SOURCEDIR := ../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := Accessibility Commons.Xml.Relaxng CustomMarshalers I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N	\
	IBM.Data.DB2 ICSharpCode.SharpZipLib Microsoft.Build.Engine Microsoft.Build.Framework Microsoft.Build.Tasks.v4.0	\
	Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC Microsoft.Web.Infrastructure	\
	Mono.C5 Mono.CSharp Mono.Cairo Mono.Cecil Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI RabbitMQ.Client System.ComponentModel.Composition	\
	System.ComponentModel.DataAnnotations System.Configuration.Install System.Configuration System.Core	\
	System.Data.DataSetExtensions System.Data.Linq System.Data.OracleClient	\
	System.Data.Services.Client System.Data.Services System.Data System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.Dynamic System.EnterpriseServices	\
	System.IdentityModel.Selectors System.IdentityModel	System.Json.Microsoft System.Json System.Management System.Messaging	\
	System.Net System.Numerics System.Runtime.Caching System.Runtime.DurableInstancing System.Runtime.Remoting	\
	System.Runtime.Serialization.Formatters.Soap System.Runtime.Serialization System.Security System.ServiceModel.Activation	\
	System.ServiceModel.Discovery System.ServiceModel.Routing System.ServiceModel.Web	\
	System.ServiceModel System.ServiceProcess System.Transactions System.Web.Abstractions	\
	System.Web.ApplicationServices System.Web.DynamicData System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Routing System.Web.Services System.Web System.Windows.Forms.DataVisualization System.Windows.Forms System.Xaml System.Xml.Linq	\
	System.Xml System WebMatrix.Data WindowsBase cscompmgd monodoc mscorlib

ASSEMBLIES += bare/System bare/System.Xml bare/System.Configuration bare/System.ServiceModel.Activation bare/System.Web

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
Microsoft.Build.Engine_REFS := mscorlib System System.Xml Microsoft.Build.Framework Microsoft.Build.Utilities.v4.0 System.Core
Microsoft.Build.Framework_REFS := mscorlib
Microsoft.Build.Tasks.v4.0_REFS := mscorlib Microsoft.Build.Utilities.v4.0 Microsoft.Build.Framework System System.Core System.Xml Microsoft.Build.Engine
Microsoft.Build.Utilities.v4.0_REFS := Microsoft.Build.Framework mscorlib System System.Xml
Microsoft.Build_REFS := mscorlib Microsoft.Build.Framework System System.Xml System.Core
Microsoft.CSharp_REFS := mscorlib Mono.CSharp System.Core
Microsoft.VisualBasic_REFS := mscorlib System System.Windows.Forms System.Drawing
Microsoft.VisualC_REFS := mscorlib
Microsoft.Web.Infrastructure_REFS := System.Web mscorlib System
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
Novell.Directory.Ldap_REFS := mscorlib System
PEAPI_REFS := mscorlib
RabbitMQ.Client_REFS := mscorlib System System.Xml
System.ComponentModel.Composition_REFS := mscorlib System.Core System
System.ComponentModel.DataAnnotations_REFS := mscorlib System System.Core
System.Configuration.Install_REFS := mscorlib System
System.Configuration_REFS := mscorlib System bare/System.Xml
System.Core_REFS := mscorlib System Mono.Posix
System.Data.DataSetExtensions_REFS := System.Data mscorlib System.Core System
System.Data.Linq_REFS := mscorlib System.Data System System.Core System.Xml System.Runtime.Serialization
System.Data.OracleClient_REFS := mscorlib System.Data System System.EnterpriseServices System.Drawing
System.Data.Services.Client_REFS := mscorlib System.Core System System.Xml System.Xml.Linq
System.Data.Services_REFS := mscorlib System.Core System System.Data.Services.Client System.ServiceModel System.ServiceModel.Web System.ServiceModel.Activation
System.Data_REFS := mscorlib System System.Xml Mono.Data.Tds System.Configuration System.Transactions System.EnterpriseServices
System.Design_REFS := mscorlib System System.Windows.Forms System.Data System.Drawing System.Xml bare/System.Web System.Configuration
System.DirectoryServices.Protocols_REFS := mscorlib System System.Xml System.DirectoryServices
System.DirectoryServices_REFS := Novell.Directory.Ldap mscorlib System
System.Drawing.Design_REFS := System.Windows.Forms System.Drawing mscorlib System
System.Drawing_REFS := mscorlib System
System.Dynamic_REFS := mscorlib System.Core System
System.EnterpriseServices_REFS := mscorlib System.Transactions
System.IdentityModel.Selectors_REFS := System.Xml mscorlib System System.IdentityModel
System.IdentityModel_REFS := mscorlib System System.Web.ApplicationServices System.Xml System.Runtime.Serialization System.Security Mono.Security
System.Json.Microsoft_REFS := System.Core mscorlib System System.Runtime.Serialization System.Xml
System.Json_REFS := mscorlib System System.Core
System.Management_REFS := mscorlib System System.Configuration.Install
System.Messaging_REFS := mscorlib Mono.Messaging System System.Configuration.Install System.Xml System.Windows.Forms System.Drawing
System.Net_REFS := mscorlib System
System.Numerics_REFS := mscorlib
System.Runtime.Caching_REFS := mscorlib System System.Core System.Configuration System.Data
System.Runtime.DurableInstancing_REFS := mscorlib System.Xml.Linq
System.Runtime.Remoting_REFS := mscorlib System.Runtime.Serialization.Formatters.Soap System System.Xml System.Web
System.Runtime.Serialization.Formatters.Soap_REFS := System.Xml mscorlib
System.Runtime.Serialization_REFS := mscorlib System.Xml System System.Configuration System.Core
System.Security_REFS := mscorlib System.Xml System Mono.Security
System.ServiceModel.Activation_REFS := mscorlib System.ServiceModel System
System.ServiceModel.Discovery_REFS := System.ServiceModel System mscorlib System.Configuration System.Runtime.Serialization System.Xml System.Xml.Linq System.Core
System.ServiceModel.Routing_REFS := System.ServiceModel mscorlib System.Runtime.Serialization System System.Configuration System.Core
System.ServiceModel.Web_REFS := System.ServiceModel mscorlib System.Runtime.Serialization System.Configuration System System.Xml System.ServiceModel.Activation System.Core System.Web.Extensions
System.ServiceModel_REFS := mscorlib System System.Runtime.Serialization System.Xml Mono.Security System.Web System.IdentityModel System.Security System.Messaging System.Core System.Transactions System.Configuration System.Web.Services System.Web.ApplicationServices bare/System.ServiceModel.Activation System.IdentityModel.Selectors
System.ServiceProcess_REFS := System mscorlib System.Configuration.Install System.Windows.Forms
System.Transactions_REFS := mscorlib System.Configuration
System.Web.Abstractions_REFS := mscorlib System.Web
System.Web.ApplicationServices_REFS := System mscorlib System.Configuration
System.Web.DynamicData_REFS := mscorlib System.Data.Linq System System.Web System.Web.Extensions System.Core System.ComponentModel.DataAnnotations System.Drawing
System.Web.Extensions.Design_REFS := mscorlib System System.Design System.Drawing
System.Web.Extensions_REFS := mscorlib System.Core System System.Web System.Web.ApplicationServices System.Configuration System.Web.Services System.Xml System.ServiceModel System.Data.Linq System.Drawing
System.Web.Routing_REFS := mscorlib System.Web
System.Web.Services_REFS := System.EnterpriseServices bare/System.Web System.Configuration mscorlib System System.Xml
System.Web_REFS := System.Drawing mscorlib System System.Xml System.Core System.Configuration System.Data System.Web.ApplicationServices System.Runtime.Serialization.Formatters.Soap System.Web.Services Mono.Data.Sqlite System.EnterpriseServices
System.Windows.Forms.DataVisualization_REFS := System.Drawing mscorlib System.Windows.Forms System System.Core System.Xml System.Data
System.Windows.Forms_REFS := mscorlib System System.Xml System.Drawing Mono.WebBrowser System.Configuration Mono.Posix System.Runtime.Serialization.Formatters.Soap Accessibility System.Data
System.Xaml_REFS := mscorlib System System.Xml System.Core
System.Xml.Linq_REFS := mscorlib System.Xml System.Core
System.Xml_REFS := mscorlib System System.Configuration
System_REFS := mscorlib Mono.Security bare/System.Configuration bare/System.Xml
WebMatrix.Data_REFS := System.Data mscorlib System.Core System System.Configuration
WindowsBase_REFS := mscorlib System System.Xml System.Xaml
cscompmgd_REFS := mscorlib System
monodoc_REFS := ICSharpCode.SharpZipLib mscorlib System System.Xml System.Xml.Linq System.Core System.Configuration
mscorlib_REFS :=

bare/System_REFS := mscorlib
bare/System.Xml_REFS := mscorlib bare/System
bare/System.Configuration_REFS := mscorlib bare/System bare/System.Xml
bare/System.ServiceModel.Activation_REFS := mscorlib System
bare/System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.Web.ApplicationServices System.ComponentModel.DataAnnotations Mono.Data.Sqlite System.EnterpriseServices

mscorlib_CSC_ARGS := -runtimemetadataversion:v4.0.30319
System_CSC_ARGS := -d:CONFIG_DEP -d:XML_DEP
System.Configuration_CSC_ARGS := -d:CONFIG_DEP
System.Xml_CSC_ARGS := -d:CONFIG_DEP
System.ServiceModel.Activation_CSC_ARGS := -d:SERVICEMODEL_DEP
System.Web_CSC_ARGS := -d:SERVICES_DEP

MONO_KEY := ../../../mcs/class/mono.pub
ECMA_KEY := ../../../mcs/class/ecma.pub
WINFX_KEY := ../../../mcs/class/winfx.pub
MSFINAL_KEY := ../../../mcs/class/msfinal.pub

Mono.C5_KEYFILE := ../../../mcs/class/Mono.C5/c5.pub
IBM.Data.DB2_KEYFILE := ../../../mcs/class/IBM.Data.DB2/ibm.pub
ICSharpCode.SharpZipLib_KEYFILE := ../../../mcs/class/ICSharpCode.SharpZipLib/SharpZipLib.pub

MONO_KEY_ASSEMBLIES := Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N Mono.CSharp	\
	Mono.Cairo Mono.Cecil Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite Mono.Data.Tds	\
	Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI monodoc WebMatrix.Data

ECMA_KEY_ASSEMBLIES := System.ComponentModel.Composition System.Core System.Data.DataSetExtensions	\
	System.Data.Linq System.Data.OracleClient System.Data.Services.Client System.Data.Services	\
	System.Data System.IdentityModel.Selectors System.IdentityModel	\
	System.Dynamic System.Numerics System.Runtime.Remoting System.Runtime.Serialization	\
	System.ServiceModel System.Transactions System.Windows.Forms System.Xaml	\
	System.Xml.Linq System.Xml System mscorlib bare/System bare/System.Xml

WINFX_KEY_ASSEMBLIES := System.ComponentModel.DataAnnotations Microsoft.Web.Infrastructure System.Json.Microsoft	\
	System.Json System.Runtime.DurableInstancing System.ServiceModel.Activation System.ServiceModel.Discovery System.ServiceModel.Routing	\
	System.ServiceModel.Web System.Web.Abstractions System.Web.ApplicationServices System.Web.DynamicData	\
	System.Web.Extensions.Design System.Web.Extensions System.Web.Routing	\
	System.Windows.Forms.DataVisualization WindowsBase bare/System.ServiceModel.Activation

MSFINAL_KEY_ASSEMBLIES := Accessibility CustomMarshalers Microsoft.Build.Engine Microsoft.Build.Framework	\
	Microsoft.Build.Tasks.v4.0 Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC	\
	RabbitMQ.Client System.Configuration.Install System.Configuration System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.EnterpriseServices System.Management	\
	System.Messaging System.Net System.Runtime.Caching	\
	System.Runtime.Serialization.Formatters.Soap System.Security System.ServiceProcess System.Web.Services	\
	System.Web cscompmgd bare/System.Configuration bare/System.Web

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

$(foreach asm, $(MONO_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MONO_KEY))))
$(foreach asm, $(ECMA_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(ECMA_KEY))))
$(foreach asm, $(WINFX_KEY_ASSEMBLIES),   $(eval $(call KEYFILE_TEMPLATE,$(asm), $(WINFX_KEY))))
$(foreach asm, $(MSFINAL_KEY_ASSEMBLIES), $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))
$(foreach asm, $(FACADE_ASSEMBLIES),      $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
