namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects64=
    let getDogmaEffect id = 
      match id with 
      | 1034 -> { DogmaEffectData.id= 1034; name= "eliteBonusLogisticRemoteArmorRepairCapNeed2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4578; postExpression= 4579 } |> Some
      | 1131 -> { DogmaEffectData.id= 1131; name= "controlTowerSiloCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4928; postExpression= 4929 } |> Some
      | 1228 -> { DogmaEffectData.id= 1228; name= "shipProjectileTrackingGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5275; postExpression= 5276 } |> Some
      | 161 -> { DogmaEffectData.id= 161; name= "mediumProjectileTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringMediumProjectileTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1212; postExpression= 1213 } |> Some
      | 1616 -> { DogmaEffectData.id= 1616; name= "skillCapitalShipsAdvancedAgility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6418; postExpression= 6419 } |> Some
      | 2392 -> { DogmaEffectData.id= 2392; name= "iceHarvesterMiningAmountBonusMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8800; postExpression= 8801 } |> Some
      | 2489 -> { DogmaEffectData.id= 2489; name= "shipBonusRemoteTrackingComputerFalloffMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9103; postExpression= 9104 } |> Some
      | 2683 -> { DogmaEffectData.id= 2683; name= "addMedSlot"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9667; postExpression= 9668 } |> Some
      | 2780 -> { DogmaEffectData.id= 2780; name= "maxVelocityBonusModifier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 3908; postExpression= 3909 } |> Some
      | 2877 -> { DogmaEffectData.id= 2877; name= "missileEMDmgBonusCruise2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10183; postExpression= 10184 } |> Some
      | 2974 -> { DogmaEffectData.id= 2974; name= "skillRemoteECMDurationBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10487; postExpression= 10488 } |> Some
      | 3071 -> { DogmaEffectData.id= 3071; name= "controlTowerGenericHullEmResistanceBonusCynoJammer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10773; postExpression= 10774 } |> Some
      | 3265 -> { DogmaEffectData.id= 3265; name= "industrialReconfigurationCpuNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11354; postExpression= 11355 } |> Some
      | 3362 -> { DogmaEffectData.id= 3362; name= "eliteBonusElectronicAttackShipEnergyNeutRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11627; postExpression= 11628 } |> Some
      | 3459 -> { DogmaEffectData.id= 3459; name= "warpDisruptionFieldAfterburnerAndMassOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11914; postExpression= 11915 } |> Some
      | 355 -> { DogmaEffectData.id= 355; name= "ethnicRelationsNonRaceCorporationMembersBonusModAddMaxNonRaceCorporationMembersChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2088; postExpression= 2089 } |> Some
      | 3556 -> { DogmaEffectData.id= 3556; name= "targetGunneryMaxRangeAndTrackingSpeedBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12234; postExpression= 12235 } |> Some
      | 3653 -> { DogmaEffectData.id= 3653; name= "ewGroupEcmBurstMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12532; postExpression= 12533 } |> Some
      | 3847 -> { DogmaEffectData.id= 3847; name= "subsystemSkillLevelAmarrOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13049; postExpression= 13050 } |> Some
      | 4041 -> { DogmaEffectData.id= 4041; name= "systemOverloadRof"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13516; postExpression= 13517 } |> Some
      | 4138 -> { DogmaEffectData.id= 4138; name= "systemShieldThermalResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13784; postExpression= 13785 } |> Some
      | 4235 -> { DogmaEffectData.id= 4235; name= "modifyArmorResonanceThermalPreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14067; postExpression= 14068 } |> Some
      | 4332 -> { DogmaEffectData.id= 4332; name= "subsystemBonusCaldariOffensive3HeavyMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14276; postExpression= 14277 } |> Some
      | 452 -> { DogmaEffectData.id= 452; name= "shipVelocityBonusMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2497; postExpression= 2498 } |> Some
      | 4526 -> { DogmaEffectData.id= 4526; name= "gunneryFalloffBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 14834; postExpression= 14835 } |> Some
      | 4623 -> { DogmaEffectData.id= 4623; name= "shipBonusSmallHybridTrackingSpeedATF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15109; postExpression= 15110 } |> Some
      | 4817 -> { DogmaEffectData.id= 4817; name= "salvagerModuleDurationReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15529; postExpression= 15530 } |> Some
      | 4914 -> { DogmaEffectData.id= 4914; name= "setMaxSpeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 15836; postExpression= 15837 } |> Some
      | 5011 -> { DogmaEffectData.id= 5011; name= "shipShieldKineticResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16106; postExpression= 16107 } |> Some
      | 5108 -> { DogmaEffectData.id= 5108; name= "shipBonusRemoteArmorRepairAmountGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16331; postExpression= 16332 } |> Some
      | 5205 -> { DogmaEffectData.id= 5205; name= "shipSETTrackingBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16554; postExpression= 16555 } |> Some
      | 5302 -> { DogmaEffectData.id= 5302; name= "shipBonusEnergyNeutRangeAD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16805; postExpression= 16806 } |> Some
      | 5399 -> { DogmaEffectData.id= 5399; name= "baseSensorStrengthModifierModule"; description= ""; displayName= ""; effectCategory= 4; preExpression= 16991; postExpression= 16992 } |> Some
      | 549 -> { DogmaEffectData.id= 549; name= "shipPTDmgBonusMB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2889; postExpression= 2890 } |> Some
      | 5496 -> { DogmaEffectData.id= 5496; name= "eliteBonusCommandShipHAMRoFCS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17249; postExpression= 17250 } |> Some
      | 5593 -> { DogmaEffectData.id= 5593; name= "shieldBoostAmplifierActive"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 3171; postExpression= 3172 } |> Some
      | 5787 -> { DogmaEffectData.id= 5787; name= "marauderHeavyMissileVelocityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17922; postExpression= 17923 } |> Some
      | 6078 -> { DogmaEffectData.id= 6078; name= "tacticalDestroyerCaldariSkillLevel1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18660; postExpression= 18661 } |> Some
      | 6175 -> { DogmaEffectData.id= 6175; name= "battlecruiserMissileRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18911; postExpression= 18912 } |> Some
      | 6272 -> { DogmaEffectData.id= 6272; name= "shipBonusEnergyNeutFalloffEAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19072; postExpression= 19073 } |> Some
      | 6369 -> { DogmaEffectData.id= 6369; name= "shipShieldTransferFalloffMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4622; postExpression= 4623 } |> Some
      | 6563 -> { DogmaEffectData.id= 6563; name= "skillBonusHeavyFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6660 -> { DogmaEffectData.id= 6660; name= "higgsWarpBubbleImmuneRemoval"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14369; postExpression= 14370 } |> Some
      | 6757 -> { DogmaEffectData.id= 6757; name= "behaviorECM"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6951 -> { DogmaEffectData.id= 6951; name= "subSystemBonusMinmatarDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14414; postExpression= 14415 } |> Some
      | _ -> None