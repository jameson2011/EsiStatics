namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects48=
    let getDogmaEffect id = 
      match id with 
      | 1018 -> { DogmaEffectData.id= 1018; name= "selfT2LargeHybridRailDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4522; postExpression= 4523 } |> Some
      | 1212 -> { DogmaEffectData.id= 1212; name= "crystalMiningamountInfo2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5236; postExpression= 5237 } |> Some
      | 1309 -> { DogmaEffectData.id= 1309; name= "shipMissileThermDamageGallenteInterceptor2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5488; postExpression= 5489 } |> Some
      | 242 -> { DogmaEffectData.id= 242; name= "accerationControlSpeedFBonusPostPercentSpeedFactorLocationShipGroupAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1587; postExpression= 1588 } |> Some
      | 2473 -> { DogmaEffectData.id= 2473; name= "shipBonusDroneDamageMultiplierBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9071; postExpression= 9072 } |> Some
      | 2764 -> { DogmaEffectData.id= 2764; name= "boosterModifyBoosterCapacitorCapacitorPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9895; postExpression= 9896 } |> Some
      | 2861 -> { DogmaEffectData.id= 2861; name= "agilityMultiplierOnTarget"; description= ""; displayName= ""; effectCategory= 2; preExpression= 566; postExpression= 567 } |> Some
      | 3152 -> { DogmaEffectData.id= 3152; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11021; postExpression= 11022 } |> Some
      | 3249 -> { DogmaEffectData.id= 3249; name= "shipCapRecharge2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3283; postExpression= 3284 } |> Some
      | 3346 -> { DogmaEffectData.id= 3346; name= "eliteBonusHeavyInterdictorLaserRof"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11588; postExpression= 11589 } |> Some
      | 339 -> { DogmaEffectData.id= 339; name= "cruiserConstructionCruiserConstructionTimeBonusPostPercentCruiserConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2017; postExpression= 2018 } |> Some
      | 3540 -> { DogmaEffectData.id= 3540; name= "scriptSensorBoosterScanResolutionMultiplierBonusAdditive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12186; postExpression= 12187 } |> Some
      | 3831 -> { DogmaEffectData.id= 3831; name= "shieldCapacityAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12961; postExpression= 12962 } |> Some
      | 4025 -> { DogmaEffectData.id= 4025; name= "systemRemoteSensorBoosterRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13450; postExpression= 13451 } |> Some
      | 4122 -> { DogmaEffectData.id= 4122; name= "subsystemBonusCaldariOffensive1LauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13750; postExpression= 13751 } |> Some
      | 4219 -> { DogmaEffectData.id= 4219; name= "subsystemBonusCaldariElectronicLadarECMStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14027; postExpression= 14028 } |> Some
      | 4316 -> { DogmaEffectData.id= 4316; name= "subsystemBonusGallenteEngineeringDroneHPShieldAndArmor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14236; postExpression= 14237 } |> Some
      | 436 -> { DogmaEffectData.id= 436; name= "missileLauncherOperationSpeedBonusPostPercentSpeedLocationShipModulesRequiringMissileLauncherOperation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2429; postExpression= 2430 } |> Some
      | 4413 -> { DogmaEffectData.id= 4413; name= "shipBonusGF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14469; postExpression= 14470 } |> Some
      | 4510 -> { DogmaEffectData.id= 4510; name= "shipStasisWebStrengthBonusMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14774; postExpression= 14775 } |> Some
      | 4704 -> { DogmaEffectData.id= 4704; name= "systemEffectDamageThermalMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15272; postExpression= 15273 } |> Some
      | 48 -> { DogmaEffectData.id= 48; name= "powerBooster"; description= ""; displayName= ""; effectCategory= 1; preExpression= 404; postExpression= 131 } |> Some
      | 4801 -> { DogmaEffectData.id= 4801; name= "salvagingAccessDifficultyBonusMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15478; postExpression= 15479 } |> Some
      | 4898 -> { DogmaEffectData.id= 4898; name= "shipBonusDroneShieldHitpointsGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15803; postExpression= 15804 } |> Some
      | 4995 -> { DogmaEffectData.id= 4995; name= "shipArmorEXResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16065; postExpression= 16066 } |> Some
      | 5189 -> { DogmaEffectData.id= 5189; name= "trackingSpeedBonusEffectLasers"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16510; postExpression= 16511 } |> Some
      | 5286 -> { DogmaEffectData.id= 5286; name= "battlecruiserSkillLevelPreMulShipBonusCBC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16763; postExpression= 16764 } |> Some
      | 533 -> { DogmaEffectData.id= 533; name= "shipPTrackingBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2833; postExpression= 2834 } |> Some
      | 5383 -> { DogmaEffectData.id= 5383; name= "shipMissileEMDamageCC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16960; postExpression= 16961 } |> Some
      | 5480 -> { DogmaEffectData.id= 5480; name= "setBonusChristmasBonusVelocity"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17210; postExpression= 17211 } |> Some
      | 5868 -> { DogmaEffectData.id= 5868; name= "drawbackCargoCapacity"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18128; postExpression= 18129 } |> Some
      | 6062 -> { DogmaEffectData.id= 6062; name= "shipBonusLightDroneShieldHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18627; postExpression= 18628 } |> Some
      | 6256 -> { DogmaEffectData.id= 6256; name= "shipBonusEnergyNeutFalloffAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19033; postExpression= 19034 } |> Some
      | 6353 -> { DogmaEffectData.id= 6353; name= "roleBonusWDCapCPU"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19216; postExpression= 19217 } |> Some
      | 6450 -> { DogmaEffectData.id= 6450; name= "structureMissileGuidanceComputerBonus5"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6547 -> { DogmaEffectData.id= 6547; name= "shipBonusForceAuxiliaryC3CapCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6741 -> { DogmaEffectData.id= 6741; name= "npcBehaviorRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6838 -> { DogmaEffectData.id= 6838; name= "rigCapShipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of Capital ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6935 -> { DogmaEffectData.id= 6935; name= "subsystemBonusAmarrCore3EnergyWarHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19336; postExpression= 19337 } |> Some
      | 7032 -> { DogmaEffectData.id= 7032; name= "shipBonusHeavyMissileThermalDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19394; postExpression= 19395 } |> Some
      | 727 -> { DogmaEffectData.id= 727; name= "shipBonusCargoCI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3549; postExpression= 3550 } |> Some
      | _ -> None