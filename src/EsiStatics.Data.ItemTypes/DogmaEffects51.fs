namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects51=
    let getDogmaEffect id = 
      match id with 
      | 1021 -> { DogmaEffectData.id= 1021; name= "eliteBonusGunshipHybridDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1118 -> { DogmaEffectData.id= 1118; name= "shipArmorEMResistanceABC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4884; postExpression= 4885 } |> Some
      | 1215 -> { DogmaEffectData.id= 1215; name= "shipEnergyDrainAmountAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1409 -> { DogmaEffectData.id= 1409; name= "systemScanDurationSkillAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2670 -> { DogmaEffectData.id= 2670; name= "sensorBoosterActivePercentage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2767 -> { DogmaEffectData.id= 2767; name= "boosterModifyBoosterAOEVelocityPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9905; postExpression= 9906 } |> Some
      | 2864 -> { DogmaEffectData.id= 2864; name= "newTestStasisWebifierEffect"; description= ""; displayName= ""; effectCategory= 2; preExpression= 10132; postExpression= 10133 } |> Some
      | 3155 -> { DogmaEffectData.id= 3155; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN&H&JP&L"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11027; postExpression= 11028 } |> Some
      | 3349 -> { DogmaEffectData.id= 3349; name= "shipShieldKineticResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11594; postExpression= 11595 } |> Some
      | 342 -> { DogmaEffectData.id= 342; name= "industrialConstructionSkillBoostIndustrialConstructionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3543 -> { DogmaEffectData.id= 3543; name= "targetHybridWeaponTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12200; postExpression= 12201 } |> Some
      | 3834 -> { DogmaEffectData.id= 3834; name= "subsystemSkillLevelGallenteDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4028 -> { DogmaEffectData.id= 4028; name= "systemRemoteEccmLadar"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13464; postExpression= 13465 } |> Some
      | 4125 -> { DogmaEffectData.id= 4125; name= "subsystemBonusCaldariOffensiveStandardMissileFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13756; postExpression= 13757 } |> Some
      | 439 -> { DogmaEffectData.id= 439; name= "learningSkillBoostLearningBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2446; postExpression= 2447 } |> Some
      | 4416 -> { DogmaEffectData.id= 4416; name= "shipBonusCF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4513 -> { DogmaEffectData.id= 4513; name= "shipStasisWebStrengthBonusMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4707 -> { DogmaEffectData.id= 4707; name= "systemEffectDamageKineticSmartbombs"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15281; postExpression= 15282 } |> Some
      | 4804 -> { DogmaEffectData.id= 4804; name= "dataMiningSkillBoostAccessDifficultyBonusAbsolutePercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4901 -> { DogmaEffectData.id= 4901; name= "shipMissileSpeedBonusAF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5095 -> { DogmaEffectData.id= 5095; name= "passiveThermicArmorResonanceBonusGroupArmorHardener3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 7877; postExpression= 7878 } |> Some
      | 51 -> { DogmaEffectData.id= 51; name= "modifyPowerRechargeRate"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5192 -> { DogmaEffectData.id= 5192; name= "shipBonusDroneDamageMultiplierBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16520; postExpression= 16521 } |> Some
      | 5289 -> { DogmaEffectData.id= 5289; name= "battlecruiserSkillLevelPreMulShipBonusGBC2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 536 -> { DogmaEffectData.id= 536; name= "cpuMultiplierPostMulCpuOutputShip"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5386 -> { DogmaEffectData.id= 5386; name= "shipMissileKinDamageCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5483 -> { DogmaEffectData.id= 5483; name= "setBonusChristmasShieldCapacityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5580 -> { DogmaEffectData.id= 5580; name= "marauderModeEffect3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17444; postExpression= 17445 } |> Some
      | 5871 -> { DogmaEffectData.id= 5871; name= "shipBonusShieldBoostMI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6065 -> { DogmaEffectData.id= 6065; name= "shipBonusLightMissileExpDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18631; postExpression= 18632 } |> Some
      | 6259 -> { DogmaEffectData.id= 6259; name= "shipBonusEnergyNosFalloffAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19039; postExpression= 19040 } |> Some
      | 6356 -> { DogmaEffectData.id= 6356; name= "roleBonusECMRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6550 -> { DogmaEffectData.id= 6550; name= "shipBonusForceAuxiliaryG3CapBoosterStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6647 -> { DogmaEffectData.id= 6647; name= "shipBonusTitanA3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6744 -> { DogmaEffectData.id= 6744; name= "behaviorWarpDisrupt"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6841 -> { DogmaEffectData.id= 6841; name= "rigAllShipManufactureTimeBonus"; description= "rig time bonus on manufacture of all ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6938 -> { DogmaEffectData.id= 6938; name= "subsystemBonusCaldariCore3ECMHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7035 -> { DogmaEffectData.id= 7035; name= "shipBonusHeavyAssaultMissileExplosiveDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7132 -> { DogmaEffectData.id= 7132; name= "selfMassBonusPercentage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 11224; postExpression= 11225 } |> Some
      | 730 -> { DogmaEffectData.id= 730; name= "shipBonusVelocityCI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None