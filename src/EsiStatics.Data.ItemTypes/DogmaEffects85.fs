﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects85=
    let getDogmaEffect id = 
      match id with 
      | 1055 -> { DogmaEffectData.id= 1055; name= "shipTrackingLinkRange2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4642; postExpression= 4643 } |> Some
      | 1152 -> { DogmaEffectData.id= 1152; name= "controlTowerGallenteHybridDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1443 -> { DogmaEffectData.id= 1443; name= "caldariShipEwCapacitorNeedCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2413 -> { DogmaEffectData.id= 2413; name= "snowBallLaunching"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 2607 -> { DogmaEffectData.id= 2607; name= "scanRadarStrengthBonusPercentageScanStrengthBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9461; postExpression= 9462 } |> Some
      | 279 -> { DogmaEffectData.id= 279; name= "shieldEmmisionSystemsCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringShieldEmmisionSystems"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2801 -> { DogmaEffectData.id= 2801; name= "energyWeaponSpeedMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2898 -> { DogmaEffectData.id= 2898; name= "missileThermalDmgBonusFOF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10249; postExpression= 10250 } |> Some
      | 3092 -> { DogmaEffectData.id= 3092; name= "controlTowerGenericHullThermicResistanceBonusMissile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10861; postExpression= 10862 } |> Some
      | 3189 -> { DogmaEffectData.id= 3189; name= "overloadSelfECCMStrenghtBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3383 -> { DogmaEffectData.id= 3383; name= "droneShieldHPBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11685; postExpression= 11686 } |> Some
      | 3480 -> { DogmaEffectData.id= 3480; name= "shipTrackingBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3577 -> { DogmaEffectData.id= 3577; name= "targetScanResolutionRangeBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 3427; postExpression= 3428 } |> Some
      | 3674 -> { DogmaEffectData.id= 3674; name= "jumpPortalGenerationBO"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 3771 -> { DogmaEffectData.id= 3771; name= "armorHPBonusAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3868 -> { DogmaEffectData.id= 3868; name= "subsystemBonusMinmatarPropulsion2Agility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3965 -> { DogmaEffectData.id= 3965; name= "subsystemBonusGallenteDefensiveShieldBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13295; postExpression= 13296 } |> Some
      | 4062 -> { DogmaEffectData.id= 4062; name= "systemStandardMissileEmDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4159 -> { DogmaEffectData.id= 4159; name= "subsystemBonusAmarrCoreCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4256 -> { DogmaEffectData.id= 4256; name= "subsystemBonusMinmatarOffensive2MissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4353 -> { DogmaEffectData.id= 4353; name= "shipMissileHeavyAssaultVelocityBonusCR3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14330; postExpression= 14331 } |> Some
      | 4644 -> { DogmaEffectData.id= 4644; name= "eliteBonusHeavyGunshipHeavyAssaultAndAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15149; postExpression= 15150 } |> Some
      | 4935 -> { DogmaEffectData.id= 4935; name= "titanTurretDamageScaling"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15907; postExpression= 15908 } |> Some
      | 5129 -> { DogmaEffectData.id= 5129; name= "minmatarShipEwTargetPainterMC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5226 -> { DogmaEffectData.id= 5226; name= "shipHeavyMissileExpDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5323 -> { DogmaEffectData.id= 5323; name= "shipArmorExplosiveResistance1ABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5420 -> { DogmaEffectData.id= 5420; name= "shipBonusDroneStructureHitPointsAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5614 -> { DogmaEffectData.id= 5614; name= "piCustomsOfficeTaxReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5808 -> { DogmaEffectData.id= 5808; name= "shipBonusHeavyDroneShieldHpPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6196 -> { DogmaEffectData.id= 6196; name= "expeditionFrigateBonusIceHarvestingCycleTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6293 -> { DogmaEffectData.id= 6293; name= "amarrCruiserSkillLevelPreMulShipBonusAC3Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6487 -> { DogmaEffectData.id= 6487; name= "modifyEnergyWarfareResistance"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6584 -> { DogmaEffectData.id= 6584; name= "skillMultiplierShipBonusCarrierCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6681 -> { DogmaEffectData.id= 6681; name= "shipBonusRole3NumWarfareLinks"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6778 -> { DogmaEffectData.id= 6778; name= "informationCommandStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6875 -> { DogmaEffectData.id= 6875; name= "blackOpsSkillMultiplier3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7069 -> { DogmaEffectData.id= 7069; name= "precursorBattleShipSkillLevelPreMulShipBonusPBS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7166 -> { DogmaEffectData.id= 7166; name= "ShipModuleRemoteArmorMutadaptiveRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 958 -> { DogmaEffectData.id= 958; name= "shipArmorEmResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None