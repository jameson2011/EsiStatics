namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects47=
    let getDogmaEffect id = 
      match id with 
      | 1017 -> { DogmaEffectData.id= 1017; name= "selfT2LargeHybridBlasterDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4516; postExpression= 4517 } |> Some
      | 1405 -> { DogmaEffectData.id= 1405; name= "covertOpsSkillLevelPreMulEliteBonusCoverOpsShip2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5814; postExpression= 5815 } |> Some
      | 2181 -> { DogmaEffectData.id= 2181; name= "shipBonusDroneHitpointsFixedAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8142; postExpression= 8143 } |> Some
      | 2763 -> { DogmaEffectData.id= 2763; name= "boosterModifyBoosterShieldPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9891; postExpression= 9892 } |> Some
      | 3345 -> { DogmaEffectData.id= 3345; name= "heavyInterdictorsSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11586; postExpression= 11587 } |> Some
      | 338 -> { DogmaEffectData.id= 338; name= "cruiserConstructionSkillBoostCruiserConstructionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2013; postExpression= 2014 } |> Some
      | 4121 -> { DogmaEffectData.id= 4121; name= "subsystemBonusCaldariOffensiveHeavyAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13748; postExpression= 13749 } |> Some
      | 435 -> { DogmaEffectData.id= 435; name= "refineryEfficiencyRefiningYieldMutatorPostPercentRefiningYieldPercentageChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2421; postExpression= 2422 } |> Some
      | 4412 -> { DogmaEffectData.id= 4412; name= "subsystemBonusJumpHarmonics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14465; postExpression= 14466 } |> Some
      | 47 -> { DogmaEffectData.id= 47; name= "cargoScan"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 403 } |> Some
      | 4897 -> { DogmaEffectData.id= 4897; name= "shipBonusDroneArmorHitpointsGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15800; postExpression= 15801 } |> Some
      | 4994 -> { DogmaEffectData.id= 4994; name= "shipArmorEMResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16063; postExpression= 16064 } |> Some
      | 5188 -> { DogmaEffectData.id= 5188; name= "trackingSpeedBonusEffectHybrids"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16507; postExpression= 16508 } |> Some
      | 5285 -> { DogmaEffectData.id= 5285; name= "battlecruiserSkillLevelPreMulShipBonusABC2Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16759; postExpression= 16760 } |> Some
      | 532 -> { DogmaEffectData.id= 532; name= "gallenteIndustrialSkillLevelPreMulShipBonusGIShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2830; postExpression= 2831 } |> Some
      | 5382 -> { DogmaEffectData.id= 5382; name= "shipBonusMETOptimalAC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16958; postExpression= 16959 } |> Some
      | 5479 -> { DogmaEffectData.id= 5479; name= "shipBonusMineralBayGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17206; postExpression= 17207 } |> Some
      | 5673 -> { DogmaEffectData.id= 5673; name= "interceptor2ProjectileDamage"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17647; postExpression= 17648 } |> Some
      | 5867 -> { DogmaEffectData.id= 5867; name= "shipBonusMissileExplosionDelayPirateFaction2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18126; postExpression= 18127 } |> Some
      | 6061 -> { DogmaEffectData.id= 6061; name= "shipBonusLightDroneArmorHPGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18625; postExpression= 18626 } |> Some
      | 6352 -> { DogmaEffectData.id= 6352; name= "roleBonusWDRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19216; postExpression= 19217 } |> Some
      | 6449 -> { DogmaEffectData.id= 6449; name= "structureBallisticControlSystem"; description= ""; displayName= ""; effectCategory= 4; preExpression= 59; postExpression= 59 } |> Some
      | 6546 -> { DogmaEffectData.id= 6546; name= "shipBonusForceAuxiliaryC2ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6740 -> { DogmaEffectData.id= 6740; name= "industrialCommandShipSkillLevelMultiplierICS4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12745; postExpression= 12746 } |> Some
      | 6837 -> { DogmaEffectData.id= 6837; name= "rigCopyTimeBonus"; description= "Structure Rig Time effect on Copying"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6934 -> { DogmaEffectData.id= 6934; name= "shipMaxLockedTargetsBonusAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 798; postExpression= 800 } |> Some
      | 7031 -> { DogmaEffectData.id= 7031; name= "shipBonusHeavyMissileKineticDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19392; postExpression= 19393 } |> Some
      | 726 -> { DogmaEffectData.id= 726; name= "shipBonusCargo2GI"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3547; postExpression= 3548 } |> Some
      | _ -> None