﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes77=
    let getDogmaAttribute id = 
      match id with 
      | 1047 -> { DogmaAttributeData.id= 1047; name= "canNotBeTrainedOnTrial"; description= "If set to 1 on a skill then this skill can not be trained on accounts that are marked as Trial."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1144 -> { DogmaAttributeData.id= 1144; name= "boosterTurretOptimalRangePenalty"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1435 -> { DogmaAttributeData.id= 1435; name= "subsystemBonusAmarrPropulsion"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1532 -> { DogmaAttributeData.id= 1532; name= "subsystemBonusGallenteOffensive3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1726 -> { DogmaAttributeData.id= 1726; name= "distributionIDRogueDrone02"; description= "Distribution ID for sov upgrades in Rogue Drone space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 174 -> { DogmaAttributeData.id= 174; name= "customIntelligenceBonus"; description= "Bonus to the intelligence of a character specified by the player in character creation."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1823 -> { DogmaAttributeData.id= 1823; name= "rookieSETDamageBonus"; description= "Energy turret damage bonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1920 -> { DogmaAttributeData.id= 1920; name= "disallowActivateInForcefield"; description= "If set to True on a module, the module will not be allowed to activate whilst the ship is inside a starbase forcefield"; published= true; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2017 -> { DogmaAttributeData.id= 2017; name= "shipBonusTacticalDestroyerCaldari3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2114 -> { DogmaAttributeData.id= 2114; name= "targetPainterResistance"; description= "Resistance against Target Painters"; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2211 -> { DogmaAttributeData.id= 2211; name= "fighterAbilityEnergyNeutralizerAmount"; description= "Energy Amount Neutralized"; published= true; unitId= Some(114); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2308 -> { DogmaAttributeData.id= 2308; name= "shipBonusForceAuxiliaryA1"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2405 -> { DogmaAttributeData.id= 2405; name= "thermalDamageResistanceBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2502 -> { DogmaAttributeData.id= 2502; name= "behaviorWebifierDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2599 -> { DogmaAttributeData.id= 2599; name= "warfareBuff4Multiplier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2696 -> { DogmaAttributeData.id= 2696; name= "moduleIsObsolete"; description= "Indicates that a module or subsystem has been phased out. Primarily used by saved fittings."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 271 -> { DogmaAttributeData.id= 271; name= "shieldEmDamageResonance"; description= "Multiplies EM damage taken by shield"; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 2793 -> { DogmaAttributeData.id= 2793; name= "jumpPortalAdditionalConsumption"; description= "Additional units of fuel that are consumed on each jump through a jump portal, not subject to any of the mass or distance multipliers"; published= false; unitId= Some(138); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 368 -> { DogmaAttributeData.id= 368; name= "refiningTimePercentage"; description= "Refining speed percentage"; published= true; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 465 -> { DogmaAttributeData.id= 465; name= "entityEquipmentGroupMax"; description= "The maximum drops of same group (example: entity can only drop 1 of group: energy laser)"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 562 -> { DogmaAttributeData.id= 562; name= "entityFactionLoss"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 659 -> { DogmaAttributeData.id= 659; name= "shipBonusMC2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 756 -> { DogmaAttributeData.id= 756; name= "controlTowerMoonHarvesterCPUBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 77 -> { DogmaAttributeData.id= 77; name= "miningAmount"; description= "How much ore gets mined"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 853 -> { DogmaAttributeData.id= 853; name= "advancedAgility"; description= "Attribute on ship to make advanced command affect only ships that we want."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 950 -> { DogmaAttributeData.id= 950; name= "entitySensorDampenFallOff"; description= "Fall Off for NPC sensor dampen"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None