namespace Psych.Exercism.UnitTests.Easy

open Xunit
open FsUnit.Xunit
open Psych.Exercism.Easy.RnaTranscription

module RnaTranscriptionTests =
    [<Fact>]
    let ``Empty RNA sequence`` () =
        toRna "" |> should equal ""

    [<Fact>]
    let ``RNA complement of cytosine is guanine`` () =
        toRna "C" |> should equal "G"

    [<Fact>]
    let ``RNA complement of guanine is cytosine`` () =
        toRna "G" |> should equal "C"

    [<Fact>]
    let ``RNA complement of thymine is adenine`` () =
        toRna "T" |> should equal "A"

    [<Fact>]
    let ``RNA complement of adenine is uracil`` () =
        toRna "A" |> should equal "U"

    [<Fact>]
    let ``RNA complement`` () =
        toRna "ACGTGGTCTTAA" |> should equal "UGCACCAGAAUU"

