namespace Psych.Exercism.UnitTests.Easy

open Psych.Exercism.Easy
open Xunit
open Microsoft.FSharp.Reflection

module BobTests =
    
    type TestData() =
        static member BobTestData =
            [ ("Tom-ay-to, tom-aaaah-to.", "Whatever.")
              ("WATCH OUT!", "Whoa, chill out!")
              ("FCECDFCAAB", "Whoa, chill out!")
              ("Hi there!", "Whatever.")
              ("It's OK if you don't want to go work for NASA.", "Whatever.")
              ("1, 2, 3 GO!", "Whoa, chill out!")
              ("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!", "Whoa, chill out!")
              ("I HATE THE DENTIST", "Whoa, chill out!")
              ("Ending with ? means a question.", "Whatever.")
              ("", "Fine. Be that way!")
              ("          ", "Fine. Be that way!")
              ("\t\t\t\t\t\t\t\t\t\t", "Fine. Be that way!")
              ("\nDoes this cryogenic chamber make me look fat?\nNo.", "Whatever.")
              ("         hmmmmmmm...", "Whatever.")
              ("\n\r \t", "Fine. Be that way!")
              ("This is a statement ending with whitespace      ", "Whatever.")
              ("Does this cryogenic chamber make me look fat?", "Sure.")
              ("You are, what, like 15?", "Sure.")
              ("fffbbcbeab?", "Sure.")
              ("WHAT'S GOING ON?", "Calm down, I know what I'm doing!")
              ("1, 2, 3", "Whatever.")
              ("4?", "Sure.")
              (":) ?", "Sure.")
              ("Wait! Hang on. Are you going to be OK?", "Sure.")
              ("Okay if like my  spacebar  quite a bit?   ", "Sure.")
            ] |> Seq.map FSharpValue.GetTupleFields

    [<Theory>]
    [<MemberData("BobTestData", MemberType=typeof<TestData>)>]
    let ``Bob should utter the correct response`` (input: string) (expected: string) =
        input |> Bob.response |> fun actual -> Assert.Equal(expected, actual)

    [<Theory>]
    [<MemberData("BobTestData", MemberType=typeof<TestData>)>]
    let ``Bob should utter the correct response 2`` (input: string) (expected: string) =
        input |> Bob.response' |> fun actual -> Assert.Equal(expected, actual)
