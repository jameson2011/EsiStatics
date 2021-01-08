namespace EsiStatics

open System

module internal String =
    let lower (value: string) = value.ToLower()
    let join (separator) (lines: seq<string>) = System.String.Join(separator, lines)

[<AutoOpen>]
module internal Throws=    
    let argNull name value =
        if Object.ReferenceEquals(value, null) then
            ArgumentNullException(name) |> raise 
        else value

    let invalidOp (predicate: 'a -> bool) (message)  (value: 'a) =
        if predicate value |> not then   
            InvalidOperationException(message) |> raise
        value

    let invalidOpIfNotEmpty (messages: seq<string>) =        
        let msg = messages |> String.join Environment.NewLine
        if msg.Length > 0 then 
            InvalidOperationException(msg) |> raise
        

module internal Seq=
    let reduceOptions values = values |> Seq.filter Option.isSome |> Seq.map Option.get
    let removeConsecutives (values) =        
        let rec reduce result values =
            match values with
            | [] ->     result
            | h::t ->   let tail = t |> List.skipWhile(fun x -> x = h)
                        reduce (h::result) tail
        values |> List.ofSeq |> reduce [] |> List.rev

module internal Math=
    let sq (x: float) = x * x
    let abs (x: float) = Math.Abs(x)

