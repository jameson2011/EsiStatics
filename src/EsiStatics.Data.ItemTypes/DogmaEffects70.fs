namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects70=
    let getDogmaEffect id = 
      match id with 
      | 1137 -> { DogmaEffectData.id= 1137; name= "controlTowerMinmatarProjectileRofBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4958; postExpression= 4959 } |> Some
      | 1234 -> { DogmaEffectData.id= 1234; name= "shipMissileVelocityPirateFactionLight"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5287; postExpression= 5288 } |> Some
      | 167 -> { DogmaEffectData.id= 167; name= "sharpshooterSkillBoostRangeSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1241; postExpression= 1242 } |> Some
      | 1816 -> { DogmaEffectData.id= 1816; name= "shipShieldEMResistanceCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7002; postExpression= 7003 } |> Some
      | 1913 -> { DogmaEffectData.id= 1913; name= "eliteReconBonusRadarStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7343; postExpression= 7344 } |> Some
      | 2010 -> { DogmaEffectData.id= 2010; name= "propulsionDroneJammingStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7626; postExpression= 7627 } |> Some
      | 2107 -> { DogmaEffectData.id= 2107; name= "kineticArmorCompensationHardeningBonusGroupArmorCoating"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7932; postExpression= 7933 } |> Some
      | 2689 -> { DogmaEffectData.id= 2689; name= "capNeedBonusEffectHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9679; postExpression= 9680 } |> Some
      | 2883 -> { DogmaEffectData.id= 2883; name= "missileKineticDmgBonusCruise3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10195; postExpression= 10196 } |> Some
      | 2980 -> { DogmaEffectData.id= 2980; name= "skillCapitalRemoteHullRepairSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10511; postExpression= 10512 } |> Some
      | 3174 -> { DogmaEffectData.id= 3174; name= "overloadSelfRangeBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 11090; postExpression= 11091 } |> Some
      | 3659 -> { DogmaEffectData.id= 3659; name= "shipMaxTargetRangeBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9627; postExpression= 9628 } |> Some
      | 3853 -> { DogmaEffectData.id= 3853; name= "rechargeRateAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13074; postExpression= 13075 } |> Some
      | 4047 -> { DogmaEffectData.id= 4047; name= "systemSmartBombThermalDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13544; postExpression= 13545 } |> Some
      | 4338 -> { DogmaEffectData.id= 4338; name= "subsystemSkillLevelAmarrOffensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14290; postExpression= 14291 } |> Some
      | 4823 -> { DogmaEffectData.id= 4823; name= "bcLargeEnergyTurretCPUNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15572; postExpression= 15573 } |> Some
      | 5017 -> { DogmaEffectData.id= 5017; name= "shipArmorRepairingRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16122; postExpression= 16123 } |> Some
      | 5308 -> { DogmaEffectData.id= 5308; name= "shipBonusAoeVelocityStandardMissilesCD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16817; postExpression= 16818 } |> Some
      | 5502 -> { DogmaEffectData.id= 5502; name= "eliteBonusCommandShipMediumHybridTrackingCS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17263; postExpression= 17264 } |> Some
      | 5793 -> { DogmaEffectData.id= 5793; name= "ewSkillTrackingDisruptionRangeDisruptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17937; postExpression= 17938 } |> Some
      | 5890 -> { DogmaEffectData.id= 5890; name= "eliteIndustrialMWDHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18177; postExpression= 18178 } |> Some
      | 6278 -> { DogmaEffectData.id= 6278; name= "shipBonusEnergyNosFalloffEAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19084; postExpression= 19085 } |> Some
      | 6375 -> { DogmaEffectData.id= 6375; name= "logiFrigSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4633; postExpression= 4634 } |> Some
      | 6472 -> { DogmaEffectData.id= 6472; name= "doomsdayBeamDOT"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6569 -> { DogmaEffectData.id= 6569; name= "skillMultiplierFighterHangarSize"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6666 -> { DogmaEffectData.id= 6666; name= "skillMultiplierMaxVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6763 -> { DogmaEffectData.id= 6763; name= "iceHarvestingDroneOperationDurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19314; postExpression= 19315 } |> Some
      | 6860 -> { DogmaEffectData.id= 6860; name= "shipBonusRole5RemoteArmorRepairPowergridBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6957 -> { DogmaEffectData.id= 6957; name= "subsystemRemoteArmorRepairerFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8021; postExpression= 8022 } |> Some
      | 70 -> { DogmaEffectData.id= 70; name= "agilityMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 566; postExpression= 567 } |> Some
      | 7151 -> { DogmaEffectData.id= 7151; name= "precursorDestroyerSkillLevelPreMulShipBonusPD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19667; postExpression= 19668 } |> Some
      | _ -> None