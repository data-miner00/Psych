namespace Psych.Concepts.Syntax

module Array =
    let array = Array.init<int> 10 (id)
    let array2 = Array2D.init<int> 3 3 (fun x _ -> x)
    let array3 = Array3D.init<int> 3 3 3 (fun _ _ z -> z)
    let array4 = [|1;2;3;4;5|]
    let array5 = [|1..5|]
    let array6 = [|1..4..23|]
