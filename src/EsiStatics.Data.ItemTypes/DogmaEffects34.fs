namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects34=
    let getDogmaEffect id = 
      match id with 
      | 1004 -> { DogmaEffectData.id= 1004; name= "selfT2SmallLaserBeamDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4440; postExpression= 4441 } |> Some
      | 1198 -> { DogmaEffectData.id= 1198; name= "shipHybridFallOffGD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5185; postExpression= 5186 } |> Some
      | 131 -> { DogmaEffectData.id= 131; name= "cheatTeleGate"; description= ""; displayName= ""; effectCategory= 2; preExpression= 1019; postExpression= 131 } |> Some
      | 1586 -> { DogmaEffectData.id= 1586; name= "capitalTurretSkillProjectileDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6344; postExpression= 6345 } |> Some
      | 2071 -> { DogmaEffectData.id= 2071; name= "empWaveGrid"; description= ""; displayName= ""; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 2168 -> { DogmaEffectData.id= 2168; name= "eliteBonusCommandShipInfoCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8113; postExpression= 8114 } |> Some
      | 228 -> { DogmaEffectData.id= 228; name= "accerationControlSkillBoostSpeedFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1521; postExpression= 1522 } |> Some
      | 2653 -> { DogmaEffectData.id= 2653; name= "missileProjectionComputerBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 9580; postExpression= 9581 } |> Some
      | 2750 -> { DogmaEffectData.id= 2750; name= "shipBonusECMGravimetricStrengthBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9855; postExpression= 9856 } |> Some
      | 2847 -> { DogmaEffectData.id= 2847; name= "trackingSpeedBonusPassiveRequiringGunneryTrackingSpeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6248; postExpression= 6249 } |> Some
      | 3041 -> { DogmaEffectData.id= 3041; name= "remoteHullRepair"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 3138 -> { DogmaEffectData.id= 3138; name= "controlTowerGenericHullResistanceBonusCynoJammer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10995; postExpression= 10996 } |> Some
      | 3235 -> { DogmaEffectData.id= 3235; name= "shipRocketKineticDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11252; postExpression= 11253 } |> Some
      | 325 -> { DogmaEffectData.id= 325; name= "minmatarTechSkillBoostMinmatarTechMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1930; postExpression= 1931 } |> Some
      | 3332 -> { DogmaEffectData.id= 3332; name= "leechNpc"; description= ""; displayName= ""; effectCategory= 2; preExpression= 8497; postExpression= 8496 } |> Some
      | 34 -> { DogmaEffectData.id= 34; name= "projectileFired"; description= ""; displayName= ""; effectCategory= 2; preExpression= 115; postExpression= 131 } |> Some
      | 3429 -> { DogmaEffectData.id= 3429; name= "eliteBonusViolatorsCruiseMissileEMDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11840; postExpression= 11841 } |> Some
      | 3526 -> { DogmaEffectData.id= 3526; name= "cynosuralTheoryConsumptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12122; postExpression= 12123 } |> Some
      | 4108 -> { DogmaEffectData.id= 4108; name= "subsystemBonusGallenteOffensiveHybridWeaponROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13720; postExpression= 13721 } |> Some
      | 4205 -> { DogmaEffectData.id= 4205; name= "subsystemSkillLevelGallenteEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13972; postExpression= 13973 } |> Some
      | 4399 -> { DogmaEffectData.id= 4399; name= "shipBonusCF1TorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14434; postExpression= 14435 } |> Some
      | 4787 -> { DogmaEffectData.id= 4787; name= "shipEnergyNeutralizerRangeBonusATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15446; postExpression= 15447 } |> Some
      | 4981 -> { DogmaEffectData.id= 4981; name= "unusedEntityTrackingDisrupt5"; description= ""; displayName= ""; effectCategory= 2; preExpression= 16026; postExpression= 16027 } |> Some
      | 5078 -> { DogmaEffectData.id= 5078; name= "shipBonusTDOptimalBonusAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16277; postExpression= 16278 } |> Some
      | 5369 -> { DogmaEffectData.id= 5369; name= "shipEnergyVampireRangeBonusFixedAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16938; postExpression= 16939 } |> Some
      | 5563 -> { DogmaEffectData.id= 5563; name= "subSystemBonusAmarrDefensiveSkirmishWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17409; postExpression= 17410 } |> Some
      | 5757 -> { DogmaEffectData.id= 5757; name= "overloadSelfSensorModuleBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 17835; postExpression= 17836 } |> Some
      | 5854 -> { DogmaEffectData.id= 5854; name= "shipBonusNosferatuOverride"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18100; postExpression= 18101 } |> Some
      | 5951 -> { DogmaEffectData.id= 5951; name= "drawbackWarpSpeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18363; postExpression= 18364 } |> Some
      | 6048 -> { DogmaEffectData.id= 6048; name= "shipBonusSentryShieldHPGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18599; postExpression= 18600 } |> Some
      | 6145 -> { DogmaEffectData.id= 6145; name= "tacticalDestroyerGallenteSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18833; postExpression= 18834 } |> Some
      | 616 -> { DogmaEffectData.id= 616; name= "targetedThermalResonanceMultiply"; description= "Automatically generated effect"; displayName= "TargetedThermalResonanceMultiply"; effectCategory= 2; preExpression= 3127; postExpression= 3128 } |> Some
      | 6242 -> { DogmaEffectData.id= 6242; name= "shipBonusEnergyNeutOptimalAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18999; postExpression= 19000 } |> Some
      | 6339 -> { DogmaEffectData.id= 6339; name= "eliteBonusCommandDestroyerArmored1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19202; postExpression= 19203 } |> Some
      | 6436 -> { DogmaEffectData.id= 6436; name= "fighterAbilityWarpDisruption"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6533 -> { DogmaEffectData.id= 6533; name= "shipBonusForceAuxiliaryA4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6630 -> { DogmaEffectData.id= 6630; name= "skillMultiplierShipBonusTitanAmarr"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6727 -> { DogmaEffectData.id= 6727; name= "eliteBonusCoverOpsNOSNeutFalloff1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19305; postExpression= 19306 } |> Some
      | 6824 -> { DogmaEffectData.id= 6824; name= "rigAdvComponentManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced components"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6921 -> { DogmaEffectData.id= 6921; name= "subSystemBonusAmarrDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14414; postExpression= 14415 } |> Some
      | 7018 -> { DogmaEffectData.id= 7018; name= "shipSETROFAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3626; postExpression= 3627 } |> Some
      | 7115 -> { DogmaEffectData.id= 7115; name= "eliteBonusReconMaxDmgMultiMaxHPT"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19556; postExpression= 19557 } |> Some
      | 713 -> { DogmaEffectData.id= 713; name= "stealthActive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 3520; postExpression= 3521 } |> Some
      | 907 -> { DogmaEffectData.id= 907; name= "shipLaserRofAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4152; postExpression= 4153 } |> Some
      | _ -> None