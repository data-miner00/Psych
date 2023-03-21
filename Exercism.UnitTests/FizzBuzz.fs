namespace Psych.Exercism.UnitTests

open Xunit
open Psych.Exercism
open Microsoft.FSharp.Reflection

module FizzBuzzTests =
    type TestData() =
        static member FizzBuzzTestData =
            [ (1, "1")
              (2, "2")
              (3, "Fizz")
              (4, "4")
              (5, "Buzz")
              (6, "Fizz")
              (7, "7")
              (8, "8")
              (9, "Fizz")
              (10, "Buzz")
              (11, "11")
              (12, "Fizz")
              (13, "13")
              (14, "14")
              (15, "FizzBuzz")
              (16, "16")
              (17, "17")
              (18, "Fizz")
              (19, "19")
              (20, "Buzz")
              (21, "Fizz")
              (22, "22")
              (23, "23")
              (24, "Fizz")
              (25, "Buzz")
            ] |> Seq.map FSharpValue.GetTupleFields

    [<Theory>]
    [<MemberData("FizzBuzzTestData", MemberType=typeof<TestData>)>]
    let ``FizzBuzz should be correct`` (input: int) (expected: string) =
        input |> FizzBuzz.transform |> fun actual -> Assert.Equal(expected, actual)
