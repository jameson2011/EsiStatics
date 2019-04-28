namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects28=
    let getDogmaEffect id = 
      match id with 
      | 1095 -> { DogmaEffectData.id= 1095; name= "destroyerPenalityTurretROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4789; postExpression= 4790 } |> Some
      | 1192 -> { DogmaEffectData.id= 1192; name= "controlTowerCaldariEwTargetSwitchDelayBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5048; postExpression= 5049 } |> Some
      | 1483 -> { DogmaEffectData.id= 1483; name= "contrabandMasking"; description= ""; displayName= ""; effectCategory= 1; preExpression= 6032; postExpression= 6033 } |> Some
      | 1871 -> { DogmaEffectData.id= 1871; name= "entityTargetJam"; description= ""; displayName= ""; effectCategory= 2; preExpression= 7210; postExpression= 7211 } |> Some
      | 1968 -> { DogmaEffectData.id= 1968; name= "shipBonusTrackingLinkMC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7513; postExpression= 7514 } |> Some
      | 2162 -> { DogmaEffectData.id= 2162; name= "eliteBonusCommandShipSiegeCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8101; postExpression= 8102 } |> Some
      | 222 -> { DogmaEffectData.id= 222; name= "navigationSkillBoostVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1491; postExpression= 1492 } |> Some
      | 2259 -> { DogmaEffectData.id= 2259; name= "eliteBargeBonusDamageCloudReduction2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8364; postExpression= 8365 } |> Some
      | 2356 -> { DogmaEffectData.id= 2356; name= "capitalRemoteEnergyTransferCapNeedBonusSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8713; postExpression= 8714 } |> Some
      | 2453 -> { DogmaEffectData.id= 2453; name= "eliteBonusCommandShipLaserOptimalCS1FIXED"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9021; postExpression= 9022 } |> Some
      | 2647 -> { DogmaEffectData.id= 2647; name= "eliteBonusHeavyGunshipHeavyMissileLaunhcerRof2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9570; postExpression= 9571 } |> Some
      | 2841 -> { DogmaEffectData.id= 2841; name= "shipBonusHeavyMissileKineticDamageBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10077; postExpression= 10078 } |> Some
      | 3035 -> { DogmaEffectData.id= 3035; name= "overloadSelfHardeningInvulnerabilityBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 10678; postExpression= 10679 } |> Some
      | 319 -> { DogmaEffectData.id= 319; name= "caldariTechSkillBoostCaldariTechMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1903; postExpression= 1904 } |> Some
      | 3229 -> { DogmaEffectData.id= 3229; name= "shipHeavyAssaultMissileExplosiveDmgBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11240; postExpression= 11241 } |> Some
      | 3326 -> { DogmaEffectData.id= 3326; name= "shipBonusORECapShipDroneArmorHPAndShieldHPAndHpBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11539; postExpression= 11540 } |> Some
      | 3423 -> { DogmaEffectData.id= 3423; name= "eliteBonusViolatorsLargeEnergyTurretTracking1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11820; postExpression= 11821 } |> Some
      | 3520 -> { DogmaEffectData.id= 3520; name= "skillAdvancedWeaponUpgradesPowerNeedBonusBombLaunchers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12093; postExpression= 12094 } |> Some
      | 3617 -> { DogmaEffectData.id= 3617; name= "scriptSignatureRadiusBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12420; postExpression= 12421 } |> Some
      | 3714 -> { DogmaEffectData.id= 3714; name= "concordModifyTargetSpeed"; description= ""; displayName= "modifyTargetSpeed"; effectCategory= 2; preExpression= 3489; postExpression= 3491 } |> Some
      | 3811 -> { DogmaEffectData.id= 3811; name= "capacitorCapacityAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12906; postExpression= 12907 } |> Some
      | 3908 -> { DogmaEffectData.id= 3908; name= "subsystemBonusAmarrDefensiveArmorResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13183; postExpression= 13184 } |> Some
      | 4005 -> { DogmaEffectData.id= 4005; name= "systemDroneControlRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13381; postExpression= 13382 } |> Some
      | 4102 -> { DogmaEffectData.id= 4102; name= "subsystemBonusCaldariOffensiveHybridWeaponTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13708; postExpression= 13709 } |> Some
      | 416 -> { DogmaEffectData.id= 416; name= "tradeTradePremiumBonusPostPercentTradePremiumChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2343; postExpression= 2344 } |> Some
      | 4199 -> { DogmaEffectData.id= 4199; name= "subsystemSkillLevelMinmatarElectronic2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13942; postExpression= 13943 } |> Some
      | 4393 -> { DogmaEffectData.id= 4393; name= "shipBonusEliteCover2TorpedoThermalDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14422; postExpression= 14423 } |> Some
      | 4490 -> { DogmaEffectData.id= 4490; name= "superWeaponCaldari"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 4684 -> { DogmaEffectData.id= 4684; name= "systemThermalMissileDmgModifier"; description= ""; displayName= ""; effectCategory= 7; preExpression= 15230; postExpression= 15231 } |> Some
      | 4781 -> { DogmaEffectData.id= 4781; name= "shipArmorTHEResistanceATF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15430; postExpression= 15431 } |> Some
      | 4975 -> { DogmaEffectData.id= 4975; name= "shipBonusMissileKineticlATF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16010; postExpression= 16011 } |> Some
      | 5266 -> { DogmaEffectData.id= 5266; name= "blockadeRunnerCloakCpuPercentBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16692; postExpression= 16693 } |> Some
      | 5460 -> { DogmaEffectData.id= 5460; name= "minigameVirusStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17151; postExpression= 17152 } |> Some
      | 5557 -> { DogmaEffectData.id= 5557; name= "shipBonusSentryDroneOptimalRangeEliteBonusHeavyGunship2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17390; postExpression= 17391 } |> Some
      | 5945 -> { DogmaEffectData.id= 5945; name= "cloakingPrototype"; description= ""; displayName= "[no messageID: 296834]"; effectCategory= 1; preExpression= 3908; postExpression= 3909 } |> Some
      | 6042 -> { DogmaEffectData.id= 6042; name= "entitySuperWeapon"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 6139 -> { DogmaEffectData.id= 6139; name= "overloadSelfMissileGuidanceAOECloudSizeBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 5; preExpression= 18817; postExpression= 18818 } |> Some
      | 6236 -> { DogmaEffectData.id= 6236; name= "shipBonusEnergyNosFalloffRS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18987; postExpression= 18988 } |> Some
      | 6333 -> { DogmaEffectData.id= 6333; name= "shipBonusShieldExplosiveResistanceCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19190; postExpression= 19191 } |> Some
      | 6430 -> { DogmaEffectData.id= 6430; name= "fighterAbilityAttack"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6527 -> { DogmaEffectData.id= 6527; name= "shipBonusForceAuxiliaryA2ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6624 -> { DogmaEffectData.id= 6624; name= "shipBonusSupercarrierM2FighterVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6721 -> { DogmaEffectData.id= 6721; name= "eliteBonusLogisticRemoteArmorRepairOptimalFalloff1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19299; postExpression= 19300 } |> Some
      | 6818 -> { DogmaEffectData.id= 6818; name= "rigAdvSmshipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced small ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6915 -> { DogmaEffectData.id= 6915; name= "subsystemSkillLevelCaldariDefensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12973; postExpression= 12974 } |> Some
      | 7012 -> { DogmaEffectData.id= 7012; name= "moduleBonusAssaultDamageControl"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 707 -> { DogmaEffectData.id= 707; name= "bomberRocketRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3469; postExpression= 3470 } |> Some
      | 7109 -> { DogmaEffectData.id= 7109; name= "structureConversionRigInventionCostBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 804 -> { DogmaEffectData.id= 804; name= "ammoInfluenceCapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3797; postExpression= 3798 } |> Some
      | 901 -> { DogmaEffectData.id= 901; name= "onlineForStructures"; description= "this is the online effect for structures"; displayName= "online"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 998 -> { DogmaEffectData.id= 998; name= "eliteBonusGunshipProjectileFalloff2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4419; postExpression= 4420 } |> Some
      | _ -> None