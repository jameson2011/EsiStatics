namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects61=
    let getDogmaEffect id = 
      match id with 
      | 1807 -> { DogmaEffectData.id= 1807; name= "shipArmorEXResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6984; postExpression= 6985 } |> Some
      | 2195 -> { DogmaEffectData.id= 2195; name= "entityArmorRepairingSmall"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4039; postExpression= 131 } |> Some
      | 2971 -> { DogmaEffectData.id= 2971; name= "bombLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 114; postExpression= 89 } |> Some
      | 3262 -> { DogmaEffectData.id= 3262; name= "oreCapitalShipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11340; postExpression= 11341 } |> Some
      | 3359 -> { DogmaEffectData.id= 3359; name= "electronicAttackShipsSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11621; postExpression= 11622 } |> Some
      | 352 -> { DogmaEffectData.id= 352; name= "fasttalkFastTalkMutatorPostPercentFastTalkPercentageChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2074; postExpression= 2075 } |> Some
      | 3650 -> { DogmaEffectData.id= 3650; name= "ewGroupRsdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12520; postExpression= 12521 } |> Some
      | 3844 -> { DogmaEffectData.id= 3844; name= "subsystemSkillLevelMinmatarOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13034; postExpression= 13035 } |> Some
      | 4038 -> { DogmaEffectData.id= 4038; name= "systemOverloadEcmStrength"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13504; postExpression= 13505 } |> Some
      | 4135 -> { DogmaEffectData.id= 4135; name= "systemShieldEmResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13778; postExpression= 13779 } |> Some
      | 4329 -> { DogmaEffectData.id= 4329; name= "subsystemBonusGallenteOffensive3DroneDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14268; postExpression= 14270 } |> Some
      | 4620 -> { DogmaEffectData.id= 4620; name= "shipBonusWarpScramblerMaxRangeGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15103; postExpression= 15104 } |> Some
      | 4814 -> { DogmaEffectData.id= 4814; name= "jumpPortalConsumptionBonusPercentSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15511; postExpression= 15512 } |> Some
      | 4911 -> { DogmaEffectData.id= 4911; name= "modifyShieldRechargeRatePassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 439; postExpression= 440 } |> Some
      | 5008 -> { DogmaEffectData.id= 5008; name= "shipShieldEMResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16099; postExpression= 16100 } |> Some
      | 5105 -> { DogmaEffectData.id= 5105; name= "shipBonusShieldTransferCapNeedMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16325; postExpression= 16326 } |> Some
      | 5881 -> { DogmaEffectData.id= 5881; name= "eliteIndustrialShieldResists2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18154; postExpression= 18155 } |> Some
      | 61 -> { DogmaEffectData.id= 61; name= "agilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 500; postExpression= 501 } |> Some
      | 6172 -> { DogmaEffectData.id= 6172; name= "battlecruiserMETRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18911; postExpression= 18912 } |> Some
      | 6560 -> { DogmaEffectData.id= 6560; name= "skillBonusFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6657 -> { DogmaEffectData.id= 6657; name= "shipBonusTitanC5AllDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6754 -> { DogmaEffectData.id= 6754; name= "behaviorTargetPainter"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6851 -> { DogmaEffectData.id= 6851; name= "shipBonusRole3CapitalEnergyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7045 -> { DogmaEffectData.id= 7045; name= "shipSignatureRadiusMC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19409; postExpression= 19410 } |> Some
      | 7142 -> { DogmaEffectData.id= 7142; name= "massEntanglerEffect5"; description= ""; displayName= ""; effectCategory= 1; preExpression= 19623; postExpression= 19624 } |> Some
      | _ -> None