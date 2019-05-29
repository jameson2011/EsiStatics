﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes3=
    let getDogmaAttribute id = 
      match id with 
      | 1167 -> { DogmaAttributeData.id= 1167; name= "posPlayerControlStructure"; description= "If a starbase structure has this attribute = 1 then it can be controlled by owners with infrastructure tactical officer skill and corp role."; published= true; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1264 -> { DogmaAttributeData.id= 1264; name= "brokenRepairCostMultiplier"; description= ""; published= false; unitId= None; defaultValue= 10.000000; stackable= true; highIsGood= true } |> Some
      | 1361 -> { DogmaAttributeData.id= 1361; name= "eliteIndustrialCovertCloakBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1458 -> { DogmaAttributeData.id= 1458; name= "npcRemoteShieldBoostDuration"; description= "Duration of shield boost effect"; published= false; unitId= Some(101); defaultValue= 20000.000000; stackable= true; highIsGood= true } |> Some
      | 1555 -> { DogmaAttributeData.id= 1555; name= "fwLpKill"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1652 -> { DogmaAttributeData.id= 1652; name= "AI_ShouldUseEffectMultiplier"; description= "Should the entity watch for effects when choosing targets"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1749 -> { DogmaAttributeData.id= 1749; name= "distributionIDSerpentis05"; description= "Distribution ID for sov upgrades in Serpentis space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1846 -> { DogmaAttributeData.id= 1846; name= "cargoGroup2"; description= "The second cargo group that can be loaded into this container"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1943 -> { DogmaAttributeData.id= 1943; name= "eliteBonusExpedition2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 197 -> { DogmaAttributeData.id= 197; name= "surveyScanRange"; description= "Distance from thing to survey."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2137 -> { DogmaAttributeData.id= 2137; name= "scanResolutionBonusInterim"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2234 -> { DogmaAttributeData.id= 2234; name= "fighterAbilityAttackMissileExplosionRadius"; description= "Explosion Radius"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2428 -> { DogmaAttributeData.id= 2428; name= "doomsdayImmobilityDuration"; description= "Length of Immobility time."; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2525 -> { DogmaAttributeData.id= 2525; name= "behaviorTargetPainterFalloff"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2622 -> { DogmaAttributeData.id= 2622; name= "concordTankBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2719 -> { DogmaAttributeData.id= 2719; name= "reactionBioTimeMultiplier"; description= "biochemical reaction time multiplier"; published= false; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2816 -> { DogmaAttributeData.id= 2816; name= "behaviorMicroJumpAttackRange"; description= "The range in meters for the npcBehaviorMicroJumpAttackRange effect"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 294 -> { DogmaAttributeData.id= 294; name= "rangeSkillBonus"; description= "Autogenerated skill attribute, rangeSkillBonus"; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 3 -> { DogmaAttributeData.id= 3; name= "damage"; description= "current structure damage dealt to module"; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 488 -> { DogmaAttributeData.id= 488; name= "shipVelocityBonusMC"; description= ""; published= false; unitId= None; defaultValue= 5.000000; stackable= true; highIsGood= true } |> Some
      | 585 -> { DogmaAttributeData.id= 585; name= "shipBonusAB2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 682 -> { DogmaAttributeData.id= 682; name= "typeContainerType2"; description= "A type allowed to be placed in this container."; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 779 -> { DogmaAttributeData.id= 779; name= "entityFlyRangeMultiplier"; description= "For charges, hidden attribute used by sentry guns to modify target pick range."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 973 -> { DogmaAttributeData.id= 973; name= "signatureRadiusBonusPercent"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | _ -> None