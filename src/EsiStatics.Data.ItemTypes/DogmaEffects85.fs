namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects85=
    let getDogmaEffect id = 
      match id with 
      | 1152 -> { DogmaEffectData.id= 1152; name= "controlTowerGallenteHybridDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1443 -> { DogmaEffectData.id= 1443; name= "caldariShipEwCapacitorNeedCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2413 -> { DogmaEffectData.id= 2413; name= "snowBallLaunching"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 279 -> { DogmaEffectData.id= 279; name= "shieldEmmisionSystemsCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringShieldEmmisionSystems"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2801 -> { DogmaEffectData.id= 2801; name= "energyWeaponSpeedMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3189 -> { DogmaEffectData.id= 3189; name= "overloadSelfECCMStrenghtBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3480 -> { DogmaEffectData.id= 3480; name= "shipTrackingBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3674 -> { DogmaEffectData.id= 3674; name= "jumpPortalGenerationBO"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 3771 -> { DogmaEffectData.id= 3771; name= "armorHPBonusAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3868 -> { DogmaEffectData.id= 3868; name= "subsystemBonusMinmatarPropulsion2Agility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4062 -> { DogmaEffectData.id= 4062; name= "systemStandardMissileEmDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4159 -> { DogmaEffectData.id= 4159; name= "subsystemBonusAmarrCoreCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4256 -> { DogmaEffectData.id= 4256; name= "subsystemBonusMinmatarOffensive2MissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
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
      | 8039 -> { DogmaEffectData.id= 8039; name= "upwellSkillaoeVelocityaoeCloudSizeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 958 -> { DogmaEffectData.id= 958; name= "shipArmorEmResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None