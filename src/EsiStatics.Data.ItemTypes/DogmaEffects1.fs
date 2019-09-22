namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects1=
    let getDogmaEffect id = 
      match id with 
      | 1262 -> { DogmaEffectData.id= 1262; name= "setBonusSerpentis2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5376; postExpression= 5377 } |> Some
      | 1650 -> { DogmaEffectData.id= 1650; name= "skillSiegeModuleConsumptionQuantityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6553; postExpression= 6554 } |> Some
      | 2135 -> { DogmaEffectData.id= 2135; name= "armorRepairProjectorMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8021; postExpression= 8022 } |> Some
      | 2232 -> { DogmaEffectData.id= 2232; name= "scanStrengthBonusPercentOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 8294; postExpression= 8295 } |> Some
      | 2426 -> { DogmaEffectData.id= 2426; name= "skillInterdictorEliteBonus1SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8935; postExpression= 8936 } |> Some
      | 2717 -> { DogmaEffectData.id= 2717; name= "drawbackMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9759; postExpression= 9760 } |> Some
      | 2911 -> { DogmaEffectData.id= 2911; name= "dataminerModuleDurationReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10297; postExpression= 10298 } |> Some
      | 3299 -> { DogmaEffectData.id= 3299; name= "shipEnergyNeutralizerTransferAmountBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11462; postExpression= 11463 } |> Some
      | 3493 -> { DogmaEffectData.id= 3493; name= "rorqualCargoScanRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11405; postExpression= 11406 } |> Some
      | 3590 -> { DogmaEffectData.id= 3590; name= "shipBonusEwRemoteSensorDampenerScanResolutionBonusGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12303; postExpression= 12304 } |> Some
      | 3784 -> { DogmaEffectData.id= 3784; name= "maxVelocityAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12857; postExpression= 12858 } |> Some
      | 389 -> { DogmaEffectData.id= 389; name= "astrogeologySkillBoostMiningAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2232; postExpression= 2233 } |> Some
      | 4269 -> { DogmaEffectData.id= 4269; name= "subsystemBonusAmarrCore3ScanResolution"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14139; postExpression= 14140 } |> Some
      | 4366 -> { DogmaEffectData.id= 4366; name= "shipBonusMediumHybridDmgCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14359; postExpression= 14360 } |> Some
      | 4463 -> { DogmaEffectData.id= 4463; name= "republicsetLGbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14644; postExpression= 14645 } |> Some
      | 486 -> { DogmaEffectData.id= 486; name= "shieldOperationRechargeratebonusPostPercentRechargeRateLocationShipGroupShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2603; postExpression= 2604 } |> Some
      | 5045 -> { DogmaEffectData.id= 5045; name= "shipBonusSalvageCycleCF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16191; postExpression= 16192 } |> Some
      | 5142 -> { DogmaEffectData.id= 5142; name= "GCHYieldMultiplyPassive"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16405; postExpression= 16406 } |> Some
      | 5336 -> { DogmaEffectData.id= 5336; name= "shipShieldExplosiveResistance1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16873; postExpression= 16874 } |> Some
      | 5433 -> { DogmaEffectData.id= 5433; name= "hackingSkillVirusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17063; postExpression= 17064 } |> Some
      | 5724 -> { DogmaEffectData.id= 5724; name= "shipSHTOptimalBonusGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4378; postExpression= 4379 } |> Some
      | 5821 -> { DogmaEffectData.id= 5821; name= "shipBonusMediumDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18013; postExpression= 18014 } |> Some
      | 583 -> { DogmaEffectData.id= 583; name= "amarrIndustrialSkillLevelPreMulShipBonusAI2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2816; postExpression= 2817 } |> Some
      | 5918 -> { DogmaEffectData.id= 5918; name= "systemDamageThermalBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18266; postExpression= 18267 } |> Some
      | 6015 -> { DogmaEffectData.id= 6015; name= "modeArmorResonancePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7861; postExpression= 7862 } |> Some
      | 6112 -> { DogmaEffectData.id= 6112; name= "missileAOECloudSizeBonusOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 15886; postExpression= 15887 } |> Some
      | 6209 -> { DogmaEffectData.id= 6209; name= "commandDestroyerSkillMultiplier1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18936; postExpression= 18937 } |> Some
      | 6306 -> { DogmaEffectData.id= 6306; name= "serviceSlot"; description= "Requires a service slot."; displayName= "Service Slot"; effectCategory= 0; preExpression= 131; postExpression= 131 } |> Some
      | 6403 -> { DogmaEffectData.id= 6403; name= "structureRigVelocityBonusSingleTargetMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6597 -> { DogmaEffectData.id= 6597; name= "shipBonusCarrierG4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6694 -> { DogmaEffectData.id= 6694; name= "npcEntityWeaponDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6791 -> { DogmaEffectData.id= 6791; name= "oreCapitalShipSkillMultiplier5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11543; postExpression= 11544 } |> Some
      | 6888 -> { DogmaEffectData.id= 6888; name= "rigAdvCapComponentManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced capital components"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6985 -> { DogmaEffectData.id= 6985; name= "shipBonusDreadnoughtG1KinThermDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7179 -> { DogmaEffectData.id= 7179; name= "stripMinerDurationMultiplier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 19737; postExpression= 19738 } |> Some
      | 874 -> { DogmaEffectData.id= 874; name= "shipProjectileOptimalBonuseMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4026; postExpression= 4027 } |> Some
      | _ -> None