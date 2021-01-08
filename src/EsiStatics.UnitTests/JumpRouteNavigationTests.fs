namespace EsiStatics.UnitTests

open System
open EsiStatics
open Xunit
open FsUnit.Xunit

module JumpRouteNavigationTests=
    
    [<Fact>]
    let ``validationErrors no ship``()=                
        let plan = JumpPlan.empty
                        |> JumpRouteNavigation.jumpFreighter 1 
                        |> JumpRouteNavigation.calibration 1
                        |> JumpRouteNavigation.conservation 1
                        |> JumpRouteNavigation.route ( [| KnownSystems.adirain; KnownSystems.jita |] |> Array.map KnownSystems.knownSystem )
                        
        let xs = JumpRouteNavigation.validationErrors plan

        xs.Length |> should equal 1
        
    [<Theory>]
    [<InlineData(0)>]
    [<InlineData(-1)>]
    [<InlineData(6)>]
    [<InlineData(10)>]
    let ``validationErrors invalid jump freighter``(value)= 
        let plan = JumpPlan.empty
                        |> JumpRouteNavigation.ship (KnownItemTypes.sin |> KnownItemTypes.knownItemType)
                        |> JumpRouteNavigation.jumpFreighter value
                        |> JumpRouteNavigation.calibration 1
                        |> JumpRouteNavigation.conservation 1
                        |> JumpRouteNavigation.route ( [| KnownSystems.adirain; KnownSystems.jita |] |> Array.map KnownSystems.knownSystem )
                        
        let xs = JumpRouteNavigation.validationErrors plan

        xs.Length |> should equal 1

    [<Theory>]
    [<InlineData(0)>]
    [<InlineData(-1)>]
    [<InlineData(6)>]
    [<InlineData(10)>]
    let ``validationErrors invalid calibration``(value)= 
        let plan = JumpPlan.empty
                        |> JumpRouteNavigation.ship (KnownItemTypes.sin |> KnownItemTypes.knownItemType)
                        |> JumpRouteNavigation.jumpFreighter 1
                        |> JumpRouteNavigation.calibration value
                        |> JumpRouteNavigation.conservation 1
                        |> JumpRouteNavigation.route ( [| KnownSystems.adirain; KnownSystems.jita |] |> Array.map KnownSystems.knownSystem )
                        
        let xs = JumpRouteNavigation.validationErrors plan

        xs.Length |> should equal 1

    [<Theory>]
    [<InlineData(0)>]
    [<InlineData(-1)>]
    [<InlineData(6)>]
    [<InlineData(10)>]
    let ``validationErrors invalid conservation``(value)= 
        let plan = JumpPlan.empty
                        |> JumpRouteNavigation.ship (KnownItemTypes.sin |> KnownItemTypes.knownItemType)
                        |> JumpRouteNavigation.jumpFreighter 1
                        |> JumpRouteNavigation.calibration 1
                        |> JumpRouteNavigation.conservation value
                        |> JumpRouteNavigation.route ( [| KnownSystems.adirain; KnownSystems.jita |] |> Array.map KnownSystems.knownSystem )
                        
        let xs = JumpRouteNavigation.validationErrors plan

        xs.Length |> should equal 1

    [<Fact>]
    let ``validationErrors empty route``()= 
        let plan = JumpPlan.empty
                        |> JumpRouteNavigation.ship (KnownItemTypes.sin |> KnownItemTypes.knownItemType)
                        |> JumpRouteNavigation.jumpFreighter 1
                        |> JumpRouteNavigation.calibration 1
                        |> JumpRouteNavigation.conservation 1
                        |> JumpRouteNavigation.route [||] 
                        
        let xs = JumpRouteNavigation.validationErrors plan

        xs.Length |> should equal 1

    [<Fact>]
    let ``validationErrors success``()= 
        let plan = JumpPlan.empty
                        |> JumpRouteNavigation.ship (KnownItemTypes.sin |> KnownItemTypes.knownItemType)
                        |> JumpRouteNavigation.jumpFreighter 5
                        |> JumpRouteNavigation.calibration 5
                        |> JumpRouteNavigation.conservation 5
                        |> JumpRouteNavigation.route ( [| KnownSystems.adirain; KnownSystems.jita |] |> Array.map KnownSystems.knownSystem )
                        
        let xs = JumpRouteNavigation.validationErrors plan

        xs.Length |> should equal 0
