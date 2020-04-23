namespace Microsoft.FSharp.Collections

open Microsoft.FSharp.Core
open System.Collections.Generic

[<Sealed>]
type ReadOnlyDictionary<'TKey, 'TValue> =
    new : dict : IDictionary<'TKey, 'TValue> -> ReadOnlyDictionary<'TKey, 'TValue>
    interface IReadOnlyDictionary<'TKey, 'TValue>