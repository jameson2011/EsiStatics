namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects11=
    let getDogmaEffect id = 
      match id with 
      | 11 -> { DogmaEffectData.id= 11; name= "loPower"; description= "Requires a low power slot."; displayName= "Low power"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1660 -> { DogmaEffectData.id= 1660; name= "freighterA2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 205 -> { DogmaEffectData.id= 205; name= "signatureAnalysisScanspeedBonusPostPercentScanSpeedLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2727 -> { DogmaEffectData.id= 2727; name= "gasCloudHarvestingMaxGroupSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 302 -> { DogmaEffectData.id= 302; name= "empathyCharismaBonusModAddCharismaLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3212 -> { DogmaEffectData.id= 3212; name= "missileSkillFoFAoeCloudSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3406 -> { DogmaEffectData.id= 3406; name= "eliteBonusBlackOpsMaxVelocity1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3600 -> { DogmaEffectData.id= 3600; name= "scriptTrackingComputerMaxRangeBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3794 -> { DogmaEffectData.id= 3794; name= "dungeonMaxVelocityModifier"; description= ""; displayName= ""; effectCategory= 6; preExpression= 0; postExpression= 0 } |> Some
      | 399 -> { DogmaEffectData.id= 399; name= "connectionsConnectionBonusMutatorModAddConnectionsBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4376 -> { DogmaEffectData.id= 4376; name= "subSystemBonusMinmatarDefensiveSkirmishWarfare"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4473 -> { DogmaEffectData.id= 4473; name= "shipVelocityBonusATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4667 -> { DogmaEffectData.id= 4667; name= "shipBonusNoctisSalvageCycle"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5055 -> { DogmaEffectData.id= 5055; name= "iceHarvesterDurationMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5540 -> { DogmaEffectData.id= 5540; name= "shipBonusHMLEMDamageAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5637 -> { DogmaEffectData.id= 5637; name= "shipBonusHeavyMissileThermDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5734 -> { DogmaEffectData.id= 5734; name= "eliteBonusMaraudersHeavyMissileDamageKinRole1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5928 -> { DogmaEffectData.id= 5928; name= "warpScrambleTargetMWDBlockActivationForEntity"; description= ""; displayName= "Warp Scramble"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6025 -> { DogmaEffectData.id= 6025; name= "eliteReconBonusMHTOptimalRange1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6316 -> { DogmaEffectData.id= 6316; name= "eliteBonusCommandDestroyerShield1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6413 -> { DogmaEffectData.id= 6413; name= "structureRigPDBCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6510 -> { DogmaEffectData.id= 6510; name= "shipBonusDreadnoughtM2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6607 -> { DogmaEffectData.id= 6607; name= "shipBonusSupercarrierA5WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6704 -> { DogmaEffectData.id= 6704; name= "rigDrawbackReductionLauncher"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6801 -> { DogmaEffectData.id= 6801; name= "modeMWDandABBoostPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6898 -> { DogmaEffectData.id= 6898; name= "subsystemMRARFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6995 -> { DogmaEffectData.id= 6995; name= "targetDisintegratorAttack"; description= "Atomic Beam Cannon main effect"; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 7092 -> { DogmaEffectData.id= 7092; name= "shipBonusRemoteRepCapNeedRoleBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8062 -> { DogmaEffectData.id= 8062; name= "ammoAOEvelocityMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None