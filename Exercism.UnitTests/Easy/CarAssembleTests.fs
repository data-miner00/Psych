namespace Psych.Exercism.UnitTests.Easy

module CarAssembleTests =
    open Xunit
    open Psych.Exercism.Easy

    [<Theory>]
    [<InlineData (10, 0.77, 2)>]
    [<InlineData (9, 0.8, 2)>]
    [<InlineData (8, 0.9, 2)>]
    [<InlineData (5, 0.9, 2)>]
    [<InlineData (4, 1.0, 2)>]
    [<InlineData (1, 1.0, 2)>]
    let ``Should calculate the correct success rate of car assembly`` (input: int) (expected: float) (tolerance: int) =
        input |> CarAssemble.successRate |> fun x -> Assert.Equal(expected, x, tolerance)

    [<Theory>]
    [<InlineData (0, 0.0, 2)>]
    [<InlineData (1, 221.0, 2)>]
    [<InlineData (4, 884.0, 2)>]
    [<InlineData (7, 1392.3, 2)>]
    [<InlineData (9, 1591.2, 2)>]
    [<InlineData (10, 1701.7, 2)>]
    let ``Should calculate the correct production rate per hour`` (input: int) (expected: float) (tolerance: int) =
        input |> CarAssemble.productionRatePerHour |> fun x -> Assert.Equal(expected, x, tolerance)

    [<Theory>]
    [<InlineData (0, 0)>]
    [<InlineData (1, 3)>]
    [<InlineData (5, 16)>]
    [<InlineData (8, 26)>]
    [<InlineData (9, 26)>]
    [<InlineData (10, 28)>]
    let ``Should calculate number of working items produced per minute`` input expected =
        input |> CarAssemble.workingItemsPerMinute |> fun x -> Assert.Equal(expected, x)
