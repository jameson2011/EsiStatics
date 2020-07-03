namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects41=
    let getDogmaEffect id = 
      match id with 
      | 1011 -> { DogmaEffectData.id= 1011; name= "selfT2MediumHybridBlasterDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1108 -> { DogmaEffectData.id= 1108; name= "controlTowerAmarrLaserDMGBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1593 -> { DogmaEffectData.id= 1593; name= "capitalLauncherSkillCitadelExplosiveDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 235 -> { DogmaEffectData.id= 235; name= "warpdriveoperationWarpCapacitorNeedBonusPostPercentWarpCapacitorNeedLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2757 -> { DogmaEffectData.id= 2757; name= "salvaging"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3242 -> { DogmaEffectData.id= 3242; name= "eliteBonusGunshipArmorThermalResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3339 -> { DogmaEffectData.id= 3339; name= "shipArmorKineticResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3727 -> { DogmaEffectData.id= 3727; name= "velocityBonusPassive"; description= "Automatically generated effect"; displayName= "Max Velocity Bonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4018 -> { DogmaEffectData.id= 4018; name= "systemDamageEmMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4115 -> { DogmaEffectData.id= 4115; name= "subsystemBonusMinmatarOffensiveProjectileWeaponMaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4212 -> { DogmaEffectData.id= 4212; name= "subsystemSkillLevelCaldariPropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4406 -> { DogmaEffectData.id= 4406; name= "subSystemBonusGallenteElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4600 -> { DogmaEffectData.id= 4600; name= "gallenteFrigateSkillLevelPreMulShipBonus3GFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4794 -> { DogmaEffectData.id= 4794; name= "shipBonusMissileLauncherAssaultROFATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5182 -> { DogmaEffectData.id= 5182; name= "sensorCompensationSensorStrengthBonusMagnetometric"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 526 -> { DogmaEffectData.id= 526; name= "minmatarIndustrialSkillLevelPreMulShipBonusMIShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5279 -> { DogmaEffectData.id= 5279; name= "destroyerSkillLevelPreMulShipBonusCD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5570 -> { DogmaEffectData.id= 5570; name= "subSystemBonusMinmatarOffensiveCommandBursts"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5958 -> { DogmaEffectData.id= 5958; name= "shipHybridTrackingGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6055 -> { DogmaEffectData.id= 6055; name= "shipBonusHeavyDroneArmorHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6152 -> { DogmaEffectData.id= 6152; name= "shipModeSHTOptimalRangePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 623 -> { DogmaEffectData.id= 623; name= "miningDroneOperationMiningAmountBonusPostPercentMiningDroneAmountPercentChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6443 -> { DogmaEffectData.id= 6443; name= "pointDefense"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6637 -> { DogmaEffectData.id= 6637; name= "shipBonusTitanM1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6734 -> { DogmaEffectData.id= 6734; name= "moduleBonusWarfareLinkSkirmish"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6831 -> { DogmaEffectData.id= 6831; name= "rigInventionTimeBonus"; description= "Structure Rig Time effect on Invention"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6928 -> { DogmaEffectData.id= 6928; name= "subsystemBonusCaldariPropulsion2PropModHeatBenefit"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None