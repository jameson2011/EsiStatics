namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects20=
    let getDogmaEffect id = 
      match id with 
      | 1087 -> { DogmaEffectData.id= 1087; name= "eliteBonusHeavyGunshipProjectileDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1184 -> { DogmaEffectData.id= 1184; name= "shipEnergyTransferRange2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1281 -> { DogmaEffectData.id= 1281; name= "structuralAnalysisEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1669 -> { DogmaEffectData.id= 1669; name= "freighterCargoBonusC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1863 -> { DogmaEffectData.id= 1863; name= "shipMissileThermalDamageCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 214 -> { DogmaEffectData.id= 214; name= "targetingMaxTargetBonusModAddMaxLockedTargetsLocationChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2251 -> { DogmaEffectData.id= 2251; name= "commandshipMultiRelayEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2445 -> { DogmaEffectData.id= 2445; name= "iceMinerCpuUsagePercent"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 2736 -> { DogmaEffectData.id= 2736; name= "boosterArmorRepairAmountPenalty"; description= "Automatically generated effect"; displayName= "Armor Repairer Penalty"; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3027 -> { DogmaEffectData.id= 3027; name= "eliteBonusCoverOpsBombThermalDmg1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3415 -> { DogmaEffectData.id= 3415; name= "eliteBonusViolatorsLargeEnergyTurretDamageRole1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3706 -> { DogmaEffectData.id= 3706; name= "shipBonusProjectileTrackingMC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3900 -> { DogmaEffectData.id= 3900; name= "subsystemBonusAmarrCoreScanStrengthRADAR"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3997 -> { DogmaEffectData.id= 3997; name= "systemArmorExplosiveResistance"; description= ""; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 408 -> { DogmaEffectData.id= 408; name= "largeProjectileTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringLargeProjectileTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4191 -> { DogmaEffectData.id= 4191; name= "strategicCruiserAmarrSkillLevel1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4288 -> { DogmaEffectData.id= 4288; name= "subsystemBonusGallenteOffensive2RemoteArmorRepairCapUse"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4385 -> { DogmaEffectData.id= 4385; name= "eliteReconBonusHeavyAssaultMissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4482 -> { DogmaEffectData.id= 4482; name= "shipETOptimalRange2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4579 -> { DogmaEffectData.id= 4579; name= "droneRigStasisWebSpeedFactorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4773 -> { DogmaEffectData.id= 4773; name= "hackOrbital"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 4967 -> { DogmaEffectData.id= 4967; name= "shieldBoosterDurationBonusShieldSkills"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5355 -> { DogmaEffectData.id= 5355; name= "shipLargeLaserDamageBonusABC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5840 -> { DogmaEffectData.id= 5840; name= "eliteBargeBonusMiningDurationBarge2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 602 -> { DogmaEffectData.id= 602; name= "shipPTurretSpeedBonusMC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6034 -> { DogmaEffectData.id= 6034; name= "tacticalDestroyerMinmatarSkillLevel2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6131 -> { DogmaEffectData.id= 6131; name= "scriptMissileGuidanceComputerExplosionDelayBonusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6325 -> { DogmaEffectData.id= 6325; name= "scriptscanRadarStrengthBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6422 -> { DogmaEffectData.id= 6422; name= "remoteSensorDampFalloff"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6616 -> { DogmaEffectData.id= 6616; name= "shipBonusSupercarrierC4BurstProjectorBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6713 -> { DogmaEffectData.id= 6713; name= "shipBonusSupercarrierM1BurstProjectorWebBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6810 -> { DogmaEffectData.id= 6810; name= "rigDroneManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of drones"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6907 -> { DogmaEffectData.id= 6907; name= "strategicCruiserGallenteSkillLevel2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 699 -> { DogmaEffectData.id= 699; name= "signatureAnalysisScanResolutionBonusPostPercentScanResolutionShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7004 -> { DogmaEffectData.id= 7004; name= "npcStructureEwarBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7101 -> { DogmaEffectData.id= 7101; name= "structureConversionRigT2ShipManTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 796 -> { DogmaEffectData.id= 796; name= "escortShieldUpgradeCpu Bonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None