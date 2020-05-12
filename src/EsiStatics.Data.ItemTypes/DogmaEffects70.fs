namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects70=
    let getDogmaEffect id = 
      match id with 
      | 1137 -> { DogmaEffectData.id= 1137; name= "controlTowerMinmatarProjectileRofBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1234 -> { DogmaEffectData.id= 1234; name= "shipMissileVelocityPirateFactionLight"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 167 -> { DogmaEffectData.id= 167; name= "sharpshooterSkillBoostRangeSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1816 -> { DogmaEffectData.id= 1816; name= "shipShieldEMResistanceCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1913 -> { DogmaEffectData.id= 1913; name= "eliteReconBonusRadarStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2010 -> { DogmaEffectData.id= 2010; name= "propulsionDroneJammingStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2107 -> { DogmaEffectData.id= 2107; name= "kineticArmorCompensationHardeningBonusGroupArmorCoating"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2689 -> { DogmaEffectData.id= 2689; name= "capNeedBonusEffectHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2786 -> { DogmaEffectData.id= 2786; name= "bcuThDamageBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9950; postExpression= 9951 } |> Some
      | 2883 -> { DogmaEffectData.id= 2883; name= "missileKineticDmgBonusCruise3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2980 -> { DogmaEffectData.id= 2980; name= "skillCapitalRemoteHullRepairSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3077 -> { DogmaEffectData.id= 3077; name= "controlTowerGenericHullKineticResistanceBonusEnergyNeutralizer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10799; postExpression= 10800 } |> Some
      | 3174 -> { DogmaEffectData.id= 3174; name= "overloadSelfRangeBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3562 -> { DogmaEffectData.id= 3562; name= "shipBonusEwWeaponDisruptionMaxRangeBonusAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12252; postExpression= 12253 } |> Some
      | 3659 -> { DogmaEffectData.id= 3659; name= "shipMaxTargetRangeBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 3853 -> { DogmaEffectData.id= 3853; name= "rechargeRateAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4047 -> { DogmaEffectData.id= 4047; name= "systemSmartBombThermalDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4241 -> { DogmaEffectData.id= 4241; name= "modifyShieldResonanceEMPassivePreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14082; postExpression= 14083 } |> Some
      | 4338 -> { DogmaEffectData.id= 4338; name= "subsystemSkillLevelAmarrOffensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 458 -> { DogmaEffectData.id= 458; name= "shipCargoBonusMF"; description= "Automatically generated effect"; displayName= "shipCapacityBonusMF"; effectCategory= 0; preExpression= 2515; postExpression= 2516 } |> Some
      | 4629 -> { DogmaEffectData.id= 4629; name= "eliteBonusViolatorsCruiseMissileEMAndEXDamageRole"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15119; postExpression= 15120 } |> Some
      | 4823 -> { DogmaEffectData.id= 4823; name= "bcLargeEnergyTurretCPUNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5017 -> { DogmaEffectData.id= 5017; name= "shipArmorRepairingRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5308 -> { DogmaEffectData.id= 5308; name= "shipBonusAoeVelocityStandardMissilesCD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5405 -> { DogmaEffectData.id= 5405; name= "shipMissileHeavyAssaultROFCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17003; postExpression= 17004 } |> Some
      | 5502 -> { DogmaEffectData.id= 5502; name= "eliteBonusCommandShipMediumHybridTrackingCS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5599 -> { DogmaEffectData.id= 5599; name= "marauderModeEffect18"; description= ""; displayName= ""; effectCategory= 1; preExpression= 17488; postExpression= 17489 } |> Some
      | 5793 -> { DogmaEffectData.id= 5793; name= "ewSkillTrackingDisruptionRangeDisruptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5890 -> { DogmaEffectData.id= 5890; name= "eliteIndustrialMWDHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6084 -> { DogmaEffectData.id= 6084; name= "shipShieldCapacityCaldariTacticalDestroyer2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18671; postExpression= 18672 } |> Some
      | 6278 -> { DogmaEffectData.id= 6278; name= "shipBonusEnergyNosFalloffEAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6375 -> { DogmaEffectData.id= 6375; name= "logiFrigSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6472 -> { DogmaEffectData.id= 6472; name= "doomsdayBeamDOT"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6569 -> { DogmaEffectData.id= 6569; name= "skillMultiplierFighterHangarSize"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6666 -> { DogmaEffectData.id= 6666; name= "skillMultiplierMaxVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6763 -> { DogmaEffectData.id= 6763; name= "iceHarvestingDroneOperationDurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6860 -> { DogmaEffectData.id= 6860; name= "shipBonusRole5RemoteArmorRepairPowergridBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6957 -> { DogmaEffectData.id= 6957; name= "subsystemRemoteArmorRepairerFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 70 -> { DogmaEffectData.id= 70; name= "agilityMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7151 -> { DogmaEffectData.id= 7151; name= "precursorDestroyerSkillLevelPreMulShipBonusPD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7248 -> { DogmaEffectData.id= 7248; name= "shipPBonusROFMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8024 -> { DogmaEffectData.id= 8024; name= "hydraDroneRangeEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None