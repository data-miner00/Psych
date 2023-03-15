namespace Psych.Exercism

module Clock =
    let create hours minutes =
        let currentMins = minutes % 60
        let currentHour = (hours + (minutes / 60)) % 24

        let borrowed = if currentMins < 0 then -1 else 0
        let wrappedMins = if currentMins < 0 then 60 + currentMins else currentMins
        let wrappedHour = 
            match currentHour with
            | _ when currentHour < 0 -> 24 + currentHour + borrowed
            | _ when currentHour = 0 && currentMins < 0 -> 23
            | _ -> currentHour + borrowed
        
        (wrappedHour, wrappedMins)

    let add minutes clock = (fst clock, (snd clock) + minutes)

    let subtract minutes clock = (fst clock, (snd clock) - minutes)

    let display clock =
        let currentMins = (snd clock) % 60
        let currentHour = ((fst clock) + ((snd clock) / 60)) % 24

        let borrowed = if currentMins < 0 then -1 else 0
        let wrappedMins = if currentMins < 0 then 60 + currentMins else currentMins
        let wrappedHour = 
            match currentHour with
            | _ when currentHour < 0 -> 24 + currentHour + borrowed
            | _ when currentHour = 0 && currentMins < 0 -> 23
            | _ -> currentHour + borrowed

        sprintf "%02i:%02i" wrappedHour wrappedMins 
