namespace EsiStatics.UnitTests

open System
open EsiStatics
open Xunit
open FluentAssertions

module JumpNavigatorTests=

    let distanceFinder = new SolarSystemDistanceFinder()
    let solarSystemInfoProvider =  { 
        new ISolarSystemInfoProvider with
            member this.GetSolarSystemInfos() = [| |] }

    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin, 5, 5, 0., 1., 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin, 5, 5, 0., 0, 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin, 5, 5, 0, 1, 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 0, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 0, 0, 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 1, 1, 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin, 5, 5, 0., 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin, 5, 5, 0., 0., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin, 5, 5, 0., 0., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 0., 1., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 0., 0., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 0., 0., 4)>]

    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.thanatos, 5, 5, 0., 1., 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.thanatos, 5, 5, 0., 0., 1)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.thanatos, 5, 5, 0., 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.thanatos, 5, 5, 0., 0, 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.thanatos, 5, 5, 0., 1., 3)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.thanatos, 5, 5, 0., 0., 3)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.thanatos, 5, 5, 0., 1., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.thanatos, 5, 5, 0., 0., 4)>]
    [<InlineData(KnownSystems.jita, KnownSystems.hevrice, KnownItemTypes.rhea, 5, 5, 1., 1., 2)>]
    [<InlineData(KnownSystems.jita, KnownSystems.hevrice, KnownItemTypes.sin, 5, 5, 1., 1., 2)>]
    let findRoute(start, finish, ship, callibration: int, conservation: int, dockingStationsWeight: float, emptyStationsWeight: float, expectedJumps: int) =
        let route = [| start; finish |] |> Array.map knownSystem
        let ship = knownItemType ship

        let plan = JumpPlan.empty 
                    |> JumpRouteNavigation.calibration callibration
                    |> JumpRouteNavigation.conservation conservation
                    |> JumpRouteNavigation.jumpFreighter 5
                    |> JumpRouteNavigation.route route
                    |> JumpRouteNavigation.ship ship
                    |> JumpRouteNavigation.stationDockingWeight dockingStationsWeight
                    |> JumpRouteNavigation.emptyStationsWeight emptyStationsWeight
                    |> JumpRouteNavigation.distanceWeight 1.0
                    |> JumpRouteNavigation.jumpsWeight 1.0
        
        let r = JumpRouteNavigation.findRoute distanceFinder solarSystemInfoProvider plan

        r.Head.stages.Length.Should().NotBe(0, "") |> ignore
        r.Head.stages.Length.Should().Be(expectedJumps, "") |> ignore

    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.thanatos)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, KnownItemTypes.sin)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.thanatos)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.thanatos)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.amamake, KnownItemTypes.sin)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.thanatos)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.heild, KnownItemTypes.sin)>]
    [<InlineData(KnownSystems.jita, KnownSystems.hevrice, KnownItemTypes.thanatos)>]
    [<InlineData(KnownSystems.jita, KnownSystems.hevrice, KnownItemTypes.sin)>]
    let ``findRoute all scale to jump freighters``(start, finish, ship) =
        let route = [| start; finish |] |> Array.map knownSystem
        let ship = knownItemType ship
        let jf = knownItemType KnownItemTypes.rhea

        let plan = JumpPlan.empty 
                    |> JumpRouteNavigation.calibration 5
                    |> JumpRouteNavigation.conservation 5
                    |> JumpRouteNavigation.jumpFreighter 5
                    |> JumpRouteNavigation.route route
                    |> JumpRouteNavigation.stationDockingWeight 1.
                    |> JumpRouteNavigation.emptyStationsWeight 1.
                    |> JumpRouteNavigation.distanceWeight 1.0
                    |> JumpRouteNavigation.jumpsWeight 1.0

        let shipPlan = plan |> JumpRouteNavigation.ship ship
        let jfPlan = plan |> JumpRouteNavigation.ship jf
        
        let route = JumpRouteNavigation.findRoute distanceFinder solarSystemInfoProvider
        
        let shipRoute = route shipPlan |> Seq.head
        let jfRoute = route jfPlan |> Seq.head

        let shipRouteLen = shipRoute.stages.Length
        let jfRouteLen = jfRoute.stages.Length

        shipRouteLen.Should().BeGreaterOrEqualTo(jfRouteLen, "") |> ignore
        

    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownItemTypes.sin, KnownSystems.schoorasana, 2)>]
    let ``findRoute with SolarSystemInfo``(start, finish, ship, expectedMid, expectedJumps: int) =
        let route = [| start; finish |] |> Array.map knownSystem
        
        let solarSystemInfoProviderMock =  { 
            new ISolarSystemInfoProvider with
                member this.GetSolarSystemInfos() = [|  { SolarSystemInfo.solarSystemId = expectedMid; 
                                                                            jumps = Some 10; shipKills = None; podKills = None; npcKills = None;
                                                                            incursion = Some false; triglavian = Some false; edencom = Some false } |] 
            }

        let plan = JumpPlan.empty 
                    |> JumpRouteNavigation.calibration 5
                    |> JumpRouteNavigation.conservation 5
                    |> JumpRouteNavigation.route route
                    |> JumpRouteNavigation.ship (knownItemType ship)
                    |> JumpRouteNavigation.stationDockingWeight 1.
                    |> JumpRouteNavigation.emptyStationsWeight 1.

        let r = JumpRouteNavigation.findRoute distanceFinder solarSystemInfoProviderMock plan

        r.Head.stages.Length.Should().NotBe(0, "") |> ignore
        r.Head.stages.Length.Should().Be(expectedJumps, "") |> ignore
    
                    
    
    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.schoorasana, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 1., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.schoorasana, KnownSystems.avenod, KnownItemTypes.sin, 5, 5, 0., 2)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 1., 4)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, KnownSystems.heild, KnownItemTypes.sin, 5, 5, 0., 4)>]
    let ``findRoute with Midpoint``(start, mid, finish, ship, callibration: int, conservation: int, emptyStationsWeight: float, expectedJumps: int) =
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
        
        
        let r = JumpRouteNavigation.findRoute distanceFinder solarSystemInfoProvider plan

        r.Head.stages.Length.Should().NotBe(0, "") |> ignore
        r.Head.stages.Length.Should().Be(expectedJumps, "") |> ignore