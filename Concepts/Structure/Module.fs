namespace Psych.Concepts.Structure

module Transaction =
    // Type definition
    type T =
        { Id: int; Amount: float }

    // Methods associated with type
    let create id amount =
        { Id = id; Amount = amount }
