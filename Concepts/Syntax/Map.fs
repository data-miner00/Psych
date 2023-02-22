namespace Psych.Concepts.Syntax

module Map =
    
    let myMap =
        Map.empty
           .Add("key1", 4)
           .Add("Key2", 6)

    let mapLen = myMap.Count
    let tryKey1 = myMap.TryFind "key1"
    let containKey1 = myMap.ContainsKey "key1"
    let key1val = myMap.["key1"]
    let newMap = Map.remove "key1" myMap
