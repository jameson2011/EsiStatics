namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects3=
    let getDogmaEffect id = 
      match id with 
      | 100 -> { DogmaEffectData.id= 100; name= "hybridWeaponAccuracyMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1264 -> { DogmaEffectData.id= 1264; name= "interceptor2HybridTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1361 -> { DogmaEffectData.id= 1361; name= "ewSkillTdCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1943 -> { DogmaEffectData.id= 1943; name= "ammoEMResistOther"; description= "Automatically generated effect"; displayName= "EM Resistance Modifier"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3495 -> { DogmaEffectData.id= 3495; name= "shipCapPropulsionJamming"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3592 -> { DogmaEffectData.id= 3592; name= "eliteBonusJumpFreighterHullHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 391 -> { DogmaEffectData.id= 391; name= "astrogeologyMiningAmountBonusPostPercentMiningAmountLocationShipModulesRequiringMining"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3980 -> { DogmaEffectData.id= 3980; name= "subsystemBonusGallenteDefensiveArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4271 -> { DogmaEffectData.id= 4271; name= "subsystemBonusCaldariCore2MaxTargetingRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4950 -> { DogmaEffectData.id= 4950; name= "shipBonusShieldBoosterMB1a"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5338 -> { DogmaEffectData.id= 5338; name= "shipShieldThermalResistance1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5435 -> { DogmaEffectData.id= 5435; name= "dataMiningSkillLevelVirusCoherenceBonusModifier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5629 -> { DogmaEffectData.id= 5629; name= "shipBonusCruiseMissileThermDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5726 -> { DogmaEffectData.id= 5726; name= "shipBonusLETOptimalRangePirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5823 -> { DogmaEffectData.id= 5823; name= "shipBonusMediumDroneArmorHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5920 -> { DogmaEffectData.id= 5920; name= "systemAoeCloudSize"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6017 -> { DogmaEffectData.id= 6017; name= "modeVelocityPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6211 -> { DogmaEffectData.id= 6211; name= "commandDestroyerSkillMultiplier3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6308 -> { DogmaEffectData.id= 6308; name= "shipBonusEMMissileDmgMD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6405 -> { DogmaEffectData.id= 6405; name= "structureRigNeutralizerCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6502 -> { DogmaEffectData.id= 6502; name= "shipBonusDreadnoughtA2ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6599 -> { DogmaEffectData.id= 6599; name= "shipBonusCarrierA1ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6696 -> { DogmaEffectData.id= 6696; name= "starbaseEnergyNeutralizerFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6793 -> { DogmaEffectData.id= 6793; name= "miningForemanBurstBonusORECapital2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 682 -> { DogmaEffectData.id= 682; name= "gallenteBattleshipSkillLevelPreMulShipBonusGB2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6890 -> { DogmaEffectData.id= 6890; name= "rigThukkerAdvCapCompManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of Advanced Capital Components"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6987 -> { DogmaEffectData.id= 6987; name= "shipBonusRole2LogisticDroneRepAmountAndHitpointBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8054 -> { DogmaEffectData.id= 8054; name= "shipBonusUB1upwellDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 876 -> { DogmaEffectData.id= 876; name= "shieldBoostingForEntities"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None