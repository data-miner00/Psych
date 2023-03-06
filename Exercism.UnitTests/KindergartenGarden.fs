namespace Psych.Exercism.UnitTests

open Psych.Exercism
open Xunit
open Microsoft.FSharp.Reflection

module KindergartenGardenTests =
    open KindergartenGarden
    
    //type TestData() =
    //    static member KindergartenGardenTestData =
    //        [
    //            (
    //                "RC\nGG",
    //                "Alice",
    //                [Plant.Radishes; Plant.Clover; Plant.Grass; Plant.Grass]
    //            ),
    //            (
    //                "VC\nRC",
    //                "Alice",
    //                [Plant.Violets; Plant.Clover; Plant.Radishes; Plant.Clover]
    //            ),
    //            (
    //                "VVCG\nVVRC",
    //                "Bob",
    //                [Plant.Clover; Plant.Grass; Plant.Radishes; Plant.Clover]
    //            ),
    //            (
    //                "VVCCGG\nVVCCGG",
    //                "Bob",
    //                [Plant.Clover; Plant.Clover; Plant.Clover; Plant.Clover]
    //            ),
    //            (
    //                "VVCCGG\nVVCCGG",
    //                "Charlie",
    //                [Plant.Grass; Plant.Grass; Plant.Grass; Plant.Grass]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Alice",
    //                [Plant.Violets; Plant.Radishes; Plant.Violets; Plant.Radishes]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Bob",
    //                [Plant.Clover; Plant.Grass; Plant.Clover; Plant.Clover]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Charlie",
    //                [Plant.Violets; Plant.Violets; Plant.Clover; Plant.Grass]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "David",
    //                [Plant.Radishes; Plant.Violets; Plant.Clover; Plant.Radishes]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Eve",
    //                [Plant.Clover; Plant.Grass; Plant.Radishes; Plant.Grass]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Fred",
    //                [Plant.Grass; Plant.Clover; Plant.Violets; Plant.Clover]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Fred",
    //                [Plant.Grass; Plant.Clover; Plant.Violets; Plant.Clover]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Ginny",
    //                [Plant.Clover; Plant.Grass; Plant.Grass; Plant.Clover]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Harriet",
    //                [Plant.Violets; Plant.Radishes; Plant.Radishes; Plant.Violets]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Ileana",
    //                [Plant.Grass; Plant.Clover; Plant.Violets; Plant.Clover]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Joseph",
    //                [Plant.Violets; Plant.Clover; Plant.Violets; Plant.Grass]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Kincaid",
    //                [Plant.Grass; Plant.Clover; Plant.Clover; Plant.Grass]
    //            ),
    //            (
    //                "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV",
    //                "Larry",
    //                [Plant.Grass; Plant.Violets; Plant.Clover; Plant.Violets]
    //            )
    //        ] |> Seq.map FSharpValue.GetTupleFields

    //[<Theory>]
    //[<MemberData("KindergartenGardenTestData", MemberType=typeof<TestData>)>]
    //let ``Should get the correct plant with the given children in class`` (garden: string) (children: string) (expected: Plant list) =
    //    (garden, children)
    //    ||> KindergartenGarden.plants
    //    |> fun x -> Assert.StrictEqual(expected, x)

    let should (f: 'a -> ^b) expected actual =
        Assert.StrictEqual(expected, actual)

    let equal s = s
        

    [<Fact>]
    let ``Partial garden - garden with single student`` () =
        let student = "Alice"
        let diagram = "RC\nGG"
        let expected = [Plant.Radishes; Plant.Clover; Plant.Grass; Plant.Grass]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Partial garden - different garden with single student`` () =
        let student = "Alice"
        let diagram = "VC\nRC"
        let expected = [Plant.Violets; Plant.Clover; Plant.Radishes; Plant.Clover]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Partial garden - garden with two students`` () =
        let student = "Bob"
        let diagram = "VVCG\nVVRC"
        let expected = [Plant.Clover; Plant.Grass; Plant.Radishes; Plant.Clover]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Partial garden - multiple students for the same garden with three students - second student's garden`` () =
        let student = "Bob"
        let diagram = "VVCCGG\nVVCCGG"
        let expected = [Plant.Clover; Plant.Clover; Plant.Clover; Plant.Clover]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Partial garden - multiple students for the same garden with three students - third student's garden`` () =
        let student = "Charlie"
        let diagram = "VVCCGG\nVVCCGG"
        let expected = [Plant.Grass; Plant.Grass; Plant.Grass; Plant.Grass]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Alice, first student's garden`` () =
        let student = "Alice"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Violets; Plant.Radishes; Plant.Violets; Plant.Radishes]
        plants diagram student |> should equal expected 

    [<Fact>]
    let ``Full garden - for Bob, second student's garden`` () =
        let student = "Bob"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Clover; Plant.Grass; Plant.Clover; Plant.Clover]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Charlie`` () =
        let student = "Charlie"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Violets; Plant.Violets; Plant.Clover; Plant.Grass]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for David`` () =
        let student = "David"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Radishes; Plant.Violets; Plant.Clover; Plant.Radishes]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Eve`` () =
        let student = "Eve"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Clover; Plant.Grass; Plant.Radishes; Plant.Grass]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Fred`` () =
        let student = "Fred"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Grass; Plant.Clover; Plant.Violets; Plant.Clover]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Ginny`` () =
        let student = "Ginny"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Clover; Plant.Grass; Plant.Grass; Plant.Clover]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Harriet`` () =
        let student = "Harriet"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Violets; Plant.Radishes; Plant.Radishes; Plant.Violets]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Ileana`` () =
        let student = "Ileana"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Grass; Plant.Clover; Plant.Violets; Plant.Clover]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Joseph`` () =
        let student = "Joseph"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Violets; Plant.Clover; Plant.Violets; Plant.Grass]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Kincaid, second to last student's garden`` () =
        let student = "Kincaid"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Grass; Plant.Clover; Plant.Clover; Plant.Grass]
        plants diagram student |> should equal expected

    [<Fact>]
    let ``Full garden - for Larry, last student's garden`` () =
        let student = "Larry"
        let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
        let expected = [Plant.Grass; Plant.Violets; Plant.Clover; Plant.Violets]
        plants diagram student |> should equal expected
