﻿namespace Psych.Exercism.UnitTests.Easy

open Xunit
open FsUnit.Xunit
open Psych.Exercism.Easy.PerfectNumber

module PerfectNumberTests =
    [<Fact>]
    let ``Smallest perfect number is classified correctly`` () =
        classify 6 |> should equal (Some Classification.Perfect)

    [<Fact>]
    let ``Medium perfect number is classified correctly`` () =
        classify 28 |> should equal (Some Classification.Perfect)

    [<Fact>]
    let ``Large perfect number is classified correctly`` () =
        classify 33550336 |> should equal (Some Classification.Perfect)

    [<Fact>]
    let ``Smallest abundant number is classified correctly`` () =
        classify 12 |> should equal (Some Classification.Abundant)

    [<Fact>]
    let ``Medium abundant number is classified correctly`` () =
        classify 30 |> should equal (Some Classification.Abundant)

    [<Fact>]
    let ``Large abundant number is classified correctly`` () =
        classify 33550335 |> should equal (Some Classification.Abundant)

    [<Fact>]
    let ``Smallest prime deficient number is classified correctly`` () =
        classify 2 |> should equal (Some Classification.Deficient)

    [<Fact>]
    let ``Smallest non-prime deficient number is classified correctly`` () =
        classify 4 |> should equal (Some Classification.Deficient)

    [<Fact>]
    let ``Medium deficient number is classified correctly`` () =
        classify 32 |> should equal (Some Classification.Deficient)

    [<Fact>]
    let ``Large deficient number is classified correctly`` () =
        classify 33550337 |> should equal (Some Classification.Deficient)

    [<Fact>]
    let ``Edge case (no factors other than itself) is classified correctly`` () =
        classify 1 |> should equal (Some Classification.Deficient)

    [<Fact>]
    let ``Zero is rejected (as it is not a positive integer)`` () =
        classify 0 |> should equal None

    [<Fact>]
    let ``Negative integer is rejected (as it is not a positive integer)`` () =
        classify -1 |> should equal None

