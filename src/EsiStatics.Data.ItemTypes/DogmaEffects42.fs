namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects42=
    let getDogmaEffect id = 
      match id with 
      | 1012 -> { DogmaEffectData.id= 1012; name= "selfT2MediumHybridRailDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4486; postExpression= 4487 } |> Some
      | 1109 -> { DogmaEffectData.id= 1109; name= "battlecruiserSkillLevelPreMulShipBonusBC1Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4856; postExpression= 4857 } |> Some
      | 1400 -> { DogmaEffectData.id= 1400; name= "eliteBonusCoverOpsCruiseExplosiveDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5799; postExpression= 5800 } |> Some
      | 1594 -> { DogmaEffectData.id= 1594; name= "capitalLauncherSkillCitadelThermalDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6373; postExpression= 6374 } |> Some
      | 1885 -> { DogmaEffectData.id= 1885; name= "shipCruiseLauncherROFBonus2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7234; postExpression= 7235 } |> Some
      | 236 -> { DogmaEffectData.id= 236; name= "energyEmmisionSystemsCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringEnergyEmmisionSystems"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1559; postExpression= 1560 } |> Some
      | 2467 -> { DogmaEffectData.id= 2467; name= "shipLaserDamageBonusBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9053; postExpression= 9054 } |> Some
      | 2661 -> { DogmaEffectData.id= 2661; name= "scanRadarStrengthBonusRequringAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9611; postExpression= 9612 } |> Some
      | 2758 -> { DogmaEffectData.id= 2758; name= "boosterModifyBoosterArmorHPPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9874; postExpression= 9875 } |> Some
      | 2855 -> { DogmaEffectData.id= 2855; name= "eliteReconBonusHeavyAssaultLauncherROF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10115; postExpression= 10116 } |> Some
      | 3146 -> { DogmaEffectData.id= 3146; name= "controlTowerGenericHullResistanceBonusScrambler"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11011; postExpression= 11012 } |> Some
      | 3243 -> { DogmaEffectData.id= 3243; name= "eliteBonusGunshipArmorKineticResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11268; postExpression= 11269 } |> Some
      | 3340 -> { DogmaEffectData.id= 3340; name= "shipArmorThermalResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11566; postExpression= 11567 } |> Some
      | 3437 -> { DogmaEffectData.id= 3437; name= "shipBonusTorpedoKineticDamageCB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11856; postExpression= 11857 } |> Some
      | 3728 -> { DogmaEffectData.id= 3728; name= "shieldBoostAmplifierPassiveCapitalUNUSED"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6717; postExpression= 6718 } |> Some
      | 3922 -> { DogmaEffectData.id= 3922; name= "subsystemBonusGallenteDefensiveArmorResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13211; postExpression= 13212 } |> Some
      | 4019 -> { DogmaEffectData.id= 4019; name= "systemDamageExplosiveMissiles"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13429; postExpression= 13430 } |> Some
      | 4116 -> { DogmaEffectData.id= 4116; name= "subsystemBonusCaldariOffensiveMissileLauncherKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13738; postExpression= 13739 } |> Some
      | 42 -> { DogmaEffectData.id= 42; name= "turretFitted"; description= ""; displayName= ""; effectCategory= 0; preExpression= 379; postExpression= 305 } |> Some
      | 4213 -> { DogmaEffectData.id= 4213; name= "subsystemSkillLevelGallentePropulsion2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14012; postExpression= 14013 } |> Some
      | 430 -> { DogmaEffectData.id= 430; name= "scienceSkillBoostCopySpeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2400; postExpression= 2401 } |> Some
      | 4407 -> { DogmaEffectData.id= 4407; name= "subSystemBonusCaldariElectronic2TractorBeamRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14450; postExpression= 14451 } |> Some
      | 4601 -> { DogmaEffectData.id= 4601; name= "minmatarFrigateSkillLevelPreMulShipBonus3MFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15067; postExpression= 15068 } |> Some
      | 4795 -> { DogmaEffectData.id= 4795; name= "shipBonusMissileLauncherHeavyAssaultROFATC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15462; postExpression= 15463 } |> Some
      | 4989 -> { DogmaEffectData.id= 4989; name= "missileSkillAoeCloudSizeBonusAllIncludingCapitals"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16049; postExpression= 16050 } |> Some
      | 5183 -> { DogmaEffectData.id= 5183; name= "sensorCompensationSensorStrengthBonusRadar"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16488; postExpression= 16489 } |> Some
      | 527 -> { DogmaEffectData.id= 527; name= "shipVelocityBonusMI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2811; postExpression= 2812 } |> Some
      | 5280 -> { DogmaEffectData.id= 5280; name= "destroyerSkillLevelPreMulShipBonusGD1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16738; postExpression= 16739 } |> Some
      | 5377 -> { DogmaEffectData.id= 5377; name= "shipHeavyAssaultMissileVelocityCBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16948; postExpression= 16949 } |> Some
      | 5474 -> { DogmaEffectData.id= 5474; name= "shipBonusOreCapacityGI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17193; postExpression= 17194 } |> Some
      | 5571 -> { DogmaEffectData.id= 5571; name= "commandShipSkillMultiplier3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17428; postExpression= 17429 } |> Some
      | 5862 -> { DogmaEffectData.id= 5862; name= "shipMissileEMDamageCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18116; postExpression= 18117 } |> Some
      | 5959 -> { DogmaEffectData.id= 5959; name= "eliteBonusHeavyInterdictorsHybridOptimal1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18383; postExpression= 18384 } |> Some
      | 6056 -> { DogmaEffectData.id= 6056; name= "shipBonusHeavyDroneShieldHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18615; postExpression= 18616 } |> Some
      | 6153 -> { DogmaEffectData.id= 6153; name= "modeMWDCapPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18853; postExpression= 18854 } |> Some
      | 6347 -> { DogmaEffectData.id= 6347; name= "structureTargetMissileGuidanceComputerBonus"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6638 -> { DogmaEffectData.id= 6638; name= "shipBonusTitanC2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6735 -> { DogmaEffectData.id= 6735; name= "moduleBonusWarfareLinkInfo"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6832 -> { DogmaEffectData.id= 6832; name= "rigMEResearchCostBonus"; description= "Structure Rig Cost effect on ME Research"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6929 -> { DogmaEffectData.id= 6929; name= "subsystemBonusGallentePropulsion2PropModHeatBenefit"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13091; postExpression= 13092 } |> Some
      | 7026 -> { DogmaEffectData.id= 7026; name= "scriptStandupWarpScram"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12336; postExpression= 12337 } |> Some
      | 721 -> { DogmaEffectData.id= 721; name= "miningCapBonus"; description= "Automatically generated effect"; displayName= "Reduces Mining laser activation power"; effectCategory= 0; preExpression= 3536; postExpression= 3537 } |> Some
      | 7220 -> { DogmaEffectData.id= 7220; name= "shipSmartBombPowerReductionEliteHeavyGunship2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19834; postExpression= 19835 } |> Some
      | _ -> None