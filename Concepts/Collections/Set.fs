namespace Psych.Concepts.Collections

module Set =
    let set1 = ["A"; "B"; "A"] |> Set.ofList
    let set2 = [| "A"; "B"; "A" |] |> Set.ofArray
    let set3 = set1.Add("Z")
    let set4 = set3.Remove("Z")
    let unionSet = set1 + set2 + set3
    let distinctToSet1 = set1 - set2
    let intersect = set1 |> Set.intersect set2
    let isSubset = set1 |> Set.isSubset set3

