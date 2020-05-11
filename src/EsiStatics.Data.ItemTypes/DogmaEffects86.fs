namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects86=
    let getDogmaEffect id = 
      match id with 
      | 1056 -> { DogmaEffectData.id= 1056; name= "eliteBonusHeavyGunshipHybridOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4658; postExpression= 4659 } |> Some
      | 1638 -> { DogmaEffectData.id= 1638; name= "skillAdvancedWeaponUpgradesPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6505; postExpression= 6506 } |> Some
      | 2608 -> { DogmaEffectData.id= 2608; name= "scanLadarStrengthBonusPercentageScanStrengthBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9463; postExpression= 9464 } |> Some
      | 280 -> { DogmaEffectData.id= 280; name= "shieldManagementSkillBoostShieldCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1737; postExpression= 1738 } |> Some
      | 2802 -> { DogmaEffectData.id= 2802; name= "hybridWeaponDamageMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 669; postExpression= 672 } |> Some
      | 2899 -> { DogmaEffectData.id= 2899; name= "missileEMDmgBonusHeavy"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10253; postExpression= 10254 } |> Some
      | 3093 -> { DogmaEffectData.id= 3093; name= "controlTowerGenericHullKineticResistanceBonusMissile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10865; postExpression= 10866 } |> Some
      | 3384 -> { DogmaEffectData.id= 3384; name= "droneHPBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11687; postExpression= 11688 } |> Some
      | 3481 -> { DogmaEffectData.id= 3481; name= "shipBonusLargeEnergyTurretDamageCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11972; postExpression= 11973 } |> Some
      | 3675 -> { DogmaEffectData.id= 3675; name= "shipBonusArmorRepairAmountGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12581; postExpression= 12582 } |> Some
      | 3772 -> { DogmaEffectData.id= 3772; name= "subSystem"; description= "Must be installed into an available subsystem slot on a Tech III ship."; displayName= "Sub System"; effectCategory= 0; preExpression= 131; postExpression= 131 } |> Some
      | 3869 -> { DogmaEffectData.id= 3869; name= "subsystemBonusMinmatarPropulsion2MWDPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13103; postExpression= 13104 } |> Some
      | 3966 -> { DogmaEffectData.id= 3966; name= "subsystemBonusMinmatarDefensiveShieldBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13297; postExpression= 13298 } |> Some
      | 4063 -> { DogmaEffectData.id= 4063; name= "systemStandardMissileExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13595; postExpression= 13596 } |> Some
      | 4160 -> { DogmaEffectData.id= 4160; name= "massAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13828; postExpression= 13829 } |> Some
      | 4257 -> { DogmaEffectData.id= 4257; name= "subsystemBonusMinmatarOffensiveAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14115; postExpression= 14116 } |> Some
      | 4354 -> { DogmaEffectData.id= 4354; name= "shipMissileLightVelocityBonusCR3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14332; postExpression= 14333 } |> Some
      | 4451 -> { DogmaEffectData.id= 4451; name= "ScanRadarStrengthModifierEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14595; postExpression= 14596 } |> Some
      | 4645 -> { DogmaEffectData.id= 4645; name= "eliteBonusHeavyGunshipHeavyAndHeavyAssaultAndAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15151; postExpression= 15152 } |> Some
      | 474 -> { DogmaEffectData.id= 474; name= "shipTargetRangeBonusGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2566; postExpression= 2567 } |> Some
      | 4936 -> { DogmaEffectData.id= 4936; name= "fueledShieldBoosting"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 5227 -> { DogmaEffectData.id= 5227; name= "shipHeavyMissileKinDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16613; postExpression= 16614 } |> Some
      | 5324 -> { DogmaEffectData.id= 5324; name= "shipArmorKineticResistance1ABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16849; postExpression= 16850 } |> Some
      | 5421 -> { DogmaEffectData.id= 5421; name= "shipBonusEnergyNeutRangeAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17035; postExpression= 17036 } |> Some
      | 5615 -> { DogmaEffectData.id= 5615; name= "piTaxReductionModifierSkillModifier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17532; postExpression= 17533 } |> Some
      | 571 -> { DogmaEffectData.id= 571; name= "reverseEngineeringInventionBonusModAddReverseEngineeringChanceLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2970; postExpression= 2971 } |> Some
      | 5809 -> { DogmaEffectData.id= 5809; name= "shipBonusHeavyDroneArmorHpPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17981; postExpression= 17982 } |> Some
      | 5906 -> { DogmaEffectData.id= 5906; name= "advancedIndustryCopyTimeBonusPostPercent"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18234; postExpression= 18235 } |> Some
      | 6003 -> { DogmaEffectData.id= 6003; name= "tacticalDestroyerAmarrSkillLevel1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18494; postExpression= 18495 } |> Some
      | 6197 -> { DogmaEffectData.id= 6197; name= "energyNosferatuFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6294 -> { DogmaEffectData.id= 6294; name= "shipBonusEnergyNeutOptimalAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19122; postExpression= 19123 } |> Some
      | 6488 -> { DogmaEffectData.id= 6488; name= "scriptSensorBoosterSensorStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12333; postExpression= 12334 } |> Some
      | 6585 -> { DogmaEffectData.id= 6585; name= "skillMultiplierShipBonusCarrierGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 668 -> { DogmaEffectData.id= 668; name= "missileKineticDmgBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3338; postExpression= 3339 } |> Some
      | 6682 -> { DogmaEffectData.id= 6682; name= "structureModuleEffectStasisWebifier"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6779 -> { DogmaEffectData.id= 6779; name= "skirmishCommandStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6876 -> { DogmaEffectData.id= 6876; name= "blackOpsSkillMultiplier4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11761; postExpression= 11762 } |> Some
      | 6973 -> { DogmaEffectData.id= 6973; name= "rigReactionCompMatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7070 -> { DogmaEffectData.id= 7070; name= "precursorBattleshipSkillLevelPreMulShipBonusPBS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19443; postExpression= 19444 } |> Some
      | 7167 -> { DogmaEffectData.id= 7167; name= "shipBonusRemoteCapacitorTransferRangeRole1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19707; postExpression= 19708 } |> Some
      | 959 -> { DogmaEffectData.id= 959; name= "shipArmorExplosiveResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4259; postExpression= 4260 } |> Some
      | _ -> None