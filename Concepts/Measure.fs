namespace Psych.Concepts

module Measure =
    [<Measure>] type cm
    [<Measure>] type inch
    [<Measure>] type m
    [<Measure>] type sec
    [<Measure>] type kg
    [<Measure>] type lbs

    let x = 1<cm>
    let x' = x + 3<cm>

    let iseq = x = 4<cm>
    let m = 1<m>

    // Mixing
    let distance = 1.0<m>
    let time = 2.0<sec>
    let speed = 2.0<m/sec>
    let acceleration = 2.0<m/sec^2>
    let force = 5.0<kg m/sec^2>

    [<Measure>] type N = kg m/sec^2
    let force' = 5.0<N>

    (* Conversion *)
    [<Measure>] type degC
    [<Measure>] type degF

    let convertCelciusToFarenheit c = c * 1.8<degF/degC> + 32.0<degF>
    convertCelciusToFarenheit 0.0<degC> |> ignore

    let centimetersperMeter = 100.0<cm/m>
    let distanceInCentimeters = 2.0<m> * centimetersperMeter
