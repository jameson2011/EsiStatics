namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects25=
    let getDogmaEffect id = 
      match id with 
      | 1577 -> { DogmaEffectData.id= 1577; name= "haloSetBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1674 -> { DogmaEffectData.id= 1674; name= "freighterMaxVelocityBonusG1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 25 -> { DogmaEffectData.id= 25; name= "capacitorCapacityBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2644 -> { DogmaEffectData.id= 2644; name= "increaseSignatureRadiusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2741 -> { DogmaEffectData.id= 2741; name= "boosterTurretFalloffPenalty"; description= "Automatically generated effect"; displayName= "Turret Falloff Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3032 -> { DogmaEffectData.id= 3032; name= "overloadSelfKineticHardeningBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 316 -> { DogmaEffectData.id= 316; name= "dronesMaxActiveDroneBonusModAddMaxActiveLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3808 -> { DogmaEffectData.id= 3808; name= "signatureRadiusAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4002 -> { DogmaEffectData.id= 4002; name= "systemMissileVelocity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 413 -> { DogmaEffectData.id= 413; name= "gunnerySkillBoostTurretSpeeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4196 -> { DogmaEffectData.id= 4196; name= "subsystemSkillLevelCaldariDefensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4390 -> { DogmaEffectData.id= 4390; name= "subSystemBonusCaldariElectronicScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4972 -> { DogmaEffectData.id= 4972; name= "eliteBonusAssaultShipLightMissileROF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5069 -> { DogmaEffectData.id= 5069; name= "mercoxitCrystalBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 510 -> { DogmaEffectData.id= 510; name= "amarrFrigateSkillLevelPreMulShipBonus2AFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5263 -> { DogmaEffectData.id= 5263; name= "covertCynoCpuPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5360 -> { DogmaEffectData.id= 5360; name= "shipProjectileRofBonusMBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5457 -> { DogmaEffectData.id= 5457; name= "shipTorpedoROFCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5554 -> { DogmaEffectData.id= 5554; name= "shipBonusArmorRepAmountGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6039 -> { DogmaEffectData.id= 6039; name= "shipModeSPTTrackingPostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 607 -> { DogmaEffectData.id= 607; name= "cloaking"; description= ""; displayName= "Cloaking"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6233 -> { DogmaEffectData.id= 6233; name= "shipBonusEnergyNeutFalloffRS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6330 -> { DogmaEffectData.id= 6330; name= "shipBonusShieldEMResistanceCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6427 -> { DogmaEffectData.id= 6427; name= "remoteSensorBoostFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6621 -> { DogmaEffectData.id= 6621; name= "shipBonusSupercarrierA2ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6718 -> { DogmaEffectData.id= 6718; name= "logisticSkillMultiplier3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6815 -> { DogmaEffectData.id= 6815; name= "rigMediumshipsManufactureTimeBonus"; description= "Structure Rig time effect on Manufacturing of medium ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6912 -> { DogmaEffectData.id= 6912; name= "subsystemSkillLevelAmarrDefensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7009 -> { DogmaEffectData.id= 7009; name= "serviceModuleFullPowerHitpointPostAssign"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 704 -> { DogmaEffectData.id= 704; name= "covertOpsSkillLevelPreMulEliteBonusCoverOpsShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7106 -> { DogmaEffectData.id= 7106; name= "structureConversionRigTETimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7203 -> { DogmaEffectData.id= 7203; name= "systemDroneDamageBonusPercent"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 898 -> { DogmaEffectData.id= 898; name= "shipMissileKineticDamageCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None