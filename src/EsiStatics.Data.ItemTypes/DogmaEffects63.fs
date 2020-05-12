namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects63=
    let getDogmaEffect id = 
      match id with 
      | 1033 -> { DogmaEffectData.id= 1033; name= "eliteBonusLogisticRemoteArmorRepairCapNeed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1130 -> { DogmaEffectData.id= 1130; name= "controlTowerAmarrLaserOptimalBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 160 -> { DogmaEffectData.id= 160; name= "mediumHybridTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringMediumHybridTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1615 -> { DogmaEffectData.id= 1615; name= "shipAdvancedSpaceshipCommandAgilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2003 -> { DogmaEffectData.id= 2003; name= "droneDamageMultiplierBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 7602; postExpression= 7603 } |> Some
      | 2197 -> { DogmaEffectData.id= 2197; name= "entityArmorRepairingLarge"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2488 -> { DogmaEffectData.id= 2488; name= "implantVelocityBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2682 -> { DogmaEffectData.id= 2682; name= "shipCruiserSizedLauncherROFBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9664; postExpression= 9665 } |> Some
      | 2779 -> { DogmaEffectData.id= 2779; name= "shipLaserCapABC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9939; postExpression= 9940 } |> Some
      | 2876 -> { DogmaEffectData.id= 2876; name= "missileThermalDmgBonusCruise"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10181; postExpression= 10182 } |> Some
      | 3070 -> { DogmaEffectData.id= 3070; name= "controlTowerGenericHullExplosiveResistanceBonusCynoJammer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10769; postExpression= 10770 } |> Some
      | 3264 -> { DogmaEffectData.id= 3264; name= "skillIndustrialReconfigurationConsumptionQuantityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3361 -> { DogmaEffectData.id= 3361; name= "amarrShipEwWeaponDisruptionTrackingAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11625; postExpression= 11626 } |> Some
      | 3458 -> { DogmaEffectData.id= 3458; name= "warpDisruptionFieldAfterburnerOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11912; postExpression= 11913 } |> Some
      | 354 -> { DogmaEffectData.id= 354; name= "ethnicRelationsNonRaceCorporationMembersBonusPostPercentMaxNonRaceCorporationMembersChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2085; postExpression= 2086 } |> Some
      | 3555 -> { DogmaEffectData.id= 3555; name= "targetGunneryMaxRangeAndTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12234; postExpression= 12235 } |> Some
      | 3652 -> { DogmaEffectData.id= 3652; name= "ewGroupTdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3846 -> { DogmaEffectData.id= 3846; name= "subsystemSkillLevelCaldariOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4040 -> { DogmaEffectData.id= 4040; name= "systemOverloadRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4137 -> { DogmaEffectData.id= 4137; name= "systemShieldKineticResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4234 -> { DogmaEffectData.id= 4234; name= "modifyArmorResonanceEmPreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14064; postExpression= 14065 } |> Some
      | 4331 -> { DogmaEffectData.id= 4331; name= "subsystemBonusCaldariOffensive3HMLHAMVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4622 -> { DogmaEffectData.id= 4622; name= "shipBonusSmallHybridMaxRangeATF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4913 -> { DogmaEffectData.id= 4913; name= "missileDamageMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5107 -> { DogmaEffectData.id= 5107; name= "shipBonusRemoteArmorRepairCapNeedGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5204 -> { DogmaEffectData.id= 5204; name= "shipHMHAMRofMBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16551; postExpression= 16552 } |> Some
      | 5301 -> { DogmaEffectData.id= 5301; name= "shipBonusEnergyVampireRangeAD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16803; postExpression= 16804 } |> Some
      | 5398 -> { DogmaEffectData.id= 5398; name= "systemScanDurationModuleModifier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 548 -> { DogmaEffectData.id= 548; name= "minmatarBattleshipSkillLevelPreMulShipBonusMBShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5592 -> { DogmaEffectData.id= 5592; name= "shipMWDBlockActivation"; description= ""; displayName= ""; effectCategory= 1; preExpression= 17478; postExpression= 17479 } |> Some
      | 6077 -> { DogmaEffectData.id= 6077; name= "shipHeatDamageCaldariTacticalDestroyer3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6174 -> { DogmaEffectData.id= 6174; name= "battlecruiserMPTRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6271 -> { DogmaEffectData.id= 6271; name= "shipBonusEnergyNeutFalloffEAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19070; postExpression= 19071 } |> Some
      | 63 -> { DogmaEffectData.id= 63; name= "armorHPMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6368 -> { DogmaEffectData.id= 6368; name= "shieldTransporterFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6465 -> { DogmaEffectData.id= 6465; name= "fighterAbilityAttackM"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6562 -> { DogmaEffectData.id= 6562; name= "skillBonusSupportFightersShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6756 -> { DogmaEffectData.id= 6756; name= "npcBehaviorEnergyNeutralizer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6853 -> { DogmaEffectData.id= 6853; name= "shipBonusTitanA1EnergyWarfareAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6950 -> { DogmaEffectData.id= 6950; name= "subSystemBonusGallenteDefensive3TractorBeamBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14452; postExpression= 14453 } |> Some
      | 7047 -> { DogmaEffectData.id= 7047; name= "roleBonusFlagCruiserModuleFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7241 -> { DogmaEffectData.id= 7241; name= "skillMultiplierShipBonusDreadnoughtPrecursor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8017 -> { DogmaEffectData.id= 8017; name= "saviorSetBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None