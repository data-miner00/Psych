namespace Psych.Exercism.Easy

module Raindrops =
    let convert (number: int): string =
        let isDividedBy3 = number % 3 = 0
        let isDividedBy5 = number % 5 = 0
        let isDividedBy7 = number % 7 = 0

        match isDividedBy3, isDividedBy5, isDividedBy7 with
        | true, true, true -> "PlingPlangPlong"
        | true, true, false -> "PlingPlang"
        | true, false, false -> "Pling"
        | true, false, true -> "PlingPlong"
        | false, true, false -> "Plang"
        | false, true, true -> "PlangPlong"
        | false, false, true -> "Plong"
        | _ -> number.ToString()


    let convert' (number: int): string =
        let isDividedBy3 = number % 3 = 0
        let isDividedBy5 = number % 5 = 0
        let isDividedBy7 = number % 7 = 0

        if isDividedBy3 || isDividedBy5 || isDividedBy7 then
            let pling = if isDividedBy3 then "Pling" else ""
            let plang = if isDividedBy5 then "Plang" else ""
            let plong = if isDividedBy7 then "Plong" else ""

            $"{pling}{plang}{plong}"
        else
            number.ToString()
