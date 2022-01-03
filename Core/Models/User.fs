namespace Psych.Core.Models

type User(firstName:string, lastName:string, age:int, money:float, location:string,
          email:string, password:string) =
            member this.FirstName = firstName
            member this.LastName = lastName
            member this.Age = age
            member this.Money = money
            member this.Location = location
            member this.Email = email
            member this.Password = password

