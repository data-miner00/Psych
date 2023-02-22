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
