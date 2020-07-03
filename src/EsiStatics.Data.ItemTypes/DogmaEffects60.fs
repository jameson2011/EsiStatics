namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects60=
    let getDogmaEffect id = 
      match id with 
      | 1030 -> { DogmaEffectData.id= 1030; name= "remoteArmorSystemsCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringRemoteArmorSystems"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1321 -> { DogmaEffectData.id= 1321; name= "ewSkillScanStrengthBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 157 -> { DogmaEffectData.id= 157; name= "largeHybridTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringLargeHybridTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1806 -> { DogmaEffectData.id= 1806; name= "shipArmorKNResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2000 -> { DogmaEffectData.id= 2000; name= "droneRangeBonusAdd"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2194 -> { DogmaEffectData.id= 2194; name= "entityShieldBoostingLarge"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2485 -> { DogmaEffectData.id= 2485; name= "implantArmorHpBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 254 -> { DogmaEffectData.id= 254; name= "shadowBarrageFalloffWithFalloffPostPercentBarrageFalloffMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2776 -> { DogmaEffectData.id= 2776; name= "boosterModifyBoosterMissilePenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3261 -> { DogmaEffectData.id= 3261; name= "shipCommandBonusEffectiveMultiplierOreCapital2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3358 -> { DogmaEffectData.id= 3358; name= "electronicAttackShipsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3649 -> { DogmaEffectData.id= 3649; name= "eliteBonusViolatorsLargeEnergyTurretDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3843 -> { DogmaEffectData.id= 3843; name= "subsystemSkillLevelMinmatarEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4037 -> { DogmaEffectData.id= 4037; name= "systemOverloadEccmStrength"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 448 -> { DogmaEffectData.id= 448; name= "scoutDroneOperationSkillBoostDroneRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4619 -> { DogmaEffectData.id= 4619; name= "shipBonusDroneDamageGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4813 -> { DogmaEffectData.id= 4813; name= "skillConsumptionQuantityBonusPercentSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4910 -> { DogmaEffectData.id= 4910; name= "setWeaponSpeedToValue"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5104 -> { DogmaEffectData.id= 5104; name= "shipBonusShieldTransferBoostAmountCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5201 -> { DogmaEffectData.id= 5201; name= "armorUpgradesMassPenaltyReductionBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 60 -> { DogmaEffectData.id= 60; name= "structureHPMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6171 -> { DogmaEffectData.id= 6171; name= "entosisCPUAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6559 -> { DogmaEffectData.id= 6559; name= "moduleBonusOmnidirectionalTrackingEnhancer"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6656 -> { DogmaEffectData.id= 6656; name= "shipBonusRole3XLTorpdeoVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6753 -> { DogmaEffectData.id= 6753; name= "moduleTitanEffectGenerator"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6947 -> { DogmaEffectData.id= 6947; name= "subSystemBonusCaldariDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7044 -> { DogmaEffectData.id= 7044; name= "shipAgilityBonusGC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7238 -> { DogmaEffectData.id= 7238; name= "shipBonusDreadnoughtPC1DamageMultMax"; description= "precursor XL weapon damage modifier by skill level"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 836 -> { DogmaEffectData.id= 836; name= "skillFreightBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None