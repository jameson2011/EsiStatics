namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects94=
    let getDogmaEffect id = 
      match id with 
      | 1161 -> { DogmaEffectData.id= 1161; name= "controlTowerTrackingArrayLaserTrackingBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5040; postExpression= 5041 } |> Some
      | 1258 -> { DogmaEffectData.id= 1258; name= "skillBoostContrabandDetectionChanceBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5356; postExpression= 5357 } |> Some
      | 1452 -> { DogmaEffectData.id= 1452; name= "ewSkillEwMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5943; postExpression= 5944 } |> Some
      | 1549 -> { DogmaEffectData.id= 1549; name= "ewTargetPaint"; description= ""; displayName= ""; effectCategory= 2; preExpression= 3836; postExpression= 3837 } |> Some
      | 1646 -> { DogmaEffectData.id= 1646; name= "informationCommandMindlink"; description= "Automatically generated effect"; displayName= "InformationCommandMindlink"; effectCategory= 0; preExpression= 6535; postExpression= 6536 } |> Some
      | 2131 -> { DogmaEffectData.id= 2131; name= "smallEnergyMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8005; postExpression= 8006 } |> Some
      | 2422 -> { DogmaEffectData.id= 2422; name= "implantVelocityBonus"; description= "Automatically generated effect"; displayName= "Max Velocity Bonus"; effectCategory= 0; preExpression= 8917; postExpression= 8918 } |> Some
      | 2713 -> { DogmaEffectData.id= 2713; name= "drawbackCPUOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9751; postExpression= 9752 } |> Some
      | 2810 -> { DogmaEffectData.id= 2810; name= "eliteBonusHeavyGunshipAssaultMissileFlightTime1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9980; postExpression= 9981 } |> Some
      | 2907 -> { DogmaEffectData.id= 2907; name= "missileEMDmgBonusTorpedo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10279; postExpression= 10280 } |> Some
      | 3392 -> { DogmaEffectData.id= 3392; name= "eliteBonusBlackOpsLargeEnergyTurretTracking1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11718; postExpression= 11719 } |> Some
      | 3489 -> { DogmaEffectData.id= 3489; name= "shipBonusSmallEnergyTurretTracking2AF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11986; postExpression= 11987 } |> Some
      | 3586 -> { DogmaEffectData.id= 3586; name= "ewSkillSignalSuppressionScanResolutionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12293; postExpression= 12294 } |> Some
      | 3683 -> { DogmaEffectData.id= 3683; name= "freighterAgilityBonusA1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12597; postExpression= 12598 } |> Some
      | 4168 -> { DogmaEffectData.id= 4168; name= "eliteBonusCoverOpsScanProbeStrength2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13853; postExpression= 13854 } |> Some
      | 4265 -> { DogmaEffectData.id= 4265; name= "subsystemBonusGallenteCoreCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14131; postExpression= 14132 } |> Some
      | 4362 -> { DogmaEffectData.id= 4362; name= "subsystemBonusAmarrOffensive2MissileDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14351; postExpression= 14352 } |> Some
      | 4459 -> { DogmaEffectData.id= 4459; name= "caldarisetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14624; postExpression= 14625 } |> Some
      | 4556 -> { DogmaEffectData.id= 4556; name= "capitalLauncherSkillCruiseCitadelExplosiveDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14956; postExpression= 14957 } |> Some
      | 5138 -> { DogmaEffectData.id= 5138; name= "miningFrigateSkillLevelPostMulShipBonusORE2frig"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16396; postExpression= 16397 } |> Some
      | 5332 -> { DogmaEffectData.id= 5332; name= "shipLaserCapABC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16865; postExpression= 16866 } |> Some
      | 5429 -> { DogmaEffectData.id= 5429; name= "shipBonusMissileAoeVelocityMB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17051; postExpression= 17052 } |> Some
      | 5817 -> { DogmaEffectData.id= 5817; name= "shipBonusLightDroneHPPirateFaction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18001; postExpression= 18002 } |> Some
      | 5914 -> { DogmaEffectData.id= 5914; name= "systemEnergyNeutMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18254; postExpression= 18255 } |> Some
      | 6011 -> { DogmaEffectData.id= 6011; name= "shipModeSETOptimalRangePostDiv"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18518; postExpression= 18519 } |> Some
      | 6593 -> { DogmaEffectData.id= 6593; name= "shipBonusSupercarrierG3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6690 -> { DogmaEffectData.id= 6690; name= "remoteWebifierEntity"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6787 -> { DogmaEffectData.id= 6787; name= "shipBonusDroneHPDamageMiningICS4"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6884 -> { DogmaEffectData.id= 6884; name= "npcBehaviorArmorRepairer"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 6981 -> { DogmaEffectData.id= 6981; name= "shipBonusTitanG1KinThermDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 7078 -> { DogmaEffectData.id= 7078; name= "disintegratorWeaponSpeedMultiply"; description= "Automatically generated effect"; displayName= ""; effectCategory= 4; preExpression= 19489; postExpression= 19490 } |> Some
      | _ -> None