namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects80=
    let getDogmaEffect id = 
      match id with 
      | 1147 -> { DogmaEffectData.id= 1147; name= "shipProjectileTrackingMD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4995; postExpression= 4996 } |> Some
      | 1244 -> { DogmaEffectData.id= 1244; name= "smugglingModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5315; postExpression= 5316 } |> Some
      | 1729 -> { DogmaEffectData.id= 1729; name= "cynosuralGenerationTmp"; description= ""; displayName= ""; effectCategory= 1; preExpression= 6742; postExpression= 6743 } |> Some
      | 2020 -> { DogmaEffectData.id= 2020; name= "repairDroneArmorDamageAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7666; postExpression= 7667 } |> Some
      | 2117 -> { DogmaEffectData.id= 2117; name= "modifyShieldResonancePassivePostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 7982; postExpression= 7983 } |> Some
      | 2311 -> { DogmaEffectData.id= 2311; name= "skillADDmaxJumpClones"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8527; postExpression= 8528 } |> Some
      | 2408 -> { DogmaEffectData.id= 2408; name= "eliteBonusCommandShipMissileKineticDamageCS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8861; postExpression= 8862 } |> Some
      | 2602 -> { DogmaEffectData.id= 2602; name= "shipBonusEmShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9450; postExpression= 9451 } |> Some
      | 2699 -> { DogmaEffectData.id= 2699; name= "trackingSpeedMultiplierEffectLasers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9709; postExpression= 9710 } |> Some
      | 274 -> { DogmaEffectData.id= 274; name= "energyManagementSkillBoostCapacitorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1707; postExpression= 1708 } |> Some
      | 2796 -> { DogmaEffectData.id= 2796; name= "massReductionBonusPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9566; postExpression= 9567 } |> Some
      | 2893 -> { DogmaEffectData.id= 2893; name= "missileKineticDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10229; postExpression= 10230 } |> Some
      | 3087 -> { DogmaEffectData.id= 3087; name= "controlTowerGenericHullEmResistanceBonusHybrid"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10841; postExpression= 10842 } |> Some
      | 3281 -> { DogmaEffectData.id= 3281; name= "industrialCoreScannerAndCommandBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 11409; postExpression= 11410 } |> Some
      | 3572 -> { DogmaEffectData.id= 3572; name= "shipBonusTrackingLinkTrackingSpeedBonusMC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12276; postExpression= 12277 } |> Some
      | 3669 -> { DogmaEffectData.id= 3669; name= "frequencyMiningLaserMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12573; postExpression= 12574 } |> Some
      | 3766 -> { DogmaEffectData.id= 3766; name= "interceptorMWDSignatureRadiusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12828; postExpression= 12829 } |> Some
      | 3863 -> { DogmaEffectData.id= 3863; name= "subsystemBonusCaldariPropulsionAfterburnerSpeedFactor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13091; postExpression= 13092 } |> Some
      | 3960 -> { DogmaEffectData.id= 3960; name= "subsystemBonusCaldariDefensiveArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13285; postExpression= 13286 } |> Some
      | 4057 -> { DogmaEffectData.id= 4057; name= "systemRocketEmDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13577; postExpression= 13578 } |> Some
      | 4154 -> { DogmaEffectData.id= 4154; name= "subsystemBonusGallenteEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13816; postExpression= 13817 } |> Some
      | 4251 -> { DogmaEffectData.id= 4251; name= "subsystemBonusMinmatarOffensive2ProjectileWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14105; postExpression= 14106 } |> Some
      | 4445 -> { DogmaEffectData.id= 4445; name= "imperialsetbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14567; postExpression= 14568 } |> Some
      | 4639 -> { DogmaEffectData.id= 4639; name= "shipArmorEMAndExpAndkinResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15139; postExpression= 15140 } |> Some
      | 468 -> { DogmaEffectData.id= 468; name= "gallenteFrigateSkillLevelPreMulShipBonusGFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2548; postExpression= 2549 } |> Some
      | 4930 -> { DogmaEffectData.id= 4930; name= "scriptConsumptionQuantityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15890; postExpression= 15891 } |> Some
      | 5124 -> { DogmaEffectData.id= 5124; name= "shipBonusRemoteArmorRepairAmountAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16372; postExpression= 16373 } |> Some
      | 5221 -> { DogmaEffectData.id= 5221; name= "shipHeavyAssaultMissileEMDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16601; postExpression= 16602 } |> Some
      | 5318 -> { DogmaEffectData.id= 5318; name= "shipProjectileTracking1MD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16837; postExpression= 16838 } |> Some
      | 5415 -> { DogmaEffectData.id= 5415; name= "shipRocketThermalDmgAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17023; postExpression= 17024 } |> Some
      | 5803 -> { DogmaEffectData.id= 5803; name= "shipBonusSentryDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17959; postExpression= 17960 } |> Some
      | 5900 -> { DogmaEffectData.id= 5900; name= "warpSpeedAddition"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 18213; postExpression= 18214 } |> Some
      | 5997 -> { DogmaEffectData.id= 5997; name= "freighterO2SkillLevel"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18475; postExpression= 18476 } |> Some
      | 6191 -> { DogmaEffectData.id= 6191; name= "expeditionFrigateShieldResistanceKIN1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18917; postExpression= 18918 } |> Some
      | 6288 -> { DogmaEffectData.id= 6288; name= "shipBonusEnergyNosOptimalAF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19106; postExpression= 19107 } |> Some
      | 6385 -> { DogmaEffectData.id= 6385; name= "ignoreCloakVelocityPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19220; postExpression= 19221 } |> Some
      | 6482 -> { DogmaEffectData.id= 6482; name= "doomsdayAOEBubble"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 662 -> { DogmaEffectData.id= 662; name= "missileThermalDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3310; postExpression= 3311 } |> Some
      | 6676 -> { DogmaEffectData.id= 6676; name= "structureRigCalAmarrIceYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6773 -> { DogmaEffectData.id= 6773; name= "skirmishCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6870 -> { DogmaEffectData.id= 6870; name= "concordAssignTankBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7064 -> { DogmaEffectData.id= 7064; name= "weather_basic"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7161 -> { DogmaEffectData.id= 7161; name= "shipArmorExplosiveResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19693; postExpression= 19694 } |> Some
      | 856 -> { DogmaEffectData.id= 856; name= "warpSkillSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3949; postExpression= 3950 } |> Some
      | 953 -> { DogmaEffectData.id= 953; name= "biologyTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4292; postExpression= 4293 } |> Some
      | _ -> None