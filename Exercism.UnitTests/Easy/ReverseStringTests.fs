﻿namespace Psych.Exercism.UnitTests.Easy

open Psych.Exercism.Easy.ReverseString
open Xunit
open FsUnit.Xunit

module ReverseStringTests =
    [<Fact>]
    let ``An empty string`` () =
        reverse "" |> should equal ""

    [<Fact>]
    let ``A word`` () =
        reverse "robot" |> should equal "tobor"

    [<Fact>]
    let ``A capitalized word`` () =
        reverse "Ramen" |> should equal "nemaR"

    [<Fact>]
    let ``A sentence with punctuation`` () =
        reverse "I'm hungry!" |> should equal "!yrgnuh m'I"

    [<Fact>]
    let ``A palindrome`` () =
        reverse "racecar" |> should equal "racecar"

    [<Fact>]
    let ``An even-sized word`` () =
        reverse "drawer" |> should equal "reward"

