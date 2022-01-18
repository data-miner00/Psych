namespace Psych.Application
// Bank application
open System

module Program =

    [<EntryPoint>]
    let main argv =
        Cli.welcome()
        0 // return an integer exit code
