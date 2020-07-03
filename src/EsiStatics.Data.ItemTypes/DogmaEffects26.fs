namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects26=
    let getDogmaEffect id = 
      match id with 
      | 1190 -> { DogmaEffectData.id= 1190; name= "iceHarvestCycleTimeModulesRequiringIceHarvesting"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1675 -> { DogmaEffectData.id= 1675; name= "freighterMaxVelocityBonusM1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2160 -> { DogmaEffectData.id= 2160; name= "eliteBonusCommandShipHybridFalloffCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 220 -> { DogmaEffectData.id= 220; name= "energyManagementSkillBoostCapRechargeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2354 -> { DogmaEffectData.id= 2354; name= "capitalRemoteArmorRepairerCapNeedBonusSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2451 -> { DogmaEffectData.id= 2451; name= "commandShipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 26 -> { DogmaEffectData.id= 26; name= "structureRepair"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2645 -> { DogmaEffectData.id= 2645; name= "scanResolutionMultiplierOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 317 -> { DogmaEffectData.id= 317; name= "amarrTechSkillBoostAmarrTechMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3615 -> { DogmaEffectData.id= 3615; name= "scriptWarpDisruptionFieldGeneratorSetScriptCapacitorNeedHidden"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3809 -> { DogmaEffectData.id= 3809; name= "scanResolutionAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4003 -> { DogmaEffectData.id= 4003; name= "systemMaxVelocity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 414 -> { DogmaEffectData.id= 414; name= "gunneryTurretSpeeBonusPostPercentSpeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4197 -> { DogmaEffectData.id= 4197; name= "subsystemSkillLevelGallenteDefensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4391 -> { DogmaEffectData.id= 4391; name= "subSystemBonusGallenteElectronicScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4973 -> { DogmaEffectData.id= 4973; name= "eliteBonusAssaultShipRocketROF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 511 -> { DogmaEffectData.id= 511; name= "shipEnergyTCapNeedBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5264 -> { DogmaEffectData.id= 5264; name= "warfareLinkCPUAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5361 -> { DogmaEffectData.id= 5361; name= "shipProjectileFalloffBonusMBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5555 -> { DogmaEffectData.id= 5555; name= "shipBonusHeavyDroneSpeedGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6040 -> { DogmaEffectData.id= 6040; name= "modeMWDSigRadiusPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6234 -> { DogmaEffectData.id= 6234; name= "shipBonusEnergyNosOptimalRS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6331 -> { DogmaEffectData.id= 6331; name= "shipBonusShieldThermalResistanceCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6428 -> { DogmaEffectData.id= 6428; name= "shipModuleRemoteTrackingComputer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6622 -> { DogmaEffectData.id= 6622; name= "shipBonusSupercarrierC2ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6719 -> { DogmaEffectData.id= 6719; name= "moduleBonusIndustrialInvulnerability"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6816 -> { DogmaEffectData.id= 6816; name= "rigLargeshipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of large ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6913 -> { DogmaEffectData.id= 6913; name= "subsystemSkillLevelAmarrEngineering3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7010 -> { DogmaEffectData.id= 7010; name= "doomsdayTargetedWarpableBeacon"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7107 -> { DogmaEffectData.id= 7107; name= "structureConversionRigCopyTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7204 -> { DogmaEffectData.id= 7204; name= "shipArmorEMResistancePF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 899 -> { DogmaEffectData.id= 899; name= "shipMissileKineticDamageCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 996 -> { DogmaEffectData.id= 996; name= "eliteBonusGunshipHybridTracking2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None