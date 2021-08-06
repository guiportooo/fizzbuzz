open System

let from whom =
    $"from %s{whom}"

[<EntryPoint>]
let main argv =
    let message = from "F#"
    printfn $"Hello world %s{message}"
    0 