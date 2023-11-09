namespace Psych.Concepts.Syntax

module Struct =
    type Rectangle = struct
        val Length: float
        val Width: float

        new (width, length) =
            { Length = length; Width = width}
    end

    [<Struct>] // stack allocation
    type Rectangle' = { Length: float; Width: float }

    let rect = new Rectangle(1.0, 3.0)
