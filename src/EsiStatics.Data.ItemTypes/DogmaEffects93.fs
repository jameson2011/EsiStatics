namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects93=
    let getDogmaEffect id = 
      match id with 
      | 1063 -> { DogmaEffectData.id= 1063; name= "eliteBonusHeavyGunshipProjectileTracking2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4676; postExpression= 4677 } |> Some
      | 1160 -> { DogmaEffectData.id= 1160; name= "controlTowerTrackingArrayHybridTrackingBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5038; postExpression= 5039 } |> Some
      | 1257 -> { DogmaEffectData.id= 1257; name= "blackMarketTradingSkillBoostContrabandDetectionChanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5352; postExpression= 5353 } |> Some
      | 1451 -> { DogmaEffectData.id= 1451; name= "ewSkillTdFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5941; postExpression= 5942 } |> Some
      | 1645 -> { DogmaEffectData.id= 1645; name= "shieldCommandMindlink"; description= "Automatically generated effect"; displayName= "ShieldCommandMindlink"; effectCategory= 0; preExpression= 6529; postExpression= 6530 } |> Some
      | 1839 -> { DogmaEffectData.id= 1839; name= "eliteBargeSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7098; postExpression= 7099 } |> Some
      | 2130 -> { DogmaEffectData.id= 2130; name= "smallHybridMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8003; postExpression= 8004 } |> Some
      | 2712 -> { DogmaEffectData.id= 2712; name= "drawbackArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9748; postExpression= 9749 } |> Some
      | 2809 -> { DogmaEffectData.id= 2809; name= "shipMissileAssaultMissileVelocityBonusCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9976; postExpression= 9977 } |> Some
      | 287 -> { DogmaEffectData.id= 287; name= "controlledBurstsCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1774; postExpression= 1775 } |> Some
      | 2906 -> { DogmaEffectData.id= 2906; name= "missileThermalDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10275; postExpression= 10276 } |> Some
      | 3682 -> { DogmaEffectData.id= 3682; name= "freighterAgilityBonusG1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12595; postExpression= 12596 } |> Some
      | 4167 -> { DogmaEffectData.id= 4167; name= "shipBonusScanProbeStrengthGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13851; postExpression= 13852 } |> Some
      | 4264 -> { DogmaEffectData.id= 4264; name= "subsystemBonusMinmatarCoreCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14129; postExpression= 14130 } |> Some
      | 4361 -> { DogmaEffectData.id= 4361; name= "subsystemBonusAmarrOffensiveHeavyAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14349; postExpression= 14350 } |> Some
      | 4458 -> { DogmaEffectData.id= 4458; name= "republicsetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14620; postExpression= 14621 } |> Some
      | 4555 -> { DogmaEffectData.id= 4555; name= "	capitalLauncherSkillCruiseCitadelEmDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14954; postExpression= 14955 } |> Some
      | 481 -> { DogmaEffectData.id= 481; name= "metallurgySkillBoostMineralNeedResearchBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2588; postExpression= 2589 } |> Some
      | 5137 -> { DogmaEffectData.id= 5137; name= "miningFrigateSkillLevelPostMulShipBonusORE1frig"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16391; postExpression= 16392 } |> Some
      | 5234 -> { DogmaEffectData.id= 5234; name= "shipSmallMissileExpDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16623; postExpression= 16624 } |> Some
      | 5331 -> { DogmaEffectData.id= 5331; name= "shipBonusDroneHitpointsABC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16863; postExpression= 16864 } |> Some
      | 5428 -> { DogmaEffectData.id= 5428; name= "shipBonusDroneOptimalRangeGB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17049; postExpression= 17050 } |> Some
      | 5622 -> { DogmaEffectData.id= 5622; name= "shipBonusTorpedoROFMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 9083; postExpression= 9084 } |> Some
      | 5816 -> { DogmaEffectData.id= 5816; name= "shipBonusLightDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17997; postExpression= 17998 } |> Some
      | 5913 -> { DogmaEffectData.id= 5913; name= "systemArmorHP"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 509; postExpression= 510 } |> Some
      | 6010 -> { DogmaEffectData.id= 6010; name= "shipModeMaxTargetRangePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2692; postExpression= 2693 } |> Some
      | 6301 -> { DogmaEffectData.id= 6301; name= "shipBonusNosOptimalFalloffAC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19136; postExpression= 19137 } |> Some
      | 6495 -> { DogmaEffectData.id= 6495; name= "skillMultiplierShipBonusDreadnoughtGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6592 -> { DogmaEffectData.id= 6592; name= "shipBonusSupercarrierC3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6689 -> { DogmaEffectData.id= 6689; name= "npcEntityRemoteHullRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 675 -> { DogmaEffectData.id= 675; name= "weaponUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringEnergyPulseWeapons"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3359; postExpression= 3360 } |> Some
      | 6786 -> { DogmaEffectData.id= 6786; name= "shieldCommandBurstBonusICS3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6883 -> { DogmaEffectData.id= 6883; name= "shipBonusForceAuxiliaryM2LocalRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6980 -> { DogmaEffectData.id= 6980; name= "rigMoonAsteroidDecayBonus"; description= "Moon asteroid decay Bonus"; displayName= "Moon asteroid decay Bonus"; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7077 -> { DogmaEffectData.id= 7077; name= "disintegratorWeaponDamageMultiply"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 19485; postExpression= 19486 } |> Some
      | 93 -> { DogmaEffectData.id= 93; name= "hybridWeaponDamageMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 669; postExpression= 672 } |> Some
      | _ -> None