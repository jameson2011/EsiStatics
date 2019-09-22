namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects20=
    let getDogmaEffect id = 
      match id with 
      | 1087 -> { DogmaEffectData.id= 1087; name= "eliteBonusHeavyGunshipProjectileDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4750; postExpression= 4751 } |> Some
      | 1184 -> { DogmaEffectData.id= 1184; name= "shipEnergyTransferRange2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5141; postExpression= 5142 } |> Some
      | 1281 -> { DogmaEffectData.id= 1281; name= "structuralAnalysisEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5408; postExpression= 5409 } |> Some
      | 1669 -> { DogmaEffectData.id= 1669; name= "freighterCargoBonusC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6619; postExpression= 6620 } |> Some
      | 1863 -> { DogmaEffectData.id= 1863; name= "shipMissileThermalDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7173; postExpression= 7174 } |> Some
      | 214 -> { DogmaEffectData.id= 214; name= "targetingMaxTargetBonusModAddMaxLockedTargetsLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1453; postExpression= 1454 } |> Some
      | 2251 -> { DogmaEffectData.id= 2251; name= "commandshipMultiRelayEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6083; postExpression= 6084 } |> Some
      | 2445 -> { DogmaEffectData.id= 2445; name= "iceMinerCpuUsagePercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 8998; postExpression= 8999 } |> Some
      | 2736 -> { DogmaEffectData.id= 2736; name= "boosterArmorRepairAmountPenalty"; description= "Automatically generated effect"; displayName= "Armor Repairer Penalty"; effectCategory= 0; preExpression= 9825; postExpression= 9826 } |> Some
      | 3027 -> { DogmaEffectData.id= 3027; name= "eliteBonusCoverOpsBombThermalDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10658; postExpression= 10659 } |> Some
      | 3415 -> { DogmaEffectData.id= 3415; name= "eliteBonusViolatorsLargeEnergyTurretDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11804; postExpression= 11805 } |> Some
      | 3706 -> { DogmaEffectData.id= 3706; name= "shipBonusProjectileTrackingMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4178; postExpression= 4179 } |> Some
      | 3900 -> { DogmaEffectData.id= 3900; name= "subsystemBonusAmarrCoreScanStrengthRADAR"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13167; postExpression= 13168 } |> Some
      | 3997 -> { DogmaEffectData.id= 3997; name= "systemArmorExplosiveResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13356; postExpression= 13357 } |> Some
      | 408 -> { DogmaEffectData.id= 408; name= "largeProjectileTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringLargeProjectileTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2306; postExpression= 2307 } |> Some
      | 4191 -> { DogmaEffectData.id= 4191; name= "strategicCruiserAmarrSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13905; postExpression= 13906 } |> Some
      | 4288 -> { DogmaEffectData.id= 4288; name= "subsystemBonusGallenteOffensive2RemoteArmorRepairCapUse"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14178; postExpression= 14179 } |> Some
      | 4385 -> { DogmaEffectData.id= 4385; name= "eliteReconBonusHeavyAssaultMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14406; postExpression= 14407 } |> Some
      | 4482 -> { DogmaEffectData.id= 4482; name= "shipETOptimalRange2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4768; postExpression= 4769 } |> Some
      | 4579 -> { DogmaEffectData.id= 4579; name= "droneRigStasisWebSpeedFactorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15008; postExpression= 15009 } |> Some
      | 4773 -> { DogmaEffectData.id= 4773; name= "hackOrbital"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 4967 -> { DogmaEffectData.id= 4967; name= "shieldBoosterDurationBonusShieldSkills"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15994; postExpression= 15995 } |> Some
      | 5355 -> { DogmaEffectData.id= 5355; name= "shipLargeLaserDamageBonusABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16911; postExpression= 16912 } |> Some
      | 5840 -> { DogmaEffectData.id= 5840; name= "eliteBargeBonusMiningDurationBarge2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18057; postExpression= 18058 } |> Some
      | 602 -> { DogmaEffectData.id= 602; name= "shipPTurretSpeedBonusMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3069; postExpression= 3070 } |> Some
      | 6034 -> { DogmaEffectData.id= 6034; name= "tacticalDestroyerMinmatarSkillLevel2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18565; postExpression= 18566 } |> Some
      | 6131 -> { DogmaEffectData.id= 6131; name= "scriptMissileGuidanceComputerExplosionDelayBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18796; postExpression= 18797 } |> Some
      | 6325 -> { DogmaEffectData.id= 6325; name= "scriptscanRadarStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6422 -> { DogmaEffectData.id= 6422; name= "remoteSensorDampFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6616 -> { DogmaEffectData.id= 6616; name= "shipBonusSupercarrierC4BurstProjectorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6713 -> { DogmaEffectData.id= 6713; name= "shipBonusSupercarrierM1BurstProjectorWebBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6810 -> { DogmaEffectData.id= 6810; name= "rigDroneManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of drones"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6907 -> { DogmaEffectData.id= 6907; name= "strategicCruiserGallenteSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13913; postExpression= 13914 } |> Some
      | 699 -> { DogmaEffectData.id= 699; name= "signatureAnalysisScanResolutionBonusPostPercentScanResolutionShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3427; postExpression= 3428 } |> Some
      | 7004 -> { DogmaEffectData.id= 7004; name= "npcStructureEwarBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7101 -> { DogmaEffectData.id= 7101; name= "structureConversionRigT2ShipManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 227; postExpression= 228 } |> Some
      | 796 -> { DogmaEffectData.id= 796; name= "escortShieldUpgradeCpu Bonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3775; postExpression= 3776 } |> Some
      | _ -> None