namespace Psych.Concepts.Syntax

module List =
    
    (* Creating list *)

    let list0 = [1;2;3;4]
    let list1 = 5::6::7::[]
    let list2 = ['a'..'z']
    let list3 = [for a in 1..5 do yield (a * a)]
    let list4 = [for a in 1..20 do if a % 2 = 0 then yield a]
    let list5 = [for a in 1..3 do yield! [a..a+2]]
    let list5' = List.init<int> 10 (fun i -> i * 2)

    (* List methods *)

    let length = list0.Length
    let isEmpty = list0.IsEmpty
    let index2 = list0.Item(2)
    let head = list0.Head
    let tail = list0.Tail


    let list6 = list3 |> List.filter(fun x -> x % 2 = 0)
    let sorted = List.sort list3

    let throwIfNotFound = List.find (fun x -> x = 5) list0
    let getOptionFromFind = List.tryFind (fun x -> x = 5) list0

    [6;7;8] |> List.append list0 |> ignore // Append
    list0 |> List.append [6;7;8] |> ignore // Prepend

    (* Conversion *)
    list0 |> Array.ofList |> ignore
    list0 |> Seq.ofList |> ignore

    (* Mapping *)
    list0
    |> List.map
        (fun x ->
            let var = 2
            {| Initial = x; Added = x + var |})
    |> ignore

    list0
    |> List.iter (printfn "%i")

    list0
    |> List.sumBy (fun x -> x)
    |> ignore

    list0
    |> List.sortByDescending (fun x -> x)
    |> ignore
