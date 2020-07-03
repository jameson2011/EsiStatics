namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects31=
    let getDogmaEffect id = 
      match id with 
      | 1001 -> { DogmaEffectData.id= 1001; name= "eliteBonusGunshipCapRecharge2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1292 -> { DogmaEffectData.id= 1292; name= "gallenteIndustrialSkillLevelPreMulShipBonusGI2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 225 -> { DogmaEffectData.id= 225; name= "accerationControlSkillBoostCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2456 -> { DogmaEffectData.id= 2456; name= "miningUpgradeCPUPenaltyReductionModulesRequiringMiningUpgradePercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2747 -> { DogmaEffectData.id= 2747; name= "boosterTurretTrackingPenalty"; description= "Automatically generated effect"; displayName= "Turret Tracking Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 322 -> { DogmaEffectData.id= 322; name= "gallenteTechGallenteTechMutatorPostPercentGallenteTechTimePercentLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3620 -> { DogmaEffectData.id= 3620; name= "scriptSpeedFactorBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4202 -> { DogmaEffectData.id= 4202; name= "subsystemSkillLevelAmarrElectronic2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4396 -> { DogmaEffectData.id= 4396; name= "shipBonusEliteCover2TorpedoKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4687 -> { DogmaEffectData.id= 4687; name= "NPCGroupSpeedAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 516 -> { DogmaEffectData.id= 516; name= "shipTCapNeedBonusAC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5172 -> { DogmaEffectData.id= 5172; name= "sensorIntegritySkillLevelPreMulSensorStrengthBonusSelf"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5366 -> { DogmaEffectData.id= 5366; name= "shipBonusRepairSystemsBonusATC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5560 -> { DogmaEffectData.id= 5560; name= "roleBonusMarauderMJDRReactivationDelayBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5657 -> { DogmaEffectData.id= 5657; name= "Interceptor2ShieldResist"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5754 -> { DogmaEffectData.id= 5754; name= "overloadSelfTrackingModuleBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 5851 -> { DogmaEffectData.id= 5851; name= "expeditionFrigateSkillLevelPostMulEliteBonusExpedition2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6045 -> { DogmaEffectData.id= 6045; name= "shipBonusSentryDamageMultiplierGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6239 -> { DogmaEffectData.id= 6239; name= "miningFrigateBonusIceHarvestingCycleTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6336 -> { DogmaEffectData.id= 6336; name= "shipBonusThermalArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6627 -> { DogmaEffectData.id= 6627; name= "shipBonusCarrierG2SupportFighterBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6724 -> { DogmaEffectData.id= 6724; name= "eliteBonusLogisticRemoteArmorRepairDuration3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6821 -> { DogmaEffectData.id= 6821; name= "rigAdvMedShipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced medium ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6918 -> { DogmaEffectData.id= 6918; name= "subsystemSkillLevelMinmatarEngineering3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7015 -> { DogmaEffectData.id= 7015; name= "eliteBonusGunshipEMMissileDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7112 -> { DogmaEffectData.id= 7112; name= "shipBonusNeutCapNeedRoleBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7209 -> { DogmaEffectData.id= 7209; name= "shipPCTOptimalBonusEliteGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 904 -> { DogmaEffectData.id= 904; name= "ammoInfluenceShieldCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None