namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects74=
    let getDogmaEffect id = 
      match id with 
      | 1723 -> { DogmaEffectData.id= 1723; name= "jumpDriveSkillsCapacitorNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6730; postExpression= 6731 } |> Some
      | 1820 -> { DogmaEffectData.id= 1820; name= "shipShieldExplosiveResistanceCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7010; postExpression= 7011 } |> Some
      | 2014 -> { DogmaEffectData.id= 2014; name= "droneMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7641; postExpression= 7642 } |> Some
      | 2111 -> { DogmaEffectData.id= 2111; name= "kineticArmorCompensationHardeningBonusGroupEnergized"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7950; postExpression= 7951 } |> Some
      | 2305 -> { DogmaEffectData.id= 2305; name= "eliteReconBonusEnergyNeutAmount2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8502; postExpression= 8503 } |> Some
      | 2402 -> { DogmaEffectData.id= 2402; name= "skillSuperWeaponDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8840; postExpression= 8841 } |> Some
      | 2693 -> { DogmaEffectData.id= 2693; name= "falloffBonusEffectLasers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9695; postExpression= 9696 } |> Some
      | 2887 -> { DogmaEffectData.id= 2887; name= "missileEMDmgBonusRocket"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10207; postExpression= 10208 } |> Some
      | 3857 -> { DogmaEffectData.id= 3857; name= "subsystemBonusAmarrPropulsionMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13079; postExpression= 13080 } |> Some
      | 4342 -> { DogmaEffectData.id= 4342; name= "subsystemBonusMinmatarCore2MaxTargetingRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14302; postExpression= 14303 } |> Some
      | 4827 -> { DogmaEffectData.id= 4827; name= "bcLargeHybridTurretCapacitorNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15588; postExpression= 15589 } |> Some
      | 5021 -> { DogmaEffectData.id= 5021; name= "shipShieldBoostRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16134; postExpression= 16135 } |> Some
      | 5215 -> { DogmaEffectData.id= 5215; name= "shipSHTTrackingSpeedBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16585; postExpression= 16586 } |> Some
      | 6088 -> { DogmaEffectData.id= 6088; name= "shipBonusHeavyAssaultMissileAllDamageMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18679; postExpression= 18680 } |> Some
      | 6185 -> { DogmaEffectData.id= 6185; name= "shipModuleRemoteHullRepairer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6379 -> { DogmaEffectData.id= 6379; name= "eliteBonusLogiFrigArmorHP2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4158; postExpression= 4159 } |> Some
      | 6476 -> { DogmaEffectData.id= 6476; name= "doomsdayAOEWeb"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6573 -> { DogmaEffectData.id= 6573; name= "skillBonusCapitalBlasterSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6670 -> { DogmaEffectData.id= 6670; name= "moduleBonusCapitalDroneScopeChip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6864 -> { DogmaEffectData.id= 6864; name= "npcBehaviorMicroWarpDrive"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6961 -> { DogmaEffectData.id= 6961; name= "subsystemBonusMinmatarOffensive3RemoteRepHeat"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14184; postExpression= 14185 } |> Some
      | 7058 -> { DogmaEffectData.id= 7058; name= "aoe_beacon_filament_cloud"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7155 -> { DogmaEffectData.id= 7155; name= "shipBonusPBC1DisintegratorDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19681; postExpression= 19682 } |> Some
      | 850 -> { DogmaEffectData.id= 850; name= "cloakingSkillBoostCloakingTargetingDelayBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3928; postExpression= 3929 } |> Some
      | _ -> None