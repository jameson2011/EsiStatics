namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects90=
    let getDogmaEffect id = 
      match id with 
      | 1060 -> { DogmaEffectData.id= 1060; name= "eliteBonusHeavyGunshipProjectileFallOff1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1157 -> { DogmaEffectData.id= 1157; name= "controlTowerTrackingArrayLaserOptimalBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1448 -> { DogmaEffectData.id= 1448; name= "ewSkillTdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 187 -> { DogmaEffectData.id= 187; name= "caldariCruiserSkillBoostCcTRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2127 -> { DogmaEffectData.id= 2127; name= "passiveExplosiveShieldResonanceBonusGroupArmorHardener2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7993; postExpression= 7994 } |> Some
      | 2224 -> { DogmaEffectData.id= 2224; name= "warpNavigationWarpAccuracySkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8272; postExpression= 8273 } |> Some
      | 2612 -> { DogmaEffectData.id= 2612; name= "eliteBonusGunshipProjectileDamage2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9469; postExpression= 9470 } |> Some
      | 2709 -> { DogmaEffectData.id= 2709; name= "drawbackPowerNeedLaunchers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9744; postExpression= 9745 } |> Some
      | 2806 -> { DogmaEffectData.id= 2806; name= "maxRangeBonusEffectHybridsMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9968; postExpression= 9969 } |> Some
      | 2903 -> { DogmaEffectData.id= 2903; name= "missileEMDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3097 -> { DogmaEffectData.id= 3097; name= "controlTowerGenericHullExplosiveResistanceBonusProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10881; postExpression= 10882 } |> Some
      | 3485 -> { DogmaEffectData.id= 3485; name= "shipBonusMediumEnergyTurretDamageCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11980; postExpression= 11981 } |> Some
      | 3582 -> { DogmaEffectData.id= 3582; name= "targetMaxTargetRangeBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12283; postExpression= 12284 } |> Some
      | 3679 -> { DogmaEffectData.id= 3679; name= "eliteBonusJumpFreighterArmorHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3873 -> { DogmaEffectData.id= 3873; name= "subsystemBonusAmarrPropulsionABMWDCapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13111; postExpression= 13112 } |> Some
      | 3970 -> { DogmaEffectData.id= 3970; name= "subsystemBonusMinmatarDefensiveArmorRepairCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13305; postExpression= 13306 } |> Some
      | 4067 -> { DogmaEffectData.id= 4067; name= "systemMediumEnergyDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13604; postExpression= 13606 } |> Some
      | 4164 -> { DogmaEffectData.id= 4164; name= "shipBonusScanProbeStrengthAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13845; postExpression= 13846 } |> Some
      | 4261 -> { DogmaEffectData.id= 4261; name= "subsystemBonusCaldariEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4358 -> { DogmaEffectData.id= 4358; name= "ecmRangeBonusModuleEffect"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 4455 -> { DogmaEffectData.id= 4455; name= "imperialsetbonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14608; postExpression= 14609 } |> Some
      | 4552 -> { DogmaEffectData.id= 4552; name= "capitalLauncherSkillCruiseCitadelExplosiveDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14945; postExpression= 14946 } |> Some
      | 4649 -> { DogmaEffectData.id= 4649; name= "shipCruiseAndSiegeLauncherROFBonus2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4843 -> { DogmaEffectData.id= 4843; name= "shipHybridDamageBonusBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15643; postExpression= 15644 } |> Some
      | 4940 -> { DogmaEffectData.id= 4940; name= "nosReflectAmount"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 15927; postExpression= 15928 } |> Some
      | 5037 -> { DogmaEffectData.id= 5037; name= "shipBonusHackingCycleAF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16168; postExpression= 16169 } |> Some
      | 5231 -> { DogmaEffectData.id= 5231; name= "modifyActiveArmorResonancePostPercent"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5328 -> { DogmaEffectData.id= 5328; name= "shipBonusDroneArmorHitpointsABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16857; postExpression= 16858 } |> Some
      | 5619 -> { DogmaEffectData.id= 5619; name= "shipBonusRHMLROFCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 575 -> { DogmaEffectData.id= 575; name= "modifyTargetSpeed2"; description= ""; displayName= "modifyTargetSpeed"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5813 -> { DogmaEffectData.id= 5813; name= "shipBonusAfterburnerSpeedFactorCF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5910 -> { DogmaEffectData.id= 5910; name= "advancedIndustryMaterialResearchTimeBonusPostPercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6007 -> { DogmaEffectData.id= 6007; name= "shipSETCapNeedAmarrTacticalDestroyer2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6104 -> { DogmaEffectData.id= 6104; name= "entosisDurationMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6201 -> { DogmaEffectData.id= 6201; name= "doomsdaySlash"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6298 -> { DogmaEffectData.id= 6298; name= "shipBonusEnergyNeutFalloffAC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19130; postExpression= 19131 } |> Some
      | 6395 -> { DogmaEffectData.id= 6395; name= "shipBonusEwWeaponDisruptionStrengthAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6492 -> { DogmaEffectData.id= 6492; name= "skillMultiplierShipBonusDreadnoughtCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6589 -> { DogmaEffectData.id= 6589; name= "skillMultiplierShipBonusSupercarrierGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6686 -> { DogmaEffectData.id= 6686; name= "structureModuleEffectWeaponDisruption"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 672 -> { DogmaEffectData.id= 672; name= "weaponUpgradesSkillBoostCpu"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6783 -> { DogmaEffectData.id= 6783; name= "commandBurstAoERoleBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6880 -> { DogmaEffectData.id= 6880; name= "shipBonusLauncherRoF2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6977 -> { DogmaEffectData.id= 6977; name= "rigMoonSpewVolBonus"; description= "increases volume of asteroids created from moon drill"; displayName= "Drill Volume Bonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7074 -> { DogmaEffectData.id= 7074; name= "smallDisintegratorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7171 -> { DogmaEffectData.id= 7171; name= "shipBonusMutadaptiveRemoteRepRangePC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None