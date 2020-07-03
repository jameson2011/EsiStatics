namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects63=
    let getDogmaEffect id = 
      match id with 
      | 1033 -> { DogmaEffectData.id= 1033; name= "eliteBonusLogisticRemoteArmorRepairCapNeed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1130 -> { DogmaEffectData.id= 1130; name= "controlTowerAmarrLaserOptimalBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 160 -> { DogmaEffectData.id= 160; name= "mediumHybridTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringMediumHybridTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1615 -> { DogmaEffectData.id= 1615; name= "shipAdvancedSpaceshipCommandAgilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2197 -> { DogmaEffectData.id= 2197; name= "entityArmorRepairingLarge"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2488 -> { DogmaEffectData.id= 2488; name= "implantVelocityBonus2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3264 -> { DogmaEffectData.id= 3264; name= "skillIndustrialReconfigurationConsumptionQuantityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3652 -> { DogmaEffectData.id= 3652; name= "ewGroupTdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3846 -> { DogmaEffectData.id= 3846; name= "subsystemSkillLevelCaldariOffensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4040 -> { DogmaEffectData.id= 4040; name= "systemOverloadRange"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4137 -> { DogmaEffectData.id= 4137; name= "systemShieldKineticResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4331 -> { DogmaEffectData.id= 4331; name= "subsystemBonusCaldariOffensive3HMLHAMVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4622 -> { DogmaEffectData.id= 4622; name= "shipBonusSmallHybridMaxRangeATF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4913 -> { DogmaEffectData.id= 4913; name= "missileDamageMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5107 -> { DogmaEffectData.id= 5107; name= "shipBonusRemoteArmorRepairCapNeedGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5398 -> { DogmaEffectData.id= 5398; name= "systemScanDurationModuleModifier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 548 -> { DogmaEffectData.id= 548; name= "minmatarBattleshipSkillLevelPreMulShipBonusMBShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6077 -> { DogmaEffectData.id= 6077; name= "shipHeatDamageCaldariTacticalDestroyer3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6174 -> { DogmaEffectData.id= 6174; name= "battlecruiserMPTRange"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 63 -> { DogmaEffectData.id= 63; name= "armorHPMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6368 -> { DogmaEffectData.id= 6368; name= "shieldTransporterFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6465 -> { DogmaEffectData.id= 6465; name= "fighterAbilityAttackM"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6562 -> { DogmaEffectData.id= 6562; name= "skillBonusSupportFightersShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6756 -> { DogmaEffectData.id= 6756; name= "npcBehaviorEnergyNeutralizer"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6853 -> { DogmaEffectData.id= 6853; name= "shipBonusTitanA1EnergyWarfareAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7047 -> { DogmaEffectData.id= 7047; name= "roleBonusFlagCruiserModuleFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7241 -> { DogmaEffectData.id= 7241; name= "skillMultiplierShipBonusDreadnoughtPrecursor"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8017 -> { DogmaEffectData.id= 8017; name= "saviorSetBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None