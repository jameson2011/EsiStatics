namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects91=
    let getDogmaEffect id = 
      match id with 
      | 1061 -> { DogmaEffectData.id= 1061; name= "eliteBonusHeavyGunshipHybridDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4672; postExpression= 4673 } |> Some
      | 1158 -> { DogmaEffectData.id= 1158; name= "controlTowerTrackingArrayProjectileOptimalBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5030; postExpression= 5031 } |> Some
      | 1255 -> { DogmaEffectData.id= 1255; name= "setBonusBloodraider"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5342; postExpression= 5343 } |> Some
      | 1449 -> { DogmaEffectData.id= 1449; name= "ewSkillRsdFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5933; postExpression= 5934 } |> Some
      | 1643 -> { DogmaEffectData.id= 1643; name= "armoredCommandMindlink"; description= "Automatically generated effect"; displayName= "ArmoredCommandMindlink"; effectCategory= 0; preExpression= 6517; postExpression= 6518 } |> Some
      | 1740 -> { DogmaEffectData.id= 1740; name= "dataMiningSkillMultiplierFixed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6782; postExpression= 6783 } |> Some
      | 2128 -> { DogmaEffectData.id= 2128; name= "passiveKineticShieldResonanceBonusGroupArmorHardener2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7997; postExpression= 7998 } |> Some
      | 2613 -> { DogmaEffectData.id= 2613; name= "eliteBonusGunshipLaserDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9471; postExpression= 9472 } |> Some
      | 2710 -> { DogmaEffectData.id= 2710; name= "drawbackPowerNeedGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9746; postExpression= 9747 } |> Some
      | 2807 -> { DogmaEffectData.id= 2807; name= "maxRangeBonusEffectLasersMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9971; postExpression= 9972 } |> Some
      | 2904 -> { DogmaEffectData.id= 2904; name= "missileExplosiveDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10269; postExpression= 10270 } |> Some
      | 3001 -> { DogmaEffectData.id= 3001; name= "overloadRofBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 10567; postExpression= 10568 } |> Some
      | 3098 -> { DogmaEffectData.id= 3098; name= "controlTowerGenericHullKineticResistanceBonusProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10885; postExpression= 10886 } |> Some
      | 3195 -> { DogmaEffectData.id= 3195; name= "thermodynamicsSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11169; postExpression= 11170 } |> Some
      | 3486 -> { DogmaEffectData.id= 3486; name= "shipBonusSmallEnergyTurretDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11982; postExpression= 11983 } |> Some
      | 3583 -> { DogmaEffectData.id= 3583; name= "targetMaxTargetRangeAndScanResolutionBonusAssistance"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12285; postExpression= 12286 } |> Some
      | 3680 -> { DogmaEffectData.id= 3680; name= "freighterAgilityBonusC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12591; postExpression= 12592 } |> Some
      | 3874 -> { DogmaEffectData.id= 3874; name= "subsystemBonusCaldariPropulsionABMWDCapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13113; postExpression= 13114 } |> Some
      | 3971 -> { DogmaEffectData.id= 3971; name= "subsystemBonusMinmatarDefensiveShieldBoostCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13307; postExpression= 13308 } |> Some
      | 4068 -> { DogmaEffectData.id= 4068; name= "subsystemBonusMinmatarDefensiveDroneCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13607; postExpression= 13608 } |> Some
      | 4165 -> { DogmaEffectData.id= 4165; name= "shipBonusScanProbeStrengthCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13847; postExpression= 13848 } |> Some
      | 4262 -> { DogmaEffectData.id= 4262; name= "subsystemBonusGallenteEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14125; postExpression= 14126 } |> Some
      | 4359 -> { DogmaEffectData.id= 4359; name= "subsystemBonusAmarrOffensiveHeavyMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14345; postExpression= 14346 } |> Some
      | 4456 -> { DogmaEffectData.id= 4456; name= "federationsetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14612; postExpression= 14613 } |> Some
      | 4650 -> { DogmaEffectData.id= 4650; name= "shipBonusArmorEMandExpResistance2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15161; postExpression= 15162 } |> Some
      | 479 -> { DogmaEffectData.id= 479; name= "shipDroneRangeBonusGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2581; postExpression= 2582 } |> Some
      | 4844 -> { DogmaEffectData.id= 4844; name= "shipStasisWebSpeedFactorBonusBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15645; postExpression= 15646 } |> Some
      | 4941 -> { DogmaEffectData.id= 4941; name= "shipHybridDamageBonusCF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15929; postExpression= 15930 } |> Some
      | 5038 -> { DogmaEffectData.id= 5038; name= "shipBonusArchCycleAF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16172; postExpression= 16173 } |> Some
      | 5329 -> { DogmaEffectData.id= 5329; name= "shipBonusDroneShieldHitpointsABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16859; postExpression= 16860 } |> Some
      | 5620 -> { DogmaEffectData.id= 5620; name= "shipBonusRHMLROFMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17544; postExpression= 17545 } |> Some
      | 5717 -> { DogmaEffectData.id= 5717; name= "implantSetWarpSpeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17738; postExpression= 17739 } |> Some
      | 5814 -> { DogmaEffectData.id= 5814; name= "shipBonusKineticMissileDamageGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17993; postExpression= 17994 } |> Some
      | 5911 -> { DogmaEffectData.id= 5911; name= "onlineJumpDriveConsumptionAmountBonusPercentage"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12154; postExpression= 12155 } |> Some
      | 6008 -> { DogmaEffectData.id= 6008; name= "shipHeatDamageAmarrTacticalDestroyer3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18510; postExpression= 18511 } |> Some
      | 6202 -> { DogmaEffectData.id= 6202; name= "siegeWarfareShieldCapacityBonusReplacer"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6299 -> { DogmaEffectData.id= 6299; name= "shipBonusEnergyNeutFalloffAC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19132; postExpression= 19133 } |> Some
      | 6396 -> { DogmaEffectData.id= 6396; name= "skillStructureMissileDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6590 -> { DogmaEffectData.id= 6590; name= "skillMultiplierShipBonusSupercarrierMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6687 -> { DogmaEffectData.id= 6687; name= "npcEntityRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6881 -> { DogmaEffectData.id= 6881; name= "shipBonusLargeMissileFlightTimeCB1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6978 -> { DogmaEffectData.id= 6978; name= "rigMoonSpewRadBonus"; description= "moon drill spew radius bonus"; displayName= "Moon Asteroid Belt Radius Bonus"; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7075 -> { DogmaEffectData.id= 7075; name= "mediumDisintegratorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19473; postExpression= 19474 } |> Some
      | 7172 -> { DogmaEffectData.id= 7172; name= "shipBonusMutadaptiveRemoteRepCapNeedeliteBonusLogisitics1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19725; postExpression= 19726 } |> Some
      | 867 -> { DogmaEffectData.id= 867; name= "missileFlightTimeAndDamage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 3996; postExpression= 3997 } |> Some
      | 91 -> { DogmaEffectData.id= 91; name= "energyWeaponDamageMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 668; postExpression= 671 } |> Some
      | _ -> None