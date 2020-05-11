namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects77=
    let getDogmaEffect id = 
      match id with 
      | 1047 -> { DogmaEffectData.id= 1047; name= "shipRemoteArmorRangeAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4616; postExpression= 4617 } |> Some
      | 1144 -> { DogmaEffectData.id= 1144; name= "shipLaserTrackingAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4987; postExpression= 4988 } |> Some
      | 174 -> { DogmaEffectData.id= 174; name= "smallProjectileTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringSmallProjectileTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1278; postExpression= 1279 } |> Some
      | 1920 -> { DogmaEffectData.id= 1920; name= "eliteReconEnergyVampireRangeBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7359; postExpression= 7360 } |> Some
      | 2017 -> { DogmaEffectData.id= 2017; name= "droneDurabilityHPBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7653; postExpression= 7654 } |> Some
      | 2308 -> { DogmaEffectData.id= 2308; name= "eliteReconBonusAssaultLauncherROF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8515; postExpression= 8516 } |> Some
      | 2502 -> { DogmaEffectData.id= 2502; name= "shipLauncherRofBonusMB1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9139; postExpression= 9140 } |> Some
      | 2599 -> { DogmaEffectData.id= 2599; name= "modifyBoosterAttributePostPercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9437; postExpression= 9438 } |> Some
      | 2696 -> { DogmaEffectData.id= 2696; name= "maxRangeBonusEffectLasers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2972; postExpression= 2973 } |> Some
      | 271 -> { DogmaEffectData.id= 271; name= "hullUpgradesArmorHpBonusPostPercentHpLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1691; postExpression= 1692 } |> Some
      | 2890 -> { DogmaEffectData.id= 2890; name= "missileThermalDmgBonusRocket"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10219; postExpression= 10220 } |> Some
      | 3084 -> { DogmaEffectData.id= 3084; name= "controlTowerGenericHullThermicResistanceBonusHybrid"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10829; postExpression= 10830 } |> Some
      | 3278 -> { DogmaEffectData.id= 3278; name= "industrialCoreSurveyScannerBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 11401; postExpression= 11402 } |> Some
      | 3472 -> { DogmaEffectData.id= 3472; name= "shipBonusMWDCapNeedMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11956; postExpression= 11957 } |> Some
      | 3569 -> { DogmaEffectData.id= 3569; name= "eliteBonusLogisticsTrackingLinkMaxRangeBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12268; postExpression= 12269 } |> Some
      | 3666 -> { DogmaEffectData.id= 3666; name= "testColinScanner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12562; postExpression= 12563 } |> Some
      | 368 -> { DogmaEffectData.id= 368; name= "gallenteFrigateSkillBoostCpuOutputBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2157; postExpression= 2158 } |> Some
      | 3763 -> { DogmaEffectData.id= 3763; name= "shipBonusGF1TorpedoThermalDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12818; postExpression= 12819 } |> Some
      | 3860 -> { DogmaEffectData.id= 3860; name= "subsystemBonusMinmatarPropulsionMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13085; postExpression= 13086 } |> Some
      | 4054 -> { DogmaEffectData.id= 4054; name= "systemSmallEnergyDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13568; postExpression= 13569 } |> Some
      | 4151 -> { DogmaEffectData.id= 4151; name= "subsystemBonusGallenteEngineeringSensorDampenerStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13810; postExpression= 13811 } |> Some
      | 4248 -> { DogmaEffectData.id= 4248; name= "subsystemBonusCaldariOffensive2MissileLauncherKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14099; postExpression= 14100 } |> Some
      | 4345 -> { DogmaEffectData.id= 4345; name= "subsystemBonusMinmatarOffensive2TurretTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14308; postExpression= 14309 } |> Some
      | 4636 -> { DogmaEffectData.id= 4636; name= "shipBonusAoeVelocityCruiseAndTorpedoCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15133; postExpression= 15134 } |> Some
      | 5121 -> { DogmaEffectData.id= 5121; name= "energyTransferArrayTransferAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16368; postExpression= 16369 } |> Some
      | 5218 -> { DogmaEffectData.id= 5218; name= "shipSPTFalloffBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16594; postExpression= 16595 } |> Some
      | 5315 -> { DogmaEffectData.id= 5315; name= "shipBonusDroneHitpoints1GD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16831; postExpression= 16832 } |> Some
      | 5412 -> { DogmaEffectData.id= 5412; name= "shipRocketEmDmgAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17017; postExpression= 17018 } |> Some
      | 562 -> { DogmaEffectData.id= 562; name= "shipHTDmgBonusfixedGC"; description= "Automatically generated effect"; displayName= "ShipHTDmgBonusfixedGC"; effectCategory= 0; preExpression= 2940; postExpression= 2941 } |> Some
      | 5994 -> { DogmaEffectData.id= 5994; name= "resistanceKillerHullAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18463; postExpression= 18464 } |> Some
      | 6188 -> { DogmaEffectData.id= 6188; name= "shipModuleRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6285 -> { DogmaEffectData.id= 6285; name= "shipBonusEnergyNeutFalloffAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19100; postExpression= 19101 } |> Some
      | 6382 -> { DogmaEffectData.id= 6382; name= "fighterSpeedBoostSigRad"; description= "A micro warp drive effect for fighters."; displayName= "Speed Boost"; effectCategory= 1; preExpression= 5333; postExpression= 5334 } |> Some
      | 6479 -> { DogmaEffectData.id= 6479; name= "doomsdayAOETrack"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6576 -> { DogmaEffectData.id= 6576; name= "skillBonusCapitalBeamLaserSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6673 -> { DogmaEffectData.id= 6673; name= "structureReprocessingRigSecurityModification"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6770 -> { DogmaEffectData.id= 6770; name= "armoredCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6867 -> { DogmaEffectData.id= 6867; name= "shipBonusSPTRoFMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6964 -> { DogmaEffectData.id= 6964; name= "subsystemBonusGallentePropulsionWarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14157; postExpression= 14158 } |> Some
      | 7061 -> { DogmaEffectData.id= 7061; name= "weather_electric_storm"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7158 -> { DogmaEffectData.id= 7158; name= "shipArmorKineticResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19687; postExpression= 19688 } |> Some
      | _ -> None