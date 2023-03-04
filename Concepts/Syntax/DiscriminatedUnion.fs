namespace Psych.Concepts.Syntax

open System

module DiscriminatedUnion =
    (* Without discriminated union *)
    type StringGitHubProject =
        { ProjectName: string
          Stars: int
          State: string }

    let fakeProject =
        { ProjectName = "Awesome Project"
          Stars = 0
          State = "Inactive" }

    (* With discriminated union *)
    type ProjectState =
        | Archived
        | Active of {| Maintainer: string |} // Anonymous record

    type DiscriminatedGitHubProject =
        { ProjectName: string
          Stars: int
          State: ProjectState }

    let proj: DiscriminatedGitHubProject =
        { ProjectName = "XX"
          Stars = 1
          State = Archived }

    let proj2: DiscriminatedGitHubProject =
        { ProjectName = "YY"
          Stars = 2
          State = Active {| Maintainer = "Team" |}}

    let isMaintainedByTeam (proj: DiscriminatedGitHubProject) =
        match proj.State with
        | Archived -> printfn "not sure"
        | Active(M) when M.Maintainer = "Team" -> printfn "yes"
        | _ -> printfn "nope"

    type Shape =
        | Rectangle of width : float * height : float
        | Circle of radius : float
        | Triangle of s1 : float * s2 : float * s3 : float

    let rect = Rectangle(width = 1, height = 2)
    let circ = Circle(1.0)
    let tri = Triangle(1., 2., 3.)

    let perimeter shape =
        match shape with
        | Rectangle (width, height) -> 2. * (width + height)
        | Circle radius -> 2. * Math.PI * radius
        | Triangle (s1, s2, s3) -> s1 + s2 + s3

    let isSquare shape =
        match shape with
        | Rectangle (width, height) -> width = height
        | _ -> false

    (* Recursive Tree *)
    type BinaryTree =
        | Leaf of int
        | Node of BinaryTree * BinaryTree

    let root = Node(Leaf(1), Node(Leaf(2), Leaf(3)))

    let sum tree =
        let rec walk accum current =
            match current with
            | Leaf value -> accum + value
            | Node (left, right) -> (walk accum left) + (walk accum right)
        walk 0 tree

    (* Option & Result *)
    // Generic DU Implementation with option
    // type 'a option =
    //     | None
    //     | Some of 'a

    // Generic Result
    // type Result<'T, 'TError> =
    //     | Ok of ResultValue: 'T
    //     | Error of ErrorValue: 'TError

    let parse = function
        | "1" -> Some (1)
        | _ -> None

    // Option.map: Map if got value
    "1" |> parse |> Option.map (fun x  -> x * 2) |> ignore

    // Option.bind: Maps and expect an option
    "1" |> parse |> Option.bind (fun x -> x * 2 |> Some) |> ignore

    module Result =
        type Request = {
            Id: int
            Name: string
            Email: string
        }

        type RequestPipelineError =
            | ValidationError of field: string
            | DatabaseError of message: string

        let validateName request =
            match request.Name with
            | "" -> Error(ValidationError "Name")
            | _ -> Ok request

        let validateEmail request =
            match request.Email with
            | "" -> Error(ValidationError "Email")
            | _ -> Ok request

        let validateRequest request =
            (Ok request)
                |> Result.bind validateName
                |> Result.bind validateEmail

        let (>>=) result func =Result.bind func result

        let validateRequest' request =
            (Ok request)
                >>= validateName
                >>= validateEmail

        let storeInDB request =
            try
                // storing data
                Ok request
            with
                | _ -> Error (DatabaseError "Database")

        let resutnStatus result =
            match result with
            | Ok data -> $"return 200 / Ok and data: {data}"
            | Error e ->
                match e with
                | ValidationError field -> $"Validation error: {field}"
                | DatabaseError message -> $"Database error: {message}"
