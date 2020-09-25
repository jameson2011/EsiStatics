namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects24=
    let getDogmaEffect id = 
      match id with 
      | 1188 -> { DogmaEffectData.id= 1188; name= "miningBargeSkillLevelPostMulShipBonusORE2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1673 -> { DogmaEffectData.id= 1673; name= "freighterMaxVelocityBonusC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1964 -> { DogmaEffectData.id= 1964; name= "shipBonusShieldTransferCapneed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2158 -> { DogmaEffectData.id= 2158; name= "eliteBonusCommandShipLaserROFCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 218 -> { DogmaEffectData.id= 218; name= "engineeringSkillBoostPowerOutputBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2255 -> { DogmaEffectData.id= 2255; name= "tractorBeamCan"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 2837 -> { DogmaEffectData.id= 2837; name= "armorHPBonusAdd"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 3031 -> { DogmaEffectData.id= 3031; name= "overloadSelfExplosiveHardeningBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 315 -> { DogmaEffectData.id= 315; name= "dronesSkillBoostMaxActiveDroneBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3710 -> { DogmaEffectData.id= 3710; name= "concordTargetJam"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3807 -> { DogmaEffectData.id= 3807; name= "maxTargetRangeAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 412 -> { DogmaEffectData.id= 412; name= "industrySkillBoostManufacturingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4195 -> { DogmaEffectData.id= 4195; name= "subsystemSkillLevelAmarrDefensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4292 -> { DogmaEffectData.id= 4292; name= "subsystemBonusCaldariOffensive2RemoteShieldBoosterCapUse"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4389 -> { DogmaEffectData.id= 4389; name= "subSystemBonusAmarrElectronicScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5068 -> { DogmaEffectData.id= 5068; name= "shipBonusShieldCapacityORE2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5165 -> { DogmaEffectData.id= 5165; name= "shipBonusDroneMWDboostrole"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5262 -> { DogmaEffectData.id= 5262; name= "covertOpsCloakCpuPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5359 -> { DogmaEffectData.id= 5359; name= "shipHybridDamageBonusGBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5456 -> { DogmaEffectData.id= 5456; name= "shipCruiseMissileROFCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5553 -> { DogmaEffectData.id= 5553; name= "shipBonusHAMVelocityEliteBonusHeavyGunship1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5650 -> { DogmaEffectData.id= 5650; name= "shipArmorResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6038 -> { DogmaEffectData.id= 6038; name= "shipSPTOptimalMinmatarTacticalDestroyer2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6135 -> { DogmaEffectData.id= 6135; name= "missileGuidanceComputerBonus4"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6232 -> { DogmaEffectData.id= 6232; name= "shipBonusEnergyNeutFalloffRS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6329 -> { DogmaEffectData.id= 6329; name= "shipBonusExplosiveMissileDamageCD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6426 -> { DogmaEffectData.id= 6426; name= "remoteWebifierFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6523 -> { DogmaEffectData.id= 6523; name= "skillMultiplierShipBonusForceAuxiliaryMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6620 -> { DogmaEffectData.id= 6620; name= "shipBonusDreadnoughtC3ReloadBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6717 -> { DogmaEffectData.id= 6717; name= "roleBonusIceOreMiningDurationCap"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6814 -> { DogmaEffectData.id= 6814; name= "rigMediumshipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of medium ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6911 -> { DogmaEffectData.id= 6911; name= "shipBonusStrategicCruiserMinmatarNaniteRepairTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7008 -> { DogmaEffectData.id= 7008; name= "structureFullPowerStateHitpointModifier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 703 -> { DogmaEffectData.id= 703; name= "interceptorsSkillLevelPreMulEliteBonusInterceptorShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7105 -> { DogmaEffectData.id= 7105; name= "structureConversionRigMETimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7202 -> { DogmaEffectData.id= 7202; name= "systemDroneSpeedBonusPercent"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 8075 -> { DogmaEffectData.id= 8075; name= "systemHullEmResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None