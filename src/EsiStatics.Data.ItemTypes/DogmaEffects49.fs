namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects49=
    let getDogmaEffect id = 
      match id with 
      | 1019 -> { DogmaEffectData.id= 1019; name= "selfT2LargeProjectileACDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 146 -> { DogmaEffectData.id= 146; name= "damageMultiplierSkillBonus"; description= "Boost of damageMultiplier by PreMul of skillLevel"; displayName= "DamageBonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 243 -> { DogmaEffectData.id= 243; name= "highSpeedManuveringSkillBoostCapacitorNeedMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 340 -> { DogmaEffectData.id= 340; name= "frigateConstructionSkillBoostFrigateConstructionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3832 -> { DogmaEffectData.id= 3832; name= "subsystemSkillLevelAmarrDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4317 -> { DogmaEffectData.id= 4317; name= "subsystemBonusGallenteEngineeringDroneHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4802 -> { DogmaEffectData.id= 4802; name= "hackingAccessDifficultyBonusMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4996 -> { DogmaEffectData.id= 4996; name= "shipArmorKNResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5190 -> { DogmaEffectData.id= 5190; name= "trackingSpeedBonusEffectProjectiles"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5287 -> { DogmaEffectData.id= 5287; name= "battlecruiserSkillLevelPreMulShipBonusCBC2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5384 -> { DogmaEffectData.id= 5384; name= "shipMissileThermDamageCC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5869 -> { DogmaEffectData.id= 5869; name= "eliteIndustrialWarpSpeedBonus1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6063 -> { DogmaEffectData.id= 6063; name= "entosisLink"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6257 -> { DogmaEffectData.id= 6257; name= "shipBonusEnergyNosOptimalAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6354 -> { DogmaEffectData.id= 6354; name= "shipBonusEwWeaponDisruptionStrengthAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6451 -> { DogmaEffectData.id= 6451; name= "structureScanResolutionActivePercentage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6548 -> { DogmaEffectData.id= 6548; name= "shipBonusForceAuxiliaryG1RemoteCycleTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6742 -> { DogmaEffectData.id= 6742; name= "npcBehaviorRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6839 -> { DogmaEffectData.id= 6839; name= "rigCapShipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of Capital Ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6936 -> { DogmaEffectData.id= 6936; name= "subsystemBonusMinmatarCore3StasisWebHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7033 -> { DogmaEffectData.id= 7033; name= "shipBonusHeavyMissileEMDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7227 -> { DogmaEffectData.id= 7227; name= "	systemHullHPBonusPercentItem"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 728 -> { DogmaEffectData.id= 728; name= "shipBonusCargoMI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None