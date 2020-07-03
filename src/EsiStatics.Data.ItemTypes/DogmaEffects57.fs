namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects57=
    let getDogmaEffect id = 
      match id with 
      | 1221 -> { DogmaEffectData.id= 1221; name= "shipStasisWebRangeBonusMB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1318 -> { DogmaEffectData.id= 1318; name= "ewSkillScanStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 251 -> { DogmaEffectData.id= 251; name= "hullUpgradesSkillBoostHullHpBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2967 -> { DogmaEffectData.id= 2967; name= "skillTriageModuleConsumptionQuantityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3355 -> { DogmaEffectData.id= 3355; name= "eliteBonusHeavyInterdictorHeavyMissileVelocityBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 348 -> { DogmaEffectData.id= 348; name= "diplomacySkillBoostDiplomacyMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3743 -> { DogmaEffectData.id= 3743; name= "industrialCommandShipSkillLevelMultiplierICS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3840 -> { DogmaEffectData.id= 3840; name= "subsystemSkillLevelAmarrEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4034 -> { DogmaEffectData.id= 4034; name= "systemOverloadArmor"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 445 -> { DogmaEffectData.id= 445; name= "energyManagementCapacitorBonusPostPercentCapacityLocationShipGroupCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4810 -> { DogmaEffectData.id= 4810; name= "ecmLadarStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5295 -> { DogmaEffectData.id= 5295; name= "shipBonusDroneDamageMultiplierAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 542 -> { DogmaEffectData.id= 542; name= "shipCapNeedBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 57 -> { DogmaEffectData.id= 57; name= "shieldCapacityMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6362 -> { DogmaEffectData.id= 6362; name= "roleBonusStasisRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6556 -> { DogmaEffectData.id= 6556; name= "moduleBonusDroneDamageAmplifier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6653 -> { DogmaEffectData.id= 6653; name= "shipBonusTitanA2CapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6944 -> { DogmaEffectData.id= 6944; name= "subsystemBonusGallenteDefensive3ArmorRepHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7041 -> { DogmaEffectData.id= 7041; name= "flagCruiserSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7235 -> { DogmaEffectData.id= 7235; name= "aoeDamageMultiplier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 736 -> { DogmaEffectData.id= 736; name= "shipBonusCapCapAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8011 -> { DogmaEffectData.id= 8011; name= "shieldHpBonusPostPercentHpLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None