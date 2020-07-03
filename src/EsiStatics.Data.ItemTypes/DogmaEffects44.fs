namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects44=
    let getDogmaEffect id = 
      match id with 
      | 1014 -> { DogmaEffectData.id= 1014; name= "selfT2MediumProjectileArtyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1111 -> { DogmaEffectData.id= 1111; name= "battlecruiserSkillLevelPreMulShipBonusBC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1499 -> { DogmaEffectData.id= 1499; name= "shieldOperationSkillBoostCapacitorNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1596 -> { DogmaEffectData.id= 1596; name= "missileSkillWarheadUpgradesExplosiveDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2663 -> { DogmaEffectData.id= 2663; name= "rigSlot"; description= "Must be installed into an open rig slot"; displayName= "Rig Slot"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2760 -> { DogmaEffectData.id= 2760; name= "boosterModifyBoosterArmorPenalties"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2857 -> { DogmaEffectData.id= 2857; name= "cynosuralGeneration"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 335 -> { DogmaEffectData.id= 335; name= "cSOTrainingResearchGangSizeBonusModAddMaxResearchGangSizeShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3439 -> { DogmaEffectData.id= 3439; name= "eliteBonusViolatorsEwTargetPainting1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4021 -> { DogmaEffectData.id= 4021; name= "systemDamageDrones"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4215 -> { DogmaEffectData.id= 4215; name= "subsystemBonusAmarrOffensive2EnergyWeaponCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 432 -> { DogmaEffectData.id= 432; name= "researchSkillBoostBlueprintmanufactureTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4409 -> { DogmaEffectData.id= 4409; name= "signatureRadiusPreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4894 -> { DogmaEffectData.id= 4894; name= "maxRangeHiddenPreAssignmentWarpScrambleRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4991 -> { DogmaEffectData.id= 4991; name= "shipSETDmgBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5185 -> { DogmaEffectData.id= 5185; name= "shipEnergyVampireAmountBonusFixedAF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5282 -> { DogmaEffectData.id= 5282; name= "destroyerSkillLevelPreMulShipBonusMD1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 529 -> { DogmaEffectData.id= 529; name= "shipCargoBonusAI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5379 -> { DogmaEffectData.id= 5379; name= "shipHeavyAssaultMissileAOECloudSizeCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5476 -> { DogmaEffectData.id= 5476; name= "shipBonusOreCapacityGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5573 -> { DogmaEffectData.id= 5573; name= "eliteBonusCommandShipSiegeCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5864 -> { DogmaEffectData.id= 5864; name= "shipMissileThermDamageCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6058 -> { DogmaEffectData.id= 6058; name= "shipBonusMediumDroneArmorHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6155 -> { DogmaEffectData.id= 6155; name= "modeArmorRepDurationPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6446 -> { DogmaEffectData.id= 6446; name= "structureBumpingModule"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6640 -> { DogmaEffectData.id= 6640; name= "shipBonusRole1NumWarfareLinks"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6737 -> { DogmaEffectData.id= 6737; name= "chargeBonusWarfareCharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6834 -> { DogmaEffectData.id= 6834; name= "rigTEResearchCostBonus"; description= "Structure Rig Cost effect on TE Research"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6931 -> { DogmaEffectData.id= 6931; name= "subsystemBonusMinmatarCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7028 -> { DogmaEffectData.id= 7028; name= "structureModifyPowerRechargeRate"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None