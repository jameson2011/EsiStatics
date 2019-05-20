namespace EsiStatics

type ItemTypesFinder(eagerIndex: bool)=
    
    let itemTypeIndex =
        lazy (
            Data.ItemTypes.ItemTypes.itemTypes()
                |> Seq.map (fun mg -> (mg.name, mg.id))
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
