namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects56=
    let getDogmaEffect id = 
      match id with 
      | 1220 -> { DogmaEffectData.id= 1220; name= "shipEnergyVampireTransferAmountBonusAc"; description= "Automatically generated effect"; displayName= "shipEnergyVampireTransferAmountBonusAB"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1996 -> { DogmaEffectData.id= 1996; name= "caldariShipEwCapacitorNeedCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2481 -> { DogmaEffectData.id= 2481; name= "warpScrambleForStructure"; description= "Attempts to prevent the target from warping."; displayName= "Warp Scramble"; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 3160 -> { DogmaEffectData.id= 3160; name= "controlTowerGenericHullResistanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3742 -> { DogmaEffectData.id= 3742; name= "cargoAndOreHoldCapacityBonusICS1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3839 -> { DogmaEffectData.id= 3839; name= "subsystemSkillLevelAmarrElectronic"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4033 -> { DogmaEffectData.id= 4033; name= "systemHeatDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 4809 -> { DogmaEffectData.id= 4809; name= "ecmGravimetricStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 4906 -> { DogmaEffectData.id= 4906; name= "systemDamageFighters"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 5294 -> { DogmaEffectData.id= 5294; name= "shipLaserTracking2AD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 541 -> { DogmaEffectData.id= 541; name= "caldariBattleshipSkillLevelPreMulShipBonusCBShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 56 -> { DogmaEffectData.id= 56; name= "powerOutputMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 5779 -> { DogmaEffectData.id= 5779; name= "shipBonusSPTFalloffMF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6361 -> { DogmaEffectData.id= 6361; name= "shipRocketExpDmgMF3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6555 -> { DogmaEffectData.id= 6555; name= "moduleBonusDroneNavigationComputer"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6652 -> { DogmaEffectData.id= 6652; name= "shipModuleAncillaryRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6846 -> { DogmaEffectData.id= 6846; name= "npcEntityTrackingDisruptor"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6943 -> { DogmaEffectData.id= 6943; name= "subsystemBonusAmarrDefensive3ArmorRepHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7040 -> { DogmaEffectData.id= 7040; name= "structureHiddenArmorHPMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7234 -> { DogmaEffectData.id= 7234; name= "implantSetMimesis"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 929 -> { DogmaEffectData.id= 929; name= "minmatarCruiserSkillLevelPreMulShipBonusMC2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None