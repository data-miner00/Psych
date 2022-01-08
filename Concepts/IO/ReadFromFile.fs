namespace Psych.Concepts.IO

open System
open System.IO

module ReadFromFile =

    let lines = File.ReadAllLines(@"C:\programs\file.txt")
    
    // Convert file lines into a list.
    let list = Seq.toList lines
    printfn "%A" list
    
    // Get sequence of only capitalized lines in list.
    let uppercase = Seq.where (fun (n : String) -> Char.IsUpper(n, 0)) list
    printfn "%A" uppercase