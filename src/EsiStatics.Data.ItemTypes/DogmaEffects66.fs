namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects66=
    let getDogmaEffect id = 
      match id with 
      | 1036 -> { DogmaEffectData.id= 1036; name= "eliteBonusLogisticShieldTransferCapNeed1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4586; postExpression= 4587 } |> Some
      | 1133 -> { DogmaEffectData.id= 1133; name= "controlTowerMinmatarProjectileOptimalBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4938; postExpression= 4939 } |> Some
      | 1230 -> { DogmaEffectData.id= 1230; name= "shipMissileVelocityPirateFactionFrigate"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5279; postExpression= 5280 } |> Some
      | 163 -> { DogmaEffectData.id= 163; name= "rapidFiringSkillBoostRofBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1217; postExpression= 1218 } |> Some
      | 1812 -> { DogmaEffectData.id= 1812; name= "shipShieldEMResistanceCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6994; postExpression= 6995 } |> Some
      | 1909 -> { DogmaEffectData.id= 1909; name= "reconShipSkillMultiplier2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7329; postExpression= 7330 } |> Some
      | 2200 -> { DogmaEffectData.id= 2200; name= "eliteBonusInterdictorsMissileKineticDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8179; postExpression= 8180 } |> Some
      | 2297 -> { DogmaEffectData.id= 2297; name= "modifyShieldResonancePassivePostPercentPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7982; postExpression= 7983 } |> Some
      | 2491 -> { DogmaEffectData.id= 2491; name= "ewSkillEcmBurstRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9112; postExpression= 9113 } |> Some
      | 3267 -> { DogmaEffectData.id= 3267; name= "shipConsumptionQuantityBonusIndustrialReconfigurationORECapital1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11359; postExpression= 11360 } |> Some
      | 3655 -> { DogmaEffectData.id= 3655; name= "gunneryMaxRangeBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12236; postExpression= 12237 } |> Some
      | 3849 -> { DogmaEffectData.id= 3849; name= "subsystemSkillLevelCaldariPropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13061; postExpression= 13062 } |> Some
      | 4043 -> { DogmaEffectData.id= 4043; name= "systemOverloadShieldBonus"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13524; postExpression= 13525 } |> Some
      | 4334 -> { DogmaEffectData.id= 4334; name= "subsystemBonusCaldariOffensive3EwStrengthGrav"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14280; postExpression= 14281 } |> Some
      | 4625 -> { DogmaEffectData.id= 4625; name= "shipBonusHybridFalloffATC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15113; postExpression= 15114 } |> Some
      | 5013 -> { DogmaEffectData.id= 5013; name= "shipSHTDmgBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16111; postExpression= 16112 } |> Some
      | 5110 -> { DogmaEffectData.id= 5110; name= "shipBonusRemoteArmorRepairAmount2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16335; postExpression= 16336 } |> Some
      | 5207 -> { DogmaEffectData.id= 5207; name= "shipNOSTransferAmountBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16560; postExpression= 16561 } |> Some
      | 5304 -> { DogmaEffectData.id= 5304; name= "shipHybridTrackingCD2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16809; postExpression= 16810 } |> Some
      | 5498 -> { DogmaEffectData.id= 5498; name= "eliteBonusCommandShipsHeavyAssaultMissileExplosionVelocityCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17255; postExpression= 17256 } |> Some
      | 5789 -> { DogmaEffectData.id= 5789; name= "miningAmountBonusBonusActivation"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 17927; postExpression= 17928 } |> Some
      | 5983 -> { DogmaEffectData.id= 5983; name= "resistanceKillerShieldAll"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18440; postExpression= 18441 } |> Some
      | 6080 -> { DogmaEffectData.id= 6080; name= "tacticalDestroyerCaldariSkillLevel3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18669; postExpression= 18670 } |> Some
      | 6177 -> { DogmaEffectData.id= 6177; name= "shipHybridDmg1CBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16883; postExpression= 16884 } |> Some
      | 6371 -> { DogmaEffectData.id= 6371; name= "shipRemoteArmorFalloffGC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4614; postExpression= 4615 } |> Some
      | 648 -> { DogmaEffectData.id= 648; name= "shipSpecialityMining"; description= "Automatically generated effect"; displayName= "deepCoreMiningCPUReduction"; effectCategory= 0; preExpression= 3257; postExpression= 3258 } |> Some
      | 6565 -> { DogmaEffectData.id= 6565; name= "citadelRigBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6662 -> { DogmaEffectData.id= 6662; name= "shipBonusCarrierG3FighterHitpoints"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6759 -> { DogmaEffectData.id= 6759; name= "engComplexServiceFuelBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6856 -> { DogmaEffectData.id= 6856; name= "shipBonusDreadnoughtM1WebRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6953 -> { DogmaEffectData.id= 6953; name= "mediumRemoteRepFittingAdjustment"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19342; postExpression= 19343 } |> Some
      | 7050 -> { DogmaEffectData.id= 7050; name= "aoe_beacon_bioluminescence_cloud"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | _ -> None