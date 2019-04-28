namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects95=
    let getDogmaEffect id = 
      match id with 
      | 1259 -> { DogmaEffectData.id= 1259; name= "testfuelConsumption"; description= "Automatically generated effect"; displayName= "TESTfuelConsumption"; effectCategory= 1; preExpression= 5360; postExpression= 5361 } |> Some
      | 1453 -> { DogmaEffectData.id= 1453; name= "ewSkillEwFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5947; postExpression= 5948 } |> Some
      | 1550 -> { DogmaEffectData.id= 1550; name= "ewSkillTargetPaintingStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5951; postExpression= 5952 } |> Some
      | 1938 -> { DogmaEffectData.id= 1938; name= "setActiveDamageResonanceMultiplier"; description= ""; displayName= ""; effectCategory= 1; preExpression= 7421; postExpression= 7422 } |> Some
      | 2132 -> { DogmaEffectData.id= 2132; name= "smallProjectileMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8007; postExpression= 8008 } |> Some
      | 2423 -> { DogmaEffectData.id= 2423; name= "eliteReconHeavyMissileKineticDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8921; postExpression= 8922 } |> Some
      | 2714 -> { DogmaEffectData.id= 2714; name= "drawbackCPUNeedLaunchers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9753; postExpression= 9754 } |> Some
      | 2811 -> { DogmaEffectData.id= 2811; name= "cpuPenaltyToScanProbeLaunchers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9986; postExpression= 9987 } |> Some
      | 289 -> { DogmaEffectData.id= 289; name= "motionPredictionTrackingSpeedMultiplierPostPercentTrackingSpeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1786; postExpression= 1787 } |> Some
      | 2908 -> { DogmaEffectData.id= 2908; name= "missileExplosiveDmgBonusTorpedo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10283; postExpression= 10284 } |> Some
      | 3102 -> { DogmaEffectData.id= 3102; name= "controlTowerGenericHullExplosiveResistanceBonusSensorDampener"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10903; postExpression= 10904 } |> Some
      | 3587 -> { DogmaEffectData.id= 3587; name= "shipBonusEwRemoteSensorDampenerMaxTargetRangeBonusGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12297; postExpression= 12298 } |> Some
      | 3878 -> { DogmaEffectData.id= 3878; name= "subsystemBonusGallenteElectronicSignatureRadius"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13121; postExpression= 13122 } |> Some
      | 3975 -> { DogmaEffectData.id= 3975; name= "subsystemBonusAmarrDefensiveShieldHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13315; postExpression= 13316 } |> Some
      | 4072 -> { DogmaEffectData.id= 4072; name= "subsystemBonusAmarrDefensiveCargoCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13615; postExpression= 13616 } |> Some
      | 4169 -> { DogmaEffectData.id= 4169; name= "subsystemBonusMinmatarDefensiveMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13855; postExpression= 13856 } |> Some
      | 4266 -> { DogmaEffectData.id= 4266; name= "subsystemBonusCaldariEngineeringCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14133; postExpression= 14134 } |> Some
      | 4363 -> { DogmaEffectData.id= 4363; name= "subsystemBonusAmarrOffensive2HAMThermalDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14353; postExpression= 14354 } |> Some
      | 4460 -> { DogmaEffectData.id= 4460; name= "imperialsetLGbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14629; postExpression= 14630 } |> Some
      | 4557 -> { DogmaEffectData.id= 4557; name= "capitalLauncherSkillCruiseCitadelKineticDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14958; postExpression= 14959 } |> Some
      | 4654 -> { DogmaEffectData.id= 4654; name= "shipRocketEmAndExpAndKinDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15169; postExpression= 15170 } |> Some
      | 4848 -> { DogmaEffectData.id= 4848; name= "bcSiegeMissileCPUNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15657; postExpression= 15658 } |> Some
      | 4945 -> { DogmaEffectData.id= 4945; name= "skillTargetBreakerDurationBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15942; postExpression= 15943 } |> Some
      | 5042 -> { DogmaEffectData.id= 5042; name= "shipBonusArchCycleCF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16185; postExpression= 16186 } |> Some
      | 5139 -> { DogmaEffectData.id= 5139; name= "shipMiningBonusOREfrig1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16398; postExpression= 16399 } |> Some
      | 5333 -> { DogmaEffectData.id= 5333; name= "shipLaserDamageBonusABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16867; postExpression= 16868 } |> Some
      | 5430 -> { DogmaEffectData.id= 5430; name= "shipBonusAoeVelocityCruiseMissilesMB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17053; postExpression= 17054 } |> Some
      | 5527 -> { DogmaEffectData.id= 5527; name= "skillJumpCloneCooldownReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17320; postExpression= 17321 } |> Some
      | 5721 -> { DogmaEffectData.id= 5721; name= "shipBonusMETOptimalRangePirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17744; postExpression= 17745 } |> Some
      | 5818 -> { DogmaEffectData.id= 5818; name= "shipBonusLightDroneArmorHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18005; postExpression= 18006 } |> Some
      | 5915 -> { DogmaEffectData.id= 5915; name= "systemEnergyVampireMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18257; postExpression= 18258 } |> Some
      | 6012 -> { DogmaEffectData.id= 6012; name= "shipModeScanStrengthPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8294; postExpression= 8295 } |> Some
      | 6206 -> { DogmaEffectData.id= 6206; name= "skirmishWarfareAgilityBonusReplacer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6303 -> { DogmaEffectData.id= 6303; name= "shipBonusEnergyNosFalloffAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19140; postExpression= 19141 } |> Some
      | 6400 -> { DogmaEffectData.id= 6400; name= "skillStructureElectronicSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6594 -> { DogmaEffectData.id= 6594; name= "shipBonusSupercarrierM3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6691 -> { DogmaEffectData.id= 6691; name= "entityEnergyNeutralizerFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 677 -> { DogmaEffectData.id= 677; name= "weaponUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringMissileLauncherOperation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3352; postExpression= 3353 } |> Some
      | 6788 -> { DogmaEffectData.id= 6788; name= "shipBonusDroneIceHarvestingICS5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6885 -> { DogmaEffectData.id= 6885; name= "npcBehaviorSiege"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6982 -> { DogmaEffectData.id= 6982; name= "shipBonusTitanG2EMExplosiveDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7079 -> { DogmaEffectData.id= 7079; name= "shipPCBSSPeedBonusPCBS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19493; postExpression= 19494 } |> Some
      | 7176 -> { DogmaEffectData.id= 7176; name= "skillBonusDroneInterfacingNotFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 95 -> { DogmaEffectData.id= 95; name= "energyWeaponSpeedMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 681; postExpression= 683 } |> Some
      | 968 -> { DogmaEffectData.id= 968; name= "shipProjectileDmgMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4322; postExpression= 4323 } |> Some
      | _ -> None