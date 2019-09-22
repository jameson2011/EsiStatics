namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects2=
    let getDogmaEffect id = 
      match id with 
      | 1360 -> { DogmaEffectData.id= 1360; name= "ewSkillRsdCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5649; postExpression= 5650 } |> Some
      | 1651 -> { DogmaEffectData.id= 1651; name= "skillCynosural&SiegeConsumQuantityBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6557; postExpression= 6558 } |> Some
      | 2427 -> { DogmaEffectData.id= 2427; name= "skillInterdictorEliteBonus2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8939; postExpression= 8940 } |> Some
      | 2718 -> { DogmaEffectData.id= 2718; name= "drawbackShieldCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9761; postExpression= 9762 } |> Some
      | 3494 -> { DogmaEffectData.id= 3494; name= "rorqualSurveyScannerRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11401; postExpression= 11402 } |> Some
      | 3591 -> { DogmaEffectData.id= 3591; name= "ewSkillSignalSuppressionMaxTargetRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12305; postExpression= 12306 } |> Some
      | 3979 -> { DogmaEffectData.id= 3979; name= "subsystemBonusMinmatarDefensiveShieldArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13323; postExpression= 13324 } |> Some
      | 4270 -> { DogmaEffectData.id= 4270; name= "subsystemBonusMinmatarCore3ScanResolution"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14141; postExpression= 14142 } |> Some
      | 4464 -> { DogmaEffectData.id= 4464; name= "shipProjectileRofMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14646; postExpression= 14647 } |> Some
      | 4852 -> { DogmaEffectData.id= 4852; name= "battlecruiserSkillLevelPreMulShipBonusBC4Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15671; postExpression= 15672 } |> Some
      | 5240 -> { DogmaEffectData.id= 5240; name= "shipSmallMissileThermDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16635; postExpression= 16636 } |> Some
      | 5337 -> { DogmaEffectData.id= 5337; name= "shipShieldKineticResistance1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16875; postExpression= 16876 } |> Some
      | 5628 -> { DogmaEffectData.id= 5628; name= "shipBonusCruiseMissileEMDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17556; postExpression= 17557 } |> Some
      | 5725 -> { DogmaEffectData.id= 5725; name= "shipBonusRemoteRepairAmountPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17750; postExpression= 17751 } |> Some
      | 5822 -> { DogmaEffectData.id= 5822; name= "shipBonusMediumDroneHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18017; postExpression= 18018 } |> Some
      | 584 -> { DogmaEffectData.id= 584; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3015; postExpression= 3016 } |> Some
      | 5919 -> { DogmaEffectData.id= 5919; name= "systemDamageEMBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18269; postExpression= 18270 } |> Some
      | 6016 -> { DogmaEffectData.id= 6016; name= "modeAgilityPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2250; postExpression= 2251 } |> Some
      | 6113 -> { DogmaEffectData.id= 6113; name= "missileAOEVelocityBonusOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 18742; postExpression= 18743 } |> Some
      | 6210 -> { DogmaEffectData.id= 6210; name= "commandDestroyerSkillMultiplier2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18941; postExpression= 18942 } |> Some
      | 6307 -> { DogmaEffectData.id= 6307; name= "shipBonusThermMissileDmgMD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19146; postExpression= 19147 } |> Some
      | 6404 -> { DogmaEffectData.id= 6404; name= "structureRigNeutralizerMaxRangeFalloffEffectiveness"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6501 -> { DogmaEffectData.id= 6501; name= "shipBonusDreadnoughtA1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6598 -> { DogmaEffectData.id= 6598; name= "shipBonusCarrierM4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6695 -> { DogmaEffectData.id= 6695; name= "entityECMFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6792 -> { DogmaEffectData.id= 6792; name= "shipBonusDroneHPDamageMiningORECapital4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6889 -> { DogmaEffectData.id= 6889; name= "rigAdvCapComponentManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced capital components"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6986 -> { DogmaEffectData.id= 6986; name= "shipBonusForceAuxiliaryG1RemoteShieldBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7180 -> { DogmaEffectData.id= 7180; name= "miningDurationMultiplierOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 19741; postExpression= 19742 } |> Some
      | _ -> None