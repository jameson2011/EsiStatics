namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects82=
    let getDogmaEffect id = 
      match id with 
      | 1052 -> { DogmaEffectData.id= 1052; name= "logisticSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4633; postExpression= 4634 } |> Some
      | 1634 -> { DogmaEffectData.id= 1634; name= "capitalShieldOperationSkillCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6489; postExpression= 6490 } |> Some
      | 2604 -> { DogmaEffectData.id= 2604; name= "shipBonusKineticShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9454; postExpression= 9455 } |> Some
      | 2798 -> { DogmaEffectData.id= 2798; name= "projectileWeaponDamageMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 667; postExpression= 670 } |> Some
      | 3380 -> { DogmaEffectData.id= 3380; name= "warpDisruptSphere"; description= ""; displayName= ""; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 3671 -> { DogmaEffectData.id= 3671; name= "gasHarvesterMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12579; postExpression= 12580 } |> Some
      | 3865 -> { DogmaEffectData.id= 3865; name= "subsystemBonusAmarrPropulsion2Agility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13095; postExpression= 13096 } |> Some
      | 3962 -> { DogmaEffectData.id= 3962; name= "subsystemBonusMinmatarDefensiveShieldArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13289; postExpression= 13290 } |> Some
      | 4059 -> { DogmaEffectData.id= 4059; name= "systemRocketKineticDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13583; postExpression= 13584 } |> Some
      | 4156 -> { DogmaEffectData.id= 4156; name= "subsystemBonusMinmatarEngineeringCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13820; postExpression= 13821 } |> Some
      | 4253 -> { DogmaEffectData.id= 4253; name= "subsystemBonusMinmatarOffensive2ProjectileWeaponROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14107; postExpression= 14108 } |> Some
      | 4350 -> { DogmaEffectData.id= 4350; name= "subsystemSkillLevelMinmatarOffensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14323; postExpression= 14324 } |> Some
      | 5029 -> { DogmaEffectData.id= 5029; name= "shipBonusDroneMiningAmountRole"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16150; postExpression= 16151 } |> Some
      | 5126 -> { DogmaEffectData.id= 5126; name= "shipBonusShieldTransferBoostAmountCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16376; postExpression= 16377 } |> Some
      | 5223 -> { DogmaEffectData.id= 5223; name= "shipHeavyAssaultMissileThermDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16605; postExpression= 16606 } |> Some
      | 5320 -> { DogmaEffectData.id= 5320; name= "shipRocketExplosiveDmgMD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16841; postExpression= 16842 } |> Some
      | 5417 -> { DogmaEffectData.id= 5417; name= "shipBonusDroneDamageMultiplierAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17027; postExpression= 17028 } |> Some
      | 5514 -> { DogmaEffectData.id= 5514; name= "eliteBonusCommandShipHeavyAssaultMissileDamageCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17287; postExpression= 17288 } |> Some
      | 5611 -> { DogmaEffectData.id= 5611; name= "shipBonusHTFalloffGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17516; postExpression= 17517 } |> Some
      | 5805 -> { DogmaEffectData.id= 5805; name= "shipBonusSentryDroneHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17965; postExpression= 17966 } |> Some
      | 6096 -> { DogmaEffectData.id= 6096; name= "shipBonusLightMissileAllDamageMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18695; postExpression= 18696 } |> Some
      | 6484 -> { DogmaEffectData.id= 6484; name= "emergencyHullEnergizer"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6581 -> { DogmaEffectData.id= 6581; name= "moduleBonusTriageModule"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6678 -> { DogmaEffectData.id= 6678; name= "structureRigIceYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6775 -> { DogmaEffectData.id= 6775; name= "commandBurstStrengthSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6872 -> { DogmaEffectData.id= 6872; name= "eliteReconStasisWebBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7361; postExpression= 7362 } |> Some
      | 6969 -> { DogmaEffectData.id= 6969; name= "rigReactionHybTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7066 -> { DogmaEffectData.id= 7066; name= "precursorFrigateSkillLevelPreMulShipBonusPF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19423; postExpression= 19424 } |> Some
      | 761 -> { DogmaEffectData.id= 761; name= "caldariFrigateSkillLevelPreMulShipBonusCF2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3649; postExpression= 3650 } |> Some
      | 82 -> { DogmaEffectData.id= 82; name= "corporationMemberLimitBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 609; postExpression= 610 } |> Some
      | 858 -> { DogmaEffectData.id= 858; name= "bountyhunterskill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3961; postExpression= 3962 } |> Some
      | _ -> None