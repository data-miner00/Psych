namespace Psych.Concepts.Syntax

open System
open System.IO
open System.Text
open Microsoft.FSharp.Core.Printf

module Formatting =
    
    // Placeholder for different datatypes
    printfn "A string: %s. An int: %i. A float: %f. A bool: %b" "hello." 42 3.14 true 
    printfn "A tuple %A or object %O" (1, 2, 3) DateTime.Now

    // Precise float datatype
    printfn "A precise float %M" 1.2345675565465M

    // Rouded floating point
    printfn "A rounded float %g" 1.234

    // Padding with parameterized length
    printfn "%*s" 10 "padding 10 from left"

    // Padding left and right for 5 length each
    printfn "%-5s %5s" "a" "b"

    // Escaping % character
    printfn "Hello %%"

    // Different printer
    printf "Goes to stdout"
    sprintf "Returns a formatted string" |> ignore
    eprintf "Prints to stderr"
    fprintf TextWriter.Null "Output to text writer"
    
    let buffer = StringBuilder()
    bprintf buffer $"Output to StringBuilder {1}"
    buffer.ToString() |> ignore

    kprintf (fun x -> x + ", done!") "printf but with additional finalizer function" |> ignore
