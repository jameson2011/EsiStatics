namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects16=
    let getDogmaEffect id = 
      match id with 
      | 113 -> { DogmaEffectData.id= 113; name= "characterIntelligenceSkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 780; postExpression= 781 } |> Some
      | 16 -> { DogmaEffectData.id= 16; name= "online"; description= ""; displayName= ""; effectCategory= 1; preExpression= 633; postExpression= 400 } |> Some
      | 1665 -> { DogmaEffectData.id= 1665; name= "freighterG2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6609; postExpression= 6610 } |> Some
      | 2053 -> { DogmaEffectData.id= 2053; name= "emShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7761; postExpression= 7762 } |> Some
      | 210 -> { DogmaEffectData.id= 210; name= "sensorLinkingDurationBonusPostPercentDurationLocationShipModulesRequiringSensorLinking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1435; postExpression= 1436 } |> Some
      | 307 -> { DogmaEffectData.id= 307; name= "ironWillSkillBoostWillpowerBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1842; postExpression= 1843 } |> Some
      | 3120 -> { DogmaEffectData.id= 3120; name= "controlTowerGenericHullE&EResistanceBonusProjectile"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10961; postExpression= 10962 } |> Some
      | 3508 -> { DogmaEffectData.id= 3508; name= "gasHarvesterMaxRangeMultBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12054; postExpression= 12055 } |> Some
      | 3799 -> { DogmaEffectData.id= 3799; name= "droneCapacityAdddroneCapacityPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12882; postExpression= 12883 } |> Some
      | 3896 -> { DogmaEffectData.id= 3896; name= "subsystemBonusGallenteElectronicScanStrengthLADAR"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13157; postExpression= 13158 } |> Some
      | 3993 -> { DogmaEffectData.id= 3993; name= "systemTargetingRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 840; postExpression= 841 } |> Some
      | 404 -> { DogmaEffectData.id= 404; name= "negotiationNegotiationBonusPostPercentNegotiationPercentageChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2287; postExpression= 2288 } |> Some
      | 4090 -> { DogmaEffectData.id= 4090; name= "systemCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13677; postExpression= 13678 } |> Some
      | 4187 -> { DogmaEffectData.id= 4187; name= "shipBonusStrategicCruiserAmarrHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13892; postExpression= 13893 } |> Some
      | 4284 -> { DogmaEffectData.id= 4284; name= "subsystemBonusGallenteDefensiveDroneHPArmorHull"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14168; postExpression= 14169 } |> Some
      | 4381 -> { DogmaEffectData.id= 4381; name= "covertOpsStealthBomberCruiseMissileLauncherPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14394; postExpression= 14395 } |> Some
      | 4478 -> { DogmaEffectData.id= 4478; name= "shipBonusAfterburnerCapNeedATF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14682; postExpression= 14683 } |> Some
      | 4575 -> { DogmaEffectData.id= 4575; name= "industrialCoreEffect2"; description= ""; displayName= ""; effectCategory= 1; preExpression= 14997; postExpression= 14998 } |> Some
      | 4769 -> { DogmaEffectData.id= 4769; name= "anchorDropOrbital"; description= "Anchoring this object in space."; displayName= "anchoring"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 4866 -> { DogmaEffectData.id= 4866; name= "skillBonusBoosterArmorDamageAmountBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15720; postExpression= 15721 } |> Some
      | 5157 -> { DogmaEffectData.id= 5157; name= "shipBonusEnergyNeutRangeDF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16437; postExpression= 16438 } |> Some
      | 5351 -> { DogmaEffectData.id= 5351; name= "shipShieldBoost1MBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16903; postExpression= 16904 } |> Some
      | 5448 -> { DogmaEffectData.id= 5448; name= "shipMissileKineticDamageMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17110; postExpression= 17111 } |> Some
      | 5933 -> { DogmaEffectData.id= 5933; name= "entitySelfCruiseSpeedMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18314; postExpression= 18315 } |> Some
      | 598 -> { DogmaEffectData.id= 598; name= "ammoSpeedMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3054; postExpression= 3055 } |> Some
      | 6030 -> { DogmaEffectData.id= 6030; name= "shipMissileBonusKindmgMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18549; postExpression= 18550 } |> Some
      | 6224 -> { DogmaEffectData.id= 6224; name= "structureSensorBoosterActivePercentage"; description= ""; displayName= ""; effectCategory= 1; preExpression= 9629; postExpression= 9630 } |> Some
      | 6321 -> { DogmaEffectData.id= 6321; name= "shipBonusExplosiveShieldResistanceMD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19174; postExpression= 19175 } |> Some
      | 6418 -> { DogmaEffectData.id= 6418; name= "fighterDecreaseTargetSpeed"; description= ""; displayName= "Decrease Target Speed"; effectCategory= 2; preExpression= 3489; postExpression= 3491 } |> Some
      | 6612 -> { DogmaEffectData.id= 6612; name= "shipBonusSupercarrierA2FighterApplicationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6709 -> { DogmaEffectData.id= 6709; name= "shipBonusRole1CapitalHybridDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6806 -> { DogmaEffectData.id= 6806; name= "rigEquipmentManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of equipment"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6903 -> { DogmaEffectData.id= 6903; name= "shipModuleNonRepeatingArmorHardener"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7000 -> { DogmaEffectData.id= 7000; name= "shipBonusSHTFalloffGF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6892; postExpression= 6893 } |> Some
      | 7097 -> { DogmaEffectData.id= 7097; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupPrecursorTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19538; postExpression= 19539 } |> Some
      | 889 -> { DogmaEffectData.id= 889; name= "missileLauncherSpeedMultiplier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 4069; postExpression= 4070 } |> Some
      | _ -> None