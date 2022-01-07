namespace Psych.Functions.UnitTests

module Tests =

    open System
    open Xunit
    open Psych.Functions.Common

    [<Fact>]
    let ``Environment test`` () =
        Assert.True(true)

    [<Fact>]
    let ``Logarithm`` () =
        let actual = logx 8.0 5.0
        let expected = 0.77397

        Assert.Equal(expected, actual, 4)

    [<Fact>]
    let ``Natural logarithm`` () =
        let actual = ln 6.0
        let expected = 1.79175

        Assert.Equal(expected, actual, 4)

    
    (* Unable to test recursive functions *)

    [<Fact>]
    let ``Pythogoras theorem`` () =
        let actual = pythogorasTheorem 3.0 4.0
        let expected = 5.0

        Assert.Equal(expected, actual)

    [<Theory>]
    [<InlineData(0, 1)>]
    [<InlineData(3, 6)>]
    [<InlineData(5, 120)>]
    let ``Factorial`` n expected =
        
        let actual = Factorial.factorial' n
        Assert.Equal(expected, actual)
