namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects26=
    let getDogmaEffect id = 
      match id with 
      | 1190 -> { DogmaEffectData.id= 1190; name= "iceHarvestCycleTimeModulesRequiringIceHarvesting"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 123 -> { DogmaEffectData.id= 123; name= "turretWeaponRangeTrackingSpeedMultiplyActivate"; description= ""; displayName= ""; effectCategory= 1; preExpression= 884; postExpression= 885 } |> Some
      | 1675 -> { DogmaEffectData.id= 1675; name= "freighterMaxVelocityBonusM1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1869 -> { DogmaEffectData.id= 1869; name= "shipMissileKineticDamageAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7185; postExpression= 7186 } |> Some
      | 2160 -> { DogmaEffectData.id= 2160; name= "eliteBonusCommandShipHybridFalloffCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 220 -> { DogmaEffectData.id= 220; name= "energyManagementSkillBoostCapRechargeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2257 -> { DogmaEffectData.id= 2257; name= "eliteBonusInterdictorsBubbleRoF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8355; postExpression= 8356 } |> Some
      | 2354 -> { DogmaEffectData.id= 2354; name= "capitalRemoteArmorRepairerCapNeedBonusSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2451 -> { DogmaEffectData.id= 2451; name= "commandShipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 26 -> { DogmaEffectData.id= 26; name= "structureRepair"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2645 -> { DogmaEffectData.id= 2645; name= "scanResolutionMultiplierOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2839 -> { DogmaEffectData.id= 2839; name= "shipShieldKineticThermalResistanceCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10073; postExpression= 10074 } |> Some
      | 3130 -> { DogmaEffectData.id= 3130; name= "controlTowerGenericHullK&TResistanceBonusLaser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10981; postExpression= 10982 } |> Some
      | 317 -> { DogmaEffectData.id= 317; name= "amarrTechSkillBoostAmarrTechMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3227 -> { DogmaEffectData.id= 3227; name= "shipHeavyAssaultMissileThermalDmgBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11236; postExpression= 11237 } |> Some
      | 3324 -> { DogmaEffectData.id= 3324; name= "shipBonusORECapShipDroneHPBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11535; postExpression= 11536 } |> Some
      | 3421 -> { DogmaEffectData.id= 3421; name= "shipCapNeedBonusAB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11818; postExpression= 11819 } |> Some
      | 3615 -> { DogmaEffectData.id= 3615; name= "scriptWarpDisruptionFieldGeneratorSetScriptCapacitorNeedHidden"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3809 -> { DogmaEffectData.id= 3809; name= "scanResolutionAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4003 -> { DogmaEffectData.id= 4003; name= "systemMaxVelocity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4100 -> { DogmaEffectData.id= 4100; name= "subsystemBonusCaldariOffensiveHybridWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13704; postExpression= 13705 } |> Some
      | 414 -> { DogmaEffectData.id= 414; name= "gunneryTurretSpeeBonusPostPercentSpeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4197 -> { DogmaEffectData.id= 4197; name= "subsystemSkillLevelGallenteDefensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4391 -> { DogmaEffectData.id= 4391; name= "subSystemBonusGallenteElectronicScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4682 -> { DogmaEffectData.id= 4682; name= "systemEMmissileDmg"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15224; postExpression= 15225 } |> Some
      | 4779 -> { DogmaEffectData.id= 4779; name= "shipArmorEXPResistanceATF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15426; postExpression= 15427 } |> Some
      | 4876 -> { DogmaEffectData.id= 4876; name= "siegeCitadelCruiseAoeVelocityModifier"; description= "Automatically generated effect"; displayName= "siegeCitadelCruiseAoeVelocityModifier"; effectCategory= 1; preExpression= 15756; postExpression= 15757 } |> Some
      | 4973 -> { DogmaEffectData.id= 4973; name= "eliteBonusAssaultShipRocketROF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 511 -> { DogmaEffectData.id= 511; name= "shipEnergyTCapNeedBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5264 -> { DogmaEffectData.id= 5264; name= "warfareLinkCPUAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5361 -> { DogmaEffectData.id= 5361; name= "shipProjectileFalloffBonusMBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5458 -> { DogmaEffectData.id= 5458; name= "archaeologyVirusStrengthBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17145; postExpression= 17146 } |> Some
      | 5555 -> { DogmaEffectData.id= 5555; name= "shipBonusHeavyDroneSpeedGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6040 -> { DogmaEffectData.id= 6040; name= "modeMWDSigRadiusPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6137 -> { DogmaEffectData.id= 6137; name= "overloadSelfMissileGuidanceExplosionDelayBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 5; preExpression= 18811; postExpression= 18812 } |> Some
      | 6234 -> { DogmaEffectData.id= 6234; name= "shipBonusEnergyNosOptimalRS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6331 -> { DogmaEffectData.id= 6331; name= "shipBonusShieldThermalResistanceCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6428 -> { DogmaEffectData.id= 6428; name= "shipModuleRemoteTrackingComputer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6622 -> { DogmaEffectData.id= 6622; name= "shipBonusSupercarrierC2ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6719 -> { DogmaEffectData.id= 6719; name= "moduleBonusIndustrialInvulnerability"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6816 -> { DogmaEffectData.id= 6816; name= "rigLargeshipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of large ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6913 -> { DogmaEffectData.id= 6913; name= "subsystemSkillLevelAmarrEngineering3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7010 -> { DogmaEffectData.id= 7010; name= "doomsdayTargetedWarpableBeacon"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 705 -> { DogmaEffectData.id= 705; name= "bombersSkillLevelPreMulEliteBonusBombersShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3459; postExpression= 3460 } |> Some
      | 7107 -> { DogmaEffectData.id= 7107; name= "structureConversionRigCopyTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7204 -> { DogmaEffectData.id= 7204; name= "shipArmorEMResistancePF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 802 -> { DogmaEffectData.id= 802; name= "shipDronesMaxGB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3785; postExpression= 3786 } |> Some
      | 899 -> { DogmaEffectData.id= 899; name= "shipMissileKineticDamageCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 996 -> { DogmaEffectData.id= 996; name= "eliteBonusGunshipHybridTracking2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None