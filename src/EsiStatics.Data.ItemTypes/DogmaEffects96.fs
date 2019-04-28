namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects96=
    let getDogmaEffect id = 
      match id with 
      | 1066 -> { DogmaEffectData.id= 1066; name= "eliteBonusHeavyGunshipDroneCapacity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4686; postExpression= 4687 } |> Some
      | 1260 -> { DogmaEffectData.id= 1260; name= "testmassThrust"; description= "Automatically generated effect"; displayName= "TESTmassThrust"; effectCategory= 1; preExpression= 5364; postExpression= 5365 } |> Some
      | 1551 -> { DogmaEffectData.id= 1551; name= "minmatarShipEwTargetPainterMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5953; postExpression= 5954 } |> Some
      | 2133 -> { DogmaEffectData.id= 2133; name= "energyTransferArrayMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8009; postExpression= 8010 } |> Some
      | 2424 -> { DogmaEffectData.id= 2424; name= "eliteReconLightMissileKineticDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8925; postExpression= 8926 } |> Some
      | 2715 -> { DogmaEffectData.id= 2715; name= "drawbackCPUNeedGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9755; postExpression= 9756 } |> Some
      | 2812 -> { DogmaEffectData.id= 2812; name= "caldariShipECMBurstOptimalRangeCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9988; postExpression= 9989 } |> Some
      | 290 -> { DogmaEffectData.id= 290; name= "sharpshooterRangeSkillBonusPostPercentMaxRangeLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1790; postExpression= 1791 } |> Some
      | 2909 -> { DogmaEffectData.id= 2909; name= "missileKineticDmgBonusTorpedo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10287; postExpression= 10288 } |> Some
      | 3103 -> { DogmaEffectData.id= 3103; name= "controlTowerGenericHullEmResistanceBonusSensorDampener"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10907; postExpression= 10908 } |> Some
      | 3200 -> { DogmaEffectData.id= 3200; name= "overloadSelfArmorDamageAmountDurationBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 11189; postExpression= 11190 } |> Some
      | 3297 -> { DogmaEffectData.id= 3297; name= "shipEnergyNeutralizerTransferAmountBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11458; postExpression= 11459 } |> Some
      | 3491 -> { DogmaEffectData.id= 3491; name= "rorqualSpeedFactorIndustrialCore"; description= ""; displayName= ""; effectCategory= 1; preExpression= 11990; postExpression= 11991 } |> Some
      | 3588 -> { DogmaEffectData.id= 3588; name= "shipBonusEwRemoteSensorDampenerMaxTargetRangeBonusGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12299; postExpression= 12300 } |> Some
      | 3782 -> { DogmaEffectData.id= 3782; name= "powerOutputAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12859; postExpression= 12860 } |> Some
      | 3879 -> { DogmaEffectData.id= 3879; name= "subsystemBonusCaldariElectronicSignatureRadius"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13123; postExpression= 13124 } |> Some
      | 3976 -> { DogmaEffectData.id= 3976; name= "subsystemBonusCaldariDefensiveShieldHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13317; postExpression= 13318 } |> Some
      | 4073 -> { DogmaEffectData.id= 4073; name= "systemMediumHybridDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13618; postExpression= 13619 } |> Some
      | 4170 -> { DogmaEffectData.id= 4170; name= "subsystemBonusAmarrEngineeringOffensiveEnergyWeaponROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13857; postExpression= 13858 } |> Some
      | 4267 -> { DogmaEffectData.id= 4267; name= "subsystemBonusAmarrEngineeringCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14135; postExpression= 14136 } |> Some
      | 4364 -> { DogmaEffectData.id= 4364; name= "subsystemBonusAmarrOffensive2HAMKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14355; postExpression= 14356 } |> Some
      | 4461 -> { DogmaEffectData.id= 4461; name= "federationsetLGbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14634; postExpression= 14635 } |> Some
      | 4558 -> { DogmaEffectData.id= 4558; name= "capitalLauncherSkillCruiseCitadelThermalDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14960; postExpression= 14961 } |> Some
      | 4655 -> { DogmaEffectData.id= 4655; name= "shipRocketEmAndExpAndKinAndThmDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15171; postExpression= 15172 } |> Some
      | 4849 -> { DogmaEffectData.id= 4849; name= "shipTorpedosVelocityBonusBC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15660; postExpression= 15661 } |> Some
      | 4946 -> { DogmaEffectData.id= 4946; name= "skillTargetBreakerCapNeedBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15945; postExpression= 15946 } |> Some
      | 5140 -> { DogmaEffectData.id= 5140; name= "shipGCHBonusOREfrig1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16402; postExpression= 16403 } |> Some
      | 5237 -> { DogmaEffectData.id= 5237; name= "shipSmallMissileKinDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16629; postExpression= 16630 } |> Some
      | 5334 -> { DogmaEffectData.id= 5334; name= "shipHybridOptimal1CBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16869; postExpression= 16870 } |> Some
      | 5431 -> { DogmaEffectData.id= 5431; name= "shipBonusLargeEnergyTurretTrackingAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17055; postExpression= 17056 } |> Some
      | 5528 -> { DogmaEffectData.id= 5528; name= "roleBonusArmoredWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17323; postExpression= 17324 } |> Some
      | 5722 -> { DogmaEffectData.id= 5722; name= "shipHybridOptimalGD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17746; postExpression= 17747 } |> Some
      | 581 -> { DogmaEffectData.id= 581; name= "weaponUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3009; postExpression= 3010 } |> Some
      | 5819 -> { DogmaEffectData.id= 5819; name= "shipBonusLightDroneShieldHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18009; postExpression= 18010 } |> Some
      | 5916 -> { DogmaEffectData.id= 5916; name= "systemDamageExplosiveBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18260; postExpression= 18261 } |> Some
      | 6013 -> { DogmaEffectData.id= 6013; name= "shipModeScanResPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3427; postExpression= 3428 } |> Some
      | 6110 -> { DogmaEffectData.id= 6110; name= "missileVelocityBonusOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 18736; postExpression= 18737 } |> Some
      | 6304 -> { DogmaEffectData.id= 6304; name= "shipBonusEnergyNosFalloffAC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19142; postExpression= 19143 } |> Some
      | 6401 -> { DogmaEffectData.id= 6401; name= "skillStructureEngineeringSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6498 -> { DogmaEffectData.id= 6498; name= "skillMultiplierShipBonusDreadnoughtMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6595 -> { DogmaEffectData.id= 6595; name= "shipBonusCarrierA4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6692 -> { DogmaEffectData.id= 6692; name= "remoteTargetPaintEntity"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6789 -> { DogmaEffectData.id= 6789; name= "industrialBonusDroneDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6983 -> { DogmaEffectData.id= 6983; name= "shipBonusTitanC1ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7080 -> { DogmaEffectData.id= 7080; name= "shipPCBSDmgBonusPCBS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19495; postExpression= 19496 } |> Some
      | 7177 -> { DogmaEffectData.id= 7177; name= "skillBonusDroneDurabilityNotFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 775 -> { DogmaEffectData.id= 775; name= "capBoostAmplifier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 3694; postExpression= 3695 } |> Some
      | 96 -> { DogmaEffectData.id= 96; name= "hybridWeaponSpeedMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 682; postExpression= 684 } |> Some
      | 969 -> { DogmaEffectData.id= 969; name= "smartbombEMBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 4327; postExpression= 4328 } |> Some
      | _ -> None