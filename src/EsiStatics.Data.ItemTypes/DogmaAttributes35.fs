namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes35=
    let getDogmaAttribute id = 
      match id with 
      | 1005 -> { DogmaAttributeData.id= 1005; name= "jumpPortalCapacitorNeed"; description= ""; published= true; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1102 -> { DogmaAttributeData.id= 1102; name= "boosterAttribute4"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1199 -> { DogmaAttributeData.id= 1199; name= "heatCapacityMed"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1296 -> { DogmaAttributeData.id= 1296; name= "consumptionQuantityBonusPercentage"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 132 -> { DogmaAttributeData.id= 132; name= "explosiveDamageResonanceMultiplier"; description= "Multiplier to the explosive damage resistance of something."; published= true; unitId= Some(111); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 1393 -> { DogmaAttributeData.id= 1393; name= "wormholeTargetRegion8"; description= "Specific target region 8 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1490 -> { DogmaAttributeData.id= 1490; name= "shieldExplosiveDamageResistanceBonus"; description= "Explosive resistance bonus for shields"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1684 -> { DogmaAttributeData.id= 1684; name= "ecuMaxVolume"; description= ""; published= true; unitId= None; defaultValue= 9.200000; stackable= true; highIsGood= true } |> Some
      | 1781 -> { DogmaAttributeData.id= 1781; name= "defaultCustomsOfficeTaxRate"; description= ""; published= false; unitId= None; defaultValue= 0.100000; stackable= true; highIsGood= true } |> Some
      | 1975 -> { DogmaAttributeData.id= 1975; name= "published"; description= "Dogma helper version of basic attribute, used to set published flag."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2072 -> { DogmaAttributeData.id= 2072; name= "scanGravimetricStrengthBonusBonus"; description= "Bonus to Gravimetric Strength bonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2266 -> { DogmaAttributeData.id= 2266; name= "speedFactorFloor"; description= ""; published= false; unitId= Some(124); defaultValue= -99.000000; stackable= true; highIsGood= true } |> Some
      | 229 -> { DogmaAttributeData.id= 229; name= "intelligenceSkillTrainingTimeMultiplierBonus"; description= "Bonus or penalty to the percentage time it takes to train skills with Intelligence as the primary attribute."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2363 -> { DogmaAttributeData.id= 2363; name= "shipBonusCarrierC1"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2460 -> { DogmaAttributeData.id= 2460; name= "eliteBonusLogistics3"; description= "third bonus for support cruisers"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2557 -> { DogmaAttributeData.id= 2557; name= "attributeAdvCompManufactureMaterialMultiplier"; description= "Decrease material requirement for manufacturing the following:  T2 Components, Tools, Data Interfaces, T3 Components        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2654 -> { DogmaAttributeData.id= 2654; name= "gfxTurretCount"; description= "Number of Turrets to fit for entity type ships"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2751 -> { DogmaAttributeData.id= 2751; name= "hiddenArmorHPMultiplier"; description= "Armor hitpoint attribute used by structures as a workaround for implementing Standup layered plating stacking penalties"; published= false; unitId= Some(104); defaultValue= 1.000000; stackable= false; highIsGood= true } |> Some
      | 326 -> { DogmaAttributeData.id= 326; name= "barrageDmgMultiplier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 423 -> { DogmaAttributeData.id= 423; name= "entityDroneCount"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 714 -> { DogmaAttributeData.id= 714; name= "consumptionQuantity"; description= "The amount of the given resource type needed to be consumed for each activation cycle of this structure."; published= true; unitId= Some(138); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 811 -> { DogmaAttributeData.id= 811; name= "shipBonusCI2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 908 -> { DogmaAttributeData.id= 908; name= "shipMaintenanceBayCapacity"; description= "The capacity of the hangar in a ship."; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None