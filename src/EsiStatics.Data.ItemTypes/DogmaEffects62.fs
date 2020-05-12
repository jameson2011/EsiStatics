namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects62=
    let getDogmaEffect id = 
      match id with 
      | 1129 -> { DogmaEffectData.id= 1129; name= "structureUnanchorForced"; description= ""; displayName= "Force Unanchor"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 1226 -> { DogmaEffectData.id= 1226; name= "shipMWDCapBonusMB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5269; postExpression= 5270 } |> Some
      | 159 -> { DogmaEffectData.id= 159; name= "mediumEnergyTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringMediumEnergyTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1614 -> { DogmaEffectData.id= 1614; name= "skillAdvancedSpaceshipAgilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2196 -> { DogmaEffectData.id= 2196; name= "entityArmorRepairingMedium"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2487 -> { DogmaEffectData.id= 2487; name= "skirmishWarfareVelocityBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9099; postExpression= 9100 } |> Some
      | 2778 -> { DogmaEffectData.id= 2778; name= "boosterModifyBoosterTurretPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2875 -> { DogmaEffectData.id= 2875; name= "missileKineticDmgBonusCruise"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10177; postExpression= 10178 } |> Some
      | 3069 -> { DogmaEffectData.id= 3069; name= "controlTowerGenericHullKineticResistanceBonusCynoJammer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10765; postExpression= 10766 } |> Some
      | 3263 -> { DogmaEffectData.id= 3263; name= "oreCapitalShipSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3360 -> { DogmaEffectData.id= 3360; name= "amarrShipEwWeaponDisruptionMaxRangeAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11623; postExpression= 11624 } |> Some
      | 353 -> { DogmaEffectData.id= 353; name= "ethnicRelationsSkillBoostNonRaceCorporationMembersBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2081; postExpression= 2082 } |> Some
      | 3554 -> { DogmaEffectData.id= 3554; name= "targetGunneryTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12232; postExpression= 12233 } |> Some
      | 3651 -> { DogmaEffectData.id= 3651; name= "ewGroupTpMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3845 -> { DogmaEffectData.id= 3845; name= "subsystemSkillLevelGallenteOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4039 -> { DogmaEffectData.id= 4039; name= "systemOverloadHardening"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4136 -> { DogmaEffectData.id= 4136; name= "systemShieldExplosiveResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4233 -> { DogmaEffectData.id= 4233; name= "subsystemBonusMinmatarEngineering2CapacitorRechargeRate"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14061; postExpression= 14062 } |> Some
      | 4330 -> { DogmaEffectData.id= 4330; name= "subsystemBonusAmarrOffensive3EnergyWeaponMaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4524 -> { DogmaEffectData.id= 4524; name= "fighterBomberThermalDamageBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14820; postExpression= 14821 } |> Some
      | 4621 -> { DogmaEffectData.id= 4621; name= "shipBonusHeatDamageATF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4815 -> { DogmaEffectData.id= 4815; name= "miningDroneMwdBoostOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15516; postExpression= 15517 } |> Some
      | 4912 -> { DogmaEffectData.id= 4912; name= "damageMultiplierMultiplierActivation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5009 -> { DogmaEffectData.id= 5009; name= "shipShieldExplosiveResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5106 -> { DogmaEffectData.id= 5106; name= "shipBonusShieldTransferBoostAmountMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5300 -> { DogmaEffectData.id= 5300; name= "shipBonusDroneHitpointsAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5397 -> { DogmaEffectData.id= 5397; name= "baseMaxScanDeviationModifierModuleOnline2None"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5688 -> { DogmaEffectData.id= 5688; name= "shipBonusMissileVelocityAD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6076 -> { DogmaEffectData.id= 6076; name= "shipModeMissileVelocityPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6173 -> { DogmaEffectData.id= 6173; name= "battlecruiserMHTRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 62 -> { DogmaEffectData.id= 62; name= "maxPassengersBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 506; postExpression= 507 } |> Some
      | 6270 -> { DogmaEffectData.id= 6270; name= "shipBonusEnergyNeutFalloffEAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19068; postExpression= 19069 } |> Some
      | 6367 -> { DogmaEffectData.id= 6367; name= "oreCapitalShipShieldTransferFalloff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11490; postExpression= 11491 } |> Some
      | 6464 -> { DogmaEffectData.id= 6464; name= "fighterAbilityTackle"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6561 -> { DogmaEffectData.id= 6561; name= "skillBonusLightFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6658 -> { DogmaEffectData.id= 6658; name= "moduleBonusBastionModule"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6755 -> { DogmaEffectData.id= 6755; name= "behaviorSensorDampener"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6852 -> { DogmaEffectData.id= 6852; name= "shipBonusTitanM1WebRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6949 -> { DogmaEffectData.id= 6949; name= "subSystemBonusGallenteDefensive2ScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7046 -> { DogmaEffectData.id= 7046; name= "eliteBonusFlagCruiserAllResistances1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7143 -> { DogmaEffectData.id= 7143; name= "socialBoosterSocialMutator"; description= "Used for Social Boosters that alter the amount of Standings gained when completing missions."; displayName= ""; effectCategory= 0; preExpression= 19627; postExpression= 19628 } |> Some
      | 7240 -> { DogmaEffectData.id= 7240; name= "shipBonusDreadnoughtPC3WeaponSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 838 -> { DogmaEffectData.id= 838; name= "ammoInfluenceShipVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None