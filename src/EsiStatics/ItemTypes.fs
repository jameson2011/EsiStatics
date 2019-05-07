namespace EsiStatics

module MarketGroups=
    let internal identity (value: MarketGroup)= value.Id

    [<CompiledName("GetMarketGroups")>]
    let marketGroups() =
        Data.ItemTypes.MarketGroups.marketGroups()
            |> Seq.map TypeMaps.ofMarketGroupData
            |> Seq.sortBy (fun mg -> mg.Name)
                
    [<CompiledName("GetRootMarketGroups")>]
    let rootMarketGroups()=
        Data.ItemTypes.MarketGroups.marketGroups()
            |> Seq.filter (fun mg -> Option.isNone mg.parentMarketGroupId)
            |> Seq.map TypeMaps.ofMarketGroupData
            |> Seq.sortBy (fun mg -> mg.Name)

    [<CompiledName("GetMarketGroup")>]
    let marketGroup (id: int)=
        id  |> Data.ItemTypes.MarketGroups.getMarketGroup
            |> Option.map TypeMaps.ofMarketGroupData

    [<CompiledName("GetChildMarketGroups")>]
    let childMarketGroups (value: MarketGroup)=
        Data.ItemTypes.MarketGroups.marketGroups()
            |> Seq.filter (fun mg -> match mg.parentMarketGroupId with
                                        | Some x -> x = value.Id
                                        | _ -> false)
            |> Seq.map TypeMaps.ofMarketGroupData
            |> Seq.sortBy (fun mg -> mg.Name)

    [<CompiledName("GetItemTypes")>]
    let itemTypes (value: MarketGroup)=
        value.Id
            |> (Data.ItemTypes.MarketGroups.getMarketGroup 
                    >> Option.get
                    >> fun mg -> mg.typeIds)
            |> Seq.map Data.ItemTypes.ItemTypes.getItemType
            |> Seq.reduceOptions
            |> Seq.map TypeMaps.ofItemTypeData
            |> Seq.sortBy (fun it -> it.Name)

    [<CompiledName("GetParent")>]
    let parent (value: MarketGroup)=
        value.Id
            |> (Data.ItemTypes.MarketGroups.getMarketGroup 
                    >> Option.get
                    >> fun mg -> mg.parentMarketGroupId)
            |> Option.bind marketGroup

    [<CompiledName("GetParents")>]
    let parentage (value: MarketGroup) =
        let rec walk group result =
            match group with
            | Some g -> walk (parent g) (g::result)
            | None ->   result
        walk (Some value) [] |> Seq.rev

module Categories =
    let internal identity (value: Category)= value.Id

    [<CompiledName("GetCategories")>]
    let categories() =
        Data.ItemTypes.Categories.categories()
            |> Seq.map TypeMaps.ofCategoryData
            

    [<CompiledName("GetCategory")>]
    let category (id: int)=
        id  |> Data.ItemTypes.Categories.getCategory
            |> Option.map TypeMaps.ofCategoryData

    [<CompiledName("GetGroups")>]
    let groups (value: Category)=
        value.Id
            |> (Data.ItemTypes.Categories.getCategory >> Option.get)
            |> (fun c -> c.groupIds)
            |> Seq.map (Data.ItemTypes.Groups.getGroup >> Option.get >> TypeMaps.ofGroupData)

module Groups=
    let internal identity (value: Group)= value.Id

    [<CompiledName("GetGroups")>]
    let groups ()=
        Data.ItemTypes.Groups.groups()
            |> Seq.map TypeMaps.ofGroupData

    [<CompiledName("GetGroup")>]
    let group (id: int)=
        id  |> Data.ItemTypes.Groups.getGroup
            |> Option.map TypeMaps.ofGroupData

    [<CompiledName("GetCategory")>]
    let category (value: Group) =
        value 
            |> argNull "value"
            |> identity
            |> (Data.ItemTypes.Groups.getGroup >> Option.get)
            |> (fun g -> g.categoryId)
            |> (Categories.category >> Option.get)

    [<CompiledName("GetItemTypes")>]
    let itemTypes (value: Group) =
        value 
            |> argNull "value"
            |> identity
            |> (Data.ItemTypes.Groups.getGroup >> Option.get)
            |> (fun g -> g.typeIds)
            |> Seq.map (Data.ItemTypes.ItemTypes.getItemType >> Option.get >> TypeMaps.ofItemTypeData)
            
module ItemTypes =
    let internal identity (value: ItemType)= value.Id

    [<CompiledName("GetItemTypes")>]
    let itemTypes() =
        Data.ItemTypes.ItemTypes.itemTypes()
            |> Seq.map TypeMaps.ofItemTypeData

    [<CompiledName("GetItemType")>]
    let itemType (id: int)=
        id  |> Data.ItemTypes.ItemTypes.getItemType
            |> Option.map TypeMaps.ofItemTypeData
            
    [<CompiledName("GetGroup")>]
    let group (value: ItemType) =
        value 
            |> argNull "value"
            |> (identity >> Data.ItemTypes.ItemTypes.getItemType >> Option.get)
            |> (fun it -> it.groupId)
            |> (Data.ItemTypes.Groups.getGroup >> Option.get >> TypeMaps.ofGroupData)
    
    [<CompiledName("GetMarketGroup")>]
    let marketGroup (value: ItemType) =
        value 
            |> argNull "value"
            |> (identity >> Data.ItemTypes.ItemTypes.getItemType >> Option.get)
            |> (fun it -> it.marketGroupId)
            |> Option.map (Data.ItemTypes.MarketGroups.getMarketGroup >> Option.get >> TypeMaps.ofMarketGroupData)
            
