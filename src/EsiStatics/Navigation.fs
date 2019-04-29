namespace EsiStatics


module Navigation=

    open System.Collections.Generic

    let private getSys = SolarSystems.byId >> Option.get

    let euclideanDistance (start: SolarSystem) (finish: SolarSystem) = 
        Geospatial.euclidean start.Position finish.Position |> float
        
    let euclideanDistancePreferHighsec (start: SolarSystem) (finish: SolarSystem) = 
        match start.Level, finish.Level with
            | SecurityLevel.Highsec, SecurityLevel.Highsec -> 1.
            | _ -> 2.
        |> (*) (Geospatial.euclidean start.Position finish.Position |> float)
        
    let euclideanDistancePreferNotHighsec (start: SolarSystem) (finish: SolarSystem) = 
        match start.Level, finish.Level with
            | SecurityLevel.Highsec, SecurityLevel.Highsec -> 2.
            | _ -> 1.
        |> (*) (Geospatial.euclidean start.Position finish.Position |> float)
    
    let findRoute (distanceOf: SolarSystem -> SolarSystem -> float)  (start: SolarSystem, finish: SolarSystem) =
        let startId = start.Id;
        let closed = new HashSet<int>()
        let todo = new MutablePriorityQueue<float, int>()
        let todo = todo.Push(0., start.Id)

        let cameFrom = new Dictionary<int, int>()
        let gScore = new Dictionary<int, float>()
        gScore.[startId] <- 0.0

        

        let rec backWalk current result  =
            match current with
            | x when x = startId -> result
            | _ ->  let next = cameFrom.[current]
                    backWalk next (next :: result)
        
        
        
        let rec find (todo: MutablePriorityQueue<float, int>)= 
            
            match todo.Pop() with
            | None -> []
            | Some (distance, current) -> 

                        if (current = finish.Id) then                    
                            backWalk current [ current ]                    
                        else                    
                            let currentSystem = getSys current
                            closed.Add current |> ignore

                            let neighbours = SolarSystems.neighbourIds current
                                                |> Seq.filter (closed.Contains >> not)                                        
                                                |> Seq.map (fun s ->  (distanceOf (getSys s ) finish),  s) 
                                                |> List.ofSeq

                            // adjust best known paths
                            neighbours 
                                |> Seq.iter (fun (d,s) ->   let tentative = distance + (distanceOf currentSystem (getSys s) )
                                                            if (gScore.ContainsKey(s) |> not) 
                                                                    || (gScore.[s] > tentative) then
                                                                cameFrom.[s] <- current
                                                                gScore.[s] <- tentative  )
                            // construct todo  
                            neighbours 
                                    |> Seq.map (fun (d,n) -> gScore.[n] + d, n)   
                                    |> Seq.iter (fun (p,v) -> todo.Push(p,v) |> ignore)
                        

                            find todo

        find todo
            |> List.map (SolarSystems.byId >> Option.get)

