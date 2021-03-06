﻿namespace EsiStatics

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
        let msgs = messages |> Array.ofSeq
        if msgs.Length > 0 then 
            let msg = msgs |> String.join Environment.NewLine
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
    let maxSafe defaultValue values = 
        if values |> Seq.isEmpty then defaultValue
        else values |> Seq.max
    let minSafe defaultValue values = 
        if values |> Seq.isEmpty then defaultValue
        else values |> Seq.min


module internal Math=
    let sq (x: float) = x * x
    let abs (x: float) = Math.Abs(x)

