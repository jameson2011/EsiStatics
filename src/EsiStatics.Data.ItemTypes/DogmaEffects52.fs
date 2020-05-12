namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects52=
    let getDogmaEffect id = 
      match id with 
      | 1022 -> { DogmaEffectData.id= 1022; name= "anchorDropForStructures"; description= "Anchoring this object in space."; displayName= "anchoring"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1119 -> { DogmaEffectData.id= 1119; name= "shipArmorExplosiveResistanceABC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4886; postExpression= 4887 } |> Some
      | 1410 -> { DogmaEffectData.id= 1410; name= "propulsionSkillCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1895 -> { DogmaEffectData.id= 1895; name= "miningUpgradeCPUReductionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2186 -> { DogmaEffectData.id= 2186; name= "shipBonusDroneHitpointsGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 246 -> { DogmaEffectData.id= 246; name= "sensorUpgradesSkillBoostPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2671 -> { DogmaEffectData.id= 2671; name= "maxTargetRangePremulModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9633; postExpression= 9634 } |> Some
      | 2768 -> { DogmaEffectData.id= 2768; name= "boosterModifyBoosterMissileAOECloudPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9909; postExpression= 9910 } |> Some
      | 2865 -> { DogmaEffectData.id= 2865; name= "velocityBonusOnline"; description= "Automatically generated effect"; displayName= "Max Velocity Bonus"; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 3156 -> { DogmaEffectData.id= 3156; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN&H&JP&L&M"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11029; postExpression= 11030 } |> Some
      | 3253 -> { DogmaEffectData.id= 3253; name= "tacticalShieldManipulationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11288; postExpression= 11289 } |> Some
      | 3350 -> { DogmaEffectData.id= 3350; name= "shipShieldThermalResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11596; postExpression= 11597 } |> Some
      | 343 -> { DogmaEffectData.id= 343; name= "industrialConstructionIndustrialConstructionTimeBonusPostPercentIndustrialConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3447 -> { DogmaEffectData.id= 3447; name= "shipBonusPTFalloffMB1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3544 -> { DogmaEffectData.id= 3544; name= "targetHybridWeaponMaxRangeBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12204; postExpression= 12205 } |> Some
      | 3835 -> { DogmaEffectData.id= 3835; name= "subsystemSkillLevelMinmatarDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4029 -> { DogmaEffectData.id= 4029; name= "systemRemoteEccmMagnetometric"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13468; postExpression= 13469 } |> Some
      | 4320 -> { DogmaEffectData.id= 4320; name= "subsystemBonusGallenteEngineering2DroneMWD"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 440 -> { DogmaEffectData.id= 440; name= "learningLearningBonusPostPercentIntelligenceChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2449; postExpression= 2450 } |> Some
      | 4417 -> { DogmaEffectData.id= 4417; name= "shipBonusAF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4514 -> { DogmaEffectData.id= 4514; name= "shipBonusDroneCapacityGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14782; postExpression= 14783 } |> Some
      | 4708 -> { DogmaEffectData.id= 4708; name= "systemEffectDamageThermalSmartbombs"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15284; postExpression= 15285 } |> Some
      | 4805 -> { DogmaEffectData.id= 4805; name= "ewSkillEcmBurstFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15490; postExpression= 15491 } |> Some
      | 4902 -> { DogmaEffectData.id= 4902; name= "MWDSignatureRadiusRoleBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4999 -> { DogmaEffectData.id= 4999; name= "shipHybridRangeBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5096 -> { DogmaEffectData.id= 5096; name= "passiveKineticShieldResonanceBonusGroupShieldHardener3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16310; postExpression= 16311 } |> Some
      | 5290 -> { DogmaEffectData.id= 5290; name= "battlecruiserSkillLevelPreMulShipBonusMBC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 537 -> { DogmaEffectData.id= 537; name= "droneBayBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 2849; postExpression= 2850 } |> Some
      | 5387 -> { DogmaEffectData.id= 5387; name= "shipHeavyAssaultMissileAOECloudSizeCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5484 -> { DogmaEffectData.id= 5484; name= "setBonusChristmasArmorHPBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5581 -> { DogmaEffectData.id= 5581; name= "marauderModeEffect4"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17446; postExpression= 17447 } |> Some
      | 5872 -> { DogmaEffectData.id= 5872; name= "shipBonusArmorRepairAI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6066 -> { DogmaEffectData.id= 6066; name= "shipBonusLightMissileKineticDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18633; postExpression= 18634 } |> Some
      | 6163 -> { DogmaEffectData.id= 6163; name= "passiveSpeedLimit"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6260 -> { DogmaEffectData.id= 6260; name= "shipBonusEnergyNosFalloffAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6357 -> { DogmaEffectData.id= 6357; name= "shipBonusJustScramblerRangeGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6551 -> { DogmaEffectData.id= 6551; name= "shipBonusForceAuxiliaryM1RemoteDuration"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6648 -> { DogmaEffectData.id= 6648; name= "shipBonusTitanC3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6745 -> { DogmaEffectData.id= 6745; name= "behaviorWarpScramble"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6842 -> { DogmaEffectData.id= 6842; name= "structureEngineeringRigSecurityModification"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6939 -> { DogmaEffectData.id= 6939; name= "subsystemBonusAmarrDefensive2HardenerHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7036 -> { DogmaEffectData.id= 7036; name= "shipBonusHeavyAssaultMissileEMDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7133 -> { DogmaEffectData.id= 7133; name= "selfMaxVelocityBonusPercentage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 19603; postExpression= 19604 } |> Some
      | 7230 -> { DogmaEffectData.id= 7230; name= "shipBonusDroneTrackingGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None