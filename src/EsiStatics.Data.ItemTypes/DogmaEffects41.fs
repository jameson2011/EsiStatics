namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects41=
    let getDogmaEffect id = 
      match id with 
      | 1011 -> { DogmaEffectData.id= 1011; name= "selfT2MediumHybridBlasterDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4480; postExpression= 4481 } |> Some
      | 1108 -> { DogmaEffectData.id= 1108; name= "controlTowerAmarrLaserDMGBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4831; postExpression= 4832 } |> Some
      | 1399 -> { DogmaEffectData.id= 1399; name= "eliteBonusCoverOpsCruiseThermalDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5795; postExpression= 5796 } |> Some
      | 1496 -> { DogmaEffectData.id= 1496; name= "relayActiveMultiplier"; description= ""; displayName= ""; effectCategory= 1; preExpression= 6087; postExpression= 6088 } |> Some
      | 1593 -> { DogmaEffectData.id= 1593; name= "capitalLauncherSkillCitadelExplosiveDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6369; postExpression= 6370 } |> Some
      | 235 -> { DogmaEffectData.id= 235; name= "warpdriveoperationWarpCapacitorNeedBonusPostPercentWarpCapacitorNeedLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1553; postExpression= 1554 } |> Some
      | 2660 -> { DogmaEffectData.id= 2660; name= "scanLadarStrengthBonusRequringAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9607; postExpression= 9608 } |> Some
      | 2757 -> { DogmaEffectData.id= 2757; name= "salvaging"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 2854 -> { DogmaEffectData.id= 2854; name= "scanResolutionBonusMultiplierPreMulPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3398; postExpression= 3399 } |> Some
      | 3145 -> { DogmaEffectData.id= 3145; name= "controlTowerGenericHullResistanceBonusProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11009; postExpression= 11010 } |> Some
      | 3242 -> { DogmaEffectData.id= 3242; name= "eliteBonusGunshipArmorThermalResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11266; postExpression= 11267 } |> Some
      | 3339 -> { DogmaEffectData.id= 3339; name= "shipArmorKineticResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11564; postExpression= 11565 } |> Some
      | 3436 -> { DogmaEffectData.id= 3436; name= "eliteBonusViolatorsTorpedoEMDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11854; postExpression= 11855 } |> Some
      | 3727 -> { DogmaEffectData.id= 3727; name= "velocityBonusPassive"; description= "Automatically generated effect"; displayName= "Max Velocity Bonus"; effectCategory= 0; preExpression= 8917; postExpression= 8918 } |> Some
      | 4018 -> { DogmaEffectData.id= 4018; name= "systemDamageEmMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13427; postExpression= 13428 } |> Some
      | 4115 -> { DogmaEffectData.id= 4115; name= "subsystemBonusMinmatarOffensiveProjectileWeaponMaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13736; postExpression= 13737 } |> Some
      | 4212 -> { DogmaEffectData.id= 4212; name= "subsystemSkillLevelCaldariPropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14007; postExpression= 14008 } |> Some
      | 429 -> { DogmaEffectData.id= 429; name= "productionEfficiencyManufactureCostBonusPostPercentManufactureCostMultiplierChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2395; postExpression= 2396 } |> Some
      | 4406 -> { DogmaEffectData.id= 4406; name= "subSystemBonusGallenteElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14448; postExpression= 14449 } |> Some
      | 4600 -> { DogmaEffectData.id= 4600; name= "gallenteFrigateSkillLevelPreMulShipBonus3GFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15063; postExpression= 15064 } |> Some
      | 4794 -> { DogmaEffectData.id= 4794; name= "shipBonusMissileLauncherAssaultROFATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15460; postExpression= 15461 } |> Some
      | 5182 -> { DogmaEffectData.id= 5182; name= "sensorCompensationSensorStrengthBonusMagnetometric"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16486; postExpression= 16487 } |> Some
      | 526 -> { DogmaEffectData.id= 526; name= "minmatarIndustrialSkillLevelPreMulShipBonusMIShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2809; postExpression= 2810 } |> Some
      | 5279 -> { DogmaEffectData.id= 5279; name= "destroyerSkillLevelPreMulShipBonusCD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16734; postExpression= 16735 } |> Some
      | 5376 -> { DogmaEffectData.id= 5376; name= "shipHeavyMissileVelocityCBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16946; postExpression= 16947 } |> Some
      | 5473 -> { DogmaEffectData.id= 5473; name= "shipBonusMineralBayGI"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17191; postExpression= 17192 } |> Some
      | 5570 -> { DogmaEffectData.id= 5570; name= "subSystemBonusMinmatarOffensiveCommandBursts"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17423; postExpression= 17424 } |> Some
      | 5958 -> { DogmaEffectData.id= 5958; name= "shipHybridTrackingGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18381; postExpression= 18382 } |> Some
      | 6055 -> { DogmaEffectData.id= 6055; name= "shipBonusHeavyDroneArmorHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18613; postExpression= 18614 } |> Some
      | 6152 -> { DogmaEffectData.id= 6152; name= "shipModeSHTOptimalRangePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18518; postExpression= 18519 } |> Some
      | 623 -> { DogmaEffectData.id= 623; name= "miningDroneOperationMiningAmountBonusPostPercentMiningDroneAmountPercentChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3153; postExpression= 3154 } |> Some
      | 6346 -> { DogmaEffectData.id= 6346; name= "scriptStasisWebifierSpeedFactorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6443 -> { DogmaEffectData.id= 6443; name= "pointDefense"; description= ""; displayName= ""; effectCategory= 1; preExpression= 288; postExpression= 131 } |> Some
      | 6637 -> { DogmaEffectData.id= 6637; name= "shipBonusTitanM1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6734 -> { DogmaEffectData.id= 6734; name= "moduleBonusWarfareLinkSkirmish"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6831 -> { DogmaEffectData.id= 6831; name= "rigInventionTimeBonus"; description= "Structure Rig Time effect on Invention"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6928 -> { DogmaEffectData.id= 6928; name= "subsystemBonusCaldariPropulsion2PropModHeatBenefit"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13091; postExpression= 13092 } |> Some
      | 7025 -> { DogmaEffectData.id= 7025; name= "eliteBonusGunshipExplosionRadius2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19390; postExpression= 19391 } |> Some
      | 720 -> { DogmaEffectData.id= 720; name= "sensorBoosterActive"; description= ""; displayName= "sensorBoosterActivated"; effectCategory= 1; preExpression= 3527; postExpression= 3528 } |> Some
      | 914 -> { DogmaEffectData.id= 914; name= "shipMiningYieldCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4170; postExpression= 4171 } |> Some
      | _ -> None