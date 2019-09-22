namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects92=
    let getDogmaEffect id = 
      match id with 
      | 1062 -> { DogmaEffectData.id= 1062; name= "eliteBonusHeavyGunshipLaserDmg2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4674; postExpression= 4675 } |> Some
      | 1159 -> { DogmaEffectData.id= 1159; name= "controlTowerTrackingArrayProjectileTrackingBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5034; postExpression= 5035 } |> Some
      | 1256 -> { DogmaEffectData.id= 1256; name= "setBonusBloodraiderNosferatu"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5346; postExpression= 5347 } |> Some
      | 1450 -> { DogmaEffectData.id= 1450; name= "ewSkillTpFallOffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5937; postExpression= 5938 } |> Some
      | 1644 -> { DogmaEffectData.id= 1644; name= "skirmishCommandMindlink"; description= "Automatically generated effect"; displayName= "SkirmishCommandMindlink"; effectCategory= 0; preExpression= 6523; postExpression= 6524 } |> Some
      | 1838 -> { DogmaEffectData.id= 1838; name= "eliteBargeSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7094; postExpression= 7095 } |> Some
      | 189 -> { DogmaEffectData.id= 189; name= "caldariFrigateSkillBoostCfTRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1338; postExpression= 1339 } |> Some
      | 2905 -> { DogmaEffectData.id= 2905; name= "missileKineticDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10271; postExpression= 10272 } |> Some
      | 3002 -> { DogmaEffectData.id= 3002; name= "overloadSelfDurationBonus"; description= ""; displayName= ""; effectCategory= 5; preExpression= 10571; postExpression= 10572 } |> Some
      | 3196 -> { DogmaEffectData.id= 3196; name= "thermodynamicsSkillDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11172; postExpression= 11173 } |> Some
      | 3487 -> { DogmaEffectData.id= 3487; name= "shipBonusSmallEnergyTurretDamagePirateFaction"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5241; postExpression= 5242 } |> Some
      | 3681 -> { DogmaEffectData.id= 3681; name= "freighterAgilityBonusM1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12593; postExpression= 12594 } |> Some
      | 3875 -> { DogmaEffectData.id= 3875; name= "subsystemBonusGallentePropulsionABMWDCapNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13115; postExpression= 13116 } |> Some
      | 4166 -> { DogmaEffectData.id= 4166; name= "shipBonusScanProbeStrengthMF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13849; postExpression= 13850 } |> Some
      | 4263 -> { DogmaEffectData.id= 4263; name= "subsystemBonusMinmatarEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14127; postExpression= 14128 } |> Some
      | 4360 -> { DogmaEffectData.id= 4360; name= "subsystemBonusAmarrOffensiveMissileLauncherROF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14347; postExpression= 14348 } |> Some
      | 4457 -> { DogmaEffectData.id= 4457; name= "imperialsetbonus3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14616; postExpression= 14617 } |> Some
      | 4942 -> { DogmaEffectData.id= 4942; name= "targetBreaker"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 5136 -> { DogmaEffectData.id= 5136; name= "shipMETCDamageBonusAC"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 8034; postExpression= 8035 } |> Some
      | 5427 -> { DogmaEffectData.id= 5427; name= "shipBonusDroneTrackingGB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17047; postExpression= 17048 } |> Some
      | 5621 -> { DogmaEffectData.id= 5621; name= "shipBonusCruiseROFMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 9085; postExpression= 9086 } |> Some
      | 5815 -> { DogmaEffectData.id= 5815; name= "shipBonusThermalMissileDamageGF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17995; postExpression= 17996 } |> Some
      | 5912 -> { DogmaEffectData.id= 5912; name= "systemRemoteCapTransmitterAmount"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18250; postExpression= 18251 } |> Some
      | 6009 -> { DogmaEffectData.id= 6009; name= "probeLauncherCPUPercentRoleBonusT3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18515; postExpression= 18516 } |> Some
      | 6300 -> { DogmaEffectData.id= 6300; name= "shipBonusEnergyNosOptimalAC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19134; postExpression= 19135 } |> Some
      | 6591 -> { DogmaEffectData.id= 6591; name= "shipBonusSupercarrierA3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6688 -> { DogmaEffectData.id= 6688; name= "npcEntityRemoteShieldBooster"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6785 -> { DogmaEffectData.id= 6785; name= "industrialCommandShipSkillLevelMultiplierICS5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12745; postExpression= 12746 } |> Some
      | 6882 -> { DogmaEffectData.id= 6882; name= "npcBehaviorEnergyNosferatu"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6979 -> { DogmaEffectData.id= 6979; name= "rigMoonFractureDelay"; description= "Delay to fracture moon chunk"; displayName= "Asteroid extraction delay Bonus"; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7076 -> { DogmaEffectData.id= 7076; name= "largeDisintegratorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19479; postExpression= 19480 } |> Some
      | 7173 -> { DogmaEffectData.id= 7173; name= "shipBonusMutadaptiveRemoteRepAmounteliteBonusLogisitics2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19727; postExpression= 19728 } |> Some
      | 92 -> { DogmaEffectData.id= 92; name= "projectileWeaponDamageMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 667; postExpression= 670 } |> Some
      | _ -> None