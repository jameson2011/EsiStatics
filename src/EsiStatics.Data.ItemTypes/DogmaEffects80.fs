namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects80=
    let getDogmaEffect id = 
      match id with 
      | 1244 -> { DogmaEffectData.id= 1244; name= "smugglingModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2020 -> { DogmaEffectData.id= 2020; name= "repairDroneArmorDamageAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2311 -> { DogmaEffectData.id= 2311; name= "skillADDmaxJumpClones"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2602 -> { DogmaEffectData.id= 2602; name= "shipBonusEmShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2796 -> { DogmaEffectData.id= 2796; name= "massReductionBonusPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2893 -> { DogmaEffectData.id= 2893; name= "missileKineticDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3669 -> { DogmaEffectData.id= 3669; name= "frequencyMiningLaserMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3766 -> { DogmaEffectData.id= 3766; name= "interceptorMWDSignatureRadiusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3863 -> { DogmaEffectData.id= 3863; name= "subsystemBonusCaldariPropulsionAfterburnerSpeedFactor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4057 -> { DogmaEffectData.id= 4057; name= "systemRocketEmDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4154 -> { DogmaEffectData.id= 4154; name= "subsystemBonusGallenteEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4251 -> { DogmaEffectData.id= 4251; name= "subsystemBonusMinmatarOffensive2ProjectileWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 468 -> { DogmaEffectData.id= 468; name= "gallenteFrigateSkillLevelPreMulShipBonusGFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4930 -> { DogmaEffectData.id= 4930; name= "scriptConsumptionQuantityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5124 -> { DogmaEffectData.id= 5124; name= "shipBonusRemoteArmorRepairAmountAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5221 -> { DogmaEffectData.id= 5221; name= "shipHeavyAssaultMissileEMDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5318 -> { DogmaEffectData.id= 5318; name= "shipProjectileTracking1MD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5803 -> { DogmaEffectData.id= 5803; name= "shipBonusSentryDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5900 -> { DogmaEffectData.id= 5900; name= "warpSpeedAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5997 -> { DogmaEffectData.id= 5997; name= "freighterO2SkillLevel"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6385 -> { DogmaEffectData.id= 6385; name= "ignoreCloakVelocityPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6482 -> { DogmaEffectData.id= 6482; name= "doomsdayAOEBubble"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 662 -> { DogmaEffectData.id= 662; name= "missileThermalDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6676 -> { DogmaEffectData.id= 6676; name= "structureRigCalAmarrIceYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6773 -> { DogmaEffectData.id= 6773; name= "skirmishCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6870 -> { DogmaEffectData.id= 6870; name= "concordAssignTankBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7064 -> { DogmaEffectData.id= 7064; name= "weather_basic"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7161 -> { DogmaEffectData.id= 7161; name= "shipArmorExplosiveResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8034 -> { DogmaEffectData.id= 8034; name= "smallUpwellWeaponDmgBonusRequiredSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 856 -> { DogmaEffectData.id= 856; name= "warpSkillSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None