namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects17=
    let getDogmaEffect id = 
      match id with 
      | 1084 -> { DogmaEffectData.id= 1084; name= "eliteBonusHeavyGunshipDroneControlRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4740; postExpression= 4741 } |> Some
      | 114 -> { DogmaEffectData.id= 114; name= "characterMemorySkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 782; postExpression= 783 } |> Some
      | 1181 -> { DogmaEffectData.id= 1181; name= "eliteBonusLogisticEnergyTransferCapNeed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5133; postExpression= 5134 } |> Some
      | 1472 -> { DogmaEffectData.id= 1472; name= "missileSkillAoeCloudSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16049; postExpression= 16050 } |> Some
      | 1666 -> { DogmaEffectData.id= 1666; name= "freighterM1SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6613; postExpression= 6614 } |> Some
      | 17 -> { DogmaEffectData.id= 17; name= "mining"; description= ""; displayName= ""; effectCategory= 2; preExpression= 3134; postExpression= 184 } |> Some
      | 1763 -> { DogmaEffectData.id= 1763; name= "missileSkillRapidLauncherRoF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6859; postExpression= 6860 } |> Some
      | 2054 -> { DogmaEffectData.id= 2054; name= "explosiveShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7765; postExpression= 7766 } |> Some
      | 211 -> { DogmaEffectData.id= 211; name= "sensorUpgradesSkillBoostCpuNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1440; postExpression= 1441 } |> Some
      | 3024 -> { DogmaEffectData.id= 3024; name= "eliteBonusCoverOpsBombExplosiveDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10652; postExpression= 10653 } |> Some
      | 308 -> { DogmaEffectData.id= 308; name= "ironWillWillpowerBonusModAddWillpowerLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1844; postExpression= 1845 } |> Some
      | 3703 -> { DogmaEffectData.id= 3703; name= "shipMissileLauncherSpeedBonusMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12656; postExpression= 12657 } |> Some
      | 3897 -> { DogmaEffectData.id= 3897; name= "subsystemBonusCaldariCoreScanStrengthGravimetric"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13159; postExpression= 13160 } |> Some
      | 4091 -> { DogmaEffectData.id= 4091; name= "systemCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13680; postExpression= 13681 } |> Some
      | 4188 -> { DogmaEffectData.id= 4188; name= "shipBonusStrategicCruiserCaldariHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13895; postExpression= 13896 } |> Some
      | 4479 -> { DogmaEffectData.id= 4479; name= "shipBonusSurveyProbeExplosionDelaySkillSurveyCovertOps3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14685; postExpression= 14686 } |> Some
      | 4576 -> { DogmaEffectData.id= 4576; name= "eliteBonusLogisticsTrackingLinkFalloffBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15001; postExpression= 15002 } |> Some
      | 4770 -> { DogmaEffectData.id= 4770; name= "anchorLiftOrbital"; description= ""; displayName= "unanchoring"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 4867 -> { DogmaEffectData.id= 4867; name= "setBonusChristmasPowergrid"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15725; postExpression= 15726 } |> Some
      | 5352 -> { DogmaEffectData.id= 5352; name= "shipBonusProjectileDamageMBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16905; postExpression= 16906 } |> Some
      | 5934 -> { DogmaEffectData.id= 5934; name= "warpScrambleBlockMWDWithNPCEffect"; description= ""; displayName= ""; effectCategory= 2; preExpression= 18316; postExpression= 18317 } |> Some
      | 599 -> { DogmaEffectData.id= 599; name= "ammoFallofMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3059; postExpression= 3060 } |> Some
      | 6128 -> { DogmaEffectData.id= 6128; name= "scriptMissileGuidanceComputerAOECloudSizeBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18781; postExpression= 18782 } |> Some
      | 6225 -> { DogmaEffectData.id= 6225; name= "structureTargetGunneryMaxRangeFalloffTrackingSpeedBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12625; postExpression= 12626 } |> Some
      | 6322 -> { DogmaEffectData.id= 6322; name= "scriptscanGravimetricStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6613 -> { DogmaEffectData.id= 6613; name= "shipBonusSupercarrierRole1NumWarfareLinks"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6710 -> { DogmaEffectData.id= 6710; name= "shipBonusDreadnoughtM1WebStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6807 -> { DogmaEffectData.id= 6807; name= "invulnerabilityCoreDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6904 -> { DogmaEffectData.id= 6904; name= "strategicCruiserMinmatarSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13917; postExpression= 13918 } |> Some
      | 7001 -> { DogmaEffectData.id= 7001; name= "roleBonusTorpRoF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19363; postExpression= 19364 } |> Some
      | 7098 -> { DogmaEffectData.id= 7098; name= "structureConversionRigBasicBonuses"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 793 -> { DogmaEffectData.id= 793; name= "escortHullUpgradeCpu Bonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3758; postExpression= 3759 } |> Some
      | 987 -> { DogmaEffectData.id= 987; name= "gunshipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4387; postExpression= 4388 } |> Some
      | _ -> None