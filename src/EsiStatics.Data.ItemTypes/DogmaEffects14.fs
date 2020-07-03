namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects14=
    let getDogmaEffect id = 
      match id with 
      | 1081 -> { DogmaEffectData.id= 1081; name= "eliteBonusHeavyGunshipHeavyMissileFlightTime1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 111 -> { DogmaEffectData.id= 111; name= "characterBlueprintManufactureTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1372 -> { DogmaEffectData.id= 1372; name= "ewSkillEwCapNeedSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1663 -> { DogmaEffectData.id= 1663; name= "freighterC2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 208 -> { DogmaEffectData.id= 208; name= "propulsionJammingSkillBoostDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2148 -> { DogmaEffectData.id= 2148; name= "droneDamageBonusRequringDrones"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3409 -> { DogmaEffectData.id= 3409; name= "violatorsSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3797 -> { DogmaEffectData.id= 3797; name= "droneBandwidthAddPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 402 -> { DogmaEffectData.id= 402; name= "criminalConnectionsCriminalConnectionsMutatorModAddCriminalConnectionsBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4088 -> { DogmaEffectData.id= 4088; name= "systemArmorRemoteRepairAmount"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4185 -> { DogmaEffectData.id= 4185; name= "subsystemBonusAmarrOffensiveEnergyWeaponCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4282 -> { DogmaEffectData.id= 4282; name= "subsystemBonusGallenteOffensive2HybridWeaponDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4379 -> { DogmaEffectData.id= 4379; name= "shipBonusTorpedoVelocity2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4476 -> { DogmaEffectData.id= 4476; name= "shipMTFalloffBonusATF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4670 -> { DogmaEffectData.id= 4670; name= "shipBonusNoctisTractorRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4961 -> { DogmaEffectData.id= 4961; name= "systemShieldRepairAmountShieldSkills"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 5058 -> { DogmaEffectData.id= 5058; name= "miningYieldMultiplyPassive"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5349 -> { DogmaEffectData.id= 5349; name= "shipBonusHeavyMissileLauncherRofMBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5737 -> { DogmaEffectData.id= 5737; name= "shipScanProbeStrengthBonusPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5931 -> { DogmaEffectData.id= 5931; name= "entitySelfVelocityMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 596 -> { DogmaEffectData.id= 596; name= "ammoInfluenceRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6222 -> { DogmaEffectData.id= 6222; name= "structureWarpScrambleBlockMWDWithNPCEffect"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6319 -> { DogmaEffectData.id= 6319; name= "shipBonusKineticShieldResistanceMD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6513 -> { DogmaEffectData.id= 6513; name= "doomsdayAOEECM"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6610 -> { DogmaEffectData.id= 6610; name= "shipBonusSupercarrierM5WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6901 -> { DogmaEffectData.id= 6901; name= "npcBehaviorMiningLaser"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6998 -> { DogmaEffectData.id= 6998; name= "covertOpsSkillLevelPreMulEliteBonusCoverOpsShip4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8065 -> { DogmaEffectData.id= 8065; name= "vortonProjectorSkillRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 887 -> { DogmaEffectData.id= 887; name= "shipETspeedBonusAB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None