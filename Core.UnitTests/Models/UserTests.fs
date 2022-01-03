namespace Psych.Core.UnitTests.Models

module UserTests =
    
    open Xunit
    open Psych.Core.Models

    [<Fact>]
    let ``Should have correct properties`` () =
        let user = User("mum khong", "chong", 24, 54.01, "Melaka", "mumk0313@gmail.com", "123456")

        Assert.Equal(user.FirstName, "mum khong")
        Assert.Equal(user.LastName, "chong")
        Assert.Equal(user.Age, 24)
        Assert.Equal(user.Money, 54.00, 1)
        Assert.NotEqual(user.Money, 54.00, 2)
        Assert.Equal(user.Email, "mumk0313@gmail.com")

