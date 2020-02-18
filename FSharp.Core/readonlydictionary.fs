namespace Microsoft.FSharp.Collections

open Microsoft.FSharp.Core
open System.Collections
open System.Collections.Generic
open System.Linq

[<Sealed>]
type ReadOnlyDictionary<'TKey, 'TValue>(dict : IDictionary<'TKey, 'TValue>) =
    interface IReadOnlyDictionary<'TKey, 'TValue> with
        member __.GetEnumerator() : IEnumerator = dict.GetEnumerator() :> IEnumerator
        member __.GetEnumerator() : IEnumerator<KeyValuePair<'TKey,'TValue>> = dict.GetEnumerator()
        member __.Count = dict.Count
        member __.Item with get(key) = dict.[key]
        member __.Keys = dict.Keys.AsEnumerable()
        member __.TryGetValue(key, value) = dict.TryGetValue(key, ref value)
        member __.Values = dict.Values.AsEnumerable()
        member __.ContainsKey key = dict.ContainsKey key