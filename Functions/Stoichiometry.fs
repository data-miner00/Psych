namespace Psych.Functions

module Stoichiometry =

    open System
    open Common

    // k is decay constant
    let halfLife k =
        ln 2. / k

    module RateEquation =
        
        // ln N = -kt + ln N0

        let findT N k N0 =
            (ln N - ln N0) / -k

        let findN k t N0 =
             Math.Pow(Math.E, (-k * t + ln N0))
             
        let findK N t N0 =
            (ln N - ln N0) / -t

        let findN0 N t k =
            ln N + k * t
