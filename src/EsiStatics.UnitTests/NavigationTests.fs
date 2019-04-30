namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions
open EsiStatics

module NavigationTests=


    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, 14)>]
    [<InlineData(30013489, KnownSystems.adirain, 18)>]
    [<InlineData(30013489, KnownSystems.avenod, 20)>]
    [<InlineData(30013489, KnownSystems.jita, 10)>]
    let ``findRoute euclidean``(start, finish, expected) =
        let s = start |> SolarSystems.byId |> Option.get
        let f = finish |> SolarSystems.byId |> Option.get

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanSystemDistance

        Assert.Equal(result.Length, expected)

    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, 14)>]
    [<InlineData(30013489, KnownSystems.adirain, 18)>]
    [<InlineData(30013489, KnownSystems.avenod, 20)>]
    [<InlineData(30013489, KnownSystems.jita, 10)>]
    let ``findRoute euclidean highsec preferred``(start, finish, expected) =
        let s = start |> SolarSystems.byId |> Option.get
        let f = finish |> SolarSystems.byId |> Option.get

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanSystemDistancePreferHighsec

        Assert.Equal(result.Length, expected)
        