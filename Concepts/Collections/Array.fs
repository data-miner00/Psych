namespace Psych.Concepts.Collections

module Array =
    let empty = [||]
    let array: int array = [|1;2;3|]
    let array' = [|
        1
        2
        3
    |]

    let array''' = [|1..5|]
    let array'''' = [|for x in 1..5 -> x*x|]

    module ArrayModule =
        let empty = Array.empty
        let array = Array.create 5 1.0 // [|1.0;1.0;1.0;1.0;1.0|]
        let zeroArray: int array = Array.zeroCreate 5 // [|0;0;0;0;0|]
        let array' = Array.init 5 (fun x -> x * x)
        let value = array.[1]
        array.[1] <- 3 // changing value
        let array'' = Array.append array [|1.0; 0.5|]
        let array''' = Array.concat [array; array'']

    module MultiDimension =
        let array2d = [| [|1..3|]; [|4..6|] |]
        let value = array2d[1][2]
