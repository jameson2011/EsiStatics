namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects58=
    let getDogmaEffect id = 
      match id with 
      | 1222 -> { DogmaEffectData.id= 1222; name= "shipStasisWebRangeBonusMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1804 -> { DogmaEffectData.id= 1804; name= "shipArmorEMResistanceAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2192 -> { DogmaEffectData.id= 2192; name= "entityShieldBoostingSmall"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 2580 -> { DogmaEffectData.id= 2580; name= "neurotoxinRecoverySkillBoostChanceBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3356 -> { DogmaEffectData.id= 3356; name= "eliteBonusHeavyInterdictorHeavyAssaultMissileVelocityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 349 -> { DogmaEffectData.id= 349; name= "diplomacyDiplomacyMutatorModAddDiplomacyBonusChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3744 -> { DogmaEffectData.id= 3744; name= "miningForemanBurstBonusICS2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3841 -> { DogmaEffectData.id= 3841; name= "subsystemSkillLevelCaldariEngineering"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4035 -> { DogmaEffectData.id= 4035; name= "systemOverloadDamageModifier"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 446 -> { DogmaEffectData.id= 446; name= "shieldManagementShieldCapacityBonusPostPercentCapacityLocationShipGroupShield"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4811 -> { DogmaEffectData.id= 4811; name= "ecmMagnetometricStrengthBonusPercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 4908 -> { DogmaEffectData.id= 4908; name= "modifyShieldArmorHullResonancePostPercent"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 58 -> { DogmaEffectData.id= 58; name= "capacitorCapacityMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 6557 -> { DogmaEffectData.id= 6557; name= "moduleBonusOmnidirectionalTrackingLink"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 6654 -> { DogmaEffectData.id= 6654; name= "shipBonusTitanG2ROFBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6848 -> { DogmaEffectData.id= 6848; name= "shipModuleFocusedWarpScramblingScript"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6945 -> { DogmaEffectData.id= 6945; name= "subsystemBonusCaldariDefensive3ShieldBoostHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7042 -> { DogmaEffectData.id= 7042; name= "shipArmorHitPointsAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7236 -> { DogmaEffectData.id= 7236; name= "systemWarpSpeed"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 834 -> { DogmaEffectData.id= 834; name= "ammoInfluenceCapRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None