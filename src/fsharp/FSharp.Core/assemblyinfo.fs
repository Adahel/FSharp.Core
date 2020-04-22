// Copyright (c) Microsoft Corporation.  All Rights Reserved.  See License.txt in the project root for license information.

namespace Microsoft.FSharp
open System.Reflection
open System.Resources

[<assembly: AssemblyCompany("Microsoft Corporation")>]
#if DEBUG
[<assembly: AssemblyConfiguration("Debug")>]
#else
[<assembly: AssemblyConfiguration("Release")>]
#endif
[<assembly: AssemblyCopyright("\u00A9 Microsoft Corporation.  All Rights Reserved.")>]
[<assembly: AssemblyFileVersion("4.700.20.10408")>]
[<assembly: AssemblyInformationalVersion("4.7.0-beta.20104.8+395ca17c8516208e9143d4f1188db424d2e94415")>]
[<assembly: AssemblyProduct("FSharp.Core")>]
[<assembly: AssemblyTitle("FSharp.Core")>]
[<assembly: AssemblyVersion("4.7.0.0")>]
[<assembly: NeutralResourcesLanguage("en-US")>]
do()

