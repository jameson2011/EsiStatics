namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects96=
    let getDogmaEffect id = 
      match id with 
      | 1551 -> { DogmaEffectData.id= 1551; name= "minmatarShipEwTargetPainterMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2133 -> { DogmaEffectData.id= 2133; name= "energyTransferArrayMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2812 -> { DogmaEffectData.id= 2812; name= "caldariShipECMBurstOptimalRangeCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 290 -> { DogmaEffectData.id= 290; name= "sharpshooterRangeSkillBonusPostPercentMaxRangeLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2909 -> { DogmaEffectData.id= 2909; name= "missileKineticDmgBonusTorpedo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3200 -> { DogmaEffectData.id= 3200; name= "overloadSelfArmorDamageAmountDurationBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3297 -> { DogmaEffectData.id= 3297; name= "shipEnergyNeutralizerTransferAmountBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3588 -> { DogmaEffectData.id= 3588; name= "shipBonusEwRemoteSensorDampenerMaxTargetRangeBonusGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3782 -> { DogmaEffectData.id= 3782; name= "powerOutputAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3976 -> { DogmaEffectData.id= 3976; name= "subsystemBonusCaldariDefensiveShieldHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4267 -> { DogmaEffectData.id= 4267; name= "subsystemBonusAmarrEngineeringCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4364 -> { DogmaEffectData.id= 4364; name= "subsystemBonusAmarrOffensive2HAMKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4461 -> { DogmaEffectData.id= 4461; name= "federationsetLGbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4558 -> { DogmaEffectData.id= 4558; name= "capitalLauncherSkillCruiseCitadelThermalDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4946 -> { DogmaEffectData.id= 4946; name= "skillTargetBreakerCapNeedBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5237 -> { DogmaEffectData.id= 5237; name= "shipSmallMissileKinDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5334 -> { DogmaEffectData.id= 5334; name= "shipHybridOptimal1CBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5431 -> { DogmaEffectData.id= 5431; name= "shipBonusLargeEnergyTurretTrackingAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5722 -> { DogmaEffectData.id= 5722; name= "shipHybridOptimalGD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 581 -> { DogmaEffectData.id= 581; name= "weaponUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5819 -> { DogmaEffectData.id= 5819; name= "shipBonusLightDroneShieldHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5916 -> { DogmaEffectData.id= 5916; name= "systemDamageExplosiveBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6110 -> { DogmaEffectData.id= 6110; name= "missileVelocityBonusOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6401 -> { DogmaEffectData.id= 6401; name= "skillStructureEngineeringSystemsCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6498 -> { DogmaEffectData.id= 6498; name= "skillMultiplierShipBonusDreadnoughtMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6595 -> { DogmaEffectData.id= 6595; name= "shipBonusCarrierA4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6692 -> { DogmaEffectData.id= 6692; name= "remoteTargetPaintEntity"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6789 -> { DogmaEffectData.id= 6789; name= "industrialBonusDroneDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6983 -> { DogmaEffectData.id= 6983; name= "shipBonusTitanC1ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7080 -> { DogmaEffectData.id= 7080; name= "shipPCBSDmgBonusPCBS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7177 -> { DogmaEffectData.id= 7177; name= "skillBonusDroneDurabilityNotFighters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8050 -> { DogmaEffectData.id= 8050; name= "upwellCruiserSkillLevelPreMulShipBonusUC1UC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 96 -> { DogmaEffectData.id= 96; name= "hybridWeaponSpeedMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None