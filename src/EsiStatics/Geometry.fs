namespace EsiStatics


module Geometry=
            
    let internal euclidean' (coords: seq<float>) =
        coords  |> Seq.map (float >> abs >> Math.sq)
                |> Seq.sum 
                |> sqrt
                

    /// Get a Euclidean distance between 2 Positions
    [<CompiledName("GetEuclidean")>]
    let euclidean (p1: Position) (p2: Position) =
        [ p1.x - p2.x; p1.y - p2.y; p1.z - p2.z ]
            |> Seq.map float
            |> euclidean'
            |> Units.toMetres


    
    
