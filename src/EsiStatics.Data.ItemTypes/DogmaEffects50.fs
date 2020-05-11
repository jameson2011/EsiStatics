namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects50=
    let getDogmaEffect id = 
      match id with 
      | 1020 -> { DogmaEffectData.id= 1020; name= "selfT2LargeProjectileArtyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4534; postExpression= 4535 } |> Some
      | 1117 -> { DogmaEffectData.id= 1117; name= "shipArmorThermResistanceABC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4882; postExpression= 4883 } |> Some
      | 244 -> { DogmaEffectData.id= 244; name= "highSpeedManuveringCapacitorNeedMultiplierPostPercentCapacitorNeedLocationShipModulesRequiringHighSpeedManuvering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1597; postExpression= 1598 } |> Some
      | 2766 -> { DogmaEffectData.id= 2766; name= "boosterModifyBoosterMaxVelocityAndCapacitorPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9901; postExpression= 9902 } |> Some
      | 2863 -> { DogmaEffectData.id= 2863; name= "agilityBonusOnTargetPercentage"; description= ""; displayName= ""; effectCategory= 2; preExpression= 10130; postExpression= 10131 } |> Some
      | 3154 -> { DogmaEffectData.id= 3154; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN&H&JP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11025; postExpression= 11026 } |> Some
      | 3348 -> { DogmaEffectData.id= 3348; name= "shipShieldExplosiveResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11592; postExpression= 11593 } |> Some
      | 341 -> { DogmaEffectData.id= 341; name= "frigateConstructionFrigateConstructionTimeBonusPostPercentFrigateConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2026; postExpression= 2027 } |> Some
      | 3542 -> { DogmaEffectData.id= 3542; name= "targetEnergyWeaponTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12195; postExpression= 12196 } |> Some
      | 3833 -> { DogmaEffectData.id= 3833; name= "subsystemSkillLevelCaldariDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12973; postExpression= 12974 } |> Some
      | 3930 -> { DogmaEffectData.id= 3930; name= "subsystemBonusMinmatarDefensiveArmorResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13225; postExpression= 13226 } |> Some
      | 4027 -> { DogmaEffectData.id= 4027; name= "systemRemoteEccmGrav"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13460; postExpression= 13461 } |> Some
      | 4124 -> { DogmaEffectData.id= 4124; name= "subsystemBonusCaldariOffensiveHeavyMissileFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13754; postExpression= 13755 } |> Some
      | 4221 -> { DogmaEffectData.id= 4221; name= "subsystemBonusCaldariElectronicRadarECMStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14031; postExpression= 14032 } |> Some
      | 4415 -> { DogmaEffectData.id= 4415; name= "shipBonusMF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14475; postExpression= 14476 } |> Some
      | 4512 -> { DogmaEffectData.id= 4512; name= "shipPTurretFalloffBonusGC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14778; postExpression= 14779 } |> Some
      | 4706 -> { DogmaEffectData.id= 4706; name= "systemEffectDamageExplosiveSmartbombs"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15278; postExpression= 15279 } |> Some
      | 4803 -> { DogmaEffectData.id= 4803; name= "archaeologyAccessDifficultyBonusMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15484; postExpression= 15485 } |> Some
      | 4900 -> { DogmaEffectData.id= 4900; name= "shipSETTrackingBonusAF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 4797; postExpression= 4798 } |> Some
      | 4997 -> { DogmaEffectData.id= 4997; name= "shipArmorTHResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16069; postExpression= 16070 } |> Some
      | 50 -> { DogmaEffectData.id= 50; name= "modifyShieldRechargeRate"; description= ""; displayName= ""; effectCategory= 4; preExpression= 439; postExpression= 440 } |> Some
      | 5094 -> { DogmaEffectData.id= 5094; name= "passiveThermicShieldResonanceBonusGroupShieldHardener2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16307; postExpression= 16308 } |> Some
      | 5191 -> { DogmaEffectData.id= 5191; name= "spaceAnchorEffect"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16518; postExpression= 16519 } |> Some
      | 5288 -> { DogmaEffectData.id= 5288; name= "battlecruiserSkillLevelPreMulShipBonusGBC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16771; postExpression= 16772 } |> Some
      | 5385 -> { DogmaEffectData.id= 5385; name= "shipMissileExpDamageCC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16962; postExpression= 16963 } |> Some
      | 5482 -> { DogmaEffectData.id= 5482; name= "setBonusChristmasAgilityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17215; postExpression= 17216 } |> Some
      | 5676 -> { DogmaEffectData.id= 5676; name= "shipBonusSmallMissileExplosionRadiusCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17653; postExpression= 17654 } |> Some
      | 5870 -> { DogmaEffectData.id= 5870; name= "shipBonusShieldBoostCI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 5466; postExpression= 5467 } |> Some
      | 6064 -> { DogmaEffectData.id= 6064; name= "shipBonusLightMissileEMDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18629; postExpression= 18630 } |> Some
      | 6258 -> { DogmaEffectData.id= 6258; name= "shipBonusEnergyNosOptimalAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19037; postExpression= 19038 } |> Some
      | 6355 -> { DogmaEffectData.id= 6355; name= "roleBonusECMCapCPU"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19216; postExpression= 19217 } |> Some
      | 6549 -> { DogmaEffectData.id= 6549; name= "shipBonusForceAuxiliaryG2LocalRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6743 -> { DogmaEffectData.id= 6743; name= "npcBehaviorWebifier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6840 -> { DogmaEffectData.id= 6840; name= "rigAllShipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of all ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6937 -> { DogmaEffectData.id= 6937; name= "subsystemBonusGallenteCore3WarpScramHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14147; postExpression= 14148 } |> Some
      | 7034 -> { DogmaEffectData.id= 7034; name= "shipBonusHeavyMissileExplosiveDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19398; postExpression= 19399 } |> Some
      | 7228 -> { DogmaEffectData.id= 7228; name= "shipMediumPrecursorWeaponOptimalEliteHeavyGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19846; postExpression= 19847 } |> Some
      | 729 -> { DogmaEffectData.id= 729; name= "shipBonusVelocityGI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3553; postExpression= 3554 } |> Some
      | 923 -> { DogmaEffectData.id= 923; name= "shipMiningYieldMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4196; postExpression= 4197 } |> Some
      | _ -> None