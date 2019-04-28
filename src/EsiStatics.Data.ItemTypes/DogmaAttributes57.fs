namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes57=
    let getDogmaAttribute id = 
      match id with 
      | 1027 -> { DogmaAttributeData.id= 1027; name= "scanGravimetricStrengthPercent"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1124 -> { DogmaAttributeData.id= 1124; name= "inventionMaxRunModifier"; description= "Modifies the max runs in a blueprint created through invention"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1221 -> { DogmaAttributeData.id= 1221; name= "jumpDelayDuration"; description= "Delay in seconds; until you can jump again."; published= true; unitId= Some(123); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1318 -> { DogmaAttributeData.id= 1318; name= "warpScrambleStrengthHidden"; description= "warpScrambleStrengthHidden"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1512 -> { DogmaAttributeData.id= 1512; name= "subsystemBonusAmarrPropulsion2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 154 -> { DogmaAttributeData.id= 154; name= "proximityRange"; description= "The distance at which to react when relevant objects come within range."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1609 -> { DogmaAttributeData.id= 1609; name= "distributionID_serpentis"; description= "Obsolete attribute"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 1706 -> { DogmaAttributeData.id= 1706; name= "distributionIDBlood02"; description= "Distribution ID for sov upgrades in Blood Raider space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1803 -> { DogmaAttributeData.id= 1803; name= "MWDSignatureRadiusBonus"; description= "reduction in MicroWarp Drive signature"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1997 -> { DogmaAttributeData.id= 1997; name= "modeEmResistancePostDiv"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2094 -> { DogmaAttributeData.id= 2094; name= "fighterMicroWarpDriveDuration"; description= "The amount of time that a fighter can have a micro warp drive active."; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2288 -> { DogmaAttributeData.id= 2288; name= "shipBonusDreadnoughtC3"; description= "Multiplied by Caldari Dreadnought skill level"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2385 -> { DogmaAttributeData.id= 2385; name= "shipBonusSupercarrierG1"; description= "Multiplied by Gallente Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2482 -> { DogmaAttributeData.id= 2482; name= "canFitShipGroup17"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 251 -> { DogmaAttributeData.id= 251; name= "entityLootCountMax"; description= "The maximum number of pieces of loot dropped by this entity."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2579 -> { DogmaAttributeData.id= 2579; name= "roleBonusDroneIceHarvestingSpeed"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2676 -> { DogmaAttributeData.id= 2676; name= "shipBonusStrategicCruiserCaldari2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2773 -> { DogmaAttributeData.id= 2773; name= "attributeT1ShipManufactureTime"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 445 -> { DogmaAttributeData.id= 445; name= "smugglingChance"; description= "Chance of being caught Transporting contraband. "; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 542 -> { DogmaAttributeData.id= 542; name= "entityStrength"; description= "A relative strength that indicates how powerful this NPC entity is in combat."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 639 -> { DogmaAttributeData.id= 639; name= "entityShieldBoostDelayChance"; description= "The chance an entity will delay repeating use of its shield boosting effect if it has one."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 833 -> { DogmaAttributeData.id= 833; name= "commandBonus"; description= ""; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 930 -> { DogmaAttributeData.id= 930; name= "ECMEntityChance"; description= "Chance of NPC effect to be activated each duration"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None