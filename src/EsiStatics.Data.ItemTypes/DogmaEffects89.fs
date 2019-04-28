namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects89=
    let getDogmaEffect id = 
      match id with 
      | 1156 -> { DogmaEffectData.id= 1156; name= "controlTowerTrackingArrayHybridOptimalBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5026; postExpression= 5027 } |> Some
      | 1738 -> { DogmaEffectData.id= 1738; name= "doHacking"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 1835 -> { DogmaEffectData.id= 1835; name= "miningYieldMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 7078; postExpression= 7079 } |> Some
      | 2029 -> { DogmaEffectData.id= 2029; name= "addToSignatureRadius2"; description= ""; displayName= ""; effectCategory= 4; preExpression= 7686; postExpression= 7687 } |> Some
      | 2126 -> { DogmaEffectData.id= 2126; name= "passiveEmShieldResonanceBonusGroupArmorHardener2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7989; postExpression= 7990 } |> Some
      | 2611 -> { DogmaEffectData.id= 2611; name= "eliteBonusGunshipProjectileDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9467; postExpression= 9468 } |> Some
      | 2708 -> { DogmaEffectData.id= 2708; name= "drawbackPowerNeedProjectiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9742; postExpression= 9743 } |> Some
      | 2805 -> { DogmaEffectData.id= 2805; name= "shipBonusLargeEnergyWeaponDamageAB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9965; postExpression= 9966 } |> Some
      | 283 -> { DogmaEffectData.id= 283; name= "shieldoperationSkillBoostRechargeratebonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1751; postExpression= 1752 } |> Some
      | 2902 -> { DogmaEffectData.id= 2902; name= "missileThermalDmgBonusHeavy"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10261; postExpression= 10262 } |> Some
      | 3096 -> { DogmaEffectData.id= 3096; name= "controlTowerGenericHullEmResistanceBonusProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10877; postExpression= 10878 } |> Some
      | 3193 -> { DogmaEffectData.id= 3193; name= "cloakingSignatureRadiusMultiplierMultiplierActive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 11159; postExpression= 11160 } |> Some
      | 3484 -> { DogmaEffectData.id= 3484; name= "shipBonusMediumEnergyTurretTrackingAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4376; postExpression= 4377 } |> Some
      | 3678 -> { DogmaEffectData.id= 3678; name= "eliteBonusJumpFreighterShieldHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12587; postExpression= 12588 } |> Some
      | 3872 -> { DogmaEffectData.id= 3872; name= "subsystemBonusAmarrPropulsion2MWDPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13109; postExpression= 13110 } |> Some
      | 3969 -> { DogmaEffectData.id= 3969; name= "subsystemBonusGallenteDefensiveArmorRepairCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13303; postExpression= 13304 } |> Some
      | 4066 -> { DogmaEffectData.id= 4066; name= "subsystemBonusGallenteDefensiveDroneCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13603; postExpression= 13605 } |> Some
      | 4163 -> { DogmaEffectData.id= 4163; name= "eliteBonusCoverOpsScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13843; postExpression= 13844 } |> Some
      | 4260 -> { DogmaEffectData.id= 4260; name= "subsystemBonusAmarrEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14121; postExpression= 14122 } |> Some
      | 4357 -> { DogmaEffectData.id= 4357; name= "caldariCruiserSkillLevelPreMulShipBonusCC3Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14340; postExpression= 14341 } |> Some
      | 4454 -> { DogmaEffectData.id= 4454; name= "ScanMagnetometricStrengthModifierEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14604; postExpression= 14605 } |> Some
      | 4551 -> { DogmaEffectData.id= 4551; name= "capitalLauncherSkillCruiseCitadelKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14941; postExpression= 14942 } |> Some
      | 4648 -> { DogmaEffectData.id= 4648; name= "eliteBonusBlackOpsECMGravAndLadarAndMagnetometricAndRadarStrength1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15157; postExpression= 15158 } |> Some
      | 4842 -> { DogmaEffectData.id= 4842; name= "shipHybridRangeBonusBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15641; postExpression= 15642 } |> Some
      | 5036 -> { DogmaEffectData.id= 5036; name= "shipBonusSalvageCycleAF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16164; postExpression= 16165 } |> Some
      | 5133 -> { DogmaEffectData.id= 5133; name= "shipHTDamageBonusCC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16386; postExpression= 16387 } |> Some
      | 5230 -> { DogmaEffectData.id= 5230; name= "modifyActiveShieldResonancePostPercent"; description= ""; displayName= ""; effectCategory= 1; preExpression= 7755; postExpression= 7756 } |> Some
      | 5327 -> { DogmaEffectData.id= 5327; name= "shipBonusDroneHullHitpointsABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16855; postExpression= 16856 } |> Some
      | 5424 -> { DogmaEffectData.id= 5424; name= "shipLargeHybridTurretRofGB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17041; postExpression= 17042 } |> Some
      | 5521 -> { DogmaEffectData.id= 5521; name= "eliteBonusCommandShipHeavyMissileDamageCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17301; postExpression= 17302 } |> Some
      | 5618 -> { DogmaEffectData.id= 5618; name= "shipBonusRHMLROF2CB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17540; postExpression= 17541 } |> Some
      | 5715 -> { DogmaEffectData.id= 5715; name= "setWarpSpeedMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17732; postExpression= 17733 } |> Some
      | 5812 -> { DogmaEffectData.id= 5812; name= "shipBonusThermalMissileDamageGB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17989; postExpression= 17990 } |> Some
      | 5909 -> { DogmaEffectData.id= 5909; name= "advancedIndustryManufactureTimeResearchTimeBonusPostPercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18245; postExpression= 18246 } |> Some
      | 6006 -> { DogmaEffectData.id= 6006; name= "shipSETDamageAmarrTacticalDestroyer1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18506; postExpression= 18507 } |> Some
      | 6297 -> { DogmaEffectData.id= 6297; name= "shipBonusEnergyNeutFalloffAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19128; postExpression= 19129 } |> Some
      | 6588 -> { DogmaEffectData.id= 6588; name= "skillMultiplierShipBonusSupercarrierCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6685 -> { DogmaEffectData.id= 6685; name= "structureModuleEffectECM"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6782 -> { DogmaEffectData.id= 6782; name= "commandBurstReloadTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6879 -> { DogmaEffectData.id= 6879; name= "eliteBonusBlackOpsWebRange3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7361; postExpression= 7362 } |> Some
      | 6976 -> { DogmaEffectData.id= 6976; name= "structureReactionRigSecurityModification"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7073 -> { DogmaEffectData.id= 7073; name= "largePrecursorTurretDmgBonusRequiredSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19461; postExpression= 19462 } |> Some
      | 7170 -> { DogmaEffectData.id= 7170; name= "shipBonusMutadaptiveRepCapNeedPC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19721; postExpression= 19722 } |> Some
      | 768 -> { DogmaEffectData.id= 768; name= "hypereuclideanNavigationCloakVelocityBonusModAddSpeedFactorLocationShipModulesRequiringCloaking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3670; postExpression= 3671 } |> Some
      | 89 -> { DogmaEffectData.id= 89; name= "projectileWeaponSpeedMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 654; postExpression= 655 } |> Some
      | _ -> None