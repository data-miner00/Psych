namespace Psych.Concepts.Syntax

module DataTypes =
    
    (* Integral data types *)

    let sbyte': sbyte = 1y
    let byte': byte = 1uy

    let int16': int16 = 1s
    let uint16': uint16 = 1us

    let int': int = 1
    let int32': int32 = 1

    let uint32': uint32 = 1u

    let int64': int64 = 1L
    let uint64': uint64 = 1UL

    let bigint': bigint = 1I

    (* Floating point data types *)

    let float32': float32 = 1.0F
    let float': float = 1.0
    let decimal': decimal = 1.0M

    (* Text data types *)

    let char': char = 'y'
    let string': string = "hello";

    (* Boolean *)

    let bool': bool = false

    (* Casting *)
    module Casting =

        let number = 7
        printfn "Type: %A" (number.GetType())
        printfn "float %f" (float number)
        printfn "int %i" (int number)