namespace Psych.Concepts

open System
open System.Text.RegularExpressions

module Regex =
    /// <summary> 
    /// Find whether a string matches with `IsMatch` method that returns a flag.
    /// </summary>
    let findMatch =
        let words = [ "Seven"; "even"; "eleven"; "noven" ]
        let regex = Regex(@".even", RegexOptions.Compiled) // Compile regex for better performance

        words
        |> List.map
            (fun x ->
                if regex.IsMatch(x) then
                    printfn $"{x} matches"
                else
                    printfn $"{x} not match")

    /// <summary> 
    /// Find multiple possible matches with the `|` symbol.
    /// </summary>
    let alternateRegex =
        let users = [ "Becky"; "James"; "Andy"; "Steward" ]
        let regex = Regex(@"Jane|Becky|Steward", RegexOptions.Compiled)

        users |> List.filter regex.IsMatch |> List.iter (printfn "%s")

    /// <summary> 
    /// Find and return all matches within a single string.
    /// </summary>
    let findAll =
        let content = "Lorem ipsum dolor sit amet, ipsum lipsum picsum venedict"
        
        let found =
            seq {
                for m in Regex.Matches(content, "*sum") do
                    yield m.Value, m.Index
            }

        found
        |> Seq.iter (fun (value, index) -> printfn "%s at %d" value index)

    /// <summary> 
    /// Find text with word boundaries.
    /// </summary>
    let findBoundary =
        let content = "Thyne thy en limthy"
        let regex = Regex(@"\bthy\b", RegexOptions.Compiled)

        regex.Matches(content)
        |> Seq.map (fun m -> m.Value, m.Index)
        |> Seq.iter (fun (value, index) -> printfn "%s at %d" value index)

    /// <summary> 
    /// Searching for all types of currency symbol.
    /// </summary>
    let findCurrencySymbol =
        Console.OutputEncoding = Text.Encoding.UTF8

        let content = @"Currency symbols: ฿ Thailand bath, ₹  Indian rupee,
    ₾ Georgian lari, $ Dollar, € Euro, ¥ Yen, £ Pound Sterling";

        let regex = Regex(@"\p{Sc}")
        let matches = regex.Matches(content)
                      |> Seq.map (fun m -> m.Value, m.Index)

        matches |> Seq.iter (fun (value, index) -> printfn "%s at %d" value index)
        
    /// <summary> 
    /// Capturing groups defined within the Regex.
    /// </summary>
    let findGroups =
        let websites = ["google.com"; "facebook.com"; "zetcode.com"; "trivago"; "airbnb"]
        let regex = Regex(@"(\w+)\.(\w+)", RegexOptions.Compiled)
        
        let found =
            websites
            |> List.map
                (fun x ->
                    let m = regex.Match(x)
                    (m.Value, m.Groups[1], m.Groups[2])) // Indexing starts with 1

        printfn "%A" found

