namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects38=
    let getDogmaEffect id = 
      match id with 
      | 1008 -> { DogmaEffectData.id= 1008; name= "selfT2SmallProjectileArtyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1202 -> { DogmaEffectData.id= 1202; name= "shipMissileEMDamage2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5194; postExpression= 5195 } |> Some
      | 1590 -> { DogmaEffectData.id= 1590; name= "missileSkillAoeVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 232 -> { DogmaEffectData.id= 232; name= "evasiveManuveringSkillBoostAgilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2657 -> { DogmaEffectData.id= 2657; name= "scanGravimetricStrengthBonusRequringAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9595; postExpression= 9596 } |> Some
      | 2754 -> { DogmaEffectData.id= 2754; name= "shipBonusECMRadarLadarBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9863; postExpression= 9864 } |> Some
      | 2851 -> { DogmaEffectData.id= 2851; name= "missileDMGBonusPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3142 -> { DogmaEffectData.id= 3142; name= "controlTowerGenericHullResistanceBonusJumpPortal"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11003; postExpression= 11004 } |> Some
      | 3239 -> { DogmaEffectData.id= 3239; name= "shipMissileAoeVelocityDF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11260; postExpression= 11261 } |> Some
      | 3336 -> { DogmaEffectData.id= 3336; name= "shipArmorExplosiveResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3433 -> { DogmaEffectData.id= 3433; name= "eliteBonusViolatorsTorpedoExplosiveDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11848; postExpression= 11849 } |> Some
      | 3530 -> { DogmaEffectData.id= 3530; name= "eliteBonusBlackOpsAgiliy1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3724 -> { DogmaEffectData.id= 3724; name= "targetMWDBlockActivation"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12705; postExpression= 12706 } |> Some
      | 38 -> { DogmaEffectData.id= 38; name= "empWave"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4015 -> { DogmaEffectData.id= 4015; name= "systemTrackingDisruptorOptimal"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13419; postExpression= 13420 } |> Some
      | 4112 -> { DogmaEffectData.id= 4112; name= "subsystemBonusMinmatarOffensiveProjectileWeaponTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13728; postExpression= 13729 } |> Some
      | 4209 -> { DogmaEffectData.id= 4209; name= "subsystemSkillLevelCaldariOffensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4403 -> { DogmaEffectData.id= 4403; name= "subSystemBonusGallenteElectronic2TractorBeamVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4597 -> { DogmaEffectData.id= 4597; name= "shipBonusSurveyProbeExplosionDelay3MF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15051; postExpression= 15052 } |> Some
      | 4694 -> { DogmaEffectData.id= 4694; name= "systemDamageKineticSmartbombs"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15249; postExpression= 15250 } |> Some
      | 4985 -> { DogmaEffectData.id= 4985; name= "relationsAllyCostSkillBoost"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5179 -> { DogmaEffectData.id= 5179; name= "sensorIntegritySensorStrengthBonusPostPercentAllSensorStrengthShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16496; postExpression= 16497 } |> Some
      | 5276 -> { DogmaEffectData.id= 5276; name= "destroyerSkillLevelPreMulShipBonusAD1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5373 -> { DogmaEffectData.id= 5373; name= "deepCoreMiningSkillBoostDamageCloudChanceReductionMul"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5470 -> { DogmaEffectData.id= 5470; name= "shipBonusAgilityGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5567 -> { DogmaEffectData.id= 5567; name= "subSystemBonusGallenteDefensiveSkirmishWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6052 -> { DogmaEffectData.id= 6052; name= "shipBonusMediumDroneDamageMultiplierGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6149 -> { DogmaEffectData.id= 6149; name= "shipSHTRoFGallenteTacticalDestroyer1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6246 -> { DogmaEffectData.id= 6246; name= "shipBonusEnergyNosFalloffAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6343 -> { DogmaEffectData.id= 6343; name= "shipBonusExplosiveArmorResistanceGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6440 -> { DogmaEffectData.id= 6440; name= "fighterAbilityAfterburner"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6537 -> { DogmaEffectData.id= 6537; name= "shipBonusRole1CommandBurstCPUBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6634 -> { DogmaEffectData.id= 6634; name= "shipBonusTitanA1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6731 -> { DogmaEffectData.id= 6731; name= "moduleBonusAfterburner"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6828 -> { DogmaEffectData.id= 6828; name= "rigStructureManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of structures"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6925 -> { DogmaEffectData.id= 6925; name= "subsystemBonusGallenteOffensive2DroneVeloTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7022 -> { DogmaEffectData.id= 7022; name= "structureShieldCapacityBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 7119 -> { DogmaEffectData.id= 7119; name= "eliteBonusReconShip3PCTdamagePerCycle"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7216 -> { DogmaEffectData.id= 7216; name= "shipDmgMultiMaxEliteGunship1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None