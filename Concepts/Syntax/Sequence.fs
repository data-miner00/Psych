namespace Psych.Concepts.Syntax

(* Sequence are like list but computed lazily *)
module Sequence =
    
    let seq1 = seq { 1..100 }
    let seq2 = seq { 0..2..100 }
    let descendingSeq = seq { 50..1 }
    let seqList = Seq.toList seq1

    let isPrime n = 
        let rec check i =
            i > n / 2 || (n % i <> 0 && check(i + 1))
        check n

    let primeSeq = seq { for a in 1..500 do if isPrime a then yield a }
