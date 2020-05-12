namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects1=
    let getDogmaEffect id = 
      match id with 
      | 1165 -> { DogmaEffectData.id= 1165; name= "shipIceHarvesterCPUNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5063; postExpression= 5064 } |> Some
      | 1262 -> { DogmaEffectData.id= 1262; name= "setBonusSerpentis2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1650 -> { DogmaEffectData.id= 1650; name= "skillSiegeModuleConsumptionQuantityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2135 -> { DogmaEffectData.id= 2135; name= "armorRepairProjectorMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2232 -> { DogmaEffectData.id= 2232; name= "scanStrengthBonusPercentOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2426 -> { DogmaEffectData.id= 2426; name= "skillInterdictorEliteBonus1SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2523 -> { DogmaEffectData.id= 2523; name= "armorRepairAmountBonusPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9164; postExpression= 9165 } |> Some
      | 2717 -> { DogmaEffectData.id= 2717; name= "drawbackMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2814 -> { DogmaEffectData.id= 2814; name= "shipBonusSurveyProbeExplosionDelaySkillSurveyCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10000; postExpression= 10001 } |> Some
      | 2911 -> { DogmaEffectData.id= 2911; name= "dataminerModuleDurationReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3105 -> { DogmaEffectData.id= 3105; name= "controlTowerGenericHullExplosiveResistanceBonusStasis"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10917; postExpression= 10918 } |> Some
      | 3299 -> { DogmaEffectData.id= 3299; name= "shipEnergyNeutralizerTransferAmountBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3396 -> { DogmaEffectData.id= 3396; name= "eliteBonusBlackOpsECMGravimetricStrengthBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11732; postExpression= 11733 } |> Some
      | 3493 -> { DogmaEffectData.id= 3493; name= "rorqualCargoScanRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3590 -> { DogmaEffectData.id= 3590; name= "shipBonusEwRemoteSensorDampenerScanResolutionBonusGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3687 -> { DogmaEffectData.id= 3687; name= "selfCopyMaxRangeBonusToFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12609; postExpression= 12610 } |> Some
      | 3784 -> { DogmaEffectData.id= 3784; name= "maxVelocityAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3881 -> { DogmaEffectData.id= 3881; name= "subsystemBonusAmarrElectronicMaxTargetRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13127; postExpression= 13128 } |> Some
      | 389 -> { DogmaEffectData.id= 389; name= "astrogeologySkillBoostMiningAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3978 -> { DogmaEffectData.id= 3978; name= "subsystemBonusMinmatarDefensiveShieldHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13321; postExpression= 13322 } |> Some
      | 4075 -> { DogmaEffectData.id= 4075; name= "systemHeavyMissileExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13624; postExpression= 13625 } |> Some
      | 4269 -> { DogmaEffectData.id= 4269; name= "subsystemBonusAmarrCore3ScanResolution"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4366 -> { DogmaEffectData.id= 4366; name= "shipBonusMediumHybridDmgCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4463 -> { DogmaEffectData.id= 4463; name= "republicsetLGbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4560 -> { DogmaEffectData.id= 4560; name= "targetGunneryMaxRangeFalloffTrackingSpeedBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12625; postExpression= 12626 } |> Some
      | 4851 -> { DogmaEffectData.id= 4851; name= "shipTorpedosExplosionVelocityBonusBC4"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15667; postExpression= 15668 } |> Some
      | 486 -> { DogmaEffectData.id= 486; name= "shieldOperationRechargeratebonusPostPercentRechargeRateLocationShipGroupShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5045 -> { DogmaEffectData.id= 5045; name= "shipBonusSalvageCycleCF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5142 -> { DogmaEffectData.id= 5142; name= "GCHYieldMultiplyPassive"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5336 -> { DogmaEffectData.id= 5336; name= "shipShieldExplosiveResistance1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5433 -> { DogmaEffectData.id= 5433; name= "hackingSkillVirusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5724 -> { DogmaEffectData.id= 5724; name= "shipSHTOptimalBonusGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5821 -> { DogmaEffectData.id= 5821; name= "shipBonusMediumDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 583 -> { DogmaEffectData.id= 583; name= "amarrIndustrialSkillLevelPreMulShipBonusAI2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5918 -> { DogmaEffectData.id= 5918; name= "systemDamageThermalBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6015 -> { DogmaEffectData.id= 6015; name= "modeArmorResonancePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6112 -> { DogmaEffectData.id= 6112; name= "missileAOECloudSizeBonusOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6209 -> { DogmaEffectData.id= 6209; name= "commandDestroyerSkillMultiplier1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6306 -> { DogmaEffectData.id= 6306; name= "serviceSlot"; description= "Requires a service slot."; displayName= "Service Slot"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6403 -> { DogmaEffectData.id= 6403; name= "structureRigVelocityBonusSingleTargetMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6597 -> { DogmaEffectData.id= 6597; name= "shipBonusCarrierG4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6694 -> { DogmaEffectData.id= 6694; name= "npcEntityWeaponDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6791 -> { DogmaEffectData.id= 6791; name= "oreCapitalShipSkillMultiplier5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6888 -> { DogmaEffectData.id= 6888; name= "rigAdvCapComponentManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced capital components"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6985 -> { DogmaEffectData.id= 6985; name= "shipBonusDreadnoughtG1KinThermDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7179 -> { DogmaEffectData.id= 7179; name= "stripMinerDurationMultiplier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 874 -> { DogmaEffectData.id= 874; name= "shipProjectileOptimalBonuseMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 971 -> { DogmaEffectData.id= 971; name= "smartbombThermalBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 4335; postExpression= 4336 } |> Some
      | _ -> None