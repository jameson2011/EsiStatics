﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes37=
    let getDogmaAttribute id = 
      match id with 
      | 1007 -> { DogmaAttributeData.id= 1007; name= "entityShieldBoostDelayChanceMedium"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1104 -> { DogmaAttributeData.id= 1104; name= "displayMaxVelocityBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1298 -> { DogmaAttributeData.id= 1298; name= "canFitShipGroup01"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 134 -> { DogmaAttributeData.id= 134; name= "shieldRechargeRateMultiplier"; description= "Multiplier to a recharge rate time."; published= true; unitId= Some(111); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 1395 -> { DogmaAttributeData.id= 1395; name= "wormholeTargetConstellation1"; description= "Specific target constellation 1 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1492 -> { DogmaAttributeData.id= 1492; name= "shieldThermalDamageResistanceBonus"; description= "Thermal resistance bonus for shields"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1686 -> { DogmaAttributeData.id= 1686; name= "systemEffectDamageReduction"; description= "Damage reduction for system effects"; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1783 -> { DogmaAttributeData.id= 1783; name= "allowedDroneGroup2"; description= ""; published= false; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1880 -> { DogmaAttributeData.id= 1880; name= "canFitShipGroup07"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2074 -> { DogmaAttributeData.id= 2074; name= "scanMagnetometricStrengthBonusBonus"; description= "Bonus to Magnetometric Strength bonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2171 -> { DogmaAttributeData.id= 2171; name= "fighterAbilityAttackTurretDamageEM"; description= "EM Damage"; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2268 -> { DogmaAttributeData.id= 2268; name= "tetheringRange"; description= "Distance which tethering will engage / disengage piloted ships."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 231 -> { DogmaAttributeData.id= 231; name= "perceptionSkillTrainingTimeMultiplierBonus"; description= "Bonus or penalty to the percentage time it takes to train skills with Perception as the primary attribute."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2365 -> { DogmaAttributeData.id= 2365; name= "shipBonusCarrierC3"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2462 -> { DogmaAttributeData.id= 2462; name= "roleBonusRepairRange"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2559 -> { DogmaAttributeData.id= 2559; name= "attributeBasCapCompManufactureMaterialMultiplier"; description= "Decrease material requirement for manufacturing the following:  Capital Construction Components        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2656 -> { DogmaAttributeData.id= 2656; name= "gfxLauncherCount"; description= "Number of Launchers to fit for entity type ships"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2753 -> { DogmaAttributeData.id= 2753; name= "flagCruiserFittingBonusPropMods"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 3044 -> { DogmaAttributeData.id= 3044; name= "shipBonusUC2"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 328 -> { DogmaAttributeData.id= 328; name= "barrageFalloff"; description= ""; published= false; unitId= None; defaultValue= 75.000000; stackable= true; highIsGood= true } |> Some
      | 37 -> { DogmaAttributeData.id= 37; name= "maxVelocity"; description= "Maximum velocity of ship"; published= true; unitId= Some(11); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 425 -> { DogmaAttributeData.id= 425; name= "cpuOutputBonus"; description= "Autogenerated skill attribute, cpuOutputBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 522 -> { DogmaAttributeData.id= 522; name= "damageCloudChance"; description= "%chance of new asteroid releasing damage cloud each mining turn."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 619 -> { DogmaAttributeData.id= 619; name= "cloakingTargetingDelayBonus"; description= "Skill bonus for cloaking targeting delay."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 716 -> { DogmaAttributeData.id= 716; name= "maxOperationalUsers"; description= "The maximum number of users that can be present within the operational range of the structure for it to be capable of operation."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 813 -> { DogmaAttributeData.id= 813; name= "shipBonusGI2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 910 -> { DogmaAttributeData.id= 910; name= "maxShipGroupActive"; description= "The amount of modules belonging to the same group that can be active at the same time."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None