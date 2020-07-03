namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects33=
    let getDogmaEffect id = 
      match id with 
      | 1003 -> { DogmaEffectData.id= 1003; name= "selfT2SmallLaserPulseDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1585 -> { DogmaEffectData.id= 1585; name= "capitalTurretSkillLaserDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 227 -> { DogmaEffectData.id= 227; name= "accerationControlCapNeedBonusPostPercentCapacitorNeedLocationShipGroupAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2749 -> { DogmaEffectData.id= 2749; name= "boosterMissileExplosionVelocityPenalty"; description= "Automatically generated effect"; displayName= "Explosion Velocity Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2846 -> { DogmaEffectData.id= 2846; name= "skillBoostTrackingSpeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3234 -> { DogmaEffectData.id= 3234; name= "shipRocketExplosiveDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3331 -> { DogmaEffectData.id= 3331; name= "eliteBonusCommandShipArmorHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4204 -> { DogmaEffectData.id= 4204; name= "subsystemSkillLevelCaldariEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4398 -> { DogmaEffectData.id= 4398; name= "shipBonusMF1TorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4689 -> { DogmaEffectData.id= 4689; name= "NPCGroupArmorAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5853 -> { DogmaEffectData.id= 5853; name= "eliteBonusExpeditionSigRadius2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6047 -> { DogmaEffectData.id= 6047; name= "shipBonusSentryArmorHPGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6144 -> { DogmaEffectData.id= 6144; name= "overloadSelfMissileGuidanceBonus5"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 6241 -> { DogmaEffectData.id= 6241; name= "shipBonusEnergyNeutFalloffAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6338 -> { DogmaEffectData.id= 6338; name= "shipBonusExplosiveArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6435 -> { DogmaEffectData.id= 6435; name= "fighterAbilityStasisWebifier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6629 -> { DogmaEffectData.id= 6629; name= "scriptResistanceBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6726 -> { DogmaEffectData.id= 6726; name= "shipBonusCloakCpuMF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6823 -> { DogmaEffectData.id= 6823; name= "rigAdvLarShipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced large ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6920 -> { DogmaEffectData.id= 6920; name= "structureHPBonusAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7017 -> { DogmaEffectData.id= 7017; name= "eliteBonusGunshipExplosionVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7211 -> { DogmaEffectData.id= 7211; name= "shipDmgMultiMaxEliteHeavyGunship1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None