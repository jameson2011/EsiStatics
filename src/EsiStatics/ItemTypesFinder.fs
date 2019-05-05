namespace EsiStatics

type ItemTypesFinder()=
    
    let marketGroupIndex =
        lazy (
            Data.ItemTypes.MarketGroups.marketGroups()
                    |> Seq.map (fun mg -> (mg.name, mg.id))
                    |> MutableTrie.Create
        )

    let categoryIndex =
        lazy (
            Data.ItemTypes.Categories.categories()
                |> Seq.map (fun mg -> (mg.name, mg.id))
                |> MutableTrie.Create
        )
    
    let groupIndex =
        lazy (
            Data.ItemTypes.Groups.groups()
                |> Seq.map (fun mg -> (mg.name, mg.id))
                |> MutableTrie.Create
        )

    
    let itemTypeIndex =
        lazy (
            Data.ItemTypes.ItemTypes.itemTypes()
                |> Seq.map (fun mg -> (mg.name, mg.id))
                |> MutableTrie.Create
        )

    member this.FindMarketGroups(search: string) =
        search
            |> argNull "search"
            |> marketGroupIndex.Value.Find 
            |> Seq.map (EsiStatics.MarketGroups.marketGroup >> Option.get)
          
    member this.FindCategories(search: string) =
        search
            |> argNull "search"
            |> categoryIndex.Value.Find 
            |> Seq.map (EsiStatics.Categories.category >> Option.get)

    member this.FindGroups(search: string) =
        search
            |> argNull "search"
            |> groupIndex.Value.Find 
            |> Seq.map (EsiStatics.Groups.group >> Option.get)
                
    member this.FindItemTypes(search: string) =
        search
            |> argNull "search"
            |> itemTypeIndex.Value.Find 
            |> Seq.map (EsiStatics.ItemTypes.itemType >> Option.get)
