﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects62=
    let getDogmaEffect id = 
      match id with 
      | 1129 -> { DogmaEffectData.id= 1129; name= "structureUnanchorForced"; description= ""; displayName= "Force Unanchor"; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 159 -> { DogmaEffectData.id= 159; name= "mediumEnergyTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringMediumEnergyTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1200; postExpression= 1201 } |> Some
      | 1614 -> { DogmaEffectData.id= 1614; name= "skillAdvancedSpaceshipAgilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6409; postExpression= 6410 } |> Some
      | 2196 -> { DogmaEffectData.id= 2196; name= "entityArmorRepairingMedium"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4039; postExpression= 131 } |> Some
      | 2778 -> { DogmaEffectData.id= 2778; name= "boosterModifyBoosterTurretPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9937; postExpression= 9938 } |> Some
      | 3263 -> { DogmaEffectData.id= 3263; name= "oreCapitalShipSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11344; postExpression= 11345 } |> Some
      | 3651 -> { DogmaEffectData.id= 3651; name= "ewGroupTpMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12524; postExpression= 12525 } |> Some
      | 3845 -> { DogmaEffectData.id= 3845; name= "subsystemSkillLevelGallenteOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13039; postExpression= 13040 } |> Some
      | 4039 -> { DogmaEffectData.id= 4039; name= "systemOverloadHardening"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13508; postExpression= 13509 } |> Some
      | 4136 -> { DogmaEffectData.id= 4136; name= "systemShieldExplosiveResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13780; postExpression= 13781 } |> Some
      | 4330 -> { DogmaEffectData.id= 4330; name= "subsystemBonusAmarrOffensive3EnergyWeaponMaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14271; postExpression= 14272 } |> Some
      | 4621 -> { DogmaEffectData.id= 4621; name= "shipBonusHeatDamageATF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15105; postExpression= 15106 } |> Some
      | 4912 -> { DogmaEffectData.id= 4912; name= "damageMultiplierMultiplierActivation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 15829; postExpression= 15830 } |> Some
      | 5009 -> { DogmaEffectData.id= 5009; name= "shipShieldExplosiveResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16101; postExpression= 16102 } |> Some
      | 5106 -> { DogmaEffectData.id= 5106; name= "shipBonusShieldTransferBoostAmountMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16327; postExpression= 16328 } |> Some
      | 5300 -> { DogmaEffectData.id= 5300; name= "shipBonusDroneHitpointsAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16801; postExpression= 16802 } |> Some
      | 5397 -> { DogmaEffectData.id= 5397; name= "baseMaxScanDeviationModifierModuleOnline2None"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 16985; postExpression= 16986 } |> Some
      | 5688 -> { DogmaEffectData.id= 5688; name= "shipBonusMissileVelocityAD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17677; postExpression= 17678 } |> Some
      | 6076 -> { DogmaEffectData.id= 6076; name= "shipModeMissileVelocityPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18652; postExpression= 18653 } |> Some
      | 6173 -> { DogmaEffectData.id= 6173; name= "battlecruiserMHTRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18911; postExpression= 18912 } |> Some
      | 6464 -> { DogmaEffectData.id= 6464; name= "fighterAbilityTackle"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6561 -> { DogmaEffectData.id= 6561; name= "skillBonusLightFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6658 -> { DogmaEffectData.id= 6658; name= "moduleBonusBastionModule"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6755 -> { DogmaEffectData.id= 6755; name= "behaviorSensorDampener"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6852 -> { DogmaEffectData.id= 6852; name= "shipBonusTitanM1WebRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6949 -> { DogmaEffectData.id= 6949; name= "subSystemBonusGallenteDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14414; postExpression= 14415 } |> Some
      | 7046 -> { DogmaEffectData.id= 7046; name= "eliteBonusFlagCruiserAllResistances1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19409; postExpression= 19410 } |> Some
      | 838 -> { DogmaEffectData.id= 838; name= "ammoInfluenceShipVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3908; postExpression= 3909 } |> Some
      | _ -> None