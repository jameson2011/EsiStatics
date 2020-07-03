namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects23=
    let getDogmaEffect id = 
      match id with 
      | 1672 -> { DogmaEffectData.id= 1672; name= "freighterMaxVelocityBonusA1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2157 -> { DogmaEffectData.id= 2157; name= "eliteBonusCommandShipLaserDamageCS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2739 -> { DogmaEffectData.id= 2739; name= "boosterTurretOptimalRangePenalty"; description= "Automatically generated effect"; displayName= "Turret Optimal Range Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3030 -> { DogmaEffectData.id= 3030; name= "overloadSelfThermalHardeningBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3321 -> { DogmaEffectData.id= 3321; name= "shipBonusORECapShipDroneDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3806 -> { DogmaEffectData.id= 3806; name= "scanStrengthAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4194 -> { DogmaEffectData.id= 4194; name= "strategicCruiserMinmatarSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4485 -> { DogmaEffectData.id= 4485; name= "shipBonusStasisWebSpeedFactorMB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4970 -> { DogmaEffectData.id= 4970; name= "boosterShieldBoostAmountPenaltyShieldSkills"; description= ""; displayName= "Shield Booster Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5067 -> { DogmaEffectData.id= 5067; name= "shipBonusOreHoldORE2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 508 -> { DogmaEffectData.id= 508; name= "shipPDmgBonusMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5261 -> { DogmaEffectData.id= 5261; name= "CovertCloakCPUAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5358 -> { DogmaEffectData.id= 5358; name= "shipLargeHybridTrackingBonusGBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5552 -> { DogmaEffectData.id= 5552; name= "shipBonusHMLVelocityEliteBonusHeavyGunship1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5940 -> { DogmaEffectData.id= 5940; name= "eliteBonusInterdictorsSHTRoF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6037 -> { DogmaEffectData.id= 6037; name= "shipSPTDamageMinmatarTacticalDestroyer1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 605 -> { DogmaEffectData.id= 605; name= "minmatarBattleshipSkillLevelPreMulShipBonusMB2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6328 -> { DogmaEffectData.id= 6328; name= "shipBonusKineticMissileDamageCD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6425 -> { DogmaEffectData.id= 6425; name= "remoteTargetPaintFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6619 -> { DogmaEffectData.id= 6619; name= "shipBonusCarrierRole1NumWarfareLinks"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6716 -> { DogmaEffectData.id= 6716; name= "pacifierDebuffQA"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6813 -> { DogmaEffectData.id= 6813; name= "rigSmallshipManufactureTimeBonus"; description= "Structure Rig time effect on Manufacturing of small ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6910 -> { DogmaEffectData.id= 6910; name= "shipBonusStrategicCruiserGallenteNaniteRepairTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7104 -> { DogmaEffectData.id= 7104; name= "structureConversionRigEquipManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 896 -> { DogmaEffectData.id= 896; name= "covertOpsCpuBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None