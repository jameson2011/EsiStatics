namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects46=
    let getDogmaEffect id = 
      match id with 
      | 1016 -> { DogmaEffectData.id= 1016; name= "selfT2LargeLaserBeamDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1210 -> { DogmaEffectData.id= 1210; name= "controlTowerCaldariMissileRofBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3344 -> { DogmaEffectData.id= 3344; name= "heavyInterdictorsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 337 -> { DogmaEffectData.id= 337; name= "battleshipConstructionBattleshipConstructionTimeBonusPostPercentBattleshipConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4023 -> { DogmaEffectData.id= 4023; name= "systemAoeVelocity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4120 -> { DogmaEffectData.id= 4120; name= "subsystemBonusCaldariOffensiveHeavyMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4217 -> { DogmaEffectData.id= 4217; name= "subsystemBonusAmarrCore2EnergyDestabilizerAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 46 -> { DogmaEffectData.id= 46; name= "shipScan"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 4799 -> { DogmaEffectData.id= 4799; name= "eliteBonusBlackOpsECMBurstGravAndLadarAndMagnetoAndRadar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4896 -> { DogmaEffectData.id= 4896; name= "shipBonusDroneHitpointsGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5090 -> { DogmaEffectData.id= 5090; name= "shipShieldBoostMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5187 -> { DogmaEffectData.id= 5187; name= "shipBonusEwRemoteSensorDampenerFalloffBonusGC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5284 -> { DogmaEffectData.id= 5284; name= "battlecruiserSkillLevelPreMulShipBonusABC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5381 -> { DogmaEffectData.id= 5381; name= "shipEnergyTrackingABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5478 -> { DogmaEffectData.id= 5478; name= "shipBonusPICommoditiesHoldGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5575 -> { DogmaEffectData.id= 5575; name= "eliteBonusCommandShipInformationCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5769 -> { DogmaEffectData.id= 5769; name= "repairDroneHullBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5866 -> { DogmaEffectData.id= 5866; name= "shipBonusWarpScrambleMaxRangeGB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6060 -> { DogmaEffectData.id= 6060; name= "shipBonusLightDroneHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6351 -> { DogmaEffectData.id= 6351; name= "shipMissileKinDamageCC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6448 -> { DogmaEffectData.id= 6448; name= "structureMissileGuidanceEnhancer"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6545 -> { DogmaEffectData.id= 6545; name= "shipBonusForceAuxiliaryC1RemoteBoostAndCapAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6642 -> { DogmaEffectData.id= 6642; name= "skillBonusDoomsdayRapidFiring"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6739 -> { DogmaEffectData.id= 6739; name= "industrialCommandShipSkillLevelMultiplierICS3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6836 -> { DogmaEffectData.id= 6836; name= "rigCopyCostBonus"; description= "Structure Rig Cost effect on Copying"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6933 -> { DogmaEffectData.id= 6933; name= "subsystemBonusCaldariCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7030 -> { DogmaEffectData.id= 7030; name= "structureAoERoFRoleBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 919 -> { DogmaEffectData.id= 919; name= "shipHybridTrackingGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None