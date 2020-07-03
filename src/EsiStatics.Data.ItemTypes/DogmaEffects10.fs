namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects10=
    let getDogmaEffect id = 
      match id with 
      | 10 -> { DogmaEffectData.id= 10; name= "targetAttack"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 107 -> { DogmaEffectData.id= 107; name= "characterMissileDamageMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1077 -> { DogmaEffectData.id= 1077; name= "warshipSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1659 -> { DogmaEffectData.id= 1659; name= "freighterA1SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 204 -> { DogmaEffectData.id= 204; name= "signatureAnalysisSkillBoostScanspeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2726 -> { DogmaEffectData.id= 2726; name= "miningClouds"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3308 -> { DogmaEffectData.id= 3308; name= "oreCapitalShipShieldTransferRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3405 -> { DogmaEffectData.id= 3405; name= "blackOpsSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3599 -> { DogmaEffectData.id= 3599; name= "scriptTrackingComputerTrackingSpeedBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3793 -> { DogmaEffectData.id= 3793; name= "probeLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4278 -> { DogmaEffectData.id= 4278; name= "subsystemBonusGallentePropulsion2WarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4375 -> { DogmaEffectData.id= 4375; name= "subSystemBonusGallenteDefensiveInformationWarfare"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4472 -> { DogmaEffectData.id= 4472; name= "shipProjectileDmgMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4666 -> { DogmaEffectData.id= 4666; name= "oreIndustrialSkillLevelPostMulShipBonusOreIndustrial2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5539 -> { DogmaEffectData.id= 5539; name= "shipBonusHMLKineticDamageAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5636 -> { DogmaEffectData.id= 5636; name= "shipBonusHeavyMissileEMDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5733 -> { DogmaEffectData.id= 5733; name= "eliteBonusMaraudersHeavyMissileDamageExpRole1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 592 -> { DogmaEffectData.id= 592; name= "targetArmorRepair"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5927 -> { DogmaEffectData.id= 5927; name= "systemRadarECMBomb"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6315 -> { DogmaEffectData.id= 6315; name= "eliteBonusCommandDestroyerSkirmish1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6412 -> { DogmaEffectData.id= 6412; name= "structureRigPDBmaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6509 -> { DogmaEffectData.id= 6509; name= "shipBonusDreadnoughtM1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6606 -> { DogmaEffectData.id= 6606; name= "shipBonusSupercarrierM1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6703 -> { DogmaEffectData.id= 6703; name= "rigDrawbackReductionHybrid"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6800 -> { DogmaEffectData.id= 6800; name= "modeDampTDResistsPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6897 -> { DogmaEffectData.id= 6897; name= "subsystemMPTFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6994 -> { DogmaEffectData.id= 6994; name= "eliteReconBonusMHTDamage1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7091 -> { DogmaEffectData.id= 7091; name= "shipBonusNosNeutCapNeedRoleBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7188 -> { DogmaEffectData.id= 7188; name= "npcBehaviorSmartBomb"; description= ""; displayName= ""; effectCategory= 3; preExpression= 0; postExpression= 0 } |> Some
      | 980 -> { DogmaEffectData.id= 980; name= "cloakingWarpSafe"; description= ""; displayName= "Cloaking"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None