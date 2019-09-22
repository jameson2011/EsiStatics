namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects79=
    let getDogmaEffect id = 
      match id with 
      | 1049 -> { DogmaEffectData.id= 1049; name= "shipShieldTransferRangeMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4622; postExpression= 4623 } |> Some
      | 1922 -> { DogmaEffectData.id= 1922; name= "eliteReconScramblerRangeBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7367; postExpression= 7368 } |> Some
      | 2019 -> { DogmaEffectData.id= 2019; name= "repairDroneShieldBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7662; postExpression= 7663 } |> Some
      | 2504 -> { DogmaEffectData.id= 2504; name= "shipBonusHybridTrackingGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4766; postExpression= 4767 } |> Some
      | 2698 -> { DogmaEffectData.id= 2698; name= "maxRangeBonusEffectProjectiles"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9707; postExpression= 9708 } |> Some
      | 273 -> { DogmaEffectData.id= 273; name= "shieldUpgradesPowerNeedBonusPostPercentPowerLocationShipModulesRequiringShieldUpgrades"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1703; postExpression= 1704 } |> Some
      | 2795 -> { DogmaEffectData.id= 2795; name= "modifyShieldResonancePostPercentPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7755; postExpression= 7756 } |> Some
      | 2892 -> { DogmaEffectData.id= 2892; name= "missileExplosiveDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10227; postExpression= 10228 } |> Some
      | 3571 -> { DogmaEffectData.id= 3571; name= "eliteBonusLogisticsTrackingLinkTrackingSpeedBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12274; postExpression= 12275 } |> Some
      | 3668 -> { DogmaEffectData.id= 3668; name= "miningLaserRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8032; postExpression= 8033 } |> Some
      | 3765 -> { DogmaEffectData.id= 3765; name= "covertOpsStealthBomberSiegeMissileLauncherPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12824; postExpression= 12825 } |> Some
      | 3959 -> { DogmaEffectData.id= 3959; name= "subsystemBonusAmarrDefensiveArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13283; postExpression= 13284 } |> Some
      | 4056 -> { DogmaEffectData.id= 4056; name= "systemSmallHybridDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13574; postExpression= 13575 } |> Some
      | 4153 -> { DogmaEffectData.id= 4153; name= "subsystemBonusCaldariEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13814; postExpression= 13815 } |> Some
      | 4250 -> { DogmaEffectData.id= 4250; name= "subsystemBonusGallenteOffensiveDroneDamageHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14103; postExpression= 14104 } |> Some
      | 4347 -> { DogmaEffectData.id= 4347; name= "subsystemBonusGallenteOffensive3TurretTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14312; postExpression= 14313 } |> Some
      | 5123 -> { DogmaEffectData.id= 5123; name= "shipBonusRemoteArmorRepairCapNeedAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6955; postExpression= 6956 } |> Some
      | 5220 -> { DogmaEffectData.id= 5220; name= "shipProjectileDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16599; postExpression= 16600 } |> Some
      | 5317 -> { DogmaEffectData.id= 5317; name= "shipProjectileDamageMD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16835; postExpression= 16836 } |> Some
      | 5802 -> { DogmaEffectData.id= 5802; name= "shipBonusAfterburnerSpeedFactor2CB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17957; postExpression= 17958 } |> Some
      | 5899 -> { DogmaEffectData.id= 5899; name= "eliteIndustrialArmorRepairHeatBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18209; postExpression= 18210 } |> Some
      | 5996 -> { DogmaEffectData.id= 5996; name= "freighterO1SkillLevel"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18470; postExpression= 18471 } |> Some
      | 6093 -> { DogmaEffectData.id= 6093; name= "shipBonusHeavyMissileAllDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18689; postExpression= 18690 } |> Some
      | 6287 -> { DogmaEffectData.id= 6287; name= "shipBonusEnergyNosOptimalAF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19104; postExpression= 19105 } |> Some
      | 6384 -> { DogmaEffectData.id= 6384; name= "overloadSelfMissileGuidanceModuleBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 17826; postExpression= 17827 } |> Some
      | 6481 -> { DogmaEffectData.id= 6481; name= "doomsdayAOEDamp"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6578 -> { DogmaEffectData.id= 6578; name= "skillBonusXLTorpedoSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 661 -> { DogmaEffectData.id= 661; name= "missileExplosiveDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3305; postExpression= 3306 } |> Some
      | 6675 -> { DogmaEffectData.id= 6675; name= "structureRigMoonOreYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6772 -> { DogmaEffectData.id= 6772; name= "informationCommandDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6869 -> { DogmaEffectData.id= 6869; name= "concordIntermediateSecStatus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7063 -> { DogmaEffectData.id= 7063; name= "weather_xenon_gas"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7160 -> { DogmaEffectData.id= 7160; name= "shipArmorEMResistancePBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19691; postExpression= 19692 } |> Some
      | _ -> None