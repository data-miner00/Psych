namespace Psych.Concepts.Syntax

open FSharp.Data
open System.IO

module Interface =
    type IHtmlParser =
        abstract member ParseHtml : string -> HtmlDocument

    type WebParser() =
        interface IHtmlParser with
            member this.ParseHtml url = HtmlDocument.Load(url)

        member this.ParseHtml url = (this :> IHtmlParser).ParseHtml(url) // Expose the method to public

    type FileParser() =
        interface IHtmlParser with
            member this.ParseHtml filePath =
                filePath
                |> File.ReadAllText
                |> HtmlDocument.Parse

        member this.ParseHtml filePath = (this :> IHtmlParser).ParseHtml(filePath)

    let classWebParser = WebParser() :> IHtmlParser
    let classFileParser = FileParser() :> IHtmlParser

    let parseHtml (parser: IHtmlParser) (source: string) = parser.ParseHtml source

    parseHtml classWebParser "https://google.com" |> ignore
    parseHtml classFileParser "non exist path" |> ignore
