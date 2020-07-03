namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects72=
    let getDogmaEffect id = 
      match id with 
      | 1139 -> { DogmaEffectData.id= 1139; name= "destroyerSkillLevelPreMulShipBonusDF2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2109 -> { DogmaEffectData.id= 2109; name= "emArmorCompensationHardeningBonusGroupEnergized"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2691 -> { DogmaEffectData.id= 2691; name= "cpuNeedBonusEffectHybrid"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2885 -> { DogmaEffectData.id= 2885; name= "gasHarvestingCycleTimeModulesRequiringGasCloudHarvesting"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2982 -> { DogmaEffectData.id= 2982; name= "skillRemoteECMDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3370 -> { DogmaEffectData.id= 3370; name= "eliteBonusElectronicAttackShipStasisWebMaxRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3467 -> { DogmaEffectData.id= 3467; name= "eliteBonusElectronicAttackShipCapacitorCapacity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3661 -> { DogmaEffectData.id= 3661; name= "targetDroneBandwidthMultiplier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3855 -> { DogmaEffectData.id= 3855; name= "NPCRemoteShieldBoost"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 4049 -> { DogmaEffectData.id= 4049; name= "systemSmartBombExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 460 -> { DogmaEffectData.id= 460; name= "caldariFrigateSkillLevelPreMulShipBonusCFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4728 -> { DogmaEffectData.id= 4728; name= "OffensiveDefensiveReduction"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4825 -> { DogmaEffectData.id= 4825; name= "bcLargeProjectileTurretCPUNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5019 -> { DogmaEffectData.id= 5019; name= "minmatarShipEwTargetPainterRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5213 -> { DogmaEffectData.id= 5213; name= "shipRocketMaxVelocityBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5310 -> { DogmaEffectData.id= 5310; name= "shipHybridTracking1GD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5504 -> { DogmaEffectData.id= 5504; name= "eliteBonusCommandShipHeavyDroneVelocityCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5795 -> { DogmaEffectData.id= 5795; name= "shipBonusEwWeaponDisruptionStrengthRookie"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5892 -> { DogmaEffectData.id= 5892; name= "eliteIndustrialReactiveArmorHardenerHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6377 -> { DogmaEffectData.id= 6377; name= "eliteBonusLogiFrigArmorRepSpeedCap1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6474 -> { DogmaEffectData.id= 6474; name= "doomsdayHOG"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6571 -> { DogmaEffectData.id= 6571; name= "skillBonusCapitalAutocannonSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6765 -> { DogmaEffectData.id= 6765; name= "spatialPhenomenaGenerationDurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6862 -> { DogmaEffectData.id= 6862; name= "shipBonusForceAuxiliaryM1RemoteArmorRepairDuration"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6959 -> { DogmaEffectData.id= 6959; name= "subsystemBonusGallenteOffensive3RemoteArmorRepairHeat"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7153 -> { DogmaEffectData.id= 7153; name= "precursorBattlecruiserSkillLevelPreMulShipBonusPBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 751 -> { DogmaEffectData.id= 751; name= "gallenteFrigateSkillLevelPreMulShipBonusGF2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8026 -> { DogmaEffectData.id= 8026; name= "hydraMissileExplosionVelocityEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 848 -> { DogmaEffectData.id= 848; name= "cloakingTargetingDelayBonusPostPercentCloakingTargetingDelayBonusForShipModulesRequiringCloaking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None