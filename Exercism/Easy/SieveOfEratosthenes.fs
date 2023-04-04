namespace Psych.Exercism.Easy

module SieveOfEratosthenes =
    let primes limit =
        let current = 2

        let rec cross composite_list current =
            if current > limit then
                composite_list
            else
                let current_numbers = [2..current - 1]
                let isPrime = List.forall (fun x -> current % x <> 0) current_numbers

                let new_composite =
                    if isPrime then
                        List.append composite_list [current .. limit .. current] // Not what I expected but it works?
                    else composite_list

                cross new_composite (current + 1)
            
        let composite_list = List.distinct(cross List.empty current)
        [2 .. limit] |> List.filter (fun x -> List.contains x composite_list)
