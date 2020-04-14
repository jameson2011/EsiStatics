namespace EsiStatics


[<Measure>] type m
[<Measure>] type km
[<Measure>] type AU
[<Measure>] type LY
[<Measure>] type m3
[<Measure>] type kg
[<Measure>] type K

[<AutoOpen>]
module Units=
    [<Literal>]
    let kmFactor = 1000.0

    [<Literal>]
    let auFactor = 149597870700.0

    [<Literal>]
    let lyFactor = 9460730472580800.0

    /// Convert an arbitrary float to Metres
    [<CompiledName("ToMetres")>]
    let toMetres (x: float) = x * 1.0<m>

    /// Convert Metres to Kilometres
    [<CompiledName("MetresToKm")>]
    let metresToKm (x: float<m>) = 
        ((float x) / kmFactor) * 1.0<km>

    /// Convert Metres to AU
    [<CompiledName("MetresToAu")>]
    let metresToAU (x: float<m>) = 
        ((float x) / auFactor)  * 1.0<AU>

    /// Convert Metres to Light years
    [<CompiledName("MetresToLy")>]
    let metresToLY (x: float<m>) = 
        ((float x) / lyFactor)  * 1.0<LY>
        
    /// Convert Kilometres to Metres
    [<CompiledName("KmToMetres")>]
    let kmToMetres (x: float<km>) = 
        (float x) * kmFactor<m>

    /// Convert AU to Metres
    [<CompiledName("AuToMetres")>]
    let auToMetres (x: float<AU>) = 
        ((float x) * auFactor) |> toMetres

    /// Convert Light years to Metres
    [<CompiledName("LyToMetres")>]
    let lyToMetres (x: float<LY>) = 
        ((float x) * lyFactor) |> toMetres
        
    /// Convert an arbitrary float to cubic metres
    [<CompiledName("ToCubicMetres")>]
    let toCubicMetres (x: float) = x * 1.0<m3>

    /// Convert an arbitrary float to kilogrammes
    [<CompiledName("ToKilos")>]
    let toKilos (x: float) = x * 1.0<kg>

    /// Convert an arbitrary float to Kelvin
    [<CompiledName("ToKelvin")>]
    let toKelvin (x: float) = x * 1.0<K>
