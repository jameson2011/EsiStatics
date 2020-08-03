namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects71=
    let getDogmaEffect id = 
      match id with 
      | 1720 -> { DogmaEffectData.id= 1720; name= "shieldBoostAmplifier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1817 -> { DogmaEffectData.id= 1817; name= "shipShieldThermalResistanceCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1914 -> { DogmaEffectData.id= 1914; name= "eliteReconBonusLadarStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2108 -> { DogmaEffectData.id= 2108; name= "thermicArmorCompensationHardeningBonusGroupArmorCoating"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2302 -> { DogmaEffectData.id= 2302; name= "damageControl"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2690 -> { DogmaEffectData.id= 2690; name= "cpuNeedBonusEffectLasers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2884 -> { DogmaEffectData.id= 2884; name= "missileThermalDmgBonusCruise3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3175 -> { DogmaEffectData.id= 3175; name= "overloadSelfSpeedBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3369 -> { DogmaEffectData.id= 3369; name= "eliteBonusElectronicAttackShipECMOptimalRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3466 -> { DogmaEffectData.id= 3466; name= "eliteBonusElectronicAttackShipRechargeRate2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3660 -> { DogmaEffectData.id= 3660; name= "shipMaxLockedTargetsBonusAddOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 4048 -> { DogmaEffectData.id= 4048; name= "systemSmartBombKineticDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4339 -> { DogmaEffectData.id= 4339; name= "subsystemSkillLevelCaldariOffensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4824 -> { DogmaEffectData.id= 4824; name= "bcLargeHybridTurretCPUNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4921 -> { DogmaEffectData.id= 4921; name= "microJumpDrive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5018 -> { DogmaEffectData.id= 5018; name= "shipVelocityBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5212 -> { DogmaEffectData.id= 5212; name= "shipDroneMWDSpeedBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5309 -> { DogmaEffectData.id= 5309; name= "shipHybridFallOff1GD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5503 -> { DogmaEffectData.id= 5503; name= "eliteBonusCommandShipDroneTrackingCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 556 -> { DogmaEffectData.id= 556; name= "caldariBattleshipSkillLevelPreMulShipBonus2CBShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5891 -> { DogmaEffectData.id= 5891; name= "eliteIndustrialArmorHardenerHeatBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6085 -> { DogmaEffectData.id= 6085; name= "shipMissileRoFCaldariTacticalDestroyer1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6279 -> { DogmaEffectData.id= 6279; name= "electronicAttackShipsSkillMultiplier3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6376 -> { DogmaEffectData.id= 6376; name= "logiFrigSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6473 -> { DogmaEffectData.id= 6473; name= "doomsdayConeDOT"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6570 -> { DogmaEffectData.id= 6570; name= "skillBonusFighterHangarManagement"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6667 -> { DogmaEffectData.id= 6667; name= "skillBonusDroneNavigation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6764 -> { DogmaEffectData.id= 6764; name= "iceHarvestingDroneSpecBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6861 -> { DogmaEffectData.id= 6861; name= "shipBonusRole5CapitalRemoteArmorRepairPowergridBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6958 -> { DogmaEffectData.id= 6958; name= "subsystemBonusAmarrOffensive3RemoteArmorRepairHeat"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7055 -> { DogmaEffectData.id= 7055; name= "shipLargeWeaponsDamageBonus"; description= "Large Weapons Damage % Bonus"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7152 -> { DogmaEffectData.id= 7152; name= "precursorBattlecruiserSkillLevelPreMulShipBonusPBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8025 -> { DogmaEffectData.id= 8025; name= "hydraMissileFlightTimeEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None