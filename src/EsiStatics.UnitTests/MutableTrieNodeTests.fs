namespace EsiStatics.UnitTests

open System
open System.Linq
open Xunit
open FluentAssertions
open EsiStatics

module MutableTrieNodeTests=

    let words = [| "cba"; "aaa"; "aab"; "aac"; "aba"; "abb"; "abc"; "baa"; "bab" |]
    let values() = words |> Array.map (fun s -> (s, s))

    
    [<Fact>]
    let ``Empty Trie returns empty``() =
        let trie = MutableTrie.Create([])
        
        let matches = trie.Find ""

        matches.Should().BeEmpty("")
    

    [<Fact>]
    let ``Search for all - all returned``() =
        let trie = values() |> MutableTrie.Create
        
        let matches = trie.Find ""

        matches.Should().BeEquivalentTo(words)
    
    
    [<Fact>]
    let ``Search for unkonwn returns empty``() =
        let trie = values() |> MutableTrie.Create
        
        let matches = trie.Find "!"

        matches.Should().BeEmpty("")
    
    [<Theory>]
    [<InlineData("a")>]
    [<InlineData("aa")>]
    [<InlineData("aaa")>]
    [<InlineData("c")>]
    [<InlineData("!£$!\"")>]
    let ``Search returns prefixed words``(word) =
        let trie = values() |> MutableTrie.Create
        
        let matches = trie.Find word

        let expected = words |> Seq.filter (fun w -> w.StartsWith(word)) |> List.ofSeq

        matches.SequenceEqual(expected).Should().BeTrue("")
    
    
    [<Theory>]
    [<InlineData("a")>]
    [<InlineData("aa")>]
    [<InlineData("aaa")>]
    [<InlineData("c")>]
    let ``Search is case insensitive``(word: string) =
        let trie = values() |> MutableTrie.Create
        
        let matches = word.ToUpper() |> trie.Find

        let expected = words |> Seq.filter (fun w -> w.StartsWith(word)) |> List.ofSeq

        matches.SequenceEqual(expected).Should().BeTrue("")
    