namespace Psych.Exercism.UnitTests.Easy

open Psych.Exercism.Easy
open Xunit

module RaindropsTests =
    [<Theory>]
    [<InlineData(1, "1")>]
    [<InlineData(3, "Pling")>]
    [<InlineData(5, "Plang")>]
    [<InlineData(7, "Plong")>]
    [<InlineData(6, "Pling")>]
    [<InlineData(8, "8")>]
    [<InlineData(9, "Pling")>]
    [<InlineData(10, "Plang")>]
    [<InlineData(14, "Plong")>]
    [<InlineData(15, "PlingPlang")>]
    [<InlineData(21, "PlingPlong")>]
    [<InlineData(25, "Plang")>]
    [<InlineData(27, "Pling")>]
    [<InlineData(35, "PlangPlong")>]
    [<InlineData(49, "Plong")>]
    [<InlineData(52, "52")>]
    [<InlineData(105, "PlingPlangPlong")>]
    [<InlineData(3125, "Plang")>]
    let ``Raindrop should produce correct sound`` number sound =
        number |> Raindrops.convert |> fun x -> Assert.Equal(sound, x)

    [<Theory>]
    [<InlineData(1, "1")>]
    [<InlineData(3, "Pling")>]
    [<InlineData(5, "Plang")>]
    [<InlineData(7, "Plong")>]
    [<InlineData(6, "Pling")>]
    [<InlineData(8, "8")>]
    [<InlineData(9, "Pling")>]
    [<InlineData(10, "Plang")>]
    [<InlineData(14, "Plong")>]
    [<InlineData(15, "PlingPlang")>]
    [<InlineData(21, "PlingPlong")>]
    [<InlineData(25, "Plang")>]
    [<InlineData(27, "Pling")>]
    [<InlineData(35, "PlangPlong")>]
    [<InlineData(49, "Plong")>]
    [<InlineData(52, "52")>]
    [<InlineData(105, "PlingPlangPlong")>]
    [<InlineData(3125, "Plang")>]
    let ``Raindrop' should produce correct sound`` number sound =
        number |> Raindrops.convert' |> fun x -> Assert.Equal(sound, x)
