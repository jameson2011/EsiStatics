namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects18=
    let getDogmaEffect id = 
      match id with 
      | 115 -> { DogmaEffectData.id= 115; name= "characterPerceptionSkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1182 -> { DogmaEffectData.id= 1182; name= "shipEnergyTransferRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1279 -> { DogmaEffectData.id= 1279; name= "interceptors2SkillLevelPreMulEliteBonusInterceptorShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1473 -> { DogmaEffectData.id= 1473; name= "missileSkillAoeCloudSizeBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1667 -> { DogmaEffectData.id= 1667; name= "freighterM2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1764 -> { DogmaEffectData.id= 1764; name= "missileSkillMissileProjectileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 18 -> { DogmaEffectData.id= 18; name= "shieldTransfer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 2055 -> { DogmaEffectData.id= 2055; name= "kineticShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 212 -> { DogmaEffectData.id= 212; name= "sensorUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringSensorUpgrades"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2152 -> { DogmaEffectData.id= 2152; name= "jumpPortalGeneration"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2249 -> { DogmaEffectData.id= 2249; name= "shipBonusDroneMiningAmountAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2734 -> { DogmaEffectData.id= 2734; name= "shipECMScanStrengthBonusCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3025 -> { DogmaEffectData.id= 3025; name= "overloadSelfDamageBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3995 -> { DogmaEffectData.id= 3995; name= "systemSignatureRadius"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 406 -> { DogmaEffectData.id= 406; name= "socialSkillBoostSocialMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4189 -> { DogmaEffectData.id= 4189; name= "shipBonusStrategicCruiserGallenteHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4286 -> { DogmaEffectData.id= 4286; name= "subsystemBonusAmarrOffensive2RemoteArmorRepairCapUse"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4480 -> { DogmaEffectData.id= 4480; name= "covertOpsSkillLevelPreMulEliteBonusCoverOpsShip3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4577 -> { DogmaEffectData.id= 4577; name= "eliteBonusLogisticsTrackingLinkFalloffBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4771 -> { DogmaEffectData.id= 4771; name= "onlineOrbital"; description= "this is the online effect for structures"; displayName= "online"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4868 -> { DogmaEffectData.id= 4868; name= "setBonusChristmasCapacitorCapacity"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5353 -> { DogmaEffectData.id= 5353; name= "shipProjectileRof1MBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5644 -> { DogmaEffectData.id= 5644; name= "shipBonusMissileVelocityCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 600 -> { DogmaEffectData.id= 600; name= "ammoTrackingMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6032 -> { DogmaEffectData.id= 6032; name= "remoteCapacitorTransmitterPowerNeedBonusEffect"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6129 -> { DogmaEffectData.id= 6129; name= "scriptMissileGuidanceComputerAOEVelocityBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6226 -> { DogmaEffectData.id= 6226; name= "structureMissileGuidanceComputerBonus4"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6323 -> { DogmaEffectData.id= 6323; name= "scriptscanLadarStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6517 -> { DogmaEffectData.id= 6517; name= "skillMultiplierShipBonusForceAuxiliaryCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6614 -> { DogmaEffectData.id= 6614; name= "shipBonusSupercarrierRole2ArmorShieldModuleBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6711 -> { DogmaEffectData.id= 6711; name= "shipBonusRole3CapitalHybridDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6808 -> { DogmaEffectData.id= 6808; name= "rigAmmoManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of ammo"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6905 -> { DogmaEffectData.id= 6905; name= "strategicCruiserAmarrSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7002 -> { DogmaEffectData.id= 7002; name= "roleBonusBombLauncherPWGCPU3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7099 -> { DogmaEffectData.id= 7099; name= "structureConversionRigManufacturingMaterialBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 891 -> { DogmaEffectData.id= 891; name= "shipCruiseMissileVelocityBonusCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 988 -> { DogmaEffectData.id= 988; name= "gunshipSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None