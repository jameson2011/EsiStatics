namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects54=
    let getDogmaEffect id = 
      match id with 
      | 1024 -> { DogmaEffectData.id= 1024; name= "shipMissileHeavyVelocityBonusCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4542; postExpression= 4543 } |> Some
      | 1218 -> { DogmaEffectData.id= 1218; name= "shipBonusPirateSmallHybridDmg"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5257; postExpression= 5258 } |> Some
      | 1412 -> { DogmaEffectData.id= 1412; name= "shipBonusHybridOptimalCB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5837; postExpression= 5838 } |> Some
      | 1897 -> { DogmaEffectData.id= 1897; name= "shieldCompensationSkillBoostHardeningBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7277; postExpression= 7278 } |> Some
      | 2188 -> { DogmaEffectData.id= 2188; name= "shipBonusDroneDamageMultiplierGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8156; postExpression= 8157 } |> Some
      | 2479 -> { DogmaEffectData.id= 2479; name= "iceHarvestCycleTimeModulesRequiringIceHarvestingOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5165; postExpression= 5166 } |> Some
      | 2867 -> { DogmaEffectData.id= 2867; name= "sentryDroneDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10144; postExpression= 10145 } |> Some
      | 3061 -> { DogmaEffectData.id= 3061; name= "heatDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10735; postExpression= 10736 } |> Some
      | 3740 -> { DogmaEffectData.id= 3740; name= "zColinOrcaTractorVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12740; postExpression= 12741 } |> Some
      | 3837 -> { DogmaEffectData.id= 3837; name= "subsystemSkillLevelGallenteElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12995; postExpression= 12996 } |> Some
      | 4322 -> { DogmaEffectData.id= 4322; name= "subsystemBonusAmarrOffensiveDroneDamageMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14253; postExpression= 14254 } |> Some
      | 4516 -> { DogmaEffectData.id= 4516; name= "shipHTurretFalloffBonusGC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14786; postExpression= 14787 } |> Some
      | 5389 -> { DogmaEffectData.id= 5389; name= "shipBonusDroneTrackingGC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16970; postExpression= 16971 } |> Some
      | 54 -> { DogmaEffectData.id= 54; name= "targetPassively"; description= ""; displayName= ""; effectCategory= 2; preExpression= 472; postExpression= 131 } |> Some
      | 5486 -> { DogmaEffectData.id= 5486; name= "shipBonusProjectileDamageMBC2"; description= "[no messageID: 289549]"; displayName= ""; effectCategory= 0; preExpression= 17225; postExpression= 17226 } |> Some
      | 5874 -> { DogmaEffectData.id= 5874; name= "eliteIndustrialFleetCapacity1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18140; postExpression= 18141 } |> Some
      | 6165 -> { DogmaEffectData.id= 6165; name= "behaviorNpcRemoteArmorRepair"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 89 } |> Some
      | 6359 -> { DogmaEffectData.id= 6359; name= "shipBonusAoeVelocityRocketsMF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16815; postExpression= 16816 } |> Some
      | 6650 -> { DogmaEffectData.id= 6650; name= "shipBonusTitanM3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6747 -> { DogmaEffectData.id= 6747; name= "npcBehaviorTrackingDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6844 -> { DogmaEffectData.id= 6844; name= "skillMultiplierDefenderMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6941 -> { DogmaEffectData.id= 6941; name= "subsystemBonusCaldariDefensive2HardenerHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7038 -> { DogmaEffectData.id= 7038; name= "shipBonusHeavyAssaultMissileKineticDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19406; postExpression= 19407 } |> Some
      | 7232 -> { DogmaEffectData.id= 7232; name= "modifyDamageMultiplierBonusMax"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 927 -> { DogmaEffectData.id= 927; name= "caldariCruiserSkillLevelPreMulShipBonusCC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4218; postExpression= 4219 } |> Some
      | _ -> None