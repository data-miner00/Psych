namespace Psych.Exercism.Easy

module PerfectNumber =
    type Classification = Perfect | Abundant | Deficient

    let classify n =
        if n < 1 then
            None
        else
            let factors = 
                [ for i in 1 .. n - 1 do
                    if n % i = 0 then yield i]
            let sum = factors |> List.sum
            
            match sum with
            | _ when sum > n -> Some Abundant
            | _ when sum < n -> Some Deficient
            | _ -> Some Perfect

