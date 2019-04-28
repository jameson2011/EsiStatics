﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes26=
    let getDogmaAttribute id = 
      match id with 
      | 1093 -> { DogmaAttributeData.id= 1093; name= "boosterEffectChance5"; description= ""; published= false; unitId= Some(127); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1190 -> { DogmaAttributeData.id= 1190; name= "ewCapacitorNeedBonus"; description= "Bonus attribute for capacitor need of EW and propulsion jamming."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 123 -> { DogmaAttributeData.id= 123; name= "shieldPiercingChance"; description= "Chance of piercing the shield."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1287 -> { DogmaAttributeData.id= 1287; name= "requiredSkill5Level"; description= "Required skill level for skill 5"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1384 -> { DogmaAttributeData.id= 1384; name= "wormholeMassRegeneration"; description= "The amount of mass a wormhole regenerates per cycle"; published= false; unitId= Some(2); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1481 -> { DogmaAttributeData.id= 1481; name= "maxRangeBonusMultiplier"; description= "Tracking disruptor optimal range penalty multiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1578 -> { DogmaAttributeData.id= 1578; name= "eliteBonusCovertOps3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1675 -> { DogmaAttributeData.id= 1675; name= "entityGroupPropJamBonus"; description= "Amount of propulsion jamming assist. Used by NPCGroupPropJamAssist. Negative values is a bonus so e.g. -20 is a 20% bonus"; published= true; unitId= Some(109); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1772 -> { DogmaAttributeData.id= 1772; name= "accessDifficultyBonusAbsolutePercent"; description= "Bonus to chance of opening a container (for skills)."; published= true; unitId= Some(127); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1869 -> { DogmaAttributeData.id= 1869; name= "rookieSPTOptimal"; description= "Increase in Small Projectile Turret optimal range"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1966 -> { DogmaAttributeData.id= 1966; name= "energyWarfareStrengthMultiplier"; description= ""; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2063 -> { DogmaAttributeData.id= 2063; name= "clothingRemovesCategory2"; description= "This item of clothing does not allow the category specified to be equipped with this item. It will be removed"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 220 -> { DogmaAttributeData.id= 220; name= "blueprintResearchTimeMultiplierBonus"; description= "Bonus or penalty to the percentage time it takes to research a blueprint."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2257 -> { DogmaAttributeData.id= 2257; name= "scanMagnetometricStrengthPercentInterim"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2354 -> { DogmaAttributeData.id= 2354; name= "disallowDocking"; description= "If this ship attribute is NOT 0 then they will be prevented from docking in stations or structures."; published= true; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2451 -> { DogmaAttributeData.id= 2451; name= "energyNeutralizerSignatureResolution"; description= "Signature Resolution of Energy Neutralizer"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2548 -> { DogmaAttributeData.id= 2548; name= "attributeBasLargeShipManufactureMaterialMultiplier"; description= "Decrease material requirement for manufacturing the following:  T1 Battleships, T1 Freighters,                                     Industrial Command Ships        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2645 -> { DogmaAttributeData.id= 2645; name= "BehaviorSiegeDisallowTetheringModifier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2742 -> { DogmaAttributeData.id= 2742; name= "fighterSquadronIsStandupHeavy"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 317 -> { DogmaAttributeData.id= 317; name= "capNeedBonus"; description= "Autogenerated skill attribute, capNeedBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 414 -> { DogmaAttributeData.id= 414; name= "diplomacyMutator"; description= "Autogenerated skill attribute, diplomacyMutator"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 511 -> { DogmaAttributeData.id= 511; name= "shipScanResistance"; description= "Chance of being able to resist a ship scan."; published= false; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 608 -> { DogmaAttributeData.id= 608; name= "powerNeedMultiplier"; description= ""; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 705 -> { DogmaAttributeData.id= 705; name= "resourceOnline1Type"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 802 -> { DogmaAttributeData.id= 802; name= "implantSetSerpentis"; description= ""; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 899 -> { DogmaAttributeData.id= 899; name= "jumpDriveCapacitorNeedBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 996 -> { DogmaAttributeData.id= 996; name= "passiveKineticDamageResistanceBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | _ -> None