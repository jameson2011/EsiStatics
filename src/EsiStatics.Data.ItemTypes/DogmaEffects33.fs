namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects33=
    let getDogmaEffect id = 
      match id with 
      | 1003 -> { DogmaEffectData.id= 1003; name= "selfT2SmallLaserPulseDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4434; postExpression= 4435 } |> Some
      | 1585 -> { DogmaEffectData.id= 1585; name= "capitalTurretSkillLaserDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6338; postExpression= 6339 } |> Some
      | 227 -> { DogmaEffectData.id= 227; name= "accerationControlCapNeedBonusPostPercentCapacitorNeedLocationShipGroupAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1516; postExpression= 1517 } |> Some
      | 2749 -> { DogmaEffectData.id= 2749; name= "boosterMissileExplosionVelocityPenalty"; description= "Automatically generated effect"; displayName= "Explosion Velocity Penalty"; effectCategory= 0; preExpression= 9853; postExpression= 9854 } |> Some
      | 2846 -> { DogmaEffectData.id= 2846; name= "skillBoostTrackingSpeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10091; postExpression= 10092 } |> Some
      | 3234 -> { DogmaEffectData.id= 3234; name= "shipRocketExplosiveDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11250; postExpression= 11251 } |> Some
      | 3331 -> { DogmaEffectData.id= 3331; name= "eliteBonusCommandShipArmorHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11549; postExpression= 11550 } |> Some
      | 4204 -> { DogmaEffectData.id= 4204; name= "subsystemSkillLevelCaldariEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13967; postExpression= 13968 } |> Some
      | 4398 -> { DogmaEffectData.id= 4398; name= "shipBonusMF1TorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14432; postExpression= 14433 } |> Some
      | 4689 -> { DogmaEffectData.id= 4689; name= "NPCGroupArmorAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 89 } |> Some
      | 5853 -> { DogmaEffectData.id= 5853; name= "eliteBonusExpeditionSigRadius2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18095; postExpression= 18096 } |> Some
      | 6047 -> { DogmaEffectData.id= 6047; name= "shipBonusSentryArmorHPGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18597; postExpression= 18598 } |> Some
      | 6144 -> { DogmaEffectData.id= 6144; name= "overloadSelfMissileGuidanceBonus5"; description= ""; displayName= ""; effectCategory= 5; preExpression= 18828; postExpression= 18829 } |> Some
      | 6241 -> { DogmaEffectData.id= 6241; name= "shipBonusEnergyNeutFalloffAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18997; postExpression= 18998 } |> Some
      | 6338 -> { DogmaEffectData.id= 6338; name= "shipBonusExplosiveArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19200; postExpression= 19201 } |> Some
      | 6435 -> { DogmaEffectData.id= 6435; name= "fighterAbilityStasisWebifier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6629 -> { DogmaEffectData.id= 6629; name= "scriptResistanceBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19277; postExpression= 19278 } |> Some
      | 6726 -> { DogmaEffectData.id= 6726; name= "shipBonusCloakCpuMF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19301; postExpression= 19302 } |> Some
      | 6823 -> { DogmaEffectData.id= 6823; name= "rigAdvLarShipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced large ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6920 -> { DogmaEffectData.id= 6920; name= "structureHPBonusAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10069; postExpression= 10070 } |> Some
      | 7017 -> { DogmaEffectData.id= 7017; name= "eliteBonusGunshipExplosionVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19381; postExpression= 19382 } |> Some
      | 7211 -> { DogmaEffectData.id= 7211; name= "shipDmgMultiMaxEliteHeavyGunship1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19809; postExpression= 19810 } |> Some
      | _ -> None