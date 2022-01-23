namespace Psych.Functions

open System.Security.Cryptography
open System.Text

(* Code design from https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp/21109622 *)
module Hash =
    let private GetHash(input: string) =
        using(SHA256.Create()) (fun algo -> algo.ComputeHash(Encoding.UTF8.GetBytes input))

    let GetHashString(input: string) =

        GetHash(input)
        |> Array.map (fun b -> b.ToString("X2"))
        |> Seq.reduce (+)

    let GetHashString'(input: string) =
        let check = match input with
                    | input when input.Length = 0 -> None
                    | _ -> Some(input)

        let HashAlgorithm(input: string) =
            using(new SHA256Managed())(fun sha ->
                let textData = Encoding.UTF8.GetBytes input
                let hash = sha.ComputeHash textData
                System.BitConverter.ToString(hash).Replace("-", System.String.Empty)
            )

        match check with
        | Some(value) -> HashAlgorithm value
        | None -> System.String.Empty
