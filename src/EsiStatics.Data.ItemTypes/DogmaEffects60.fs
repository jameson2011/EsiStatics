namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects60=
    let getDogmaEffect id = 
      match id with 
      | 1030 -> { DogmaEffectData.id= 1030; name= "remoteArmorSystemsCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringRemoteArmorSystems"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4566; postExpression= 4567 } |> Some
      | 1224 -> { DogmaEffectData.id= 1224; name= "shipMWDCapBonusMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5267; postExpression= 5268 } |> Some
      | 1321 -> { DogmaEffectData.id= 1321; name= "ewSkillScanStrengthBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5537; postExpression= 5538 } |> Some
      | 157 -> { DogmaEffectData.id= 157; name= "largeHybridTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringLargeHybridTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1188; postExpression= 1189 } |> Some
      | 1806 -> { DogmaEffectData.id= 1806; name= "shipArmorKNResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6982; postExpression= 6983 } |> Some
      | 2000 -> { DogmaEffectData.id= 2000; name= "droneRangeBonusAdd"; description= ""; displayName= ""; effectCategory= 4; preExpression= 2674; postExpression= 2675 } |> Some
      | 2194 -> { DogmaEffectData.id= 2194; name= "entityShieldBoostingLarge"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4037; postExpression= 131 } |> Some
      | 2485 -> { DogmaEffectData.id= 2485; name= "implantArmorHpBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9093; postExpression= 9094 } |> Some
      | 254 -> { DogmaEffectData.id= 254; name= "shadowBarrageFalloffWithFalloffPostPercentBarrageFalloffMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1657; postExpression= 1658 } |> Some
      | 2776 -> { DogmaEffectData.id= 2776; name= "boosterModifyBoosterMissilePenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9933; postExpression= 9934 } |> Some
      | 2873 -> { DogmaEffectData.id= 2873; name= "missileEMDmgBonusCruise"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10169; postExpression= 10170 } |> Some
      | 3067 -> { DogmaEffectData.id= 3067; name= "controlTowerGenericHullThermicResistanceBonusCynoGenerator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10755; postExpression= 10756 } |> Some
      | 3261 -> { DogmaEffectData.id= 3261; name= "shipCommandBonusEffectiveMultiplierOreCapital2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11330; postExpression= 11331 } |> Some
      | 3358 -> { DogmaEffectData.id= 3358; name= "electronicAttackShipsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11617; postExpression= 11618 } |> Some
      | 3455 -> { DogmaEffectData.id= 3455; name= "warpDisruptionFieldAfterburnerSpeedFactorOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11895; postExpression= 11896 } |> Some
      | 3552 -> { DogmaEffectData.id= 3552; name= "targetTurretWeaponMaxRangeAndTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12223; postExpression= 12224 } |> Some
      | 3649 -> { DogmaEffectData.id= 3649; name= "eliteBonusViolatorsLargeEnergyTurretDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12516; postExpression= 12517 } |> Some
      | 3746 -> { DogmaEffectData.id= 3746; name= "zColinSkillOrcaSurveyScannerBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12761; postExpression= 12762 } |> Some
      | 3843 -> { DogmaEffectData.id= 3843; name= "subsystemSkillLevelMinmatarEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13027; postExpression= 13028 } |> Some
      | 4037 -> { DogmaEffectData.id= 4037; name= "systemOverloadEccmStrength"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13500; postExpression= 13501 } |> Some
      | 4134 -> { DogmaEffectData.id= 4134; name= "subsystemBonusGallenteOffensiveDroneDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13776; postExpression= 13777 } |> Some
      | 4231 -> { DogmaEffectData.id= 4231; name= "subsystemBonusCaldariEngineering2CapacitorRechargeRate"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14057; postExpression= 14058 } |> Some
      | 4328 -> { DogmaEffectData.id= 4328; name= "subsystemBonusAmarrOffensive3EnergyWeaponTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14267; postExpression= 14269 } |> Some
      | 4425 -> { DogmaEffectData.id= 4425; name= "missileDMGBonusTemp2"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14509; postExpression= 14510 } |> Some
      | 448 -> { DogmaEffectData.id= 448; name= "scoutDroneOperationSkillBoostDroneRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2481; postExpression= 2482 } |> Some
      | 4522 -> { DogmaEffectData.id= 4522; name= "fighterBomberExplosiveDamageBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14812; postExpression= 14813 } |> Some
      | 4619 -> { DogmaEffectData.id= 4619; name= "shipBonusDroneDamageGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15101; postExpression= 15102 } |> Some
      | 4813 -> { DogmaEffectData.id= 4813; name= "skillConsumptionQuantityBonusPercentSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15509; postExpression= 15510 } |> Some
      | 4910 -> { DogmaEffectData.id= 4910; name= "setWeaponSpeedToValue"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15827; postExpression= 15828 } |> Some
      | 5104 -> { DogmaEffectData.id= 5104; name= "shipBonusShieldTransferBoostAmountCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16323; postExpression= 16324 } |> Some
      | 5201 -> { DogmaEffectData.id= 5201; name= "armorUpgradesMassPenaltyReductionBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16545; postExpression= 16546 } |> Some
      | 5298 -> { DogmaEffectData.id= 5298; name= "shipBonusDroneShieldHitpointsAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16797; postExpression= 16798 } |> Some
      | 5395 -> { DogmaEffectData.id= 5395; name= "shipMissileEMDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16982; postExpression= 16983 } |> Some
      | 60 -> { DogmaEffectData.id= 60; name= "structureHPMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 494; postExpression= 495 } |> Some
      | 6074 -> { DogmaEffectData.id= 6074; name= "shipBonusHeavyAssaultMissileExpDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18647; postExpression= 18648 } |> Some
      | 6171 -> { DogmaEffectData.id= 6171; name= "entosisCPUAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18906; postExpression= 18907 } |> Some
      | 6268 -> { DogmaEffectData.id= 6268; name= "shipBonusEnergyNeutOptimalEAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19063; postExpression= 19064 } |> Some
      | 6559 -> { DogmaEffectData.id= 6559; name= "moduleBonusOmnidirectionalTrackingEnhancer"; description= ""; displayName= ""; effectCategory= 4; preExpression= 59; postExpression= 59 } |> Some
      | 6656 -> { DogmaEffectData.id= 6656; name= "shipBonusRole3XLTorpdeoVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6753 -> { DogmaEffectData.id= 6753; name= "moduleTitanEffectGenerator"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6850 -> { DogmaEffectData.id= 6850; name= "chargeRateStructureModulesMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6947 -> { DogmaEffectData.id= 6947; name= "subSystemBonusCaldariDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14414; postExpression= 14415 } |> Some
      | 7044 -> { DogmaEffectData.id= 7044; name= "shipAgilityBonusGC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19409; postExpression= 19410 } |> Some
      | 7141 -> { DogmaEffectData.id= 7141; name= "massEntanglerEffect4"; description= ""; displayName= ""; effectCategory= 1; preExpression= 19621; postExpression= 19622 } |> Some
      | 836 -> { DogmaEffectData.id= 836; name= "skillFreightBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3906; postExpression= 3907 } |> Some
      | _ -> None