namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects83=
    let getDogmaEffect id = 
      match id with 
      | 1053 -> { DogmaEffectData.id= 1053; name= "logisticSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4637; postExpression= 4638 } |> Some
      | 1150 -> { DogmaEffectData.id= 1150; name= "systemScan"; description= "Scan the solar system."; displayName= "Analyzing Scans"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 1441 -> { DogmaEffectData.id= 1441; name= "caldariShipEwOptimalRangeCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5907; postExpression= 5908 } |> Some
      | 1635 -> { DogmaEffectData.id= 1635; name= "capitalRepairSystemsSkillDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6495; postExpression= 6496 } |> Some
      | 2411 -> { DogmaEffectData.id= 2411; name= "cloneVatMaxJumpCloneBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8873; postExpression= 8874 } |> Some
      | 2605 -> { DogmaEffectData.id= 2605; name= "shipBonusThermicShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9456; postExpression= 9457 } |> Some
      | 2702 -> { DogmaEffectData.id= 2702; name= "salvagingAccessDifficultyBonusEffect"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9722; postExpression= 9723 } |> Some
      | 277 -> { DogmaEffectData.id= 277; name= "tacticalshieldManipulationSkillBoostUniformityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1721; postExpression= 1722 } |> Some
      | 2799 -> { DogmaEffectData.id= 2799; name= "missileLauncherSpeedMultiplierPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4069; postExpression= 4070 } |> Some
      | 2896 -> { DogmaEffectData.id= 2896; name= "missileExplosiveDmgBonusFOF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10241; postExpression= 10242 } |> Some
      | 3090 -> { DogmaEffectData.id= 3090; name= "controlTowerGenericHullKineticResistanceBonusLaser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10853; postExpression= 10854 } |> Some
      | 3478 -> { DogmaEffectData.id= 3478; name= "shipLaserDamagePirateBattleship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11966; postExpression= 11967 } |> Some
      | 3575 -> { DogmaEffectData.id= 3575; name= "sensorBoosterScanResolutionBonusActive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 3427; postExpression= 3428 } |> Some
      | 3672 -> { DogmaEffectData.id= 3672; name= "setBonusOre"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12064; postExpression= 12065 } |> Some
      | 3769 -> { DogmaEffectData.id= 3769; name= "zColinShieldHPPerLvl"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12837; postExpression= 12838 } |> Some
      | 3866 -> { DogmaEffectData.id= 3866; name= "subsystemBonusCaldariPropulsion2Agility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13097; postExpression= 13098 } |> Some
      | 3963 -> { DogmaEffectData.id= 3963; name= "subsystemBonusAmarrDefensiveShieldBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13291; postExpression= 13292 } |> Some
      | 4060 -> { DogmaEffectData.id= 4060; name= "systemRocketThermalDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13586; postExpression= 13587 } |> Some
      | 4157 -> { DogmaEffectData.id= 4157; name= "subsystemBonusGallenteEngineeringCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13822; postExpression= 13823 } |> Some
      | 4254 -> { DogmaEffectData.id= 4254; name= "subsystemBonusMinmatarOffensive2HeavyMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14109; postExpression= 14110 } |> Some
      | 4351 -> { DogmaEffectData.id= 4351; name= "subsystemBonusMinmatarOffensive3TurretTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14325; postExpression= 14326 } |> Some
      | 4448 -> { DogmaEffectData.id= 4448; name= "republicsetbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14582; postExpression= 14583 } |> Some
      | 4642 -> { DogmaEffectData.id= 4642; name= "shipHeavyAssaultMissileEMAndExpAndKinDmgAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15145; postExpression= 15146 } |> Some
      | 4933 -> { DogmaEffectData.id= 4933; name= "shipSETDmgBonus2AF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15899; postExpression= 15900 } |> Some
      | 5030 -> { DogmaEffectData.id= 5030; name= "shipBonusMiningDroneAmountPercentRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16152; postExpression= 16153 } |> Some
      | 5127 -> { DogmaEffectData.id= 5127; name= "shipBonusShieldTransferBoostAmountMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16378; postExpression= 16379 } |> Some
      | 5224 -> { DogmaEffectData.id= 5224; name= "shipHeavyAssaultMissileExpDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16607; postExpression= 16608 } |> Some
      | 5321 -> { DogmaEffectData.id= 5321; name= "shipBonusMWDSignatureRadiusMD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16843; postExpression= 16844 } |> Some
      | 5418 -> { DogmaEffectData.id= 5418; name= "shipBonusDroneArmorHitPointsAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17029; postExpression= 17030 } |> Some
      | 568 -> { DogmaEffectData.id= 568; name= "massProductionSkillLevelModAddManufactureSlotLimitChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2958; postExpression= 2959 } |> Some
      | 5806 -> { DogmaEffectData.id= 5806; name= "shipBonusSentryDroneArmorHpPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17969; postExpression= 17970 } |> Some
      | 5903 -> { DogmaEffectData.id= 5903; name= "advancedIndustryManufacturingTimeBonusPostPercent"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18226; postExpression= 18227 } |> Some
      | 6097 -> { DogmaEffectData.id= 6097; name= "shipShieldCapacityAdditionCaldariTacticalDestroyer2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18697; postExpression= 18698 } |> Some
      | 6194 -> { DogmaEffectData.id= 6194; name= "expeditionFrigateShieldResistanceEMEXKIN1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18923; postExpression= 18924 } |> Some
      | 6291 -> { DogmaEffectData.id= 6291; name= "shipBonusEnergyNosFalloffAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19112; postExpression= 19113 } |> Some
      | 6485 -> { DogmaEffectData.id= 6485; name= "fighterAbilityLaunchBomb"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6582 -> { DogmaEffectData.id= 6582; name= "moduleBonusSiegeModule"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6679 -> { DogmaEffectData.id= 6679; name= "skillStructureDoomsdayDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6776 -> { DogmaEffectData.id= 6776; name= "armoredCommandStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6873 -> { DogmaEffectData.id= 6873; name= "eliteBonusReconWarpVelocity3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19327; postExpression= 19328 } |> Some
      | 6970 -> { DogmaEffectData.id= 6970; name= "rigReactionHybMatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7067 -> { DogmaEffectData.id= 7067; name= "precursorCruiserSkillLevelPreMulShipBonusPC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19428; postExpression= 19429 } |> Some
      | 762 -> { DogmaEffectData.id= 762; name= "minmatarFrigateSkillLevelPreMulShipBonusMF2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3653; postExpression= 3654 } |> Some
      | 859 -> { DogmaEffectData.id= 859; name= "advancedBountyHuntingSkillBoostBountySkillMultiplyer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3967; postExpression= 3968 } |> Some
      | _ -> None