namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects13=
    let getDogmaEffect id = 
      match id with 
      | 1080 -> { DogmaEffectData.id= 1080; name= "eliteBonusHeavyGunshipHybridFallOff1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4732; postExpression= 4733 } |> Some
      | 110 -> { DogmaEffectData.id= 110; name= "characterBlueprintResearchTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 750; postExpression= 751 } |> Some
      | 13 -> { DogmaEffectData.id= 13; name= "medPower"; description= "Requires a medium power slot."; displayName= "Medium power"; effectCategory= 0; preExpression= 131; postExpression= 131 } |> Some
      | 304 -> { DogmaEffectData.id= 304; name= "instantRecallMemoryBonusModAddMemoryLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1832; postExpression= 1833 } |> Some
      | 3311 -> { DogmaEffectData.id= 3311; name= "oreCapitalShipSkillMultiplier3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11503; postExpression= 11504 } |> Some
      | 3408 -> { DogmaEffectData.id= 3408; name= "violatorsSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11780; postExpression= 11781 } |> Some
      | 3602 -> { DogmaEffectData.id= 3602; name= "scriptDurationBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12352; postExpression= 12353 } |> Some
      | 3796 -> { DogmaEffectData.id= 3796; name= "dungeonTurretTrackingBonus"; description= ""; displayName= ""; effectCategory= 6; preExpression= 12240; postExpression= 12241 } |> Some
      | 3893 -> { DogmaEffectData.id= 3893; name= "subsystemBonusMinmatarCoreScanStrengthLADAR"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13151; postExpression= 13152 } |> Some
      | 4281 -> { DogmaEffectData.id= 4281; name= "modifyShipAgilityPassivePreAssignment"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14162; postExpression= 14163 } |> Some
      | 4378 -> { DogmaEffectData.id= 4378; name= "shipBonusTorpedoVelocityMF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14387; postExpression= 14388 } |> Some
      | 4475 -> { DogmaEffectData.id= 4475; name= "shipMTFalloffBonusATC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14674; postExpression= 14675 } |> Some
      | 4669 -> { DogmaEffectData.id= 4669; name= "shipBonusNoctisTractorVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15209; postExpression= 15210 } |> Some
      | 498 -> { DogmaEffectData.id= 498; name= "inventionSkillBoostInventionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2655; postExpression= 2657 } |> Some
      | 5348 -> { DogmaEffectData.id= 5348; name= "shipBonusDroneHitpointsGBC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16897; postExpression= 16898 } |> Some
      | 5445 -> { DogmaEffectData.id= 5445; name= "shipCruiseMissileAOECloudSize1CB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17100; postExpression= 17101 } |> Some
      | 5542 -> { DogmaEffectData.id= 5542; name= "shipBonusHMLExploDamageAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17358; postExpression= 17359 } |> Some
      | 5639 -> { DogmaEffectData.id= 5639; name= "shipBonusHeavyMissileExploDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17578; postExpression= 17579 } |> Some
      | 5736 -> { DogmaEffectData.id= 5736; name= "eliteBonusMaraudersHeavyMissileDamageThermRole1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17774; postExpression= 17775 } |> Some
      | 6027 -> { DogmaEffectData.id= 6027; name= "eliteReconBonusMPTdamage1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 7357; postExpression= 7358 } |> Some
      | 6318 -> { DogmaEffectData.id= 6318; name= "shipBonusEMShieldResistanceMD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19168; postExpression= 19169 } |> Some
      | 6415 -> { DogmaEffectData.id= 6415; name= "structureRigFighterMaxVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6609 -> { DogmaEffectData.id= 6609; name= "shipBonusSupercarrierG5WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6706 -> { DogmaEffectData.id= 6706; name= "setBonusAsklepian"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6313; postExpression= 6314 } |> Some
      | 6900 -> { DogmaEffectData.id= 6900; name= "subsystemMMissileFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19331; postExpression= 19332 } |> Some
      | 6997 -> { DogmaEffectData.id= 6997; name= "eliteCovertOpsBonusArmorRepAmount4"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16933; postExpression= 16934 } |> Some
      | 7094 -> { DogmaEffectData.id= 7094; name= "shipBonusRemoteRepMaxRangeRoleBonus1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19535; postExpression= 19536 } |> Some
      | _ -> None