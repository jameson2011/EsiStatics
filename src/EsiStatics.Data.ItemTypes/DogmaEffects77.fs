﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects77=
    let getDogmaEffect id = 
      match id with 
      | 1047 -> { DogmaEffectData.id= 1047; name= "shipRemoteArmorRangeAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 174 -> { DogmaEffectData.id= 174; name= "smallProjectileTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringSmallProjectileTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2017 -> { DogmaEffectData.id= 2017; name= "droneDurabilityHPBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2696 -> { DogmaEffectData.id= 2696; name= "maxRangeBonusEffectLasers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 271 -> { DogmaEffectData.id= 271; name= "hullUpgradesArmorHpBonusPostPercentHpLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2890 -> { DogmaEffectData.id= 2890; name= "missileThermalDmgBonusRocket"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3569 -> { DogmaEffectData.id= 3569; name= "eliteBonusLogisticsTrackingLinkMaxRangeBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 368 -> { DogmaEffectData.id= 368; name= "gallenteFrigateSkillBoostCpuOutputBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3860 -> { DogmaEffectData.id= 3860; name= "subsystemBonusMinmatarPropulsionMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4054 -> { DogmaEffectData.id= 4054; name= "systemSmallEnergyDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4248 -> { DogmaEffectData.id= 4248; name= "subsystemBonusCaldariOffensive2MissileLauncherKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4636 -> { DogmaEffectData.id= 4636; name= "shipBonusAoeVelocityCruiseAndTorpedoCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5121 -> { DogmaEffectData.id= 5121; name= "energyTransferArrayTransferAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5218 -> { DogmaEffectData.id= 5218; name= "shipSPTFalloffBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 562 -> { DogmaEffectData.id= 562; name= "shipHTDmgBonusfixedGC"; description= "Automatically generated effect"; displayName= "ShipHTDmgBonusfixedGC"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5994 -> { DogmaEffectData.id= 5994; name= "resistanceKillerHullAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6188 -> { DogmaEffectData.id= 6188; name= "shipModuleRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6285 -> { DogmaEffectData.id= 6285; name= "shipBonusEnergyNeutFalloffAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6479 -> { DogmaEffectData.id= 6479; name= "doomsdayAOETrack"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6576 -> { DogmaEffectData.id= 6576; name= "skillBonusCapitalBeamLaserSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6673 -> { DogmaEffectData.id= 6673; name= "structureReprocessingRigSecurityModification"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6770 -> { DogmaEffectData.id= 6770; name= "armoredCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6867 -> { DogmaEffectData.id= 6867; name= "shipBonusSPTRoFMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6964 -> { DogmaEffectData.id= 6964; name= "subsystemBonusGallentePropulsionWarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7061 -> { DogmaEffectData.id= 7061; name= "weather_electric_storm"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7158 -> { DogmaEffectData.id= 7158; name= "shipArmorKineticResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8031 -> { DogmaEffectData.id= 8031; name= "systemMaxTargets"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None