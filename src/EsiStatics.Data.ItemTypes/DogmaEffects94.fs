namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects94=
    let getDogmaEffect id = 
      match id with 
      | 1161 -> { DogmaEffectData.id= 1161; name= "controlTowerTrackingArrayLaserTrackingBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1258 -> { DogmaEffectData.id= 1258; name= "skillBoostContrabandDetectionChanceBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1355 -> { DogmaEffectData.id= 1355; name= "ewTestEffectWs"; description= ""; displayName= ""; effectCategory= 2; preExpression= 294; postExpression= 295 } |> Some
      | 1452 -> { DogmaEffectData.id= 1452; name= "ewSkillEwMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1549 -> { DogmaEffectData.id= 1549; name= "ewTargetPaint"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 1646 -> { DogmaEffectData.id= 1646; name= "informationCommandMindlink"; description= "Automatically generated effect"; displayName= "InformationCommandMindlink"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1840 -> { DogmaEffectData.id= 1840; name= "eliteBonusBargeMiningYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7100; postExpression= 7101 } |> Some
      | 2131 -> { DogmaEffectData.id= 2131; name= "smallEnergyMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2422 -> { DogmaEffectData.id= 2422; name= "implantVelocityBonus"; description= "Automatically generated effect"; displayName= "Max Velocity Bonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2713 -> { DogmaEffectData.id= 2713; name= "drawbackCPUOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2810 -> { DogmaEffectData.id= 2810; name= "eliteBonusHeavyGunshipAssaultMissileFlightTime1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 288 -> { DogmaEffectData.id= 288; name= "skillBoostTrackingSpeedMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1782; postExpression= 1783 } |> Some
      | 2907 -> { DogmaEffectData.id= 2907; name= "missileEMDmgBonusTorpedo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3004 -> { DogmaEffectData.id= 3004; name= "setGlobalPool"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10577; postExpression= 10578 } |> Some
      | 3101 -> { DogmaEffectData.id= 3101; name= "controlTowerGenericHullKineticResistanceBonusSensorDampener"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10899; postExpression= 10900 } |> Some
      | 3198 -> { DogmaEffectData.id= 3198; name= "overloadSelfShieldBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 11183; postExpression= 11184 } |> Some
      | 3392 -> { DogmaEffectData.id= 3392; name= "eliteBonusBlackOpsLargeEnergyTurretTracking1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3489 -> { DogmaEffectData.id= 3489; name= "shipBonusSmallEnergyTurretTracking2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3586 -> { DogmaEffectData.id= 3586; name= "ewSkillSignalSuppressionScanResolutionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3683 -> { DogmaEffectData.id= 3683; name= "freighterAgilityBonusA1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3780 -> { DogmaEffectData.id= 3780; name= "maxVelocityAdd"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12855; postExpression= 12856 } |> Some
      | 3877 -> { DogmaEffectData.id= 3877; name= "subsystemBonusMinmatarElectronicSignatureRadius"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13119; postExpression= 13120 } |> Some
      | 3974 -> { DogmaEffectData.id= 3974; name= "subsystemBonusAmarrDefensiveShieldBoostCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13313; postExpression= 13314 } |> Some
      | 4071 -> { DogmaEffectData.id= 4071; name= "subsystemBonusCaldariDefensiveCargoCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13613; postExpression= 13614 } |> Some
      | 4168 -> { DogmaEffectData.id= 4168; name= "eliteBonusCoverOpsScanProbeStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4265 -> { DogmaEffectData.id= 4265; name= "subsystemBonusGallenteCoreCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4362 -> { DogmaEffectData.id= 4362; name= "subsystemBonusAmarrOffensive2MissileDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4459 -> { DogmaEffectData.id= 4459; name= "caldarisetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4556 -> { DogmaEffectData.id= 4556; name= "capitalLauncherSkillCruiseCitadelExplosiveDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4653 -> { DogmaEffectData.id= 4653; name= "shipRocketEmAndExpDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15167; postExpression= 15168 } |> Some
      | 482 -> { DogmaEffectData.id= 482; name= "shipTargetingRangeBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2590; postExpression= 2591 } |> Some
      | 4847 -> { DogmaEffectData.id= 4847; name= "bcSiegeMissilePowerNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15652; postExpression= 15653 } |> Some
      | 4944 -> { DogmaEffectData.id= 4944; name= "skillTargetBreakerDurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15939; postExpression= 15940 } |> Some
      | 5041 -> { DogmaEffectData.id= 5041; name= "miniProfessionRangeBonus"; description= "Bonus to optimal range of Data Analyzer and Relic Analyzers"; displayName= ""; effectCategory= 0; preExpression= 16183; postExpression= 16184 } |> Some
      | 5138 -> { DogmaEffectData.id= 5138; name= "miningFrigateSkillLevelPostMulShipBonusORE2frig"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5332 -> { DogmaEffectData.id= 5332; name= "shipLaserCapABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5429 -> { DogmaEffectData.id= 5429; name= "shipBonusMissileAoeVelocityMB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5817 -> { DogmaEffectData.id= 5817; name= "shipBonusLightDroneHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5914 -> { DogmaEffectData.id= 5914; name= "systemEnergyNeutMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6011 -> { DogmaEffectData.id= 6011; name= "shipModeSETOptimalRangePostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6205 -> { DogmaEffectData.id= 6205; name= "informationWarfareMaxTargetRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6302 -> { DogmaEffectData.id= 6302; name= "shipBonusEnergyNosOptimalAC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19138; postExpression= 19139 } |> Some
      | 6399 -> { DogmaEffectData.id= 6399; name= "skillStructureDefensiveSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6593 -> { DogmaEffectData.id= 6593; name= "shipBonusSupercarrierG3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6690 -> { DogmaEffectData.id= 6690; name= "remoteWebifierEntity"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6787 -> { DogmaEffectData.id= 6787; name= "shipBonusDroneHPDamageMiningICS4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6884 -> { DogmaEffectData.id= 6884; name= "npcBehaviorArmorRepairer"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6981 -> { DogmaEffectData.id= 6981; name= "shipBonusTitanG1KinThermDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7078 -> { DogmaEffectData.id= 7078; name= "disintegratorWeaponSpeedMultiply"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 7175 -> { DogmaEffectData.id= 7175; name= "shipBonusRemoteCapacitorTransferPowerRequirementBonusRole2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19733; postExpression= 19734 } |> Some
      | 967 -> { DogmaEffectData.id= 967; name= "shipMwdLessCapNerfGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4320; postExpression= 4321 } |> Some
      | _ -> None