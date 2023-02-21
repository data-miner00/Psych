namespace Psych.Data

open System
open System.Collections.Generic
open Psych.Core.Models

// Side Effect
module MemoryUserData =
    let mutable private users = List<User>()

    let addUser (user: User) = 
        users.Add(user) |> ignore
        user

    let getAllUser =
        users

    let getUser (username: string) =
        try users.Find(fun x -> x.Username = username) |> Some
        with
        | :? ArgumentNullException -> None
        | :? NullReferenceException -> None

    let updateUser (user: User) =
        match getUser user.Username with
        | Some(user') ->
            users.Remove(user') |> ignore
            users.Add(user)
        | None -> raise (InvalidOperationException "Cannot find user with given username")

    let deleteUser (username: string) =
        match getUser username with
        | Some(user') ->
            users.Remove(user') |> ignore
        | None -> raise (InvalidOperationException "Cannot find user with given username")

// Non side effect
module MemoryUserData' =
    let private users: User[] = [||]

