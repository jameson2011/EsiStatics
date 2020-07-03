namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects16=
    let getDogmaEffect id = 
      match id with 
      | 113 -> { DogmaEffectData.id= 113; name= "characterIntelligenceSkillTrainingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 16 -> { DogmaEffectData.id= 16; name= "online"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1665 -> { DogmaEffectData.id= 1665; name= "freighterG2SkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2053 -> { DogmaEffectData.id= 2053; name= "emShieldCompensationHardeningBonusGroupShieldAmp"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3799 -> { DogmaEffectData.id= 3799; name= "droneCapacityAdddroneCapacityPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3993 -> { DogmaEffectData.id= 3993; name= "systemTargetingRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 404 -> { DogmaEffectData.id= 404; name= "negotiationNegotiationBonusPostPercentNegotiationPercentageChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4090 -> { DogmaEffectData.id= 4090; name= "systemCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4187 -> { DogmaEffectData.id= 4187; name= "shipBonusStrategicCruiserAmarrHeatDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4478 -> { DogmaEffectData.id= 4478; name= "shipBonusAfterburnerCapNeedATF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4575 -> { DogmaEffectData.id= 4575; name= "industrialCoreEffect2"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 4769 -> { DogmaEffectData.id= 4769; name= "anchorDropOrbital"; description= "Anchoring this object in space."; displayName= "anchoring"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 5351 -> { DogmaEffectData.id= 5351; name= "shipShieldBoost1MBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5933 -> { DogmaEffectData.id= 5933; name= "entitySelfCruiseSpeedMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 598 -> { DogmaEffectData.id= 598; name= "ammoSpeedMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6321 -> { DogmaEffectData.id= 6321; name= "shipBonusExplosiveShieldResistanceMD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6612 -> { DogmaEffectData.id= 6612; name= "shipBonusSupercarrierA2FighterApplicationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6709 -> { DogmaEffectData.id= 6709; name= "shipBonusRole1CapitalHybridDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6806 -> { DogmaEffectData.id= 6806; name= "rigEquipmentManufactureTimeBonus"; description= "Structure Rig Time effect on Manufacturing of equipment"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6903 -> { DogmaEffectData.id= 6903; name= "shipModuleNonRepeatingArmorHardener"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7000 -> { DogmaEffectData.id= 7000; name= "shipBonusSHTFalloffGF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7097 -> { DogmaEffectData.id= 7097; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupPrecursorTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 889 -> { DogmaEffectData.id= 889; name= "missileLauncherSpeedMultiplier"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None