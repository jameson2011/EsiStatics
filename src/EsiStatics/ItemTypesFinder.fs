namespace EsiStatics

type ItemTypesFinder(eagerIndex: bool)=
    
    let itemTypeIndex =
        lazy (
            Data.ItemTypes.ItemTypes.itemTypes()
                |> Seq.filter (fun it -> it.published)
                |> Seq.map (fun it -> (it.name, it.id))
                |> ReadonlyTrie.Create
        )
                
    do  if eagerIndex then
            itemTypeIndex.Value |> ignore
            
    new() = 
        ItemTypesFinder(false)
                        
    member this.Find(search: string) =
        search
            |> argNull "search"
            |> itemTypeIndex.Value.Find 
            |> Seq.map (EsiStatics.ItemTypes.itemType >> Option.get)
