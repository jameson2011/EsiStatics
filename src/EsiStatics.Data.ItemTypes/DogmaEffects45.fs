namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects45=
    let getDogmaEffect id = 
      match id with 
      | 1015 -> { DogmaEffectData.id= 1015; name= "selfT2LargeLaserPulseDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1500 -> { DogmaEffectData.id= 1500; name= "shieldOperationSkillBoostCapacitorNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1597 -> { DogmaEffectData.id= 1597; name= "missileSkillWarheadUpgradesKineticDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2179 -> { DogmaEffectData.id= 2179; name= "shipBonusDroneHitpointsGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 239 -> { DogmaEffectData.id= 239; name= "corporationManagementSkillBoostCorporationMemberBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2858 -> { DogmaEffectData.id= 2858; name= "cloneJumpAccepting"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 3343 -> { DogmaEffectData.id= 3343; name= "eliteBonusHeavyInterdictorsProjectileFalloff1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 336 -> { DogmaEffectData.id= 336; name= "battleshipConstructionSkillBoostBattleshipConstructionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4022 -> { DogmaEffectData.id= 4022; name= "systemTracking"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4216 -> { DogmaEffectData.id= 4216; name= "subsystemBonusAmarrCore2EnergyVampireAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 433 -> { DogmaEffectData.id= 433; name= "researchBlueprintmanufactureTimeBonusPostPercentProductionTimeResearchSpeedChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4410 -> { DogmaEffectData.id= 4410; name= "subsystemBonusScanProbeLauncherCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5283 -> { DogmaEffectData.id= 5283; name= "destroyerSkillLevelPreMulShipBonusMD2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 530 -> { DogmaEffectData.id= 530; name= "caldariIndustrialSkillLevelPreMulShipBonusCIShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5380 -> { DogmaEffectData.id= 5380; name= "shipHybridTrackingGBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5477 -> { DogmaEffectData.id= 5477; name= "shipBonusAmmoBayMI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5574 -> { DogmaEffectData.id= 5574; name= "eliteBonusCommandShipSkirmishCS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5768 -> { DogmaEffectData.id= 5768; name= "EssWarpScramble"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5865 -> { DogmaEffectData.id= 5865; name= "shipMissileExploDamageCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6059 -> { DogmaEffectData.id= 6059; name= "shipBonusMediumDroneHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6253 -> { DogmaEffectData.id= 6253; name= "shipBonusEnergyNeutOptimalAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 627 -> { DogmaEffectData.id= 627; name= "powerIncrease"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6350 -> { DogmaEffectData.id= 6350; name= "shipSmallMissileKinDmgCF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6447 -> { DogmaEffectData.id= 6447; name= "lightningWeapon"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6641 -> { DogmaEffectData.id= 6641; name= "shipBonusRole2ArmorPlates&ShieldExtendersBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6835 -> { DogmaEffectData.id= 6835; name= "rigTEResearchTimeBonus"; description= "Structure Rig Time effect on TE Research"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6932 -> { DogmaEffectData.id= 6932; name= "subsystemBonusGallenteCore2EnergyResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7029 -> { DogmaEffectData.id= 7029; name= "structureArmorHPBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 7223 -> { DogmaEffectData.id= 7223; name= "systemAgilityBonusPercentItem"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 8096 -> { DogmaEffectData.id= 8096; name= "shipBonusKinMissileDamageCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 918 -> { DogmaEffectData.id= 918; name= "shipDronesMaxGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None