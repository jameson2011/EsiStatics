﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects22=
    let getDogmaEffect id = 
      match id with 
      | 1283 -> { DogmaEffectData.id= 1283; name= "eliteIndustrial2SkillLevelPreMulEliteBonusEliteIndustrialShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1671 -> { DogmaEffectData.id= 1671; name= "freighterCargoBonusM2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1865 -> { DogmaEffectData.id= 1865; name= "shipMissileEMDamageMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7177; postExpression= 7178 } |> Some
      | 1962 -> { DogmaEffectData.id= 1962; name= "signatureRadiusBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2156 -> { DogmaEffectData.id= 2156; name= "eliteBonusCommandShipProjectileFalloffCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 216 -> { DogmaEffectData.id= 216; name= "electronicWarfareSkillBoostDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 22 -> { DogmaEffectData.id= 22; name= "maxVelocityBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 205; postExpression= 206 } |> Some
      | 2253 -> { DogmaEffectData.id= 2253; name= "covertOpsStealthBomberTargettingDelayBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2738 -> { DogmaEffectData.id= 2738; name= "boosterShieldBoostAmountPenalty"; description= "Automatically generated effect"; displayName= "Shield Booster Penalty"; effectCategory= 0; preExpression= 9829; postExpression= 9830 } |> Some
      | 2835 -> { DogmaEffectData.id= 2835; name= "shipMissileVelocityPirateFactionHeavyAssault"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10058; postExpression= 10059 } |> Some
      | 3029 -> { DogmaEffectData.id= 3029; name= "overloadSelfEmHardeningBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3126 -> { DogmaEffectData.id= 3126; name= "controlTowerGenericHullK&TResistanceBonusEcm"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10973; postExpression= 10974 } |> Some
      | 3223 -> { DogmaEffectData.id= 3223; name= "eliteBonusHeavyGunshipMass1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11228; postExpression= 11229 } |> Some
      | 3417 -> { DogmaEffectData.id= 3417; name= "eliteBonusViolatorsLargeProjectileTurretDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3514 -> { DogmaEffectData.id= 3514; name= "Interceptor2WarpScrambleRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3999 -> { DogmaEffectData.id= 3999; name= "systemArmorThermalResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4096 -> { DogmaEffectData.id= 4096; name= "subsystemBonusAmarrOffensiveEnergyWeaponTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13696; postExpression= 13697 } |> Some
      | 4193 -> { DogmaEffectData.id= 4193; name= "strategicCruiserGallenteSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4290 -> { DogmaEffectData.id= 4290; name= "subsystemBonusMinmatarOffensive2RemoteRepCapUse"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4387 -> { DogmaEffectData.id= 4387; name= "shipBonusHeavyAssaultLauncherRateOfFireCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14410; postExpression= 14411 } |> Some
      | 4484 -> { DogmaEffectData.id= 4484; name= "shipPTurretFalloffBonusGB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4775 -> { DogmaEffectData.id= 4775; name= "shipEnergyNeutralizerTransferAmountBonusAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4969 -> { DogmaEffectData.id= 4969; name= "boosterShieldBoostAmountPenaltyCapitalShieldOperation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15998; postExpression= 15999 } |> Some
      | 5066 -> { DogmaEffectData.id= 5066; name= "shipBonusTargetPainterOptimalMF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 507 -> { DogmaEffectData.id= 507; name= "longRangeTargetingMaxTargetRangeBonusPostPercentMaxTargetRangeLocationShipGroupElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5163 -> { DogmaEffectData.id= 5163; name= "salvageDroneEffect"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5260 -> { DogmaEffectData.id= 5260; name= "covertOpsCloakCpuPercentBonus1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5357 -> { DogmaEffectData.id= 5357; name= "shipHybridDamageBonusCBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5939 -> { DogmaEffectData.id= 5939; name= "shipRocketRoFBonusAF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6036 -> { DogmaEffectData.id= 6036; name= "shipHeatDamageMinmatarTacticalDestroyer3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 604 -> { DogmaEffectData.id= 604; name= "shipPTspeedBonusMB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6133 -> { DogmaEffectData.id= 6133; name= "missileGuidanceComputerBonus2"; description= "aoe cloud size + missile velocity + explosion delay"; displayName= ""; effectCategory= 1; preExpression= 18800; postExpression= 18801 } |> Some
      | 6230 -> { DogmaEffectData.id= 6230; name= "shipBonusEnergyNeutOptimalRS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6327 -> { DogmaEffectData.id= 6327; name= "shipBonusEMMissileDamageCD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6424 -> { DogmaEffectData.id= 6424; name= "shipModuleTrackingDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6618 -> { DogmaEffectData.id= 6618; name= "shipBonusSupercarrierM4BurstProjectorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6715 -> { DogmaEffectData.id= 6715; name= "ECMBurstJammerQA"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6812 -> { DogmaEffectData.id= 6812; name= "rigSmallshipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of small Ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6909 -> { DogmaEffectData.id= 6909; name= "shipBonusStrategicCruiserAmarrNaniteRepairTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7103 -> { DogmaEffectData.id= 7103; name= "structureConversionRigCapCompManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None