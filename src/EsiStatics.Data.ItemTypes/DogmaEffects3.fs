namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects3=
    let getDogmaEffect id = 
      match id with 
      | 100 -> { DogmaEffectData.id= 100; name= "hybridWeaponAccuracyMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 698; postExpression= 701 } |> Some
      | 1264 -> { DogmaEffectData.id= 1264; name= "interceptor2HybridTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5381; postExpression= 5382 } |> Some
      | 1361 -> { DogmaEffectData.id= 1361; name= "ewSkillTdCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5653; postExpression= 5654 } |> Some
      | 1943 -> { DogmaEffectData.id= 1943; name= "ammoEMResistOther"; description= "Automatically generated effect"; displayName= "EM Resistance Modifier"; effectCategory= 0; preExpression= 7435; postExpression= 7436 } |> Some
      | 3495 -> { DogmaEffectData.id= 3495; name= "shipCapPropulsionJamming"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11996; postExpression= 11997 } |> Some
      | 3592 -> { DogmaEffectData.id= 3592; name= "eliteBonusJumpFreighterHullHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12311; postExpression= 12312 } |> Some
      | 391 -> { DogmaEffectData.id= 391; name= "astrogeologyMiningAmountBonusPostPercentMiningAmountLocationShipModulesRequiringMining"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2240; postExpression= 2241 } |> Some
      | 3980 -> { DogmaEffectData.id= 3980; name= "subsystemBonusGallenteDefensiveArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13325; postExpression= 13326 } |> Some
      | 4271 -> { DogmaEffectData.id= 4271; name= "subsystemBonusCaldariCore2MaxTargetingRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14143; postExpression= 14144 } |> Some
      | 4950 -> { DogmaEffectData.id= 4950; name= "shipBonusShieldBoosterMB1a"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15953; postExpression= 15954 } |> Some
      | 5338 -> { DogmaEffectData.id= 5338; name= "shipShieldThermalResistance1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16877; postExpression= 16878 } |> Some
      | 5435 -> { DogmaEffectData.id= 5435; name= "dataMiningSkillLevelVirusCoherenceBonusModifier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17071; postExpression= 17072 } |> Some
      | 5629 -> { DogmaEffectData.id= 5629; name= "shipBonusCruiseMissileThermDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17558; postExpression= 17559 } |> Some
      | 5726 -> { DogmaEffectData.id= 5726; name= "shipBonusLETOptimalRangePirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17752; postExpression= 17753 } |> Some
      | 5823 -> { DogmaEffectData.id= 5823; name= "shipBonusMediumDroneArmorHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18021; postExpression= 18022 } |> Some
      | 5920 -> { DogmaEffectData.id= 5920; name= "systemAoeCloudSize"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18273; postExpression= 18274 } |> Some
      | 6017 -> { DogmaEffectData.id= 6017; name= "modeVelocityPostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1494; postExpression= 1495 } |> Some
      | 6211 -> { DogmaEffectData.id= 6211; name= "commandDestroyerSkillMultiplier3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18946; postExpression= 18947 } |> Some
      | 6308 -> { DogmaEffectData.id= 6308; name= "shipBonusEMMissileDmgMD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19148; postExpression= 19149 } |> Some
      | 6405 -> { DogmaEffectData.id= 6405; name= "structureRigNeutralizerCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6502 -> { DogmaEffectData.id= 6502; name= "shipBonusDreadnoughtA2ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6599 -> { DogmaEffectData.id= 6599; name= "shipBonusCarrierA1ArmorResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6696 -> { DogmaEffectData.id= 6696; name= "starbaseEnergyNeutralizerFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6793 -> { DogmaEffectData.id= 6793; name= "miningForemanBurstBonusORECapital2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12754; postExpression= 12755 } |> Some
      | 682 -> { DogmaEffectData.id= 682; name= "gallenteBattleshipSkillLevelPreMulShipBonusGB2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3380; postExpression= 3381 } |> Some
      | 6890 -> { DogmaEffectData.id= 6890; name= "rigThukkerAdvCapCompManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of Advanced Capital Components"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6987 -> { DogmaEffectData.id= 6987; name= "shipBonusRole2LogisticDroneRepAmountAndHitpointBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 876 -> { DogmaEffectData.id= 876; name= "shieldBoostingForEntities"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4037; postExpression= 131 } |> Some
      | _ -> None