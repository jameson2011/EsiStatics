namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects32=
    let getDogmaEffect id = 
      match id with 
      | 1099 -> { DogmaEffectData.id= 1099; name= "shipProjectileTrackingMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1293 -> { DogmaEffectData.id= 1293; name= "minmatarIndustrialSkillLevelPreMulShipBonusMI2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2748 -> { DogmaEffectData.id= 2748; name= "boosterMissileVelocityPenalty"; description= "Automatically generated effect"; displayName= "Missile Velocity Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3427 -> { DogmaEffectData.id= 3427; name= "eliteBonusViolatorsTractorBeamMaxRangeRole2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3524 -> { DogmaEffectData.id= 3524; name= "skillNaniteInterfacingRepairTimeLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4106 -> { DogmaEffectData.id= 4106; name= "subsystemBonusGallenteOffensiveHybridWeaponFalloff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4203 -> { DogmaEffectData.id= 4203; name= "subsystemSkillLevelAmarrEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4397 -> { DogmaEffectData.id= 4397; name= "shipBonusGFTorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4688 -> { DogmaEffectData.id= 4688; name= "NPCGroupPropJamAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 517 -> { DogmaEffectData.id= 517; name= "gallenteCruiserSkillLevelPreMulShipBonusGCShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5367 -> { DogmaEffectData.id= 5367; name= "shipBonusRepairSystemsArmorRepairAmountGB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5561 -> { DogmaEffectData.id= 5561; name= "subSystemBonusAmarrDefensiveInformationWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5852 -> { DogmaEffectData.id= 5852; name= "eliteBonusExpeditionMining1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6046 -> { DogmaEffectData.id= 6046; name= "shipBonusSentryHPGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6337 -> { DogmaEffectData.id= 6337; name= "shipBonusEMArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6434 -> { DogmaEffectData.id= 6434; name= "fighterAbilityEnergyNeutralizer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6628 -> { DogmaEffectData.id= 6628; name= "shipBonusCarrierM2SupportFighterBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6725 -> { DogmaEffectData.id= 6725; name= "shipBonusSETFalloffAF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6822 -> { DogmaEffectData.id= 6822; name= "rigAdvLarShipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced large ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6919 -> { DogmaEffectData.id= 6919; name= "subsystemSkillLevelMinmatarDefensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7016 -> { DogmaEffectData.id= 7016; name= "eliteBonusGunshipExplosiveMissileDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7210 -> { DogmaEffectData.id= 7210; name= "shipBonusCommandDestroyerRole2DefenderBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None