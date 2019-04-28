﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes83=
    let getDogmaAttribute id = 
      match id with 
      | 1150 -> { DogmaAttributeData.id= 1150; name= "boosterCapacitorCapacityPenalty"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1247 -> { DogmaAttributeData.id= 1247; name= "eliteBonusHeavyInterdictors2"; description= "eliteBonusHeavyInterdictors2"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1441 -> { DogmaAttributeData.id= 1441; name= "subsystemBonusCaldariCore"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1538 -> { DogmaAttributeData.id= 1538; name= "warpBubbleImmune"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1635 -> { DogmaAttributeData.id= 1635; name= "cpuLoadLevelModifier"; description= "Used to calculate cpu load multiplier for PI links"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1732 -> { DogmaAttributeData.id= 1732; name= "distributionIDRogueDrone08"; description= "Distribution ID for sov upgrades in Rogue Drone space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 180 -> { DogmaAttributeData.id= 180; name= "primaryAttribute"; description= "Only refers to another dogma attribute."; published= true; unitId= Some(119); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1829 -> { DogmaAttributeData.id= 1829; name= "rookieShieldResistBonus"; description= "Shield resistance bonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1926 -> { DogmaAttributeData.id= 1926; name= "piTaxReduction"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2023 -> { DogmaAttributeData.id= 2023; name= "aoeCloudSizeBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 1399.000000; stackable= true; highIsGood= true } |> Some
      | 2120 -> { DogmaAttributeData.id= 2120; name= "fighterAbilityEvasiveManeuversKinResonance"; description= "Shield Kinetic Damage Resistance"; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 2217 -> { DogmaAttributeData.id= 2217; name= "fighterLightSlots"; description= "Number of Light Fighters the ship can launch."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2314 -> { DogmaAttributeData.id= 2314; name= "shipBonusForceAuxiliaryG1"; description= "Multiplied by Gallente Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2411 -> { DogmaAttributeData.id= 2411; name= "shipBonusTitanC2"; description= "Multiplied by Caldari Titan skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2508 -> { DogmaAttributeData.id= 2508; name= "behaviorWarpScrambleDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2605 -> { DogmaAttributeData.id= 2605; name= "industrialCoreRemoteLogisticsDurationBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 277 -> { DogmaAttributeData.id= 277; name= "requiredSkill1Level"; description= "Required skill level for skill 1"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2799 -> { DogmaAttributeData.id= 2799; name= "shipBonusPD1"; description= "Precursor Destroyer Skill Attribute"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 374 -> { DogmaAttributeData.id= 374; name= "minmatarTechMutator"; description= "Autogenerated skill attribute, minmatarTechMutator"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 471 -> { DogmaAttributeData.id= 471; name= "laboratorySlotsBonus"; description= "Autogenerated skill attribute, laboratorySlotsBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 568 -> { DogmaAttributeData.id= 568; name= "eliteBonusInterceptor"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 665 -> { DogmaAttributeData.id= 665; name= "entityChaseMaxDistance"; description= "The distance outside of which the entity activates their MWD equivalent."; published= false; unitId= Some(1); defaultValue= 2500.000000; stackable= true; highIsGood= true } |> Some
      | 762 -> { DogmaAttributeData.id= 762; name= "controlTowerHybridProximityRangeBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 83 -> { DogmaAttributeData.id= 83; name= "structureDamageAmount"; description= "An amount to modify the structural damage by."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 859 -> { DogmaAttributeData.id= 859; name= "missileEntityAoeVelocityMultiplier"; description= "Affects the velocity of the target in missile impact calculations."; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 956 -> { DogmaAttributeData.id= 956; name= "damageModifierMultiplierBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None