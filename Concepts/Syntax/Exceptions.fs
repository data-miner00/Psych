namespace Psych.Concepts.Syntax

open System

module Exceptions =

    let trye =
        try
            4 / 0
        with
        | :? System.DivideByZeroException -> 6

    let tryex =
        try
            if 0 = 0 then raise(DivideByZeroException("Cannot divide by 0"))
            else
                printf "Ok"
        with
        | :? System.DivideByZeroException as ex -> printf "not ok"

