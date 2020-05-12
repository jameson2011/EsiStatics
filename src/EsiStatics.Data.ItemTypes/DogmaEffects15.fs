namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects15=
    let getDogmaEffect id = 
      match id with 
      | 1082 -> { DogmaEffectData.id= 1082; name= "eliteBonusHeavyGunshipLightMissileFlightTime1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 112 -> { DogmaEffectData.id= 112; name= "characterCharismaSkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1179 -> { DogmaEffectData.id= 1179; name= "eliteBonusGunshipLaserDamage2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1373 -> { DogmaEffectData.id= 1373; name= "ewSkillTargetPaintingStrengthBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1664 -> { DogmaEffectData.id= 1664; name= "freighterG1SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2052 -> { DogmaEffectData.id= 2052; name= "modifyShieldResonancePostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 209 -> { DogmaEffectData.id= 209; name= "propulsionJammingDurationBonusPostPercentDurationLocationShipModulesRequiringPropulsionJamming"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1429; postExpression= 1430 } |> Some
      | 2246 -> { DogmaEffectData.id= 2246; name= "scanStrengthTargetPercentBonus"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 2537 -> { DogmaEffectData.id= 2537; name= "shieldCapacityPenaltyPostPercentBoosterAttribute1"; description= "Automatically generated effect"; displayName= "Shield Capacity Penalty"; effectCategory= 0; preExpression= 9224; postExpression= 9225 } |> Some
      | 306 -> { DogmaEffectData.id= 306; name= "analyticalMindIntelligenceBonusModAddIntelligenceLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3119 -> { DogmaEffectData.id= 3119; name= "controlTowerGenericHullE&EResistanceBonusMissile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10959; postExpression= 10960 } |> Some
      | 3216 -> { DogmaEffectData.id= 3216; name= "shipHeavyAssaultMissileExplosiveDmgAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11220; postExpression= 11221 } |> Some
      | 3313 -> { DogmaEffectData.id= 3313; name= "cloneVatMaxJumpCloneBonusSkillNew"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3507 -> { DogmaEffectData.id= 3507; name= "frequencyMiningLaserMaxRangeMultBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12052; postExpression= 12053 } |> Some
      | 3604 -> { DogmaEffectData.id= 3604; name= "targetSetWarpScrambleStatusHidden"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12365; postExpression= 12366 } |> Some
      | 3895 -> { DogmaEffectData.id= 3895; name= "subsystemBonusGallenteCoreScanStrengthMagnetometric"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3992 -> { DogmaEffectData.id= 3992; name= "systemShieldHP"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 403 -> { DogmaEffectData.id= 403; name= "negotiationSkillBoostNegotiationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4089 -> { DogmaEffectData.id= 4089; name= "systemShieldRemoteRepairAmount"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4186 -> { DogmaEffectData.id= 4186; name= "subsystemBonusMinmatarOffensiveDroneBandwidth"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13889; postExpression= 13890 } |> Some
      | 4283 -> { DogmaEffectData.id= 4283; name= "subsystemBonusCaldariOffensive2HybridWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4380 -> { DogmaEffectData.id= 4380; name= "shipBonusTorpedoVelocityCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4477 -> { DogmaEffectData.id= 4477; name= "shipMTMaxRangeBonusATF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4768 -> { DogmaEffectData.id= 4768; name= "eliteBonusBlackOpsECMGravAndLadarAndMagnetometricAndRadarStrength5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15413; postExpression= 15414 } |> Some
      | 4865 -> { DogmaEffectData.id= 4865; name= "skillBonusBoosterTrackingSpeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15716; postExpression= 15717 } |> Some
      | 500 -> { DogmaEffectData.id= 500; name= "amarrCruiserSkillLevelPreMulShipBonusACShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5059 -> { DogmaEffectData.id= 5059; name= "shipBonusIceHarvesterDurationORE3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5156 -> { DogmaEffectData.id= 5156; name= "shipGCHYieldBonusOREfrig2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5350 -> { DogmaEffectData.id= 5350; name= "shipBonusHeavyAssaultMissileLauncherRofMBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5738 -> { DogmaEffectData.id= 5738; name= "shipBonusRemoteRepairRangePirateFaction2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5932 -> { DogmaEffectData.id= 5932; name= "targetSetVelocityMultiplier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 18310; postExpression= 18311 } |> Some
      | 597 -> { DogmaEffectData.id= 597; name= "targetedEMResonanceMultiply"; description= "Automatically generated effect"; displayName= "TargetedEMResonanceMultiply"; effectCategory= 2; preExpression= 3050; postExpression= 3051 } |> Some
      | 6029 -> { DogmaEffectData.id= 6029; name= "shipMissileBonusThermdmgMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18547; postExpression= 18548 } |> Some
      | 6223 -> { DogmaEffectData.id= 6223; name= "structureTargetMaxTargetRangeAndScanResolutionBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6320 -> { DogmaEffectData.id= 6320; name= "shipBonusThermalShieldResistanceMD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6417 -> { DogmaEffectData.id= 6417; name= "structureRigDoomsdayDamageLoss"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6514 -> { DogmaEffectData.id= 6514; name= "skillMultiplierShipBonusForceAuxiliaryAmarr"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6611 -> { DogmaEffectData.id= 6611; name= "shipBonusSupercarrierC2AfterburnerBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6708 -> { DogmaEffectData.id= 6708; name= "armorRepairAmountBonusSubcap"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6805 -> { DogmaEffectData.id= 6805; name= "rigEquipmentManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of equipment "; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6902 -> { DogmaEffectData.id= 6902; name= "shipModuleNonRepeatingShieldHardener"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6999 -> { DogmaEffectData.id= 6999; name= "covertOpsStealthBomberSiegeMissileLauncherCPUNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7193 -> { DogmaEffectData.id= 7193; name= "systemMiningCycleTimeBonus"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None