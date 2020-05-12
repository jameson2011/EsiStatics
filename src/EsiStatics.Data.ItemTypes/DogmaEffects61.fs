namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects61=
    let getDogmaEffect id = 
      match id with 
      | 1322 -> { DogmaEffectData.id= 1322; name= "propulsionSkillMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5539; postExpression= 5540 } |> Some
      | 1807 -> { DogmaEffectData.id= 1807; name= "shipArmorEXResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2098 -> { DogmaEffectData.id= 2098; name= "modifyActiveArmorResonanceAndNullifyPassiveResonance"; description= ""; displayName= ""; effectCategory= 1; preExpression= 7906; postExpression= 7907 } |> Some
      | 2195 -> { DogmaEffectData.id= 2195; name= "entityArmorRepairingSmall"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2777 -> { DogmaEffectData.id= 2777; name= "boosterModifyBoosterTurretTrackingOptimalPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9935; postExpression= 9936 } |> Some
      | 2874 -> { DogmaEffectData.id= 2874; name= "missileExplosiveDmgBonusCruise"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10173; postExpression= 10174 } |> Some
      | 2971 -> { DogmaEffectData.id= 2971; name= "bombLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 3068 -> { DogmaEffectData.id= 3068; name= "controlTowerGenericHullThermicResistanceBonusCynoJammer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10761; postExpression= 10762 } |> Some
      | 3262 -> { DogmaEffectData.id= 3262; name= "oreCapitalShipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3359 -> { DogmaEffectData.id= 3359; name= "electronicAttackShipsSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3456 -> { DogmaEffectData.id= 3456; name= "warpDisruptionFieldAfterburnerSpeedBoostFactorOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11901; postExpression= 11902 } |> Some
      | 352 -> { DogmaEffectData.id= 352; name= "fasttalkFastTalkMutatorPostPercentFastTalkPercentageChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3553 -> { DogmaEffectData.id= 3553; name= "targetGunneryMaxRangeBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12228; postExpression= 12229 } |> Some
      | 3650 -> { DogmaEffectData.id= 3650; name= "ewGroupRsdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3844 -> { DogmaEffectData.id= 3844; name= "subsystemSkillLevelMinmatarOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4038 -> { DogmaEffectData.id= 4038; name= "systemOverloadEcmStrength"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4135 -> { DogmaEffectData.id= 4135; name= "systemShieldEmResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4232 -> { DogmaEffectData.id= 4232; name= "subsystemBonusGallenteEngineering2CapacitorRechargeRate"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14059; postExpression= 14060 } |> Some
      | 4329 -> { DogmaEffectData.id= 4329; name= "subsystemBonusGallenteOffensive3DroneDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4426 -> { DogmaEffectData.id= 4426; name= "missileDMGBonus1"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14511; postExpression= 14512 } |> Some
      | 4523 -> { DogmaEffectData.id= 4523; name= "fighterBomberKineticDamageBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14816; postExpression= 14817 } |> Some
      | 4620 -> { DogmaEffectData.id= 4620; name= "shipBonusWarpScramblerMaxRangeGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4814 -> { DogmaEffectData.id= 4814; name= "jumpPortalConsumptionBonusPercentSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4911 -> { DogmaEffectData.id= 4911; name= "modifyShieldRechargeRatePassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5008 -> { DogmaEffectData.id= 5008; name= "shipShieldEMResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5105 -> { DogmaEffectData.id= 5105; name= "shipBonusShieldTransferCapNeedMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5299 -> { DogmaEffectData.id= 5299; name= "shipBonusDroneHitpoints1AD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16799; postExpression= 16800 } |> Some
      | 5396 -> { DogmaEffectData.id= 5396; name= "baseMaxScanDeviationModifierModuleOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 13834; postExpression= 13835 } |> Some
      | 5687 -> { DogmaEffectData.id= 5687; name= "shipSmallMissileDmgAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17675; postExpression= 17676 } |> Some
      | 5881 -> { DogmaEffectData.id= 5881; name= "eliteIndustrialShieldResists2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6075 -> { DogmaEffectData.id= 6075; name= "shipBonusHeavyAssaultMissileEmDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18649; postExpression= 18650 } |> Some
      | 61 -> { DogmaEffectData.id= 61; name= "agilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6172 -> { DogmaEffectData.id= 6172; name= "battlecruiserMETRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6269 -> { DogmaEffectData.id= 6269; name= "shipBonusEnergyNeutOptimalEAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19066; postExpression= 19067 } |> Some
      | 6560 -> { DogmaEffectData.id= 6560; name= "skillBonusFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6657 -> { DogmaEffectData.id= 6657; name= "shipBonusTitanC5AllDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6754 -> { DogmaEffectData.id= 6754; name= "behaviorTargetPainter"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6851 -> { DogmaEffectData.id= 6851; name= "shipBonusRole3CapitalEnergyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6948 -> { DogmaEffectData.id= 6948; name= "subSystemBonusCaldariDefensive3TractorBeamBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14452; postExpression= 14453 } |> Some
      | 7045 -> { DogmaEffectData.id= 7045; name= "shipSignatureRadiusMC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7142 -> { DogmaEffectData.id= 7142; name= "massEntanglerEffect5"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7239 -> { DogmaEffectData.id= 7239; name= "shipBonusDreadnoughtPC2ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 934 -> { DogmaEffectData.id= 934; name= "shipMaxVelocityMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4238; postExpression= 4239 } |> Some
      | _ -> None