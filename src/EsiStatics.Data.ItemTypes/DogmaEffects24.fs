namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects24=
    let getDogmaEffect id = 
      match id with 
      | 1188 -> { DogmaEffectData.id= 1188; name= "miningBargeSkillLevelPostMulShipBonusORE2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5159; postExpression= 5160 } |> Some
      | 1673 -> { DogmaEffectData.id= 1673; name= "freighterMaxVelocityBonusC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6625; postExpression= 6626 } |> Some
      | 1867 -> { DogmaEffectData.id= 1867; name= "shipMissileKineticDamageMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7181; postExpression= 7182 } |> Some
      | 1964 -> { DogmaEffectData.id= 1964; name= "shipBonusShieldTransferCapneed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7505; postExpression= 7506 } |> Some
      | 2158 -> { DogmaEffectData.id= 2158; name= "eliteBonusCommandShipLaserROFCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8093; postExpression= 8094 } |> Some
      | 218 -> { DogmaEffectData.id= 218; name= "engineeringSkillBoostPowerOutputBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1475; postExpression= 1476 } |> Some
      | 2255 -> { DogmaEffectData.id= 2255; name= "tractorBeamCan"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 2449 -> { DogmaEffectData.id= 2449; name= "eliteeliteBonusCommandShipDroneBay1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9006; postExpression= 9007 } |> Some
      | 2546 -> { DogmaEffectData.id= 2546; name= "explosionVelocityPenaltyBoosterAttribute5"; description= "Automatically generated effect"; displayName= "Missile Explosion Velocity Penalty"; effectCategory= 0; preExpression= 9254; postExpression= 9255 } |> Some
      | 2643 -> { DogmaEffectData.id= 2643; name= "massReductionBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9566; postExpression= 9567 } |> Some
      | 2837 -> { DogmaEffectData.id= 2837; name= "armorHPBonusAdd"; description= ""; displayName= ""; effectCategory= 4; preExpression= 10069; postExpression= 10070 } |> Some
      | 3031 -> { DogmaEffectData.id= 3031; name= "overloadSelfExplosiveHardeningBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 10669; postExpression= 10670 } |> Some
      | 3128 -> { DogmaEffectData.id= 3128; name= "controlTowerGenericHullK&TResistanceBonusHybrd"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10977; postExpression= 10978 } |> Some
      | 315 -> { DogmaEffectData.id= 315; name= "dronesSkillBoostMaxActiveDroneBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1872; postExpression= 1873 } |> Some
      | 3225 -> { DogmaEffectData.id= 3225; name= "eliteBonusCommandShipCapRecharge1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11232; postExpression= 11233 } |> Some
      | 3322 -> { DogmaEffectData.id= 3322; name= "shipBonusORECapShipDroneShieldHPBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11531; postExpression= 11532 } |> Some
      | 3710 -> { DogmaEffectData.id= 3710; name= "concordTargetJam"; description= ""; displayName= ""; effectCategory= 2; preExpression= 7210; postExpression= 7211 } |> Some
      | 3807 -> { DogmaEffectData.id= 3807; name= "maxTargetRangeAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12899; postExpression= 12900 } |> Some
      | 4001 -> { DogmaEffectData.id= 4001; name= "systemFalloffRangeGunnery"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13366; postExpression= 13367 } |> Some
      | 4098 -> { DogmaEffectData.id= 4098; name= "subsystemBonusAmarrOffensiveDroneBandwidth"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13700; postExpression= 13701 } |> Some
      | 412 -> { DogmaEffectData.id= 412; name= "industrySkillBoostManufacturingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2323; postExpression= 2324 } |> Some
      | 4195 -> { DogmaEffectData.id= 4195; name= "subsystemSkillLevelAmarrDefensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13922; postExpression= 13923 } |> Some
      | 4292 -> { DogmaEffectData.id= 4292; name= "subsystemBonusCaldariOffensive2RemoteShieldBoosterCapUse"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14188; postExpression= 14189 } |> Some
      | 4389 -> { DogmaEffectData.id= 4389; name= "subSystemBonusAmarrElectronicScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14414; postExpression= 14415 } |> Some
      | 4777 -> { DogmaEffectData.id= 4777; name= "shipArmorEMResistanceATF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15422; postExpression= 15423 } |> Some
      | 4971 -> { DogmaEffectData.id= 4971; name= "shipBonusMissileThermalATF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16002; postExpression= 16003 } |> Some
      | 5068 -> { DogmaEffectData.id= 5068; name= "shipBonusShieldCapacityORE2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16247; postExpression= 16248 } |> Some
      | 509 -> { DogmaEffectData.id= 509; name= "shipCargoBonusCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2738; postExpression= 2739 } |> Some
      | 5165 -> { DogmaEffectData.id= 5165; name= "shipBonusDroneMWDboostrole"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16455; postExpression= 16456 } |> Some
      | 5262 -> { DogmaEffectData.id= 5262; name= "covertOpsCloakCpuPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16678; postExpression= 16679 } |> Some
      | 5359 -> { DogmaEffectData.id= 5359; name= "shipHybridDamageBonusGBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16919; postExpression= 16920 } |> Some
      | 5456 -> { DogmaEffectData.id= 5456; name= "shipCruiseMissileROFCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17137; postExpression= 17138 } |> Some
      | 5553 -> { DogmaEffectData.id= 5553; name= "shipBonusHAMVelocityEliteBonusHeavyGunship1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17380; postExpression= 17381 } |> Some
      | 5650 -> { DogmaEffectData.id= 5650; name= "shipArmorResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17601; postExpression= 17602 } |> Some
      | 6038 -> { DogmaEffectData.id= 6038; name= "shipSPTOptimalMinmatarTacticalDestroyer2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18576; postExpression= 18577 } |> Some
      | 6135 -> { DogmaEffectData.id= 6135; name= "missileGuidanceComputerBonus4"; description= ""; displayName= ""; effectCategory= 1; preExpression= 18804; postExpression= 18805 } |> Some
      | 6232 -> { DogmaEffectData.id= 6232; name= "shipBonusEnergyNeutFalloffRS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18977; postExpression= 18978 } |> Some
      | 6329 -> { DogmaEffectData.id= 6329; name= "shipBonusExplosiveMissileDamageCD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19182; postExpression= 19183 } |> Some
      | 6426 -> { DogmaEffectData.id= 6426; name= "remoteWebifierFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6523 -> { DogmaEffectData.id= 6523; name= "skillMultiplierShipBonusForceAuxiliaryMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6620 -> { DogmaEffectData.id= 6620; name= "shipBonusDreadnoughtC3ReloadBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6717 -> { DogmaEffectData.id= 6717; name= "roleBonusIceOreMiningDurationCap"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19290; postExpression= 19291 } |> Some
      | 6814 -> { DogmaEffectData.id= 6814; name= "rigMediumshipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of medium ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6911 -> { DogmaEffectData.id= 6911; name= "shipBonusStrategicCruiserMinmatarNaniteRepairTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12698; postExpression= 12699 } |> Some
      | 7008 -> { DogmaEffectData.id= 7008; name= "structureFullPowerStateHitpointModifier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19371; postExpression= 19372 } |> Some
      | 703 -> { DogmaEffectData.id= 703; name= "interceptorsSkillLevelPreMulEliteBonusInterceptorShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3451; postExpression= 3452 } |> Some
      | 7105 -> { DogmaEffectData.id= 7105; name= "structureConversionRigMETimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 7202 -> { DogmaEffectData.id= 7202; name= "systemDroneSpeedBonusPercent"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 7638; postExpression= 7639 } |> Some
      | 897 -> { DogmaEffectData.id= 897; name= "covertOpsCpuMultplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4115; postExpression= 4116 } |> Some
      | _ -> None