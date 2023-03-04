namespace Psych.Concepts.Collections

open System

module List =
    let list0 = []

    let list1 = [1; 2; 3]

    let list2 = [
        1
        2
        3
    ]

    let list3: float list = [1.; 2.; 3.]

    let val1 = list1[1]
    let val1' = list1.[1]

    // Cons operator
    let list1' = 10 :: list1

    // Concat operator
    let list1'' = list1' @ list1

    let list4 = [1..100]
    let slice = list4.[10..14]

    let slice' = list4[..4]
    let slice'' = list4[96..]

    let isempty = list4.IsEmpty
    let len = list4.Length
    let head = list4.Head
    let tail = list4.Tail

    let tailtailhead = list4.Tail.Tail.Head
    let val2 = list4.Item(1)

    module ListModule =
        let list = List.init 5 (fun x -> x * 2) // [0;2;4;6;8]
        let list' = let r = Random() in List.init 10 (fun x -> r.Next(0, 10))
        let list'' = List.sort [5..-1..0] // [0;1;2;3;4;5]
        let list''' = List.sortDescending [1..5] // [5;4;3;2;1]
        let list'''' = List.rev ["a"; "b"; "c"] // ["c";"b";"a"]
        let exist = List.exists (fun x -> x > 2) [1..5] // true
        let list''''' = List.where (fun x -> x < 3) [1..5] // [1; 2]

        // Be wary the below will throw exception if not found
        let index = List.findIndex (fun x -> x = "b") ["z"; "e"; "a"; "b"; "4"] // Index of first item found: 3
        let value = List.find (fun x -> x % 2 = 0) [1; -1; 9; 4; 3] // Value of first item found: 4

        // Safer version
        let maybeIndex = List.tryFindIndex (fun x -> x = "b") ["z"; "e"; "a"; "b"; "4"] // Some(3)
        let maybeValue = List.find (fun x -> x % 2 = 0) [1; -1; 9; 4; 3] // Some(4)

        (* Aggregates *)
        let floatList = List.map (fun x -> float x) list
        let sum = List.sum floatList
        let average = List.average floatList
        let min = List.min floatList
        let max = List.max floatList

        let concat = List.concat [[1..3]; [4..6]; [7..9]] // [1..9]
        let append = List.append [1..3] [7..9] // [1;2;3;7;8;9]
        let remove = List.removeAt 1 [1..3] // [1;3]

        let take = List.take 2 [1..5] // [1;2]
        let takeWhile = List.takeWhile (fun x -> x < 0) [-1; -2; 3; -4; -10] // [-1; -2]
        let skip = List.skip 3 [1..6] // [4;5;6]
        let skipWhile = List.skipWhile (fun x -> x < 0) [-1; -2; 3; -4; -10] // [3; -4; -10]
