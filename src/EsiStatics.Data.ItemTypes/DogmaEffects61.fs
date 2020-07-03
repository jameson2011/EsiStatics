namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects61=
    let getDogmaEffect id = 
      match id with 
      | 1807 -> { DogmaEffectData.id= 1807; name= "shipArmorEXResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2195 -> { DogmaEffectData.id= 2195; name= "entityArmorRepairingSmall"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2971 -> { DogmaEffectData.id= 2971; name= "bombLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 3262 -> { DogmaEffectData.id= 3262; name= "oreCapitalShipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3359 -> { DogmaEffectData.id= 3359; name= "electronicAttackShipsSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 352 -> { DogmaEffectData.id= 352; name= "fasttalkFastTalkMutatorPostPercentFastTalkPercentageChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3650 -> { DogmaEffectData.id= 3650; name= "ewGroupRsdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3844 -> { DogmaEffectData.id= 3844; name= "subsystemSkillLevelMinmatarOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4038 -> { DogmaEffectData.id= 4038; name= "systemOverloadEcmStrength"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4135 -> { DogmaEffectData.id= 4135; name= "systemShieldEmResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4329 -> { DogmaEffectData.id= 4329; name= "subsystemBonusGallenteOffensive3DroneDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4620 -> { DogmaEffectData.id= 4620; name= "shipBonusWarpScramblerMaxRangeGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4814 -> { DogmaEffectData.id= 4814; name= "jumpPortalConsumptionBonusPercentSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4911 -> { DogmaEffectData.id= 4911; name= "modifyShieldRechargeRatePassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5008 -> { DogmaEffectData.id= 5008; name= "shipShieldEMResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5105 -> { DogmaEffectData.id= 5105; name= "shipBonusShieldTransferCapNeedMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5881 -> { DogmaEffectData.id= 5881; name= "eliteIndustrialShieldResists2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 61 -> { DogmaEffectData.id= 61; name= "agilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6172 -> { DogmaEffectData.id= 6172; name= "battlecruiserMETRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6560 -> { DogmaEffectData.id= 6560; name= "skillBonusFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6657 -> { DogmaEffectData.id= 6657; name= "shipBonusTitanC5AllDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6754 -> { DogmaEffectData.id= 6754; name= "behaviorTargetPainter"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6851 -> { DogmaEffectData.id= 6851; name= "shipBonusRole3CapitalEnergyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7045 -> { DogmaEffectData.id= 7045; name= "shipSignatureRadiusMC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7142 -> { DogmaEffectData.id= 7142; name= "massEntanglerEffect5"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7239 -> { DogmaEffectData.id= 7239; name= "shipBonusDreadnoughtPC2ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None