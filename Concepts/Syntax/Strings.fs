namespace Psych.Concepts.Syntax

open System
open System.Text

module Strings =
    
    let normalString = "normal"

    let ignoreBackslash = @"\ \f\\\fdsf" // verbatim string
    let ignoreQuoteNBackslash = """ \ "" """

    (* Length of string *)

    let length = String.length ignoreBackslash
    let length' = ignoreQuoteNBackslash.Length

    (* String slicing *)

    let somestr = "somestring"
    let char': char = somestr.[1] // accessing individual char with index
    let range: string = somestr.[1..4]

    (* Composition with string *)

    // Do for each character
    let collectedStr = String.collect (fun char -> sprintf "%c, " char)
    let iter = String.iter (fun char -> printf "%c" char)

    // Check if one character meets criteria
    let charExists = String.exists (fun char -> Char.IsUpper char)
    
    // Check for all character meets criteria, also Char.IsDigit
    let all = String.forall (fun char -> Char.IsLetter char)

    (* String generator *)

    /// Generate from 0 to 14 as string
    let init = String.init 14 (fun i -> i.ToString())

    (* String builder *)
    let builder = StringBuilder()
    let s = builder.Append "abc" 
            |> fun builder -> builder.Append "123"
            |> fun builder -> builder.ToString()
