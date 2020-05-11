namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects59=
    let getDogmaEffect id = 
      match id with 
      | 1126 -> { DogmaEffectData.id= 1126; name= "shipHybridDmgGBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4902; postExpression= 4903 } |> Some
      | 1320 -> { DogmaEffectData.id= 1320; name= "propulsionSkillFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5534; postExpression= 5535 } |> Some
      | 1805 -> { DogmaEffectData.id= 1805; name= "shipArmorTHResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6980; postExpression= 6981 } |> Some
      | 2193 -> { DogmaEffectData.id= 2193; name= "entityShieldBoostingMedium"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4037; postExpression= 131 } |> Some
      | 253 -> { DogmaEffectData.id= 253; name= "shadowBarrageDmgMultiplierWithDamageMultiplierPostPercentBarrageDmgMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1645; postExpression= 1646 } |> Some
      | 2775 -> { DogmaEffectData.id= 2775; name= "boosterModifyBoosterMissileAOEPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9931; postExpression= 9932 } |> Some
      | 2872 -> { DogmaEffectData.id= 2872; name= "missileVelocityBonusDefender"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10164; postExpression= 10165 } |> Some
      | 3066 -> { DogmaEffectData.id= 3066; name= "controlTowerGenericHullKineticResistanceBonusCynoGenerator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10751; postExpression= 10752 } |> Some
      | 3260 -> { DogmaEffectData.id= 3260; name= "industrialCoreCommandBonusEffectiveAdd"; description= ""; displayName= ""; effectCategory= 1; preExpression= 11324; postExpression= 11325 } |> Some
      | 3357 -> { DogmaEffectData.id= 3357; name= "eliteBonusHeavyInterdictorLightMissileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11610; postExpression= 11611 } |> Some
      | 3454 -> { DogmaEffectData.id= 3454; name= "warpDisruptionFieldMassBonusPercentageOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11224; postExpression= 11225 } |> Some
      | 350 -> { DogmaEffectData.id= 350; name= "fasttalkSkillBoostFastTalkMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2067; postExpression= 2068 } |> Some
      | 3648 -> { DogmaEffectData.id= 3648; name= "scriptWarpScrambleRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12514; postExpression= 12515 } |> Some
      | 3745 -> { DogmaEffectData.id= 3745; name= "zColinOrcaSurveyScannerBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12757; postExpression= 12758 } |> Some
      | 3842 -> { DogmaEffectData.id= 3842; name= "subsystemSkillLevelGallenteEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13022; postExpression= 13023 } |> Some
      | 4036 -> { DogmaEffectData.id= 4036; name= "systemOverloadDurationBonus"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13496; postExpression= 13497 } |> Some
      | 4133 -> { DogmaEffectData.id= 4133; name= "subsystemBonusGallenteDefensiveDroneHPShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13774; postExpression= 13775 } |> Some
      | 4230 -> { DogmaEffectData.id= 4230; name= "subsystemBonusAmarrEngineering2CapacitorRechargeRate"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14055; postExpression= 14056 } |> Some
      | 4327 -> { DogmaEffectData.id= 4327; name= "subsystemBonusAmarrOffensive3DroneDamageHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14264; postExpression= 14265 } |> Some
      | 4424 -> { DogmaEffectData.id= 4424; name= "missileDMGBonusTemp"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14507; postExpression= 14508 } |> Some
      | 4521 -> { DogmaEffectData.id= 4521; name= "fighterBomberEmDamageBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14808; postExpression= 14809 } |> Some
      | 4618 -> { DogmaEffectData.id= 4618; name= "shipBonusDroneDamageMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15099; postExpression= 15100 } |> Some
      | 4812 -> { DogmaEffectData.id= 4812; name= "ecmRadarStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15504; postExpression= 15505 } |> Some
      | 4909 -> { DogmaEffectData.id= 4909; name= "setWeaponDurationToValue"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15824; postExpression= 15825 } |> Some
      | 5103 -> { DogmaEffectData.id= 5103; name= "shipBonusShieldTransferCapNeedCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16321; postExpression= 16322 } |> Some
      | 5200 -> { DogmaEffectData.id= 5200; name= "armorUpgradesSkillBoostMassPenaltyReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16541; postExpression= 16542 } |> Some
      | 5297 -> { DogmaEffectData.id= 5297; name= "shipBonusDroneHullHitpointsAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16795; postExpression= 16796 } |> Some
      | 5394 -> { DogmaEffectData.id= 5394; name= "shipMissileThermDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16980; postExpression= 16981 } |> Some
      | 5588 -> { DogmaEffectData.id= 5588; name= "marauderModeEffect11"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17466; postExpression= 17467 } |> Some
      | 5782 -> { DogmaEffectData.id= 5782; name= "droneDmgBonusRequiringLightDroneOperation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17909; postExpression= 17910 } |> Some
      | 59 -> { DogmaEffectData.id= 59; name= "cargoCapacityMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 490; postExpression= 491 } |> Some
      | 6073 -> { DogmaEffectData.id= 6073; name= "shipBonusHeavyAssaultMissileKineticDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18645; postExpression= 18646 } |> Some
      | 6170 -> { DogmaEffectData.id= 6170; name= "entosisCPUPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18904; postExpression= 18905 } |> Some
      | 6267 -> { DogmaEffectData.id= 6267; name= "shipBonusEnergyNeutOptimalEAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19061; postExpression= 19062 } |> Some
      | 6558 -> { DogmaEffectData.id= 6558; name= "moduleBonusOmnidirectionalTrackingLinkOverload"; description= ""; displayName= ""; effectCategory= 5; preExpression= 59; postExpression= 59 } |> Some
      | 6655 -> { DogmaEffectData.id= 6655; name= "shipBonusTitanM2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6752 -> { DogmaEffectData.id= 6752; name= "entityDrifterControlled"; description= "Drifter Controlled effect for NPE NPCs."; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6849 -> { DogmaEffectData.id= 6849; name= "shipModuleFocusedWarpDisruptionScript"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6946 -> { DogmaEffectData.id= 6946; name= "subsystemBonusMinmatarDefensive3LocalRepHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7043 -> { DogmaEffectData.id= 7043; name= "shipShieldHitpointsCC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19409; postExpression= 19410 } |> Some
      | 7140 -> { DogmaEffectData.id= 7140; name= "selfSpeedFactorBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 19618; postExpression= 19620 } |> Some
      | 835 -> { DogmaEffectData.id= 835; name= "freightSkillBoostCargoCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3904; postExpression= 3905 } |> Some
      | _ -> None