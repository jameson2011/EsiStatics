namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects55=
    let getDogmaEffect id = 
      match id with 
      | 1025 -> { DogmaEffectData.id= 1025; name= "shipMissileLightVelocityBonusCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1219 -> { DogmaEffectData.id= 1219; name= "shipEnergyVampireTransferAmountBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 152 -> { DogmaEffectData.id= 152; name= "skillBoostDamageMultiplierBonus"; description= "Boost of damageMultiplierBonus by PreMul of skillLevel"; displayName= "SkillBoostDamageMultiplierBonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2189 -> { DogmaEffectData.id= 2189; name= "shipBonusDroneDamageMultiplierAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2868 -> { DogmaEffectData.id= 2868; name= "armorDamageAmountBonusCapitalArmorRepairers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 346 -> { DogmaEffectData.id= 346; name= "criminalConnectionsSkillBoostCriminalConnectionsMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3741 -> { DogmaEffectData.id= 3741; name= "industrialCommandShipSkillLevelMultiplierICS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3838 -> { DogmaEffectData.id= 3838; name= "subsystemSkillLevelCaldariElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5293 -> { DogmaEffectData.id= 5293; name= "shipLaserCapNeed2AD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 55 -> { DogmaEffectData.id= 55; name= "targetHostiles"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5778 -> { DogmaEffectData.id= 5778; name= "shipMissileRoFMF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6166 -> { DogmaEffectData.id= 6166; name= "shipBonusWDFGnullPenalties"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6360 -> { DogmaEffectData.id= 6360; name= "shipRocketEMThermKinDmgMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6554 -> { DogmaEffectData.id= 6554; name= "fighterAbilityKamikaze"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6651 -> { DogmaEffectData.id= 6651; name= "shipModuleAncillaryRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6845 -> { DogmaEffectData.id= 6845; name= "shipBonusCommandDestroyerRole1DefenderBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6942 -> { DogmaEffectData.id= 6942; name= "subsystemBonusMinmatarDefensive2HardenerHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7039 -> { DogmaEffectData.id= 7039; name= "structureHiddenMissileDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7233 -> { DogmaEffectData.id= 7233; name= "modifyDamageMultiplierBonusPerCycle"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 734 -> { DogmaEffectData.id= 734; name= "amarrBattleshipSkillLevelPreMulShipBonusAB2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 928 -> { DogmaEffectData.id= 928; name= "gallenteCruiserSkillLevelPreMulShipBonusGC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None