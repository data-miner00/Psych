namespace Psych.Concepts.Syntax

module Generics =

    let add<'T> x y =
        x + y

    let answer = add<float> 1.0 2.0

