module Request

open System.IO
open FSharp.Data

let makeHttpRequest =
    let html = Http.RequestString("https://docs.microsoft.com/dotnet/fsharp/")
    printfn $"{html}"

let getHtml (htmlFile: string): HtmlDocument option =
    try
        let html = HtmlDocument.Load(htmlFile)
        Some(html)
    with
    | ex ->
        printfn "Error: %A" ex
        None

let private local =
    Path.Join("xx", "xx.html") |> ignore

    ()

(* Get all anchor tags within a html file *)
let getLinks (html: HtmlDocument option) =
    match html with
    | Some (x) -> x.Descendants ["a"]
    | None -> Seq.empty
