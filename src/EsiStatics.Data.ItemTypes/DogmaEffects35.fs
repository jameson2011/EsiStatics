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
      | 2848 -> { DogmaEffectData.id= 2848; name= "accessDifficultyBonusModifierRequiringArchaelogy"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3236 -> { DogmaEffectData.id= 3236; name= "shipRocketThermalDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3527 -> { DogmaEffectData.id= 3527; name= "skillConsumptionQuantityBonusPercentageSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4109 -> { DogmaEffectData.id= 4109; name= "subsystemBonusGallenteOffensiveHybridWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4206 -> { DogmaEffectData.id= 4206; name= "subsystemSkillLevelMinmatarEngineering2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4400 -> { DogmaEffectData.id= 4400; name= "shipBonusAF1TorpedoExplosionVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5079 -> { DogmaEffectData.id= 5079; name= "shipMissileKineticDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 520 -> { DogmaEffectData.id= 520; name= "caldariCruiserSkillLevelPreMulShipBonusCCShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5370 -> { DogmaEffectData.id= 5370; name= "entityArmorRepairing"; description= "Entity armor repair effect for tanking NPCs"; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5564 -> { DogmaEffectData.id= 5564; name= "subSystemBonusCaldariOffensiveCommandBursts"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5758 -> { DogmaEffectData.id= 5758; name= "overloadSelfPainterBonus"; description= "Overload Effectiveness Bonus"; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 6146 -> { DogmaEffectData.id= 6146; name= "tacticalDestroyerGallenteSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6340 -> { DogmaEffectData.id= 6340; name= "shipBonusKineticArmorResistanceGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6437 -> { DogmaEffectData.id= 6437; name= "fighterAbilityECM"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6534 -> { DogmaEffectData.id= 6534; name= "shipBonusForceAuxiliaryM4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6631 -> { DogmaEffectData.id= 6631; name= "skillMultiplierShipBonusTitanCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6825 -> { DogmaEffectData.id= 6825; name= "rigAdvComponentManufactureTimeBonus"; description= "Structure Rig Material effect on Manufacturing of equipment"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7116 -> { DogmaEffectData.id= 7116; name= "eliteBonusReconScanProbeStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None