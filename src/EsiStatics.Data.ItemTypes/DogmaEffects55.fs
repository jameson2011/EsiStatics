namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects55=
    let getDogmaEffect id = 
      match id with 
      | 1025 -> { DogmaEffectData.id= 1025; name= "shipMissileLightVelocityBonusCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4546; postExpression= 4547 } |> Some
      | 1122 -> { DogmaEffectData.id= 1122; name= "shipShieldExplosiveResistanceCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4892; postExpression= 4893 } |> Some
      | 1219 -> { DogmaEffectData.id= 1219; name= "shipEnergyVampireTransferAmountBonusAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5259; postExpression= 5260 } |> Some
      | 152 -> { DogmaEffectData.id= 152; name= "skillBoostDamageMultiplierBonus"; description= "Boost of damageMultiplierBonus by PreMul of skillLevel"; displayName= "SkillBoostDamageMultiplierBonus"; effectCategory= 0; preExpression= 1167; postExpression= 1168 } |> Some
      | 2189 -> { DogmaEffectData.id= 2189; name= "shipBonusDroneDamageMultiplierAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8158; postExpression= 8159 } |> Some
      | 2577 -> { DogmaEffectData.id= 2577; name= "armorRepairerPenaltyBoosterAttribute3"; description= "Automatically generated effect"; displayName= "Armor Repair Penalty"; effectCategory= 0; preExpression= 9302; postExpression= 9303 } |> Some
      | 2674 -> { DogmaEffectData.id= 2674; name= "shipBonusProjectileDamageBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9641; postExpression= 9642 } |> Some
      | 2771 -> { DogmaEffectData.id= 2771; name= "boosterModifyBoosterTurretOptimalPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9921; postExpression= 9922 } |> Some
      | 2868 -> { DogmaEffectData.id= 2868; name= "armorDamageAmountBonusCapitalArmorRepairers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10146; postExpression= 10147 } |> Some
      | 3159 -> { DogmaEffectData.id= 3159; name= "controlTowerGenericHullResistanceBonusCG&CGJ&ECM&EN&H&JP&L&M&P&SC&SD"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11035; postExpression= 11036 } |> Some
      | 3353 -> { DogmaEffectData.id= 3353; name= "shipMissileHeavyAssaultMissileRofCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11602; postExpression= 11603 } |> Some
      | 3450 -> { DogmaEffectData.id= 3450; name= "shipBonusStasisWebSpeedFactorGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11887; postExpression= 11888 } |> Some
      | 346 -> { DogmaEffectData.id= 346; name= "criminalConnectionsSkillBoostCriminalConnectionsMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2049; postExpression= 2050 } |> Some
      | 3547 -> { DogmaEffectData.id= 3547; name= "targetProjectileWeaponMaxRangeAndTrackingSpeedBonusHostile"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12215; postExpression= 12216 } |> Some
      | 3741 -> { DogmaEffectData.id= 3741; name= "industrialCommandShipSkillLevelMultiplierICS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12745; postExpression= 12746 } |> Some
      | 3838 -> { DogmaEffectData.id= 3838; name= "subsystemSkillLevelCaldariElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13000; postExpression= 13001 } |> Some
      | 4032 -> { DogmaEffectData.id= 4032; name= "systemTrackingLinkOptimal"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13479; postExpression= 13480 } |> Some
      | 4129 -> { DogmaEffectData.id= 4129; name= "subsystemBonusGallenteOffensiveDroneHPArmor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13766; postExpression= 13767 } |> Some
      | 4226 -> { DogmaEffectData.id= 4226; name= "subsystemBonusMinmatarElectronic2CPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14045; postExpression= 14046 } |> Some
      | 4323 -> { DogmaEffectData.id= 4323; name= "subsystemBonusAmarrOffensive3DroneHPShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14256; postExpression= 14257 } |> Some
      | 4420 -> { DogmaEffectData.id= 4420; name= "missileDMGBonus2"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14493; postExpression= 14494 } |> Some
      | 443 -> { DogmaEffectData.id= 443; name= "learningLearningBonusPostPercentCharismaChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2458; postExpression= 2459 } |> Some
      | 4517 -> { DogmaEffectData.id= 4517; name= "fighterBomberTorpedoEmDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14792; postExpression= 14793 } |> Some
      | 5099 -> { DogmaEffectData.id= 5099; name= "passiveExplosiveArmorResonanceBonusGroupArmorHardener3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 7869; postExpression= 7870 } |> Some
      | 5293 -> { DogmaEffectData.id= 5293; name= "shipLaserCapNeed2AD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16787; postExpression= 16788 } |> Some
      | 5390 -> { DogmaEffectData.id= 5390; name= "shipBonusDroneMWDboostGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16972; postExpression= 16973 } |> Some
      | 55 -> { DogmaEffectData.id= 55; name= "targetHostiles"; description= ""; displayName= ""; effectCategory= 1; preExpression= 131; postExpression= 473 } |> Some
      | 5584 -> { DogmaEffectData.id= 5584; name= "marauderModeEffect7"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17452; postExpression= 17453 } |> Some
      | 5778 -> { DogmaEffectData.id= 5778; name= "shipMissileRoFMF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 5304; postExpression= 5305 } |> Some
      | 6069 -> { DogmaEffectData.id= 6069; name= "shipBonusHeavyMissileExpDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 4202; postExpression= 4203 } |> Some
      | 6166 -> { DogmaEffectData.id= 6166; name= "shipBonusWDFGnullPenalties"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18884; postExpression= 18885 } |> Some
      | 6360 -> { DogmaEffectData.id= 6360; name= "shipRocketEMThermKinDmgMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16641; postExpression= 16642 } |> Some
      | 6554 -> { DogmaEffectData.id= 6554; name= "fighterAbilityKamikaze"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6651 -> { DogmaEffectData.id= 6651; name= "shipModuleAncillaryRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6845 -> { DogmaEffectData.id= 6845; name= "shipBonusCommandDestroyerRole1DefenderBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6942 -> { DogmaEffectData.id= 6942; name= "subsystemBonusMinmatarDefensive2HardenerHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7039 -> { DogmaEffectData.id= 7039; name= "structureHiddenMissileDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7136 -> { DogmaEffectData.id= 7136; name= "massEntanglerEffect2"; description= ""; displayName= ""; effectCategory= 1; preExpression= 19607; postExpression= 19608 } |> Some
      | 734 -> { DogmaEffectData.id= 734; name= "amarrBattleshipSkillLevelPreMulShipBonusAB2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3565; postExpression= 3566 } |> Some
      | 928 -> { DogmaEffectData.id= 928; name= "gallenteCruiserSkillLevelPreMulShipBonusGC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4222; postExpression= 4223 } |> Some
      | _ -> None