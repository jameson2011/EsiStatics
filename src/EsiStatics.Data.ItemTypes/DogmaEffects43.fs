namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects43=
    let getDogmaEffect id = 
      match id with 
      | 1013 -> { DogmaEffectData.id= 1013; name= "selfT2MediumProjectileACDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1110 -> { DogmaEffectData.id= 1110; name= "shipProjectileRofMBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4858; postExpression= 4859 } |> Some
      | 1304 -> { DogmaEffectData.id= 1304; name= "eliteIndustrialShieldBoostAmountElite1"; description= "Automatically generated effect"; displayName= "eliteIndustrialShieldBoostAmountMI1"; effectCategory= 0; preExpression= 5474; postExpression= 5475 } |> Some
      | 1401 -> { DogmaEffectData.id= 1401; name= "eliteBonusCoverOpsCruiseLauncherPowerNeed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5802; postExpression= 5803 } |> Some
      | 1498 -> { DogmaEffectData.id= 1498; name= "masterAndCommander2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6076; postExpression= 6077 } |> Some
      | 1595 -> { DogmaEffectData.id= 1595; name= "missileSkillWarheadUpgradesEmDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1886 -> { DogmaEffectData.id= 1886; name= "shipSiegeLauncherROFBonus2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2468 -> { DogmaEffectData.id= 2468; name= "shipHeavyLauncherROFBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9055; postExpression= 9056 } |> Some
      | 2565 -> { DogmaEffectData.id= 2565; name= "turretFalloffPenaltyBoosterAttribute4"; description= "Automatically generated effect"; displayName= "Turret Falloff Penalty"; effectCategory= 0; preExpression= 9314; postExpression= 9315 } |> Some
      | 2662 -> { DogmaEffectData.id= 2662; name= "entityEnvironmentalEffectDamageTest"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2759 -> { DogmaEffectData.id= 2759; name= "boosterModifyBoosterArmorRepairAmountPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9879; postExpression= 9880 } |> Some
      | 2856 -> { DogmaEffectData.id= 2856; name= "setCanCloak"; description= ""; displayName= ""; effectCategory= 1; preExpression= 10122; postExpression= 10123 } |> Some
      | 3244 -> { DogmaEffectData.id= 3244; name= "eliteBonusGunshipArmorExplosiveResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 334 -> { DogmaEffectData.id= 334; name= "cSOTrainingSkillBoostResearchGangSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3341 -> { DogmaEffectData.id= 3341; name= "shipArmorThermalResistanceGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11568; postExpression= 11569 } |> Some
      | 3438 -> { DogmaEffectData.id= 3438; name= "shipBonusCruiseMissileKineticDamageCB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11858; postExpression= 11859 } |> Some
      | 3729 -> { DogmaEffectData.id= 3729; name= "boostersShieldBoostAmountPenalty"; description= "Changes the shield boost amount by a percentage"; displayName= "Shield Boost Penalty"; effectCategory= 0; preExpression= 6717; postExpression= 6718 } |> Some
      | 4020 -> { DogmaEffectData.id= 4020; name= "systemDamageKineticMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4117 -> { DogmaEffectData.id= 4117; name= "subsystemBonusCaldariOffensiveHeavyAssaultMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13740; postExpression= 13741 } |> Some
      | 4214 -> { DogmaEffectData.id= 4214; name= "subsystemSkillLevelMinmatarPropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 431 -> { DogmaEffectData.id= 431; name= "scienceCopySpeedBonusPostPercentCopySpeedPercentChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4408 -> { DogmaEffectData.id= 4408; name= "subSystemBonusAmarrElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4699 -> { DogmaEffectData.id= 4699; name= "systemEffectDamageDrones"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15262; postExpression= 15263 } |> Some
      | 4796 -> { DogmaEffectData.id= 4796; name= "shipBonusArmorRepairBonusATC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15464; postExpression= 15465 } |> Some
      | 4990 -> { DogmaEffectData.id= 4990; name= "shipEnergyTCapNeedBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5087 -> { DogmaEffectData.id= 5087; name= "shipBonusDroneHitpointsGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5281 -> { DogmaEffectData.id= 5281; name= "destroyerSkillLevelPreMulShipBonusGD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5378 -> { DogmaEffectData.id= 5378; name= "shipHeavyMissileAOECloudSizeCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5475 -> { DogmaEffectData.id= 5475; name= "shipBonusPICommoditiesHoldGI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17198; postExpression= 17199 } |> Some
      | 5572 -> { DogmaEffectData.id= 5572; name= "eliteBonusCommandShipArmoredCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5863 -> { DogmaEffectData.id= 5863; name= "shipMissileKinDamageCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6057 -> { DogmaEffectData.id= 6057; name= "shipBonusMediumDroneShieldHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6154 -> { DogmaEffectData.id= 6154; name= "modeMWDBoostPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6348 -> { DogmaEffectData.id= 6348; name= "setFixedResonance"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6445 -> { DogmaEffectData.id= 6445; name= "tractorBeamShip"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6639 -> { DogmaEffectData.id= 6639; name= "shipBonusSupercarrierA4FighterApplicationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6736 -> { DogmaEffectData.id= 6736; name= "moduleBonusWarfareLinkMining"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6833 -> { DogmaEffectData.id= 6833; name= "rigMEResearchTimeBonus"; description= "Structure Rig Material effect on Manufacturing of equipment"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6930 -> { DogmaEffectData.id= 6930; name= "subsystemBonusAmarrCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7027 -> { DogmaEffectData.id= 7027; name= "structureCapacitorCapacityBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 7124 -> { DogmaEffectData.id= 7124; name= "moduleStasisImpedence"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7221 -> { DogmaEffectData.id= 7221; name= "shipNosPowerReductionEliteHeavyGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19836; postExpression= 19837 } |> Some
      | _ -> None