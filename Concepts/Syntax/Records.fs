namespace Psych.Concepts.Syntax

module Records =

    type Customer =
        { Name: string; balance: float }

    let doug = { Name = "doug"; balance = 3.14 }
