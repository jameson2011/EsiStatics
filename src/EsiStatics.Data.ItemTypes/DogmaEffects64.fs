namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects64=
    let getDogmaEffect id = 
      match id with 
      | 1034 -> { DogmaEffectData.id= 1034; name= "eliteBonusLogisticRemoteArmorRepairCapNeed2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1131 -> { DogmaEffectData.id= 1131; name= "controlTowerSiloCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1228 -> { DogmaEffectData.id= 1228; name= "shipProjectileTrackingGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 161 -> { DogmaEffectData.id= 161; name= "mediumProjectileTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringMediumProjectileTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1616 -> { DogmaEffectData.id= 1616; name= "skillCapitalShipsAdvancedAgility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2489 -> { DogmaEffectData.id= 2489; name= "shipBonusRemoteTrackingComputerFalloffMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2974 -> { DogmaEffectData.id= 2974; name= "skillRemoteECMDurationBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3653 -> { DogmaEffectData.id= 3653; name= "ewGroupEcmBurstMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3847 -> { DogmaEffectData.id= 3847; name= "subsystemSkillLevelAmarrOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4041 -> { DogmaEffectData.id= 4041; name= "systemOverloadRof"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4138 -> { DogmaEffectData.id= 4138; name= "systemShieldThermalResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4332 -> { DogmaEffectData.id= 4332; name= "subsystemBonusCaldariOffensive3HeavyMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4623 -> { DogmaEffectData.id= 4623; name= "shipBonusSmallHybridTrackingSpeedATF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4817 -> { DogmaEffectData.id= 4817; name= "salvagerModuleDurationReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5011 -> { DogmaEffectData.id= 5011; name= "shipShieldKineticResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5108 -> { DogmaEffectData.id= 5108; name= "shipBonusRemoteArmorRepairAmountGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5205 -> { DogmaEffectData.id= 5205; name= "shipSETTrackingBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5399 -> { DogmaEffectData.id= 5399; name= "baseSensorStrengthModifierModule"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 549 -> { DogmaEffectData.id= 549; name= "shipPTDmgBonusMB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5496 -> { DogmaEffectData.id= 5496; name= "eliteBonusCommandShipHAMRoFCS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6078 -> { DogmaEffectData.id= 6078; name= "tacticalDestroyerCaldariSkillLevel1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6175 -> { DogmaEffectData.id= 6175; name= "battlecruiserMissileRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6272 -> { DogmaEffectData.id= 6272; name= "shipBonusEnergyNeutFalloffEAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6369 -> { DogmaEffectData.id= 6369; name= "shipShieldTransferFalloffMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6563 -> { DogmaEffectData.id= 6563; name= "skillBonusHeavyFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6660 -> { DogmaEffectData.id= 6660; name= "higgsWarpBubbleImmuneRemoval"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6757 -> { DogmaEffectData.id= 6757; name= "behaviorECM"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6951 -> { DogmaEffectData.id= 6951; name= "subSystemBonusMinmatarDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7242 -> { DogmaEffectData.id= 7242; name= "capitalPrecursorTurretDmgBonusRequiredSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8018 -> { DogmaEffectData.id= 8018; name= "subcapRemoteArmorShieldRepDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None