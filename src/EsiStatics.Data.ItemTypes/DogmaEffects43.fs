namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects43=
    let getDogmaEffect id = 
      match id with 
      | 1013 -> { DogmaEffectData.id= 1013; name= "selfT2MediumProjectileACDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1595 -> { DogmaEffectData.id= 1595; name= "missileSkillWarheadUpgradesEmDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1886 -> { DogmaEffectData.id= 1886; name= "shipSiegeLauncherROFBonus2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2662 -> { DogmaEffectData.id= 2662; name= "entityEnvironmentalEffectDamageTest"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 3244 -> { DogmaEffectData.id= 3244; name= "eliteBonusGunshipArmorExplosiveResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 334 -> { DogmaEffectData.id= 334; name= "cSOTrainingSkillBoostResearchGangSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4020 -> { DogmaEffectData.id= 4020; name= "systemDamageKineticMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4214 -> { DogmaEffectData.id= 4214; name= "subsystemSkillLevelMinmatarPropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 431 -> { DogmaEffectData.id= 431; name= "scienceCopySpeedBonusPostPercentCopySpeedPercentChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4408 -> { DogmaEffectData.id= 4408; name= "subSystemBonusAmarrElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4990 -> { DogmaEffectData.id= 4990; name= "shipEnergyTCapNeedBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5087 -> { DogmaEffectData.id= 5087; name= "shipBonusDroneHitpointsGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5281 -> { DogmaEffectData.id= 5281; name= "destroyerSkillLevelPreMulShipBonusGD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5378 -> { DogmaEffectData.id= 5378; name= "shipHeavyMissileAOECloudSizeCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
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
      | _ -> None