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
      | 2904 -> { DogmaEffectData.id= 2904; name= "missileExplosiveDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10269; postExpression= 10270 } |> Some
      | 3001 -> { DogmaEffectData.id= 3001; name= "overloadRofBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 10567; postExpression= 10568 } |> Some
      | 3195 -> { DogmaEffectData.id= 3195; name= "thermodynamicsSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11169; postExpression= 11170 } |> Some
      | 3680 -> { DogmaEffectData.id= 3680; name= "freighterAgilityBonusC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12591; postExpression= 12592 } |> Some
      | 4165 -> { DogmaEffectData.id= 4165; name= "shipBonusScanProbeStrengthCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13847; postExpression= 13848 } |> Some
      | 4262 -> { DogmaEffectData.id= 4262; name= "subsystemBonusGallenteEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14125; postExpression= 14126 } |> Some
      | 4359 -> { DogmaEffectData.id= 4359; name= "subsystemBonusAmarrOffensiveHeavyMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14345; postExpression= 14346 } |> Some
      | 4456 -> { DogmaEffectData.id= 4456; name= "federationsetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14612; postExpression= 14613 } |> Some
      | 4941 -> { DogmaEffectData.id= 4941; name= "shipHybridDamageBonusCF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15929; postExpression= 15930 } |> Some
      | 5620 -> { DogmaEffectData.id= 5620; name= "shipBonusRHMLROFMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17544; postExpression= 17545 } |> Some
      | 5717 -> { DogmaEffectData.id= 5717; name= "implantSetWarpSpeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17738; postExpression= 17739 } |> Some
      | 5814 -> { DogmaEffectData.id= 5814; name= "shipBonusKineticMissileDamageGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17993; postExpression= 17994 } |> Some
      | 5911 -> { DogmaEffectData.id= 5911; name= "onlineJumpDriveConsumptionAmountBonusPercentage"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12154; postExpression= 12155 } |> Some
      | 6008 -> { DogmaEffectData.id= 6008; name= "shipHeatDamageAmarrTacticalDestroyer3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18510; postExpression= 18511 } |> Some
      | 6299 -> { DogmaEffectData.id= 6299; name= "shipBonusEnergyNeutFalloffAC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19132; postExpression= 19133 } |> Some
      | 6396 -> { DogmaEffectData.id= 6396; name= "skillStructureMissileDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6590 -> { DogmaEffectData.id= 6590; name= "skillMultiplierShipBonusSupercarrierMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6687 -> { DogmaEffectData.id= 6687; name= "npcEntityRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6881 -> { DogmaEffectData.id= 6881; name= "shipBonusLargeMissileFlightTimeCB1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6978 -> { DogmaEffectData.id= 6978; name= "rigMoonSpewRadBonus"; description= "moon drill spew radius bonus"; displayName= "Moon Asteroid Belt Radius Bonus"; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7075 -> { DogmaEffectData.id= 7075; name= "mediumDisintegratorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19473; postExpression= 19474 } |> Some
      | 7172 -> { DogmaEffectData.id= 7172; name= "shipBonusMutadaptiveRemoteRepCapNeedeliteBonusLogisitics1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19725; postExpression= 19726 } |> Some
      | 91 -> { DogmaEffectData.id= 91; name= "energyWeaponDamageMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 668; postExpression= 671 } |> Some
      | _ -> None