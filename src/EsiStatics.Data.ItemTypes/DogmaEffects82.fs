namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects82=
    let getDogmaEffect id = 
      match id with 
      | 1052 -> { DogmaEffectData.id= 1052; name= "logisticSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1634 -> { DogmaEffectData.id= 1634; name= "capitalShieldOperationSkillCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2604 -> { DogmaEffectData.id= 2604; name= "shipBonusKineticShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2798 -> { DogmaEffectData.id= 2798; name= "projectileWeaponDamageMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3380 -> { DogmaEffectData.id= 3380; name= "warpDisruptSphere"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 3671 -> { DogmaEffectData.id= 3671; name= "gasHarvesterMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3865 -> { DogmaEffectData.id= 3865; name= "subsystemBonusAmarrPropulsion2Agility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3962 -> { DogmaEffectData.id= 3962; name= "subsystemBonusMinmatarDefensiveShieldArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4059 -> { DogmaEffectData.id= 4059; name= "systemRocketKineticDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4156 -> { DogmaEffectData.id= 4156; name= "subsystemBonusMinmatarEngineeringCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4253 -> { DogmaEffectData.id= 4253; name= "subsystemBonusMinmatarOffensive2ProjectileWeaponROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4350 -> { DogmaEffectData.id= 4350; name= "subsystemSkillLevelMinmatarOffensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5029 -> { DogmaEffectData.id= 5029; name= "shipBonusDroneMiningAmountRole"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5126 -> { DogmaEffectData.id= 5126; name= "shipBonusShieldTransferBoostAmountCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5223 -> { DogmaEffectData.id= 5223; name= "shipHeavyAssaultMissileThermDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5320 -> { DogmaEffectData.id= 5320; name= "shipRocketExplosiveDmgMD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5417 -> { DogmaEffectData.id= 5417; name= "shipBonusDroneDamageMultiplierAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5514 -> { DogmaEffectData.id= 5514; name= "eliteBonusCommandShipHeavyAssaultMissileDamageCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5611 -> { DogmaEffectData.id= 5611; name= "shipBonusHTFalloffGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5805 -> { DogmaEffectData.id= 5805; name= "shipBonusSentryDroneHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6096 -> { DogmaEffectData.id= 6096; name= "shipBonusLightMissileAllDamageMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6484 -> { DogmaEffectData.id= 6484; name= "emergencyHullEnergizer"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6581 -> { DogmaEffectData.id= 6581; name= "moduleBonusTriageModule"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6678 -> { DogmaEffectData.id= 6678; name= "structureRigIceYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6775 -> { DogmaEffectData.id= 6775; name= "commandBurstStrengthSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6872 -> { DogmaEffectData.id= 6872; name= "eliteReconStasisWebBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6969 -> { DogmaEffectData.id= 6969; name= "rigReactionHybTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7066 -> { DogmaEffectData.id= 7066; name= "precursorFrigateSkillLevelPreMulShipBonusPF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 761 -> { DogmaEffectData.id= 761; name= "caldariFrigateSkillLevelPreMulShipBonusCF2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8036 -> { DogmaEffectData.id= 8036; name= "largeUpwellWeaponDmgBonusRequiredSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 82 -> { DogmaEffectData.id= 82; name= "corporationMemberLimitBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 858 -> { DogmaEffectData.id= 858; name= "bountyhunterskill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None