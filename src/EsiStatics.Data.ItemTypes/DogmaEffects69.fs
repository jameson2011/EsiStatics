namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects69=
    let getDogmaEffect id = 
      match id with 
      | 1233 -> { DogmaEffectData.id= 1233; name= "shipHybridDmgPirateCruiser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5285; postExpression= 5286 } |> Some
      | 1330 -> { DogmaEffectData.id= 1330; name= "propulsionSkillPropulsionStrengthBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5565; postExpression= 5566 } |> Some
      | 1815 -> { DogmaEffectData.id= 1815; name= "shipShieldExplosiveResistanceCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7000; postExpression= 7001 } |> Some
      | 1912 -> { DogmaEffectData.id= 1912; name= "eliteReconBonusMagnetometricStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7339; postExpression= 7340 } |> Some
      | 2106 -> { DogmaEffectData.id= 2106; name= "explosiveArmorCompensationHardeningBonusGroupArmorCoating"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7928; postExpression= 7929 } |> Some
      | 263 -> { DogmaEffectData.id= 263; name= "barrage"; description= "Barrage Attack, Attack with barrageDmgMultiplier as a damage multiplier"; displayName= "Barrage Attack"; effectCategory= 2; preExpression= 1659; postExpression= 1104 } |> Some
      | 2688 -> { DogmaEffectData.id= 2688; name= "capNeedBonusEffectLasers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9675; postExpression= 9676 } |> Some
      | 2882 -> { DogmaEffectData.id= 2882; name= "missileExplosiveDmgBonusCruise3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10193; postExpression= 10194 } |> Some
      | 2979 -> { DogmaEffectData.id= 2979; name= "	skillRemoteHullRepairSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10508; postExpression= 10509 } |> Some
      | 3173 -> { DogmaEffectData.id= 3173; name= "droneShieldBonusBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11084; postExpression= 11085 } |> Some
      | 3367 -> { DogmaEffectData.id= 3367; name= "eliteBonusElectronicAttackShipWarpScramblerMaxRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11637; postExpression= 11638 } |> Some
      | 3561 -> { DogmaEffectData.id= 3561; name= "ewSkillTrackingDisruptionTrackingSpeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12250; postExpression= 12251 } |> Some
      | 3755 -> { DogmaEffectData.id= 3755; name= "zColinSkillTransportCovertCloakMod"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12798; postExpression= 12799 } |> Some
      | 3852 -> { DogmaEffectData.id= 3852; name= "NPCRemoteArmorRepair"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 89 } |> Some
      | 3949 -> { DogmaEffectData.id= 3949; name= "subsystemBonusMinmatarDefensiveShieldResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13263; postExpression= 13264 } |> Some
      | 4046 -> { DogmaEffectData.id= 4046; name= "systemSmartBombEmDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13540; postExpression= 13541 } |> Some
      | 4240 -> { DogmaEffectData.id= 4240; name= "modifyArmorResonancePassivePreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14079; postExpression= 14080 } |> Some
      | 4337 -> { DogmaEffectData.id= 4337; name= "subsystemBonusCaldariOffensive3EwStrengthRadar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14286; postExpression= 14287 } |> Some
      | 4822 -> { DogmaEffectData.id= 4822; name= "bcLargeProjectileTurretPowerNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15567; postExpression= 15568 } |> Some
      | 5016 -> { DogmaEffectData.id= 5016; name= "shipBonusEwRemoteSensorDampenerScanResolutionBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16119; postExpression= 16120 } |> Some
      | 5307 -> { DogmaEffectData.id= 5307; name= "shipBonusAoeVelocityRocketsCD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16815; postExpression= 16816 } |> Some
      | 5501 -> { DogmaEffectData.id= 5501; name= "eliteBonusCommandShipMediumHybridDamageCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17261; postExpression= 17262 } |> Some
      | 5695 -> { DogmaEffectData.id= 5695; name= "eliteBonusInterdictorsArmorResist1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17691; postExpression= 17692 } |> Some
      | 5889 -> { DogmaEffectData.id= 5889; name= "eliteIndustrialABHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18173; postExpression= 18174 } |> Some
      | 5986 -> { DogmaEffectData.id= 5986; name= "resistanceKillerArmorAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18446; postExpression= 18447 } |> Some
      | 6083 -> { DogmaEffectData.id= 6083; name= "shipSmallMissileDmgPirateFaction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17675; postExpression= 17676 } |> Some
      | 6374 -> { DogmaEffectData.id= 6374; name= "droneHullRepairBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11082; postExpression= 11083 } |> Some
      | 651 -> { DogmaEffectData.id= 651; name= "cloakingSkillBoostCloakVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3262; postExpression= 3263 } |> Some
      | 6568 -> { DogmaEffectData.id= 6568; name= "citadelServiceFuelBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6665 -> { DogmaEffectData.id= 6665; name= "skillBonusDroneDurability"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6762 -> { DogmaEffectData.id= 6762; name= "miningDroneSpecBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3153; postExpression= 3154 } |> Some
      | 6859 -> { DogmaEffectData.id= 6859; name= "shipBonusRole4NosferatuCPUBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6956 -> { DogmaEffectData.id= 6956; name= "subsystemRemoteArmorRepairerOptimalBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8021; postExpression= 8022 } |> Some
      | 7053 -> { DogmaEffectData.id= 7053; name= "aoe_beacon_pulse_01"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7150 -> { DogmaEffectData.id= 7150; name= "precursorDestroyerSkillLevelPreMulShipBonusPD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19662; postExpression= 19663 } |> Some
      | _ -> None