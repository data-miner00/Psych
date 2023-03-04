namespace Psych.Concepts.Collections

module Sequence =
    let seqs = seq {1..10}
    let seqs' = seq { for i in 1..10 -> i * i }

    for i in seqs do printfn "%A" i
