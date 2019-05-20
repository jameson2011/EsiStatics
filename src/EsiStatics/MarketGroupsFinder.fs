namespace EsiStatics

type MarketGroupsFinder(eagerIndex: bool)=

    let marketGroupIndex =
        lazy (
            Data.ItemTypes.MarketGroups.marketGroups()
                    |> Seq.map (fun mg -> (mg.name, mg.id))
                    |> ReadonlyTrie.Create
        )
        
    do  if eagerIndex then
            marketGroupIndex.Value |> ignore

    new() = 
        MarketGroupsFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> marketGroupIndex.Value.Find 
            |> Seq.map (EsiStatics.MarketGroups.marketGroup >> Option.get)
          
