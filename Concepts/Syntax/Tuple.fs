namespace Psych.Concepts.Syntax

module Tuple =
    
    let funct (w, x, y, z): float =
        w + x + y + z

    printfn "%f" (funct (1.0, 3.0, 5.0, 3.0))
