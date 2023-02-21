namespace Psych.Playground

open System
open Psych.Functions

module Program =
    [<EntryPoint>]
    let main argv =
        let str = "Hello World from F#!"

        printfn "%s" (Hash.GetHashString str)
        printfn "%s" (Hash.GetHashString' str)

        0 // return an integer exit code
