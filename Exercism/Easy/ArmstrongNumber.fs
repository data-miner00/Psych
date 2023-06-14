namespace Psych.Exercism.Easy

module ArmstrongNumber =
    
    let isArmstrongNumber (number: int): bool =
        let numberAsString = number.ToString()

        numberAsString
        |> Seq.map(fun x -> (pown (int x - int '0') numberAsString.Length))
        |> Seq.reduce (+)
        |> (=) number

