namespace EsiStatics


module Navigation=

    open System.Collections.Generic

    let private getSys = SolarSystems.byId >> Option.get

    
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

    let euclideanSystemDistance (start: SolarSystem) (finish: SolarSystem) = 
        euclidean start.Position finish.Position |> float
        
    let euclideanSystemDistancePreferHighsec (start: SolarSystem) (finish: SolarSystem) = 
        match start.Level, finish.Level with
            | SecurityLevel.Highsec, SecurityLevel.Highsec -> 1.
            | _ -> 2.
        |> (*) (euclidean start.Position finish.Position |> float)
        
    let euclideanSystemDistanceAvoidHighsec (start: SolarSystem) (finish: SolarSystem) = 
        match start.Level, finish.Level with
            | SecurityLevel.Highsec, SecurityLevel.Highsec -> 2.
            | _ -> 1.
        |> (*) (euclidean start.Position finish.Position |> float)
    
    let findRoute (distanceOf: SolarSystem -> SolarSystem -> float)  (start: SolarSystem, finish: SolarSystem) =
        
        let closed = new HashSet<int>()
        let todo = new MutablePriorityQueue<float, SolarSystem>()
        let todo = todo.Push(0., start)

        let cameFrom = new Dictionary<int, int>()
        let gScore = new Dictionary<int, float>()
        gScore.[start.Id] <- 0.0

        

        let rec backWalk current result  =
            match current with
            | x when x = start.Id -> result
            | _ ->  let next = cameFrom.[current]
                    backWalk next (next :: result)
        
        
        
        let rec find (todo: MutablePriorityQueue<float, SolarSystem>)= 
            
            match todo.Pop() with
            | None -> []
            | Some (distance, current) -> 

                        if (current.Id = finish.Id) then                    
                            backWalk current.Id [ current.Id ]                    
                        else                    
                            
                            closed.Add current.Id |> ignore

                            let neighbours = SolarSystems.neighbourIds current.Id
                                                |> Seq.filter (closed.Contains >> not)                                        
                                                |> Seq.map (fun s ->    let sys = getSys s
                                                                        (distanceOf sys finish), sys) 
                                                |> List.ofSeq

                            // adjust best known paths
                            neighbours 
                                |> Seq.iter (fun (d,s) ->   let tentative = distance + (distanceOf current s)
                                                            if (gScore.ContainsKey(s.Id) |> not) 
                                                                    || (gScore.[s.Id] > tentative) then
                                                                cameFrom.[s.Id] <- current.Id
                                                                gScore.[s.Id] <- tentative  )
                            // construct todo  
                            neighbours 
                                    |> Seq.map (fun (d,s) -> gScore.[s.Id] + d, s)   
                                    |> Seq.iter (fun (d,s) -> todo.Push(d,s) |> ignore)
                        

                            find todo

        find todo
            |> List.filter (fun s -> s <> start.Id)
            |> List.map (SolarSystems.byId >> Option.get)

    [<CompiledName("FindDirectRoute")>]
    let findDirectRoute(start, finish) = findRoute euclideanSystemDistance (start, finish)
