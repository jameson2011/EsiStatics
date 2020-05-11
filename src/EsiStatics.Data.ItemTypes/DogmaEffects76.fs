namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects76=
    let getDogmaEffect id = 
      match id with 
      | 1046 -> { DogmaEffectData.id= 1046; name= "shipRemoteArmorRangeGC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4614; postExpression= 4615 } |> Some
      | 1143 -> { DogmaEffectData.id= 1143; name= "shipLaserCapNeedAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4985; postExpression= 4986 } |> Some
      | 1240 -> { DogmaEffectData.id= 1240; name= "shipHybridDmgPirateBattleship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5301; postExpression= 5302 } |> Some
      | 1434 -> { DogmaEffectData.id= 1434; name= "caldariShipEwStrengthCB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5888; postExpression= 5889 } |> Some
      | 173 -> { DogmaEffectData.id= 173; name= "smallHybridTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringSmallHybridTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1272; postExpression= 1273 } |> Some
      | 2016 -> { DogmaEffectData.id= 2016; name= "droneDurabilityArmorHPBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7649; postExpression= 7650 } |> Some
      | 2113 -> { DogmaEffectData.id= 2113; name= "passiveEmArmorResonanceBonusGroupArmorHardener2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7957; postExpression= 7958 } |> Some
      | 2695 -> { DogmaEffectData.id= 2695; name= "falloffBonusEffectProjectiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9703; postExpression= 9704 } |> Some
      | 270 -> { DogmaEffectData.id= 270; name= "hullUpgradesSkillBoostArmorHpBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1689; postExpression= 1690 } |> Some
      | 2792 -> { DogmaEffectData.id= 2792; name= "modifyArmorResonancePostPercentPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7725; postExpression= 7726 } |> Some
      | 2889 -> { DogmaEffectData.id= 2889; name= "missileKineticDmgBonusRocket"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10215; postExpression= 10216 } |> Some
      | 3083 -> { DogmaEffectData.id= 3083; name= "controlTowerGenericHullThermicResistanceBonusJumpPortal"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10825; postExpression= 10826 } |> Some
      | 3374 -> { DogmaEffectData.id= 3374; name= "eliteBonusElectronicAttackShipSignatureRadius2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11653; postExpression= 11654 } |> Some
      | 3568 -> { DogmaEffectData.id= 3568; name= "eliteBonusLogisticsTrackingLinkMaxRangeBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12266; postExpression= 12267 } |> Some
      | 3665 -> { DogmaEffectData.id= 3665; name= "scanMagnetometricStrengthBonusScannerProbeGroup"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12560; postExpression= 12561 } |> Some
      | 3762 -> { DogmaEffectData.id= 3762; name= "shipBonusCF1TorpedoKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12816; postExpression= 12817 } |> Some
      | 3859 -> { DogmaEffectData.id= 3859; name= "subsystemBonusCaldariPropulsionMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13083; postExpression= 13084 } |> Some
      | 4053 -> { DogmaEffectData.id= 4053; name= "brokensystemShieldThermalResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13564; postExpression= 13565 } |> Some
      | 4150 -> { DogmaEffectData.id= 4150; name= "subsystemBonusGallenteEngineeringWarpScramblerRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13808; postExpression= 13809 } |> Some
      | 4247 -> { DogmaEffectData.id= 4247; name= "modifyShieldResonancePassivePreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14097; postExpression= 14098 } |> Some
      | 4344 -> { DogmaEffectData.id= 4344; name= "subsystemBonusMinmatarDefensiveSignatureRadius"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14306; postExpression= 14307 } |> Some
      | 4635 -> { DogmaEffectData.id= 4635; name= "eliteBonusMaraudersCruiseAndTorpedoDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15131; postExpression= 15132 } |> Some
      | 464 -> { DogmaEffectData.id= 464; name= "shipShieldCapBonusCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2538; postExpression= 2539 } |> Some
      | 4926 -> { DogmaEffectData.id= 4926; name= "nosAttackReflect"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 15879; postExpression= 15880 } |> Some
      | 5120 -> { DogmaEffectData.id= 5120; name= "shipBonusHackingCycleCF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16359; postExpression= 16360 } |> Some
      | 5217 -> { DogmaEffectData.id= 5217; name= "shipSPTTrackingSpeedBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16591; postExpression= 16592 } |> Some
      | 5314 -> { DogmaEffectData.id= 5314; name= "shipBonusDroneHullHitpointsGD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16829; postExpression= 16830 } |> Some
      | 5411 -> { DogmaEffectData.id= 5411; name= "shipMissileVelocityCD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17015; postExpression= 17016 } |> Some
      | 5605 -> { DogmaEffectData.id= 5605; name= "marauderModeEffect24"; description= ""; displayName= ""; effectCategory= 1; preExpression= 17500; postExpression= 17501 } |> Some
      | 5799 -> { DogmaEffectData.id= 5799; name= "shipBonusEwWeaponDisruptionRangeDisruptionBonusAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17949; postExpression= 17950 } |> Some
      | 5896 -> { DogmaEffectData.id= 5896; name= "eliteIndustrialShieldBoosterHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18199; postExpression= 18200 } |> Some
      | 6187 -> { DogmaEffectData.id= 6187; name= "energyNeutralizerFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6284 -> { DogmaEffectData.id= 6284; name= "shipBonusEnergyNeutFalloffAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19098; postExpression= 19099 } |> Some
      | 6381 -> { DogmaEffectData.id= 6381; name= "eliteBonusLogiFrigSignature2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4158; postExpression= 4159 } |> Some
      | 6478 -> { DogmaEffectData.id= 6478; name= "doomsdayAOEPaint"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6575 -> { DogmaEffectData.id= 6575; name= "skillBonusCapitalPulseLaserSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6672 -> { DogmaEffectData.id= 6672; name= "structureCombatRigSecurityModification"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6769 -> { DogmaEffectData.id= 6769; name= "commandBurstAoEBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6866 -> { DogmaEffectData.id= 6866; name= "shipBonusSmallMissileFlightTimeCF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6963 -> { DogmaEffectData.id= 6963; name= "subsystemBonusMinmatarPropulsion2WarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14157; postExpression= 14158 } |> Some
      | 7060 -> { DogmaEffectData.id= 7060; name= "weather_darkness"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7157 -> { DogmaEffectData.id= 7157; name= "shipBonusPD2DisintegratorMaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19685; postExpression= 19686 } |> Some
      | _ -> None