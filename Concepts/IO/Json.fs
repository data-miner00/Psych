namespace Psych.Concepts.IO

open System
open System.IO

module Json =
    module Serde =
        open System.Text.Json
        open System.Text.Json.Serialization

        let private jsonOptions () =
            let options = JsonSerializerOptions()
            options.Converters.Add(JsonFSharpConverter())
            options

        let serialize object = 
            JsonSerializer.Serialize(object, jsonOptions())

        let deserialize (json: string) =
            JsonSerializer.Deserialize<'a> (json, jsonOptions())

    open Serde

    type Data =
        { Id: string; Name: string }

    let private getJsonFileName filename =
        filename + ".json"

    let private getJsonData filename =
        filename |> getJsonFileName |> File.ReadAllText

    let private build json : Data =
        json |> deserialize

    let private save data =
        (getJsonData data.Id, serialize data) |> File.WriteAllText

    let get filename =
        filename |> getJsonData |> build

    let put data =
        data |> save
        data
