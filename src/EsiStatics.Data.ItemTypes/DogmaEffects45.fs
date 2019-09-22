namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects45=
    let getDogmaEffect id = 
      match id with 
      | 1015 -> { DogmaEffectData.id= 1015; name= "selfT2LargeLaserPulseDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4504; postExpression= 4505 } |> Some
      | 1500 -> { DogmaEffectData.id= 1500; name= "shieldOperationSkillBoostCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6099; postExpression= 6100 } |> Some
      | 1597 -> { DogmaEffectData.id= 1597; name= "missileSkillWarheadUpgradesKineticDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6379; postExpression= 6380 } |> Some
      | 2179 -> { DogmaEffectData.id= 2179; name= "shipBonusDroneHitpointsGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8138; postExpression= 8139 } |> Some
      | 239 -> { DogmaEffectData.id= 239; name= "corporationManagementSkillBoostCorporationMemberBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1574; postExpression= 1575 } |> Some
      | 2858 -> { DogmaEffectData.id= 2858; name= "cloneJumpAccepting"; description= ""; displayName= ""; effectCategory= 1; preExpression= 10124; postExpression= 10125 } |> Some
      | 3343 -> { DogmaEffectData.id= 3343; name= "eliteBonusHeavyInterdictorsProjectileFalloff1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11572; postExpression= 11573 } |> Some
      | 336 -> { DogmaEffectData.id= 336; name= "battleshipConstructionSkillBoostBattleshipConstructionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2004; postExpression= 2005 } |> Some
      | 4022 -> { DogmaEffectData.id= 4022; name= "systemTracking"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13436; postExpression= 13437 } |> Some
      | 4216 -> { DogmaEffectData.id= 4216; name= "subsystemBonusAmarrCore2EnergyVampireAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14021; postExpression= 14022 } |> Some
      | 433 -> { DogmaEffectData.id= 433; name= "researchBlueprintmanufactureTimeBonusPostPercentProductionTimeResearchSpeedChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2413; postExpression= 2414 } |> Some
      | 4410 -> { DogmaEffectData.id= 4410; name= "subsystemBonusScanProbeLauncherCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14458; postExpression= 14459 } |> Some
      | 5283 -> { DogmaEffectData.id= 5283; name= "destroyerSkillLevelPreMulShipBonusMD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16750; postExpression= 16751 } |> Some
      | 530 -> { DogmaEffectData.id= 530; name= "caldariIndustrialSkillLevelPreMulShipBonusCIShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2823; postExpression= 2824 } |> Some
      | 5380 -> { DogmaEffectData.id= 5380; name= "shipHybridTrackingGBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16954; postExpression= 16955 } |> Some
      | 5477 -> { DogmaEffectData.id= 5477; name= "shipBonusAmmoBayMI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17202; postExpression= 17203 } |> Some
      | 5574 -> { DogmaEffectData.id= 5574; name= "eliteBonusCommandShipSkirmishCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17434; postExpression= 17435 } |> Some
      | 5768 -> { DogmaEffectData.id= 5768; name= "EssWarpScramble"; description= ""; displayName= ""; effectCategory= 2; preExpression= 294; postExpression= 295 } |> Some
      | 5865 -> { DogmaEffectData.id= 5865; name= "shipMissileExploDamageCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18122; postExpression= 18123 } |> Some
      | 6059 -> { DogmaEffectData.id= 6059; name= "shipBonusMediumDroneHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18621; postExpression= 18622 } |> Some
      | 6253 -> { DogmaEffectData.id= 6253; name= "shipBonusEnergyNeutOptimalAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19027; postExpression= 19028 } |> Some
      | 627 -> { DogmaEffectData.id= 627; name= "powerIncrease"; description= ""; displayName= ""; effectCategory= 4; preExpression= 3174; postExpression= 3175 } |> Some
      | 6350 -> { DogmaEffectData.id= 6350; name= "shipSmallMissileKinDmgCF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16629; postExpression= 16630 } |> Some
      | 6447 -> { DogmaEffectData.id= 6447; name= "lightningWeapon"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6641 -> { DogmaEffectData.id= 6641; name= "shipBonusRole2ArmorPlates&ShieldExtendersBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6835 -> { DogmaEffectData.id= 6835; name= "rigTEResearchTimeBonus"; description= "Structure Rig Time effect on TE Research"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6932 -> { DogmaEffectData.id= 6932; name= "subsystemBonusGallenteCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13826; postExpression= 13827 } |> Some
      | 7029 -> { DogmaEffectData.id= 7029; name= "structureArmorHPBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 509; postExpression= 510 } |> Some
      | 7223 -> { DogmaEffectData.id= 7223; name= "systemAgilityBonusPercentItem"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 2250; postExpression= 2251 } |> Some
      | 918 -> { DogmaEffectData.id= 918; name= "shipDronesMaxGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4184; postExpression= 4185 } |> Some
      | _ -> None