namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects81=
    let getDogmaEffect id = 
      match id with 
      | 1730 -> { DogmaEffectData.id= 1730; name= "droneDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2215 -> { DogmaEffectData.id= 2215; name= "shipBonusPirateFrigateProjDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2312 -> { DogmaEffectData.id= 2312; name= "disallowOffensiveActChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2603 -> { DogmaEffectData.id= 2603; name= "shipBonusExplosiveShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2797 -> { DogmaEffectData.id= 2797; name= "projectileWeaponSpeedMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2894 -> { DogmaEffectData.id= 2894; name= "missileThermalDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3379 -> { DogmaEffectData.id= 3379; name= "implantHardwiringABcapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3670 -> { DogmaEffectData.id= 3670; name= "stripMinerMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3767 -> { DogmaEffectData.id= 3767; name= "eliteBonusCommandShipsHeavyMissileExplosionVelocityCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3864 -> { DogmaEffectData.id= 3864; name= "subsystemBonusAmarrPropulsionAfterburnerSpeedFactor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3961 -> { DogmaEffectData.id= 3961; name= "subsystemBonusGallenteDefensiveArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4058 -> { DogmaEffectData.id= 4058; name= "systemRocketExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4155 -> { DogmaEffectData.id= 4155; name= "subsystemBonusMinmatarEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4640 -> { DogmaEffectData.id= 4640; name= "shipArmorEMAndExpAndkinAndThmResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5028 -> { DogmaEffectData.id= 5028; name= "shipECMScanStrengthBonusRookie"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5125 -> { DogmaEffectData.id= 5125; name= "shipBonusRemoteArmorRepairAmountGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5222 -> { DogmaEffectData.id= 5222; name= "shipHeavyAssaultMissileKinDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5319 -> { DogmaEffectData.id= 5319; name= "shipBonusFrigateSizedLightMissileExplosiveDamageMD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5610 -> { DogmaEffectData.id= 5610; name= "shipBonusLargeEnergyTurretMaxRangeAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 566 -> { DogmaEffectData.id= 566; name= "laboratoryOperationSkillLevelModAddMaxLaborotorySlotsChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5804 -> { DogmaEffectData.id= 5804; name= "shipBonusHeavyDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5901 -> { DogmaEffectData.id= 5901; name= "roleBonusBulkheadCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5998 -> { DogmaEffectData.id= 5998; name= "freighterSMACapacityBonusO1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6386 -> { DogmaEffectData.id= 6386; name= "ewSkillGuidanceDisruptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6580 -> { DogmaEffectData.id= 6580; name= "shipBonusRole2LogisticDroneRepAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 663 -> { DogmaEffectData.id= 663; name= "heavyMissilesSkillBoostMaxflightTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6677 -> { DogmaEffectData.id= 6677; name= "structureRigGalMinIceYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6774 -> { DogmaEffectData.id= 6774; name= "miningForemanDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6871 -> { DogmaEffectData.id= 6871; name= "concordSecStatusTankBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7065 -> { DogmaEffectData.id= 7065; name= "precursorFrigateSkillLevelPreMulShipBonusPF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7162 -> { DogmaEffectData.id= 7162; name= "shipRoleDisintegratorMaxRangeCBC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 760 -> { DogmaEffectData.id= 760; name= "shipBonusSmallMissileRoFCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8035 -> { DogmaEffectData.id= 8035; name= "mediumUpwellWeaponDmgBonusRequiredSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 81 -> { DogmaEffectData.id= 81; name= "surveyScan"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 857 -> { DogmaEffectData.id= 857; name= "bountyHuntingSkillBoostBountySkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None