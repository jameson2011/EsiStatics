﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects39=
    let getDogmaEffect id = 
      match id with 
      | 1009 -> { DogmaEffectData.id= 1009; name= "selfT2MediumLaserPulseDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1203 -> { DogmaEffectData.id= 1203; name= "controlTowerCaldariMissileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1397 -> { DogmaEffectData.id= 1397; name= "setBonusGuristas"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1882 -> { DogmaEffectData.id= 1882; name= "miningYieldMultiplyPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2561 -> { DogmaEffectData.id= 2561; name= "eliteBonusAssaultShipMissileVelocity1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2852 -> { DogmaEffectData.id= 2852; name= "maxTargetingRangeBonusPremulPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3046 -> { DogmaEffectData.id= 3046; name= "modifyMaxVelocityOfShipPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 39 -> { DogmaEffectData.id= 39; name= "warpDisrupt"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 4016 -> { DogmaEffectData.id= 4016; name= "systemDamageMultiplierGunnery"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4210 -> { DogmaEffectData.id= 4210; name= "subsystemSkillLevelAmarrOffensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4404 -> { DogmaEffectData.id= 4404; name= "subSystemBonusMinmatarElectronic2TractorBeamVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4598 -> { DogmaEffectData.id= 4598; name= "amarrFrigateSkillLevelPreMulShipBonus3AFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5180 -> { DogmaEffectData.id= 5180; name= "sensorCompensationSensorStrengthBonusGravimetric"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 524 -> { DogmaEffectData.id= 524; name= "minmatarCruiserSkillLevelPreMulShipBonusMCShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5277 -> { DogmaEffectData.id= 5277; name= "destroyerSkillLevelPreMulShipBonusAD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5471 -> { DogmaEffectData.id= 5471; name= "shipBonusAgilityAI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5568 -> { DogmaEffectData.id= 5568; name= "subSystemBonusGallenteOffensiveCommandBursts"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5956 -> { DogmaEffectData.id= 5956; name= "shipMETDamageBonusAC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6053 -> { DogmaEffectData.id= 6053; name= "shipBonusHeavyDroneDamageMultiplierGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6150 -> { DogmaEffectData.id= 6150; name= "shipSHTTrackingGallenteTacticalDestroyer2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6441 -> { DogmaEffectData.id= 6441; name= "fighterAbilityMicroWarpDrive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6635 -> { DogmaEffectData.id= 6635; name= "shipBonusTitanC1KinDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6732 -> { DogmaEffectData.id= 6732; name= "moduleBonusWarfareLinkArmor"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6829 -> { DogmaEffectData.id= 6829; name= "rigStructureManufactureTimeBonus"; description= "Structure Rig time effect on Manufacturing of structures"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6926 -> { DogmaEffectData.id= 6926; name= "subsystemBonusAmarrPropulsionWarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7023 -> { DogmaEffectData.id= 7023; name= "structureShieldResonanceBonusPostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 7120 -> { DogmaEffectData.id= 7120; name= "structureCynoJammerOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 912 -> { DogmaEffectData.id= 912; name= "shipMissileLauncherRofCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None