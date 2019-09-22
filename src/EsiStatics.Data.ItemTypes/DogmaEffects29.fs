namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects29=
    let getDogmaEffect id = 
      match id with 
      | 1290 -> { DogmaEffectData.id= 1290; name= "amarrIndustrialSkillLevelPreMulShipBonusAI22Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5442; postExpression= 5443 } |> Some
      | 1387 -> { DogmaEffectData.id= 1387; name= "leadershipCpuBonus"; description= "Automatically generated effect"; displayName= "logisticsCPUReduction"; effectCategory= 0; preExpression= 5743; postExpression= 5744 } |> Some
      | 1581 -> { DogmaEffectData.id= 1581; name= "jumpDriveSkillsRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6321; postExpression= 6322 } |> Some
      | 1969 -> { DogmaEffectData.id= 1969; name= "shipBonusRemoteArmorRepairCapNeedGC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7515; postExpression= 7516 } |> Some
      | 223 -> { DogmaEffectData.id= 223; name= "navigationVelocityBonusPostPercentMaxVelocityLocationShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1494; postExpression= 1495 } |> Some
      | 2648 -> { DogmaEffectData.id= 2648; name= "eliteBonusHeavyGunshipHeavyAssaultMissileLaunhcerRof2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9576; postExpression= 9577 } |> Some
      | 2745 -> { DogmaEffectData.id= 2745; name= "boosterCapacitorCapacityPenalty"; description= "Automatically generated effect"; displayName= "Capacitor Capacity Penalty"; effectCategory= 0; preExpression= 9845; postExpression= 9846 } |> Some
      | 3036 -> { DogmaEffectData.id= 3036; name= "skillBombDeploymentModuleReactivationDelayBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10682; postExpression= 10683 } |> Some
      | 320 -> { DogmaEffectData.id= 320; name= "caldariTechCaldariTechMutatorPostPercentCaldariTechTimePercentLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1907; postExpression= 1908 } |> Some
      | 3327 -> { DogmaEffectData.id= 3327; name= "oreCapitalShipSkillMultiplier4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11543; postExpression= 11544 } |> Some
      | 3424 -> { DogmaEffectData.id= 3424; name= "eliteBonusViolatorsLargeHybridTurretTracking1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11822; postExpression= 11823 } |> Some
      | 3521 -> { DogmaEffectData.id= 3521; name= "skillNaniteOperationRepairCost"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12099; postExpression= 12100 } |> Some
      | 3618 -> { DogmaEffectData.id= 3618; name= "scriptMassBonusPercentageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12426; postExpression= 12427 } |> Some
      | 417 -> { DogmaEffectData.id= 417; name= "smugglingSkillBoostSmugglingChanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2348; postExpression= 2349 } |> Some
      | 4200 -> { DogmaEffectData.id= 4200; name= "subsystemSkillLevelGallenteElectronic2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13947; postExpression= 13948 } |> Some
      | 4394 -> { DogmaEffectData.id= 4394; name= "shipBonusEliteCover2TorpedoEMDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14424; postExpression= 14425 } |> Some
      | 4491 -> { DogmaEffectData.id= 4491; name= "superWeaponGallente"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 4782 -> { DogmaEffectData.id= 4782; name= "shipBonusSmallEnergyWeaponOptimalRangeATF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15432; postExpression= 15433 } |> Some
      | 4976 -> { DogmaEffectData.id= 4976; name= "skillReactiveArmorHardenerDurationBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16016; postExpression= 16017 } |> Some
      | 514 -> { DogmaEffectData.id= 514; name= "shipSETDmgBonusAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2753; postExpression= 2754 } |> Some
      | 5170 -> { DogmaEffectData.id= 5170; name= "droneSalvageSkillBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16477; postExpression= 16478 } |> Some
      | 5267 -> { DogmaEffectData.id= 5267; name= "drawbackRepairSystemsPGNeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16696; postExpression= 16697 } |> Some
      | 5364 -> { DogmaEffectData.id= 5364; name= "armorAllRepairSystemsAmountBonusPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16927; postExpression= 16928 } |> Some
      | 5461 -> { DogmaEffectData.id= 5461; name= "shieldOperationRechargeratebonusPostPercentOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 2603; postExpression= 2604 } |> Some
      | 5558 -> { DogmaEffectData.id= 5558; name= "shipBonusSentryDroneTrackingEliteBonusHeavyGunship2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17394; postExpression= 17395 } |> Some
      | 6043 -> { DogmaEffectData.id= 6043; name= "subsystemBonusCaldariDefensiveShieldRechargeRate"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18586; postExpression= 18587 } |> Some
      | 611 -> { DogmaEffectData.id= 611; name= "gallenteBattleshipSkillLevelPreMulShipBonusGBShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3094; postExpression= 3095 } |> Some
      | 6237 -> { DogmaEffectData.id= 6237; name= "shipBonusEnergyNosFalloffRS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18989; postExpression= 18990 } |> Some
      | 6334 -> { DogmaEffectData.id= 6334; name= "eliteBonusCommandDestroyerInfo1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19192; postExpression= 19193 } |> Some
      | 6431 -> { DogmaEffectData.id= 6431; name= "fighterAbilityMissiles"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6625 -> { DogmaEffectData.id= 6625; name= "shipBonusCarrierA2SupportFighterBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6722 -> { DogmaEffectData.id= 6722; name= "roleBonusRemoteArmorRepairOptimalFalloff"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19299; postExpression= 19300 } |> Some
      | 6819 -> { DogmaEffectData.id= 6819; name= "rigAdvSmshipManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of advanced small ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6916 -> { DogmaEffectData.id= 6916; name= "subsystemSkillLevelGallenteEngineering3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13022; postExpression= 13023 } |> Some
      | 7013 -> { DogmaEffectData.id= 7013; name= "eliteBonusGunshipKineticMissileDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19373; postExpression= 19374 } |> Some
      | 708 -> { DogmaEffectData.id= 708; name= "bomberLightsRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3473; postExpression= 3474 } |> Some
      | 7110 -> { DogmaEffectData.id= 7110; name= "structureConversionRigResearchCostBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 7207 -> { DogmaEffectData.id= 7207; name= "shipArmorExpResistancePF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19802; postExpression= 19803 } |> Some
      | 999 -> { DogmaEffectData.id= 999; name= "eliteBonusGunshipShieldBoost2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4421; postExpression= 4422 } |> Some
      | _ -> None