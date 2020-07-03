namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects17=
    let getDogmaEffect id = 
      match id with 
      | 1084 -> { DogmaEffectData.id= 1084; name= "eliteBonusHeavyGunshipDroneControlRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 114 -> { DogmaEffectData.id= 114; name= "characterMemorySkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1181 -> { DogmaEffectData.id= 1181; name= "eliteBonusLogisticEnergyTransferCapNeed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1472 -> { DogmaEffectData.id= 1472; name= "missileSkillAoeCloudSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1666 -> { DogmaEffectData.id= 1666; name= "freighterM1SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 17 -> { DogmaEffectData.id= 17; name= "mining"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 1763 -> { DogmaEffectData.id= 1763; name= "missileSkillRapidLauncherRoF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2054 -> { DogmaEffectData.id= 2054; name= "explosiveShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 211 -> { DogmaEffectData.id= 211; name= "sensorUpgradesSkillBoostCpuNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3024 -> { DogmaEffectData.id= 3024; name= "eliteBonusCoverOpsBombExplosiveDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 308 -> { DogmaEffectData.id= 308; name= "ironWillWillpowerBonusModAddWillpowerLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3703 -> { DogmaEffectData.id= 3703; name= "shipMissileLauncherSpeedBonusMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3897 -> { DogmaEffectData.id= 3897; name= "subsystemBonusCaldariCoreScanStrengthGravimetric"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4091 -> { DogmaEffectData.id= 4091; name= "systemCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4188 -> { DogmaEffectData.id= 4188; name= "shipBonusStrategicCruiserCaldariHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4479 -> { DogmaEffectData.id= 4479; name= "shipBonusSurveyProbeExplosionDelaySkillSurveyCovertOps3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4576 -> { DogmaEffectData.id= 4576; name= "eliteBonusLogisticsTrackingLinkFalloffBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4770 -> { DogmaEffectData.id= 4770; name= "anchorLiftOrbital"; description= ""; displayName= "unanchoring"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4867 -> { DogmaEffectData.id= 4867; name= "setBonusChristmasPowergrid"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5352 -> { DogmaEffectData.id= 5352; name= "shipBonusProjectileDamageMBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5934 -> { DogmaEffectData.id= 5934; name= "warpScrambleBlockMWDWithNPCEffect"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 599 -> { DogmaEffectData.id= 599; name= "ammoFallofMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6128 -> { DogmaEffectData.id= 6128; name= "scriptMissileGuidanceComputerAOECloudSizeBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6225 -> { DogmaEffectData.id= 6225; name= "structureTargetGunneryMaxRangeFalloffTrackingSpeedBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6322 -> { DogmaEffectData.id= 6322; name= "scriptscanGravimetricStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6613 -> { DogmaEffectData.id= 6613; name= "shipBonusSupercarrierRole1NumWarfareLinks"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6710 -> { DogmaEffectData.id= 6710; name= "shipBonusDreadnoughtM1WebStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6807 -> { DogmaEffectData.id= 6807; name= "invulnerabilityCoreDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6904 -> { DogmaEffectData.id= 6904; name= "strategicCruiserMinmatarSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7001 -> { DogmaEffectData.id= 7001; name= "roleBonusTorpRoF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7098 -> { DogmaEffectData.id= 7098; name= "structureConversionRigBasicBonuses"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 793 -> { DogmaEffectData.id= 793; name= "escortHullUpgradeCpu Bonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 987 -> { DogmaEffectData.id= 987; name= "gunshipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None