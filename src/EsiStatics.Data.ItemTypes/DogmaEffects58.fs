namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects58=
    let getDogmaEffect id = 
      match id with 
      | 1125 -> { DogmaEffectData.id= 1125; name= "shipLaserCapABC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4900; postExpression= 4901 } |> Some
      | 1222 -> { DogmaEffectData.id= 1222; name= "shipStasisWebRangeBonusMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5265; postExpression= 5266 } |> Some
      | 1804 -> { DogmaEffectData.id= 1804; name= "shipArmorEMResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6978; postExpression= 6979 } |> Some
      | 2192 -> { DogmaEffectData.id= 2192; name= "entityShieldBoostingSmall"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4037; postExpression= 131 } |> Some
      | 2580 -> { DogmaEffectData.id= 2580; name= "neurotoxinRecoverySkillBoostChanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9373; postExpression= 9374 } |> Some
      | 2871 -> { DogmaEffectData.id= 2871; name= "defenderMissileVelocityBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2215; postExpression= 2216 } |> Some
      | 3065 -> { DogmaEffectData.id= 3065; name= "controlTowerGenericHullExplosiveResistanceBonusCynoGenerator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10747; postExpression= 10748 } |> Some
      | 3356 -> { DogmaEffectData.id= 3356; name= "eliteBonusHeavyInterdictorHeavyAssaultMissileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11608; postExpression= 11609 } |> Some
      | 3453 -> { DogmaEffectData.id= 3453; name= "shipBonusAoeVelocityTorpedoCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11893; postExpression= 11894 } |> Some
      | 349 -> { DogmaEffectData.id= 349; name= "diplomacyDiplomacyMutatorModAddDiplomacyBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2062; postExpression= 2063 } |> Some
      | 3550 -> { DogmaEffectData.id= 3550; name= "targetEnergyWeaponAndHybridWeaponMaxRangeAndTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12221; postExpression= 12222 } |> Some
      | 3744 -> { DogmaEffectData.id= 3744; name= "miningForemanBurstBonusICS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12754; postExpression= 12755 } |> Some
      | 3841 -> { DogmaEffectData.id= 3841; name= "subsystemSkillLevelCaldariEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13017; postExpression= 13018 } |> Some
      | 4035 -> { DogmaEffectData.id= 4035; name= "systemOverloadDamageModifier"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13492; postExpression= 13493 } |> Some
      | 4132 -> { DogmaEffectData.id= 4132; name= "subsystemBonusGallenteDefensiveDroneHPArmor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13772; postExpression= 13773 } |> Some
      | 4326 -> { DogmaEffectData.id= 4326; name= "subsystemBonusAmarrOffensive3DroneHPShieldAndArmor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14262; postExpression= 14263 } |> Some
      | 4423 -> { DogmaEffectData.id= 4423; name= "missileDMGBonus2"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14505; postExpression= 14506 } |> Some
      | 446 -> { DogmaEffectData.id= 446; name= "shieldManagementShieldCapacityBonusPostPercentCapacityLocationShipGroupShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2472; postExpression= 2473 } |> Some
      | 4520 -> { DogmaEffectData.id= 4520; name= "fighterBomberTorpedoThermalDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14804; postExpression= 14805 } |> Some
      | 4617 -> { DogmaEffectData.id= 4617; name= "shipBonusWarpDisruptorRangeMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15097; postExpression= 15098 } |> Some
      | 4811 -> { DogmaEffectData.id= 4811; name= "ecmMagnetometricStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15502; postExpression= 15503 } |> Some
      | 4908 -> { DogmaEffectData.id= 4908; name= "modifyShieldArmorHullResonancePostPercent"; description= ""; displayName= ""; effectCategory= 1; preExpression= 15821; postExpression= 15822 } |> Some
      | 5296 -> { DogmaEffectData.id= 5296; name= "shipBonusDroneArmorHitpointsAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16793; postExpression= 16794 } |> Some
      | 5393 -> { DogmaEffectData.id= 5393; name= "shipMissileExpDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16978; postExpression= 16979 } |> Some
      | 5587 -> { DogmaEffectData.id= 5587; name= "marauderModeEffect10"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17464; postExpression= 17465 } |> Some
      | 5781 -> { DogmaEffectData.id= 5781; name= "droneDmgBonusRequiringMediumDroneOperation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17903; postExpression= 17904 } |> Some
      | 58 -> { DogmaEffectData.id= 58; name= "capacitorCapacityMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 483; postExpression= 484 } |> Some
      | 6072 -> { DogmaEffectData.id= 6072; name= "shipBonusHeavyAssaultMissileThermDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18643; postExpression= 18644 } |> Some
      | 6557 -> { DogmaEffectData.id= 6557; name= "moduleBonusOmnidirectionalTrackingLink"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6654 -> { DogmaEffectData.id= 6654; name= "shipBonusTitanG2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6848 -> { DogmaEffectData.id= 6848; name= "shipModuleFocusedWarpScramblingScript"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6945 -> { DogmaEffectData.id= 6945; name= "subsystemBonusCaldariDefensive3ShieldBoostHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7042 -> { DogmaEffectData.id= 7042; name= "shipArmorHitPointsAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19409; postExpression= 19410 } |> Some
      | 7139 -> { DogmaEffectData.id= 7139; name= "selfSpeedBoostFactorBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 19617; postExpression= 19619 } |> Some
      | 834 -> { DogmaEffectData.id= 834; name= "ammoInfluenceCapRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 443; postExpression= 444 } |> Some
      | _ -> None