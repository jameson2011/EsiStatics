namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects31=
    let getDogmaEffect id = 
      match id with 
      | 1001 -> { DogmaEffectData.id= 1001; name= "eliteBonusGunshipCapRecharge2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4426; postExpression= 4427 } |> Some
      | 1195 -> { DogmaEffectData.id= 1195; name= "shipArmorRepairingGBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5175; postExpression= 5176 } |> Some
      | 1292 -> { DogmaEffectData.id= 1292; name= "gallenteIndustrialSkillLevelPreMulShipBonusGI2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5450; postExpression= 5451 } |> Some
      | 1486 -> { DogmaEffectData.id= 1486; name= "commandMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6050; postExpression= 6051 } |> Some
      | 225 -> { DogmaEffectData.id= 225; name= "accerationControlSkillBoostCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1504; postExpression= 1505 } |> Some
      | 2456 -> { DogmaEffectData.id= 2456; name= "miningUpgradeCPUPenaltyReductionModulesRequiringMiningUpgradePercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9029; postExpression= 9030 } |> Some
      | 2747 -> { DogmaEffectData.id= 2747; name= "boosterTurretTrackingPenalty"; description= "Automatically generated effect"; displayName= "Turret Tracking Penalty"; effectCategory= 0; preExpression= 9849; postExpression= 9850 } |> Some
      | 2844 -> { DogmaEffectData.id= 2844; name= "shipBonusHeavyAssaultStandardMissileKineticDamageBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10085; postExpression= 10086 } |> Some
      | 3038 -> { DogmaEffectData.id= 3038; name= "missileDamageMultiplierCruiseThermalBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10686; postExpression= 10687 } |> Some
      | 31 -> { DogmaEffectData.id= 31; name= "energyTransfer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 258 } |> Some
      | 3135 -> { DogmaEffectData.id= 3135; name= "controlTowerGenericHullK&TResistanceBonusSenDamp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10989; postExpression= 10990 } |> Some
      | 322 -> { DogmaEffectData.id= 322; name= "gallenteTechGallenteTechMutatorPostPercentGallenteTechTimePercentLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1916; postExpression= 1917 } |> Some
      | 3232 -> { DogmaEffectData.id= 3232; name= "shipRocketKineticDmgDF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11246; postExpression= 11247 } |> Some
      | 3426 -> { DogmaEffectData.id= 3426; name= "eliteBonusViolatorsStasisWebSpeedFactor2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11828; postExpression= 11829 } |> Some
      | 3523 -> { DogmaEffectData.id= 3523; name= "skillNaniteInterfacingRepairTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12109; postExpression= 12110 } |> Some
      | 3620 -> { DogmaEffectData.id= 3620; name= "scriptSpeedFactorBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12438; postExpression= 12439 } |> Some
      | 4008 -> { DogmaEffectData.id= 4008; name= "systemEcmMagnetometricStrength"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13394; postExpression= 13395 } |> Some
      | 4105 -> { DogmaEffectData.id= 4105; name= "subsystemBonusGallenteOffensiveHybridWeaponMaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13714; postExpression= 13715 } |> Some
      | 4202 -> { DogmaEffectData.id= 4202; name= "subsystemSkillLevelAmarrElectronic2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13957; postExpression= 13958 } |> Some
      | 4396 -> { DogmaEffectData.id= 4396; name= "shipBonusEliteCover2TorpedoKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14428; postExpression= 14429 } |> Some
      | 4493 -> { DogmaEffectData.id= 4493; name= "bombersDmgBonusSkills"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14708; postExpression= 14709 } |> Some
      | 4687 -> { DogmaEffectData.id= 4687; name= "NPCGroupSpeedAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 89 } |> Some
      | 4784 -> { DogmaEffectData.id= 4784; name= "shipEnergyVampireAmountBonusAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15440; postExpression= 15441 } |> Some
      | 4978 -> { DogmaEffectData.id= 4978; name= "unusedEntityTrackingDisrupt2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 2; preExpression= 16020; postExpression= 16021 } |> Some
      | 5075 -> { DogmaEffectData.id= 5075; name= "shipBonusExplosiveShieldResistanceORE3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16271; postExpression= 16272 } |> Some
      | 516 -> { DogmaEffectData.id= 516; name= "shipTCapNeedBonusAC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2761; postExpression= 2762 } |> Some
      | 5172 -> { DogmaEffectData.id= 5172; name= "sensorIntegritySkillLevelPreMulSensorStrengthBonusSelf"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16482; postExpression= 16483 } |> Some
      | 5366 -> { DogmaEffectData.id= 5366; name= "shipBonusRepairSystemsBonusATC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16931; postExpression= 16932 } |> Some
      | 5560 -> { DogmaEffectData.id= 5560; name= "roleBonusMarauderMJDRReactivationDelayBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17403; postExpression= 17404 } |> Some
      | 5657 -> { DogmaEffectData.id= 5657; name= "Interceptor2ShieldResist"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17615; postExpression= 17616 } |> Some
      | 5754 -> { DogmaEffectData.id= 5754; name= "overloadSelfTrackingModuleBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 17826; postExpression= 17827 } |> Some
      | 5851 -> { DogmaEffectData.id= 5851; name= "expeditionFrigateSkillLevelPostMulEliteBonusExpedition2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18091; postExpression= 18092 } |> Some
      | 6045 -> { DogmaEffectData.id= 6045; name= "shipBonusSentryDamageMultiplierGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18593; postExpression= 18594 } |> Some
      | 6142 -> { DogmaEffectData.id= 6142; name= "overloadSelfMissileGuidanceBonus4"; description= ""; displayName= ""; effectCategory= 5; preExpression= 18823; postExpression= 18824 } |> Some
      | 6239 -> { DogmaEffectData.id= 6239; name= "miningFrigateBonusIceHarvestingCycleTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18993; postExpression= 18994 } |> Some
      | 6336 -> { DogmaEffectData.id= 6336; name= "shipBonusThermalArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19196; postExpression= 19197 } |> Some
      | 6627 -> { DogmaEffectData.id= 6627; name= "shipBonusCarrierG2SupportFighterBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6724 -> { DogmaEffectData.id= 6724; name= "eliteBonusLogisticRemoteArmorRepairDuration3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4578; postExpression= 4579 } |> Some
      | 6821 -> { DogmaEffectData.id= 6821; name= "rigAdvMedShipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced medium ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6918 -> { DogmaEffectData.id= 6918; name= "subsystemSkillLevelMinmatarEngineering3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13027; postExpression= 13028 } |> Some
      | 7015 -> { DogmaEffectData.id= 7015; name= "eliteBonusGunshipEMMissileDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19377; postExpression= 19378 } |> Some
      | 7112 -> { DogmaEffectData.id= 7112; name= "shipBonusNeutCapNeedRoleBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19545; postExpression= 19546 } |> Some
      | 7209 -> { DogmaEffectData.id= 7209; name= "shipPCTOptimalBonusEliteGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19806; postExpression= 19807 } |> Some
      | 904 -> { DogmaEffectData.id= 904; name= "ammoInfluenceShieldCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4136; postExpression= 4137 } |> Some
      | _ -> None