namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects53=
    let getDogmaEffect id = 
      match id with 
      | 1023 -> { DogmaEffectData.id= 1023; name= "anchorLiftForStructures"; description= ""; displayName= "unanchoring"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1120 -> { DogmaEffectData.id= 1120; name= "shipArmorKineticResistanceABC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4888; postExpression= 4889 } |> Some
      | 1217 -> { DogmaEffectData.id= 1217; name= "shipStasisRangeMF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5255; postExpression= 5256 } |> Some
      | 1896 -> { DogmaEffectData.id= 1896; name= "eliteBargeBonusIceHarvestingCycleTimeBarge3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2187 -> { DogmaEffectData.id= 2187; name= "shipBonusDroneDamageMultiplierGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2478 -> { DogmaEffectData.id= 2478; name= "shipBonusDroneHitpointsBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9081; postExpression= 9082 } |> Some
      | 2672 -> { DogmaEffectData.id= 2672; name= "scanResolutionPremulModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9637; postExpression= 9638 } |> Some
      | 2769 -> { DogmaEffectData.id= 2769; name= "boosterModifyBoosterMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9913; postExpression= 9914 } |> Some
      | 2866 -> { DogmaEffectData.id= 2866; name= "biologyTimeBonusFixed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3157 -> { DogmaEffectData.id= 3157; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN&H&JP&L&M&P"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11031; postExpression= 11032 } |> Some
      | 3254 -> { DogmaEffectData.id= 3254; name= "tacticalShieldManipulationBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3351 -> { DogmaEffectData.id= 3351; name= "shipMissileAssaultMissileRofCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11598; postExpression= 11599 } |> Some
      | 344 -> { DogmaEffectData.id= 344; name= "connectionsSkillBoostConnectionBonusMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3448 -> { DogmaEffectData.id= 3448; name= "eliteBonusViolatorsArmorDamageAmount2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11883; postExpression= 11884 } |> Some
      | 3545 -> { DogmaEffectData.id= 3545; name= "targetProjectileWeaponMaxRangeBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12209; postExpression= 12210 } |> Some
      | 3739 -> { DogmaEffectData.id= 3739; name= "zColinOrcaTractorRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3836 -> { DogmaEffectData.id= 3836; name= "subsystemSkillLevelMinmatarElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4030 -> { DogmaEffectData.id= 4030; name= "systemRemoteEccmRadar"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13472; postExpression= 13473 } |> Some
      | 4127 -> { DogmaEffectData.id= 4127; name= "subsystemBonusGallenteOffensiveDroneBandwidth"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13762; postExpression= 13763 } |> Some
      | 4321 -> { DogmaEffectData.id= 4321; name= "subsystemBonusCaldariCore2ECMStrengthRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 441 -> { DogmaEffectData.id= 441; name= "learningLearningBonusPostPercentWillpowerChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2452; postExpression= 2453 } |> Some
      | 4515 -> { DogmaEffectData.id= 4515; name= "shipFalloffBonusMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5000 -> { DogmaEffectData.id= 5000; name= "shipMissileKineticDamageRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5097 -> { DogmaEffectData.id= 5097; name= "passiveKineticArmorResonanceBonusGroupArmorHardener2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 7873; postExpression= 7874 } |> Some
      | 5291 -> { DogmaEffectData.id= 5291; name= "battlecruiserSkillLevelPreMulShipBonusMBC2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 538 -> { DogmaEffectData.id= 538; name= "amarrBattleshipSkillLevelPostMulShipBonusABShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5388 -> { DogmaEffectData.id= 5388; name= "shipHeavyMissileAOECloudSizeCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5485 -> { DogmaEffectData.id= 5485; name= "shipSPTOptimalBonusMF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5873 -> { DogmaEffectData.id= 5873; name= "shipBonusArmorRepairGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6067 -> { DogmaEffectData.id= 6067; name= "shipBonusLightMissileThermDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18635; postExpression= 18636 } |> Some
      | 6164 -> { DogmaEffectData.id= 6164; name= "systemMaxVelocityPercentage"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6358 -> { DogmaEffectData.id= 6358; name= "roleBonusJustScramblerStrength"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6552 -> { DogmaEffectData.id= 6552; name= "shipBonusForceAuxiliaryM2LocalBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6649 -> { DogmaEffectData.id= 6649; name= "shipBonusTitanG3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6746 -> { DogmaEffectData.id= 6746; name= "npcBehaviorGuidanceDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6843 -> { DogmaEffectData.id= 6843; name= "skillMultiplierMissileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6940 -> { DogmaEffectData.id= 6940; name= "subsystemBonusGallenteDefensive2HardenerHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7037 -> { DogmaEffectData.id= 7037; name= "shipBonusHeavyAssaultMissileThermalDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7134 -> { DogmaEffectData.id= 7134; name= "selfwarpScrambleAdd"; description= ""; displayName= ""; effectCategory= 1; preExpression= 2946; postExpression= 2947 } |> Some
      | 7231 -> { DogmaEffectData.id= 7231; name= "shipBonusArmorRepAmountGC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 732 -> { DogmaEffectData.id= 732; name= "shipVelocityBonusAI"; description= "Automatically generated effect"; displayName= "ShipVelocityBonusAI"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 926 -> { DogmaEffectData.id= 926; name= "amarrCruiserSkillLevelPreMulShipBonusAC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None