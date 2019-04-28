namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes69=
    let getDogmaAttribute id = 
      match id with 
      | 1136 -> { DogmaAttributeData.id= 1136; name= "scanAllStrength"; description= "Helper attribute for distribution dungeons."; published= false; unitId= Some(120); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1233 -> { DogmaAttributeData.id= 1233; name= "capacitySecondary"; description= "Secondary cargo space allowed, meant to supplement capacity. This is currently used exclusively for Strontium storage on starbases."; published= true; unitId= Some(9); defaultValue= 10000.000000; stackable= true; highIsGood= true } |> Some
      | 1330 -> { DogmaAttributeData.id= 1330; name= "isHacking"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1427 -> { DogmaAttributeData.id= 1427; name= "passiveHullExplosiveDamageResonance"; description= ""; published= true; unitId= Some(127); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1524 -> { DogmaAttributeData.id= 1524; name= "subsystemBonusMinmatarElectronic2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 166 -> { DogmaAttributeData.id= 166; name= "memory"; description= "The memory of a character."; published= true; unitId= Some(120); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1718 -> { DogmaAttributeData.id= 1718; name= "distributionIDGurista04"; description= "Distribution ID for sov upgrades in Guristas space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1815 -> { DogmaAttributeData.id= 1815; name= "neutReflectAmount"; description= ""; published= true; unitId= Some(111); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1912 -> { DogmaAttributeData.id= 1912; name= "spewContainerCount"; description= "The number of mini containers that are spewed out from this type, if it supports spewing."; published= true; unitId= Some(138); defaultValue= 20.000000; stackable= true; highIsGood= true } |> Some
      | 2009 -> { DogmaAttributeData.id= 2009; name= "entitySuperWeaponDuration"; description= "Used for NPCs to replicate cooldown functionality for the super weapon."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2106 -> { DogmaAttributeData.id= 2106; name= "lightningWeaponDamageLossTarget"; description= "Damage lost per target hit"; published= false; unitId= Some(111); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2203 -> { DogmaAttributeData.id= 2203; name= "fighterAbilityWarpDisruptionDuration"; description= "Duration"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2300 -> { DogmaAttributeData.id= 2300; name= "shipBonusRole3"; description= "Ship Role Bonus. Not multiplied by skills."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2397 -> { DogmaAttributeData.id= 2397; name= "durationWeaponDisruptionBurstProjector"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2494 -> { DogmaAttributeData.id= 2494; name= "behaviorRemoteArmorRepairDischarge"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2591 -> { DogmaAttributeData.id= 2591; name= "attributeAllShipsManufactureTimeMultiplier"; description= "Bonus that affects all ships being produced - for XL eng rigs"; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 263 -> { DogmaAttributeData.id= 263; name= "shieldCapacity"; description= "Amount of maximum shield HP on the item."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2688 -> { DogmaAttributeData.id= 2688; name= "structureHPBonusAdd"; description= ""; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2785 -> { DogmaAttributeData.id= 2785; name= "npcDroneBandwidth"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 360 -> { DogmaAttributeData.id= 360; name= "connectionsBonus"; description= "Bonus to standing towards Friendly npcs"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 457 -> { DogmaAttributeData.id= 457; name= "entityEquipmentMax"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 554 -> { DogmaAttributeData.id= 554; name= "signatureRadiusBonus"; description= "Autogenerated skill attribute, signatureRadiusBonus"; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 651 -> { DogmaAttributeData.id= 651; name= "decloakFieldRange"; description= "Range of broadcasted decloaking field."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 69 -> { DogmaAttributeData.id= 69; name= "rateBonus"; description= "Bonus to rate/conversion ratio."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 748 -> { DogmaAttributeData.id= 748; name= "shipBonusMBC1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 845 -> { DogmaAttributeData.id= 845; name= "hiddenLauncherDamageBonus"; description= "Hidden Attribute for tech 2 launcher damage bonus."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 942 -> { DogmaAttributeData.id= 942; name= "energyNeutralizerDuration"; description= "Duration of NPC Energy Neutralizer effect"; published= true; unitId= Some(101); defaultValue= 30000.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None