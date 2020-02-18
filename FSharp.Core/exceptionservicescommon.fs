namespace System.Runtime.ExceptionServices

open System
open Microsoft.FSharp.Core
open System.Text
open System.Reflection

/// <summary>
///     The ExceptionDispatchInfo object stores the stack trace information and Watson information that the exception
///     contains at the point where it is captured. The exception can be thrown at another time and possibly on another
///     thread by calling the ExceptionDispatchInfo.Throw method. The exception is thrown as if it had flowed from the
///     point where it was captured to the point where the Throw method is called.
/// </summary>
[<Sealed;AllowNullLiteral>]
type ExceptionDispatchInfo private(exc : exn) =

    let _stackTrace = exc.StackTrace
    static member val private _remoteStackTraceString : FieldInfo = null with get, set

    /// <summary>
    ///     Gets the exception that is represented by the current instance.
    /// </summary>
    member val SourceException = exc with get

    /// <summary>
    ///     Creates an ExceptionDispatchInfo object that represents the specified exception at the current point in code.
    /// </summary>
    /// <param name="source">The exception whose state is captured, and which is represented by the returned object.</param>
    /// <returns>An object that represents the specified exception at the current point in code. </returns>
    static member Capture(source : exn) =
        if source = null
            then raise(new ArgumentNullException "source")
        new ExceptionDispatchInfo(source)

    /// <summary>
    ///     Throws the exception that is represented by the current ExceptionDispatchInfo object, after restoring the state
    ///     that was saved when the exception was captured.
    /// </summary>
    member this.Throw() =
        try
            raise this.SourceException
        with
        | exc ->
            let newStackTrace = _stackTrace + ExceptionDispatchInfo.BuildStackTrace(Environment.StackTrace)
            ExceptionDispatchInfo.SetStackTrace(this.SourceException, newStackTrace)
            reraise()
        
    static member private BuildStackTrace(trace : string) =
        let items = trace.Split([|Environment.NewLine|], StringSplitOptions.RemoveEmptyEntries)
        let newStackTrace = new StringBuilder()
        let mutable found = false
        let mutable contains = false
        for item in items do
            if not contains then
                if item.Contains ":" then
                    if item.Contains "System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()"
                        then contains <- true
                    else
                        if found
                            then newStackTrace.Append Environment.NewLine |> ignore
                        found <- true
                        newStackTrace.Append item |> ignore
                elif found
                    then contains <- true
        newStackTrace.ToString()

    static member private GetFieldInfo() =
        if ExceptionDispatchInfo._remoteStackTraceString = null then
            // ---
            // Code by Miguel de Icaza
            let mutable remoteStackTraceString = typeof<Exception>.GetField("_remoteStackTraceString", BindingFlags.Instance ||| BindingFlags.NonPublic)
            if remoteStackTraceString = null then remoteStackTraceString <- typeof<Exception>.GetField("remote_stack_trace", BindingFlags.Instance ||| BindingFlags.NonPublic)
            ExceptionDispatchInfo._remoteStackTraceString <- remoteStackTraceString
        ExceptionDispatchInfo._remoteStackTraceString

    static member private SetStackTrace(exc : exn, value) =
        let remoteStackTraceString = ExceptionDispatchInfo.GetFieldInfo()
        remoteStackTraceString.SetValue(exc, value)