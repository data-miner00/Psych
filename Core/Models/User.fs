namespace Psych.Core.Models

open System

type User(firstName:string, lastName:string, username:string, age:int, money:float, location:string,
          email:string, password:string, lastLogin: DateTime) =
            member this.Username = username
            member this.FirstName = firstName
            member this.LastName = lastName
            member this.Age = age
            member this.Money = money
            member this.Location = location
            member this.Email = email
            member this.Password = password
            member this.LastLogin = lastLogin

type Sex =
    | Unspecified = 0
    | Male = 1
    | Female = 2
    

type User'() =
    member val FirstName = "" with get, set
    member val LastName = "" with get, set
    member val Age = 0 with get, set
    member val Birthday = new DateTime() with get, set
    member val Address = "" with get, set
    member val Sex = Sex.Unspecified with get, set
    member val Nationality = "" with get, set