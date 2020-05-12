namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects36=
    let getDogmaEffect id = 
      match id with 
      | 1006 -> { DogmaEffectData.id= 1006; name= "selfT2SmallHybridRailDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1200 -> { DogmaEffectData.id= 1200; name= "miningInfoMultiplier"; description= "Automatically generated effect"; displayName= "MiningInfoMultiplier"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1394 -> { DogmaEffectData.id= 1394; name= "covertOpsStealthBomberCruiseLauncerPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5777; postExpression= 5778 } |> Some
      | 1588 -> { DogmaEffectData.id= 1588; name= "capitalLauncherSkillCitadelKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1879 -> { DogmaEffectData.id= 1879; name= "entityTargetPaint"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 230 -> { DogmaEffectData.id= 230; name= "afterburnerDurationBonusPostPercentDurationLocationShipModulesRequiringAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2558 -> { DogmaEffectData.id= 2558; name= "missileVelocityPenaltyBoosterAttribute5"; description= "Automatically generated effect"; displayName= "Missile Velocity Penalty"; effectCategory= 0; preExpression= 9290; postExpression= 9291 } |> Some
      | 2752 -> { DogmaEffectData.id= 2752; name= "shipBonusECMRadarBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9859; postExpression= 9860 } |> Some
      | 2849 -> { DogmaEffectData.id= 2849; name= "accessDifficultyBonusModifierRequiringHacking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3140 -> { DogmaEffectData.id= 3140; name= "controlTowerGenericHullResistanceBonusEnergyNeutralizer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10999; postExpression= 11000 } |> Some
      | 3237 -> { DogmaEffectData.id= 3237; name= "shipRocketEmDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3334 -> { DogmaEffectData.id= 3334; name= "shipArmorEmResistanceGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11554; postExpression= 11555 } |> Some
      | 3431 -> { DogmaEffectData.id= 3431; name= "eliteBonusViolatorsCruiseMissileKineticDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11844; postExpression= 11845 } |> Some
      | 3528 -> { DogmaEffectData.id= 3528; name= "drawbackCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 36 -> { DogmaEffectData.id= 36; name= "energyDestabilization"; description= ""; displayName= ""; effectCategory= 2; preExpression= 286; postExpression= 131 } |> Some
      | 4013 -> { DogmaEffectData.id= 4013; name= "systemSensorDampenerScanResolution"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13412; postExpression= 13413 } |> Some
      | 4110 -> { DogmaEffectData.id= 4110; name= "subsystemBonusMinmatarOffensiveProjectileWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13724; postExpression= 13725 } |> Some
      | 4207 -> { DogmaEffectData.id= 4207; name= "subsystemSkillLevelMinmatarOffensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4401 -> { DogmaEffectData.id= 4401; name= "subSystemBonusAmarrElectronic2TractorBeamVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4595 -> { DogmaEffectData.id= 4595; name= "shipBonusSurveyProbeExplosionDelay3CF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15045; postExpression= 15046 } |> Some
      | 4789 -> { DogmaEffectData.id= 4789; name= "shipBonusSmallEnergyTurretDamageATF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5080 -> { DogmaEffectData.id= 5080; name= "shipMissileVelocityCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 521 -> { DogmaEffectData.id= 521; name= "shipHRangeBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5371 -> { DogmaEffectData.id= 5371; name= "entityShieldBoosting"; description= "Entity shield boosting effect for tanking NPCs"; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5468 -> { DogmaEffectData.id= 5468; name= "shipBonusAgilityCI2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5565 -> { DogmaEffectData.id= 5565; name= "subSystemBonusCaldariDefensiveInformationWarfareHidden"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17413; postExpression= 17414 } |> Some
      | 6050 -> { DogmaEffectData.id= 6050; name= "shipBonusSentryHPGC3_F"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18603; postExpression= 18604 } |> Some
      | 6147 -> { DogmaEffectData.id= 6147; name= "tacticalDestroyerGallenteSkillLevel3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6244 -> { DogmaEffectData.id= 6244; name= "shipBonusEnergyNosOptimalAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19003; postExpression= 19004 } |> Some
      | 6341 -> { DogmaEffectData.id= 6341; name= "shipBonusEMArmorResistanceGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6438 -> { DogmaEffectData.id= 6438; name= "fighterAbilityDamageBoost"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6535 -> { DogmaEffectData.id= 6535; name= "shipBonusForceAuxiliaryG4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6632 -> { DogmaEffectData.id= 6632; name= "skillMultiplierShipBonusTitanGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6826 -> { DogmaEffectData.id= 6826; name= "rigBasCapCompManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of Basic Capital Components"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6923 -> { DogmaEffectData.id= 6923; name= "subsystemBonusMinmatarOffensive1HMLHAMVelo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7020 -> { DogmaEffectData.id= 7020; name= "remoteWebifierMaxRangeBonus"; description= "Stasis Webifier increase max range"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7117 -> { DogmaEffectData.id= 7117; name= "roleBonusWarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7214 -> { DogmaEffectData.id= 7214; name= "shipArmorKinresistanceEliteHeavyGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19815; postExpression= 19816 } |> Some
      | 909 -> { DogmaEffectData.id= 909; name= "shipArmorHpAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None