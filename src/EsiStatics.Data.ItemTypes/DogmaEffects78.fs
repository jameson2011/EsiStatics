namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects78=
    let getDogmaEffect id = 
      match id with 
      | 1048 -> { DogmaEffectData.id= 1048; name= "shipShieldTransferRangeCC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1921 -> { DogmaEffectData.id= 1921; name= "eliteReconStasisWebBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2018 -> { DogmaEffectData.id= 2018; name= "damageRepairedSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2503 -> { DogmaEffectData.id= 2503; name= "shipHTTrackingBonusGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2697 -> { DogmaEffectData.id= 2697; name= "maxRangeBonusEffectHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 272 -> { DogmaEffectData.id= 272; name= "repairSystemsDurationBonusPostPercentDurationLocationShipModulesRequiringRepairSystems"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2794 -> { DogmaEffectData.id= 2794; name= "salvagingAccessDifficultyBonusEffectPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2891 -> { DogmaEffectData.id= 2891; name= "missileEMDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3182 -> { DogmaEffectData.id= 3182; name= "overloadSelfECMStrenghtBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3473 -> { DogmaEffectData.id= 3473; name= "eliteBonusViolatorsTractorBeamMaxTractorVelocityRole3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3570 -> { DogmaEffectData.id= 3570; name= "eliteBonusLogisticsTrackingLinkTrackingSpeedBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3861 -> { DogmaEffectData.id= 3861; name= "subsystemBonusMinmatarPropulsionAfterburnerSpeedFactor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4055 -> { DogmaEffectData.id= 4055; name= "systemSmallProjectileDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4152 -> { DogmaEffectData.id= 4152; name= "subsystemBonusAmarrEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4637 -> { DogmaEffectData.id= 4637; name= "shipCruiseAndTorpedoVelocityBonusCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4928 -> { DogmaEffectData.id= 4928; name= "adaptiveArmorHardener"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5122 -> { DogmaEffectData.id= 5122; name= "shipBonusShieldTransferCapneedMC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5219 -> { DogmaEffectData.id= 5219; name= "shipSPTOptimalRangeBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5316 -> { DogmaEffectData.id= 5316; name= "shipBonusDroneHitpointsGD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5607 -> { DogmaEffectData.id= 5607; name= "capacitorEmissionSystemskill"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 563 -> { DogmaEffectData.id= 563; name= "warpScrambleForEntity"; description= "Attempts to prevent the target from warping."; displayName= "Warp Scramble"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5995 -> { DogmaEffectData.id= 5995; name= "resistanceKillerShieldArmorAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6480 -> { DogmaEffectData.id= 6480; name= "doomsdayAOEGuide"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6577 -> { DogmaEffectData.id= 6577; name= "skillBonusXLCruiseMissileSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 660 -> { DogmaEffectData.id= 660; name= "missileEMDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6674 -> { DogmaEffectData.id= 6674; name= "structureRigAsteroidOreYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6771 -> { DogmaEffectData.id= 6771; name= "shieldCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6868 -> { DogmaEffectData.id= 6868; name= "roleBonusConcordSecGain"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6965 -> { DogmaEffectData.id= 6965; name= "surveyProbeExplosionDelayOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 7062 -> { DogmaEffectData.id= 7062; name= "weather_infernal"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7159 -> { DogmaEffectData.id= 7159; name= "shipArmorThermalResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 757 -> { DogmaEffectData.id= 757; name= "shipETDamageAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8032 -> { DogmaEffectData.id= 8032; name= "systemWarpScrambleStrengthBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 854 -> { DogmaEffectData.id= 854; name= "cloakingScanResolutionMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None