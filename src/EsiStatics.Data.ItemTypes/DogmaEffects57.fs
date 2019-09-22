namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects57=
    let getDogmaEffect id = 
      match id with 
      | 1221 -> { DogmaEffectData.id= 1221; name= "shipStasisWebRangeBonusMB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5263; postExpression= 5264 } |> Some
      | 1318 -> { DogmaEffectData.id= 1318; name= "ewSkillScanStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5526; postExpression= 5527 } |> Some
      | 251 -> { DogmaEffectData.id= 251; name= "hullUpgradesSkillBoostHullHpBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1631; postExpression= 1632 } |> Some
      | 2967 -> { DogmaEffectData.id= 2967; name= "skillTriageModuleConsumptionQuantityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10459; postExpression= 10460 } |> Some
      | 3355 -> { DogmaEffectData.id= 3355; name= "eliteBonusHeavyInterdictorHeavyMissileVelocityBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11606; postExpression= 11607 } |> Some
      | 348 -> { DogmaEffectData.id= 348; name= "diplomacySkillBoostDiplomacyMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2058; postExpression= 2059 } |> Some
      | 3743 -> { DogmaEffectData.id= 3743; name= "industrialCommandShipSkillLevelMultiplierICS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12752; postExpression= 12753 } |> Some
      | 3840 -> { DogmaEffectData.id= 3840; name= "subsystemSkillLevelAmarrEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13012; postExpression= 13013 } |> Some
      | 4034 -> { DogmaEffectData.id= 4034; name= "systemOverloadArmor"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13488; postExpression= 13489 } |> Some
      | 445 -> { DogmaEffectData.id= 445; name= "energyManagementCapacitorBonusPostPercentCapacityLocationShipGroupCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2468; postExpression= 2469 } |> Some
      | 4810 -> { DogmaEffectData.id= 4810; name= "ecmLadarStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15500; postExpression= 15501 } |> Some
      | 5295 -> { DogmaEffectData.id= 5295; name= "shipBonusDroneDamageMultiplierAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16791; postExpression= 16792 } |> Some
      | 542 -> { DogmaEffectData.id= 542; name= "shipCapNeedBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2865; postExpression= 2866 } |> Some
      | 57 -> { DogmaEffectData.id= 57; name= "shieldCapacityMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 485; postExpression= 486 } |> Some
      | 6362 -> { DogmaEffectData.id= 6362; name= "roleBonusStasisRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14666; postExpression= 14667 } |> Some
      | 6556 -> { DogmaEffectData.id= 6556; name= "moduleBonusDroneDamageAmplifier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 59; postExpression= 59 } |> Some
      | 6653 -> { DogmaEffectData.id= 6653; name= "shipBonusTitanA2CapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6944 -> { DogmaEffectData.id= 6944; name= "subsystemBonusGallenteDefensive3ArmorRepHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7041 -> { DogmaEffectData.id= 7041; name= "flagCruiserSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9016; postExpression= 9017 } |> Some
      | 736 -> { DogmaEffectData.id= 736; name= "shipBonusCapCapAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3567; postExpression= 3568 } |> Some
      | _ -> None