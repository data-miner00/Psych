namespace Psych.Application

open System

module Cli =

    let login () =
        0

    let register () =
        0
    
    let welcome () =
        printfn "Welcome to XXX Bank"
        printfn "1. Login"
        printfn "2. Register"
        printf "> "
        let selection = Console.ReadLine()

        let a = match selection with
                | "1" -> login()
                | "2" -> register()
                | _ -> 0

        printfn "%d" a