namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects46=
    let getDogmaEffect id = 
      match id with 
      | 1016 -> { DogmaEffectData.id= 1016; name= "selfT2LargeLaserBeamDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4510; postExpression= 4511 } |> Some
      | 1210 -> { DogmaEffectData.id= 1210; name= "controlTowerCaldariMissileRofBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5228; postExpression= 5229 } |> Some
      | 1307 -> { DogmaEffectData.id= 1307; name= "eliteIndustrialArmorRepairCapNeedElite1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5421; postExpression= 5422 } |> Some
      | 1501 -> { DogmaEffectData.id= 1501; name= "covertOpsStealthBomberCruiseMissileExplosionRadiusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6102; postExpression= 6103 } |> Some
      | 2568 -> { DogmaEffectData.id= 2568; name= "turretTrackingPenaltyBoosterAttribute4"; description= "Automatically generated effect"; displayName= "Turret Tracking Penalty"; effectCategory= 0; preExpression= 9324; postExpression= 9325 } |> Some
      | 2762 -> { DogmaEffectData.id= 2762; name= "boosterModifyBoosterShieldBoostAmountPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9889; postExpression= 9890 } |> Some
      | 2859 -> { DogmaEffectData.id= 2859; name= "modifyMaxVelocityOfShipOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 3908; postExpression= 3909 } |> Some
      | 3053 -> { DogmaEffectData.id= 3053; name= "cpuPenaltyToProjectedECM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10712; postExpression= 10713 } |> Some
      | 3150 -> { DogmaEffectData.id= 3150; name= "controlTowerGenericHullResistanceBonusCG&CGJ"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11017; postExpression= 11018 } |> Some
      | 3247 -> { DogmaEffectData.id= 3247; name= "shipArmorThermalResistance2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11276; postExpression= 11277 } |> Some
      | 3344 -> { DogmaEffectData.id= 3344; name= "heavyInterdictorsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11582; postExpression= 11583 } |> Some
      | 337 -> { DogmaEffectData.id= 337; name= "battleshipConstructionBattleshipConstructionTimeBonusPostPercentBattleshipConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2008; postExpression= 2009 } |> Some
      | 3441 -> { DogmaEffectData.id= 3441; name= "eliteBonusViolatorsTorpedoAoeVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11866; postExpression= 11867 } |> Some
      | 3538 -> { DogmaEffectData.id= 3538; name= "scriptTrackingTrackingSpeedMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12177; postExpression= 12178 } |> Some
      | 4023 -> { DogmaEffectData.id= 4023; name= "systemAoeVelocity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13440; postExpression= 13441 } |> Some
      | 4120 -> { DogmaEffectData.id= 4120; name= "subsystemBonusCaldariOffensiveHeavyMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13746; postExpression= 13747 } |> Some
      | 4217 -> { DogmaEffectData.id= 4217; name= "subsystemBonusAmarrCore2EnergyDestabilizerAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14023; postExpression= 14024 } |> Some
      | 4314 -> { DogmaEffectData.id= 4314; name= "subsystemBonusGallenteEngineeringDroneHPArmor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14232; postExpression= 14233 } |> Some
      | 4411 -> { DogmaEffectData.id= 4411; name= "subSystemBonusGallenteDefensiveInformationWarfareHidden"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14460; postExpression= 14461 } |> Some
      | 46 -> { DogmaEffectData.id= 46; name= "shipScan"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 402 } |> Some
      | 4702 -> { DogmaEffectData.id= 4702; name= "systemEffectDamageExplosiveMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15268; postExpression= 15269 } |> Some
      | 4799 -> { DogmaEffectData.id= 4799; name= "eliteBonusBlackOpsECMBurstGravAndLadarAndMagnetoAndRadar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15470; postExpression= 15471 } |> Some
      | 4896 -> { DogmaEffectData.id= 4896; name= "shipBonusDroneHitpointsGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15798; postExpression= 15799 } |> Some
      | 4993 -> { DogmaEffectData.id= 4993; name= "shipBonusEwWeaponDisruptionTrackingSpeedBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16060; postExpression= 16061 } |> Some
      | 5090 -> { DogmaEffectData.id= 5090; name= "shipShieldBoostMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16298; postExpression= 16299 } |> Some
      | 5187 -> { DogmaEffectData.id= 5187; name= "shipBonusEwRemoteSensorDampenerFalloffBonusGC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16504; postExpression= 16505 } |> Some
      | 5284 -> { DogmaEffectData.id= 5284; name= "battlecruiserSkillLevelPreMulShipBonusABC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16754; postExpression= 16755 } |> Some
      | 5381 -> { DogmaEffectData.id= 5381; name= "shipEnergyTrackingABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16956; postExpression= 16957 } |> Some
      | 5478 -> { DogmaEffectData.id= 5478; name= "shipBonusPICommoditiesHoldGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17204; postExpression= 17205 } |> Some
      | 5575 -> { DogmaEffectData.id= 5575; name= "eliteBonusCommandShipInformationCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17436; postExpression= 17437 } |> Some
      | 5672 -> { DogmaEffectData.id= 5672; name= "shipSmallMissileDmgGF2"; description= ""; displayName= "Small Missile Damage Bonus"; effectCategory= 0; preExpression= 17645; postExpression= 17646 } |> Some
      | 5769 -> { DogmaEffectData.id= 5769; name= "repairDroneHullBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17871; postExpression= 17872 } |> Some
      | 5866 -> { DogmaEffectData.id= 5866; name= "shipBonusWarpScrambleMaxRangeGB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18124; postExpression= 18125 } |> Some
      | 6060 -> { DogmaEffectData.id= 6060; name= "shipBonusLightDroneHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18623; postExpression= 18624 } |> Some
      | 6157 -> { DogmaEffectData.id= 6157; name= "cpuMultiplierToSelf"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 18865; postExpression= 18866 } |> Some
      | 6254 -> { DogmaEffectData.id= 6254; name= "shipBonusEnergyNeutOptimalAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19029; postExpression= 19030 } |> Some
      | 6351 -> { DogmaEffectData.id= 6351; name= "shipMissileKinDamageCC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16964; postExpression= 16965 } |> Some
      | 6448 -> { DogmaEffectData.id= 6448; name= "structureMissileGuidanceEnhancer"; description= ""; displayName= ""; effectCategory= 4; preExpression= 59; postExpression= 59 } |> Some
      | 6545 -> { DogmaEffectData.id= 6545; name= "shipBonusForceAuxiliaryC1RemoteBoostAndCapAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6642 -> { DogmaEffectData.id= 6642; name= "skillBonusDoomsdayRapidFiring"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6739 -> { DogmaEffectData.id= 6739; name= "industrialCommandShipSkillLevelMultiplierICS3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12745; postExpression= 12746 } |> Some
      | 6836 -> { DogmaEffectData.id= 6836; name= "rigCopyCostBonus"; description= "Structure Rig Cost effect on Copying"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6933 -> { DogmaEffectData.id= 6933; name= "subsystemBonusCaldariCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13826; postExpression= 13827 } |> Some
      | 7030 -> { DogmaEffectData.id= 7030; name= "structureAoERoFRoleBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 919 -> { DogmaEffectData.id= 919; name= "shipHybridTrackingGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4186; postExpression= 4187 } |> Some
      | _ -> None