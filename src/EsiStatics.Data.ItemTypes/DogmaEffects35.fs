namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects35=
    let getDogmaEffect id = 
      match id with 
      | 1005 -> { DogmaEffectData.id= 1005; name= "selfT2SmallHybridBlasterDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1199 -> { DogmaEffectData.id= 1199; name= "targetAttackForStructures"; description= "Combat"; displayName= "targetAttack"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 132 -> { DogmaEffectData.id= 132; name= "skillEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1587 -> { DogmaEffectData.id= 1587; name= "capitalTurretSkillHybridDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1878 -> { DogmaEffectData.id= 1878; name= "entitySensorDampen"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 2654 -> { DogmaEffectData.id= 2654; name= "skillAstrometricsMaxGroupScanningBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9584; postExpression= 9585 } |> Some
      | 2751 -> { DogmaEffectData.id= 2751; name= "shipBonusECMMagnetometricStrengthBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9857; postExpression= 9858 } |> Some
      | 2848 -> { DogmaEffectData.id= 2848; name= "accessDifficultyBonusModifierRequiringArchaelogy"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3139 -> { DogmaEffectData.id= 3139; name= "controlTowerGenericHullResistanceBonusEcm"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10997; postExpression= 10998 } |> Some
      | 3236 -> { DogmaEffectData.id= 3236; name= "shipRocketThermalDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 326 -> { DogmaEffectData.id= 326; name= "minmatarTechMinmatarTechMutatorPostPercentMinmatarTechTimePercentLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1934; postExpression= 1935 } |> Some
      | 3333 -> { DogmaEffectData.id= 3333; name= "leech2"; description= ""; displayName= "leech"; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 3430 -> { DogmaEffectData.id= 3430; name= "eliteBonusViolatorsCruiseMissileThermalDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11842; postExpression= 11843 } |> Some
      | 3527 -> { DogmaEffectData.id= 3527; name= "skillConsumptionQuantityBonusPercentageSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3915 -> { DogmaEffectData.id= 3915; name= "subsystemBonusCaldariDefensiveArmorResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13197; postExpression= 13198 } |> Some
      | 4012 -> { DogmaEffectData.id= 4012; name= "systemSensorDampenerRangeReduction"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13408; postExpression= 13409 } |> Some
      | 4109 -> { DogmaEffectData.id= 4109; name= "subsystemBonusGallenteOffensiveHybridWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4206 -> { DogmaEffectData.id= 4206; name= "subsystemSkillLevelMinmatarEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4400 -> { DogmaEffectData.id= 4400; name= "shipBonusAF1TorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4594 -> { DogmaEffectData.id= 4594; name= "shipBonusSurveyProbeExplosionDelay3AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15042; postExpression= 15043 } |> Some
      | 4691 -> { DogmaEffectData.id= 4691; name= "systemStandardMissileKineticDamageBroken"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15238; postExpression= 15239 } |> Some
      | 4788 -> { DogmaEffectData.id= 4788; name= "shipEnergyVampireRangeBonusATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15448; postExpression= 15449 } |> Some
      | 4982 -> { DogmaEffectData.id= 4982; name= "entityTrackingDisrupt"; description= ""; displayName= ""; effectCategory= 2; preExpression= 16028; postExpression= 16029 } |> Some
      | 5079 -> { DogmaEffectData.id= 5079; name= "shipMissileKineticDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 520 -> { DogmaEffectData.id= 520; name= "caldariCruiserSkillLevelPreMulShipBonusCCShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5370 -> { DogmaEffectData.id= 5370; name= "entityArmorRepairing"; description= "Entity armor repair effect for tanking NPCs"; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5564 -> { DogmaEffectData.id= 5564; name= "subSystemBonusCaldariOffensiveCommandBursts"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5758 -> { DogmaEffectData.id= 5758; name= "overloadSelfPainterBonus"; description= "Overload Effectiveness Bonus"; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 6049 -> { DogmaEffectData.id= 6049; name= "shipBonusSentryHPGC3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18601; postExpression= 18602 } |> Some
      | 6146 -> { DogmaEffectData.id= 6146; name= "tacticalDestroyerGallenteSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 617 -> { DogmaEffectData.id= 617; name= "targetedExplosiveResonanceMultiply"; description= "Automatically generated effect"; displayName= "TargetedExplosiveResonanceMultiply"; effectCategory= 2; preExpression= 3131; postExpression= 3132 } |> Some
      | 6243 -> { DogmaEffectData.id= 6243; name= "shipBonusEnergyNeutOptimalAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19001; postExpression= 19002 } |> Some
      | 6340 -> { DogmaEffectData.id= 6340; name= "shipBonusKineticArmorResistanceGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6437 -> { DogmaEffectData.id= 6437; name= "fighterAbilityECM"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6534 -> { DogmaEffectData.id= 6534; name= "shipBonusForceAuxiliaryM4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6631 -> { DogmaEffectData.id= 6631; name= "skillMultiplierShipBonusTitanCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6825 -> { DogmaEffectData.id= 6825; name= "rigAdvComponentManufactureTimeBonus"; description= "Structure Rig Material effect on Manufacturing of equipment"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6922 -> { DogmaEffectData.id= 6922; name= "subSystemBonusAmarrDefensive3TractorBeamBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14452; postExpression= 14453 } |> Some
      | 7019 -> { DogmaEffectData.id= 7019; name= "eliteBonusGunshipDroneTracking2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19386; postExpression= 19387 } |> Some
      | 7116 -> { DogmaEffectData.id= 7116; name= "eliteBonusReconScanProbeStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7213 -> { DogmaEffectData.id= 7213; name= "shipArmorThermresistanceEliteHeavyGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19813; postExpression= 19814 } |> Some
      | _ -> None