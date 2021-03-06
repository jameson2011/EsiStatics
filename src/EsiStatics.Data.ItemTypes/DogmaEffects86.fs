﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects86=
    let getDogmaEffect id = 
      match id with 
      | 1056 -> { DogmaEffectData.id= 1056; name= "eliteBonusHeavyGunshipHybridOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1638 -> { DogmaEffectData.id= 1638; name= "skillAdvancedWeaponUpgradesPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 280 -> { DogmaEffectData.id= 280; name= "shieldManagementSkillBoostShieldCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2802 -> { DogmaEffectData.id= 2802; name= "hybridWeaponDamageMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2899 -> { DogmaEffectData.id= 2899; name= "missileEMDmgBonusHeavy"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3772 -> { DogmaEffectData.id= 3772; name= "subSystem"; description= "Must be installed into an available subsystem slot on a Tech III ship."; displayName= "Sub System"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3869 -> { DogmaEffectData.id= 3869; name= "subsystemBonusMinmatarPropulsion2MWDPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4063 -> { DogmaEffectData.id= 4063; name= "systemStandardMissileExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4160 -> { DogmaEffectData.id= 4160; name= "massAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4257 -> { DogmaEffectData.id= 4257; name= "subsystemBonusMinmatarOffensiveAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4451 -> { DogmaEffectData.id= 4451; name= "ScanRadarStrengthModifierEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4645 -> { DogmaEffectData.id= 4645; name= "eliteBonusHeavyGunshipHeavyAndHeavyAssaultAndAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4936 -> { DogmaEffectData.id= 4936; name= "fueledShieldBoosting"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5227 -> { DogmaEffectData.id= 5227; name= "shipHeavyMissileKinDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5324 -> { DogmaEffectData.id= 5324; name= "shipArmorKineticResistance1ABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5421 -> { DogmaEffectData.id= 5421; name= "shipBonusEnergyNeutRangeAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5615 -> { DogmaEffectData.id= 5615; name= "piTaxReductionModifierSkillModifier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 571 -> { DogmaEffectData.id= 571; name= "reverseEngineeringInventionBonusModAddReverseEngineeringChanceLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5809 -> { DogmaEffectData.id= 5809; name= "shipBonusHeavyDroneArmorHpPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5906 -> { DogmaEffectData.id= 5906; name= "advancedIndustryCopyTimeBonusPostPercent"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6003 -> { DogmaEffectData.id= 6003; name= "tacticalDestroyerAmarrSkillLevel1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6197 -> { DogmaEffectData.id= 6197; name= "energyNosferatuFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6294 -> { DogmaEffectData.id= 6294; name= "shipBonusEnergyNeutOptimalAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6488 -> { DogmaEffectData.id= 6488; name= "scriptSensorBoosterSensorStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6585 -> { DogmaEffectData.id= 6585; name= "skillMultiplierShipBonusCarrierGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 668 -> { DogmaEffectData.id= 668; name= "missileKineticDmgBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6682 -> { DogmaEffectData.id= 6682; name= "structureModuleEffectStasisWebifier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6779 -> { DogmaEffectData.id= 6779; name= "skirmishCommandStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6876 -> { DogmaEffectData.id= 6876; name= "blackOpsSkillMultiplier4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6973 -> { DogmaEffectData.id= 6973; name= "rigReactionCompMatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7070 -> { DogmaEffectData.id= 7070; name= "precursorBattleshipSkillLevelPreMulShipBonusPBS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7167 -> { DogmaEffectData.id= 7167; name= "shipBonusRemoteCapacitorTransferRangeRole1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8040 -> { DogmaEffectData.id= 8040; name= "upwellSkillaoeVelocityaoeCloudSizeBonusSkilllevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 959 -> { DogmaEffectData.id= 959; name= "shipArmorExplosiveResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None