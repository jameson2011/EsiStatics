namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects78=
    let getDogmaEffect id = 
      match id with 
      | 1048 -> { DogmaEffectData.id= 1048; name= "shipShieldTransferRangeCC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4620; postExpression= 4621 } |> Some
      | 1921 -> { DogmaEffectData.id= 1921; name= "eliteReconStasisWebBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7361; postExpression= 7362 } |> Some
      | 2018 -> { DogmaEffectData.id= 2018; name= "damageRepairedSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7658; postExpression= 7659 } |> Some
      | 2503 -> { DogmaEffectData.id= 2503; name= "shipHTTrackingBonusGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9143; postExpression= 9144 } |> Some
      | 2697 -> { DogmaEffectData.id= 2697; name= "maxRangeBonusEffectHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9705; postExpression= 9706 } |> Some
      | 272 -> { DogmaEffectData.id= 272; name= "repairSystemsDurationBonusPostPercentDurationLocationShipModulesRequiringRepairSystems"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1697; postExpression= 1698 } |> Some
      | 2794 -> { DogmaEffectData.id= 2794; name= "salvagingAccessDifficultyBonusEffectPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9722; postExpression= 9723 } |> Some
      | 2891 -> { DogmaEffectData.id= 2891; name= "missileEMDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10223; postExpression= 10224 } |> Some
      | 3182 -> { DogmaEffectData.id= 3182; name= "overloadSelfECMStrenghtBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 11120; postExpression= 11121 } |> Some
      | 3473 -> { DogmaEffectData.id= 3473; name= "eliteBonusViolatorsTractorBeamMaxTractorVelocityRole3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11960; postExpression= 11961 } |> Some
      | 3570 -> { DogmaEffectData.id= 3570; name= "eliteBonusLogisticsTrackingLinkTrackingSpeedBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12272; postExpression= 12273 } |> Some
      | 3861 -> { DogmaEffectData.id= 3861; name= "subsystemBonusMinmatarPropulsionAfterburnerSpeedFactor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13087; postExpression= 13088 } |> Some
      | 4055 -> { DogmaEffectData.id= 4055; name= "systemSmallProjectileDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13571; postExpression= 13572 } |> Some
      | 4152 -> { DogmaEffectData.id= 4152; name= "subsystemBonusAmarrEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13812; postExpression= 13813 } |> Some
      | 4637 -> { DogmaEffectData.id= 4637; name= "shipCruiseAndTorpedoVelocityBonusCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15135; postExpression= 15136 } |> Some
      | 4928 -> { DogmaEffectData.id= 4928; name= "adaptiveArmorHardener"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 5122 -> { DogmaEffectData.id= 5122; name= "shipBonusShieldTransferCapneedMC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16370; postExpression= 16371 } |> Some
      | 5219 -> { DogmaEffectData.id= 5219; name= "shipSPTOptimalRangeBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16597; postExpression= 16598 } |> Some
      | 5316 -> { DogmaEffectData.id= 5316; name= "shipBonusDroneHitpointsGD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16833; postExpression= 16834 } |> Some
      | 5607 -> { DogmaEffectData.id= 5607; name= "capacitorEmissionSystemskill"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17504; postExpression= 17505 } |> Some
      | 563 -> { DogmaEffectData.id= 563; name= "warpScrambleForEntity"; description= "Attempts to prevent the target from warping."; displayName= "Warp Scramble"; effectCategory= 2; preExpression= 294; postExpression= 295 } |> Some
      | 5995 -> { DogmaEffectData.id= 5995; name= "resistanceKillerShieldArmorAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18465; postExpression= 18466 } |> Some
      | 6480 -> { DogmaEffectData.id= 6480; name= "doomsdayAOEGuide"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6577 -> { DogmaEffectData.id= 6577; name= "skillBonusXLCruiseMissileSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 660 -> { DogmaEffectData.id= 660; name= "missileEMDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3300; postExpression= 3301 } |> Some
      | 6674 -> { DogmaEffectData.id= 6674; name= "structureRigAsteroidOreYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6771 -> { DogmaEffectData.id= 6771; name= "shieldCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6868 -> { DogmaEffectData.id= 6868; name= "roleBonusConcordSecGain"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2074; postExpression= 2075 } |> Some
      | 6965 -> { DogmaEffectData.id= 6965; name= "surveyProbeExplosionDelayOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 19351; postExpression= 19352 } |> Some
      | 7062 -> { DogmaEffectData.id= 7062; name= "weather_infernal"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7159 -> { DogmaEffectData.id= 7159; name= "shipArmorThermalResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19689; postExpression= 19690 } |> Some
      | 757 -> { DogmaEffectData.id= 757; name= "shipETDamageAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3628; postExpression= 3629 } |> Some
      | 854 -> { DogmaEffectData.id= 854; name= "cloakingScanResolutionMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3935; postExpression= 3408 } |> Some
      | _ -> None