namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects88=
    let getDogmaEffect id = 
      match id with 
      | 1058 -> { DogmaEffectData.id= 1058; name= "eliteBonusHeavyGunshipLaserOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1252 -> { DogmaEffectData.id= 1252; name= "shipProjectileDamageDF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5329; postExpression= 5330 } |> Some
      | 1446 -> { DogmaEffectData.id= 1446; name= "ewSkillTpMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2707 -> { DogmaEffectData.id= 2707; name= "drawbackPowerNeedHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2804 -> { DogmaEffectData.id= 2804; name= "hybridWeaponSpeedMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2901 -> { DogmaEffectData.id= 2901; name= "missileKineticDmgBonusHeavy"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3095 -> { DogmaEffectData.id= 3095; name= "controlTowerGenericHullEmResistanceBonusMissile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10873; postExpression= 10874 } |> Some
      | 3192 -> { DogmaEffectData.id= 3192; name= "signatureRadiusMultiplierPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11152; postExpression= 11153 } |> Some
      | 3386 -> { DogmaEffectData.id= 3386; name= "cpuPenaltyToOmnipotent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11695; postExpression= 11696 } |> Some
      | 3483 -> { DogmaEffectData.id= 3483; name= "shipBonusMediumEnergyTurretDamagePirateFaction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3580 -> { DogmaEffectData.id= 3580; name= "targetScanResolutionBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12281; postExpression= 12282 } |> Some
      | 3677 -> { DogmaEffectData.id= 3677; name= "shipBonusLargeEnergyTurretMaxRangeAB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3774 -> { DogmaEffectData.id= 3774; name= "slotModifier"; description= "Anchoring this object in space."; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3871 -> { DogmaEffectData.id= 3871; name= "subsystemBonusCaldariPropulsionMWDPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13107; postExpression= 13108 } |> Some
      | 3968 -> { DogmaEffectData.id= 3968; name= "subsystemBonusCaldariDefensiveArmorRepairCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13301; postExpression= 13302 } |> Some
      | 4065 -> { DogmaEffectData.id= 4065; name= "subsystemBonusCaldariDefensiveDroneCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13599; postExpression= 13601 } |> Some
      | 4162 -> { DogmaEffectData.id= 4162; name= "baseSensorStrengthModifierRequiringAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4259 -> { DogmaEffectData.id= 4259; name= "subsystemBonusMinmatarOffensiveHeavyAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4356 -> { DogmaEffectData.id= 4356; name= "shipBonusLightHeavyAndHeavyAssaultMissileVelocityBonusCR3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14336; postExpression= 14337 } |> Some
      | 4453 -> { DogmaEffectData.id= 4453; name= "ScanGravimetricStrengthModifierEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4550 -> { DogmaEffectData.id= 4550; name= "capitalLauncherSkillCruiseCitadelThermalDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14937; postExpression= 14938 } |> Some
      | 4647 -> { DogmaEffectData.id= 4647; name= "eliteBonusBlackOpsECMGravAndLadarAndMagnetometricStrength1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15155; postExpression= 15156 } |> Some
      | 476 -> { DogmaEffectData.id= 476; name= "amarrFrigateSkillLevelPreMulShipBonusAFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4841 -> { DogmaEffectData.id= 4841; name= "shipLaserRangeBonusBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15639; postExpression= 15640 } |> Some
      | 5035 -> { DogmaEffectData.id= 5035; name= "shipBonusDroneHitpointsRookie"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5132 -> { DogmaEffectData.id= 5132; name= "shipPTurretFalloffBonusMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5229 -> { DogmaEffectData.id= 5229; name= "shipScanProbeStrengthBonusPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5326 -> { DogmaEffectData.id= 5326; name= "shipBonusDroneDamageMultiplierABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5423 -> { DogmaEffectData.id= 5423; name= "shipLaserRofAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17039; postExpression= 17040 } |> Some
      | 5714 -> { DogmaEffectData.id= 5714; name= "eliteBonusInterdictorsSHTDamage1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17729; postExpression= 17730 } |> Some
      | 5811 -> { DogmaEffectData.id= 5811; name= "shipBonusKineticMissileDamageGB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5908 -> { DogmaEffectData.id= 5908; name= "advancedIndustrySkillBoostAdvancedIndustrySkillIndustryJobTimeBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6005 -> { DogmaEffectData.id= 6005; name= "tacticalDestroyerAmarrSkillLevel3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6296 -> { DogmaEffectData.id= 6296; name= "shipBonusEnergyNeutOptimalAC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19126; postExpression= 19127 } |> Some
      | 6587 -> { DogmaEffectData.id= 6587; name= "skillMultiplierShipBonusSupercarrierAmarr"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6684 -> { DogmaEffectData.id= 6684; name= "structureModuleEffectRemoteSensorDampener"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 670 -> { DogmaEffectData.id= 670; name= "antiWarpScramblingPassive"; description= "Automatically generated effect"; displayName= "antiWarpScrambling"; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6781 -> { DogmaEffectData.id= 6781; name= "reloadTimeSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6878 -> { DogmaEffectData.id= 6878; name= "eliteBonusBlackOpsScramblerRange4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6975 -> { DogmaEffectData.id= 6975; name= "rigReactionBioMatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7072 -> { DogmaEffectData.id= 7072; name= "mediumPrecursorTurretDmgBonusRequiredSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7169 -> { DogmaEffectData.id= 7169; name= "shipBonusMutadaptiveRepAmountPC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 88 -> { DogmaEffectData.id= 88; name= "miningDurationMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 961 -> { DogmaEffectData.id= 961; name= "shipArmorThermalResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None