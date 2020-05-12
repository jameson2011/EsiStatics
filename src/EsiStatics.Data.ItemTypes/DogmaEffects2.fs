namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects2=
    let getDogmaEffect id = 
      match id with 
      | 1166 -> { DogmaEffectData.id= 1166; name= "shipMinerCPUNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5067; postExpression= 5068 } |> Some
      | 1360 -> { DogmaEffectData.id= 1360; name= "ewSkillRsdCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1651 -> { DogmaEffectData.id= 1651; name= "skillCynosural&SiegeConsumQuantityBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2136 -> { DogmaEffectData.id= 2136; name= "trackingLinkMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8027; postExpression= 8028 } |> Some
      | 2427 -> { DogmaEffectData.id= 2427; name= "skillInterdictorEliteBonus2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2524 -> { DogmaEffectData.id= 2524; name= "hybridTurretTrackingBonusPassiveTrackingSpeedMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9168; postExpression= 9169 } |> Some
      | 2718 -> { DogmaEffectData.id= 2718; name= "drawbackShieldCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2912 -> { DogmaEffectData.id= 2912; name= "energyDestabilizationNewForStructure"; description= ""; displayName= ""; effectCategory= 2; preExpression= 8495; postExpression= 8496 } |> Some
      | 3106 -> { DogmaEffectData.id= 3106; name= "controlTowerGenericHullKineticResistanceBonusStasis"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10921; postExpression= 10922 } |> Some
      | 3397 -> { DogmaEffectData.id= 3397; name= "eliteBonusBlackOpsECMLadarStrengthBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11734; postExpression= 11735 } |> Some
      | 3494 -> { DogmaEffectData.id= 3494; name= "rorqualSurveyScannerRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3591 -> { DogmaEffectData.id= 3591; name= "ewSkillSignalSuppressionMaxTargetRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3688 -> { DogmaEffectData.id= 3688; name= "targetGunneryFalloffHostile"; description= "Automatically generated effect"; displayName= ""; effectCategory= 2; preExpression= 12619; postExpression= 12620 } |> Some
      | 3785 -> { DogmaEffectData.id= 3785; name= "modifyHullResonancePostPercentEM"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12864; postExpression= 12865 } |> Some
      | 3882 -> { DogmaEffectData.id= 3882; name= "subsystemBonusCaldariElectronicMaxTargetRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13129; postExpression= 13130 } |> Some
      | 3979 -> { DogmaEffectData.id= 3979; name= "subsystemBonusMinmatarDefensiveShieldArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4076 -> { DogmaEffectData.id= 4076; name= "systemHeavyMissileKineticDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13627; postExpression= 13628 } |> Some
      | 4173 -> { DogmaEffectData.id= 4173; name= "subsystemBonusMinmatarEngineeringOffensiveProjectileTurretROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13863; postExpression= 13864 } |> Some
      | 4270 -> { DogmaEffectData.id= 4270; name= "subsystemBonusMinmatarCore3ScanResolution"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4367 -> { DogmaEffectData.id= 4367; name= "shipBonusHybridOptimalCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14361; postExpression= 14362 } |> Some
      | 4464 -> { DogmaEffectData.id= 4464; name= "shipProjectileRofMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4852 -> { DogmaEffectData.id= 4852; name= "battlecruiserSkillLevelPreMulShipBonusBC4Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5046 -> { DogmaEffectData.id= 5046; name= "shipBonusArchCycleGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16193; postExpression= 16194 } |> Some
      | 5143 -> { DogmaEffectData.id= 5143; name= "shipBonusDroneArmorHitpointsDF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16407; postExpression= 16408 } |> Some
      | 5240 -> { DogmaEffectData.id= 5240; name= "shipSmallMissileThermDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5337 -> { DogmaEffectData.id= 5337; name= "shipShieldKineticResistance1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5434 -> { DogmaEffectData.id= 5434; name= "dataMiningSkillLevelVirusCoherenceBonusModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17067; postExpression= 17068 } |> Some
      | 5628 -> { DogmaEffectData.id= 5628; name= "shipBonusCruiseMissileEMDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5725 -> { DogmaEffectData.id= 5725; name= "shipBonusRemoteRepairAmountPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5822 -> { DogmaEffectData.id= 5822; name= "shipBonusMediumDroneHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 584 -> { DogmaEffectData.id= 584; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5919 -> { DogmaEffectData.id= 5919; name= "systemDamageEMBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6016 -> { DogmaEffectData.id= 6016; name= "modeAgilityPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6113 -> { DogmaEffectData.id= 6113; name= "missileAOEVelocityBonusOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6210 -> { DogmaEffectData.id= 6210; name= "commandDestroyerSkillMultiplier2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6307 -> { DogmaEffectData.id= 6307; name= "shipBonusThermMissileDmgMD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6404 -> { DogmaEffectData.id= 6404; name= "structureRigNeutralizerMaxRangeFalloffEffectiveness"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6501 -> { DogmaEffectData.id= 6501; name= "shipBonusDreadnoughtA1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6598 -> { DogmaEffectData.id= 6598; name= "shipBonusCarrierM4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6695 -> { DogmaEffectData.id= 6695; name= "entityECMFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6792 -> { DogmaEffectData.id= 6792; name= "shipBonusDroneHPDamageMiningORECapital4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6889 -> { DogmaEffectData.id= 6889; name= "rigAdvCapComponentManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced capital components"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6986 -> { DogmaEffectData.id= 6986; name= "shipBonusForceAuxiliaryG1RemoteShieldBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7180 -> { DogmaEffectData.id= 7180; name= "miningDurationMultiplierOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 875 -> { DogmaEffectData.id= 875; name= "shipLaserOptimalBonuseAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4030; postExpression= 4031 } |> Some
      | 972 -> { DogmaEffectData.id= 972; name= "smartbombEXBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 4339; postExpression= 4340 } |> Some
      | _ -> None