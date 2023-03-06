namespace Psych.Exercism

module KindergartenGarden =
    type Plant =
        | Grass
        | Clover
        | Radishes
        | Violets
        | Invalid

    let plants (diagram: string) (student: string) =
        let halfDiagramLength = diagram.Length / 2

        student
        |> fun x -> x.ToUpper()
        |> fun x -> x.[0]
        |> fun x -> List.findIndex (fun y -> y = x) ['A'..'L']
        |> fun x -> (x * 2) :: (x * 2) + 1 :: halfDiagramLength + (x * 2) + 1 :: halfDiagramLength + (x * 2) + 2 :: []
        |> List.map (fun x -> diagram.[x])
        |> List.map (fun x ->
                        match x with
                        | 'G' -> Plant.Grass
                        | 'C' -> Plant.Clover
                        | 'V' -> Plant.Violets
                        | 'R' -> Plant.Radishes
                        | _ -> Plant.Invalid)
