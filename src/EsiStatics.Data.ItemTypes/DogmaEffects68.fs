﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects68=
    let getDogmaEffect id = 
      match id with 
      | 1232 -> { DogmaEffectData.id= 1232; name= "shipProjectileRofPirateCruiser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1329 -> { DogmaEffectData.id= 1329; name= "propulsionSkillPropulsionStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5561; postExpression= 5562 } |> Some
      | 1814 -> { DogmaEffectData.id= 1814; name= "shipShieldKineticResistanceCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1911 -> { DogmaEffectData.id= 1911; name= "eliteReconBonusGravimetricStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2008 -> { DogmaEffectData.id= 2008; name= "cynosuralDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2105 -> { DogmaEffectData.id= 2105; name= "emArmorCompensationHardeningBonusGroupArmorCoating"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2202 -> { DogmaEffectData.id= 2202; name= "droneDmgBonusRequiringScoutDroneOP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8183; postExpression= 8184 } |> Some
      | 2590 -> { DogmaEffectData.id= 2590; name= "naniteControlSkillBoostBoosterAttributeModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2687 -> { DogmaEffectData.id= 2687; name= "shipBonusArmorRepairAmountGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9671; postExpression= 9672 } |> Some
      | 2784 -> { DogmaEffectData.id= 2784; name= "bcsEmDamageBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9944; postExpression= 9945 } |> Some
      | 2881 -> { DogmaEffectData.id= 2881; name= "missileEMDmgBonusCruise3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3075 -> { DogmaEffectData.id= 3075; name= "controlTowerGenericHullThermicResistanceBonusEcm"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10789; postExpression= 10790 } |> Some
      | 3172 -> { DogmaEffectData.id= 3172; name= "droneArmorDamageBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3366 -> { DogmaEffectData.id= 3366; name= "shipRemoteSensorDampenerCapNeedGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3560 -> { DogmaEffectData.id= 3560; name= "ewSkillTrackingDisruptionMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12246; postExpression= 12247 } |> Some
      | 3657 -> { DogmaEffectData.id= 3657; name= "shipScanResolutionBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 3754 -> { DogmaEffectData.id= 3754; name= "zColinTransportsCloakCpuBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12794; postExpression= 12795 } |> Some
      | 3851 -> { DogmaEffectData.id= 3851; name= "subsystemSkillLevelMinmatarPropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4045 -> { DogmaEffectData.id= 4045; name= "systemSmartBombRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4142 -> { DogmaEffectData.id= 4142; name= "subsystemBonusMinmatarEngineeringTargetPainterStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13792; postExpression= 13793 } |> Some
      | 4239 -> { DogmaEffectData.id= 4239; name= "modifyArmorResonanceEmThermalPreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14077; postExpression= 14078 } |> Some
      | 4336 -> { DogmaEffectData.id= 4336; name= "subsystemBonusCaldariOffensive3EwStrengthMagn"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 456 -> { DogmaEffectData.id= 456; name= "shipTargetRangeBonusMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4821 -> { DogmaEffectData.id= 4821; name= "bcLargeHybridTurretPowerNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4918 -> { DogmaEffectData.id= 4918; name= "setMassAndAgilityAndSpeed"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5015 -> { DogmaEffectData.id= 5015; name= "shipBonusEwRemoteSensorDampenerMaxTargetRangeBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5209 -> { DogmaEffectData.id= 5209; name= "shipWebVelocityBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5306 -> { DogmaEffectData.id= 5306; name= "shipRocketKineticDmgCD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5403 -> { DogmaEffectData.id= 5403; name= "shipMissileHeavyVelocityABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5500 -> { DogmaEffectData.id= 5500; name= "eliteBonusCommandShipsHeavyMissileExplosionRadiusCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 553 -> { DogmaEffectData.id= 553; name= "shipHTTrackingBonusGB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5597 -> { DogmaEffectData.id= 5597; name= "marauderModeEffect16"; description= ""; displayName= ""; effectCategory= 1; preExpression= 17484; postExpression= 17485 } |> Some
      | 5791 -> { DogmaEffectData.id= 5791; name= "shipBonusEwWeaponDisruptionRangeDisruptionBonusAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17933; postExpression= 17934 } |> Some
      | 5888 -> { DogmaEffectData.id= 5888; name= "eliteIndustrialArmorResists2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6276 -> { DogmaEffectData.id= 6276; name= "shipBonusEnergyNosFalloffEAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19080; postExpression= 19081 } |> Some
      | 6373 -> { DogmaEffectData.id= 6373; name= "armorRepairProjectorFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6470 -> { DogmaEffectData.id= 6470; name= "remoteECMFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 650 -> { DogmaEffectData.id= 650; name= "anchorLift"; description= ""; displayName= "unanchoring"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6567 -> { DogmaEffectData.id= 6567; name= "moduleBonusNetworkedSensorArray"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6664 -> { DogmaEffectData.id= 6664; name= "skillBonusDroneSharpshooting"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6761 -> { DogmaEffectData.id= 6761; name= "engComplexTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6858 -> { DogmaEffectData.id= 6858; name= "shipBonusForceAuxiliaryA1NosferatuDrainAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6955 -> { DogmaEffectData.id= 6955; name= "subsystemRemoteShieldBoostFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7052 -> { DogmaEffectData.id= 7052; name= "roleBonusFlagCruiserTargetPainterModifications"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7149 -> { DogmaEffectData.id= 7149; name= "shipRole4RemoteRepMultMax"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19657; postExpression= 19658 } |> Some
      | _ -> None