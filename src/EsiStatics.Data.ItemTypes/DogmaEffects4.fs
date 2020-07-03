namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects4=
    let getDogmaEffect id = 
      match id with 
      | 101 -> { DogmaEffectData.id= 101; name= "useMissiles"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2041 -> { DogmaEffectData.id= 2041; name= "modifyArmorResonancePostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 3496 -> { DogmaEffectData.id= 3496; name= "setBonusThukker"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3593 -> { DogmaEffectData.id= 3593; name= "eliteBonusJumpFreighterJumpDriveConsumptionAmount2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 392 -> { DogmaEffectData.id= 392; name= "mechanicHullHpBonusPostPercentHpShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4 -> { DogmaEffectData.id= 4; name= "shieldBoosting"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4272 -> { DogmaEffectData.id= 4272; name= "subsystemBonusGallenteCore2MaxTargetingRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4369 -> { DogmaEffectData.id= 4369; name= "subsystemBonusWarpBubbleImmune"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4951 -> { DogmaEffectData.id= 4951; name= "shieldBoostAmplifierPassiveBooster"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5048 -> { DogmaEffectData.id= 5048; name= "shipBonusSalvageCycleGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5339 -> { DogmaEffectData.id= 5339; name= "shipBonusHeavyAssaultMissileKineticDamageCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5630 -> { DogmaEffectData.id= 5630; name= "shipBonusCruiseMissileKineticDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5824 -> { DogmaEffectData.id= 5824; name= "shipBonusMediumDroneShieldHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 586 -> { DogmaEffectData.id= 586; name= "decreaseTargetSpeed"; description= ""; displayName= "Decrease Target Speed"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5921 -> { DogmaEffectData.id= 5921; name= "systemTargetPainterMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
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