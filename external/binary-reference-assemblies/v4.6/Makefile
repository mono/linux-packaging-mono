PROFILE := v4.6
SOURCEDIR := ../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := Accessibility Commons.Xml.Relaxng CustomMarshalers I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N	\
	IBM.Data.DB2 ICSharpCode.SharpZipLib Microsoft.Build.Engine Microsoft.Build.Framework Microsoft.Build.Tasks.v4.0	\
	Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC Microsoft.Web.Infrastructure	\
	Mono.CSharp Mono.Cairo Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Parallel Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI RabbitMQ.Client SMDiagnostics System.ComponentModel.Composition	\
	System.ComponentModel.DataAnnotations System.Configuration.Install System.Configuration System.Core	\
	System.Data.DataSetExtensions System.Data.Entity System.Data.Linq System.Data.OracleClient	\
	System.Data.Services.Client System.Data.Services System.Data System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.Dynamic System.EnterpriseServices	\
	System.IO.Compression.FileSystem System.IO.Compression System.IdentityModel.Selectors System.IdentityModel	\
	System.Json.Microsoft System.Json System.Management System.Messaging System.Net.Http.Formatting	\
	System.Net.Http.WebRequest System.Net.Http System.Net System.Numerics System.Reactive.Core System.Reactive.Debugger	\
	System.Reactive.Experimental System.Reactive.Interfaces System.Reactive.Linq System.Reactive.Observable.Aliases	\
	System.Reactive.PlatformServices System.Reactive.Providers System.Reactive.Runtime.Remoting System.Reactive.Windows.Forms	\
	System.Reactive.Windows.Threading System.Runtime.Caching System.Runtime.DurableInstancing System.Runtime.Remoting	\
	System.Runtime.Serialization.Formatters.Soap System.Runtime.Serialization System.Security System.ServiceModel.Activation	\
	System.ServiceModel.Discovery System.ServiceModel.Internals System.ServiceModel.Routing System.ServiceModel.Web	\
	System.ServiceModel System.ServiceProcess System.Threading.Tasks.Dataflow System.Transactions System.Web.Abstractions	\
	System.Web.ApplicationServices System.Web.DynamicData System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Http.SelfHost System.Web.Http.WebHost System.Web.Http System.Web.Mvc System.Web.Razor System.Web.Routing	\
	System.Web.Services System.Web.WebPages.Deployment System.Web.WebPages.Razor System.Web.WebPages System.Web	\
	System.Windows.Forms.DataVisualization System.Windows.Forms System.Windows System.Xaml System.Xml.Linq	\
	System.Xml.Serialization System.Xml System WebMatrix.Data WindowsBase cscompmgd mscorlib	\
	System.Deployment System.Numerics.Vectors System.Reflection.Context System.Runtime.InteropServices.RuntimeInformation	\
	System.Web.Mobile System.Web.RegularExpressions System.Workflow.Activities System.Workflow.ComponentModel System.Workflow.Runtime

ASSEMBLIES += bare/System bare/System.Xml bare/System.Configuration bare/System.ServiceModel.Activation bare/System.Web bare/Mono.Cecil

FACADE_ASSEMBLIES := Facades/System.Collections.Concurrent Facades/System.Net.Primitives Facades/System.Runtime	\
	Facades/System.Collections Facades/System.Net.Requests Facades/System.Security.Principal	\
	Facades/System.ComponentModel.Annotations Facades/System.ObjectModel Facades/System.ServiceModel.Duplex	\
	Facades/System.ComponentModel.EventBasedAsync Facades/System.Reflection.Emit.ILGeneration Facades/System.ServiceModel.Http	\
	Facades/System.ComponentModel Facades/System.Reflection.Emit.Lightweight Facades/System.ServiceModel.NetTcp	\
	Facades/System.Diagnostics.Contracts Facades/System.Reflection.Emit Facades/System.ServiceModel.Primitives	\
	Facades/System.Diagnostics.Debug Facades/System.Reflection.Extensions Facades/System.ServiceModel.Security	\
	Facades/System.Diagnostics.Tools Facades/System.Reflection.Primitives Facades/System.Text.Encoding.Extensions	\
	Facades/System.Diagnostics.Tracing Facades/System.Reflection Facades/System.Text.Encoding	\
	Facades/System.Dynamic.Runtime Facades/System.Resources.ResourceManager Facades/System.Text.RegularExpressions	\
	Facades/System.Globalization Facades/System.Runtime.Extensions Facades/System.Threading.Tasks.Parallel	\
	Facades/System.IO Facades/System.Runtime.InteropServices.WindowsRuntime Facades/System.Threading.Tasks	\
	Facades/System.Linq.Expressions Facades/System.Runtime.InteropServices Facades/System.Threading.Timer	\
	Facades/System.Linq.Parallel Facades/System.Runtime.Numerics Facades/System.Threading	\
	Facades/System.Linq.Queryable Facades/System.Runtime.Serialization.Json Facades/System.Xml.ReaderWriter	\
	Facades/System.Linq Facades/System.Runtime.Serialization.Primitives Facades/System.Xml.XDocument	\
	Facades/System.Net.NetworkInformation Facades/System.Runtime.Serialization.Xml Facades/System.Xml.XmlSerializer	\
	Facades/System.Net.WebHeaderCollection Facades/System.Runtime.Handles

ASSEMBLIES += $(FACADE_ASSEMBLIES)

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
Accessibility_REFS := mscorlib
Commons.Xml.Relaxng_REFS := mscorlib System.Xml System
CustomMarshalers_REFS := mscorlib
I18N.CJK_REFS := mscorlib I18N
I18N.MidEast_REFS := mscorlib I18N
I18N.Other_REFS := mscorlib I18N
I18N.Rare_REFS := mscorlib I18N
I18N.West_REFS := mscorlib I18N
I18N_REFS := mscorlib
IBM.Data.DB2_REFS := mscorlib System System.Data
ICSharpCode.SharpZipLib_REFS := mscorlib System
Microsoft.Build.Engine_REFS := mscorlib System.Xml Microsoft.Build.Framework Microsoft.Build.Utilities.v4.0 System System.Core
Microsoft.Build.Framework_REFS := mscorlib System
Microsoft.Build.Tasks.v4.0_REFS := mscorlib Microsoft.Build.Framework Microsoft.Build.Utilities.v4.0 System Microsoft.Build.Engine System.Xml System.Core
Microsoft.Build.Utilities.v4.0_REFS := mscorlib Microsoft.Build.Framework System System.Xml
Microsoft.Build_REFS := mscorlib Microsoft.Build.Framework System.Xml System System.Core
Microsoft.CSharp_REFS := mscorlib System System.Core
Microsoft.VisualBasic_REFS := mscorlib System System.Windows.Forms System.Drawing
Microsoft.VisualC_REFS := mscorlib
Microsoft.Web.Infrastructure_REFS := mscorlib System System.Web
Mono.CSharp_REFS := mscorlib System System.Core System.Xml
Mono.Cairo_REFS := mscorlib
Mono.CodeContracts_REFS := mscorlib System.Core System
Mono.CompilerServices.SymbolWriter_REFS := mscorlib System
Mono.Data.Sqlite_REFS := mscorlib System.Data System System.Transactions
Mono.Data.Tds_REFS := mscorlib Mono.Security System
Mono.Debugger.Soft_REFS := mscorlib System.Core System bare/Mono.Cecil
Mono.Http_REFS := mscorlib System ICSharpCode.SharpZipLib Mono.Security System.Web System.Xml
Mono.Management_REFS := mscorlib System Mono.Posix
Mono.Messaging.RabbitMQ_REFS := mscorlib Mono.Messaging RabbitMQ.Client System
Mono.Messaging_REFS := mscorlib System System.Configuration
Mono.Parallel_REFS := mscorlib
Mono.Posix_REFS := mscorlib System
Mono.Security.Win32_REFS := mscorlib
Mono.Security_REFS := mscorlib bare/System
Mono.Simd_REFS := mscorlib
Mono.Tasklets_REFS := mscorlib
Mono.WebBrowser_REFS := mscorlib System
Novell.Directory.Ldap_REFS := mscorlib System
PEAPI_REFS := mscorlib
RabbitMQ.Client_REFS := mscorlib System.Xml System
SMDiagnostics_REFS := mscorlib System.Configuration System System.Xml System.ServiceModel.Internals
System.ComponentModel.Composition_REFS := mscorlib System System.Core
System.ComponentModel.DataAnnotations_REFS := mscorlib System System.Core
System.Configuration.Install_REFS := mscorlib System
System.Configuration_REFS := mscorlib bare/System.Xml System
System.Core_REFS := mscorlib System Mono.Posix
System.Data.DataSetExtensions_REFS := mscorlib System.Data System System.Core
System.Data.Entity_REFS := mscorlib System.Core System System.Data System.Runtime.Serialization System.ComponentModel.DataAnnotations System.Xml System.Xml.Linq System.Transactions System.Configuration
System.Data.Linq_REFS := mscorlib System.Data System.Core System System.Xml System.Runtime.Serialization
System.Data.OracleClient_REFS := mscorlib System.Data System System.Drawing System.EnterpriseServices System.Transactions
System.Data.Services.Client_REFS := mscorlib System System.Xml System.Core System.Xml.Linq
System.Data.Services_REFS := mscorlib System.Configuration System.ServiceModel System.ServiceModel.Web System System.ServiceModel.Activation System.Core System.Data.Services.Client
System.Data_REFS := mscorlib System.Configuration System.Xml System System.Numerics System.Core System.Transactions Mono.Data.Tds System.EnterpriseServices
System.Deployment_REFS := mscorlib
System.Design_REFS := mscorlib System.Drawing System.Drawing.Design System System.Windows.Forms System.Data bare/System.Web System.Configuration System.Xml
System.DirectoryServices.Protocols_REFS := mscorlib System.Xml System System.DirectoryServices
System.DirectoryServices_REFS := mscorlib Novell.Directory.Ldap System
System.Drawing.Design_REFS := mscorlib System.Drawing System.Windows.Forms System
System.Drawing_REFS := mscorlib System
System.Dynamic_REFS := mscorlib System.Core System
System.EnterpriseServices_REFS := mscorlib System.Transactions
System.IO.Compression.FileSystem_REFS := mscorlib System.IO.Compression System
System.IO.Compression_REFS := mscorlib System
System.IdentityModel.Selectors_REFS := mscorlib System.Xml System System.IdentityModel
System.IdentityModel_REFS := mscorlib System.Configuration System.Runtime.Serialization System.Security System System.Xml Mono.Security System.Web.ApplicationServices
System.Json.Microsoft_REFS := mscorlib System.Runtime.Serialization System System.Xml System.Core
System.Json_REFS := mscorlib System System.Core
System.Management_REFS := mscorlib System System.Configuration.Install
System.Messaging_REFS := mscorlib System Mono.Messaging System.Drawing System.Configuration.Install System.Xml System.Windows.Forms
System.Net.Http.Formatting_REFS := mscorlib System System.Xml System.Xml.Linq System.Runtime.Serialization System.Core System.Data System.Net.Http System.Configuration
System.Net.Http.WebRequest_REFS := mscorlib System.Net.Http System
System.Net.Http_REFS := mscorlib System System.Core
System.Net_REFS := mscorlib System
System.Numerics.Vectors_REFS := mscorlib System.Numerics
System.Numerics_REFS := mscorlib
System.Reactive.Core_REFS := mscorlib System System.Reactive.Interfaces System.Core
System.Reactive.Debugger_REFS := mscorlib System.Reactive.Linq
System.Reactive.Experimental_REFS := mscorlib System.Reactive.Linq System.Reactive.Core System.Core System.Reactive.Interfaces System
System.Reactive.Interfaces_REFS := mscorlib System.Core
System.Reactive.Linq_REFS := mscorlib System.Core System System.Reactive.Interfaces System.Reactive.Core
System.Reactive.Observable.Aliases_REFS := mscorlib System.Reactive.Interfaces System.Core System.Reactive.Providers System.Reactive.Linq
System.Reactive.PlatformServices_REFS := mscorlib System System.Reactive.Core System.Reactive.Interfaces System.Core System.Reactive.Linq
System.Reactive.Providers_REFS := mscorlib System.Core System.Reactive.Interfaces System System.Reactive.Core System.Reactive.Linq
System.Reactive.Runtime.Remoting_REFS := mscorlib System.Reactive.Interfaces System.Reactive.Core System.Core
System.Reactive.Windows.Forms_REFS := mscorlib System.Reactive.Core System.Reactive.Interfaces System.Windows.Forms
System.Reactive.Windows.Threading_REFS := mscorlib System System.Reactive.Core System.Reactive.Interfaces WindowsBase
System.Reflection.Context_REFS := mscorlib
System.Reflection.Metadata_REFS := System.Runtime System.Resources.ResourceManager System.Collections.Immutable System.Reflection.Primitives System.Diagnostics.Debug System.Collections System.IO System.IO.Compression System.Text.Encoding System.Runtime.InteropServices System.Linq System.Reflection System.Threading System.Runtime.Extensions System.Text.Encoding.Extensions System.Reflection.Extensions
System.Runtime.Caching_REFS := mscorlib System System.Data System.Configuration
System.Runtime.DurableInstancing_REFS := mscorlib System.Xml.Linq System.ServiceModel.Internals System.Transactions System.Core System.Runtime.Serialization System
System.Runtime.InteropServices.RuntimeInformation_REFS := mscorlib
System.Runtime.Remoting_REFS := mscorlib System System.Web System.Xml System.Runtime.Serialization.Formatters.Soap
System.Runtime.Serialization.Formatters.Soap_REFS := mscorlib System.Xml
System.Runtime.Serialization_REFS := mscorlib System.Xml System.ServiceModel.Internals System System.Configuration System.Core
System.Security_REFS := mscorlib System System.Xml Mono.Security
System.ServiceModel.Activation_REFS := mscorlib System.ServiceModel System System.Web
System.ServiceModel.Discovery_REFS := mscorlib System.ServiceModel System System.Xml System.Xml.Linq System.Runtime.Serialization System.Configuration System.Core
System.ServiceModel.Internals_REFS := mscorlib System System.Xml
System.ServiceModel.Routing_REFS := mscorlib System.ServiceModel System.Configuration System System.Runtime.Serialization
System.ServiceModel.Web_REFS := mscorlib System.ServiceModel System System.Runtime.Serialization System.Xml System.Xml.Linq System.Configuration System.ServiceModel.Activation System.Core System.Web.Extensions
System.ServiceModel_REFS := mscorlib System.Xml System.Xml.Linq System.Xaml System System.EnterpriseServices System.Transactions System.IdentityModel System.Runtime.Serialization System.Runtime.DurableInstancing System.Security System.Web.ApplicationServices System.Messaging System.Net.Http System.IdentityModel.Selectors System.Web.Services System.Configuration System.Web System.Core bare/System.ServiceModel.Activation
System.ServiceProcess_REFS := mscorlib System System.Configuration.Install System.Windows.Forms
System.Threading.Tasks.Dataflow_REFS := mscorlib System.Core System
System.Transactions_REFS := mscorlib System.Configuration
System.Web.Abstractions_REFS := mscorlib System.Web
System.Web.ApplicationServices_REFS := mscorlib System System.Configuration
System.Web.DynamicData_REFS := mscorlib System System.Drawing System.Web System.Web.Extensions System.Core System.ComponentModel.DataAnnotations System.Data.Linq
System.Web.Extensions.Design_REFS := mscorlib System System.Design System.Drawing System.Web.Extensions
System.Web.Extensions_REFS := mscorlib System.Web System System.Xml System.Drawing System.Data.Linq System.Web.Services System.ServiceModel System.ServiceModel.Activation System.Runtime.Serialization System.Web.ApplicationServices System.Core System.Configuration
System.Web.Http.SelfHost_REFS := mscorlib System System.ServiceModel System.Net.Http System.Core System.Web.Http System.IdentityModel System.Runtime.Serialization System.Net.Http.Formatting System.Configuration System.Xml
System.Web.Http.WebHost_REFS := mscorlib System.Web System.Core System System.Net.Http System.Web.Http System.Xml Microsoft.Web.Infrastructure
System.Web.Http_REFS := mscorlib System System.Net.Http System.Net.Http.Formatting System.Core System.ComponentModel.DataAnnotations System.Runtime.Serialization System.Xml System.Data.Linq
System.Web.Mobile_REFS := mscorlib
System.Web.Mvc_REFS := mscorlib System.Web System System.Core System.ComponentModel.DataAnnotations System.Web.Extensions System.Web.WebPages.Razor System.Runtime.Caching System.Web.WebPages System.Xml System.Web.Razor System.Data.Linq Microsoft.Web.Infrastructure
System.Web.Razor_REFS := mscorlib System System.Core
System.Web.RegularExpressions_REFS := mscorlib System
System.Web.Routing_REFS := mscorlib System.Web
System.Web.Services_REFS := mscorlib System System.Configuration System.EnterpriseServices System.Xml bare/System.Web System.DirectoryServices System.Design System.Data
System.Web.WebPages.Deployment_REFS := mscorlib System.Web System System.Configuration System.Core Microsoft.Web.Infrastructure
System.Web.WebPages.Razor_REFS := mscorlib System.Web System System.Web.Razor System.Configuration System.Core System.Web.WebPages
System.Web.WebPages_REFS := mscorlib System.Web System System.Core System.Xml.Linq System.Web.Razor System.ComponentModel.DataAnnotations System.Data.Linq Microsoft.Web.Infrastructure Microsoft.CSharp System.Web.WebPages.Deployment
System.Web_REFS := mscorlib System.Configuration System.Xml System System.Data System.Drawing System.Runtime.Serialization.Formatters.Soap System.Core System.EnterpriseServices System.Web.ApplicationServices Mono.Data.Sqlite System.ComponentModel.DataAnnotations System.Web.Services
System.Windows.Forms.DataVisualization_REFS := mscorlib System.Drawing System.Windows.Forms System System.Xml System.Data System.Core
System.Windows.Forms_REFS := mscorlib System System.Xml System.Drawing System.Runtime.Serialization.Formatters.Soap Accessibility Mono.WebBrowser System.Configuration Mono.Posix System.Data
System.Windows_REFS := mscorlib System
System.Workflow.Activities_REFS := mscorlib
System.Workflow.ComponentModel_REFS := mscorlib
System.Workflow.Runtime_REFS := mscorlib
System.Xaml_REFS := mscorlib System System.Xml System.Core
System.Xml.Linq_REFS := mscorlib System System.Runtime.Serialization System.Xml System.Core
System.Xml.Serialization_REFS := mscorlib System.ServiceModel System.Xml
System.Xml_REFS := mscorlib System System.Configuration
System_REFS := mscorlib Mono.Security bare/System.Configuration bare/System.Xml
WebMatrix.Data_REFS := mscorlib System.Data System.Core System System.Configuration
WindowsBase_REFS := mscorlib System.Xaml System System.Xml System.Security
cscompmgd_REFS := mscorlib System
mscorlib_REFS :=

bare/System_REFS := mscorlib
bare/System.Xml_REFS := mscorlib bare/System
bare/System.Configuration_REFS := mscorlib bare/System bare/System.Xml
bare/System.ServiceModel.Activation_REFS := mscorlib System
bare/System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.Web.ApplicationServices System.ComponentModel.DataAnnotations Mono.Data.Sqlite System.EnterpriseServices
bare/Mono.Cecil_REFS := mscorlib

Facades/System.Collections.Concurrent_REFS := mscorlib System
Facades/System.Collections_REFS := mscorlib System.Core System
Facades/System.ComponentModel.Annotations_REFS := mscorlib System.ComponentModel.DataAnnotations
Facades/System.ComponentModel.EventBasedAsync_REFS := mscorlib System
Facades/System.ComponentModel_REFS := mscorlib System
Facades/System.Diagnostics.Contracts_REFS := mscorlib
Facades/System.Diagnostics.Debug_REFS := mscorlib System
Facades/System.Diagnostics.Tools_REFS := mscorlib System
Facades/System.Diagnostics.Tracing_REFS := mscorlib
Facades/System.Dynamic.Runtime_REFS := mscorlib System.Core
Facades/System.Globalization_REFS := mscorlib
Facades/System.IO_REFS := mscorlib System
Facades/System.Linq.Expressions_REFS := mscorlib System.Core
Facades/System.Linq.Parallel_REFS := mscorlib System.Core
Facades/System.Linq.Queryable_REFS := mscorlib System.Core
Facades/System.Linq_REFS := mscorlib System.Core
Facades/System.Net.NetworkInformation_REFS := mscorlib System
Facades/System.Net.Primitives_REFS := mscorlib System
Facades/System.Net.Requests_REFS := mscorlib System
Facades/System.Net.WebHeaderCollection_REFS := mscorlib System
Facades/System.ObjectModel_REFS := mscorlib System
Facades/System.Reflection.Emit.ILGeneration_REFS := mscorlib
Facades/System.Reflection.Emit.Lightweight_REFS := mscorlib
Facades/System.Reflection.Emit_REFS := mscorlib
Facades/System.Reflection.Extensions_REFS := mscorlib
Facades/System.Reflection.Primitives_REFS := mscorlib
Facades/System.Reflection_REFS := mscorlib
Facades/System.Resources.ResourceManager_REFS := mscorlib
Facades/System.Runtime.Extensions_REFS := mscorlib System
Facades/System.Runtime.Handles_REFS := mscorlib System.Core
Facades/System.Runtime.InteropServices.WindowsRuntime_REFS := mscorlib
Facades/System.Runtime.InteropServices_REFS := mscorlib System.Core System
Facades/System.Runtime.Numerics_REFS := mscorlib System.Numerics
Facades/System.Runtime.Serialization.Json_REFS := mscorlib System.Runtime.Serialization
Facades/System.Runtime.Serialization.Primitives_REFS := mscorlib System.Runtime.Serialization
Facades/System.Runtime.Serialization.Xml_REFS := mscorlib System.Runtime.Serialization System Facades/System.Runtime.Serialization.Primitives
Facades/System.Runtime_REFS := mscorlib System.Core System System.ComponentModel.Composition
Facades/System.Security.Principal_REFS := mscorlib
Facades/System.ServiceModel.Duplex_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.Http_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.NetTcp_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.Primitives_REFS := mscorlib System.IdentityModel System.ServiceModel
Facades/System.ServiceModel.Security_REFS := mscorlib System.ServiceModel
Facades/System.Text.Encoding.Extensions_REFS := mscorlib
Facades/System.Text.Encoding_REFS := mscorlib
Facades/System.Text.RegularExpressions_REFS := mscorlib System
Facades/System.Threading.Tasks.Parallel_REFS := mscorlib
Facades/System.Threading.Tasks_REFS := mscorlib System.Core
Facades/System.Threading.Timer_REFS := mscorlib
Facades/System.Threading_REFS := mscorlib System System.Core
Facades/System.Xml.ReaderWriter_REFS := mscorlib System.Xml
Facades/System.Xml.XDocument_REFS := mscorlib System.Xml.Linq
Facades/System.Xml.XmlSerializer_REFS := mscorlib System.Xml

mscorlib_CSC_ARGS := -runtimemetadataversion:v4.0.30319
System_CSC_ARGS := -d:CONFIG_DEP -d:XML_DEP
System.Configuration_CSC_ARGS := -d:CONFIG_DEP
System.Xml_CSC_ARGS := -d:CONFIG_DEP
System.ServiceModel.Activation_CSC_ARGS := -d:SERVICEMODEL_DEP -d:WEB_DEP
System.Web_CSC_ARGS := -d:SERVICES_DEP

MONO_KEY := ../../../mcs/class/mono.pub         # Public Key Token: 0738eb9f132ed756
ECMA_KEY := ../../../mcs/class/ecma.pub         # Public Key Token: b77a5c561934e089
WINFX_KEY := ../../../mcs/class/winfx.pub       # Public Key Token: 31bf3856ad364e35
MSFINAL_KEY := ../../../mcs/class/msfinal.pub   # Public Key Token: b03f5f7f11d50a3a

IBM.Data.DB2_KEYFILE := ../../../mcs/class/IBM.Data.DB2/ibm.pub
ICSharpCode.SharpZipLib_KEYFILE := ../../../mcs/class/ICSharpCode.SharpZipLib/SharpZipLib.pub

MONO_KEY_ASSEMBLIES := Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N Mono.CSharp	\
	Mono.Cairo Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite Mono.Data.Tds	\
	Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging Mono.Parallel	\
	Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI WebMatrix.Data bare/Mono.Cecil

ECMA_KEY_ASSEMBLIES := SMDiagnostics System.ComponentModel.Composition System.Core System.Data.DataSetExtensions	\
	System.Data.Entity System.Data.Linq System.Data.OracleClient System.Data.Services.Client System.Data.Services	\
	System.Data System.IO.Compression.FileSystem System.IO.Compression System.IdentityModel.Selectors System.IdentityModel	\
	System.Numerics System.Reflection.Context System.Runtime.Remoting System.Runtime.Serialization System.ServiceModel.Internals	\
	System.ServiceModel System.Threading.Tasks.Dataflow System.Transactions System.Windows.Forms System.Xaml	\
	System.Xml.Linq System.Xml.Serialization System.Xml System mscorlib bare/System bare/System.Xml

WINFX_KEY_ASSEMBLIES := System.ComponentModel.DataAnnotations Microsoft.Web.Infrastructure System.Json.Microsoft	\
	System.Json System.Net.Http.Formatting System.Reactive.Core System.Reactive.Debugger System.Reactive.Experimental	\
	System.Reactive.Interfaces System.Reactive.Linq System.Reactive.Observable.Aliases System.Reactive.PlatformServices	\
	System.Reactive.Providers System.Reactive.Runtime.Remoting System.Reactive.Windows.Forms System.Reactive.Windows.Threading	\
	System.Runtime.DurableInstancing System.ServiceModel.Activation System.ServiceModel.Discovery System.ServiceModel.Routing	\
	System.ServiceModel.Web System.Web.Abstractions System.Web.ApplicationServices System.Web.DynamicData	\
	System.Web.Extensions.Design System.Web.Extensions System.Web.Http.SelfHost System.Web.Http.WebHost System.Web.Http	\
	System.Web.Mvc System.Web.Razor System.Web.Routing System.Web.WebPages.Deployment System.Web.WebPages.Razor	\
	System.Web.WebPages System.Windows.Forms.DataVisualization System.Workflow.Activities System.Workflow.ComponentModel System.Workflow.Runtime	\
	WindowsBase bare/System.ServiceModel.Activation

MSFINAL_KEY_ASSEMBLIES := Accessibility CustomMarshalers Microsoft.Build.Engine Microsoft.Build.Framework	\
	Microsoft.Build.Tasks.v4.0 Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC	\
	RabbitMQ.Client System.Configuration.Install System.Configuration System.Deployment System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.Dynamic System.EnterpriseServices System.Management	\
	System.Messaging System.Net.Http.WebRequest System.Net.Http System.Net System.Numerics.Vectors System.Runtime.Caching	\
	System.Runtime.InteropServices.RuntimeInformation System.Runtime.Serialization.Formatters.Soap System.Security System.ServiceProcess System.Web.Services	\
	System.Web System.Web.Mobile System.Web.RegularExpressions System.Windows cscompmgd bare/System.Configuration bare/System.Web

all: $(addsuffix .dll, $(ASSEMBLIES))

clean:
	rm -f *.dll
	rm -f bare/*.dll
	rm -f Facades/*.dll

define KEYFILE_TEMPLATE
$(1)_KEYFILE := $(2)
endef

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addsuffix .dll, $($(1)_REFS)) $($(1)_KEYFILE)
	@mkdir -p bare/
	@mkdir -p Facades/
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) -keyfile:$($(1)_KEYFILE) $($(1)_CSC_ARGS) $(addprefix -r:, $(addsuffix .dll, $($(1)_REFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(MONO_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MONO_KEY))))
$(foreach asm, $(ECMA_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(ECMA_KEY))))
$(foreach asm, $(WINFX_KEY_ASSEMBLIES),   $(eval $(call KEYFILE_TEMPLATE,$(asm), $(WINFX_KEY))))
$(foreach asm, $(MSFINAL_KEY_ASSEMBLIES), $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))
$(foreach asm, $(FACADE_ASSEMBLIES),      $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
