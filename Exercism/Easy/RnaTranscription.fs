namespace Psych.Exercism.Easy


module RnaTranscription =
    let toRna (dna: string): string =
        let rna = function
        | 'G' -> "C"
        | 'C' -> "G"
        | 'T' -> "A"
        | 'A' | _ -> "U"

        String.collect rna dna

