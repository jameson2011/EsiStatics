namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects21=
    let getDogmaEffect id = 
      match id with 
      | 118 -> { DogmaEffectData.id= 118; name= "electronicAttributeModifyOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 846; postExpression= 847 } |> Some
      | 1185 -> { DogmaEffectData.id= 1185; name= "structureStealthEmitterArraySigDecrease"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3277; postExpression= 3278 } |> Some
      | 1282 -> { DogmaEffectData.id= 1282; name= "eliteIndustrial1SkillLevelPreMulEliteBonusEliteIndustrialShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5415; postExpression= 5416 } |> Some
      | 1670 -> { DogmaEffectData.id= 1670; name= "freighterCargoBonusG2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6621; postExpression= 6622 } |> Some
      | 1767 -> { DogmaEffectData.id= 1767; name= "shipBonusPirateSanshaLaserCap"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6871; postExpression= 6872 } |> Some
      | 1864 -> { DogmaEffectData.id= 1864; name= "shipMissileExplosiveDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7175; postExpression= 7176 } |> Some
      | 21 -> { DogmaEffectData.id= 21; name= "shieldCapacityBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 199; postExpression= 201 } |> Some
      | 215 -> { DogmaEffectData.id= 215; name= "weaponDisruptionDurationBonusPostPercentDurationLocationShipModulesRequiringWeaponDisruption"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1459; postExpression= 1460 } |> Some
      | 2155 -> { DogmaEffectData.id= 2155; name= "eliteBonusCommandShipProjectileDamageCS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8087; postExpression= 8088 } |> Some
      | 2252 -> { DogmaEffectData.id= 2252; name= "covertOpsAndReconOpsCloakModuleDelayBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8338; postExpression= 8339 } |> Some
      | 2543 -> { DogmaEffectData.id= 2543; name= "turretOptimalRangePenaltyBoosterAttribute4"; description= "Automatically generated effect"; displayName= "Turret Optimal Range Penalty"; effectCategory= 0; preExpression= 9244; postExpression= 9245 } |> Some
      | 2737 -> { DogmaEffectData.id= 2737; name= "boosterShieldCapacityPenalty"; description= "Automatically generated effect"; displayName= "Shield Capacity Penalty"; effectCategory= 0; preExpression= 9827; postExpression= 9828 } |> Some
      | 3028 -> { DogmaEffectData.id= 3028; name= "eliteBonusCoverOpsBombEmDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10660; postExpression= 10661 } |> Some
      | 312 -> { DogmaEffectData.id= 312; name= "signatureAnalysisMaxTargetRangeBonusPostPercentMaxTargetRangeLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1857; postExpression= 1858 } |> Some
      | 3125 -> { DogmaEffectData.id= 3125; name= "controlTowerGenericHullK&TResistanceBonusCynoJammer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10971; postExpression= 10972 } |> Some
      | 3416 -> { DogmaEffectData.id= 3416; name= "eliteBonusViolatorsLargeHybridTurretDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11806; postExpression= 11807 } |> Some
      | 3513 -> { DogmaEffectData.id= 3513; name= "setBonusMordus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12070; postExpression= 12071 } |> Some
      | 3707 -> { DogmaEffectData.id= 3707; name= "shipBonusSurveyProbeExplosionDelaySkillSurveyAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12668; postExpression= 12669 } |> Some
      | 3901 -> { DogmaEffectData.id= 3901; name= "subsystemBonusAmarrElectronicScanStrengthGravimetric"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13169; postExpression= 13170 } |> Some
      | 3998 -> { DogmaEffectData.id= 3998; name= "systemArmorKineticResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13358; postExpression= 13359 } |> Some
      | 4095 -> { DogmaEffectData.id= 4095; name= "subsystemBonusAmarrOffensiveEnergyWeaponFalloff"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13694; postExpression= 13695 } |> Some
      | 4192 -> { DogmaEffectData.id= 4192; name= "strategicCruiserCaldariSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13909; postExpression= 13910 } |> Some
      | 4289 -> { DogmaEffectData.id= 4289; name= "subsystemBonusMinmatarDefensive2RemoteArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14180; postExpression= 14181 } |> Some
      | 4386 -> { DogmaEffectData.id= 4386; name= "shipBonusHeavyLauncherRateOfFireCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14408; postExpression= 14409 } |> Some
      | 4483 -> { DogmaEffectData.id= 4483; name= "shipBonusPTFalloffMB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14691; postExpression= 14692 } |> Some
      | 4774 -> { DogmaEffectData.id= 4774; name= "deployPledge"; description= "Deployment of pledges from a ship to a planet."; displayName= "Pledge Deployment"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 4871 -> { DogmaEffectData.id= 4871; name= "setBonusChristmasCapacitorRecharge2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15740; postExpression= 15741 } |> Some
      | 4968 -> { DogmaEffectData.id= 4968; name= "boosterShieldBoostAmountPenaltyShieldOperation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15996; postExpression= 15997 } |> Some
      | 506 -> { DogmaEffectData.id= 506; name= "fuelConservationCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2690; postExpression= 2691 } |> Some
      | 5162 -> { DogmaEffectData.id= 5162; name= "skillReactiveArmorHardenerCapNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16449; postExpression= 16450 } |> Some
      | 5259 -> { DogmaEffectData.id= 5259; name= "reconShipCloakCpuBonus1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16669; postExpression= 16670 } |> Some
      | 5356 -> { DogmaEffectData.id= 5356; name= "shipHybridRangeBonusCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16913; postExpression= 16914 } |> Some
      | 5647 -> { DogmaEffectData.id= 5647; name= "covertOpsCloakCPUPercentRoleBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17595; postExpression= 17596 } |> Some
      | 5938 -> { DogmaEffectData.id= 5938; name= "shipBonusSmallMissileExplosionRadiusCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18327; postExpression= 18328 } |> Some
      | 6035 -> { DogmaEffectData.id= 6035; name= "tacticalDestroyerMinmatarSkillLevel3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18570; postExpression= 18571 } |> Some
      | 6132 -> { DogmaEffectData.id= 6132; name= "missileGuidanceComputerBonus1"; description= "combining missile velocity and explosion delay"; displayName= ""; effectCategory= 1; preExpression= 18798; postExpression= 18799 } |> Some
      | 6229 -> { DogmaEffectData.id= 6229; name= "shipBonusEnergyNeutOptimalRS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18968; postExpression= 18969 } |> Some
      | 6326 -> { DogmaEffectData.id= 6326; name= "shipBonusThermalMissileDamageCD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19176; postExpression= 19177 } |> Some
      | 6423 -> { DogmaEffectData.id= 6423; name= "shipModuleGuidanceDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6520 -> { DogmaEffectData.id= 6520; name= "skillMultiplierShipBonusForceAuxiliaryGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6617 -> { DogmaEffectData.id= 6617; name= "shipBonusSupercarrierG4BurstProjectorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6714 -> { DogmaEffectData.id= 6714; name= "ECMBurstJammer"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6811 -> { DogmaEffectData.id= 6811; name= "rigDroneManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of drones"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6908 -> { DogmaEffectData.id= 6908; name= "shipBonusStrategicCruiserCaldariNaniteRepairTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12698; postExpression= 12699 } |> Some
      | 7102 -> { DogmaEffectData.id= 7102; name= "structureConversionRigT2CompManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 797 -> { DogmaEffectData.id= 797; name= "caldariBattleshipSkillLevelPreMulShipBonusCB3Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3767; postExpression= 3768 } |> Some
      | 991 -> { DogmaEffectData.id= 991; name= "eliteBonusGunshipLaserOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4397; postExpression= 4398 } |> Some
      | _ -> None