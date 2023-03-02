namespace Psych.Concepts.Syntax

module Use =
    open System.IO

    let writetofile filename obj =
        // Call IDisposable
        using (File.CreateText filename) (fun file -> file.WriteLine($"{obj.ToString()}"))

    (* For side-effect and no return value *)
    do printfn "hello world"
    do (1 + 1) |> ignore
