namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects72=
    let getDogmaEffect id = 
      match id with 
      | 1042 -> { DogmaEffectData.id= 1042; name= "eliteBonusLogisticTrackingLinkBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4604; postExpression= 4605 } |> Some
      | 1139 -> { DogmaEffectData.id= 1139; name= "destroyerSkillLevelPreMulShipBonusDF2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1236 -> { DogmaEffectData.id= 1236; name= "shipMissileVelocityPirateFactionCruise"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5291; postExpression= 5292 } |> Some
      | 2109 -> { DogmaEffectData.id= 2109; name= "emArmorCompensationHardeningBonusGroupEnergized"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2303 -> { DogmaEffectData.id= 2303; name= "energyDestabilizationNew"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 2691 -> { DogmaEffectData.id= 2691; name= "cpuNeedBonusEffectHybrid"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2788 -> { DogmaEffectData.id= 2788; name= "bcuKnThDamageBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9955; postExpression= 9956 } |> Some
      | 2885 -> { DogmaEffectData.id= 2885; name= "gasHarvestingCycleTimeModulesRequiringGasCloudHarvesting"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2982 -> { DogmaEffectData.id= 2982; name= "skillRemoteECMDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3079 -> { DogmaEffectData.id= 3079; name= "controlTowerGenericHullEmResistanceBonusEnergyNeutralizer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10807; postExpression= 10808 } |> Some
      | 3370 -> { DogmaEffectData.id= 3370; name= "eliteBonusElectronicAttackShipStasisWebMaxRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3467 -> { DogmaEffectData.id= 3467; name= "eliteBonusElectronicAttackShipCapacitorCapacity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3564 -> { DogmaEffectData.id= 3564; name= "shipBonusEwWeaponDisruptionMaxRangeBonusAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12256; postExpression= 12257 } |> Some
      | 3661 -> { DogmaEffectData.id= 3661; name= "targetDroneBandwidthMultiplier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3855 -> { DogmaEffectData.id= 3855; name= "NPCRemoteShieldBoost"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3952 -> { DogmaEffectData.id= 3952; name= "subsystemBonusGallenteDefensiveShieldResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13269; postExpression= 13270 } |> Some
      | 4049 -> { DogmaEffectData.id= 4049; name= "systemSmartBombExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4146 -> { DogmaEffectData.id= 4146; name= "subsystemBonusCaldariEngineeringRadarECMStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13800; postExpression= 13801 } |> Some
      | 4243 -> { DogmaEffectData.id= 4243; name= "modifyShieldResonanceKineticPassivePreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14088; postExpression= 14089 } |> Some
      | 4340 -> { DogmaEffectData.id= 4340; name= "subsystemBonusGallenteOffensive3HybridWeaponROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14296; postExpression= 14297 } |> Some
      | 460 -> { DogmaEffectData.id= 460; name= "caldariFrigateSkillLevelPreMulShipBonusCFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4631 -> { DogmaEffectData.id= 4631; name= "eliteBonusViolatorsCruiseMissileEMAndEXAndKinAndThmDamageRole"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15123; postExpression= 15124 } |> Some
      | 4728 -> { DogmaEffectData.id= 4728; name= "OffensiveDefensiveReduction"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4825 -> { DogmaEffectData.id= 4825; name= "bcLargeProjectileTurretCPUNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5019 -> { DogmaEffectData.id= 5019; name= "minmatarShipEwTargetPainterRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5213 -> { DogmaEffectData.id= 5213; name= "shipRocketMaxVelocityBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5310 -> { DogmaEffectData.id= 5310; name= "shipHybridTracking1GD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5504 -> { DogmaEffectData.id= 5504; name= "eliteBonusCommandShipHeavyDroneVelocityCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5601 -> { DogmaEffectData.id= 5601; name= "marauderModeEffect20"; description= ""; displayName= ""; effectCategory= 1; preExpression= 17492; postExpression= 17493 } |> Some
      | 5698 -> { DogmaEffectData.id= 5698; name= "shipBonusSmallMissileExplosionRadiusGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17697; postExpression= 17698 } |> Some
      | 5795 -> { DogmaEffectData.id= 5795; name= "shipBonusEwWeaponDisruptionStrengthRookie"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5892 -> { DogmaEffectData.id= 5892; name= "eliteIndustrialReactiveArmorHardenerHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6280 -> { DogmaEffectData.id= 6280; name= "shipBonusEnergyNeutOptimalAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19090; postExpression= 19091 } |> Some
      | 6377 -> { DogmaEffectData.id= 6377; name= "eliteBonusLogiFrigArmorRepSpeedCap1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6474 -> { DogmaEffectData.id= 6474; name= "doomsdayHOG"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6571 -> { DogmaEffectData.id= 6571; name= "skillBonusCapitalAutocannonSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6668 -> { DogmaEffectData.id= 6668; name= "skillMultiplierShieldBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6765 -> { DogmaEffectData.id= 6765; name= "spatialPhenomenaGenerationDurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6862 -> { DogmaEffectData.id= 6862; name= "shipBonusForceAuxiliaryM1RemoteArmorRepairDuration"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6959 -> { DogmaEffectData.id= 6959; name= "subsystemBonusGallenteOffensive3RemoteArmorRepairHeat"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7153 -> { DogmaEffectData.id= 7153; name= "precursorBattlecruiserSkillLevelPreMulShipBonusPBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 751 -> { DogmaEffectData.id= 751; name= "gallenteFrigateSkillLevelPreMulShipBonusGF2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8026 -> { DogmaEffectData.id= 8026; name= "hydraMissileExplosionVelocityEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 848 -> { DogmaEffectData.id= 848; name= "cloakingTargetingDelayBonusPostPercentCloakingTargetingDelayBonusForShipModulesRequiringCloaking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None