namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects21=
    let getDogmaEffect id = 
      match id with 
      | 118 -> { DogmaEffectData.id= 118; name= "electronicAttributeModifyOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 1185 -> { DogmaEffectData.id= 1185; name= "structureStealthEmitterArraySigDecrease"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1282 -> { DogmaEffectData.id= 1282; name= "eliteIndustrial1SkillLevelPreMulEliteBonusEliteIndustrialShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1670 -> { DogmaEffectData.id= 1670; name= "freighterCargoBonusG2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1864 -> { DogmaEffectData.id= 1864; name= "shipMissileExplosiveDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 21 -> { DogmaEffectData.id= 21; name= "shieldCapacityBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2155 -> { DogmaEffectData.id= 2155; name= "eliteBonusCommandShipProjectileDamageCS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2252 -> { DogmaEffectData.id= 2252; name= "covertOpsAndReconOpsCloakModuleDelayBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2737 -> { DogmaEffectData.id= 2737; name= "boosterShieldCapacityPenalty"; description= "Automatically generated effect"; displayName= "Shield Capacity Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3028 -> { DogmaEffectData.id= 3028; name= "eliteBonusCoverOpsBombEmDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3416 -> { DogmaEffectData.id= 3416; name= "eliteBonusViolatorsLargeHybridTurretDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3513 -> { DogmaEffectData.id= 3513; name= "setBonusMordus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3998 -> { DogmaEffectData.id= 3998; name= "systemArmorKineticResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4192 -> { DogmaEffectData.id= 4192; name= "strategicCruiserCaldariSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4871 -> { DogmaEffectData.id= 4871; name= "setBonusChristmasCapacitorRecharge2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 506 -> { DogmaEffectData.id= 506; name= "fuelConservationCapNeedBonusPostPercentCapacitorNeedLocationShipModulesRequiringAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5162 -> { DogmaEffectData.id= 5162; name= "skillReactiveArmorHardenerCapNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5259 -> { DogmaEffectData.id= 5259; name= "reconShipCloakCpuBonus1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5356 -> { DogmaEffectData.id= 5356; name= "shipHybridRangeBonusCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5647 -> { DogmaEffectData.id= 5647; name= "covertOpsCloakCPUPercentRoleBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5938 -> { DogmaEffectData.id= 5938; name= "shipBonusSmallMissileExplosionRadiusCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6035 -> { DogmaEffectData.id= 6035; name= "tacticalDestroyerMinmatarSkillLevel3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6326 -> { DogmaEffectData.id= 6326; name= "shipBonusThermalMissileDamageCD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6423 -> { DogmaEffectData.id= 6423; name= "shipModuleGuidanceDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6520 -> { DogmaEffectData.id= 6520; name= "skillMultiplierShipBonusForceAuxiliaryGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6617 -> { DogmaEffectData.id= 6617; name= "shipBonusSupercarrierG4BurstProjectorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6714 -> { DogmaEffectData.id= 6714; name= "ECMBurstJammer"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6811 -> { DogmaEffectData.id= 6811; name= "rigDroneManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of drones"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6908 -> { DogmaEffectData.id= 6908; name= "shipBonusStrategicCruiserCaldariNaniteRepairTime2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7102 -> { DogmaEffectData.id= 7102; name= "structureConversionRigT2CompManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 797 -> { DogmaEffectData.id= 797; name= "caldariBattleshipSkillLevelPreMulShipBonusCB3Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8072 -> { DogmaEffectData.id= 8072; name= "shipArmorResistanceBonusGBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 991 -> { DogmaEffectData.id= 991; name= "eliteBonusGunshipLaserOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None