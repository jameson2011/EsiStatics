namespace EsiStatics

type GroupsFinder(eagerIndex: bool)=

    let groupIndex =
        lazy (
            Data.ItemTypes.Groups.groups()
                |> Seq.map (fun g -> (g.name, g.id))
                |> ReadonlyTrie.Create
        )
        
    do  if eagerIndex then
            groupIndex.Value |> ignore

    new() = 
        GroupsFinder(false)
        
    member this.Find(search: string) =
        search
            |> argNull "search"
            |> groupIndex.Value.Find 
            |> Seq.map (EsiStatics.Groups.group >> Option.get)
                