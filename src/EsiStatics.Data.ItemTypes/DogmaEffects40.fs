namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects40=
    let getDogmaEffect id = 
      match id with 
      | 1010 -> { DogmaEffectData.id= 1010; name= "selfT2MediumLaserBeamDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1495 -> { DogmaEffectData.id= 1495; name= "flagshipmultiRelayEffect"; description= "Automatically generated effect"; displayName= "multiRelayEffect"; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1592 -> { DogmaEffectData.id= 1592; name= "capitalLauncherSkillCitadelEmDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 234 -> { DogmaEffectData.id= 234; name= "warpdriveoperationSkillBoostWarpCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2465 -> { DogmaEffectData.id= 2465; name= "shipBonusArmorResistAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2756 -> { DogmaEffectData.id= 2756; name= "shipBonusECMStrengthBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2853 -> { DogmaEffectData.id= 2853; name= "cloakingTargetingDelayBonusLRSMCloakingPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3047 -> { DogmaEffectData.id= 3047; name= "structureHPMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3241 -> { DogmaEffectData.id= 3241; name= "eliteBonusGunshipArmorEmResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 331 -> { DogmaEffectData.id= 331; name= "refineryEfficiencySkillBoostRefiningYieldMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3532 -> { DogmaEffectData.id= 3532; name= "skillJumpDriveConsumptionAmountBonusPercentage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3726 -> { DogmaEffectData.id= 3726; name= "agilityMultiplierEffectPassive"; description= "Automatically generated effect"; displayName= "AgilityMultiplierEffectPassive"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 40 -> { DogmaEffectData.id= 40; name= "launcherFitted"; description= "Requries a launcher hardpoint"; displayName= "Launcher"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4017 -> { DogmaEffectData.id= 4017; name= "systemDamageThermalMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4114 -> { DogmaEffectData.id= 4114; name= "subsystemBonusMinmatarOffensiveProjectileWeaponFalloff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4211 -> { DogmaEffectData.id= 4211; name= "subsystemSkillLevelAmarrPropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4405 -> { DogmaEffectData.id= 4405; name= "subSystemBonusMinmatarElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4599 -> { DogmaEffectData.id= 4599; name= "caldariFrigateSkillLevelPreMulShipBonus3CFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4793 -> { DogmaEffectData.id= 4793; name= "shipBonusMissileLauncherHeavyROFATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5181 -> { DogmaEffectData.id= 5181; name= "sensorCompensationSensorStrengthBonusLadar"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5278 -> { DogmaEffectData.id= 5278; name= "destroyerSkillLevelPreMulShipBonusCD1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5569 -> { DogmaEffectData.id= 5569; name= "subSystemBonusMinmatarDefensiveSiegeWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5957 -> { DogmaEffectData.id= 5957; name= "eliteBonusHeavyInterdictorsMETOptimal"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6054 -> { DogmaEffectData.id= 6054; name= "shipBonusHeavyDroneHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6151 -> { DogmaEffectData.id= 6151; name= "modeHullResonancePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6442 -> { DogmaEffectData.id= 6442; name= "fighterAbilityMicroJumpDrive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6636 -> { DogmaEffectData.id= 6636; name= "shipBonusTitanG1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6733 -> { DogmaEffectData.id= 6733; name= "moduleBonusWarfareLinkShield"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6830 -> { DogmaEffectData.id= 6830; name= "rigInventionCostBonus"; description= "Structure Rig Cost effect on Invention"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6927 -> { DogmaEffectData.id= 6927; name= "subsystemBonusMinmatarPropulsionWarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7024 -> { DogmaEffectData.id= 7024; name= "shipBonusDroneTrackingEliteGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8091 -> { DogmaEffectData.id= 8091; name= "shipBonusForceAuxiliaryG2CapBoosterStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None