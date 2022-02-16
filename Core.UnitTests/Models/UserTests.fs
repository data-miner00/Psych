namespace Psych.Core.UnitTests.Models

module UserTests =
    
    open System
    open Xunit
    open Psych.Core.Models

    [<Fact>]
    let ``Should have correct properties`` () =

        let now = DateTime.Now

        let user = User("mum khong", "chong", "mumk0313", 24, 54.01, "Melaka", "mumk0313@gmail.com", "123456", now)

        Assert.Equal(user.FirstName, "mum khong")
        Assert.Equal(user.LastName, "chong")
        Assert.Equal(user.Age, 24)
        Assert.Equal(user.Money, 54.00, 1)
        Assert.NotEqual(user.Money, 54.00, 2)
        Assert.Equal(user.Email, "mumk0313@gmail.com")
        Assert.Equal(user.LastLogin, now)

