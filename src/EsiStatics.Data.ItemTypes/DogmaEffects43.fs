namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects43=
    let getDogmaEffect id = 
      match id with 
      | 1013 -> { DogmaEffectData.id= 1013; name= "selfT2MediumProjectileACDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4492; postExpression= 4493 } |> Some
      | 1595 -> { DogmaEffectData.id= 1595; name= "missileSkillWarheadUpgradesEmDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6375; postExpression= 6376 } |> Some
      | 1886 -> { DogmaEffectData.id= 1886; name= "shipSiegeLauncherROFBonus2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7236; postExpression= 7237 } |> Some
      | 2662 -> { DogmaEffectData.id= 2662; name= "entityEnvironmentalEffectDamageTest"; description= ""; displayName= ""; effectCategory= 1; preExpression= 288; postExpression= 131 } |> Some
      | 3244 -> { DogmaEffectData.id= 3244; name= "eliteBonusGunshipArmorExplosiveResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11270; postExpression= 11271 } |> Some
      | 334 -> { DogmaEffectData.id= 334; name= "cSOTrainingSkillBoostResearchGangSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1995; postExpression= 1996 } |> Some
      | 4020 -> { DogmaEffectData.id= 4020; name= "systemDamageKineticMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13431; postExpression= 13432 } |> Some
      | 4214 -> { DogmaEffectData.id= 4214; name= "subsystemSkillLevelMinmatarPropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14017; postExpression= 14018 } |> Some
      | 431 -> { DogmaEffectData.id= 431; name= "scienceCopySpeedBonusPostPercentCopySpeedPercentChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2404; postExpression= 2405 } |> Some
      | 4408 -> { DogmaEffectData.id= 4408; name= "subSystemBonusAmarrElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14452; postExpression= 14453 } |> Some
      | 4990 -> { DogmaEffectData.id= 4990; name= "shipEnergyTCapNeedBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16052; postExpression= 16053 } |> Some
      | 5087 -> { DogmaEffectData.id= 5087; name= "shipBonusDroneHitpointsGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16292; postExpression= 16293 } |> Some
      | 5281 -> { DogmaEffectData.id= 5281; name= "destroyerSkillLevelPreMulShipBonusGD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16742; postExpression= 16743 } |> Some
      | 5378 -> { DogmaEffectData.id= 5378; name= "shipHeavyMissileAOECloudSizeCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16950; postExpression= 16951 } |> Some
      | 5572 -> { DogmaEffectData.id= 5572; name= "eliteBonusCommandShipArmoredCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17430; postExpression= 17431 } |> Some
      | 5863 -> { DogmaEffectData.id= 5863; name= "shipMissileKinDamageCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18118; postExpression= 18119 } |> Some
      | 6057 -> { DogmaEffectData.id= 6057; name= "shipBonusMediumDroneShieldHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18617; postExpression= 18618 } |> Some
      | 6154 -> { DogmaEffectData.id= 6154; name= "modeMWDBoostPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18857; postExpression= 18858 } |> Some
      | 6348 -> { DogmaEffectData.id= 6348; name= "setFixedResonance"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6445 -> { DogmaEffectData.id= 6445; name= "tractorBeamShip"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6639 -> { DogmaEffectData.id= 6639; name= "shipBonusSupercarrierA4FighterApplicationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6736 -> { DogmaEffectData.id= 6736; name= "moduleBonusWarfareLinkMining"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6833 -> { DogmaEffectData.id= 6833; name= "rigMEResearchTimeBonus"; description= "Structure Rig Material effect on Manufacturing of equipment"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6930 -> { DogmaEffectData.id= 6930; name= "subsystemBonusAmarrCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13826; postExpression= 13827 } |> Some
      | 7027 -> { DogmaEffectData.id= 7027; name= "structureCapacitorCapacityBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 227; postExpression= 228 } |> Some
      | 7124 -> { DogmaEffectData.id= 7124; name= "moduleStasisImpedence"; description= ""; displayName= ""; effectCategory= 1; preExpression= 19582; postExpression= 19583 } |> Some
      | _ -> None