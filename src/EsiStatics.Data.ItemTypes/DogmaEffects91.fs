namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects91=
    let getDogmaEffect id = 
      match id with 
      | 1061 -> { DogmaEffectData.id= 1061; name= "eliteBonusHeavyGunshipHybridDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1158 -> { DogmaEffectData.id= 1158; name= "controlTowerTrackingArrayProjectileOptimalBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1255 -> { DogmaEffectData.id= 1255; name= "setBonusBloodraider"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1449 -> { DogmaEffectData.id= 1449; name= "ewSkillRsdFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1643 -> { DogmaEffectData.id= 1643; name= "armoredCommandMindlink"; description= "Automatically generated effect"; displayName= "ArmoredCommandMindlink"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2904 -> { DogmaEffectData.id= 2904; name= "missileExplosiveDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3001 -> { DogmaEffectData.id= 3001; name= "overloadRofBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 0; postExpression= 0 } |> Some
      | 3195 -> { DogmaEffectData.id= 3195; name= "thermodynamicsSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3680 -> { DogmaEffectData.id= 3680; name= "freighterAgilityBonusC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4165 -> { DogmaEffectData.id= 4165; name= "shipBonusScanProbeStrengthCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4262 -> { DogmaEffectData.id= 4262; name= "subsystemBonusGallenteEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4359 -> { DogmaEffectData.id= 4359; name= "subsystemBonusAmarrOffensiveHeavyMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4456 -> { DogmaEffectData.id= 4456; name= "federationsetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4941 -> { DogmaEffectData.id= 4941; name= "shipHybridDamageBonusCF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5620 -> { DogmaEffectData.id= 5620; name= "shipBonusRHMLROFMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5717 -> { DogmaEffectData.id= 5717; name= "implantSetWarpSpeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5814 -> { DogmaEffectData.id= 5814; name= "shipBonusKineticMissileDamageGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5911 -> { DogmaEffectData.id= 5911; name= "onlineJumpDriveConsumptionAmountBonusPercentage"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6008 -> { DogmaEffectData.id= 6008; name= "shipHeatDamageAmarrTacticalDestroyer3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6299 -> { DogmaEffectData.id= 6299; name= "shipBonusEnergyNeutFalloffAC3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6396 -> { DogmaEffectData.id= 6396; name= "skillStructureMissileDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6590 -> { DogmaEffectData.id= 6590; name= "skillMultiplierShipBonusSupercarrierMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6687 -> { DogmaEffectData.id= 6687; name= "npcEntityRemoteArmorRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6881 -> { DogmaEffectData.id= 6881; name= "shipBonusLargeMissileFlightTimeCB1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6978 -> { DogmaEffectData.id= 6978; name= "rigMoonSpewRadBonus"; description= "moon drill spew radius bonus"; displayName= "Moon Asteroid Belt Radius Bonus"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7075 -> { DogmaEffectData.id= 7075; name= "mediumDisintegratorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7172 -> { DogmaEffectData.id= 7172; name= "shipBonusMutadaptiveRemoteRepCapNeedeliteBonusLogisitics1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8045 -> { DogmaEffectData.id= 8045; name= " mediumVortonProjectorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 91 -> { DogmaEffectData.id= 91; name= "energyWeaponDamageMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None