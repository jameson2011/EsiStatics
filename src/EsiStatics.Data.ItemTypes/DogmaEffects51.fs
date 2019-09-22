﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects51=
    let getDogmaEffect id = 
      match id with 
      | 1021 -> { DogmaEffectData.id= 1021; name= "eliteBonusGunshipHybridDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4536; postExpression= 4537 } |> Some
      | 1215 -> { DogmaEffectData.id= 1215; name= "shipEnergyDrainAmountAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5247; postExpression= 5248 } |> Some
      | 1409 -> { DogmaEffectData.id= 1409; name= "systemScanDurationSkillAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5833; postExpression= 5834 } |> Some
      | 2670 -> { DogmaEffectData.id= 2670; name= "sensorBoosterActivePercentage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 9629; postExpression= 9630 } |> Some
      | 342 -> { DogmaEffectData.id= 342; name= "industrialConstructionSkillBoostIndustrialConstructionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2031; postExpression= 2032 } |> Some
      | 3834 -> { DogmaEffectData.id= 3834; name= "subsystemSkillLevelGallenteDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12978; postExpression= 12979 } |> Some
      | 4416 -> { DogmaEffectData.id= 4416; name= "shipBonusCF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14477; postExpression= 14478 } |> Some
      | 4513 -> { DogmaEffectData.id= 4513; name= "shipStasisWebStrengthBonusMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14780; postExpression= 14781 } |> Some
      | 4804 -> { DogmaEffectData.id= 4804; name= "dataMiningSkillBoostAccessDifficultyBonusAbsolutePercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15486; postExpression= 15487 } |> Some
      | 4901 -> { DogmaEffectData.id= 4901; name= "shipMissileSpeedBonusAF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15808; postExpression= 15809 } |> Some
      | 51 -> { DogmaEffectData.id= 51; name= "modifyPowerRechargeRate"; description= ""; displayName= ""; effectCategory= 4; preExpression= 443; postExpression= 444 } |> Some
      | 5289 -> { DogmaEffectData.id= 5289; name= "battlecruiserSkillLevelPreMulShipBonusGBC2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16775; postExpression= 16776 } |> Some
      | 536 -> { DogmaEffectData.id= 536; name= "cpuMultiplierPostMulCpuOutputShip"; description= ""; displayName= ""; effectCategory= 4; preExpression= 2843; postExpression= 2844 } |> Some
      | 5386 -> { DogmaEffectData.id= 5386; name= "shipMissileKinDamageCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16964; postExpression= 16965 } |> Some
      | 5483 -> { DogmaEffectData.id= 5483; name= "setBonusChristmasShieldCapacityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17219; postExpression= 17220 } |> Some
      | 5871 -> { DogmaEffectData.id= 5871; name= "shipBonusShieldBoostMI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18132; postExpression= 18133 } |> Some
      | 6356 -> { DogmaEffectData.id= 6356; name= "roleBonusECMRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19216; postExpression= 19217 } |> Some
      | 6647 -> { DogmaEffectData.id= 6647; name= "shipBonusTitanA3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6744 -> { DogmaEffectData.id= 6744; name= "behaviorWarpDisrupt"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6841 -> { DogmaEffectData.id= 6841; name= "rigAllShipManufactureTimeBonus"; description= "rig time bonus on manufacture of all ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6938 -> { DogmaEffectData.id= 6938; name= "subsystemBonusCaldariCore3ECMHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14251; postExpression= 14252 } |> Some
      | 7035 -> { DogmaEffectData.id= 7035; name= "shipBonusHeavyAssaultMissileExplosiveDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19400; postExpression= 19401 } |> Some
      | 730 -> { DogmaEffectData.id= 730; name= "shipBonusVelocityCI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3569; postExpression= 3572 } |> Some
      | _ -> None