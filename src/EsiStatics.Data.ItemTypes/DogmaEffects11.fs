namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects11=
    let getDogmaEffect id = 
      match id with 
      | 11 -> { DogmaEffectData.id= 11; name= "loPower"; description= "Requires a low power slot."; displayName= "Low power"; effectCategory= 0; preExpression= 131; postExpression= 131 } |> Some
      | 1660 -> { DogmaEffectData.id= 1660; name= "freighterA2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6572; postExpression= 6573 } |> Some
      | 205 -> { DogmaEffectData.id= 205; name= "signatureAnalysisScanspeedBonusPostPercentScanSpeedLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1407; postExpression= 1408 } |> Some
      | 2727 -> { DogmaEffectData.id= 2727; name= "gasCloudHarvestingMaxGroupSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9795; postExpression= 9796 } |> Some
      | 302 -> { DogmaEffectData.id= 302; name= "empathyCharismaBonusModAddCharismaLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1826; postExpression= 1827 } |> Some
      | 3212 -> { DogmaEffectData.id= 3212; name= "missileSkillFoFAoeCloudSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11212; postExpression= 11213 } |> Some
      | 3406 -> { DogmaEffectData.id= 3406; name= "eliteBonusBlackOpsMaxVelocity1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11763; postExpression= 11764 } |> Some
      | 3600 -> { DogmaEffectData.id= 3600; name= "scriptTrackingComputerMaxRangeBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12344; postExpression= 12345 } |> Some
      | 3794 -> { DogmaEffectData.id= 3794; name= "dungeonMaxVelocityModifier"; description= ""; displayName= ""; effectCategory= 6; preExpression= 2308; postExpression= 2309 } |> Some
      | 399 -> { DogmaEffectData.id= 399; name= "connectionsConnectionBonusMutatorModAddConnectionsBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2269; postExpression= 2270 } |> Some
      | 4376 -> { DogmaEffectData.id= 4376; name= "subSystemBonusMinmatarDefensiveSkirmishWarfare"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14383; postExpression= 14384 } |> Some
      | 4473 -> { DogmaEffectData.id= 4473; name= "shipVelocityBonusATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14669; postExpression= 14670 } |> Some
      | 4667 -> { DogmaEffectData.id= 4667; name= "shipBonusNoctisSalvageCycle"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15205; postExpression= 15206 } |> Some
      | 5055 -> { DogmaEffectData.id= 5055; name= "iceHarvesterDurationMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16215; postExpression= 16216 } |> Some
      | 5540 -> { DogmaEffectData.id= 5540; name= "shipBonusHMLEMDamageAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17354; postExpression= 17355 } |> Some
      | 5637 -> { DogmaEffectData.id= 5637; name= "shipBonusHeavyMissileThermDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17574; postExpression= 17575 } |> Some
      | 5734 -> { DogmaEffectData.id= 5734; name= "eliteBonusMaraudersHeavyMissileDamageKinRole1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17770; postExpression= 17771 } |> Some
      | 5928 -> { DogmaEffectData.id= 5928; name= "warpScrambleTargetMWDBlockActivationForEntity"; description= ""; displayName= "Warp Scramble"; effectCategory= 2; preExpression= 12707; postExpression= 12708 } |> Some
      | 6025 -> { DogmaEffectData.id= 6025; name= "eliteReconBonusMHTOptimalRange1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18539; postExpression= 18540 } |> Some
      | 6316 -> { DogmaEffectData.id= 6316; name= "eliteBonusCommandDestroyerShield1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19164; postExpression= 19165 } |> Some
      | 6413 -> { DogmaEffectData.id= 6413; name= "structureRigPDBCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6510 -> { DogmaEffectData.id= 6510; name= "shipBonusDreadnoughtM2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6607 -> { DogmaEffectData.id= 6607; name= "shipBonusSupercarrierA5WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6704 -> { DogmaEffectData.id= 6704; name= "rigDrawbackReductionLauncher"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19285; postExpression= 19286 } |> Some
      | 6801 -> { DogmaEffectData.id= 6801; name= "modeMWDandABBoostPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18857; postExpression= 18858 } |> Some
      | 6898 -> { DogmaEffectData.id= 6898; name= "subsystemMRARFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19331; postExpression= 19332 } |> Some
      | 6995 -> { DogmaEffectData.id= 6995; name= "targetDisintegratorAttack"; description= "Atomic Beam Cannon main effect"; displayName= ""; effectCategory= 2; preExpression= 115; postExpression= 89 } |> Some
      | 7092 -> { DogmaEffectData.id= 7092; name= "shipBonusRemoteRepCapNeedRoleBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19529; postExpression= 19530 } |> Some
      | _ -> None