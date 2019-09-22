namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects26=
    let getDogmaEffect id = 
      match id with 
      | 1190 -> { DogmaEffectData.id= 1190; name= "iceHarvestCycleTimeModulesRequiringIceHarvesting"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5165; postExpression= 5166 } |> Some
      | 1675 -> { DogmaEffectData.id= 1675; name= "freighterMaxVelocityBonusM1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6629; postExpression= 6630 } |> Some
      | 2160 -> { DogmaEffectData.id= 2160; name= "eliteBonusCommandShipHybridFalloffCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8097; postExpression= 8098 } |> Some
      | 220 -> { DogmaEffectData.id= 220; name= "energyManagementSkillBoostCapRechargeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1482; postExpression= 1483 } |> Some
      | 2354 -> { DogmaEffectData.id= 2354; name= "capitalRemoteArmorRepairerCapNeedBonusSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8701; postExpression= 8702 } |> Some
      | 2451 -> { DogmaEffectData.id= 2451; name= "commandShipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9016; postExpression= 9017 } |> Some
      | 26 -> { DogmaEffectData.id= 26; name= "structureRepair"; description= ""; displayName= ""; effectCategory= 1; preExpression= 131; postExpression= 233 } |> Some
      | 2645 -> { DogmaEffectData.id= 2645; name= "scanResolutionMultiplierOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 3935; postExpression= 3408 } |> Some
      | 317 -> { DogmaEffectData.id= 317; name= "amarrTechSkillBoostAmarrTechMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1894; postExpression= 1895 } |> Some
      | 3615 -> { DogmaEffectData.id= 3615; name= "scriptWarpDisruptionFieldGeneratorSetScriptCapacitorNeedHidden"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12412; postExpression= 12413 } |> Some
      | 3809 -> { DogmaEffectData.id= 3809; name= "scanResolutionAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12904; postExpression= 12905 } |> Some
      | 4003 -> { DogmaEffectData.id= 4003; name= "systemMaxVelocity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13373; postExpression= 13374 } |> Some
      | 414 -> { DogmaEffectData.id= 414; name= "gunneryTurretSpeeBonusPostPercentSpeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2330; postExpression= 2331 } |> Some
      | 4197 -> { DogmaEffectData.id= 4197; name= "subsystemSkillLevelGallenteDefensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13932; postExpression= 13933 } |> Some
      | 4391 -> { DogmaEffectData.id= 4391; name= "subSystemBonusGallenteElectronicScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14418; postExpression= 14419 } |> Some
      | 4973 -> { DogmaEffectData.id= 4973; name= "eliteBonusAssaultShipRocketROF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16006; postExpression= 16007 } |> Some
      | 511 -> { DogmaEffectData.id= 511; name= "shipEnergyTCapNeedBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2747; postExpression= 2748 } |> Some
      | 5264 -> { DogmaEffectData.id= 5264; name= "warfareLinkCPUAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16685; postExpression= 16686 } |> Some
      | 5361 -> { DogmaEffectData.id= 5361; name= "shipProjectileFalloffBonusMBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16923; postExpression= 16924 } |> Some
      | 5555 -> { DogmaEffectData.id= 5555; name= "shipBonusHeavyDroneSpeedGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17384; postExpression= 17385 } |> Some
      | 6040 -> { DogmaEffectData.id= 6040; name= "modeMWDSigRadiusPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18584; postExpression= 18585 } |> Some
      | 6234 -> { DogmaEffectData.id= 6234; name= "shipBonusEnergyNosOptimalRS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18981; postExpression= 18982 } |> Some
      | 6331 -> { DogmaEffectData.id= 6331; name= "shipBonusShieldThermalResistanceCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19186; postExpression= 19187 } |> Some
      | 6428 -> { DogmaEffectData.id= 6428; name= "shipModuleRemoteTrackingComputer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6622 -> { DogmaEffectData.id= 6622; name= "shipBonusSupercarrierC2ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6719 -> { DogmaEffectData.id= 6719; name= "moduleBonusIndustrialInvulnerability"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6816 -> { DogmaEffectData.id= 6816; name= "rigLargeshipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of large ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6913 -> { DogmaEffectData.id= 6913; name= "subsystemSkillLevelAmarrEngineering3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13012; postExpression= 13013 } |> Some
      | 7010 -> { DogmaEffectData.id= 7010; name= "doomsdayTargetedWarpableBeacon"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7107 -> { DogmaEffectData.id= 7107; name= "structureConversionRigCopyTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 7204 -> { DogmaEffectData.id= 7204; name= "shipArmorEMResistancePF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19796; postExpression= 19797 } |> Some
      | 899 -> { DogmaEffectData.id= 899; name= "shipMissileKineticDamageCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4121; postExpression= 4122 } |> Some
      | 996 -> { DogmaEffectData.id= 996; name= "eliteBonusGunshipHybridTracking2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4415; postExpression= 4416 } |> Some
      | _ -> None