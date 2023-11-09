namespace Psych.Concepts.Syntax

open FSharp.Data

module Async =
    let getHtml (source: string) =
        async {
            let! html = HtmlDocument.AsyncLoad(source)
            return html
        }

    let downloadAndUpload (source: string) (destination: string) =
        let download file : Async<string> = failwith "not impl"
        let upload file url : Async<unit> = failwith "not impl"

        async {
            let! contents = download "text.txt"
            do! upload "text2.txt" "text.txt"
            return "Ok"
        }

    "https://google.com"
    |> getHtml // Async<HtmlDocument>
    |> Async.RunSynchronously // HtmlDocument
    |> ignore

    [ "https://google.com"
      "https://github.com"
      "https://facebook.com" ]
    |> List.map getHtml // Async<HtmlDocument> list
    |> Async.Parallel // Async<HtmlDocument []>, not ordered, use Async.Sequential for order
    |> Async.RunSynchronously // HtmlDocument []
    |> ignore

    open System.Net.Http
    
    let getHtmlTask (source: string) =
        async {
            use client = new HttpClient()
            let! html = client.GetStringAsync(source) |> Async.AwaitTask
            let parsedHtml = HtmlDocument.Parse html
            return parsedHtml
        }

    "https://google.com"
    |> getHtmlTask
    |> Async.RunSynchronously
    |> ignore
