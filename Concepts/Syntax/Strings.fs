namespace Psych.Concepts.Syntax

open System

module Strings =
    
    let normalString = "normal"

    let ignoreBackslash = @"\ \f\\\fdsf"
    let ignoreQuoteNBackslash = """ \ "" """

    (* Length of string *)

    let length = String.length ignoreBackslash
    let length' = ignoreQuoteNBackslash.Length

    (* String slicing *)

    let somestr = "somestring"
    let char': char = somestr.[1]
    let range: string = somestr.[1..4]

    (* Composition with string *)

    // Do for each character
    let collectedStr = String.collect (fun char -> sprintf "%c, " char)
    let iter = String.iter (fun char -> printf "%c" char)

    // Check if one character meets criteria
    let charExists = String.exists (fun char -> Char.IsUpper char)
    
    // Check for all character meets criteria
    let all = String.forall (fun char -> Char.IsLetter char)

    (* String generator *)

    /// Generate from 0 to 14 as string
    let init = String.init 14 (fun i -> i.ToString())

