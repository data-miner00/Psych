namespace Psych.Concepts.Syntax

module Class =
    
    type House = class
        val Name: string
        val Location: string
        val Color: string

        new (name, location, color) =
            { Name = name; Location = location; Color = color }

        member this.Run =
            printfn "this %s" this.Name
    end

    (* Inheritance *)

    type CoolHouse(name, location, color) = 
        inherit House(name, location, color)

        member this.Cool =
            printfn "this cooling down"

    type Repo(name: string, stars: int) =
        // Private property
        let baseUrl = "https://github.com"

        // Private method
        let incrementStarsBy stars n = stars + n

        // Additional constructor
        new () = Repo("", 0)

        // Instance properties
        member this.Name = name // readonly
        member val Stars = stars with get, set // mutable

        // Static method
        static member SayHi = "Hello"

        // Methods
        member _.GetBaseUrl = $"{baseUrl}"
        member this.GetRepoUrl = $"{baseUrl}/{this.Name}"
        member this.IncrementStarsBy n = this.Stars <- incrementStarsBy this.Stars n

    Repo.SayHi |> ignore
