namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects27=
    let getDogmaEffect id = 
      match id with 
      | 1191 -> { DogmaEffectData.id= 1191; name= "iceHarvestCycleTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1579 -> { DogmaEffectData.id= 1579; name= "setBonusSansha"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1773 -> { DogmaEffectData.id= 1773; name= "shipBonusSHTFalloffGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2161 -> { DogmaEffectData.id= 2161; name= "eliteBonusCommandShipHybridOptimalCS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2355 -> { DogmaEffectData.id= 2355; name= "capitalRemoteShieldTransferCapNeedBonusSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2452 -> { DogmaEffectData.id= 2452; name= "commandShipSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2646 -> { DogmaEffectData.id= 2646; name= "maxTargetRangeBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 27 -> { DogmaEffectData.id= 27; name= "armorRepair"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 318 -> { DogmaEffectData.id= 318; name= "amarrTechAmarrTechMutatorPostPercentAmarrTechTimePercentLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3519 -> { DogmaEffectData.id= 3519; name= "weaponUpgradesCpuNeedBonusPostPercentCpuLocationShipModulesRequiringBombLauncher"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3713 -> { DogmaEffectData.id= 3713; name= "concordWarpScramble"; description= "Attempts to prevent the target from warping."; displayName= "Warp Scramble"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3810 -> { DogmaEffectData.id= 3810; name= "capacityAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 415 -> { DogmaEffectData.id= 415; name= "tradeSkillBoostTradePremiumBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4198 -> { DogmaEffectData.id= 4198; name= "subsystemSkillLevelMinmatarDefensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4392 -> { DogmaEffectData.id= 4392; name= "subSystemBonusMinmatarElectronicScanProbeStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4489 -> { DogmaEffectData.id= 4489; name= "superWeaponAmarr"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 4974 -> { DogmaEffectData.id= 4974; name= "eliteBonusMarauderShieldBonus2a"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 512 -> { DogmaEffectData.id= 512; name= "shipSHTDmgBonusGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5168 -> { DogmaEffectData.id= 5168; name= "droneSalvageBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5265 -> { DogmaEffectData.id= 5265; name= "warfareLinkCpuPenalty"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5459 -> { DogmaEffectData.id= 5459; name= "hackingVirusStrengthBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5556 -> { DogmaEffectData.id= 5556; name= "shipBonusHeavyDRoneTrackingGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5944 -> { DogmaEffectData.id= 5944; name= "shipMissileLauncherRoFAD1Fixed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6041 -> { DogmaEffectData.id= 6041; name= "modeShieldResonancePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6332 -> { DogmaEffectData.id= 6332; name= "shipBonusShieldKineticResistanceCD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6526 -> { DogmaEffectData.id= 6526; name= "shipBonusForceAuxiliaryA1RemoteRepairAndCapAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6623 -> { DogmaEffectData.id= 6623; name= "shipBonusSupercarrierG2FighterHitpoints"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6720 -> { DogmaEffectData.id= 6720; name= "shipBonusDroneRepairMC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6817 -> { DogmaEffectData.id= 6817; name= "rigLargeshipManufactureTimeBonus"; description= "Structure Rig time effect on Manufacturing of large ships"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6914 -> { DogmaEffectData.id= 6914; name= "subsystemSkillLevelCaldariEngineering3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 706 -> { DogmaEffectData.id= 706; name= "covertOpsWarpResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7108 -> { DogmaEffectData.id= 7108; name= "structureConversionRigInventionTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7205 -> { DogmaEffectData.id= 7205; name= "shipArmorKinResistancePF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8078 -> { DogmaEffectData.id= 8078; name= "systemHullExplosiveResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 900 -> { DogmaEffectData.id= 900; name= "shipDroneScoutThermalDamageGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None