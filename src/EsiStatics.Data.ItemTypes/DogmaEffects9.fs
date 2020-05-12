namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects9=
    let getDogmaEffect id = 
      match id with 
      | 106 -> { DogmaEffectData.id= 106; name= "miningAmountMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1173 -> { DogmaEffectData.id= 1173; name= "ammoInfluenceEntityFlyRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1270 -> { DogmaEffectData.id= 1270; name= "interceptor2ProjectileTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5393; postExpression= 5394 } |> Some
      | 1367 -> { DogmaEffectData.id= 1367; name= "propulsionSkillStasisStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5678; postExpression= 5679 } |> Some
      | 1852 -> { DogmaEffectData.id= 1852; name= "shipMiningBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7142; postExpression= 7143 } |> Some
      | 2143 -> { DogmaEffectData.id= 2143; name= "minmatarShipEwTargetPainterMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2725 -> { DogmaEffectData.id= 2725; name= "rigDrawbackSkillEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2822 -> { DogmaEffectData.id= 2822; name= "commandBonus2MultiplyWithCommandBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10022; postExpression= 10023 } |> Some
      | 3016 -> { DogmaEffectData.id= 3016; name= "covertOpsAgilityBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10623; postExpression= 10624 } |> Some
      | 3113 -> { DogmaEffectData.id= 3113; name= "controlTowerGenericHullE&EResistanceBonusCynoJammer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10947; postExpression= 10948 } |> Some
      | 3404 -> { DogmaEffectData.id= 3404; name= "blackOpsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3501 -> { DogmaEffectData.id= 3501; name= "stripMinerMaxRangeMultBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12035; postExpression= 12036 } |> Some
      | 3598 -> { DogmaEffectData.id= 3598; name= "scriptSensorBoosterMaxTargetRangeBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3695 -> { DogmaEffectData.id= 3695; name= "turretWeaponFalloffMultiplyTargetHostile5"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12642; postExpression= 12643 } |> Some
      | 3889 -> { DogmaEffectData.id= 3889; name= "subsystemBonusAmarrElectronicScanResolution"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13143; postExpression= 13144 } |> Some
      | 397 -> { DogmaEffectData.id= 397; name= "electronicsCpuOutputBonusPostPercentCpuOutputLocationShipGroupComputer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4083 -> { DogmaEffectData.id= 4083; name= "systemStandardMissileKineticDamageOld"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13648; postExpression= 13649 } |> Some
      | 4277 -> { DogmaEffectData.id= 4277; name= "subsystemBonusGallentePropulsionWarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4374 -> { DogmaEffectData.id= 4374; name= "subSystemBonusCaldariDefensiveSiegeWarfare"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4471 -> { DogmaEffectData.id= 4471; name= "shipBonusStasisMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4665 -> { DogmaEffectData.id= 4665; name= "oreIndustrialSkillLevelPostMulShipBonusOreIndustrial1Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4762 -> { DogmaEffectData.id= 4762; name= "eliteBonusBlackOpsECMBurstRadar1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15397; postExpression= 15398 } |> Some
      | 4859 -> { DogmaEffectData.id= 4859; name= "skillBonusBoosterAoECloudSize"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15692; postExpression= 15693 } |> Some
      | 494 -> { DogmaEffectData.id= 494; name= "warpDriveOperationWarpCapacitorNeedBonusPostPercentWarpCapacitorNeedLocationShipGroupPropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5150 -> { DogmaEffectData.id= 5150; name= "shipBonusFrigateSizedMissileKineticDamageDF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16421; postExpression= 16422 } |> Some
      | 5344 -> { DogmaEffectData.id= 5344; name= "shipBonusDroneHullHitpointsGBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16889; postExpression= 16890 } |> Some
      | 5635 -> { DogmaEffectData.id= 5635; name= "shipBonusTorpedoMissileKineticDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5829 -> { DogmaEffectData.id= 5829; name= "shipBonusMiningDurationORE3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5926 -> { DogmaEffectData.id= 5926; name= "systemMagnetrometricECMBomb"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6023 -> { DogmaEffectData.id= 6023; name= "eliteReconBonusNeutRange3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18535; postExpression= 18536 } |> Some
      | 6217 -> { DogmaEffectData.id= 6217; name= "structureTargetMaxTargetRangeAndScanResolutionBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12285; postExpression= 12286 } |> Some
      | 6314 -> { DogmaEffectData.id= 6314; name= "shipBonusShieldExplosiveResistanceMD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19160; postExpression= 19161 } |> Some
      | 6411 -> { DogmaEffectData.id= 6411; name= "structureRigVelocityBonusAoeMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6508 -> { DogmaEffectData.id= 6508; name= "shipBonusDreadnoughtG3RepairTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6605 -> { DogmaEffectData.id= 6605; name= "shipBonusSupercarrierG1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6702 -> { DogmaEffectData.id= 6702; name= "rigDrawbackReductionEnergyWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6799 -> { DogmaEffectData.id= 6799; name= "shipModeSmallMissileDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 688 -> { DogmaEffectData.id= 688; name= "electronic2AttributeModifyOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 3398; postExpression= 3399 } |> Some
      | 6896 -> { DogmaEffectData.id= 6896; name= "subsystemMHTFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6993 -> { DogmaEffectData.id= 6993; name= "roleBonus2BoosterPenaltyReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7187 -> { DogmaEffectData.id= 7187; name= "npcBehaviorMicroJumpAttack"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 882 -> { DogmaEffectData.id= 882; name= "shipHybridRangeBonusCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 9 -> { DogmaEffectData.id= 9; name= "missileLaunching"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None