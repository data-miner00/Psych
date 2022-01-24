namespace Psych.Concepts.Format

open System
open FSharp.Reflection

// Reference: https://stackoverflow.com/questions/11559440/how-to-manage-debug-printing-in-f
module Debug =
    let rec mkKn (ty: Type) =
        if FSharpType.IsFunction(ty) then
            let _, ran = FSharpType.GetFunctionElements(ty)
            // NOTICE: do not delay `mkKn` invocation until runtime
            let f = mkKn ran
            FSharpValue.MakeFunction(ty, fun _ -> f)
        else
            box ()
    
    [<Sealed>]
    type Format<'T> private () =
        static let instance : 'T =
            unbox (mkKn typeof<'T>)
        static member Instance = instance
    
    let inline dprint verbose args =
        if verbose then
            printfn args
        else
            Format<_>.Instance
