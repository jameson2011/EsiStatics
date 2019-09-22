namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects38=
    let getDogmaEffect id = 
      match id with 
      | 1008 -> { DogmaEffectData.id= 1008; name= "selfT2SmallProjectileArtyDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4462; postExpression= 4463 } |> Some
      | 1590 -> { DogmaEffectData.id= 1590; name= "missileSkillAoeVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6278; postExpression= 6279 } |> Some
      | 232 -> { DogmaEffectData.id= 232; name= "evasiveManuveringSkillBoostAgilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1541; postExpression= 1542 } |> Some
      | 2851 -> { DogmaEffectData.id= 2851; name= "missileDMGBonusPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3657; postExpression= 3658 } |> Some
      | 3336 -> { DogmaEffectData.id= 3336; name= "shipArmorExplosiveResistanceMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11558; postExpression= 11559 } |> Some
      | 3530 -> { DogmaEffectData.id= 3530; name= "eliteBonusBlackOpsAgiliy1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12145; postExpression= 12146 } |> Some
      | 38 -> { DogmaEffectData.id= 38; name= "empWave"; description= ""; displayName= ""; effectCategory= 1; preExpression= 288; postExpression= 131 } |> Some
      | 4209 -> { DogmaEffectData.id= 4209; name= "subsystemSkillLevelCaldariOffensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13992; postExpression= 13993 } |> Some
      | 4403 -> { DogmaEffectData.id= 4403; name= "subSystemBonusGallenteElectronic2TractorBeamVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14442; postExpression= 14443 } |> Some
      | 4985 -> { DogmaEffectData.id= 4985; name= "relationsAllyCostSkillBoost"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16043; postExpression= 16044 } |> Some
      | 5276 -> { DogmaEffectData.id= 5276; name= "destroyerSkillLevelPreMulShipBonusAD1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16721; postExpression= 16722 } |> Some
      | 5373 -> { DogmaEffectData.id= 5373; name= "deepCoreMiningSkillBoostDamageCloudChanceReductionMul"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 3140; postExpression= 3142 } |> Some
      | 5470 -> { DogmaEffectData.id= 5470; name= "shipBonusAgilityGI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17179; postExpression= 17180 } |> Some
      | 5567 -> { DogmaEffectData.id= 5567; name= "subSystemBonusGallenteDefensiveSkirmishWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17417; postExpression= 17418 } |> Some
      | 6052 -> { DogmaEffectData.id= 6052; name= "shipBonusMediumDroneDamageMultiplierGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18607; postExpression= 18608 } |> Some
      | 6149 -> { DogmaEffectData.id= 6149; name= "shipSHTRoFGallenteTacticalDestroyer1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18847; postExpression= 18848 } |> Some
      | 6246 -> { DogmaEffectData.id= 6246; name= "shipBonusEnergyNosFalloffAD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19007; postExpression= 19008 } |> Some
      | 6343 -> { DogmaEffectData.id= 6343; name= "shipBonusExplosiveArmorResistanceGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19210; postExpression= 19211 } |> Some
      | 6440 -> { DogmaEffectData.id= 6440; name= "fighterAbilityAfterburner"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6537 -> { DogmaEffectData.id= 6537; name= "shipBonusRole1CommandBurstCPUBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6634 -> { DogmaEffectData.id= 6634; name= "shipBonusTitanA1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6731 -> { DogmaEffectData.id= 6731; name= "moduleBonusAfterburner"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6828 -> { DogmaEffectData.id= 6828; name= "rigStructureManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of structures"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6925 -> { DogmaEffectData.id= 6925; name= "subsystemBonusGallenteOffensive2DroneVeloTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14103; postExpression= 14104 } |> Some
      | 7022 -> { DogmaEffectData.id= 7022; name= "structureShieldCapacityBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 199; postExpression= 201 } |> Some
      | 7119 -> { DogmaEffectData.id= 7119; name= "eliteBonusReconShip3PCTdamagePerCycle"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19567; postExpression= 19568 } |> Some
      | 7216 -> { DogmaEffectData.id= 7216; name= "shipDmgMultiMaxEliteGunship1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19820; postExpression= 19821 } |> Some
      | _ -> None