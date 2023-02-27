namespace Psych.Concepts.Syntax


module Function =
    (* Inline function *)

    // Type inferencing to the parameter `number` depends on the first usage of the function.
    // In this case, `string`. Integer type that comes after will yield compile error.
    let useFloatCastable number =
        printfn "%f" (float number)

    useFloatCastable "123" // valid
    // useFloatCastable 123 -> invalid: Expected to have type string but have int

    // Use `inline` to make it generic.
    let inline useFloatCastable' number =
        printfn "%f" (float number)

    useFloatCastable' "123"
    useFloatCastable' 123
