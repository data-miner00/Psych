namespace Psych.Exercism.Easy

module ProteinTranslation =
    let private findProtein (codon: string) =
        match codon with
        | "AUG" -> "Methionine"
        | "UUU" | "UUC" -> "Phenylalanine"
        | "UUA" | "UUG" -> "Leucine"
        | "UCU" | "UCC" | "UCA" | "UCG" -> "Serine"
        | "UAU" | "UAC" -> "Tyrosine"
        | "UGU" | "UGC" -> "Cysteine"
        | "UGG" -> "Tryptophan"
        | "UAA" | "UAG" | "UGA" | _ -> "STOP"

    let proteins (rna: string) =
        rna.ToCharArray()
        |> Seq.chunkBySize 3
        |> Seq.map System.String
        |> Seq.map findProtein
        |> Seq.takeWhile ((<>) "STOP")
        |> List.ofSeq

