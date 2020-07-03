namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects73=
    let getDogmaEffect id = 
      match id with 
      | 1140 -> { DogmaEffectData.id= 1140; name= "destroyerSkillLevelPreMulShipBonusDF1Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1722 -> { DogmaEffectData.id= 1722; name= "jumpDriveSkillsCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1819 -> { DogmaEffectData.id= 1819; name= "shipShieldKineticResistanceCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2013 -> { DogmaEffectData.id= 2013; name= "droneMaxVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2110 -> { DogmaEffectData.id= 2110; name= "explosiveArmorCompensationHardeningBonusGroupEnergized"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 267 -> { DogmaEffectData.id= 267; name= "amarrCruiserSkillBoostPowerOutputBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2692 -> { DogmaEffectData.id= 2692; name= "cpuNeedBonusEffectProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2886 -> { DogmaEffectData.id= 2886; name= "setMaxLockedTargets"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3371 -> { DogmaEffectData.id= 3371; name= "eliteBonusElectronicAttackShipWarpScramblerCapNeed2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3468 -> { DogmaEffectData.id= 3468; name= "eliteBonusHeavyInterdictorsWarpDisruptFieldGeneratorWarpScrambleRange2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3856 -> { DogmaEffectData.id= 3856; name= "shieldRechargeRateAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4341 -> { DogmaEffectData.id= 4341; name= "subsystemSkillLevelGallenteOffensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4826 -> { DogmaEffectData.id= 4826; name= "bcLargeEnergyTurretCapacitorNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4923 -> { DogmaEffectData.id= 4923; name= "skillMJDdurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5020 -> { DogmaEffectData.id= 5020; name= "shipSPTDmgBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5214 -> { DogmaEffectData.id= 5214; name= "shipLightMissileMaxVelocityBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5311 -> { DogmaEffectData.id= 5311; name= "shipBonusDroneDamageMultiplierGD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5505 -> { DogmaEffectData.id= 5505; name= "eliteBonusCommandShipMediumHybridRoFCS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 558 -> { DogmaEffectData.id= 558; name= "metallurgyMineralNeedResearchBonusPostPercentMineralNeedResearchSpeedChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5893 -> { DogmaEffectData.id= 5893; name= "eliteIndustrialShieldHardenerHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6184 -> { DogmaEffectData.id= 6184; name= "shipModuleRemoteCapacitorTransmitter"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6281 -> { DogmaEffectData.id= 6281; name= "shipBonusEnergyNeutOptimalAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6378 -> { DogmaEffectData.id= 6378; name= "eliteBonusLogiFrigShieldRepSpeedCap1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6475 -> { DogmaEffectData.id= 6475; name= "structureRigDoomsdayTargetAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6572 -> { DogmaEffectData.id= 6572; name= "skillBonusCapitalArtillerySpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6669 -> { DogmaEffectData.id= 6669; name= "moduleBonusCapitalDroneDurabilityEnhancer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6766 -> { DogmaEffectData.id= 6766; name= "commandProcessorEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6960 -> { DogmaEffectData.id= 6960; name= "subsystemBonusCaldariOffensive3RemoteShieldBoosterHeat"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7057 -> { DogmaEffectData.id= 7057; name= "aoe_beacon_point_defense"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7154 -> { DogmaEffectData.id= 7154; name= "shipBonusPD1DisintegratorDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 73 -> { DogmaEffectData.id= 73; name= "repairCostMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None