namespace Psych.Concepts.Syntax

module List =
    
    (* Creating list *)

    let list0 = [1;2;3;4]
    let list1 = 5::6::7::[]
    let list2 = ['a'..'z']
    let list3 = [for a in 1..5 do yield (a * a)]
    let list4 = [for a in 1..20 do if a % 2 = 0 then yield a]
    let list5 = [for a in 1..3 do yield! [a..a+2]]

    (* List methods *)

    let isEmpty = list0.IsEmpty
    let index2 = list0.Item(2)
    let head = list0.Head
    let tail = list0.Tail


    let list6 = list3 |> List.filter(fun x -> x % 2 = 0)
    let sorted = List.sort list3

