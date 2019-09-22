namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects32=
    let getDogmaEffect id = 
      match id with 
      | 1099 -> { DogmaEffectData.id= 1099; name= "shipProjectileTrackingMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4801; postExpression= 4802 } |> Some
      | 1293 -> { DogmaEffectData.id= 1293; name= "minmatarIndustrialSkillLevelPreMulShipBonusMI2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5454; postExpression= 5455 } |> Some
      | 2748 -> { DogmaEffectData.id= 2748; name= "boosterMissileVelocityPenalty"; description= "Automatically generated effect"; displayName= "Missile Velocity Penalty"; effectCategory= 0; preExpression= 9851; postExpression= 9852 } |> Some
      | 3427 -> { DogmaEffectData.id= 3427; name= "eliteBonusViolatorsTractorBeamMaxRangeRole2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11834; postExpression= 11835 } |> Some
      | 3524 -> { DogmaEffectData.id= 3524; name= "skillNaniteInterfacingRepairTimeLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12113; postExpression= 12114 } |> Some
      | 4106 -> { DogmaEffectData.id= 4106; name= "subsystemBonusGallenteOffensiveHybridWeaponFalloff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13716; postExpression= 13717 } |> Some
      | 4203 -> { DogmaEffectData.id= 4203; name= "subsystemSkillLevelAmarrEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13962; postExpression= 13963 } |> Some
      | 4397 -> { DogmaEffectData.id= 4397; name= "shipBonusGFTorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14430; postExpression= 14431 } |> Some
      | 4688 -> { DogmaEffectData.id= 4688; name= "NPCGroupPropJamAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 89 } |> Some
      | 517 -> { DogmaEffectData.id= 517; name= "gallenteCruiserSkillLevelPreMulShipBonusGCShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2766; postExpression= 2767 } |> Some
      | 5367 -> { DogmaEffectData.id= 5367; name= "shipBonusRepairSystemsArmorRepairAmountGB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16933; postExpression= 16934 } |> Some
      | 5561 -> { DogmaEffectData.id= 5561; name= "subSystemBonusAmarrDefensiveInformationWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17405; postExpression= 17406 } |> Some
      | 5852 -> { DogmaEffectData.id= 5852; name= "eliteBonusExpeditionMining1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18093; postExpression= 18094 } |> Some
      | 6046 -> { DogmaEffectData.id= 6046; name= "shipBonusSentryHPGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18595; postExpression= 18596 } |> Some
      | 6337 -> { DogmaEffectData.id= 6337; name= "shipBonusEMArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19198; postExpression= 19199 } |> Some
      | 6434 -> { DogmaEffectData.id= 6434; name= "fighterAbilityEnergyNeutralizer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6628 -> { DogmaEffectData.id= 6628; name= "shipBonusCarrierM2SupportFighterBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6725 -> { DogmaEffectData.id= 6725; name= "shipBonusSETFalloffAF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19303; postExpression= 19304 } |> Some
      | 6822 -> { DogmaEffectData.id= 6822; name= "rigAdvLarShipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced large ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6919 -> { DogmaEffectData.id= 6919; name= "subsystemSkillLevelMinmatarDefensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12983; postExpression= 12984 } |> Some
      | 7016 -> { DogmaEffectData.id= 7016; name= "eliteBonusGunshipExplosiveMissileDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19379; postExpression= 19380 } |> Some
      | 7210 -> { DogmaEffectData.id= 7210; name= "shipBonusCommandDestroyerRole2DefenderBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | _ -> None