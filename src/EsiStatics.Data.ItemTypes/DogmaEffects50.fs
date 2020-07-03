namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects50=
    let getDogmaEffect id = 
      match id with 
      | 1020 -> { DogmaEffectData.id= 1020; name= "selfT2LargeProjectileArtyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 244 -> { DogmaEffectData.id= 244; name= "highSpeedManuveringCapacitorNeedMultiplierPostPercentCapacitorNeedLocationShipModulesRequiringHighSpeedManuvering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2766 -> { DogmaEffectData.id= 2766; name= "boosterModifyBoosterMaxVelocityAndCapacitorPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 341 -> { DogmaEffectData.id= 341; name= "frigateConstructionFrigateConstructionTimeBonusPostPercentFrigateConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3833 -> { DogmaEffectData.id= 3833; name= "subsystemSkillLevelCaldariDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3930 -> { DogmaEffectData.id= 3930; name= "subsystemBonusMinmatarDefensiveArmorResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4415 -> { DogmaEffectData.id= 4415; name= "shipBonusMF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4512 -> { DogmaEffectData.id= 4512; name= "shipPTurretFalloffBonusGC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4803 -> { DogmaEffectData.id= 4803; name= "archaeologyAccessDifficultyBonusMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4997 -> { DogmaEffectData.id= 4997; name= "shipArmorTHResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 50 -> { DogmaEffectData.id= 50; name= "modifyShieldRechargeRate"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5191 -> { DogmaEffectData.id= 5191; name= "spaceAnchorEffect"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5288 -> { DogmaEffectData.id= 5288; name= "battlecruiserSkillLevelPreMulShipBonusGBC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5385 -> { DogmaEffectData.id= 5385; name= "shipMissileExpDamageCC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5482 -> { DogmaEffectData.id= 5482; name= "setBonusChristmasAgilityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5676 -> { DogmaEffectData.id= 5676; name= "shipBonusSmallMissileExplosionRadiusCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5870 -> { DogmaEffectData.id= 5870; name= "shipBonusShieldBoostCI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6355 -> { DogmaEffectData.id= 6355; name= "roleBonusECMCapCPU"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6549 -> { DogmaEffectData.id= 6549; name= "shipBonusForceAuxiliaryG2LocalRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6743 -> { DogmaEffectData.id= 6743; name= "npcBehaviorWebifier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6840 -> { DogmaEffectData.id= 6840; name= "rigAllShipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of all ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6937 -> { DogmaEffectData.id= 6937; name= "subsystemBonusGallenteCore3WarpScramHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7034 -> { DogmaEffectData.id= 7034; name= "shipBonusHeavyMissileExplosiveDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7228 -> { DogmaEffectData.id= 7228; name= "shipMediumPrecursorWeaponOptimalEliteHeavyGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 729 -> { DogmaEffectData.id= 729; name= "shipBonusVelocityGI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None