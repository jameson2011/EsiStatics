namespace EsiStatics

open System

[<AutoOpen>]
module internal Throws=
    open System

    let argNull name value =
        if Object.ReferenceEquals(value, null) then
            ArgumentNullException(name) |> raise 
        else value


module internal Seq=
    let reduceOptions values = values |> Seq.filter Option.isSome |> Seq.map Option.get

module internal Math=
    let sq (x: float) = x * x

