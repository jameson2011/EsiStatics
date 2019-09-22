namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects75=
    let getDogmaEffect id = 
      match id with 
      | 1239 -> { DogmaEffectData.id= 1239; name= "shipProjectileRofPirateBattleship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5299; postExpression= 5300 } |> Some
      | 172 -> { DogmaEffectData.id= 172; name= "smallEnergyTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringSmallEnergyTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1266; postExpression= 1267 } |> Some
      | 2015 -> { DogmaEffectData.id= 2015; name= "droneDurabilityShieldCapBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7645; postExpression= 7646 } |> Some
      | 2112 -> { DogmaEffectData.id= 2112; name= "thermicArmorCompensationHardeningBonusGroupEnergized"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7954; postExpression= 7955 } |> Some
      | 2694 -> { DogmaEffectData.id= 2694; name= "falloffBonusEffectHybrids"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9699; postExpression= 9700 } |> Some
      | 2791 -> { DogmaEffectData.id= 2791; name= "boosterMissileExplosionCloudPenaltyFixed"; description= ""; displayName= "Missile Explosion Radius Penalty"; effectCategory= 0; preExpression= 9963; postExpression= 9964 } |> Some
      | 2888 -> { DogmaEffectData.id= 2888; name= "missileExplosiveDmgBonusRocket"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10211; postExpression= 10212 } |> Some
      | 3955 -> { DogmaEffectData.id= 3955; name= "subsystemBonusCaldariDefensiveShieldResistance"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13275; postExpression= 13276 } |> Some
      | 4343 -> { DogmaEffectData.id= 4343; name= "subsystemBonusAmarrCore2MaxTargetingRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14304; postExpression= 14305 } |> Some
      | 5119 -> { DogmaEffectData.id= 5119; name= "shipBonusScanProbeStrength2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16357; postExpression= 16358 } |> Some
      | 5216 -> { DogmaEffectData.id= 5216; name= "shipSHTFalloffBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16588; postExpression= 16589 } |> Some
      | 5410 -> { DogmaEffectData.id= 5410; name= "shipLaserCap1ABC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17013; postExpression= 17014 } |> Some
      | 6186 -> { DogmaEffectData.id= 6186; name= "shipModuleRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6380 -> { DogmaEffectData.id= 6380; name= "eliteBonusLogiFrigShieldHP2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4158; postExpression= 4159 } |> Some
      | 6477 -> { DogmaEffectData.id= 6477; name= "doomsdayAOENeut"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 657 -> { DogmaEffectData.id= 657; name= "agilityMultiplierEffect"; description= "Automatically generated effect"; displayName= "AgilityMultiplierEffect"; effectCategory= 4; preExpression= 3285; postExpression= 3286 } |> Some
      | 6574 -> { DogmaEffectData.id= 6574; name= "skillBonusCapitalRailgunSpecialization"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6671 -> { DogmaEffectData.id= 6671; name= "moduleBonusCapitalDroneSpeedAugmentor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6768 -> { DogmaEffectData.id= 6768; name= "areaOfEffectSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6865 -> { DogmaEffectData.id= 6865; name= "eliteBonusCoverOpsWarpVelocity1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19327; postExpression= 19328 } |> Some
      | 6962 -> { DogmaEffectData.id= 6962; name= "subsystemBonusAmarrPropulsion2WarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14157; postExpression= 14158 } |> Some
      | 7059 -> { DogmaEffectData.id= 7059; name= "weather_caustic_toxin"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7156 -> { DogmaEffectData.id= 7156; name= "smallDisintegratorMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19683; postExpression= 19684 } |> Some
      | 754 -> { DogmaEffectData.id= 754; name= "shipHybridDamageBonusCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3620; postExpression= 3621 } |> Some
      | _ -> None