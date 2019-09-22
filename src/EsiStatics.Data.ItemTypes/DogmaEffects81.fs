namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects81=
    let getDogmaEffect id = 
      match id with 
      | 1730 -> { DogmaEffectData.id= 1730; name= "droneDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6744; postExpression= 6745 } |> Some
      | 2215 -> { DogmaEffectData.id= 2215; name= "shipBonusPirateFrigateProjDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8235; postExpression= 8236 } |> Some
      | 2312 -> { DogmaEffectData.id= 2312; name= "disallowOffensiveActChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8534; postExpression= 8535 } |> Some
      | 2603 -> { DogmaEffectData.id= 2603; name= "shipBonusExplosiveShieldResistanceCB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9452; postExpression= 9453 } |> Some
      | 2797 -> { DogmaEffectData.id= 2797; name= "projectileWeaponSpeedMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 654; postExpression= 655 } |> Some
      | 2894 -> { DogmaEffectData.id= 2894; name= "missileThermalDmgBonusStandard"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10231; postExpression= 10232 } |> Some
      | 3379 -> { DogmaEffectData.id= 3379; name= "implantHardwiringABcapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11675; postExpression= 11676 } |> Some
      | 3670 -> { DogmaEffectData.id= 3670; name= "stripMinerMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12576; postExpression= 12577 } |> Some
      | 3767 -> { DogmaEffectData.id= 3767; name= "eliteBonusCommandShipsHeavyMissileExplosionVelocityCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12830; postExpression= 12831 } |> Some
      | 3864 -> { DogmaEffectData.id= 3864; name= "subsystemBonusAmarrPropulsionAfterburnerSpeedFactor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13093; postExpression= 13094 } |> Some
      | 3961 -> { DogmaEffectData.id= 3961; name= "subsystemBonusGallenteDefensiveArmorRepairAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13287; postExpression= 13288 } |> Some
      | 4058 -> { DogmaEffectData.id= 4058; name= "systemRocketExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13580; postExpression= 13581 } |> Some
      | 4155 -> { DogmaEffectData.id= 4155; name= "subsystemBonusMinmatarEngineeringHeatDamageReduction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13818; postExpression= 13819 } |> Some
      | 4640 -> { DogmaEffectData.id= 4640; name= "shipArmorEMAndExpAndkinAndThmResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15141; postExpression= 15142 } |> Some
      | 5028 -> { DogmaEffectData.id= 5028; name= "shipECMScanStrengthBonusRookie"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16148; postExpression= 16149 } |> Some
      | 5125 -> { DogmaEffectData.id= 5125; name= "shipBonusRemoteArmorRepairAmountGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16374; postExpression= 16375 } |> Some
      | 5222 -> { DogmaEffectData.id= 5222; name= "shipHeavyAssaultMissileKinDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16603; postExpression= 16604 } |> Some
      | 5319 -> { DogmaEffectData.id= 5319; name= "shipBonusFrigateSizedLightMissileExplosiveDamageMD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16839; postExpression= 16840 } |> Some
      | 5610 -> { DogmaEffectData.id= 5610; name= "shipBonusLargeEnergyTurretMaxRangeAB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17514; postExpression= 17515 } |> Some
      | 566 -> { DogmaEffectData.id= 566; name= "laboratoryOperationSkillLevelModAddMaxLaborotorySlotsChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2951; postExpression= 2952 } |> Some
      | 5804 -> { DogmaEffectData.id= 5804; name= "shipBonusHeavyDroneDamageMultiplierPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17961; postExpression= 17962 } |> Some
      | 5901 -> { DogmaEffectData.id= 5901; name= "roleBonusBulkheadCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18219; postExpression= 18220 } |> Some
      | 5998 -> { DogmaEffectData.id= 5998; name= "freighterSMACapacityBonusO1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18479; postExpression= 18480 } |> Some
      | 6386 -> { DogmaEffectData.id= 6386; name= "ewSkillGuidanceDisruptionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17937; postExpression= 17938 } |> Some
      | 6580 -> { DogmaEffectData.id= 6580; name= "shipBonusRole2LogisticDroneRepAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 663 -> { DogmaEffectData.id= 663; name= "heavyMissilesSkillBoostMaxflightTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3315; postExpression= 3316 } |> Some
      | 6677 -> { DogmaEffectData.id= 6677; name= "structureRigGalMinIceYield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6774 -> { DogmaEffectData.id= 6774; name= "miningForemanDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6871 -> { DogmaEffectData.id= 6871; name= "concordSecStatusTankBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7065 -> { DogmaEffectData.id= 7065; name= "precursorFrigateSkillLevelPreMulShipBonusPF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19418; postExpression= 19419 } |> Some
      | 7162 -> { DogmaEffectData.id= 7162; name= "shipRoleDisintegratorMaxRangeCBC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19698; postExpression= 19699 } |> Some
      | 760 -> { DogmaEffectData.id= 760; name= "shipBonusSmallMissileRoFCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3645; postExpression= 3646 } |> Some
      | 81 -> { DogmaEffectData.id= 81; name= "surveyScan"; description= ""; displayName= ""; effectCategory= 1; preExpression= 131; postExpression= 602 } |> Some
      | 857 -> { DogmaEffectData.id= 857; name= "bountyHuntingSkillBoostBountySkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3957; postExpression= 3958 } |> Some
      | _ -> None