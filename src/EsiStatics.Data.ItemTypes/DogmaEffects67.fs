namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects67=
    let getDogmaEffect id = 
      match id with 
      | 1134 -> { DogmaEffectData.id= 1134; name= "controlTowerMinmatarProjectileFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4942; postExpression= 4943 } |> Some
      | 1813 -> { DogmaEffectData.id= 1813; name= "shipShieldThermalResistanceCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6996; postExpression= 6997 } |> Some
      | 1910 -> { DogmaEffectData.id= 1910; name= "eliteBonusVampireDrainAmount2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7331; postExpression= 7332 } |> Some
      | 2201 -> { DogmaEffectData.id= 2201; name= "eliteBonusInterdictorsProjectileFalloff1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8181; postExpression= 8182 } |> Some
      | 2298 -> { DogmaEffectData.id= 2298; name= "scanStrengthBonusPercentPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8294; postExpression= 8295 } |> Some
      | 2492 -> { DogmaEffectData.id= 2492; name= "ewSkillEcmBurstCapNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9116; postExpression= 9117 } |> Some
      | 2589 -> { DogmaEffectData.id= 2589; name= "modifyBoosterEffectChanceWithBoosterChanceBonusPostPercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9403; postExpression= 9404 } |> Some
      | 3268 -> { DogmaEffectData.id= 3268; name= "miningDirectorBonusCommandBonusEffective"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11361; postExpression= 11362 } |> Some
      | 3656 -> { DogmaEffectData.id= 3656; name= "gunneryTrackingSpeedBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12240; postExpression= 12241 } |> Some
      | 3753 -> { DogmaEffectData.id= 3753; name= "eliteIndustrialExtenderSkillBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12790; postExpression= 12791 } |> Some
      | 3850 -> { DogmaEffectData.id= 3850; name= "subsystemSkillLevelGallentePropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13066; postExpression= 13067 } |> Some
      | 4044 -> { DogmaEffectData.id= 4044; name= "systemOverloadSpeedFactor"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13528; postExpression= 13529 } |> Some
      | 4335 -> { DogmaEffectData.id= 4335; name= "subsystemBonusCaldariOffensive3EwStrengthLadar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14282; postExpression= 14283 } |> Some
      | 4626 -> { DogmaEffectData.id= 4626; name= "shipBonusWarpScramblerMaxRangeGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15115; postExpression= 15116 } |> Some
      | 4820 -> { DogmaEffectData.id= 4820; name= "bcLargeEnergyTurretPowerNeedBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15554; postExpression= 15555 } |> Some
      | 5014 -> { DogmaEffectData.id= 5014; name= "shipBonusDroneDamageMultiplierRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16114; postExpression= 16115 } |> Some
      | 5111 -> { DogmaEffectData.id= 5111; name= "shipBonusDroneTrackingGF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16338; postExpression= 16339 } |> Some
      | 5208 -> { DogmaEffectData.id= 5208; name= "shipNeutDestabilizationAmountBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16563; postExpression= 16564 } |> Some
      | 5305 -> { DogmaEffectData.id= 5305; name= "shipBonusFrigateSizedMissileKineticDamageCD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16811; postExpression= 16812 } |> Some
      | 5402 -> { DogmaEffectData.id= 5402; name= "shipMissileHeavyAssaultVelocityABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16997; postExpression= 16998 } |> Some
      | 5499 -> { DogmaEffectData.id= 5499; name= "eliteBonusCommandShipsHeavyAssaultMissileExplosionRadiusCS2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17257; postExpression= 17258 } |> Some
      | 6178 -> { DogmaEffectData.id= 6178; name= "shipBonusProjectileTrackingMBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3069; postExpression= 3070 } |> Some
      | 6372 -> { DogmaEffectData.id= 6372; name= "shipRemoteArmorFalloffAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4616; postExpression= 4617 } |> Some
      | 649 -> { DogmaEffectData.id= 649; name= "anchorDrop"; description= "Anchoring this object in space."; displayName= "anchoring"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 6566 -> { DogmaEffectData.id= 6566; name= "moduleBonusFighterSupportUnit"; description= ""; displayName= ""; effectCategory= 4; preExpression= 59; postExpression= 59 } |> Some
      | 6663 -> { DogmaEffectData.id= 6663; name= "skillBonusDroneInterfacing"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 67 -> { DogmaEffectData.id= 67; name= "miningLaser"; description= ""; displayName= ""; effectCategory= 2; preExpression= 3134; postExpression= 184 } |> Some
      | 6857 -> { DogmaEffectData.id= 6857; name= "shipBonusForceAuxiliaryA1NosferatuRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6954 -> { DogmaEffectData.id= 6954; name= "subsystemBonusCommandBurstFittingReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19345; postExpression= 19346 } |> Some
      | 7051 -> { DogmaEffectData.id= 7051; name= "aoe_beacon_caustic_cloud"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | _ -> None