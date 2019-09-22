namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects87=
    let getDogmaEffect id = 
      match id with 
      | 1057 -> { DogmaEffectData.id= 1057; name= "eliteBonusHeavyGunshipProjectileOptimal1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4660; postExpression= 4661 } |> Some
      | 1445 -> { DogmaEffectData.id= 1445; name= "ewSkillRsdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5915; postExpression= 5916 } |> Some
      | 2706 -> { DogmaEffectData.id= 2706; name= "drawbackPowerNeedLasers"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9738; postExpression= 9739 } |> Some
      | 2803 -> { DogmaEffectData.id= 2803; name= "energyWeaponDamageMultiplyPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 668; postExpression= 671 } |> Some
      | 2900 -> { DogmaEffectData.id= 2900; name= "missileExplosiveDmgBonusHeavy"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10255; postExpression= 10256 } |> Some
      | 3773 -> { DogmaEffectData.id= 3773; name= "hardPointModifierEffect"; description= "Anchoring this object in space."; displayName= ""; effectCategory= 0; preExpression= 131; postExpression= 131 } |> Some
      | 3870 -> { DogmaEffectData.id= 3870; name= "subsystemBonusGallentePropulsionMWDPenalty"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13105; postExpression= 13106 } |> Some
      | 4161 -> { DogmaEffectData.id= 4161; name= "baseMaxScanDeviationModifierRequiringAstrometrics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13834; postExpression= 13835 } |> Some
      | 4258 -> { DogmaEffectData.id= 4258; name= "subsystemBonusMinmatarOffensiveHeavyMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14117; postExpression= 14118 } |> Some
      | 4452 -> { DogmaEffectData.id= 4452; name= "ScanLadarStrengthModifierEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14598; postExpression= 14599 } |> Some
      | 5131 -> { DogmaEffectData.id= 5131; name= "shipMissileRofCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16384; postExpression= 16385 } |> Some
      | 5228 -> { DogmaEffectData.id= 5228; name= "shipHeavyMissileThermDmgPirateCruiser"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16615; postExpression= 16616 } |> Some
      | 5325 -> { DogmaEffectData.id= 5325; name= "shipArmorThermResistance1ABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16851; postExpression= 16852 } |> Some
      | 5422 -> { DogmaEffectData.id= 5422; name= "shipBonusEnergyVampireRangeAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17037; postExpression= 17038 } |> Some
      | 5810 -> { DogmaEffectData.id= 5810; name= "shipBonusHeavyDroneHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17985; postExpression= 17986 } |> Some
      | 5907 -> { DogmaEffectData.id= 5907; name= "advancedIndustryInventionTimeBonusPostPercent"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18239; postExpression= 18240 } |> Some
      | 6004 -> { DogmaEffectData.id= 6004; name= "tacticalDestroyerAmarrSkillLevel2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18499; postExpression= 18500 } |> Some
      | 6489 -> { DogmaEffectData.id= 6489; name= "skillMultiplierShipBonusDreadnoughtAmarr"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6586 -> { DogmaEffectData.id= 6586; name= "skillMultiplierShipBonusCarrierMinmatar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6683 -> { DogmaEffectData.id= 6683; name= "structureModuleEffectTargetPainter"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6780 -> { DogmaEffectData.id= 6780; name= "miningForemanStrengthBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6877 -> { DogmaEffectData.id= 6877; name= "eliteBonusBlackOpsWarpVelocity1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19327; postExpression= 19328 } |> Some
      | 6974 -> { DogmaEffectData.id= 6974; name= "rigReactionBioTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7071 -> { DogmaEffectData.id= 7071; name= "smallPrecursorTurretDmgBonusRequiredSkill"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19449; postExpression= 19450 } |> Some
      | 7168 -> { DogmaEffectData.id= 7168; name= "shipBonusMutadaptiveRemoteRepairRangeRole3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19713; postExpression= 19714 } |> Some
      | 87 -> { DogmaEffectData.id= 87; name= "cpuUsageMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 638; postExpression= 639 } |> Some
      | 960 -> { DogmaEffectData.id= 960; name= "shipArmorKineticResistanceAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4262; postExpression= 4263 } |> Some
      | _ -> None