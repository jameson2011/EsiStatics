namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects48=
    let getDogmaEffect id = 
      match id with 
      | 1018 -> { DogmaEffectData.id= 1018; name= "selfT2LargeHybridRailDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1212 -> { DogmaEffectData.id= 1212; name= "crystalMiningamountInfo2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1309 -> { DogmaEffectData.id= 1309; name= "shipMissileThermDamageGallenteInterceptor2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5488; postExpression= 5489 } |> Some
      | 242 -> { DogmaEffectData.id= 242; name= "accerationControlSpeedFBonusPostPercentSpeedFactorLocationShipGroupAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2473 -> { DogmaEffectData.id= 2473; name= "shipBonusDroneDamageMultiplierBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9071; postExpression= 9072 } |> Some
      | 2764 -> { DogmaEffectData.id= 2764; name= "boosterModifyBoosterCapacitorCapacitorPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9895; postExpression= 9896 } |> Some
      | 2861 -> { DogmaEffectData.id= 2861; name= "agilityMultiplierOnTarget"; description= ""; displayName= ""; effectCategory= 2; preExpression= 566; postExpression= 567 } |> Some
      | 3152 -> { DogmaEffectData.id= 3152; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11021; postExpression= 11022 } |> Some
      | 3249 -> { DogmaEffectData.id= 3249; name= "shipCapRecharge2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3346 -> { DogmaEffectData.id= 3346; name= "eliteBonusHeavyInterdictorLaserRof"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11588; postExpression= 11589 } |> Some
      | 339 -> { DogmaEffectData.id= 339; name= "cruiserConstructionCruiserConstructionTimeBonusPostPercentCruiserConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3540 -> { DogmaEffectData.id= 3540; name= "scriptSensorBoosterScanResolutionMultiplierBonusAdditive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12186; postExpression= 12187 } |> Some
      | 3831 -> { DogmaEffectData.id= 3831; name= "shieldCapacityAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4025 -> { DogmaEffectData.id= 4025; name= "systemRemoteSensorBoosterRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13450; postExpression= 13451 } |> Some
      | 4122 -> { DogmaEffectData.id= 4122; name= "subsystemBonusCaldariOffensive1LauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4219 -> { DogmaEffectData.id= 4219; name= "subsystemBonusCaldariElectronicLadarECMStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14027; postExpression= 14028 } |> Some
      | 4316 -> { DogmaEffectData.id= 4316; name= "subsystemBonusGallenteEngineeringDroneHPShieldAndArmor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14236; postExpression= 14237 } |> Some
      | 436 -> { DogmaEffectData.id= 436; name= "missileLauncherOperationSpeedBonusPostPercentSpeedLocationShipModulesRequiringMissileLauncherOperation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4413 -> { DogmaEffectData.id= 4413; name= "shipBonusGF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4510 -> { DogmaEffectData.id= 4510; name= "shipStasisWebStrengthBonusMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4704 -> { DogmaEffectData.id= 4704; name= "systemEffectDamageThermalMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15272; postExpression= 15273 } |> Some
      | 48 -> { DogmaEffectData.id= 48; name= "powerBooster"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4801 -> { DogmaEffectData.id= 4801; name= "salvagingAccessDifficultyBonusMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4898 -> { DogmaEffectData.id= 4898; name= "shipBonusDroneShieldHitpointsGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4995 -> { DogmaEffectData.id= 4995; name= "shipArmorEXResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5189 -> { DogmaEffectData.id= 5189; name= "trackingSpeedBonusEffectLasers"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5286 -> { DogmaEffectData.id= 5286; name= "battlecruiserSkillLevelPreMulShipBonusCBC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 533 -> { DogmaEffectData.id= 533; name= "shipPTrackingBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2833; postExpression= 2834 } |> Some
      | 5383 -> { DogmaEffectData.id= 5383; name= "shipMissileEMDamageCC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5480 -> { DogmaEffectData.id= 5480; name= "setBonusChristmasBonusVelocity"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5868 -> { DogmaEffectData.id= 5868; name= "drawbackCargoCapacity"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6062 -> { DogmaEffectData.id= 6062; name= "shipBonusLightDroneShieldHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6256 -> { DogmaEffectData.id= 6256; name= "shipBonusEnergyNeutFalloffAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6353 -> { DogmaEffectData.id= 6353; name= "roleBonusWDCapCPU"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6450 -> { DogmaEffectData.id= 6450; name= "structureMissileGuidanceComputerBonus5"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6547 -> { DogmaEffectData.id= 6547; name= "shipBonusForceAuxiliaryC3CapCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6741 -> { DogmaEffectData.id= 6741; name= "npcBehaviorRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6838 -> { DogmaEffectData.id= 6838; name= "rigCapShipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of Capital ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6935 -> { DogmaEffectData.id= 6935; name= "subsystemBonusAmarrCore3EnergyWarHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7032 -> { DogmaEffectData.id= 7032; name= "shipBonusHeavyMissileThermalDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7226 -> { DogmaEffectData.id= 7226; name= "systemDroneSpeedBonusItem"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 19788; postExpression= 19789 } |> Some
      | 727 -> { DogmaEffectData.id= 727; name= "shipBonusCargoCI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None