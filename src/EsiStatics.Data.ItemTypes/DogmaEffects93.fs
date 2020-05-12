namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects93=
    let getDogmaEffect id = 
      match id with 
      | 1063 -> { DogmaEffectData.id= 1063; name= "eliteBonusHeavyGunshipProjectileTracking2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1160 -> { DogmaEffectData.id= 1160; name= "controlTowerTrackingArrayHybridTrackingBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1257 -> { DogmaEffectData.id= 1257; name= "blackMarketTradingSkillBoostContrabandDetectionChanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1354 -> { DogmaEffectData.id= 1354; name= "ewTestEffectRsd"; description= ""; displayName= ""; effectCategory= 2; preExpression= 3525; postExpression= 3526 } |> Some
      | 1451 -> { DogmaEffectData.id= 1451; name= "ewSkillTdFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1645 -> { DogmaEffectData.id= 1645; name= "shieldCommandMindlink"; description= "Automatically generated effect"; displayName= "ShieldCommandMindlink"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1839 -> { DogmaEffectData.id= 1839; name= "eliteBargeSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2130 -> { DogmaEffectData.id= 2130; name= "smallHybridMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2712 -> { DogmaEffectData.id= 2712; name= "drawbackArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2809 -> { DogmaEffectData.id= 2809; name= "shipMissileAssaultMissileVelocityBonusCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 287 -> { DogmaEffectData.id= 287; name= "controlledBurstsCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2906 -> { DogmaEffectData.id= 2906; name= "missileThermalDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3100 -> { DogmaEffectData.id= 3100; name= "controlTowerGenericHullThermicResistanceBonusSensorDampener"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10895; postExpression= 10896 } |> Some
      | 3197 -> { DogmaEffectData.id= 3197; name= "overloadSelfArmorDamageAmount"; description= ""; displayName= ""; effectCategory= 5; preExpression= 11178; postExpression= 11179 } |> Some
      | 3682 -> { DogmaEffectData.id= 3682; name= "freighterAgilityBonusG1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3779 -> { DogmaEffectData.id= 3779; name= "powerOutputAdd"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12852; postExpression= 12853 } |> Some
      | 3876 -> { DogmaEffectData.id= 3876; name= "subsystemBonusMinmatarPropulsionABMWDCapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13117; postExpression= 13118 } |> Some
      | 3973 -> { DogmaEffectData.id= 3973; name= "subsystemBonusCaldariDefensiveShieldBoostCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13311; postExpression= 13312 } |> Some
      | 4070 -> { DogmaEffectData.id= 4070; name= "subsystemBonusGallenteDefensiveCargoCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13611; postExpression= 13612 } |> Some
      | 4167 -> { DogmaEffectData.id= 4167; name= "shipBonusScanProbeStrengthGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4264 -> { DogmaEffectData.id= 4264; name= "subsystemBonusMinmatarCoreCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4361 -> { DogmaEffectData.id= 4361; name= "subsystemBonusAmarrOffensiveHeavyAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4458 -> { DogmaEffectData.id= 4458; name= "republicsetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4555 -> { DogmaEffectData.id= 4555; name= "	capitalLauncherSkillCruiseCitadelEmDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4652 -> { DogmaEffectData.id= 4652; name= "shipBonusArmorEMandExpandKinandThermResistance2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15165; postExpression= 15166 } |> Some
      | 481 -> { DogmaEffectData.id= 481; name= "metallurgySkillBoostMineralNeedResearchBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4846 -> { DogmaEffectData.id= 4846; name= "shipProjectileFalloffBonusBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15649; postExpression= 15650 } |> Some
      | 4943 -> { DogmaEffectData.id= 4943; name= "skillTargetBreakerCapNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15935; postExpression= 15936 } |> Some
      | 5137 -> { DogmaEffectData.id= 5137; name= "miningFrigateSkillLevelPostMulShipBonusORE1frig"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5234 -> { DogmaEffectData.id= 5234; name= "shipSmallMissileExpDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5331 -> { DogmaEffectData.id= 5331; name= "shipBonusDroneHitpointsABC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5428 -> { DogmaEffectData.id= 5428; name= "shipBonusDroneOptimalRangeGB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5622 -> { DogmaEffectData.id= 5622; name= "shipBonusTorpedoROFMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5816 -> { DogmaEffectData.id= 5816; name= "shipBonusLightDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5913 -> { DogmaEffectData.id= 5913; name= "systemArmorHP"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6010 -> { DogmaEffectData.id= 6010; name= "shipModeMaxTargetRangePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6301 -> { DogmaEffectData.id= 6301; name= "shipBonusNosOptimalFalloffAC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6398 -> { DogmaEffectData.id= 6398; name= "skillStructureOffensiveSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6495 -> { DogmaEffectData.id= 6495; name= "skillMultiplierShipBonusDreadnoughtGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6592 -> { DogmaEffectData.id= 6592; name= "shipBonusSupercarrierC3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6689 -> { DogmaEffectData.id= 6689; name= "npcEntityRemoteHullRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 675 -> { DogmaEffectData.id= 675; name= "weaponUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringEnergyPulseWeapons"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6786 -> { DogmaEffectData.id= 6786; name= "shieldCommandBurstBonusICS3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6883 -> { DogmaEffectData.id= 6883; name= "shipBonusForceAuxiliaryM2LocalRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6980 -> { DogmaEffectData.id= 6980; name= "rigMoonAsteroidDecayBonus"; description= "Moon asteroid decay Bonus"; displayName= "Moon asteroid decay Bonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7077 -> { DogmaEffectData.id= 7077; name= "disintegratorWeaponDamageMultiply"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 7174 -> { DogmaEffectData.id= 7174; name= "shipBonusMutadaptiveRemoteRepPowerRequirementBonusRole2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19731; postExpression= 19732 } |> Some
      | 93 -> { DogmaEffectData.id= 93; name= "hybridWeaponDamageMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None