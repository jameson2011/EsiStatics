namespace EsiStatics.UnitTests

open System
open EsiStatics
open Xunit
open FluentAssertions

module JumpNavigation=


    [<Theory>]
    [<InlineData(KnownStations.instadockStation, 1.)>]
    [<InlineData(KnownStations.kickoutStation, 0.)>]
    [<InlineData(KnownStations.averageStation, 0.5)>]
    let ``dockableStationScore``(stationId, expected: float)=        
        
        let station = EsiStatics.Stations.byId stationId |> Option.get

        let score = JumpNavigation.dockableStationScore station

        score.Should().Be(expected, "")