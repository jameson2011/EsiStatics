namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects19=
    let getDogmaEffect id = 
      match id with 
      | 1086 -> { DogmaEffectData.id= 1086; name= "projectileFiredForEntities"; description= ""; displayName= "projectileFired"; effectCategory= 2; preExpression= 115; postExpression= 131 } |> Some
      | 116 -> { DogmaEffectData.id= 116; name= "characterWillpowerSkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 786; postExpression= 787 } |> Some
      | 1183 -> { DogmaEffectData.id= 1183; name= "eliteBonusLogisticEnergyTransferCapNeed2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5139; postExpression= 5140 } |> Some
      | 1668 -> { DogmaEffectData.id= 1668; name= "freighterCargoBonusA2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6576; postExpression= 6577 } |> Some
      | 1765 -> { DogmaEffectData.id= 1765; name= "missileSkillMissileProjectileVelocityBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6864; postExpression= 6865 } |> Some
      | 1862 -> { DogmaEffectData.id= 1862; name= "shipMissileEMDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7171; postExpression= 7172 } |> Some
      | 1959 -> { DogmaEffectData.id= 1959; name= "armorReinforcerMassAdd"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5841; postExpression= 5842 } |> Some
      | 2056 -> { DogmaEffectData.id= 2056; name= "thermalShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7773; postExpression= 7774 } |> Some
      | 213 -> { DogmaEffectData.id= 213; name= "targetingSkillBoostMaxTargetBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1451; postExpression= 1452 } |> Some
      | 2250 -> { DogmaEffectData.id= 2250; name= "shipBonusDroneMiningAmountGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8331; postExpression= 8332 } |> Some
      | 2444 -> { DogmaEffectData.id= 2444; name= "minerCpuUsageMultiplyPercent2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8996; postExpression= 8997 } |> Some
      | 2735 -> { DogmaEffectData.id= 2735; name= "boosterArmorHpPenalty"; description= "Automatically generated effect"; displayName= "Armor Hitpoint Penalty"; effectCategory= 0; preExpression= 9823; postExpression= 9824 } |> Some
      | 3026 -> { DogmaEffectData.id= 3026; name= "eliteBonusCoverOpsBombKineticDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10656; postExpression= 10657 } |> Some
      | 310 -> { DogmaEffectData.id= 310; name= "spatialAwarenessPerceptionBonusModAddPerceptionLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1850; postExpression= 1851 } |> Some
      | 3705 -> { DogmaEffectData.id= 3705; name= "shipHybridTurretROFBonusGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12664; postExpression= 12665 } |> Some
      | 3996 -> { DogmaEffectData.id= 3996; name= "systemArmorEmResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13354; postExpression= 13355 } |> Some
      | 407 -> { DogmaEffectData.id= 407; name= "socialSocialMutatorPostPercentSocialBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2300; postExpression= 2301 } |> Some
      | 4093 -> { DogmaEffectData.id= 4093; name= "subsystemBonusAmarrOffensiveEnergyWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13684; postExpression= 13685 } |> Some
      | 4190 -> { DogmaEffectData.id= 4190; name= "shipBonusStrategicCruiserMinmatarHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13901; postExpression= 13902 } |> Some
      | 4384 -> { DogmaEffectData.id= 4384; name= "eliteReconBonusHeavyMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14404; postExpression= 14405 } |> Some
      | 4869 -> { DogmaEffectData.id= 4869; name= "setBonusChristmasCPUOutput"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15733; postExpression= 15734 } |> Some
      | 504 -> { DogmaEffectData.id= 504; name= "scoutDroneOperationDroneRangeBonusModAddDroneControlDistanceChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2674; postExpression= 2675 } |> Some
      | 5354 -> { DogmaEffectData.id= 5354; name= "shipLargeLaserCapABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16909; postExpression= 16910 } |> Some
      | 5839 -> { DogmaEffectData.id= 5839; name= "eliteBargeShieldResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18055; postExpression= 18056 } |> Some
      | 6033 -> { DogmaEffectData.id= 6033; name= "tacticalDestroyerMinmatarSkillLevel1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18560; postExpression= 18561 } |> Some
      | 6130 -> { DogmaEffectData.id= 6130; name= "scriptMissileGuidanceComputerMissileVelocityBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18791; postExpression= 18792 } |> Some
      | 6324 -> { DogmaEffectData.id= 6324; name= "scriptscanMagnetometricStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6615 -> { DogmaEffectData.id= 6615; name= "shipBonusSupercarrierA4BurstProjectorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6712 -> { DogmaEffectData.id= 6712; name= "shipBonusTitanM1WebStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6809 -> { DogmaEffectData.id= 6809; name= "rigAmmoManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of ammo"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6906 -> { DogmaEffectData.id= 6906; name= "strategicCruiserCaldariSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13909; postExpression= 13910 } |> Some
      | 698 -> { DogmaEffectData.id= 698; name= "signatureAnalysisSkillLevelPreMulScanResolutionBonusSelf"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3425; postExpression= 3426 } |> Some
      | 7003 -> { DogmaEffectData.id= 7003; name= "eliteBonusCovertOpsSHTDamage3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17729; postExpression= 17730 } |> Some
      | 7100 -> { DogmaEffectData.id= 7100; name= "structureConversionRigT1ShipManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 892 -> { DogmaEffectData.id= 892; name= "shipTorpedosVelocityBonusCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4087; postExpression= 4088 } |> Some
      | 989 -> { DogmaEffectData.id= 989; name= "eliteBonusGunshipHybridOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4393; postExpression= 4394 } |> Some
      | _ -> None