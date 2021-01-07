namespace EsiStatics.UnitTests

open System
open EsiStatics
open Xunit
open FluentAssertions

module JumpNavigatorTests=

    let distanceFinder = new SolarSystemDistanceFinder(true)

    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin, 5, 5, 1., 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin, 5, 5, 0, 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 0, 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin, 5, 5, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin, 5, 5, 0., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 1., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 0., 4)>]

    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.thanatos, 5, 5, 1., 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.thanatos, 5, 5, 0, 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.thanatos, 5, 5, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.thanatos, 5, 5, 0, 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.thanatos, 5, 5, 1., 3)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.thanatos, 5, 5, 0., 3)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.thanatos, 5, 5, 1., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.thanatos, 5, 5, 0., 4)>]
    let findRoute(start, finish, ship, callibration: int, conservation: int, emptyStationsWeight: float, expectedJumps: int) =
        let route = [| start; finish |] |> Array.map knownSystem
        let ship = knownItemType ship

        let plan = JumpPlan.empty 
                    |> JumpRouteNavigation.calibration callibration
                    |> JumpRouteNavigation.conservation conservation
                    |> JumpRouteNavigation.route route
                    |> JumpRouteNavigation.ship ship
                    |> JumpRouteNavigation.distanceWeight 1.
                    |> JumpRouteNavigation.stationDockingWeight 0.
                    |> JumpRouteNavigation.avoidPochvenWeight 1.
                    |> JumpRouteNavigation.emptyStationsWeight emptyStationsWeight
                
        let r = JumpRouteNavigation.findRoute distanceFinder plan

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
                    |> JumpRouteNavigation.calibration callibration
                    |> JumpRouteNavigation.conservation conservation
                    |> JumpRouteNavigation.route route
                    |> JumpRouteNavigation.ship ship
                    |> JumpRouteNavigation.distanceWeight 1.
                    |> JumpRouteNavigation.stationDockingWeight 1.
                    |> JumpRouteNavigation.avoidPochvenWeight 1.
                    |> JumpRouteNavigation.emptyStationsWeight emptyStationsWeight
        
        
        let r = JumpRouteNavigation.findRoute distanceFinder plan

        r.Head.stages.Length.Should().NotBe(0, "") |> ignore
        r.Head.stages.Length.Should().Be(expectedJumps, "") |> ignore