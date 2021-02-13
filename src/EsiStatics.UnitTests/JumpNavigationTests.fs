namespace EsiStatics.UnitTests

open System
open EsiStatics
open EsiStatics.Data.Entities
open Xunit
open FluentAssertions

module JumpNavigation=
    
    let internal defaultSystem =
        KnownSystems.amamake
            |> Data.Universe.SolarSystems.getSolarSystem
            |> Option.get

    let internal defaultStation = 
        defaultSystem.stationIds
            |> Seq.map (Data.Universe.Stations.getStation >> Option.get)
            |> Seq.head

    let internal defaultStage = 
        { JumpStageData.distanceToDestination = (Units.toLY 0.);
            system = defaultSystem;
            score = 0.;
            isotopesToDestination = 0.;
            stations = [||];
            nearestHighsecSystem = None;
            jumps = None;
            shipKills = None;
            podKills = None;
            incursion = None;
            triglavian = None;
            edencom = None;
            }
    
    let internal defaultStats = { JumpStageDataStats.maxDistance = 0.; minDistance = 0.; maxJumps = 0.; minJumps = 0.; minKills = 0; maxKills = 0;  }

    [<Theory>]
    [<InlineData(KnownStations.instadockStation, 1.)>]
    [<InlineData(KnownStations.kickoutStation, 0.)>]
    [<InlineData(KnownStations.averageStation, 0.5)>]
    let ``dockableStationScore``(stationId, expected: float)=        
        
        let station = EsiStatics.Stations.byId stationId |> Option.get

        let score = JumpNavigation.dockableStationScore station

        score.Should().Be(expected, "")

    [<Theory>]
    [<InlineData(0, 0, 0, 0., 0.)>]    
    [<InlineData(1, 0, 2, 0., 0.)>]
    [<InlineData(0, 0, 0, 1., 0.)>]
    [<InlineData(0, 0, 1, 1., 0.)>]
    [<InlineData(1, 0, 1, 1., 1.)>]
    [<InlineData(1, 0, 2, 1., 0.5)>]    
    [<InlineData(1, 1, 2, 1., 1.)>]    
    let ``scoreJumpStage kills ``(shipKills, podKills, maxKills, weight, expectedScore: float)=
        let plan = JumpPlan.empty 
                        |> JumpRouteNavigation.emptyStationsWeight 0.
                        |> JumpRouteNavigation.stationDockingWeight 0.
                        |> JumpRouteNavigation.distanceWeight 0.
                        |> JumpRouteNavigation.avoidPochvenWeight 0.
                        |> JumpRouteNavigation.jumpsWeight 0.
                        |> JumpRouteNavigation.killsWeight weight

        let system = { defaultSystem with id = 1 }
        let stats = { defaultStats with maxKills = maxKills }
        let stage = { defaultStage with podKills = Some podKills; shipKills = Some shipKills} 

        let score =  stage |> JumpNavigation.scoreJumpStage stats plan system

        score.Should().Be(expectedScore, "")

    [<Theory>]
    [<InlineData(0, 0, 0., 0.)>]    
    [<InlineData(1, 2, 0., 0.)>]
    [<InlineData(0, 0, 1., 0.)>]
    [<InlineData(0, 1, 1., 0.)>]
    [<InlineData(1, 1, 1., 1.)>]
    [<InlineData(1, 2, 1., 0.5)>]    
    [<InlineData(2, 2, 1., 1.)>]    
    let ``scoreJumpStage jumps``(jumps, maxJumps, weight, expectedScore: float)=
        let plan = JumpPlan.empty 
                        |> JumpRouteNavigation.emptyStationsWeight 0.
                        |> JumpRouteNavigation.stationDockingWeight 0.
                        |> JumpRouteNavigation.distanceWeight 0.
                        |> JumpRouteNavigation.avoidPochvenWeight 0.
                        |> JumpRouteNavigation.killsWeight 0.
                        |> JumpRouteNavigation.jumpsWeight weight

        let system = { defaultSystem with id = 1 }
        let stats = { defaultStats with maxJumps = maxJumps }
        let stage = { defaultStage with jumps = Some jumps} 

        let score =  stage |> JumpNavigation.scoreJumpStage stats plan system

        score.Should().Be(expectedScore, "")

    [<Theory>]
    [<InlineData(0, 0, 0., 0.)>]    
    [<InlineData(1000, 2000, 0., 0.)>]
    [<InlineData(0, 0, 1000., 0.)>]
    [<InlineData(0, 1000, 1., 0.)>]
    [<InlineData(1000, 1000, 1., 1.)>]
    [<InlineData(1000, 2000, 1., 0.5)>]    
    [<InlineData(2000, 2000, 1., 1.)>]    
    let ``scoreJumpStage distances``(distance, maxDistance, weight, expectedScore: float)=
        let plan = JumpPlan.empty 
                        |> JumpRouteNavigation.emptyStationsWeight 0.
                        |> JumpRouteNavigation.stationDockingWeight 0.
                        |> JumpRouteNavigation.distanceWeight weight
                        |> JumpRouteNavigation.avoidPochvenWeight 0.
                        |> JumpRouteNavigation.killsWeight 0.
                        |> JumpRouteNavigation.jumpsWeight 0.

        let system = { defaultSystem with id = 1 }
        let stats = { defaultStats with maxDistance = maxDistance }
        let stage = { defaultStage with distanceToDestination = distance} 

        let score =  stage |> JumpNavigation.scoreJumpStage stats plan system

        score.Should().Be(expectedScore, "")

    [<Theory>]
    [<InlineData(0, 0., 0.)>]    
    [<InlineData(1, 0., 0.)>]
    [<InlineData(0, 1., 1.)>]
    [<InlineData(1, 1., 0.)>]
    [<InlineData(2, 1., 0.)>]    
    [<InlineData(3, 1., 0.)>]    
    let ``scoreJumpStage emptyStations``(stations, weight, expectedScore: float)=
        let plan = JumpPlan.empty 
                        |> JumpRouteNavigation.emptyStationsWeight weight
                        |> JumpRouteNavigation.stationDockingWeight 0.
                        |> JumpRouteNavigation.distanceWeight 0.
                        |> JumpRouteNavigation.avoidPochvenWeight 0.
                        |> JumpRouteNavigation.killsWeight 0.
                        |> JumpRouteNavigation.jumpsWeight 0.

        let system = { defaultSystem with id = 1; stationIds = [| 0 .. (stations-1) |] }
        let stats = defaultStats 
        let stage = { defaultStage with stations = [| 0 .. (stations-1) |] |> Array.map (fun _ -> defaultStation) }

        let score =  stage |> JumpNavigation.scoreJumpStage stats plan system

        score.Should().Be(expectedScore, "")