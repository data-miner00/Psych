namespace Psych.Exercism

module CarAssemble =
    let successRate (speed: int): float =
        match speed with
        | x when x = 0 -> x
        | x when x > 0 && x <= 4 -> 1
        | x when x > 4 && x <= 8 -> 0.9
        | x when x = 9 -> 0.8
        | _ -> 0.77

    let productionRatePerHour (speed: int): float =
        float (speed * 221) * successRate(speed)

    let workingItemsPerMinute (speed: int): int =
        speed |> productionRatePerHour |> int |> fun x -> x / 60
