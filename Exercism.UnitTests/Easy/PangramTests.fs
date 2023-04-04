namespace Psych.Exercism.UnitTests.Easy

module PangramTests =

    open Xunit
    open Psych.Exercism.Easy

    [<Theory>]
    [<InlineData "The quick brown fox jumps over the lazy dog.">]
    [<InlineData "ABCDEFGHIJKLMNOPQRSTUVWXYZ">]
    [<InlineData "abcdefghijlkmnopqrstuvwxyz">]
    [<InlineData "abcdefghijlkmnopqrstuvwxyza">]
    [<InlineData "abCdEfGHijKlMnOPQrSTuvwXYz">]
    [<InlineData "ABCDE FGHIJ  KLMNO PQRSTUVWX.&&YZ__">]
    let ``Pangram should return true when input is a pangram`` input =
        input
        |> Pangram.isPangram
        |> Assert.True

    [<Theory>]
    [<InlineData "">]
    [<InlineData " ">]
    [<InlineData "!#@$%#&$&%(%)$&$&#(#">]
    [<InlineData "ABCDEFGHIJKLMNOPQRSTUVWXY">]
    [<InlineData "BCDEFGHIJKLMNOPQRSTUVWXYZ">]
    let ``Pangram should return false when input is not a pangram`` input =
        input
        |> Pangram.isPangram
        |> Assert.False
