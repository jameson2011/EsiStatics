namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects19=
    let getDogmaEffect id = 
      match id with 
      | 1086 -> { DogmaEffectData.id= 1086; name= "projectileFiredForEntities"; description= ""; displayName= "projectileFired"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 116 -> { DogmaEffectData.id= 116; name= "characterWillpowerSkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1183 -> { DogmaEffectData.id= 1183; name= "eliteBonusLogisticEnergyTransferCapNeed2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1668 -> { DogmaEffectData.id= 1668; name= "freighterCargoBonusA2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1765 -> { DogmaEffectData.id= 1765; name= "missileSkillMissileProjectileVelocityBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1862 -> { DogmaEffectData.id= 1862; name= "shipMissileEMDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1959 -> { DogmaEffectData.id= 1959; name= "armorReinforcerMassAdd"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2056 -> { DogmaEffectData.id= 2056; name= "thermalShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 213 -> { DogmaEffectData.id= 213; name= "targetingSkillBoostMaxTargetBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2250 -> { DogmaEffectData.id= 2250; name= "shipBonusDroneMiningAmountGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2444 -> { DogmaEffectData.id= 2444; name= "minerCpuUsageMultiplyPercent2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2735 -> { DogmaEffectData.id= 2735; name= "boosterArmorHpPenalty"; description= "Automatically generated effect"; displayName= "Armor Hitpoint Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3026 -> { DogmaEffectData.id= 3026; name= "eliteBonusCoverOpsBombKineticDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 310 -> { DogmaEffectData.id= 310; name= "spatialAwarenessPerceptionBonusModAddPerceptionLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3705 -> { DogmaEffectData.id= 3705; name= "shipHybridTurretROFBonusGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3996 -> { DogmaEffectData.id= 3996; name= "systemArmorEmResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 407 -> { DogmaEffectData.id= 407; name= "socialSocialMutatorPostPercentSocialBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4093 -> { DogmaEffectData.id= 4093; name= "subsystemBonusAmarrOffensiveEnergyWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4190 -> { DogmaEffectData.id= 4190; name= "shipBonusStrategicCruiserMinmatarHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4384 -> { DogmaEffectData.id= 4384; name= "eliteReconBonusHeavyMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4869 -> { DogmaEffectData.id= 4869; name= "setBonusChristmasCPUOutput"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 504 -> { DogmaEffectData.id= 504; name= "scoutDroneOperationDroneRangeBonusModAddDroneControlDistanceChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5354 -> { DogmaEffectData.id= 5354; name= "shipLargeLaserCapABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5839 -> { DogmaEffectData.id= 5839; name= "eliteBargeShieldResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6033 -> { DogmaEffectData.id= 6033; name= "tacticalDestroyerMinmatarSkillLevel1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6130 -> { DogmaEffectData.id= 6130; name= "scriptMissileGuidanceComputerMissileVelocityBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6324 -> { DogmaEffectData.id= 6324; name= "scriptscanMagnetometricStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6615 -> { DogmaEffectData.id= 6615; name= "shipBonusSupercarrierA4BurstProjectorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6712 -> { DogmaEffectData.id= 6712; name= "shipBonusTitanM1WebStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6809 -> { DogmaEffectData.id= 6809; name= "rigAmmoManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of ammo"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6906 -> { DogmaEffectData.id= 6906; name= "strategicCruiserCaldariSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 698 -> { DogmaEffectData.id= 698; name= "signatureAnalysisSkillLevelPreMulScanResolutionBonusSelf"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7003 -> { DogmaEffectData.id= 7003; name= "eliteBonusCovertOpsSHTDamage3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7100 -> { DogmaEffectData.id= 7100; name= "structureConversionRigT1ShipManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8070 -> { DogmaEffectData.id= 8070; name= "eliteBonusCommandShipsHeavyHAMvelocityCS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 892 -> { DogmaEffectData.id= 892; name= "shipTorpedosVelocityBonusCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 989 -> { DogmaEffectData.id= 989; name= "eliteBonusGunshipHybridOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None