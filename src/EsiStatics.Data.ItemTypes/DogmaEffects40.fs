namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects40=
    let getDogmaEffect id = 
      match id with 
      | 1010 -> { DogmaEffectData.id= 1010; name= "selfT2MediumLaserBeamDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4474; postExpression= 4475 } |> Some
      | 1204 -> { DogmaEffectData.id= 1204; name= "shipPTurretSpeedBonusGB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5204; postExpression= 5205 } |> Some
      | 1398 -> { DogmaEffectData.id= 1398; name= "eliteBonusCoverOpsCruiseEmDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5791; postExpression= 5792 } |> Some
      | 1495 -> { DogmaEffectData.id= 1495; name= "flagshipmultiRelayEffect"; description= "Automatically generated effect"; displayName= "multiRelayEffect"; effectCategory= 4; preExpression= 6083; postExpression= 6084 } |> Some
      | 1592 -> { DogmaEffectData.id= 1592; name= "capitalLauncherSkillCitadelEmDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6365; postExpression= 6366 } |> Some
      | 234 -> { DogmaEffectData.id= 234; name= "warpdriveoperationSkillBoostWarpCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1549; postExpression= 1550 } |> Some
      | 2465 -> { DogmaEffectData.id= 2465; name= "shipBonusArmorResistAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9049; postExpression= 9050 } |> Some
      | 2659 -> { DogmaEffectData.id= 2659; name= "scanMagnetometricStrengthBonusRequringAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9603; postExpression= 9604 } |> Some
      | 2756 -> { DogmaEffectData.id= 2756; name= "shipBonusECMStrengthBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9867; postExpression= 9868 } |> Some
      | 2853 -> { DogmaEffectData.id= 2853; name= "cloakingTargetingDelayBonusLRSMCloakingPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10112; postExpression= 10113 } |> Some
      | 3047 -> { DogmaEffectData.id= 3047; name= "structureHPMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 494; postExpression= 495 } |> Some
      | 3144 -> { DogmaEffectData.id= 3144; name= "controlTowerGenericHullResistanceBonusMissile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11007; postExpression= 11008 } |> Some
      | 3241 -> { DogmaEffectData.id= 3241; name= "eliteBonusGunshipArmorEmResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11264; postExpression= 11265 } |> Some
      | 331 -> { DogmaEffectData.id= 331; name= "refineryEfficiencySkillBoostRefiningYieldMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1959; postExpression= 1960 } |> Some
      | 3338 -> { DogmaEffectData.id= 3338; name= "shipArmorKineticResistanceGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11562; postExpression= 11563 } |> Some
      | 3435 -> { DogmaEffectData.id= 3435; name= "eliteBonusViolatorsTorpedoThermalDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11852; postExpression= 11853 } |> Some
      | 3532 -> { DogmaEffectData.id= 3532; name= "skillJumpDriveConsumptionAmountBonusPercentage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12154; postExpression= 12155 } |> Some
      | 3726 -> { DogmaEffectData.id= 3726; name= "agilityMultiplierEffectPassive"; description= "Automatically generated effect"; displayName= "AgilityMultiplierEffectPassive"; effectCategory= 0; preExpression= 3285; postExpression= 3286 } |> Some
      | 3823 -> { DogmaEffectData.id= 3823; name= "modifyArmorResonancePassiveSubtract"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12937; postExpression= 12938 } |> Some
      | 40 -> { DogmaEffectData.id= 40; name= "launcherFitted"; description= ""; displayName= ""; effectCategory= 0; preExpression= 373; postExpression= 319 } |> Some
      | 4017 -> { DogmaEffectData.id= 4017; name= "systemDamageThermalMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13425; postExpression= 13426 } |> Some
      | 4114 -> { DogmaEffectData.id= 4114; name= "subsystemBonusMinmatarOffensiveProjectileWeaponFalloff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13734; postExpression= 13735 } |> Some
      | 4211 -> { DogmaEffectData.id= 4211; name= "subsystemSkillLevelAmarrPropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14002; postExpression= 14003 } |> Some
      | 428 -> { DogmaEffectData.id= 428; name= "productionEfficiencySkillBoostManufactureCostBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2393; postExpression= 2394 } |> Some
      | 4405 -> { DogmaEffectData.id= 4405; name= "subSystemBonusMinmatarElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14446; postExpression= 14447 } |> Some
      | 4599 -> { DogmaEffectData.id= 4599; name= "caldariFrigateSkillLevelPreMulShipBonus3CFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15059; postExpression= 15060 } |> Some
      | 4696 -> { DogmaEffectData.id= 4696; name= "systemDamageExplosiveSmartbombs"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15255; postExpression= 15256 } |> Some
      | 4793 -> { DogmaEffectData.id= 4793; name= "shipBonusMissileLauncherHeavyROFATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15458; postExpression= 15459 } |> Some
      | 5181 -> { DogmaEffectData.id= 5181; name= "sensorCompensationSensorStrengthBonusLadar"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16490; postExpression= 16491 } |> Some
      | 525 -> { DogmaEffectData.id= 525; name= "shipVelocityBonusMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2804; postExpression= 2805 } |> Some
      | 5278 -> { DogmaEffectData.id= 5278; name= "destroyerSkillLevelPreMulShipBonusCD1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16730; postExpression= 16731 } |> Some
      | 5375 -> { DogmaEffectData.id= 5375; name= "shipArmorHpABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16944; postExpression= 16945 } |> Some
      | 5472 -> { DogmaEffectData.id= 5472; name= "shipBonusAmmoBayMI"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17186; postExpression= 17187 } |> Some
      | 5569 -> { DogmaEffectData.id= 5569; name= "subSystemBonusMinmatarDefensiveSiegeWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17421; postExpression= 17422 } |> Some
      | 5957 -> { DogmaEffectData.id= 5957; name= "eliteBonusHeavyInterdictorsMETOptimal"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18379; postExpression= 18380 } |> Some
      | 6054 -> { DogmaEffectData.id= 6054; name= "shipBonusHeavyDroneHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18611; postExpression= 18612 } |> Some
      | 6151 -> { DogmaEffectData.id= 6151; name= "modeHullResonancePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7861; postExpression= 7862 } |> Some
      | 622 -> { DogmaEffectData.id= 622; name= "damageCloudChanceReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3151; postExpression= 3152 } |> Some
      | 6345 -> { DogmaEffectData.id= 6345; name= "scriptStasisWebifierMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6442 -> { DogmaEffectData.id= 6442; name= "fighterAbilityMicroJumpDrive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6636 -> { DogmaEffectData.id= 6636; name= "shipBonusTitanG1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6733 -> { DogmaEffectData.id= 6733; name= "moduleBonusWarfareLinkShield"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6830 -> { DogmaEffectData.id= 6830; name= "rigInventionCostBonus"; description= "Structure Rig Cost effect on Invention"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6927 -> { DogmaEffectData.id= 6927; name= "subsystemBonusMinmatarPropulsionWarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15389; postExpression= 15390 } |> Some
      | 7024 -> { DogmaEffectData.id= 7024; name= "shipBonusDroneTrackingEliteGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19388; postExpression= 19389 } |> Some
      | 7218 -> { DogmaEffectData.id= 7218; name= "shipNosPowerReductionEliteGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19828; postExpression= 19829 } |> Some
      | _ -> None