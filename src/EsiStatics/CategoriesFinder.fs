namespace EsiStatics

type CategoriesFinder(eagerIndex: bool)=

    let categoryIndex =
        lazy (
            Data.ItemTypes.Categories.categories()
                |> Seq.map (fun c -> (c.name, c.id))
                |> ReadonlyTrie.Create
        )
            
    do  if eagerIndex then
            categoryIndex.Value |> ignore
            
    new() = 
        CategoriesFinder(false)
        
    member this.Find(search: string) =
        search
            |> argNull "search"
            |> categoryIndex.Value.Find 
            |> Seq.map (EsiStatics.Categories.category >> Option.get)
            