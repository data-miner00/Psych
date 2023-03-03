namespace Psych.Functions.UnitTests

open Psych.Functions
open Xunit

module RecursionTest =
    [<Theory>]
    [<InlineData(0, 0, 1)>]
    [<InlineData(1, 2, 4)>]
    [<InlineData(2, 1, 5)>]
    [<InlineData(2, 2, 7)>]
    [<InlineData(3, 4, 125)>]
    [<InlineData(4, 1, 65535)>]
    let ``Ackermann Test`` m n (e: int) =
        Recursion.ackermann m n 
        |> fun x -> Assert.Equal(e, x)
