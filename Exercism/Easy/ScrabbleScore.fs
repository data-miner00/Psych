namespace Psych.Exercism.Easy

module ScrabbleScore =
    let score (word: string) =
        let lookup = function
        | 'Q' | 'Z' -> 10
        | 'J' | 'X' -> 8
        | 'K' -> 5
        | 'F' | 'H' | 'V' | 'W' | 'Y' -> 4
        | 'B' | 'C' | 'M' | 'P' -> 3
        | 'D' | 'G' -> 2
        | _ -> 1

        List.fold (+) 0 (List.map lookup (List.ofArray(word.ToUpper().ToCharArray())))

