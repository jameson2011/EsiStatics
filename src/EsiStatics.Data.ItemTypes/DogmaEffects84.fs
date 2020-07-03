namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects84=
    let getDogmaEffect id = 
      match id with 
      | 1442 -> { DogmaEffectData.id= 1442; name= "caldariShipEwOptimalRangeCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3867 -> { DogmaEffectData.id= 3867; name= "subsystemBonusGallentePropulsion2Agility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3964 -> { DogmaEffectData.id= 3964; name= "subsystemBonusCaldariDefensiveShieldBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4061 -> { DogmaEffectData.id= 4061; name= "systemStandardMissileThermalDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4158 -> { DogmaEffectData.id= 4158; name= "subsystemBonusCaldariCoreCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4643 -> { DogmaEffectData.id= 4643; name= "shipHeavyAssaultMissileEMAndExpAndKinAndThmDmgAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4934 -> { DogmaEffectData.id= 4934; name= "shipArmorRepairingGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5128 -> { DogmaEffectData.id= 5128; name= "shipBonusEwRemoteSensorDampenerOptimalBonusGC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5225 -> { DogmaEffectData.id= 5225; name= "shipHeavyMissileEMDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5322 -> { DogmaEffectData.id= 5322; name= "shipArmorEMResistance1ABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5419 -> { DogmaEffectData.id= 5419; name= "shipBonusDroneShieldHitPointsAB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 569 -> { DogmaEffectData.id= 569; name= "missileLaunchingForEntity"; description= ""; displayName= "missileLaunching"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 5807 -> { DogmaEffectData.id= 5807; name= "shipBonusSentryDroneShieldHpPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6001 -> { DogmaEffectData.id= 6001; name= "freighterAgilityBonus2O2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6098 -> { DogmaEffectData.id= 6098; name= "shipMissileReloadTimeCaldariTacticalDestroyer2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6195 -> { DogmaEffectData.id= 6195; name= "expeditionFrigateShieldResistance1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6583 -> { DogmaEffectData.id= 6583; name= "skillMultiplierShipBonusCarrierAmarr"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6777 -> { DogmaEffectData.id= 6777; name= "shieldCommandStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6874 -> { DogmaEffectData.id= 6874; name= "shipBonusMedMissileFlightTimeCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6971 -> { DogmaEffectData.id= 6971; name= "rigReactionCompTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7068 -> { DogmaEffectData.id= 7068; name= "precursorCruiserSkillLevelPreMulShipBonusPC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7165 -> { DogmaEffectData.id= 7165; name= "miningAmountOverride"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 763 -> { DogmaEffectData.id= 763; name= "missileDMGBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None