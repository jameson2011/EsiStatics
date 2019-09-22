﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects12=
    let getDogmaEffect id = 
      match id with 
      | 1079 -> { DogmaEffectData.id= 1079; name= "warshipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4730; postExpression= 4731 } |> Some
      | 109 -> { DogmaEffectData.id= 109; name= "turretWeaponCapacitorNeedMultiply"; description= "Scales the capacitor need for all the fitted turret weapons."; displayName= "turretWeaponCapacitorMultiply"; effectCategory= 0; preExpression= 743; postExpression= 745 } |> Some
      | 1176 -> { DogmaEffectData.id= 1176; name= "accerationControlSkillAb&MwdSpeedBoost"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5113; postExpression= 5114 } |> Some
      | 12 -> { DogmaEffectData.id= 12; name= "hiPower"; description= "Requires a high power slot."; displayName= "High power"; effectCategory= 0; preExpression= 131; postExpression= 131 } |> Some
      | 1370 -> { DogmaEffectData.id= 1370; name= "ewSkillTpCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5686; postExpression= 5687 } |> Some
      | 1467 -> { DogmaEffectData.id= 1467; name= "missileSkillAoeVelocityBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5982; postExpression= 5983 } |> Some
      | 1661 -> { DogmaEffectData.id= 1661; name= "freighterC1SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6594; postExpression= 6595 } |> Some
      | 206 -> { DogmaEffectData.id= 206; name= "longRangeTargetingSkillBoostMaxTargetRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1412; postExpression= 1413 } |> Some
      | 3601 -> { DogmaEffectData.id= 3601; name= "scriptWarpDisruptionFieldGeneratorSetDisallowInEmpireSpace"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12348; postExpression= 12349 } |> Some
      | 3698 -> { DogmaEffectData.id= 3698; name= "dungeonMaxTargetingRangeShip"; description= ""; displayName= ""; effectCategory= 6; preExpression= 9627; postExpression= 9628 } |> Some
      | 3795 -> { DogmaEffectData.id= 3795; name= "dungeonMiningLaserDurationBonus"; description= ""; displayName= ""; effectCategory= 6; preExpression= 2227; postExpression= 2228 } |> Some
      | 4086 -> { DogmaEffectData.id= 4086; name= "systemArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13661; postExpression= 13662 } |> Some
      | 4280 -> { DogmaEffectData.id= 4280; name= "systemAgility"; description= ""; displayName= ""; effectCategory= 7; preExpression= 566; postExpression= 567 } |> Some
      | 4377 -> { DogmaEffectData.id= 4377; name= "shipBonusTorpedoVelocityGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14385; postExpression= 14386 } |> Some
      | 4474 -> { DogmaEffectData.id= 4474; name= "shipMTMaxRangeBonusATC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14672; postExpression= 14673 } |> Some
      | 4668 -> { DogmaEffectData.id= 4668; name= "shipBonusNoctisTractorCycle"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15207; postExpression= 15208 } |> Some
      | 5056 -> { DogmaEffectData.id= 5056; name= "iceHarvesterCapacitorNeedMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16219; postExpression= 16220 } |> Some
      | 5153 -> { DogmaEffectData.id= 5153; name= "shipMissileVelocityPirateFactionRocket"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16429; postExpression= 16430 } |> Some
      | 5444 -> { DogmaEffectData.id= 5444; name= "shipTorpedoAOECloudSize1CB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17098; postExpression= 17099 } |> Some
      | 5541 -> { DogmaEffectData.id= 5541; name= "shipBonusHMLThermDamageAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17356; postExpression= 17357 } |> Some
      | 5638 -> { DogmaEffectData.id= 5638; name= "shipBonusHeavyMissileKineticDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17576; postExpression= 17577 } |> Some
      | 5735 -> { DogmaEffectData.id= 5735; name= "eliteBonusMaraudersHeavyMissileDamageEMRole1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17772; postExpression= 17773 } |> Some
      | 5832 -> { DogmaEffectData.id= 5832; name= "shipBonusMiningIceHarvestingRangeORE2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18041; postExpression= 18042 } |> Some
      | 5929 -> { DogmaEffectData.id= 5929; name= "systemDroneTracking"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 7610; postExpression= 7611 } |> Some
      | 6317 -> { DogmaEffectData.id= 6317; name= "eliteBonusCommandDestroyerMJFGspool2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19166; postExpression= 19167 } |> Some
      | 6414 -> { DogmaEffectData.id= 6414; name= "structureRigFighterHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6511 -> { DogmaEffectData.id= 6511; name= "shipBonusDreadnoughtM3RepairTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6608 -> { DogmaEffectData.id= 6608; name= "shipBonusSupercarrierC5WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6705 -> { DogmaEffectData.id= 6705; name= "rigDrawbackReductionShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19285; postExpression= 19286 } |> Some
      | 6899 -> { DogmaEffectData.id= 6899; name= "subsystemMRSBFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19331; postExpression= 19332 } |> Some
      | 6996 -> { DogmaEffectData.id= 6996; name= "eliteReconBonusArmorRepAmount3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16933; postExpression= 16934 } |> Some
      | 7093 -> { DogmaEffectData.id= 7093; name= "shipBonusSmartbombCapNeedRoleBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19533; postExpression= 19534 } |> Some
      | _ -> None