namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects8=
    let getDogmaEffect id = 
      match id with 
      | 105 -> { DogmaEffectData.id= 105; name= "shieldResonanceMultiplyOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1657 -> { DogmaEffectData.id= 1657; name= "missileSkillWarheadUpgradesThermalDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1851 -> { DogmaEffectData.id= 1851; name= "selfRof"; description= "Automatically generated effect"; displayName= "SelfRof"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2918 -> { DogmaEffectData.id= 2918; name= "posStructureControlAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3403 -> { DogmaEffectData.id= 3403; name= "eliteBonusBlackOpsCloakVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3500 -> { DogmaEffectData.id= 3500; name= "miningLaserMaxRangeMultBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3597 -> { DogmaEffectData.id= 3597; name= "scriptSensorBoosterScanResolutionBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3791 -> { DogmaEffectData.id= 3791; name= "modifyHullResonancePostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 396 -> { DogmaEffectData.id= 396; name= "energyGridUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringEnergyGridUpgrades"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4373 -> { DogmaEffectData.id= 4373; name= "subSystemBonusAmarrOffensiveCommandBursts"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5052 -> { DogmaEffectData.id= 5052; name= "baseDefenderAllyCostCharAssignment"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5343 -> { DogmaEffectData.id= 5343; name= "shipBonusDroneDamageMultiplierGBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5440 -> { DogmaEffectData.id= 5440; name= "systemStandardMissileKineticDamage"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 5634 -> { DogmaEffectData.id= 5634; name= "shipBonusTorpedoMissileThermDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 590 -> { DogmaEffectData.id= 590; name= "energyPulseWeaponsDurationBonusPostPercentDurationLocationShipModulesRequiringEnergyPulseWeapons"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5925 -> { DogmaEffectData.id= 5925; name= "systemLadarECMBomb"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6022 -> { DogmaEffectData.id= 6022; name= "reconShipSkillMultiplier3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6216 -> { DogmaEffectData.id= 6216; name= "structureEnergyNeutralizerFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6410 -> { DogmaEffectData.id= 6410; name= "structureRigExplosionRadiusBonusAoEMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6507 -> { DogmaEffectData.id= 6507; name= "shipBonusDreadnoughtG2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6604 -> { DogmaEffectData.id= 6604; name= "shipBonusSupercarrierC1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6701 -> { DogmaEffectData.id= 6701; name= "rigDrawbackReductionProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6798 -> { DogmaEffectData.id= 6798; name= "shipModeSETDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6895 -> { DogmaEffectData.id= 6895; name= "subsystemMETFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6992 -> { DogmaEffectData.id= 6992; name= "roleBonusMHTDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7186 -> { DogmaEffectData.id= 7186; name= "shipBonusMediumDroneArmorHProle8"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 784 -> { DogmaEffectData.id= 784; name= "missileBombardmentMaxFlightTimeBonusPostPercentExplosionDelayOwnerCharModulesRequiringMissileLauncherOperation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None