namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects84=
    let getDogmaEffect id = 
      match id with 
      | 1054 -> { DogmaEffectData.id= 1054; name= "shipTrackingLinkRange1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4640; postExpression= 4641 } |> Some
      | 1442 -> { DogmaEffectData.id= 1442; name= "caldariShipEwOptimalRangeCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2218 -> { DogmaEffectData.id= 2218; name= "navigationComputerWarpAccuracyBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 8250; postExpression= 8251 } |> Some
      | 2412 -> { DogmaEffectData.id= 2412; name= "cloneVatCpuNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8879; postExpression= 8880 } |> Some
      | 2606 -> { DogmaEffectData.id= 2606; name= "scanGravimetricStrengthBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 9459; postExpression= 9460 } |> Some
      | 2897 -> { DogmaEffectData.id= 2897; name= "missileKineticDmgBonusFOF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10245; postExpression= 10246 } |> Some
      | 3091 -> { DogmaEffectData.id= 3091; name= "controlTowerGenericHullThermicResistanceBonusLaser"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10857; postExpression= 10858 } |> Some
      | 3382 -> { DogmaEffectData.id= 3382; name= "droneArmorHPBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 11683; postExpression= 11684 } |> Some
      | 3479 -> { DogmaEffectData.id= 3479; name= "shipRofBonusCB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11968; postExpression= 11969 } |> Some
      | 3770 -> { DogmaEffectData.id= 3770; name= "zColinArmorHPPerLvl"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12839; postExpression= 12840 } |> Some
      | 3867 -> { DogmaEffectData.id= 3867; name= "subsystemBonusGallentePropulsion2Agility"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3964 -> { DogmaEffectData.id= 3964; name= "subsystemBonusCaldariDefensiveShieldBoostAmount"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4061 -> { DogmaEffectData.id= 4061; name= "systemStandardMissileThermalDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4158 -> { DogmaEffectData.id= 4158; name= "subsystemBonusCaldariCoreCapacitorCapacity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4255 -> { DogmaEffectData.id= 4255; name= "subsystemBonusMinmatarOffensive2HeavyAssaultMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14111; postExpression= 14112 } |> Some
      | 4352 -> { DogmaEffectData.id= 4352; name= "shipMissileHeavyVelocityBonusCR3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14328; postExpression= 14329 } |> Some
      | 4643 -> { DogmaEffectData.id= 4643; name= "shipHeavyAssaultMissileEMAndExpAndKinAndThmDmgAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 472 -> { DogmaEffectData.id= 472; name= "shipHybridTrackingBonusGf"; description= "Automatically generated effect"; displayName= "shipHybridTrackingBonus"; effectCategory= 0; preExpression= 2561; postExpression= 2562 } |> Some
      | 4837 -> { DogmaEffectData.id= 4837; name= "disallowOffensiveModifiersShip"; description= "Automatically generated effect"; displayName= "disallowOffensiveModifiersShip"; effectCategory= 1; preExpression= 15631; postExpression= 15632 } |> Some
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
      | 860 -> { DogmaEffectData.id= 860; name= "advBountyhunterSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3971; postExpression= 3972 } |> Some
      | _ -> None