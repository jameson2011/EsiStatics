namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects57=
    let getDogmaEffect id = 
      match id with 
      | 1124 -> { DogmaEffectData.id= 1124; name= "shipShieldThermalResistanceCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4896; postExpression= 4897 } |> Some
      | 1221 -> { DogmaEffectData.id= 1221; name= "shipStasisWebRangeBonusMB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5263; postExpression= 5264 } |> Some
      | 1318 -> { DogmaEffectData.id= 1318; name= "ewSkillScanStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5526; postExpression= 5527 } |> Some
      | 1803 -> { DogmaEffectData.id= 1803; name= "shipMissileRocketVelocityBonusCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6972; postExpression= 6973 } |> Some
      | 2191 -> { DogmaEffectData.id= 2191; name= "shipMissileVelocityDF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8168; postExpression= 8169 } |> Some
      | 251 -> { DogmaEffectData.id= 251; name= "hullUpgradesSkillBoostHullHpBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1631; postExpression= 1632 } |> Some
      | 2870 -> { DogmaEffectData.id= 2870; name= "defenderMissileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10160; postExpression= 10161 } |> Some
      | 2967 -> { DogmaEffectData.id= 2967; name= "skillTriageModuleConsumptionQuantityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10459; postExpression= 10460 } |> Some
      | 3064 -> { DogmaEffectData.id= 3064; name= "controlTowerGenericHullEmResistanceBonusCynoGenerator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10743; postExpression= 10744 } |> Some
      | 3355 -> { DogmaEffectData.id= 3355; name= "eliteBonusHeavyInterdictorHeavyMissileVelocityBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11606; postExpression= 11607 } |> Some
      | 3452 -> { DogmaEffectData.id= 3452; name= "shipBonusAoeVelocityCruiseMissileCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11891; postExpression= 11892 } |> Some
      | 348 -> { DogmaEffectData.id= 348; name= "diplomacySkillBoostDiplomacyMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2058; postExpression= 2059 } |> Some
      | 3549 -> { DogmaEffectData.id= 3549; name= "targetEnergyWeaponMaxRangeAndTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12219; postExpression= 12220 } |> Some
      | 3743 -> { DogmaEffectData.id= 3743; name= "industrialCommandShipSkillLevelMultiplierICS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12752; postExpression= 12753 } |> Some
      | 3840 -> { DogmaEffectData.id= 3840; name= "subsystemSkillLevelAmarrEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13012; postExpression= 13013 } |> Some
      | 4034 -> { DogmaEffectData.id= 4034; name= "systemOverloadArmor"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13488; postExpression= 13489 } |> Some
      | 4131 -> { DogmaEffectData.id= 4131; name= "subsystemBonusGallenteDefensiveDroneHPHull"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13770; postExpression= 13771 } |> Some
      | 4325 -> { DogmaEffectData.id= 4325; name= "subsystemBonusAmarrOffensive3DroneHPHull"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14260; postExpression= 14261 } |> Some
      | 4422 -> { DogmaEffectData.id= 4422; name= "missileDMGBonus2"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14501; postExpression= 14502 } |> Some
      | 445 -> { DogmaEffectData.id= 445; name= "energyManagementCapacitorBonusPostPercentCapacityLocationShipGroupCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2468; postExpression= 2469 } |> Some
      | 4519 -> { DogmaEffectData.id= 4519; name= "fighterBomberTorpedoKineticDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14800; postExpression= 14801 } |> Some
      | 4810 -> { DogmaEffectData.id= 4810; name= "ecmLadarStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15500; postExpression= 15501 } |> Some
      | 4907 -> { DogmaEffectData.id= 4907; name= "modifyShieldArmorResonancePostPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 15819; postExpression= 15820 } |> Some
      | 5101 -> { DogmaEffectData.id= 5101; name= "passiveEmArmorResonanceBonusGroupArmorHardener3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 7865; postExpression= 7866 } |> Some
      | 5295 -> { DogmaEffectData.id= 5295; name= "shipBonusDroneDamageMultiplierAD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16791; postExpression= 16792 } |> Some
      | 5392 -> { DogmaEffectData.id= 5392; name= "shipMissileKineticDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16976; postExpression= 16977 } |> Some
      | 542 -> { DogmaEffectData.id= 542; name= "shipCapNeedBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2865; postExpression= 2866 } |> Some
      | 5586 -> { DogmaEffectData.id= 5586; name= "marauderModeEffect9"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17460; postExpression= 17461 } |> Some
      | 57 -> { DogmaEffectData.id= 57; name= "shieldCapacityMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 485; postExpression= 486 } |> Some
      | 6071 -> { DogmaEffectData.id= 6071; name= "shipBonusHeavyMissileThermDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18641; postExpression= 18642 } |> Some
      | 6362 -> { DogmaEffectData.id= 6362; name= "roleBonusStasisRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14666; postExpression= 14667 } |> Some
      | 6556 -> { DogmaEffectData.id= 6556; name= "moduleBonusDroneDamageAmplifier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 59; postExpression= 59 } |> Some
      | 6653 -> { DogmaEffectData.id= 6653; name= "shipBonusTitanA2CapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6944 -> { DogmaEffectData.id= 6944; name= "subsystemBonusGallenteDefensive3ArmorRepHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7041 -> { DogmaEffectData.id= 7041; name= "flagCruiserSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9016; postExpression= 9017 } |> Some
      | 7138 -> { DogmaEffectData.id= 7138; name= "massEntanglerEffect3"; description= ""; displayName= ""; effectCategory= 1; preExpression= 19613; postExpression= 19614 } |> Some
      | 736 -> { DogmaEffectData.id= 736; name= "shipBonusCapCapAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3567; postExpression= 3568 } |> Some
      | 930 -> { DogmaEffectData.id= 930; name= "shipCargoCapacityGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4228; postExpression= 4229 } |> Some
      | _ -> None