namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects33=
    let getDogmaEffect id = 
      match id with 
      | 1003 -> { DogmaEffectData.id= 1003; name= "selfT2SmallLaserPulseDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1197 -> { DogmaEffectData.id= 1197; name= "shipMiningBonusORE2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5181; postExpression= 5182 } |> Some
      | 130 -> { DogmaEffectData.id= 130; name= "cheatTeleDock"; description= ""; displayName= ""; effectCategory= 2; preExpression= 1018; postExpression= 131 } |> Some
      | 1585 -> { DogmaEffectData.id= 1585; name= "capitalTurretSkillLaserDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 227 -> { DogmaEffectData.id= 227; name= "accerationControlCapNeedBonusPostPercentCapacitorNeedLocationShipGroupAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2555 -> { DogmaEffectData.id= 2555; name= "armorHpPenaltyBoosterAttribute3"; description= "Automatically generated effect"; displayName= "Armor Hitpoint Penalty"; effectCategory= 0; preExpression= 9280; postExpression= 9281 } |> Some
      | 2749 -> { DogmaEffectData.id= 2749; name= "boosterMissileExplosionVelocityPenalty"; description= "Automatically generated effect"; displayName= "Explosion Velocity Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2846 -> { DogmaEffectData.id= 2846; name= "skillBoostTrackingSpeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3040 -> { DogmaEffectData.id= 3040; name= "missileDamageMultiplierCruiseExplosiveBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10690; postExpression= 10691 } |> Some
      | 3137 -> { DogmaEffectData.id= 3137; name= "controlTowerGenericHullResistanceBonusCynoGenerator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10993; postExpression= 10994 } |> Some
      | 3234 -> { DogmaEffectData.id= 3234; name= "shipRocketExplosiveDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3331 -> { DogmaEffectData.id= 3331; name= "eliteBonusCommandShipArmorHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4010 -> { DogmaEffectData.id= 4010; name= "systemTargetPaintingAmount"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13402; postExpression= 13403 } |> Some
      | 4107 -> { DogmaEffectData.id= 4107; name= "subsystemBonusGallenteOffensiveHybridWeaponTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13718; postExpression= 13719 } |> Some
      | 4204 -> { DogmaEffectData.id= 4204; name= "subsystemSkillLevelCaldariEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4398 -> { DogmaEffectData.id= 4398; name= "shipBonusMF1TorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4689 -> { DogmaEffectData.id= 4689; name= "NPCGroupArmorAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4786 -> { DogmaEffectData.id= 4786; name= "shipEnergyNeutralizerAmountBonusATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15444; postExpression= 15445 } |> Some
      | 4980 -> { DogmaEffectData.id= 4980; name= "unusedEntityTrackingDisrupt4"; description= ""; displayName= ""; effectCategory= 2; preExpression= 16024; postExpression= 16025 } |> Some
      | 5077 -> { DogmaEffectData.id= 5077; name= "shipBonusThermicShieldResistanceORE3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16275; postExpression= 16276 } |> Some
      | 5562 -> { DogmaEffectData.id= 5562; name= "subSystemBonusAmarrDefensiveInformationWarfareHidden"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17407; postExpression= 17408 } |> Some
      | 5853 -> { DogmaEffectData.id= 5853; name= "eliteBonusExpeditionSigRadius2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6047 -> { DogmaEffectData.id= 6047; name= "shipBonusSentryArmorHPGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6144 -> { DogmaEffectData.id= 6144; name= "overloadSelfMissileGuidanceBonus5"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 615 -> { DogmaEffectData.id= 615; name= "targetedKineticResonanceMultiply"; description= ""; displayName= ""; effectCategory= 2; preExpression= 3123; postExpression= 3124 } |> Some
      | 6241 -> { DogmaEffectData.id= 6241; name= "shipBonusEnergyNeutFalloffAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6338 -> { DogmaEffectData.id= 6338; name= "shipBonusExplosiveArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6435 -> { DogmaEffectData.id= 6435; name= "fighterAbilityStasisWebifier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6629 -> { DogmaEffectData.id= 6629; name= "scriptResistanceBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6726 -> { DogmaEffectData.id= 6726; name= "shipBonusCloakCpuMF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6823 -> { DogmaEffectData.id= 6823; name= "rigAdvLarShipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced large ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6920 -> { DogmaEffectData.id= 6920; name= "structureHPBonusAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7017 -> { DogmaEffectData.id= 7017; name= "eliteBonusGunshipExplosionVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7114 -> { DogmaEffectData.id= 7114; name= "eliteBonusMaxDmgMultiBonusAddHeavyPrecursor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19554; postExpression= 19555 } |> Some
      | 7211 -> { DogmaEffectData.id= 7211; name= "shipDmgMultiMaxEliteHeavyGunship1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None