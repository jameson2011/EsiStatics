namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects44=
    let getDogmaEffect id = 
      match id with 
      | 1014 -> { DogmaEffectData.id= 1014; name= "selfT2MediumProjectileArtyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4498; postExpression= 4499 } |> Some
      | 1111 -> { DogmaEffectData.id= 1111; name= "battlecruiserSkillLevelPreMulShipBonusBC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4862; postExpression= 4863 } |> Some
      | 1305 -> { DogmaEffectData.id= 1305; name= "eliteIndustrialShieldBoostCapNeedElite2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5476; postExpression= 5477 } |> Some
      | 1402 -> { DogmaEffectData.id= 1402; name= "eliteBonusCoverOpsCloakingVelocity2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5806; postExpression= 5807 } |> Some
      | 1499 -> { DogmaEffectData.id= 1499; name= "shieldOperationSkillBoostCapacitorNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6097; postExpression= 6098 } |> Some
      | 1596 -> { DogmaEffectData.id= 1596; name= "missileSkillWarheadUpgradesExplosiveDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6377; postExpression= 6378 } |> Some
      | 2469 -> { DogmaEffectData.id= 2469; name= "shipAssaultLauncherROFBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9057; postExpression= 9058 } |> Some
      | 2663 -> { DogmaEffectData.id= 2663; name= "rigSlot"; description= "Must be installed into an open rig slot"; displayName= "Rig Slot"; effectCategory= 0; preExpression= 131; postExpression= 131 } |> Some
      | 2760 -> { DogmaEffectData.id= 2760; name= "boosterModifyBoosterArmorPenalties"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9881; postExpression= 9882 } |> Some
      | 2857 -> { DogmaEffectData.id= 2857; name= "cynosuralGeneration"; description= ""; displayName= ""; effectCategory= 1; preExpression= 10124; postExpression= 10125 } |> Some
      | 3148 -> { DogmaEffectData.id= 3148; name= "controlTowerGenericHullResistanceBonusSensorDampener"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11013; postExpression= 11014 } |> Some
      | 3245 -> { DogmaEffectData.id= 3245; name= "shipArmorExplosiveResistance2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11272; postExpression= 11273 } |> Some
      | 3342 -> { DogmaEffectData.id= 3342; name= "eliteBonusHeavyInterdictorsHybridFalloff1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11570; postExpression= 11571 } |> Some
      | 335 -> { DogmaEffectData.id= 335; name= "cSOTrainingResearchGangSizeBonusModAddMaxResearchGangSizeShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1999; postExpression= 2000 } |> Some
      | 3439 -> { DogmaEffectData.id= 3439; name= "eliteBonusViolatorsEwTargetPainting1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11860; postExpression= 11861 } |> Some
      | 4021 -> { DogmaEffectData.id= 4021; name= "systemDamageDrones"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13433; postExpression= 13434 } |> Some
      | 4118 -> { DogmaEffectData.id= 4118; name= "subsystemBonusCaldariOffensiveHeavyMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13742; postExpression= 13743 } |> Some
      | 4215 -> { DogmaEffectData.id= 4215; name= "subsystemBonusAmarrOffensive2EnergyWeaponCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14019; postExpression= 14020 } |> Some
      | 432 -> { DogmaEffectData.id= 432; name= "researchSkillBoostBlueprintmanufactureTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2409; postExpression= 2410 } |> Some
      | 4409 -> { DogmaEffectData.id= 4409; name= "signatureRadiusPreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14455; postExpression= 14456 } |> Some
      | 4700 -> { DogmaEffectData.id= 4700; name= "systemEffectDamageGunnery"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15264; postExpression= 15265 } |> Some
      | 4797 -> { DogmaEffectData.id= 4797; name= "eliteBonusBlackOpsECMBurstGravAndLadar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15466; postExpression= 15467 } |> Some
      | 4894 -> { DogmaEffectData.id= 4894; name= "maxRangeHiddenPreAssignmentWarpScrambleRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15796; postExpression= 15797 } |> Some
      | 4991 -> { DogmaEffectData.id= 4991; name= "shipSETDmgBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16055; postExpression= 16056 } |> Some
      | 5088 -> { DogmaEffectData.id= 5088; name= "shipBonusDroneDamageGF"; description= ""; displayName= ""; effectCategory= 1; preExpression= 16294; postExpression= 16295 } |> Some
      | 5185 -> { DogmaEffectData.id= 5185; name= "shipEnergyVampireAmountBonusFixedAF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16498; postExpression= 16499 } |> Some
      | 5282 -> { DogmaEffectData.id= 5282; name= "destroyerSkillLevelPreMulShipBonusMD1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16746; postExpression= 16747 } |> Some
      | 529 -> { DogmaEffectData.id= 529; name= "shipCargoBonusAI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2818; postExpression= 2819 } |> Some
      | 5379 -> { DogmaEffectData.id= 5379; name= "shipHeavyAssaultMissileAOECloudSizeCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16952; postExpression= 16953 } |> Some
      | 5476 -> { DogmaEffectData.id= 5476; name= "shipBonusOreCapacityGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17200; postExpression= 17201 } |> Some
      | 5573 -> { DogmaEffectData.id= 5573; name= "eliteBonusCommandShipSiegeCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17432; postExpression= 17433 } |> Some
      | 5864 -> { DogmaEffectData.id= 5864; name= "shipMissileThermDamageCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18120; postExpression= 18121 } |> Some
      | 6058 -> { DogmaEffectData.id= 6058; name= "shipBonusMediumDroneArmorHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18619; postExpression= 18620 } |> Some
      | 6155 -> { DogmaEffectData.id= 6155; name= "modeArmorRepDurationPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18861; postExpression= 18862 } |> Some
      | 6446 -> { DogmaEffectData.id= 6446; name= "structureBumpingModule"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6640 -> { DogmaEffectData.id= 6640; name= "shipBonusRole1NumWarfareLinks"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6737 -> { DogmaEffectData.id= 6737; name= "chargeBonusWarfareCharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6834 -> { DogmaEffectData.id= 6834; name= "rigTEResearchCostBonus"; description= "Structure Rig Cost effect on TE Research"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6931 -> { DogmaEffectData.id= 6931; name= "subsystemBonusMinmatarCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13826; postExpression= 13827 } |> Some
      | 7028 -> { DogmaEffectData.id= 7028; name= "structureModifyPowerRechargeRate"; description= ""; displayName= ""; effectCategory= 4; preExpression= 443; postExpression= 444 } |> Some
      | 7222 -> { DogmaEffectData.id= 7222; name= "shipNeutPowerReductionEliteHeavyGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19838; postExpression= 19839 } |> Some
      | 820 -> { DogmaEffectData.id= 820; name= "speedBoostPassive"; description= ""; displayName= "speedBoost"; effectCategory= 4; preExpression= 3517; postExpression= 3518 } |> Some
      | _ -> None