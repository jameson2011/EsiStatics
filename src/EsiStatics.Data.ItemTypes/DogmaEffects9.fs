namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects9=
    let getDogmaEffect id = 
      match id with 
      | 106 -> { DogmaEffectData.id= 106; name= "miningAmountMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1173 -> { DogmaEffectData.id= 1173; name= "ammoInfluenceEntityFlyRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2143 -> { DogmaEffectData.id= 2143; name= "minmatarShipEwTargetPainterMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2725 -> { DogmaEffectData.id= 2725; name= "rigDrawbackSkillEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3404 -> { DogmaEffectData.id= 3404; name= "blackOpsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3598 -> { DogmaEffectData.id= 3598; name= "scriptSensorBoosterMaxTargetRangeBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 397 -> { DogmaEffectData.id= 397; name= "electronicsCpuOutputBonusPostPercentCpuOutputLocationShipGroupComputer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4277 -> { DogmaEffectData.id= 4277; name= "subsystemBonusGallentePropulsionWarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4374 -> { DogmaEffectData.id= 4374; name= "subSystemBonusCaldariDefensiveSiegeWarfare"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4471 -> { DogmaEffectData.id= 4471; name= "shipBonusStasisMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4665 -> { DogmaEffectData.id= 4665; name= "oreIndustrialSkillLevelPostMulShipBonusOreIndustrial1Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 494 -> { DogmaEffectData.id= 494; name= "warpDriveOperationWarpCapacitorNeedBonusPostPercentWarpCapacitorNeedLocationShipGroupPropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5635 -> { DogmaEffectData.id= 5635; name= "shipBonusTorpedoMissileKineticDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5829 -> { DogmaEffectData.id= 5829; name= "shipBonusMiningDurationORE3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5926 -> { DogmaEffectData.id= 5926; name= "systemMagnetrometricECMBomb"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6411 -> { DogmaEffectData.id= 6411; name= "structureRigVelocityBonusAoeMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6508 -> { DogmaEffectData.id= 6508; name= "shipBonusDreadnoughtG3RepairTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6605 -> { DogmaEffectData.id= 6605; name= "shipBonusSupercarrierG1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6702 -> { DogmaEffectData.id= 6702; name= "rigDrawbackReductionEnergyWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6799 -> { DogmaEffectData.id= 6799; name= "shipModeSmallMissileDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6896 -> { DogmaEffectData.id= 6896; name= "subsystemMHTFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6993 -> { DogmaEffectData.id= 6993; name= "roleBonus2BoosterPenaltyReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7187 -> { DogmaEffectData.id= 7187; name= "npcBehaviorMicroJumpAttack"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 882 -> { DogmaEffectData.id= 882; name= "shipHybridRangeBonusCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 9 -> { DogmaEffectData.id= 9; name= "missileLaunching"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None