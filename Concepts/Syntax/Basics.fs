namespace Psych.Concepts.Syntax

module Basics =

    module Functions = 
        
        let func_one x = x + 1
        let func_two y = y - 1
        let one_two = func_one >> func_two
        let two_one = func_one << func_two

    module Say =
        
        let hello name =
            printfn "Hello %s" name


    module Samples =
        
        let sampleArray = [|1; 2; 3; 4; 5|]
        let sampleList = [1; 2; 3; 4; 5]
        let sampleSequence =
            seq {
                yield! [5..10]
            }

        let mutable variable = 123
        variable <- 246

        let newlineSeperatedList = [
            "this"
            "is"
            "a"
            "string"
            "list"
        ]

        let private isOdd x = x % 2 <> 0
        let squareOfOdds xs =
            xs
            |> Seq.filter isOdd
            |> Seq.map (fun x -> x * 2)

        let refUses = ref 10
        refUses := 50
        printfn "%i" ! refUses

        let rec last list =
            match list with
            | [x] -> x
            | _::tail -> last tail
            | _ -> failwith "Empty list"

        let options list = 
            match List.tryLast list with
            | Some x -> x
            | None -> 0
