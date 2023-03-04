namespace Psych.Concepts.Syntax

module Records =

    type Customer =
        { Name: string; balance: float }

    let doug = { Name = "doug"; balance = 3.14 }

    (* Access data *)
    doug.balance |> ignore

    (* Update data *)
    let updated = { doug with balance = 3.15 }

    (* Type with member *)
    type Customer' =
        { Name: string; Balance: double }
        member this.GetName =
            this.Name
        member _.GetConstant =
            "const"
        static member New n b =
            { Name = n; Balance = b }

    let deposit customer amount =
        { customer with Balance = customer.Balance + amount }

    let withdraw customer amount =
        { customer with Balance = customer.Balance - amount }
