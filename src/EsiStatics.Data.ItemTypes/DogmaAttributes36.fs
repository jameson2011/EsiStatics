﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes36=
    let getDogmaAttribute id = 
      match id with 
      | 1006 -> { DogmaAttributeData.id= 1006; name= "entityShieldBoostDelayChanceSmall"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1103 -> { DogmaAttributeData.id= 1103; name= "boosterAttribute5"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1200 -> { DogmaAttributeData.id= 1200; name= "heatCapacityLow"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1297 -> { DogmaAttributeData.id= 1297; name= "droneFocusFire"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 133 -> { DogmaAttributeData.id= 133; name= "emDamageResonanceMultiplier"; description= "Multiplier to the EM damage resonance of something."; published= true; unitId= Some(111); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 1394 -> { DogmaAttributeData.id= 1394; name= "wormholeTargetRegion9"; description= "Specific target region 9 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1491 -> { DogmaAttributeData.id= 1491; name= "shieldKineticDamageResistanceBonus"; description= "Kinetic resistance bonus for shields"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1685 -> { DogmaAttributeData.id= 1685; name= "ecuOverlapFactor"; description= ""; published= false; unitId= None; defaultValue= 0.500000; stackable= true; highIsGood= true } |> Some
      | 1782 -> { DogmaAttributeData.id= 1782; name= "allowedDroneGroup1"; description= ""; published= false; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1879 -> { DogmaAttributeData.id= 1879; name= "canFitShipGroup06"; description= "Can be fitted to"; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2073 -> { DogmaAttributeData.id= 2073; name= "scanLadarStrengthBonusBonus"; description= "Bonus to Lader Strength bonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2170 -> { DogmaAttributeData.id= 2170; name= "fighterAbilityMissilesResistanceID"; description= ""; published= false; unitId= Some(119); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2267 -> { DogmaAttributeData.id= 2267; name= "energyWarfareResistanceBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 230 -> { DogmaAttributeData.id= 230; name= "memorySkillTrainingTimeMultiplierBonus"; description= "Bonus or penalty to the percentage time it takes to train skills with Memory as the primary attribute."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2364 -> { DogmaAttributeData.id= 2364; name= "shipBonusCarrierC2"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2461 -> { DogmaAttributeData.id= 2461; name= "containedSkillPoints"; description= "The amount of skill points contained in this item"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2558 -> { DogmaAttributeData.id= 2558; name= "attributeAdvCompManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  T2 Components, Tools, Data Interfaces, T3 Components"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2655 -> { DogmaAttributeData.id= 2655; name= "gfxLauncherID"; description= "Type ID of the launcher for entity type ships"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2752 -> { DogmaAttributeData.id= 2752; name= "eliteBonusFlagCruisers1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 3043 -> { DogmaAttributeData.id= 3043; name= "shipBonusUC1"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 327 -> { DogmaAttributeData.id= 327; name= "hullHpBonus"; description= "Autogenerated skill attribute, hullHpBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 424 -> { DogmaAttributeData.id= 424; name= "cpuOutputBonus2"; description= "Autogenerated skill attribute, cpu OutputBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 715 -> { DogmaAttributeData.id= 715; name= "maxOperationalDistance"; description= "The maximum distance at which the object can be used."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 909 -> { DogmaAttributeData.id= 909; name= "maxShipGroupActiveID"; description= "Which group of modules that this ship limits the number of concurrent activations of."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None