namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects18=
    let getDogmaEffect id = 
      match id with 
      | 115 -> { DogmaEffectData.id= 115; name= "characterPerceptionSkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 785; postExpression= 784 } |> Some
      | 1182 -> { DogmaEffectData.id= 1182; name= "shipEnergyTransferRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5137; postExpression= 5138 } |> Some
      | 1279 -> { DogmaEffectData.id= 1279; name= "interceptors2SkillLevelPreMulEliteBonusInterceptorShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5400; postExpression= 5401 } |> Some
      | 1376 -> { DogmaEffectData.id= 1376; name= "ewSkillSignatureDampenBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5705; postExpression= 5706 } |> Some
      | 1473 -> { DogmaEffectData.id= 1473; name= "missileSkillAoeCloudSizeBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6004; postExpression= 6005 } |> Some
      | 1667 -> { DogmaEffectData.id= 1667; name= "freighterM2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6617; postExpression= 6618 } |> Some
      | 1764 -> { DogmaEffectData.id= 1764; name= "missileSkillMissileProjectileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6861; postExpression= 6862 } |> Some
      | 18 -> { DogmaEffectData.id= 18; name= "shieldTransfer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 185; postExpression= 89 } |> Some
      | 2055 -> { DogmaEffectData.id= 2055; name= "kineticShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7769; postExpression= 7770 } |> Some
      | 212 -> { DogmaEffectData.id= 212; name= "sensorUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringSensorUpgrades"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1446; postExpression= 1447 } |> Some
      | 2152 -> { DogmaEffectData.id= 2152; name= "jumpPortalGeneration"; description= ""; displayName= ""; effectCategory= 1; preExpression= 6732; postExpression= 6733 } |> Some
      | 2249 -> { DogmaEffectData.id= 2249; name= "shipBonusDroneMiningAmountAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8329; postExpression= 8330 } |> Some
      | 2540 -> { DogmaEffectData.id= 2540; name= "capacitorCapacityPenaltyBoosterAttribute2"; description= "Automatically generated effect"; displayName= "Capacitor Capacity Penalty"; effectCategory= 0; preExpression= 9234; postExpression= 9235 } |> Some
      | 2734 -> { DogmaEffectData.id= 2734; name= "shipECMScanStrengthBonusCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9809; postExpression= 9810 } |> Some
      | 3025 -> { DogmaEffectData.id= 3025; name= "overloadSelfDamageBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 10654; postExpression= 10655 } |> Some
      | 309 -> { DogmaEffectData.id= 309; name= "spatialAwarenessSkillBoostPerceptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1848; postExpression= 1849 } |> Some
      | 3122 -> { DogmaEffectData.id= 3122; name= "controlTowerGenericHullE&EResistanceBonusSensorDampener"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10965; postExpression= 10966 } |> Some
      | 3219 -> { DogmaEffectData.id= 3219; name= "eliteBonusHeavyGunshipMissileEmDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11226; postExpression= 11227 } |> Some
      | 3316 -> { DogmaEffectData.id= 3316; name= "shipMissileHeavyVelocityBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9645; postExpression= 9646 } |> Some
      | 3510 -> { DogmaEffectData.id= 3510; name= "miningLaserAndFrequencyMiningLaserAndStripMinerMaxRangeMultBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12058; postExpression= 12059 } |> Some
      | 3607 -> { DogmaEffectData.id= 3607; name= "commandMultiplierInformationWarfareSpecialistHidden"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12379; postExpression= 12380 } |> Some
      | 3995 -> { DogmaEffectData.id= 3995; name= "systemSignatureRadius"; description= ""; displayName= ""; effectCategory= 7; preExpression= 11152; postExpression= 11153 } |> Some
      | 406 -> { DogmaEffectData.id= 406; name= "socialSkillBoostSocialMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2296; postExpression= 2297 } |> Some
      | 4092 -> { DogmaEffectData.id= 4092; name= "subsystemBonusAmarrOffensiveEnergyWeaponROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13682; postExpression= 13683 } |> Some
      | 4189 -> { DogmaEffectData.id= 4189; name= "shipBonusStrategicCruiserGallenteHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13898; postExpression= 13899 } |> Some
      | 4286 -> { DogmaEffectData.id= 4286; name= "subsystemBonusAmarrOffensive2RemoteArmorRepairCapUse"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14174; postExpression= 14175 } |> Some
      | 4480 -> { DogmaEffectData.id= 4480; name= "covertOpsSkillLevelPreMulEliteBonusCoverOpsShip3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14689; postExpression= 14690 } |> Some
      | 4577 -> { DogmaEffectData.id= 4577; name= "eliteBonusLogisticsTrackingLinkFalloffBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15003; postExpression= 15004 } |> Some
      | 4771 -> { DogmaEffectData.id= 4771; name= "onlineOrbital"; description= "this is the online effect for structures"; displayName= "online"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 4868 -> { DogmaEffectData.id= 4868; name= "setBonusChristmasCapacitorCapacity"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15729; postExpression= 15730 } |> Some
      | 4965 -> { DogmaEffectData.id= 4965; name= "shieldBoosterDurationBonusShieldOperation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15990; postExpression= 15991 } |> Some
      | 5062 -> { DogmaEffectData.id= 5062; name= "shipBonusDroneMWDBoostGF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16231; postExpression= 16232 } |> Some
      | 5353 -> { DogmaEffectData.id= 5353; name= "shipProjectileRof1MBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16907; postExpression= 16908 } |> Some
      | 5450 -> { DogmaEffectData.id= 5450; name= "shipMissileThermalDamageMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17114; postExpression= 17115 } |> Some
      | 5644 -> { DogmaEffectData.id= 5644; name= "shipBonusMissileVelocityCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 4366; postExpression= 4367 } |> Some
      | 600 -> { DogmaEffectData.id= 600; name= "ammoTrackingMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3063; postExpression= 3064 } |> Some
      | 6032 -> { DogmaEffectData.id= 6032; name= "remoteCapacitorTransmitterPowerNeedBonusEffect"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18555; postExpression= 18556 } |> Some
      | 6129 -> { DogmaEffectData.id= 6129; name= "scriptMissileGuidanceComputerAOEVelocityBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18786; postExpression= 18787 } |> Some
      | 6226 -> { DogmaEffectData.id= 6226; name= "structureMissileGuidanceComputerBonus4"; description= ""; displayName= ""; effectCategory= 1; preExpression= 18804; postExpression= 18805 } |> Some
      | 6323 -> { DogmaEffectData.id= 6323; name= "scriptscanLadarStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6420 -> { DogmaEffectData.id= 6420; name= "fighterDamageMultiply"; description= ""; displayName= "Attack Damage Boost"; effectCategory= 1; preExpression= 667; postExpression= 670 } |> Some
      | 6517 -> { DogmaEffectData.id= 6517; name= "skillMultiplierShipBonusForceAuxiliaryCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6614 -> { DogmaEffectData.id= 6614; name= "shipBonusSupercarrierRole2ArmorShieldModuleBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6711 -> { DogmaEffectData.id= 6711; name= "shipBonusRole3CapitalHybridDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6808 -> { DogmaEffectData.id= 6808; name= "rigAmmoManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of ammo"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6905 -> { DogmaEffectData.id= 6905; name= "strategicCruiserAmarrSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13905; postExpression= 13906 } |> Some
      | 7002 -> { DogmaEffectData.id= 7002; name= "roleBonusBombLauncherPWGCPU3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19366; postExpression= 19367 } |> Some
      | 7099 -> { DogmaEffectData.id= 7099; name= "structureConversionRigManufacturingMaterialBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 891 -> { DogmaEffectData.id= 891; name= "shipCruiseMissileVelocityBonusCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4081; postExpression= 4082 } |> Some
      | 988 -> { DogmaEffectData.id= 988; name= "gunshipSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4391; postExpression= 4392 } |> Some
      | _ -> None