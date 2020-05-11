namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects56=
    let getDogmaEffect id = 
      match id with 
      | 1123 -> { DogmaEffectData.id= 1123; name= "shipShieldKineticResistanceCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4894; postExpression= 4895 } |> Some
      | 1220 -> { DogmaEffectData.id= 1220; name= "shipEnergyVampireTransferAmountBonusAc"; description= "Automatically generated effect"; displayName= "shipEnergyVampireTransferAmountBonusAB"; effectCategory= 0; preExpression= 5261; postExpression= 5262 } |> Some
      | 1802 -> { DogmaEffectData.id= 1802; name= "shipMissileLightVelocityBonusCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6970; postExpression= 6971 } |> Some
      | 1996 -> { DogmaEffectData.id= 1996; name= "caldariShipEwCapacitorNeedCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7577; postExpression= 7578 } |> Some
      | 2481 -> { DogmaEffectData.id= 2481; name= "warpScrambleForStructure"; description= "Attempts to prevent the target from warping."; displayName= "Warp Scramble"; effectCategory= 2; preExpression= 294; postExpression= 295 } |> Some
      | 2675 -> { DogmaEffectData.id= 2675; name= "shipHeavyAssaultLaunhcerROFBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9643; postExpression= 9644 } |> Some
      | 2772 -> { DogmaEffectData.id= 2772; name= "boosterModifyBoosterTurretTrackingPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9925; postExpression= 9926 } |> Some
      | 2869 -> { DogmaEffectData.id= 2869; name= "droneStasisWebifyingBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10154; postExpression= 10155 } |> Some
      | 3063 -> { DogmaEffectData.id= 3063; name= "controlTowerGenericOutsideStructureResistanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8493; postExpression= 8494 } |> Some
      | 3160 -> { DogmaEffectData.id= 3160; name= "controlTowerGenericHullResistanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11037; postExpression= 11038 } |> Some
      | 3451 -> { DogmaEffectData.id= 3451; name= "shipBonusStasisWebSpeedFactorAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11889; postExpression= 11890 } |> Some
      | 3548 -> { DogmaEffectData.id= 3548; name= "targetHybridWeaponMaxRangeAndTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12217; postExpression= 12218 } |> Some
      | 3742 -> { DogmaEffectData.id= 3742; name= "cargoAndOreHoldCapacityBonusICS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12747; postExpression= 12748 } |> Some
      | 3839 -> { DogmaEffectData.id= 3839; name= "subsystemSkillLevelAmarrElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13005; postExpression= 13006 } |> Some
      | 4033 -> { DogmaEffectData.id= 4033; name= "systemHeatDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13483; postExpression= 13484 } |> Some
      | 4130 -> { DogmaEffectData.id= 4130; name= "subsystemBonusGallenteOffensiveDroneHPHull"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13768; postExpression= 13769 } |> Some
      | 4324 -> { DogmaEffectData.id= 4324; name= "subsystemBonusAmarrOffensive3DroneHPArmor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14258; postExpression= 14259 } |> Some
      | 4421 -> { DogmaEffectData.id= 4421; name= "missileDMGBonus2"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14497; postExpression= 14498 } |> Some
      | 444 -> { DogmaEffectData.id= 444; name= "learningLearningBonusPostPercentMemoryChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2461; postExpression= 2462 } |> Some
      | 4518 -> { DogmaEffectData.id= 4518; name= "fighterBomberTorpedoExplosiveDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14796; postExpression= 14797 } |> Some
      | 4809 -> { DogmaEffectData.id= 4809; name= "ecmGravimetricStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15498; postExpression= 15499 } |> Some
      | 4906 -> { DogmaEffectData.id= 4906; name= "systemDamageFighters"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 15817; postExpression= 15818 } |> Some
      | 5100 -> { DogmaEffectData.id= 5100; name= "passiveEmShieldResonanceBonusGroupShieldHardener3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16316; postExpression= 16317 } |> Some
      | 5197 -> { DogmaEffectData.id= 5197; name= "shipBonusDroneHitpointsBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16530; postExpression= 16531 } |> Some
      | 5294 -> { DogmaEffectData.id= 5294; name= "shipLaserTracking2AD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16789; postExpression= 16790 } |> Some
      | 541 -> { DogmaEffectData.id= 541; name= "caldariBattleshipSkillLevelPreMulShipBonusCBShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2859; postExpression= 2860 } |> Some
      | 5585 -> { DogmaEffectData.id= 5585; name= "marauderModeEffect8"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17456; postExpression= 17457 } |> Some
      | 56 -> { DogmaEffectData.id= 56; name= "powerOutputMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 477; postExpression= 478 } |> Some
      | 5779 -> { DogmaEffectData.id= 5779; name= "shipBonusSPTFalloffMF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 6965; postExpression= 6966 } |> Some
      | 6070 -> { DogmaEffectData.id= 6070; name= "shipBonusHeavyMissileKineticDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18639; postExpression= 18640 } |> Some
      | 6361 -> { DogmaEffectData.id= 6361; name= "shipRocketExpDmgMF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16641; postExpression= 16642 } |> Some
      | 6555 -> { DogmaEffectData.id= 6555; name= "moduleBonusDroneNavigationComputer"; description= ""; displayName= ""; effectCategory= 4; preExpression= 59; postExpression= 59 } |> Some
      | 6652 -> { DogmaEffectData.id= 6652; name= "shipModuleAncillaryRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6846 -> { DogmaEffectData.id= 6846; name= "npcEntityTrackingDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6943 -> { DogmaEffectData.id= 6943; name= "subsystemBonusAmarrDefensive3ArmorRepHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7040 -> { DogmaEffectData.id= 7040; name= "structureHiddenArmorHPMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7137 -> { DogmaEffectData.id= 7137; name= "selfDeactivateMWD"; description= ""; displayName= ""; effectCategory= 1; preExpression= 19611; postExpression= 19612 } |> Some
      | 929 -> { DogmaEffectData.id= 929; name= "minmatarCruiserSkillLevelPreMulShipBonusMC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4226; postExpression= 4227 } |> Some
      | _ -> None