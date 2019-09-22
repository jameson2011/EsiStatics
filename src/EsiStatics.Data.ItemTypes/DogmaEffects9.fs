namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects9=
    let getDogmaEffect id = 
      match id with 
      | 106 -> { DogmaEffectData.id= 106; name= "miningAmountMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 715; postExpression= 716 } |> Some
      | 1173 -> { DogmaEffectData.id= 1173; name= "ammoInfluenceEntityFlyRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5102; postExpression= 5103 } |> Some
      | 2143 -> { DogmaEffectData.id= 2143; name= "minmatarShipEwTargetPainterMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6949; postExpression= 6950 } |> Some
      | 2725 -> { DogmaEffectData.id= 2725; name= "rigDrawbackSkillEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9791; postExpression= 9792 } |> Some
      | 3404 -> { DogmaEffectData.id= 3404; name= "blackOpsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11758; postExpression= 11759 } |> Some
      | 3598 -> { DogmaEffectData.id= 3598; name= "scriptSensorBoosterMaxTargetRangeBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12336; postExpression= 12337 } |> Some
      | 397 -> { DogmaEffectData.id= 397; name= "electronicsCpuOutputBonusPostPercentCpuOutputLocationShipGroupComputer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2258; postExpression= 2259 } |> Some
      | 4277 -> { DogmaEffectData.id= 4277; name= "subsystemBonusGallentePropulsionWarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14155; postExpression= 14156 } |> Some
      | 4374 -> { DogmaEffectData.id= 4374; name= "subSystemBonusCaldariDefensiveSiegeWarfare"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14379; postExpression= 14380 } |> Some
      | 4471 -> { DogmaEffectData.id= 4471; name= "shipBonusStasisMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14666; postExpression= 14667 } |> Some
      | 4665 -> { DogmaEffectData.id= 4665; name= "oreIndustrialSkillLevelPostMulShipBonusOreIndustrial1Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15198; postExpression= 15199 } |> Some
      | 494 -> { DogmaEffectData.id= 494; name= "warpDriveOperationWarpCapacitorNeedBonusPostPercentWarpCapacitorNeedLocationShipGroupPropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2636; postExpression= 2637 } |> Some
      | 5635 -> { DogmaEffectData.id= 5635; name= "shipBonusTorpedoMissileKineticDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17570; postExpression= 17571 } |> Some
      | 5829 -> { DogmaEffectData.id= 5829; name= "shipBonusMiningDurationORE3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18035; postExpression= 18036 } |> Some
      | 5926 -> { DogmaEffectData.id= 5926; name= "systemMagnetrometricECMBomb"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18296; postExpression= 18297 } |> Some
      | 6411 -> { DogmaEffectData.id= 6411; name= "structureRigVelocityBonusAoeMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6508 -> { DogmaEffectData.id= 6508; name= "shipBonusDreadnoughtG3RepairTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6605 -> { DogmaEffectData.id= 6605; name= "shipBonusSupercarrierG1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6702 -> { DogmaEffectData.id= 6702; name= "rigDrawbackReductionEnergyWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19285; postExpression= 19286 } |> Some
      | 6799 -> { DogmaEffectData.id= 6799; name= "shipModeSmallMissileDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18518; postExpression= 18519 } |> Some
      | 6896 -> { DogmaEffectData.id= 6896; name= "subsystemMHTFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19331; postExpression= 19332 } |> Some
      | 6993 -> { DogmaEffectData.id= 6993; name= "roleBonus2BoosterPenaltyReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19360; postExpression= 19361 } |> Some
      | 7187 -> { DogmaEffectData.id= 7187; name= "npcBehaviorMicroJumpAttack"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 882 -> { DogmaEffectData.id= 882; name= "shipHybridRangeBonusCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4052; postExpression= 4053 } |> Some
      | 9 -> { DogmaEffectData.id= 9; name= "missileLaunching"; description= ""; displayName= ""; effectCategory= 2; preExpression= 114; postExpression= 89 } |> Some
      | _ -> None