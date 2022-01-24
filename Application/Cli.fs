namespace Psych.Application

open System
open Psych.Data
open Psych.Core.Models

module Cli =

    let login () =
        printf "Enter your username: "
        let username = Console.ReadLine()
        printf "Enter your password: "
        let password = Console.ReadLine()

        MemoryUserData.getUser username

    let register () =
        printf "Enter your first name: "
        let firstName = Console.ReadLine()
        printf "Enter your last name: "
        let lastName = Console.ReadLine()
        printf "Enter your user name: "
        let username = Console.ReadLine()
        printf "Enter your age: "
        let age = Console.ReadLine() |> Convert.ToInt32
        printf "Enter your birthday in dd/MM/yyyy format: "
        let birthday = Console.ReadLine()
        printf "Enter your address: "
        let location = Console.ReadLine()
        printf "Enter your email address: "
        let email = Console.ReadLine()
        printf "Enter your password: "
        let password = Console.ReadLine()
        printf "Confirm your password: "
        let confirm = Console.ReadLine()

        User(firstName, lastName, username, age, 0.0, location, email, password, DateTime.Now)
        |> MemoryUserData.addUser
        |> Some

    let welcome () =
        printfn "Welcome to XXX Bank"
        printfn "1. Login"
        printfn "2. Register"
        printf "> "
        let selection = Console.ReadLine()

        let useropt = match selection with
                        | "1" -> login()
                        | "2" -> register()
                        | _ -> login()

        match useropt with
        | Some(user) ->
            printfn "%s" user.FirstName
            printfn "%s" user.Email
            printfn "%d" user.Age
        | None -> printf "sadge thing happend"
    