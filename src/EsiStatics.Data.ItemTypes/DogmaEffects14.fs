namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects14=
    let getDogmaEffect id = 
      match id with 
      | 1081 -> { DogmaEffectData.id= 1081; name= "eliteBonusHeavyGunshipHeavyMissileFlightTime1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4734; postExpression= 4735 } |> Some
      | 111 -> { DogmaEffectData.id= 111; name= "characterBlueprintManufactureTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 756; postExpression= 757 } |> Some
      | 1275 -> { DogmaEffectData.id= 1275; name= "newEwTestsdecreaseTargetSpeed"; description= ""; displayName= "newEwTestsDecrease Target Speed"; effectCategory= 2; preExpression= 3489; postExpression= 3491 } |> Some
      | 1372 -> { DogmaEffectData.id= 1372; name= "ewSkillEwCapNeedSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5695; postExpression= 5696 } |> Some
      | 1663 -> { DogmaEffectData.id= 1663; name= "freighterC2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6601; postExpression= 6602 } |> Some
      | 1857 -> { DogmaEffectData.id= 1857; name= "shipBonusScanProbeDurationMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7152; postExpression= 7153 } |> Some
      | 208 -> { DogmaEffectData.id= 208; name= "propulsionJammingSkillBoostDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1423; postExpression= 1424 } |> Some
      | 2148 -> { DogmaEffectData.id= 2148; name= "droneDamageBonusRequringDrones"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7602; postExpression= 7603 } |> Some
      | 305 -> { DogmaEffectData.id= 305; name= "analyticalMindSkillBoostIntelligenceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1836; postExpression= 1837 } |> Some
      | 3118 -> { DogmaEffectData.id= 3118; name= "controlTowerGenericHullE&EResistanceBonusLaser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10957; postExpression= 10958 } |> Some
      | 3215 -> { DogmaEffectData.id= 3215; name= "shipHeavyAssaultMissileKineticDmgAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11218; postExpression= 11219 } |> Some
      | 3409 -> { DogmaEffectData.id= 3409; name= "violatorsSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11784; postExpression= 11785 } |> Some
      | 3603 -> { DogmaEffectData.id= 3603; name= "eliteBonusHeavyInterdictorsWarpDisruptFieldGeneratorWarpScrambleRangeScript2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12360; postExpression= 12361 } |> Some
      | 3797 -> { DogmaEffectData.id= 3797; name= "droneBandwidthAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12880; postExpression= 12881 } |> Some
      | 3894 -> { DogmaEffectData.id= 3894; name= "subsystemBonusMinmatarElectronicScanStrengthMagnetometric"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13153; postExpression= 13154 } |> Some
      | 402 -> { DogmaEffectData.id= 402; name= "criminalConnectionsCriminalConnectionsMutatorModAddCriminalConnectionsBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2278; postExpression= 2279 } |> Some
      | 4088 -> { DogmaEffectData.id= 4088; name= "systemArmorRemoteRepairAmount"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13669; postExpression= 13670 } |> Some
      | 4185 -> { DogmaEffectData.id= 4185; name= "subsystemBonusAmarrOffensiveEnergyWeaponCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13887; postExpression= 13888 } |> Some
      | 4282 -> { DogmaEffectData.id= 4282; name= "subsystemBonusGallenteOffensive2HybridWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14164; postExpression= 14165 } |> Some
      | 4379 -> { DogmaEffectData.id= 4379; name= "shipBonusTorpedoVelocity2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14389; postExpression= 14390 } |> Some
      | 4476 -> { DogmaEffectData.id= 4476; name= "shipMTFalloffBonusATF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14677; postExpression= 14678 } |> Some
      | 4670 -> { DogmaEffectData.id= 4670; name= "shipBonusNoctisTractorRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15211; postExpression= 15212 } |> Some
      | 4767 -> { DogmaEffectData.id= 4767; name= "eliteBonusBlackOpsECMGravAndLadarAndMagnetometricAndRadarStrength4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15411; postExpression= 15412 } |> Some
      | 4864 -> { DogmaEffectData.id= 4864; name= "skillBonusBoosterCapacitorCapacityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15712; postExpression= 15713 } |> Some
      | 4961 -> { DogmaEffectData.id= 4961; name= "systemShieldRepairAmountShieldSkills"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15980; postExpression= 15981 } |> Some
      | 5058 -> { DogmaEffectData.id= 5058; name= "miningYieldMultiplyPassive"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 7078; postExpression= 7079 } |> Some
      | 5155 -> { DogmaEffectData.id= 5155; name= "shipArmorRepairingGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16433; postExpression= 16434 } |> Some
      | 5349 -> { DogmaEffectData.id= 5349; name= "shipBonusHeavyMissileLauncherRofMBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16899; postExpression= 16900 } |> Some
      | 5737 -> { DogmaEffectData.id= 5737; name= "shipScanProbeStrengthBonusPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17776; postExpression= 17777 } |> Some
      | 5931 -> { DogmaEffectData.id= 5931; name= "entitySelfVelocityMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18306; postExpression= 18307 } |> Some
      | 596 -> { DogmaEffectData.id= 596; name= "ammoInfluenceRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3573; postExpression= 3574 } |> Some
      | 6028 -> { DogmaEffectData.id= 6028; name= "shipMissileBonusEMdmgMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18545; postExpression= 18546 } |> Some
      | 6222 -> { DogmaEffectData.id= 6222; name= "structureWarpScrambleBlockMWDWithNPCEffect"; description= ""; displayName= ""; effectCategory= 2; preExpression= 18316; postExpression= 18317 } |> Some
      | 6319 -> { DogmaEffectData.id= 6319; name= "shipBonusKineticShieldResistanceMD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19170; postExpression= 19171 } |> Some
      | 6416 -> { DogmaEffectData.id= 6416; name= "structureRigDoomsdayTargetRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6513 -> { DogmaEffectData.id= 6513; name= "doomsdayAOEECM"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6610 -> { DogmaEffectData.id= 6610; name= "shipBonusSupercarrierM5WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6707 -> { DogmaEffectData.id= 6707; name= "implantShieldCapacityBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2472; postExpression= 2473 } |> Some
      | 6901 -> { DogmaEffectData.id= 6901; name= "npcBehaviorMiningLaser"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6998 -> { DogmaEffectData.id= 6998; name= "covertOpsSkillLevelPreMulEliteBonusCoverOpsShip4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14689; postExpression= 14690 } |> Some
      | 887 -> { DogmaEffectData.id= 887; name= "shipETspeedBonusAB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4066; postExpression= 4067 } |> Some
      | _ -> None