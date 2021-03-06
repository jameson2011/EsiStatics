﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects79=
    let getDogmaEffect id = 
      match id with 
      | 1049 -> { DogmaEffectData.id= 1049; name= "shipShieldTransferRangeMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1922 -> { DogmaEffectData.id= 1922; name= "eliteReconScramblerRangeBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2019 -> { DogmaEffectData.id= 2019; name= "repairDroneShieldBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2504 -> { DogmaEffectData.id= 2504; name= "shipBonusHybridTrackingGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2698 -> { DogmaEffectData.id= 2698; name= "maxRangeBonusEffectProjectiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 273 -> { DogmaEffectData.id= 273; name= "shieldUpgradesPowerNeedBonusPostPercentPowerLocationShipModulesRequiringShieldUpgrades"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2795 -> { DogmaEffectData.id= 2795; name= "modifyShieldResonancePostPercentPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2892 -> { DogmaEffectData.id= 2892; name= "missileExplosiveDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3571 -> { DogmaEffectData.id= 3571; name= "eliteBonusLogisticsTrackingLinkTrackingSpeedBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3668 -> { DogmaEffectData.id= 3668; name= "miningLaserRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3765 -> { DogmaEffectData.id= 3765; name= "covertOpsStealthBomberSiegeMissileLauncherPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3959 -> { DogmaEffectData.id= 3959; name= "subsystemBonusAmarrDefensiveArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4056 -> { DogmaEffectData.id= 4056; name= "systemSmallHybridDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4153 -> { DogmaEffectData.id= 4153; name= "subsystemBonusCaldariEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4250 -> { DogmaEffectData.id= 4250; name= "subsystemBonusGallenteOffensiveDroneDamageHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4347 -> { DogmaEffectData.id= 4347; name= "subsystemBonusGallenteOffensive3TurretTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5123 -> { DogmaEffectData.id= 5123; name= "shipBonusRemoteArmorRepairCapNeedAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5220 -> { DogmaEffectData.id= 5220; name= "shipProjectileDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5317 -> { DogmaEffectData.id= 5317; name= "shipProjectileDamageMD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5802 -> { DogmaEffectData.id= 5802; name= "shipBonusAfterburnerSpeedFactor2CB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5899 -> { DogmaEffectData.id= 5899; name= "eliteIndustrialArmorRepairHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5996 -> { DogmaEffectData.id= 5996; name= "freighterO1SkillLevel"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6093 -> { DogmaEffectData.id= 6093; name= "shipBonusHeavyMissileAllDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6287 -> { DogmaEffectData.id= 6287; name= "shipBonusEnergyNosOptimalAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6384 -> { DogmaEffectData.id= 6384; name= "overloadSelfMissileGuidanceModuleBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 6481 -> { DogmaEffectData.id= 6481; name= "doomsdayAOEDamp"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6578 -> { DogmaEffectData.id= 6578; name= "skillBonusXLTorpedoSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 661 -> { DogmaEffectData.id= 661; name= "missileExplosiveDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6675 -> { DogmaEffectData.id= 6675; name= "structureRigMoonOreYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6772 -> { DogmaEffectData.id= 6772; name= "informationCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6869 -> { DogmaEffectData.id= 6869; name= "concordIntermediateSecStatus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7063 -> { DogmaEffectData.id= 7063; name= "weather_xenon_gas"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7160 -> { DogmaEffectData.id= 7160; name= "shipArmorEMResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8033 -> { DogmaEffectData.id= 8033; name= "systemEcmRangeMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None