namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects7=
    let getDogmaEffect id = 
      match id with 
      | 104 -> { DogmaEffectData.id= 104; name= "fofMissileLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 707; postExpression= 131 } |> Some
      | 1268 -> { DogmaEffectData.id= 1268; name= "interceptor2LaserTracking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5389; postExpression= 5390 } |> Some
      | 2432 -> { DogmaEffectData.id= 2432; name= "energyManagementCapacitorBonusPostPercentCapacityLocationShipGroupCapacitorCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8961; postExpression= 8962 } |> Some
      | 2820 -> { DogmaEffectData.id= 2820; name= "maxScanDeviationSelfSkillModifier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10012; postExpression= 10013 } |> Some
      | 298 -> { DogmaEffectData.id= 298; name= "surgicalStrikeFalloffBonusPostPercentFalloffLocationShipModulesRequiringGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1810; postExpression= 1811 } |> Some
      | 3499 -> { DogmaEffectData.id= 3499; name= "setBonusSyndicate"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12025; postExpression= 12026 } |> Some
      | 3596 -> { DogmaEffectData.id= 3596; name= "jumpFreightersSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12325; postExpression= 12326 } |> Some
      | 3887 -> { DogmaEffectData.id= 3887; name= "subsystemBonusCaldariElectronicCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13139; postExpression= 13140 } |> Some
      | 395 -> { DogmaEffectData.id= 395; name= "evasiveManeuveringAgilityBonusPostPercentAgilityShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2250; postExpression= 2251 } |> Some
      | 4275 -> { DogmaEffectData.id= 4275; name= "subsystemBonusCaldariPropulsion2WarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14151; postExpression= 14152 } |> Some
      | 4372 -> { DogmaEffectData.id= 4372; name= "caldariShipEwFalloffRangeCB3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14375; postExpression= 14376 } |> Some
      | 4760 -> { DogmaEffectData.id= 4760; name= "subsystemBonusCaldariPropulsionWarpCapacitor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15389; postExpression= 15390 } |> Some
      | 5051 -> { DogmaEffectData.id= 5051; name= "shipBonusSalvageCycleMF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16203; postExpression= 16204 } |> Some
      | 5342 -> { DogmaEffectData.id= 5342; name= "shipArmorRepairing1GBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16885; postExpression= 16886 } |> Some
      | 5633 -> { DogmaEffectData.id= 5633; name= "shipBonusTorpedoMissileEMDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17566; postExpression= 17567 } |> Some
      | 5827 -> { DogmaEffectData.id= 5827; name= "shipBonusTDOptimalBonusAF1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18031; postExpression= 18032 } |> Some
      | 589 -> { DogmaEffectData.id= 589; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupHybridWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3027; postExpression= 3028 } |> Some
      | 5924 -> { DogmaEffectData.id= 5924; name= "systemGravimetricECMBomb"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18288; postExpression= 18289 } |> Some
      | 6021 -> { DogmaEffectData.id= 6021; name= "shipBonusEnergyNosOptimalRS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18529; postExpression= 18530 } |> Some
      | 6409 -> { DogmaEffectData.id= 6409; name= "structureRigSensorResolution"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6506 -> { DogmaEffectData.id= 6506; name= "shipBonusDreadnoughtG1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6603 -> { DogmaEffectData.id= 6603; name= "shipBonusSupercarrierA1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6700 -> { DogmaEffectData.id= 6700; name= "rigDrawbackReductionElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19285; postExpression= 19286 } |> Some
      | 6797 -> { DogmaEffectData.id= 6797; name= "shipModeSPTDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18518; postExpression= 18519 } |> Some
      | 6894 -> { DogmaEffectData.id= 6894; name= "subsystemEnergyNeutFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19331; postExpression= 19332 } |> Some
      | 6991 -> { DogmaEffectData.id= 6991; name= "asteroidDecayTimeDisplayUpdate"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7088 -> { DogmaEffectData.id= 7088; name= "shipbonusPCTDamagePF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19517; postExpression= 19518 } |> Some
      | 7185 -> { DogmaEffectData.id= 7185; name= "shipBonusMediumDroneShieldHProle8"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19755; postExpression= 19756 } |> Some
      | _ -> None