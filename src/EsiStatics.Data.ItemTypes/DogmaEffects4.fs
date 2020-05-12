namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects4=
    let getDogmaEffect id = 
      match id with 
      | 101 -> { DogmaEffectData.id= 101; name= "useMissiles"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1265 -> { DogmaEffectData.id= 1265; name= "interceptor2MissileKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5383; postExpression= 5384 } |> Some
      | 2041 -> { DogmaEffectData.id= 2041; name= "modifyArmorResonancePostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2720 -> { DogmaEffectData.id= 2720; name= "drawbackCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9768; postExpression= 9769 } |> Some
      | 2817 -> { DogmaEffectData.id= 2817; name= "shipBonusSurveyProbeExplosionDelaySkillSurveyMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10002; postExpression= 10003 } |> Some
      | 3108 -> { DogmaEffectData.id= 3108; name= "controlTowerGenericHullThermicResistanceBonusScrambler"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10931; postExpression= 10932 } |> Some
      | 3205 -> { DogmaEffectData.id= 3205; name= "eliteBonusCoverOpsCruiseKineticDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11193; postExpression= 11194 } |> Some
      | 3399 -> { DogmaEffectData.id= 3399; name= "eliteBonusBlackOpsECMRadarStrengthBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11738; postExpression= 11739 } |> Some
      | 3496 -> { DogmaEffectData.id= 3496; name= "setBonusThukker"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3593 -> { DogmaEffectData.id= 3593; name= "eliteBonusJumpFreighterJumpDriveConsumptionAmount2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3690 -> { DogmaEffectData.id= 3690; name= "targetGunneryMaxRangeAndTrackingSpeedAndFalloffBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12625; postExpression= 12626 } |> Some
      | 3787 -> { DogmaEffectData.id= 3787; name= "modifyHullResonancePostPercentKinetic"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12869; postExpression= 12870 } |> Some
      | 3884 -> { DogmaEffectData.id= 3884; name= "subsystemBonusMinmatarElectronicMaxTargetRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13133; postExpression= 13134 } |> Some
      | 392 -> { DogmaEffectData.id= 392; name= "mechanicHullHpBonusPostPercentHpShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3981 -> { DogmaEffectData.id= 3981; name= "subsystemBonusCaldariDefensiveArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13327; postExpression= 13328 } |> Some
      | 4 -> { DogmaEffectData.id= 4; name= "shieldBoosting"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4078 -> { DogmaEffectData.id= 4078; name= "systemHeavyAssaultMissileThermalDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13633; postExpression= 13634 } |> Some
      | 4272 -> { DogmaEffectData.id= 4272; name= "subsystemBonusGallenteCore2MaxTargetingRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4369 -> { DogmaEffectData.id= 4369; name= "subsystemBonusWarpBubbleImmune"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4854 -> { DogmaEffectData.id= 4854; name= "shipLargeLaserCapBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15675; postExpression= 15676 } |> Some
      | 4951 -> { DogmaEffectData.id= 4951; name= "shieldBoostAmplifierPassiveBooster"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5048 -> { DogmaEffectData.id= 5048; name= "shipBonusSalvageCycleGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5145 -> { DogmaEffectData.id= 5145; name= "shipBonusDroneHullHitpointsDF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16411; postExpression= 16412 } |> Some
      | 5339 -> { DogmaEffectData.id= 5339; name= "shipBonusHeavyAssaultMissileKineticDamageCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5436 -> { DogmaEffectData.id= 5436; name= "	hackingSkillVirusBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17076; postExpression= 17077 } |> Some
      | 5533 -> { DogmaEffectData.id= 5533; name= "roleBonusSiegeWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17336; postExpression= 17337 } |> Some
      | 5630 -> { DogmaEffectData.id= 5630; name= "shipBonusCruiseMissileKineticDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5824 -> { DogmaEffectData.id= 5824; name= "shipBonusMediumDroneShieldHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 586 -> { DogmaEffectData.id= 586; name= "decreaseTargetSpeed"; description= ""; displayName= "Decrease Target Speed"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5921 -> { DogmaEffectData.id= 5921; name= "systemTargetPainterMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6115 -> { DogmaEffectData.id= 6115; name= "missileAOECloudSizeBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 15886; postExpression= 15887 } |> Some
      | 6309 -> { DogmaEffectData.id= 6309; name= "shipBonusKineticMissileDmgMD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6406 -> { DogmaEffectData.id= 6406; name= "structureRigEWMaxRangeFalloff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6503 -> { DogmaEffectData.id= 6503; name= "shipBonusDreadnoughtA3CapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6600 -> { DogmaEffectData.id= 6600; name= "shipBonusCarrierC1ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6697 -> { DogmaEffectData.id= 6697; name= "rigDrawbackReductionArmor"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6794 -> { DogmaEffectData.id= 6794; name= "shieldCommandBurstBonusORECapital3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6891 -> { DogmaEffectData.id= 6891; name= "reactionTimeBonusPostPercentManufactureTimeMultiplierChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6988 -> { DogmaEffectData.id= 6988; name= "refineryServiceFuelBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7085 -> { DogmaEffectData.id= 7085; name= "shipbonusPCTDamagePC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None