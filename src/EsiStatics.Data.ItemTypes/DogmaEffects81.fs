namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects81=
    let getDogmaEffect id = 
      match id with 
      | 1730 -> { DogmaEffectData.id= 1730; name= "droneDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2118 -> { DogmaEffectData.id= 2118; name= "modifyActiveShieldResonanceAndNullifyPassiveResonance"; description= ""; displayName= ""; effectCategory= 1; preExpression= 7968; postExpression= 7969 } |> Some
      | 2215 -> { DogmaEffectData.id= 2215; name= "shipBonusPirateFrigateProjDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2312 -> { DogmaEffectData.id= 2312; name= "disallowOffensiveActChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2409 -> { DogmaEffectData.id= 2409; name= "eliteBonusInterdictorsMissileEMDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8863; postExpression= 8864 } |> Some
      | 2603 -> { DogmaEffectData.id= 2603; name= "shipBonusExplosiveShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2700 -> { DogmaEffectData.id= 2700; name= "trackingSpeedMultiplierEffectHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9712; postExpression= 9713 } |> Some
      | 2797 -> { DogmaEffectData.id= 2797; name= "projectileWeaponSpeedMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2894 -> { DogmaEffectData.id= 2894; name= "missileThermalDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3088 -> { DogmaEffectData.id= 3088; name= "controlTowerGenericHullEmResistanceBonusLaser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10845; postExpression= 10846 } |> Some
      | 3282 -> { DogmaEffectData.id= 3282; name= "industrialCoreEffectOLD"; description= ""; displayName= ""; effectCategory= 1; preExpression= 11411; postExpression= 11412 } |> Some
      | 3379 -> { DogmaEffectData.id= 3379; name= "implantHardwiringABcapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3476 -> { DogmaEffectData.id= 3476; name= "shipBonusMWDCapNeedMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11962; postExpression= 11963 } |> Some
      | 3573 -> { DogmaEffectData.id= 3573; name= "shipBonusTrackingLinkMaxRangeBonusMC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12278; postExpression= 12279 } |> Some
      | 3670 -> { DogmaEffectData.id= 3670; name= "stripMinerMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3767 -> { DogmaEffectData.id= 3767; name= "eliteBonusCommandShipsHeavyMissileExplosionVelocityCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3864 -> { DogmaEffectData.id= 3864; name= "subsystemBonusAmarrPropulsionAfterburnerSpeedFactor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3961 -> { DogmaEffectData.id= 3961; name= "subsystemBonusGallenteDefensiveArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4058 -> { DogmaEffectData.id= 4058; name= "systemRocketExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4155 -> { DogmaEffectData.id= 4155; name= "subsystemBonusMinmatarEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4446 -> { DogmaEffectData.id= 4446; name= "caldarisetbonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14572; postExpression= 14573 } |> Some
      | 4640 -> { DogmaEffectData.id= 4640; name= "shipArmorEMAndExpAndkinAndThmResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 469 -> { DogmaEffectData.id= 469; name= "shipMiningBonusGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2550; postExpression= 2551 } |> Some
      | 4931 -> { DogmaEffectData.id= 4931; name= "targetMissileReduceExplosiveRadius"; description= "Automatically generated effect"; displayName= ""; effectCategory= 2; preExpression= 15895; postExpression= 15896 } |> Some
      | 5028 -> { DogmaEffectData.id= 5028; name= "shipECMScanStrengthBonusRookie"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5125 -> { DogmaEffectData.id= 5125; name= "shipBonusRemoteArmorRepairAmountGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5222 -> { DogmaEffectData.id= 5222; name= "shipHeavyAssaultMissileKinDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5319 -> { DogmaEffectData.id= 5319; name= "shipBonusFrigateSizedLightMissileExplosiveDamageMD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5416 -> { DogmaEffectData.id= 5416; name= "shipMissileAoeVelocityAD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17025; postExpression= 17026 } |> Some
      | 5610 -> { DogmaEffectData.id= 5610; name= "shipBonusLargeEnergyTurretMaxRangeAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 566 -> { DogmaEffectData.id= 566; name= "laboratoryOperationSkillLevelModAddMaxLaborotorySlotsChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5804 -> { DogmaEffectData.id= 5804; name= "shipBonusHeavyDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5901 -> { DogmaEffectData.id= 5901; name= "roleBonusBulkheadCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5998 -> { DogmaEffectData.id= 5998; name= "freighterSMACapacityBonusO1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6192 -> { DogmaEffectData.id= 6192; name= "expeditionFrigateShieldResistanceTHERM1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18919; postExpression= 18920 } |> Some
      | 6289 -> { DogmaEffectData.id= 6289; name= "shipBonusEnergyNosFalloffAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19108; postExpression= 19109 } |> Some
      | 6386 -> { DogmaEffectData.id= 6386; name= "ewSkillGuidanceDisruptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6580 -> { DogmaEffectData.id= 6580; name= "shipBonusRole2LogisticDroneRepAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 663 -> { DogmaEffectData.id= 663; name= "heavyMissilesSkillBoostMaxflightTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6677 -> { DogmaEffectData.id= 6677; name= "structureRigGalMinIceYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6774 -> { DogmaEffectData.id= 6774; name= "miningForemanDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6871 -> { DogmaEffectData.id= 6871; name= "concordSecStatusTankBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7065 -> { DogmaEffectData.id= 7065; name= "precursorFrigateSkillLevelPreMulShipBonusPF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7162 -> { DogmaEffectData.id= 7162; name= "shipRoleDisintegratorMaxRangeCBC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 760 -> { DogmaEffectData.id= 760; name= "shipBonusSmallMissileRoFCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 81 -> { DogmaEffectData.id= 81; name= "surveyScan"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 857 -> { DogmaEffectData.id= 857; name= "bountyHuntingSkillBoostBountySkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None