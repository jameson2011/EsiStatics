namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects37=
    let getDogmaEffect id = 
      match id with 
      | 1007 -> { DogmaEffectData.id= 1007; name= "selfT2SmallProjectileACDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4456; postExpression= 4457 } |> Some
      | 1395 -> { DogmaEffectData.id= 1395; name= "shieldBoostAmplifierPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3171; postExpression= 3172 } |> Some
      | 2656 -> { DogmaEffectData.id= 2656; name= "scanStrengthBonusSkillLevelIncrease"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9590; postExpression= 9591 } |> Some
      | 2850 -> { DogmaEffectData.id= 2850; name= "durationBonusForGroupAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10109; postExpression= 10110 } |> Some
      | 3335 -> { DogmaEffectData.id= 3335; name= "shipArmorEmResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11556; postExpression= 11557 } |> Some
      | 3723 -> { DogmaEffectData.id= 3723; name= "skillNaniteInterfacingRepairTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12698; postExpression= 12699 } |> Some
      | 4111 -> { DogmaEffectData.id= 4111; name= "subsystemBonusMinmatarOffensiveProjectileWeaponROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13726; postExpression= 13727 } |> Some
      | 4208 -> { DogmaEffectData.id= 4208; name= "subsystemSkillLevelGallenteOffensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13987; postExpression= 13988 } |> Some
      | 425 -> { DogmaEffectData.id= 425; name= "industryManufacturingTimeBonusPostPercentManufactureTimeMultiplierChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2379; postExpression= 2380 } |> Some
      | 4402 -> { DogmaEffectData.id= 4402; name= "subSystemBonusCaldariElectronic2TractorBeamVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14440; postExpression= 14441 } |> Some
      | 4984 -> { DogmaEffectData.id= 4984; name= "skillWarAllyCostModifier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16039; postExpression= 16040 } |> Some
      | 5081 -> { DogmaEffectData.id= 5081; name= "maxTargetingRangeBonusPostPercentPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9627; postExpression= 9628 } |> Some
      | 5275 -> { DogmaEffectData.id= 5275; name= "fueledArmorRepair"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 5372 -> { DogmaEffectData.id= 5372; name= "damageCloudChanceReductionFixed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16940; postExpression= 16941 } |> Some
      | 5469 -> { DogmaEffectData.id= 5469; name= "shipBonusAgilityMI2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17177; postExpression= 17178 } |> Some
      | 5566 -> { DogmaEffectData.id= 5566; name= "subSystemBonusCaldariDefensiveSkirmishWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17415; postExpression= 17416 } |> Some
      | 6051 -> { DogmaEffectData.id= 6051; name= "shipBonusLightDroneDamageMultiplierGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18605; postExpression= 18606 } |> Some
      | 6148 -> { DogmaEffectData.id= 6148; name= "shipHeatDamageGallenteTacticalDestroyer3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18845; postExpression= 18846 } |> Some
      | 6245 -> { DogmaEffectData.id= 6245; name= "shipBonusEnergyNosOptimalAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19005; postExpression= 19006 } |> Some
      | 6342 -> { DogmaEffectData.id= 6342; name= "shipBonusThermalArmorResistanceGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19208; postExpression= 19209 } |> Some
      | 6439 -> { DogmaEffectData.id= 6439; name= "fighterAbilityEvasiveManeuvers"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6536 -> { DogmaEffectData.id= 6536; name= "shipBonusForceAuxiliaryC4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6633 -> { DogmaEffectData.id= 6633; name= "skillMultiplierShipBonusTitanMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6730 -> { DogmaEffectData.id= 6730; name= "moduleBonusMicrowarpdrive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6827 -> { DogmaEffectData.id= 6827; name= "rigBasCapCompManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of basic capital components"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6924 -> { DogmaEffectData.id= 6924; name= "subsystemBonusMinmatarOffensive3MissileExpVelo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14113; postExpression= 14114 } |> Some
      | 7021 -> { DogmaEffectData.id= 7021; name= "structureRigMaxTargetRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7118 -> { DogmaEffectData.id= 7118; name= "eliteBonusCovertOps3PCTdamagePerCycle"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19563; postExpression= 19564 } |> Some
      | _ -> None