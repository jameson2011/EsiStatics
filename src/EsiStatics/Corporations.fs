namespace EsiStatics

module Corporations=
    [<CompiledName("GetNpcCorps")>]
    let npcCorps() =
        EsiStatics.Data.Misc.NpcCorps.npcCorps()
            |> Seq.map TypeMaps.ofNpcCorp
            |> Seq.sortBy (fun mg -> mg.Name)

    [<CompiledName("GetNpcCorp")>]
    let npcCorp (id: int)=
        id  |> Data.Misc.NpcCorps.getNpcCorp
            |> Option.map TypeMaps.ofNpcCorp
