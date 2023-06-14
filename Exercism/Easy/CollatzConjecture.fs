namespace Psych.Exercism.Easy

module CollatzConjecture =
    let rec private helper (current: int) (acc: int): int =
        if current = 1 then
            acc
        else
            helper (if current % 2 = 0 then current / 2 else current * 3 + 1) (acc + 1)

    let steps (number: int): int option =
        if number < 1 then
            None
        else
            helper number 0 |> Some

