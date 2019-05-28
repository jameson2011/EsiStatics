namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions
open EsiStatics

module NavigationTests=

    
    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, 14)>]
    [<InlineData(KnownSystems.deepari, KnownSystems.adirain, 18)>]
    [<InlineData(KnownSystems.deepari, KnownSystems.avenod, 20)>]
    [<InlineData(KnownSystems.deepari, KnownSystems.jita, 10)>]
    [<InlineData(KnownSystems.raeghoscon, KnownSystems.adirain, 6)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, 13)>] // should be 6
    let ``findRoute euclidean``(start, finish, expected) =
        let s = start |> knownSystem
        let f = finish |> knownSystem
        
        let result = (s, f) |> Navigation.findRoute Navigation.euclideanSystemDistance

        Assert.Equal(result.Length, expected)


    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, 14)>] // should be 13
    [<InlineData(KnownSystems.avenod, KnownSystems.adirain, 13)>] // ???
    [<InlineData(KnownSystems.deepari, KnownSystems.adirain, 18)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.deepari, 18)>]
    [<InlineData(KnownSystems.deepari, KnownSystems.avenod, 20)>]
    [<InlineData(KnownSystems.avenod, KnownSystems.deepari, 20)>]
    [<InlineData(KnownSystems.deepari, KnownSystems.jita, 10)>]
    [<InlineData(KnownSystems.jita, KnownSystems.deepari, 10)>]
    let ``findRoute euclidean highsec preferred``(start, finish, expected) =
        let s = start |> knownSystem
        let f = finish |> knownSystem

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanSystemDistancePreferHighsec

        Assert.Equal(result.Length, expected)
    
    [<Theory>]
    [<InlineData(KnownSystems.adirain, KnownSystems.avenod, 15)>]
    [<InlineData(KnownSystems.avenod, KnownSystems.adirain, 15)>]
    [<InlineData(KnownSystems.raeghoscon, KnownSystems.adirain, 6)>]
    [<InlineData(KnownSystems.adirain, KnownSystems.raeghoscon, 6)>]
    [<InlineData(KnownSystems.heild, KnownSystems.avenod, 27)>]
    [<InlineData(KnownSystems.avenod, KnownSystems.heild, 27)>]
    let ``findRoute euclidean highsec avoided``(start, finish, expected) =
        let s = start |> knownSystem
        let f = finish |> knownSystem

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanSystemDistanceAvoidHighsec

        Assert.Equal(result.Length, expected)
    

    [<Theory>]
    [<InlineData(KnownSystems.thera, KnownSystems.jita)>]
    let ``findRoute on WH returns empty``(start, finish) =
        let s = start |> knownSystem
        let f = finish |> knownSystem

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanSystemDistance

        Assert.Equal(result.Length, 0)

    
    [<Theory>]
    [<InlineData(KnownSystems.jita, KnownSystems.jita)>]
    let ``findRoute on self returns empty``(start, finish) =
        let s = start |> knownSystem
        let f = finish |> knownSystem

        let result = (s, f) |> Navigation.findRoute Navigation.euclideanSystemDistance

        Assert.Equal(result.Length, 0)
