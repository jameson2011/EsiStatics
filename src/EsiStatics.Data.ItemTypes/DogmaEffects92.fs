namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects92=
    let getDogmaEffect id = 
      match id with 
      | 1062 -> { DogmaEffectData.id= 1062; name= "eliteBonusHeavyGunshipLaserDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1159 -> { DogmaEffectData.id= 1159; name= "controlTowerTrackingArrayProjectileTrackingBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1256 -> { DogmaEffectData.id= 1256; name= "setBonusBloodraiderNosferatu"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1450 -> { DogmaEffectData.id= 1450; name= "ewSkillTpFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1644 -> { DogmaEffectData.id= 1644; name= "skirmishCommandMindlink"; description= "Automatically generated effect"; displayName= "SkirmishCommandMindlink"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1838 -> { DogmaEffectData.id= 1838; name= "eliteBargeSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 189 -> { DogmaEffectData.id= 189; name= "caldariFrigateSkillBoostCfTRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2129 -> { DogmaEffectData.id= 2129; name= "passiveThermicShieldResonanceBonusGroupArmorHardener2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8001; postExpression= 8002 } |> Some
      | 2808 -> { DogmaEffectData.id= 2808; name= "maxRangeBonusEffectProjectilesMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9974; postExpression= 9975 } |> Some
      | 2905 -> { DogmaEffectData.id= 2905; name= "missileKineticDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3002 -> { DogmaEffectData.id= 3002; name= "overloadSelfDurationBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3099 -> { DogmaEffectData.id= 3099; name= "controlTowerGenericHullThermicResistanceBonusProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10889; postExpression= 10890 } |> Some
      | 3196 -> { DogmaEffectData.id= 3196; name= "thermodynamicsSkillDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3487 -> { DogmaEffectData.id= 3487; name= "shipBonusSmallEnergyTurretDamagePirateFaction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3584 -> { DogmaEffectData.id= 3584; name= "targetMaxTargetRangeAndScanResolutionBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12285; postExpression= 12286 } |> Some
      | 3681 -> { DogmaEffectData.id= 3681; name= "freighterAgilityBonusM1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3778 -> { DogmaEffectData.id= 3778; name= "cpuOutputAdd"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12849; postExpression= 12850 } |> Some
      | 3875 -> { DogmaEffectData.id= 3875; name= "subsystemBonusGallentePropulsionABMWDCapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3972 -> { DogmaEffectData.id= 3972; name= "subsystemBonusGallenteDefensiveShieldBoostCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13309; postExpression= 13310 } |> Some
      | 4069 -> { DogmaEffectData.id= 4069; name= "subsystemBonusMinmatarDefensiveCargoCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13609; postExpression= 13610 } |> Some
      | 4166 -> { DogmaEffectData.id= 4166; name= "shipBonusScanProbeStrengthMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4263 -> { DogmaEffectData.id= 4263; name= "subsystemBonusMinmatarEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4360 -> { DogmaEffectData.id= 4360; name= "subsystemBonusAmarrOffensiveMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4457 -> { DogmaEffectData.id= 4457; name= "imperialsetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4651 -> { DogmaEffectData.id= 4651; name= "shipBonusArmorEMandExpandKinResistance2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15163; postExpression= 15164 } |> Some
      | 480 -> { DogmaEffectData.id= 480; name= "shipCargoBonusAF"; description= "Automatically generated effect"; displayName= "shipCargoBonus"; effectCategory= 0; preExpression= 2583; postExpression= 2584 } |> Some
      | 4845 -> { DogmaEffectData.id= 4845; name= "shipProjectileRofBonusBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15647; postExpression= 15648 } |> Some
      | 4942 -> { DogmaEffectData.id= 4942; name= "targetBreaker"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5136 -> { DogmaEffectData.id= 5136; name= "shipMETCDamageBonusAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5330 -> { DogmaEffectData.id= 5330; name= "shipBonusDroneHitpoints1ABC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16861; postExpression= 16862 } |> Some
      | 5427 -> { DogmaEffectData.id= 5427; name= "shipBonusDroneTrackingGB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5621 -> { DogmaEffectData.id= 5621; name= "shipBonusCruiseROFMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5815 -> { DogmaEffectData.id= 5815; name= "shipBonusThermalMissileDamageGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5912 -> { DogmaEffectData.id= 5912; name= "systemRemoteCapTransmitterAmount"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6009 -> { DogmaEffectData.id= 6009; name= "probeLauncherCPUPercentRoleBonusT3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6203 -> { DogmaEffectData.id= 6203; name= "armorWarfareArmorHpReplacer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6300 -> { DogmaEffectData.id= 6300; name= "shipBonusEnergyNosOptimalAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6397 -> { DogmaEffectData.id= 6397; name= "skillStructureOffensiveSystemsDoomsdayDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6591 -> { DogmaEffectData.id= 6591; name= "shipBonusSupercarrierA3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6688 -> { DogmaEffectData.id= 6688; name= "npcEntityRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6785 -> { DogmaEffectData.id= 6785; name= "industrialCommandShipSkillLevelMultiplierICS5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6882 -> { DogmaEffectData.id= 6882; name= "npcBehaviorEnergyNosferatu"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6979 -> { DogmaEffectData.id= 6979; name= "rigMoonFractureDelay"; description= "Delay to fracture moon chunk"; displayName= "Asteroid extraction delay Bonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7076 -> { DogmaEffectData.id= 7076; name= "largeDisintegratorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7173 -> { DogmaEffectData.id= 7173; name= "shipBonusMutadaptiveRemoteRepAmounteliteBonusLogisitics2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 92 -> { DogmaEffectData.id= 92; name= "projectileWeaponDamageMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None