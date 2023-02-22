namespace Psych.Concepts.Syntax

module Options =

    let divide x y =
        match y with
        | 0 -> None
        | _ -> Some (x/y)

    if (divide 1 2).IsNone then
        printf "cant divide by 0"
    elif (divide 1 2).IsSome then
        printf "ok = %A" (divide 1 2).Value
    else
        printf "nothing"
