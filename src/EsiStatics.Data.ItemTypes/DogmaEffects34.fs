namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects34=
    let getDogmaEffect id = 
      match id with 
      | 1004 -> { DogmaEffectData.id= 1004; name= "selfT2SmallLaserBeamDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1586 -> { DogmaEffectData.id= 1586; name= "capitalTurretSkillProjectileDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 228 -> { DogmaEffectData.id= 228; name= "accerationControlSkillBoostSpeedFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2847 -> { DogmaEffectData.id= 2847; name= "trackingSpeedBonusPassiveRequiringGunneryTrackingSpeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3235 -> { DogmaEffectData.id= 3235; name= "shipRocketKineticDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 34 -> { DogmaEffectData.id= 34; name= "projectileFired"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3526 -> { DogmaEffectData.id= 3526; name= "cynosuralTheoryConsumptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4205 -> { DogmaEffectData.id= 4205; name= "subsystemSkillLevelGallenteEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4399 -> { DogmaEffectData.id= 4399; name= "shipBonusCF1TorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5563 -> { DogmaEffectData.id= 5563; name= "subSystemBonusAmarrDefensiveSkirmishWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5757 -> { DogmaEffectData.id= 5757; name= "overloadSelfSensorModuleBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 5854 -> { DogmaEffectData.id= 5854; name= "shipBonusNosferatuOverride"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5951 -> { DogmaEffectData.id= 5951; name= "drawbackWarpSpeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6048 -> { DogmaEffectData.id= 6048; name= "shipBonusSentryShieldHPGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6145 -> { DogmaEffectData.id= 6145; name= "tacticalDestroyerGallenteSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6242 -> { DogmaEffectData.id= 6242; name= "shipBonusEnergyNeutOptimalAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6339 -> { DogmaEffectData.id= 6339; name= "eliteBonusCommandDestroyerArmored1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6436 -> { DogmaEffectData.id= 6436; name= "fighterAbilityWarpDisruption"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6533 -> { DogmaEffectData.id= 6533; name= "shipBonusForceAuxiliaryA4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6630 -> { DogmaEffectData.id= 6630; name= "skillMultiplierShipBonusTitanAmarr"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6727 -> { DogmaEffectData.id= 6727; name= "eliteBonusCoverOpsNOSNeutFalloff1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6824 -> { DogmaEffectData.id= 6824; name= "rigAdvComponentManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced components"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6921 -> { DogmaEffectData.id= 6921; name= "subSystemBonusAmarrDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7018 -> { DogmaEffectData.id= 7018; name= "shipSETROFAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 713 -> { DogmaEffectData.id= 713; name= "stealthActive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 907 -> { DogmaEffectData.id= 907; name= "shipLaserRofAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None