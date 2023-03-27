namespace Psych.Exercism

open System

module PigLatin =
    let translate (inputs: string) =
        let vowels = ["a"; "e"; "i"; "o"; "u"; "xr"; "yt"]
        inputs.Split(' ')
        |> Array.map (fun input ->
            match List.tryFind (fun x -> input.StartsWith(x, StringComparison.OrdinalIgnoreCase)) vowels with
            | Some _ ->
                input + "ay"
            | None ->
                let augmentedVowel = 
                    if input.StartsWith('y') then
                        [|'a'; 'e'; 'i'; 'o'; 'u'|]
                    else [|'a'; 'e'; 'i'; 'o'; 'u'; 'y'|]
                let firstVowelIndex = input.IndexOfAny(augmentedVowel)
                let quIndex = input.IndexOf("qu")
            
                let consonantCluster =
                    if quIndex = -1 then
                        input.Substring(0, firstVowelIndex)
                    else
                        input.Substring(0, quIndex + 2)

                let rest =
                    if quIndex = -1 then
                        input.Substring(firstVowelIndex)
                    else
                        input.Substring(quIndex + 2)

                rest + consonantCluster + "ay")
        |> String.concat " "
