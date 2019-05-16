namespace EsiStatics

type ItemTypesFinder()=
    
    let marketGroupIndex =
        Data.ItemTypes.MarketGroups.marketGroups()
                |> Seq.map (fun mg -> (mg.name, mg.id))
                |> ReadonlyTrie.Create
        

    let categoryIndex =
        Data.ItemTypes.Categories.categories()
            |> Seq.map (fun mg -> (mg.name, mg.id))
            |> ReadonlyTrie.Create
        
    
    let groupIndex =
        Data.ItemTypes.Groups.groups()
            |> Seq.map (fun mg -> (mg.name, mg.id))
            |> ReadonlyTrie.Create
        

    
    let itemTypeIndex =
        Data.ItemTypes.ItemTypes.itemTypes()
            |> Seq.map (fun mg -> (mg.name, mg.id))
            |> ReadonlyTrie.Create

    member this.FindMarketGroups(search: string) =
        search
            |> argNull "search"
            |> marketGroupIndex.Find 
            |> Seq.map (EsiStatics.MarketGroups.marketGroup >> Option.get)
          
    member this.FindCategories(search: string) =
        search
            |> argNull "search"
            |> categoryIndex.Find 
            |> Seq.map (EsiStatics.Categories.category >> Option.get)

    member this.FindGroups(search: string) =
        search
            |> argNull "search"
            |> groupIndex.Find 
            |> Seq.map (EsiStatics.Groups.group >> Option.get)
                
    member this.FindItemTypes(search: string) =
        search
            |> argNull "search"
            |> itemTypeIndex.Find 
            |> Seq.map (EsiStatics.ItemTypes.itemType >> Option.get)
