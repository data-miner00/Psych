namespace Psych.Concepts.Syntax

module Scoping =
    let a = 1
    let b = 2
    let c = let a = 3 in a * b // when evaluate a*b, value of a is evaluate to 3, not 1 that is defined earlier
    let d = let a = 4 in let b = 6 in a * b
