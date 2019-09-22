namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects59=
    let getDogmaEffect id = 
      match id with 
      | 1805 -> { DogmaEffectData.id= 1805; name= "shipArmorTHResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6980; postExpression= 6981 } |> Some
      | 2193 -> { DogmaEffectData.id= 2193; name= "entityShieldBoostingMedium"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4037; postExpression= 131 } |> Some
      | 253 -> { DogmaEffectData.id= 253; name= "shadowBarrageDmgMultiplierWithDamageMultiplierPostPercentBarrageDmgMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1645; postExpression= 1646 } |> Some
      | 2872 -> { DogmaEffectData.id= 2872; name= "missileVelocityBonusDefender"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10164; postExpression= 10165 } |> Some
      | 3357 -> { DogmaEffectData.id= 3357; name= "eliteBonusHeavyInterdictorLightMissileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11610; postExpression= 11611 } |> Some
      | 350 -> { DogmaEffectData.id= 350; name= "fasttalkSkillBoostFastTalkMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2067; postExpression= 2068 } |> Some
      | 3648 -> { DogmaEffectData.id= 3648; name= "scriptWarpScrambleRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12514; postExpression= 12515 } |> Some
      | 3745 -> { DogmaEffectData.id= 3745; name= "zColinOrcaSurveyScannerBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12757; postExpression= 12758 } |> Some
      | 3842 -> { DogmaEffectData.id= 3842; name= "subsystemSkillLevelGallenteEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13022; postExpression= 13023 } |> Some
      | 4036 -> { DogmaEffectData.id= 4036; name= "systemOverloadDurationBonus"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13496; postExpression= 13497 } |> Some
      | 4327 -> { DogmaEffectData.id= 4327; name= "subsystemBonusAmarrOffensive3DroneDamageHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14264; postExpression= 14265 } |> Some
      | 4812 -> { DogmaEffectData.id= 4812; name= "ecmRadarStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15504; postExpression= 15505 } |> Some
      | 5103 -> { DogmaEffectData.id= 5103; name= "shipBonusShieldTransferCapNeedCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16321; postExpression= 16322 } |> Some
      | 5200 -> { DogmaEffectData.id= 5200; name= "armorUpgradesSkillBoostMassPenaltyReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16541; postExpression= 16542 } |> Some
      | 59 -> { DogmaEffectData.id= 59; name= "cargoCapacityMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 490; postExpression= 491 } |> Some
      | 6170 -> { DogmaEffectData.id= 6170; name= "entosisCPUPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18904; postExpression= 18905 } |> Some
      | 6267 -> { DogmaEffectData.id= 6267; name= "shipBonusEnergyNeutOptimalEAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19061; postExpression= 19062 } |> Some
      | 6558 -> { DogmaEffectData.id= 6558; name= "moduleBonusOmnidirectionalTrackingLinkOverload"; description= ""; displayName= ""; effectCategory= 5; preExpression= 59; postExpression= 59 } |> Some
      | 6655 -> { DogmaEffectData.id= 6655; name= "shipBonusTitanM2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6752 -> { DogmaEffectData.id= 6752; name= "entityDrifterControlled"; description= "Drifter Controlled effect for NPE NPCs."; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6849 -> { DogmaEffectData.id= 6849; name= "shipModuleFocusedWarpDisruptionScript"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6946 -> { DogmaEffectData.id= 6946; name= "subsystemBonusMinmatarDefensive3LocalRepHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7043 -> { DogmaEffectData.id= 7043; name= "shipShieldHitpointsCC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19409; postExpression= 19410 } |> Some
      | 835 -> { DogmaEffectData.id= 835; name= "freightSkillBoostCargoCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3904; postExpression= 3905 } |> Some
      | _ -> None