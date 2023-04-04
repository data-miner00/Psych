namespace Psych.Exercism.Easy

open System

module Hamming =
    let distance (strand1: string) (strand2: string): int option =
        if strand1.Length = strand2.Length then
            Array.map2 (fun x y -> (int x - int y) <> 0) (strand1.ToCharArray()) (strand2.ToCharArray())
            |> Array.map Convert.ToInt32
            |> Array.fold (+) 0
            |> Some
        else None
