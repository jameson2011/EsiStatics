namespace EsiStatics.UnitTests

open System
open EsiStatics
open Xunit
open FluentAssertions

module JumpNavigatorTests=

    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin, 5, 5, 1., 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin, 5, 5, 0, 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 0, 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin, 5, 5, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin, 5, 5, 0., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 1., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 0., 4)>]
    let findRoute(start, finish, ship, callibration: int, conservation: int, emptyStationsWeight: float, expectedJumps: int) =
        let route = [| start; finish |] |> Array.map knownSystem
        let ship = knownItemType ship

        let plan = JumpPlan.empty 
                    |> JumpPlan.setCalibration callibration
                    |> JumpPlan.setConservation conservation
                    |> JumpPlan.setRoute route
                    |> JumpPlan.setShip ship
                    |> JumpPlan.setDistanceWeight 1.
                    |> JumpPlan.setStationDockingWeight 0.
                    |> JumpPlan.setAvoidPochvenWeight 1.
                    |> JumpPlan.setEmptyStationsWeight emptyStationsWeight
        
        let jn = new JumpNavigator(plan)

        let r = jn.FindRoute()

        r.Head.stages.Length.Should().NotBe(0, "") |> ignore
        r.Head.stages.Length.Should().Be(expectedJumps, "") |> ignore

    
    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.schoorasana, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.schoorasana, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 0., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 1., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 0., 4)>]
    let findMidpointRoute(start, mid, finish, ship, callibration: int, conservation: int, emptyStationsWeight: float, expectedJumps: int) =
        let route = [| start; mid; finish |] |> Array.map knownSystem
        let ship = knownItemType ship

        let plan = JumpPlan.empty 
                    |> JumpPlan.setCalibration callibration
                    |> JumpPlan.setConservation conservation
                    |> JumpPlan.setRoute route
                    |> JumpPlan.setShip ship
                    |> JumpPlan.setDistanceWeight 1.
                    |> JumpPlan.setStationDockingWeight 1.
                    |> JumpPlan.setAvoidPochvenWeight 1.
                    |> JumpPlan.setEmptyStationsWeight 1.
                    |> JumpPlan.setEmptyStationsWeight emptyStationsWeight
        
        let jn = new JumpNavigator(plan)

        let r = jn.FindRoute()

        r.Head.stages.Length.Should().NotBe(0, "") |> ignore
        r.Head.stages.Length.Should().Be(expectedJumps, "") |> ignore