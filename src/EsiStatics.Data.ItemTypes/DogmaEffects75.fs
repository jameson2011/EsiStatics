namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects75=
    let getDogmaEffect id = 
      match id with 
      | 1045 -> { DogmaEffectData.id= 1045; name= "eliteBonusLogisticTrackingLinkBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4610; postExpression= 4611 } |> Some
      | 1239 -> { DogmaEffectData.id= 1239; name= "shipProjectileRofPirateBattleship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 172 -> { DogmaEffectData.id= 172; name= "smallEnergyTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringSmallEnergyTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2015 -> { DogmaEffectData.id= 2015; name= "droneDurabilityShieldCapBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2112 -> { DogmaEffectData.id= 2112; name= "thermicArmorCompensationHardeningBonusGroupEnergized"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2306 -> { DogmaEffectData.id= 2306; name= "eliteReconBonusEnergyNeutRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8507; postExpression= 8508 } |> Some
      | 2694 -> { DogmaEffectData.id= 2694; name= "falloffBonusEffectHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2791 -> { DogmaEffectData.id= 2791; name= "boosterMissileExplosionCloudPenaltyFixed"; description= ""; displayName= "Missile Explosion Radius Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2888 -> { DogmaEffectData.id= 2888; name= "missileExplosiveDmgBonusRocket"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3082 -> { DogmaEffectData.id= 3082; name= "controlTowerGenericHullKineticResistanceBonusJumpPortal"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10821; postExpression= 10822 } |> Some
      | 3373 -> { DogmaEffectData.id= 3373; name= "eliteBonusElectronicAttackShipStandardMissileVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11651; postExpression= 11652 } |> Some
      | 3470 -> { DogmaEffectData.id= 3470; name= "shipBonusMWDCapNeedGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11950; postExpression= 11951 } |> Some
      | 3567 -> { DogmaEffectData.id= 3567; name= "shipBonusEwWeaponDisruptionTrackingSpeedBonusAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12262; postExpression= 12263 } |> Some
      | 3664 -> { DogmaEffectData.id= 3664; name= "scanGravimetricStrengthBonusScannerProbeGroup"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12556; postExpression= 12557 } |> Some
      | 3761 -> { DogmaEffectData.id= 3761; name= "shipBonusAF1TorpedoEmDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12814; postExpression= 12815 } |> Some
      | 3858 -> { DogmaEffectData.id= 3858; name= "subsystemBonusGallentePropulsionMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13081; postExpression= 13082 } |> Some
      | 3955 -> { DogmaEffectData.id= 3955; name= "subsystemBonusCaldariDefensiveShieldResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4052 -> { DogmaEffectData.id= 4052; name= "brokensystemShieldKineticResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13561; postExpression= 13562 } |> Some
      | 4149 -> { DogmaEffectData.id= 4149; name= "subsystemBonusCaldariEngineeringGravimetricECMStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13806; postExpression= 13807 } |> Some
      | 4246 -> { DogmaEffectData.id= 4246; name= "modifyShieldResonanceKineticThermalPassivePreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14095; postExpression= 14096 } |> Some
      | 4343 -> { DogmaEffectData.id= 4343; name= "subsystemBonusAmarrCore2MaxTargetingRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4440 -> { DogmaEffectData.id= 4440; name= "missileSkillAoeCloudSizeBonusAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14549; postExpression= 14550 } |> Some
      | 4634 -> { DogmaEffectData.id= 4634; name= "eliteBonusViolatorsTorpMissileEMAndEXDAndKinAndThmDamageRole"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15129; postExpression= 15130 } |> Some
      | 5119 -> { DogmaEffectData.id= 5119; name= "shipBonusScanProbeStrength2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5216 -> { DogmaEffectData.id= 5216; name= "shipSHTFalloffBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5313 -> { DogmaEffectData.id= 5313; name= "shipBonusDroneArmorHitpointsGD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16827; postExpression= 16828 } |> Some
      | 5410 -> { DogmaEffectData.id= 5410; name= "shipLaserCap1ABC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5507 -> { DogmaEffectData.id= 5507; name= "eliteBonusCommandShipHMRoFCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17273; postExpression= 17274 } |> Some
      | 5604 -> { DogmaEffectData.id= 5604; name= "marauderModeEffect23"; description= ""; displayName= ""; effectCategory= 1; preExpression= 17498; postExpression= 17499 } |> Some
      | 6186 -> { DogmaEffectData.id= 6186; name= "shipModuleRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6283 -> { DogmaEffectData.id= 6283; name= "shipBonusEnergyNeutFalloffAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19096; postExpression= 19097 } |> Some
      | 6380 -> { DogmaEffectData.id= 6380; name= "eliteBonusLogiFrigShieldHP2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6477 -> { DogmaEffectData.id= 6477; name= "doomsdayAOENeut"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 657 -> { DogmaEffectData.id= 657; name= "agilityMultiplierEffect"; description= "Automatically generated effect"; displayName= "AgilityMultiplierEffect"; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6574 -> { DogmaEffectData.id= 6574; name= "skillBonusCapitalRailgunSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6671 -> { DogmaEffectData.id= 6671; name= "moduleBonusCapitalDroneSpeedAugmentor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6768 -> { DogmaEffectData.id= 6768; name= "areaOfEffectSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6865 -> { DogmaEffectData.id= 6865; name= "eliteBonusCoverOpsWarpVelocity1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6962 -> { DogmaEffectData.id= 6962; name= "subsystemBonusAmarrPropulsion2WarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7059 -> { DogmaEffectData.id= 7059; name= "weather_caustic_toxin"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7156 -> { DogmaEffectData.id= 7156; name= "smallDisintegratorMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 754 -> { DogmaEffectData.id= 754; name= "shipHybridDamageBonusCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8029 -> { DogmaEffectData.id= 8029; name= "roleBonus7CapBoosterGroupRestriction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None