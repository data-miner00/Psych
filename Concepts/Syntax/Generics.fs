﻿namespace Psych.Concepts.Syntax

module Generics =

    let add<'T> x y =
        x + y

    let answer = add<float> 1.0 2.0

    let swapTuple (a: 'a, b: 'b) = (b, a)
