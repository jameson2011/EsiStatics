namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions
open EsiStatics

module NavigationTests=


    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, 15)>]
    [<InlineData(30013489, KnownSystems.adirain, 19)>]
    [<InlineData(30013489, KnownSystems.avenod, 21)>]
    [<InlineData(30013489, KnownSystems.jita, 11)>]
    let ``findRoute euclidean``(start, finish, expected) =
        let s = start |> SolarSystems.byId |> Option.get
        let f = finish |> SolarSystems.byId |> Option.get

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanDistance

        Assert.Equal(result.Length, expected)

    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, 15)>]
    [<InlineData(30013489, KnownSystems.adirain, 19)>]
    [<InlineData(30013489, KnownSystems.avenod, 21)>]
    [<InlineData(30013489, KnownSystems.jita, 11)>]
    let ``findRoute euclidean highsec preferred``(start, finish, expected) =
        let s = start |> SolarSystems.byId |> Option.get
        let f = finish |> SolarSystems.byId |> Option.get

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanDistancePreferHighsec

        Assert.Equal(result.Length, expected)
        