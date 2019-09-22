namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects68=
    let getDogmaEffect id = 
      match id with 
      | 1232 -> { DogmaEffectData.id= 1232; name= "shipProjectileRofPirateCruiser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5283; postExpression= 5284 } |> Some
      | 1814 -> { DogmaEffectData.id= 1814; name= "shipShieldKineticResistanceCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6998; postExpression= 6999 } |> Some
      | 1911 -> { DogmaEffectData.id= 1911; name= "eliteReconBonusGravimetricStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7335; postExpression= 7336 } |> Some
      | 2008 -> { DogmaEffectData.id= 2008; name= "cynosuralDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7618; postExpression= 7619 } |> Some
      | 2105 -> { DogmaEffectData.id= 2105; name= "emArmorCompensationHardeningBonusGroupArmorCoating"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7924; postExpression= 7925 } |> Some
      | 2590 -> { DogmaEffectData.id= 2590; name= "naniteControlSkillBoostBoosterAttributeModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9409; postExpression= 9410 } |> Some
      | 2881 -> { DogmaEffectData.id= 2881; name= "missileEMDmgBonusCruise3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10191; postExpression= 10192 } |> Some
      | 3172 -> { DogmaEffectData.id= 3172; name= "droneArmorDamageBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11082; postExpression= 11083 } |> Some
      | 3366 -> { DogmaEffectData.id= 3366; name= "shipRemoteSensorDampenerCapNeedGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11635; postExpression= 11636 } |> Some
      | 3657 -> { DogmaEffectData.id= 3657; name= "shipScanResolutionBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 3427; postExpression= 3428 } |> Some
      | 3851 -> { DogmaEffectData.id= 3851; name= "subsystemSkillLevelMinmatarPropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13071; postExpression= 13072 } |> Some
      | 4045 -> { DogmaEffectData.id= 4045; name= "systemSmartBombRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13535; postExpression= 13536 } |> Some
      | 4336 -> { DogmaEffectData.id= 4336; name= "subsystemBonusCaldariOffensive3EwStrengthMagn"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14284; postExpression= 14285 } |> Some
      | 456 -> { DogmaEffectData.id= 456; name= "shipTargetRangeBonusMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2511; postExpression= 2512 } |> Some
      | 4821 -> { DogmaEffectData.id= 4821; name= "bcLargeHybridTurretPowerNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15560; postExpression= 15561 } |> Some
      | 4918 -> { DogmaEffectData.id= 4918; name= "setMassAndAgilityAndSpeed"; description= ""; displayName= ""; effectCategory= 1; preExpression= 15846; postExpression= 15847 } |> Some
      | 5015 -> { DogmaEffectData.id= 5015; name= "shipBonusEwRemoteSensorDampenerMaxTargetRangeBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16117; postExpression= 16118 } |> Some
      | 5209 -> { DogmaEffectData.id= 5209; name= "shipWebVelocityBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16566; postExpression= 16567 } |> Some
      | 5306 -> { DogmaEffectData.id= 5306; name= "shipRocketKineticDmgCD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16813; postExpression= 16814 } |> Some
      | 5403 -> { DogmaEffectData.id= 5403; name= "shipMissileHeavyVelocityABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16999; postExpression= 17000 } |> Some
      | 5500 -> { DogmaEffectData.id= 5500; name= "eliteBonusCommandShipsHeavyMissileExplosionRadiusCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17259; postExpression= 17260 } |> Some
      | 553 -> { DogmaEffectData.id= 553; name= "shipHTTrackingBonusGB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2904; postExpression= 2905 } |> Some
      | 5888 -> { DogmaEffectData.id= 5888; name= "eliteIndustrialArmorResists2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18168; postExpression= 18169 } |> Some
      | 6373 -> { DogmaEffectData.id= 6373; name= "armorRepairProjectorFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8021; postExpression= 8022 } |> Some
      | 6470 -> { DogmaEffectData.id= 6470; name= "remoteECMFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 650 -> { DogmaEffectData.id= 650; name= "anchorLift"; description= ""; displayName= "unanchoring"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 6567 -> { DogmaEffectData.id= 6567; name= "moduleBonusNetworkedSensorArray"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6664 -> { DogmaEffectData.id= 6664; name= "skillBonusDroneSharpshooting"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6858 -> { DogmaEffectData.id= 6858; name= "shipBonusForceAuxiliaryA1NosferatuDrainAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6955 -> { DogmaEffectData.id= 6955; name= "subsystemRemoteShieldBoostFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8015; postExpression= 8016 } |> Some
      | 7052 -> { DogmaEffectData.id= 7052; name= "roleBonusFlagCruiserTargetPainterModifications"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19409; postExpression= 19410 } |> Some
      | _ -> None