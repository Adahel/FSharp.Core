// #NoMono #NoMT #CodeGen #EmittedIL #Attributes 
// EXPECTED behavior: compile to an assembly where "f" has custom attribute Microsoft.FSharp.Core.CompilationSourceNameAttribute with value "f"
[<CompiledName("SomeCompiledName")>]
let rec f x = f ( x - 1)
