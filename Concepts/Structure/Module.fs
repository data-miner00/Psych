namespace Psych.Concepts.Structure

[<AutoOpen>]
module Transaction =
    // Type definition
    type T =
        { Id: int; Amount: float }

    // Methods associated with type
    let create id amount =
        { Id = id; Amount = amount }

[<RequireQualifiedAccess>] // Use when feel like name will conflict; Use for readibility
module Transaction' =
    type T =
        { Id: int; Name: string }

    let create id name =
        { Id = id; Name = name }
