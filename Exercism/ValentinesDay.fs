namespace Psych.Exercism

module ValentinesDay =
    type Approval =
        | Yes
        | No
        | Maybe

    // TODO: please define the 'Cuisine' discriminated union type
    type Cuisine =
        | Korean
        | Turkish

    // TODO: please define the 'Genre' discriminated union type
    type Genre =
        | Crime
        | Horror
        | Romance
        | Thriller

    // TODO: please define the 'Activity' discriminated union type
    type Activity =
        | BoardGame
        | Chill
        | Movie of Genre
        | Restaurant of Cuisine
        | Walk of int

    let rateActivity (activity: Activity): Approval =
        match activity with
        | Movie g when g = Romance -> Yes
        | Restaurant r when r = Korean -> Yes
        | Restaurant _ -> Maybe
        | Walk w when w < 3 -> Yes
        | Walk w when w < 5 -> Maybe
        | _ -> No
