namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects0=
    let getDogmaEffect id = 
      match id with 
      | 1261 -> { DogmaEffectData.id= 1261; name= "setBonusSerpentis"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5370; postExpression= 5371 } |> Some
      | 2134 -> { DogmaEffectData.id= 2134; name= "shieldTransporterMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8015; postExpression= 8016 } |> Some
      | 2231 -> { DogmaEffectData.id= 2231; name= "scanStrengthBonusPercentActivate"; description= ""; displayName= ""; effectCategory= 1; preExpression= 8294; postExpression= 8295 } |> Some
      | 2716 -> { DogmaEffectData.id= 2716; name= "drawbackSigRad"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9757; postExpression= 9758 } |> Some
      | 2910 -> { DogmaEffectData.id= 2910; name= "missileThermalDmgBonusTorpedo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10291; postExpression= 10292 } |> Some
      | 3201 -> { DogmaEffectData.id= 3201; name= "overloadSelfShieldBonusDurationBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 11191; postExpression= 11192 } |> Some
      | 3298 -> { DogmaEffectData.id= 3298; name= "shipEnergyNeutralizerTransferAmountBonusAC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11460; postExpression= 11461 } |> Some
      | 3589 -> { DogmaEffectData.id= 3589; name= "shipBonusEwRemoteSensorDampenerScanResolutionBonusGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12301; postExpression= 12302 } |> Some
      | 3686 -> { DogmaEffectData.id= 3686; name= "scriptTrackingComputerFalloffBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12606; postExpression= 12607 } |> Some
      | 3783 -> { DogmaEffectData.id= 3783; name= "cpuOutputAddCpuOutputPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12861; postExpression= 12862 } |> Some
      | 4365 -> { DogmaEffectData.id= 4365; name= "subsystemBonusAmarrOffensive2HAMExplosiveDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14357; postExpression= 14358 } |> Some
      | 4462 -> { DogmaEffectData.id= 4462; name= "caldarisetLGbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14639; postExpression= 14640 } |> Some
      | 4559 -> { DogmaEffectData.id= 4559; name= "gunneryMaxRangeFalloffTrackingSpeedBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 14962; postExpression= 14963 } |> Some
      | 4656 -> { DogmaEffectData.id= 4656; name= "NPCRemoteECM"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 89 } |> Some
      | 485 -> { DogmaEffectData.id= 485; name= "energysystemsoperationCapRechargeBonusPostPercentRechargeRateLocationShipGroupCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2601; postExpression= 2602 } |> Some
      | 4850 -> { DogmaEffectData.id= 4850; name= "battlecruiserSkillLevelPreMulShipBonusBC3Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15664; postExpression= 15665 } |> Some
      | 5335 -> { DogmaEffectData.id= 5335; name= "shipShieldEmResistance1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16871; postExpression= 16872 } |> Some
      | 5723 -> { DogmaEffectData.id= 5723; name= "eliteBonusInterdictorsMWDSigRadius2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17748; postExpression= 17749 } |> Some
      | 582 -> { DogmaEffectData.id= 582; name= "rapidFiringRofBonusPostPercentSpeedLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3011; postExpression= 3012 } |> Some
      | 5820 -> { DogmaEffectData.id= 5820; name= "shipBonusAfterburnerSpeedFactorCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18011; postExpression= 18012 } |> Some
      | 5917 -> { DogmaEffectData.id= 5917; name= "systemDamageKineticBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18263; postExpression= 18264 } |> Some
      | 6014 -> { DogmaEffectData.id= 6014; name= "modeSigRadiusPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3277; postExpression= 3278 } |> Some
      | 6111 -> { DogmaEffectData.id= 6111; name= "missileExplosionDelayBonusOnline"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 18740; postExpression= 18741 } |> Some
      | 6208 -> { DogmaEffectData.id= 6208; name= "microJumpPortalDrive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6305 -> { DogmaEffectData.id= 6305; name= "shipBonusEnergyNosFalloffAC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19144; postExpression= 19145 } |> Some
      | 6402 -> { DogmaEffectData.id= 6402; name= "structureRigAoeVelocityBonusSingleTargetMissiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6596 -> { DogmaEffectData.id= 6596; name= "shipBonusCarrierC4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6693 -> { DogmaEffectData.id= 6693; name= "remoteSensorDampEntity"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6790 -> { DogmaEffectData.id= 6790; name= "shipBonusDroneIceHarvestingRole"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6887 -> { DogmaEffectData.id= 6887; name= "rigThukkerBasCapCompManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of Basic Capital Components"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6984 -> { DogmaEffectData.id= 6984; name= "shipBonusRole4FighterDamageAndHitpoints"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 97 -> { DogmaEffectData.id= 97; name= "turretWeaponAccuracyMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 703; postExpression= 705 } |> Some
      | _ -> None