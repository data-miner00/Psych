namespace Psych.Concepts.Syntax

open System

module Formatting =
    
    // Placeholder for different datatypes
    printfn "A string: %s. An int: %i. A float: %f. A bool: %b" "hello." 42 3.14 true 
    printfn "A tuple %A or object %O" (1, 2, 3) DateTime.Now

    // Precise float datatype
    printfn "A precise float %M" 1.2345675565465M

    // Rouded floating point
    printfn "A rounded float %g" 1.234

    // Padding with tabs
    printfn "%*s" 10 "padding 10 from left"
