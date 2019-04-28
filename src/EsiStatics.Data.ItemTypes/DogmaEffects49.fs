namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects49=
    let getDogmaEffect id = 
      match id with 
      | 1019 -> { DogmaEffectData.id= 1019; name= "selfT2LargeProjectileACDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4528; postExpression= 4529 } |> Some
      | 1213 -> { DogmaEffectData.id= 1213; name= "shipProjectileTrackingGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5239; postExpression= 5240 } |> Some
      | 1407 -> { DogmaEffectData.id= 1407; name= "eliteBonusCoverOpsScanProbeDuration2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5827; postExpression= 5828 } |> Some
      | 146 -> { DogmaEffectData.id= 146; name= "damageMultiplierSkillBonus"; description= "Boost of damageMultiplier by PreMul of skillLevel"; displayName= "DamageBonus"; effectCategory= 0; preExpression= 1167; postExpression= 1168 } |> Some
      | 243 -> { DogmaEffectData.id= 243; name= "highSpeedManuveringSkillBoostCapacitorNeedMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1591; postExpression= 1592 } |> Some
      | 2571 -> { DogmaEffectData.id= 2571; name= "aoeCloudSizePenaltyBoosterAttribute5"; description= "Automatically generated effect"; displayName= "Missile Cloud Size Penalty"; effectCategory= 0; preExpression= 9334; postExpression= 9335 } |> Some
      | 2765 -> { DogmaEffectData.id= 2765; name= "boosterModifyBoosterMaxVelocityPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9899; postExpression= 9900 } |> Some
      | 2862 -> { DogmaEffectData.id= 2862; name= "testStasisWebifierEffect"; description= ""; displayName= ""; effectCategory= 2; preExpression= 10126; postExpression= 10127 } |> Some
      | 3153 -> { DogmaEffectData.id= 3153; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN&H"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11023; postExpression= 11024 } |> Some
      | 3250 -> { DogmaEffectData.id= 3250; name= "leech"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 3347 -> { DogmaEffectData.id= 3347; name= "shipShieldEmResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11590; postExpression= 11591 } |> Some
      | 340 -> { DogmaEffectData.id= 340; name= "frigateConstructionSkillBoostFrigateConstructionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2022; postExpression= 2023 } |> Some
      | 3541 -> { DogmaEffectData.id= 3541; name= "targetEnergyWeaponMaxRangeBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12191; postExpression= 12192 } |> Some
      | 3832 -> { DogmaEffectData.id= 3832; name= "subsystemSkillLevelAmarrDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12968; postExpression= 12969 } |> Some
      | 4026 -> { DogmaEffectData.id= 4026; name= "systemRemoteSensorBoosterScanResolution"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13454; postExpression= 13455 } |> Some
      | 4123 -> { DogmaEffectData.id= 4123; name= "subsystemBonusCaldariOffensiveHeavyAssaultMissileFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13752; postExpression= 13753 } |> Some
      | 4220 -> { DogmaEffectData.id= 4220; name= "subsystemBonusCaldariElectronicMagnetometricECMStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14029; postExpression= 14030 } |> Some
      | 4317 -> { DogmaEffectData.id= 4317; name= "subsystemBonusGallenteEngineeringDroneHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14238; postExpression= 14239 } |> Some
      | 4511 -> { DogmaEffectData.id= 4511; name= "shipPTurretFalloffBonusMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14776; postExpression= 14777 } |> Some
      | 4705 -> { DogmaEffectData.id= 4705; name= "systemEffectDamageEmSmartbombs"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15275; postExpression= 15276 } |> Some
      | 4802 -> { DogmaEffectData.id= 4802; name= "hackingAccessDifficultyBonusMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15481; postExpression= 15482 } |> Some
      | 4996 -> { DogmaEffectData.id= 4996; name= "shipArmorKNResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16067; postExpression= 16068 } |> Some
      | 5190 -> { DogmaEffectData.id= 5190; name= "trackingSpeedBonusEffectProjectiles"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16513; postExpression= 16514 } |> Some
      | 5287 -> { DogmaEffectData.id= 5287; name= "battlecruiserSkillLevelPreMulShipBonusCBC2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16767; postExpression= 16768 } |> Some
      | 5384 -> { DogmaEffectData.id= 5384; name= "shipMissileThermDamageCC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 4058; postExpression= 4059 } |> Some
      | 5869 -> { DogmaEffectData.id= 5869; name= "eliteIndustrialWarpSpeedBonus1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18130; postExpression= 18131 } |> Some
      | 6063 -> { DogmaEffectData.id= 6063; name= "entosisLink"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 6257 -> { DogmaEffectData.id= 6257; name= "shipBonusEnergyNosOptimalAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19035; postExpression= 19036 } |> Some
      | 6354 -> { DogmaEffectData.id= 6354; name= "shipBonusEwWeaponDisruptionStrengthAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17945; postExpression= 17946 } |> Some
      | 6451 -> { DogmaEffectData.id= 6451; name= "structureScanResolutionActivePercentage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6548 -> { DogmaEffectData.id= 6548; name= "shipBonusForceAuxiliaryG1RemoteCycleTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6742 -> { DogmaEffectData.id= 6742; name= "npcBehaviorRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6839 -> { DogmaEffectData.id= 6839; name= "rigCapShipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of Capital Ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6936 -> { DogmaEffectData.id= 6936; name= "subsystemBonusMinmatarCore3StasisWebHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14149; postExpression= 14150 } |> Some
      | 7033 -> { DogmaEffectData.id= 7033; name= "shipBonusHeavyMissileEMDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19396; postExpression= 19397 } |> Some
      | 728 -> { DogmaEffectData.id= 728; name= "shipBonusCargoMI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3551; postExpression= 3552 } |> Some
      | _ -> None