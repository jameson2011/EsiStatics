namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects5=
    let getDogmaEffect id = 
      match id with 
      | 102 -> { DogmaEffectData.id= 102; name= "mineLaying"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1848 -> { DogmaEffectData.id= 1848; name= "miningForemanMindlink"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3982 -> { DogmaEffectData.id= 3982; name= "subsystemBonusAmarrDefensiveArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4273 -> { DogmaEffectData.id= 4273; name= "subsystemBonusGallenteCore2WarpScrambleRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4370 -> { DogmaEffectData.id= 4370; name= "caldariShipEwFalloffRangeCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 490 -> { DogmaEffectData.id= 490; name= "engineeringPowerEngineeringOutputBonusPostPercentPowerOutputLocationShipGroupPowerCore"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5243 -> { DogmaEffectData.id= 5243; name= "shipSmallMissileEMDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5340 -> { DogmaEffectData.id= 5340; name= "shipBonusHeavyMissileKineticDamageCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5437 -> { DogmaEffectData.id= 5437; name= "archaeologySkillVirusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5631 -> { DogmaEffectData.id= 5631; name= "shipBonusCruiseMissileExploDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5825 -> { DogmaEffectData.id= 5825; name= "shipBonusKineticMissileDamageGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 587 -> { DogmaEffectData.id= 587; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupEnergyWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5922 -> { DogmaEffectData.id= 5922; name= "systemWebifierStrengthMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6310 -> { DogmaEffectData.id= 6310; name= "shipBonusExplosiveMissileDmgMD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6407 -> { DogmaEffectData.id= 6407; name= "structureRigEWCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6504 -> { DogmaEffectData.id= 6504; name= "shipBonusDreadnoughtC1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6601 -> { DogmaEffectData.id= 6601; name= "shipBonusCarrierG1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6698 -> { DogmaEffectData.id= 6698; name= "rigDrawbackReductionAstronautics"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6795 -> { DogmaEffectData.id= 6795; name= "shipBonusDroneIceHarvestingORECapital5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6892 -> { DogmaEffectData.id= 6892; name= "reactionSkillBoostManufacturingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6989 -> { DogmaEffectData.id= 6989; name= "refineryRefiningYieldBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7086 -> { DogmaEffectData.id= 7086; name= "shipbonusPCTTrackingPC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7183 -> { DogmaEffectData.id= 7183; name= "implantWarpScrambleRangeBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8056 -> { DogmaEffectData.id= 8056; name= "shipBonusUB2upwellROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 878 -> { DogmaEffectData.id= 878; name= "armorRepairForEntities"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None