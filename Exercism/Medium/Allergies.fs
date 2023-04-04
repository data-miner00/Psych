namespace Psych.Exercism.Medium

module Allergies =
    type Allergen =
        | Eggs
        | Peanuts
        | Shellfish
        | Strawberries
        | Tomatoes
        | Chocolate
        | Pollen
        | Cats

    let list codedAllergies =
        codedAllergies % 256
        |> fun x -> if x / 128 > 0 then ((x - 128), [Cats]) else (x, [])
        |> fun tup -> if (fst tup) / 64 > 0 then ((fst tup) - 64, List.append (snd tup) [Pollen]) else tup
        |> fun tup -> if (fst tup) / 32 > 0 then ((fst tup) - 32, List.append (snd tup) [Chocolate]) else tup
        |> fun tup -> if (fst tup) / 32 > 0 then ((fst tup) - 32, List.append (snd tup) [Chocolate]) else tup
        |> fun tup -> if (fst tup) / 16 > 0 then ((fst tup) - 16, List.append (snd tup) [Tomatoes]) else tup
        |> fun tup -> if (fst tup) / 8 > 0 then ((fst tup) - 8, List.append (snd tup) [Strawberries]) else tup
        |> fun tup -> if (fst tup) / 4 > 0 then ((fst tup) - 4, List.append (snd tup) [Shellfish]) else tup
        |> fun tup -> if (fst tup) / 2 > 0 then ((fst tup) - 2, List.append (snd tup) [Peanuts]) else tup
        |> fun tup -> if (fst tup) / 1 > 0 then ((fst tup) - 1, List.append (snd tup) [Eggs]) else tup
        |> fun tup -> List.rev (snd tup)

    let allergicTo codedAllergies allergen =
        List.contains allergen (list codedAllergies)
