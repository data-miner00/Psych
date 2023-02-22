namespace Psych.Playground

open System
open Psych.Functions

module Program =

    (* Built-in math functions *)
    let transientContext =
        let res = abs -1
        let res = ceil 4.5
        let res = floor 4.5
        let res = log 2.718281828
        let res = log10 1000.0
        let res = sqrt 25.0

        0

    [<EntryPoint>]
    let main argv =
        let str = "Hello World from F#!"

        printfn "%s" (Hash.GetHashString str)
        printfn "%s" (Hash.GetHashString' str)

        Request.makeHttpRequest

        0 // return an integer exit code
