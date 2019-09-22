﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects73=
    let getDogmaEffect id = 
      match id with 
      | 1140 -> { DogmaEffectData.id= 1140; name= "destroyerSkillLevelPreMulShipBonusDF1Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4977; postExpression= 4978 } |> Some
      | 1722 -> { DogmaEffectData.id= 1722; name= "jumpDriveSkillsCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6726; postExpression= 6727 } |> Some
      | 1819 -> { DogmaEffectData.id= 1819; name= "shipShieldKineticResistanceCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7008; postExpression= 7009 } |> Some
      | 2013 -> { DogmaEffectData.id= 2013; name= "droneMaxVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7638; postExpression= 7639 } |> Some
      | 2110 -> { DogmaEffectData.id= 2110; name= "explosiveArmorCompensationHardeningBonusGroupEnergized"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7946; postExpression= 7947 } |> Some
      | 267 -> { DogmaEffectData.id= 267; name= "amarrCruiserSkillBoostPowerOutputBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1676; postExpression= 1677 } |> Some
      | 2692 -> { DogmaEffectData.id= 2692; name= "cpuNeedBonusEffectProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9691; postExpression= 9692 } |> Some
      | 2886 -> { DogmaEffectData.id= 2886; name= "setMaxLockedTargets"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9127; postExpression= 9128 } |> Some
      | 3371 -> { DogmaEffectData.id= 3371; name= "eliteBonusElectronicAttackShipWarpScramblerCapNeed2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11647; postExpression= 11648 } |> Some
      | 3468 -> { DogmaEffectData.id= 3468; name= "eliteBonusHeavyInterdictorsWarpDisruptFieldGeneratorWarpScrambleRange2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11942; postExpression= 11943 } |> Some
      | 3856 -> { DogmaEffectData.id= 3856; name= "shieldRechargeRateAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13077; postExpression= 13078 } |> Some
      | 4341 -> { DogmaEffectData.id= 4341; name= "subsystemSkillLevelGallenteOffensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14300; postExpression= 14301 } |> Some
      | 4826 -> { DogmaEffectData.id= 4826; name= "bcLargeEnergyTurretCapacitorNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15584; postExpression= 15585 } |> Some
      | 4923 -> { DogmaEffectData.id= 4923; name= "skillMJDdurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15862; postExpression= 15863 } |> Some
      | 5020 -> { DogmaEffectData.id= 5020; name= "shipSPTDmgBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16131; postExpression= 16132 } |> Some
      | 5214 -> { DogmaEffectData.id= 5214; name= "shipLightMissileMaxVelocityBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16582; postExpression= 16583 } |> Some
      | 5311 -> { DogmaEffectData.id= 5311; name= "shipBonusDroneDamageMultiplierGD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16823; postExpression= 16824 } |> Some
      | 5505 -> { DogmaEffectData.id= 5505; name= "eliteBonusCommandShipMediumHybridRoFCS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17269; postExpression= 17270 } |> Some
      | 558 -> { DogmaEffectData.id= 558; name= "metallurgyMineralNeedResearchBonusPostPercentMineralNeedResearchSpeedChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2924; postExpression= 2925 } |> Some
      | 5893 -> { DogmaEffectData.id= 5893; name= "eliteIndustrialShieldHardenerHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18189; postExpression= 18190 } |> Some
      | 6184 -> { DogmaEffectData.id= 6184; name= "shipModuleRemoteCapacitorTransmitter"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6281 -> { DogmaEffectData.id= 6281; name= "shipBonusEnergyNeutOptimalAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19092; postExpression= 19093 } |> Some
      | 6378 -> { DogmaEffectData.id= 6378; name= "eliteBonusLogiFrigShieldRepSpeedCap1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16333; postExpression= 16334 } |> Some
      | 6475 -> { DogmaEffectData.id= 6475; name= "structureRigDoomsdayTargetAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6572 -> { DogmaEffectData.id= 6572; name= "skillBonusCapitalArtillerySpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6669 -> { DogmaEffectData.id= 6669; name= "moduleBonusCapitalDroneDurabilityEnhancer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6766 -> { DogmaEffectData.id= 6766; name= "commandProcessorEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6083; postExpression= 6084 } |> Some
      | 6960 -> { DogmaEffectData.id= 6960; name= "subsystemBonusCaldariOffensive3RemoteShieldBoosterHeat"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14188; postExpression= 14189 } |> Some
      | 7057 -> { DogmaEffectData.id= 7057; name= "aoe_beacon_point_defense"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7154 -> { DogmaEffectData.id= 7154; name= "shipBonusPD1DisintegratorDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19679; postExpression= 19680 } |> Some
      | 73 -> { DogmaEffectData.id= 73; name= "repairCostMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 578; postExpression= 579 } |> Some
      | _ -> None