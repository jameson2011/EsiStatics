namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects8=
    let getDogmaEffect id = 
      match id with 
      | 105 -> { DogmaEffectData.id= 105; name= "shieldResonanceMultiplyOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1269 -> { DogmaEffectData.id= 1269; name= "interceptor2ProjectileFallOff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5391; postExpression= 5392 } |> Some
      | 1657 -> { DogmaEffectData.id= 1657; name= "missileSkillWarheadUpgradesThermalDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1851 -> { DogmaEffectData.id= 1851; name= "selfRof"; description= "Automatically generated effect"; displayName= "SelfRof"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2724 -> { DogmaEffectData.id= 2724; name= "rigDrawbackBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9781; postExpression= 9782 } |> Some
      | 2821 -> { DogmaEffectData.id= 2821; name= "maxScanDeviationModifierRequireingAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10016; postExpression= 10017 } |> Some
      | 2918 -> { DogmaEffectData.id= 2918; name= "posStructureControlAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3015 -> { DogmaEffectData.id= 3015; name= "eliteBonusStealhBomberBombDeploymentCpu"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10621; postExpression= 10622 } |> Some
      | 3112 -> { DogmaEffectData.id= 3112; name= "controlTowerGenericHullE&EResistanceBonusCynoGenerator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10945; postExpression= 10946 } |> Some
      | 3403 -> { DogmaEffectData.id= 3403; name= "eliteBonusBlackOpsCloakVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3500 -> { DogmaEffectData.id= 3500; name= "miningLaserMaxRangeMultBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3597 -> { DogmaEffectData.id= 3597; name= "scriptSensorBoosterScanResolutionBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3694 -> { DogmaEffectData.id= 3694; name= "turretWeaponFalloffMultiplyTargetHostile4"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12640; postExpression= 12641 } |> Some
      | 3791 -> { DogmaEffectData.id= 3791; name= "modifyHullResonancePostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 3888 -> { DogmaEffectData.id= 3888; name= "subsystemBonusAmarrElectronicCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13141; postExpression= 13142 } |> Some
      | 396 -> { DogmaEffectData.id= 396; name= "energyGridUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringEnergyGridUpgrades"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4082 -> { DogmaEffectData.id= 4082; name= "systemMediumProjectileDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13645; postExpression= 13646 } |> Some
      | 4179 -> { DogmaEffectData.id= 4179; name= "subsystemBonusCaldariEngineeringOffensiveHybridTurretROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13875; postExpression= 13876 } |> Some
      | 4276 -> { DogmaEffectData.id= 4276; name= "subsystemBonusCaldariPropulsion2WarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14153; postExpression= 14154 } |> Some
      | 4373 -> { DogmaEffectData.id= 4373; name= "subSystemBonusAmarrOffensiveCommandBursts"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4567 -> { DogmaEffectData.id= 4567; name= "capitalLauncherSkillCruiseCitadelAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14980; postExpression= 14981 } |> Some
      | 4761 -> { DogmaEffectData.id= 4761; name= "eliteBonusBlackOpsECMBurstGravimetric1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15393; postExpression= 15394 } |> Some
      | 4858 -> { DogmaEffectData.id= 4858; name= "skillBonusBoosterEffect"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15688; postExpression= 15689 } |> Some
      | 5052 -> { DogmaEffectData.id= 5052; name= "baseDefenderAllyCostCharAssignment"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5149 -> { DogmaEffectData.id= 5149; name= "DSTdronetrackingbonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16419; postExpression= 16420 } |> Some
      | 5246 -> { DogmaEffectData.id= 5246; name= "shipSmallMissileEMDmgMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16647; postExpression= 16648 } |> Some
      | 5343 -> { DogmaEffectData.id= 5343; name= "shipBonusDroneDamageMultiplierGBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5440 -> { DogmaEffectData.id= 5440; name= "systemStandardMissileKineticDamage"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 5634 -> { DogmaEffectData.id= 5634; name= "shipBonusTorpedoMissileThermDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 590 -> { DogmaEffectData.id= 590; name= "energyPulseWeaponsDurationBonusPostPercentDurationLocationShipModulesRequiringEnergyPulseWeapons"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5925 -> { DogmaEffectData.id= 5925; name= "systemLadarECMBomb"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6022 -> { DogmaEffectData.id= 6022; name= "reconShipSkillMultiplier3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6216 -> { DogmaEffectData.id= 6216; name= "structureEnergyNeutralizerFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6313 -> { DogmaEffectData.id= 6313; name= "shipBonusShieldThermalResistanceMD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19158; postExpression= 19159 } |> Some
      | 6410 -> { DogmaEffectData.id= 6410; name= "structureRigExplosionRadiusBonusAoEMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6507 -> { DogmaEffectData.id= 6507; name= "shipBonusDreadnoughtG2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6604 -> { DogmaEffectData.id= 6604; name= "shipBonusSupercarrierC1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6701 -> { DogmaEffectData.id= 6701; name= "rigDrawbackReductionProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6798 -> { DogmaEffectData.id= 6798; name= "shipModeSETDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6895 -> { DogmaEffectData.id= 6895; name= "subsystemMETFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6992 -> { DogmaEffectData.id= 6992; name= "roleBonusMHTDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7186 -> { DogmaEffectData.id= 7186; name= "shipBonusMediumDroneArmorHProle8"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 784 -> { DogmaEffectData.id= 784; name= "missileBombardmentMaxFlightTimeBonusPostPercentExplosionDelayOwnerCharModulesRequiringMissileLauncherOperation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 881 -> { DogmaEffectData.id= 881; name= "implantEWcpuneed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4048; postExpression= 4049 } |> Some
      | _ -> None