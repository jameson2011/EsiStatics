namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects95=
    let getDogmaEffect id = 
      match id with 
      | 1453 -> { DogmaEffectData.id= 1453; name= "ewSkillEwFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1550 -> { DogmaEffectData.id= 1550; name= "ewSkillTargetPaintingStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2132 -> { DogmaEffectData.id= 2132; name= "smallProjectileMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2714 -> { DogmaEffectData.id= 2714; name= "drawbackCPUNeedLaunchers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 289 -> { DogmaEffectData.id= 289; name= "motionPredictionTrackingSpeedMultiplierPostPercentTrackingSpeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2908 -> { DogmaEffectData.id= 2908; name= "missileExplosiveDmgBonusTorpedo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3587 -> { DogmaEffectData.id= 3587; name= "shipBonusEwRemoteSensorDampenerMaxTargetRangeBonusGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4266 -> { DogmaEffectData.id= 4266; name= "subsystemBonusCaldariEngineeringCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4363 -> { DogmaEffectData.id= 4363; name= "subsystemBonusAmarrOffensive2HAMThermalDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4460 -> { DogmaEffectData.id= 4460; name= "imperialsetLGbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4557 -> { DogmaEffectData.id= 4557; name= "capitalLauncherSkillCruiseCitadelKineticDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4945 -> { DogmaEffectData.id= 4945; name= "skillTargetBreakerDurationBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5139 -> { DogmaEffectData.id= 5139; name= "shipMiningBonusOREfrig1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5333 -> { DogmaEffectData.id= 5333; name= "shipLaserDamageBonusABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5430 -> { DogmaEffectData.id= 5430; name= "shipBonusAoeVelocityCruiseMissilesMB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5527 -> { DogmaEffectData.id= 5527; name= "skillJumpCloneCooldownReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5721 -> { DogmaEffectData.id= 5721; name= "shipBonusMETOptimalRangePirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5818 -> { DogmaEffectData.id= 5818; name= "shipBonusLightDroneArmorHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5915 -> { DogmaEffectData.id= 5915; name= "systemEnergyVampireMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6012 -> { DogmaEffectData.id= 6012; name= "shipModeScanStrengthPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6400 -> { DogmaEffectData.id= 6400; name= "skillStructureElectronicSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6594 -> { DogmaEffectData.id= 6594; name= "shipBonusSupercarrierM3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6691 -> { DogmaEffectData.id= 6691; name= "entityEnergyNeutralizerFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 677 -> { DogmaEffectData.id= 677; name= "weaponUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringMissileLauncherOperation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6788 -> { DogmaEffectData.id= 6788; name= "shipBonusDroneIceHarvestingICS5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6885 -> { DogmaEffectData.id= 6885; name= "npcBehaviorSiege"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6982 -> { DogmaEffectData.id= 6982; name= "shipBonusTitanG2EMExplosiveDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7079 -> { DogmaEffectData.id= 7079; name= "shipPCBSSPeedBonusPCBS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7176 -> { DogmaEffectData.id= 7176; name= "skillBonusDroneInterfacingNotFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8049 -> { DogmaEffectData.id= 8049; name= "upwellFrigateSkillLevelPreMulShipBonusUF1UF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 95 -> { DogmaEffectData.id= 95; name= "energyWeaponSpeedMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 968 -> { DogmaEffectData.id= 968; name= "shipProjectileDmgMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None