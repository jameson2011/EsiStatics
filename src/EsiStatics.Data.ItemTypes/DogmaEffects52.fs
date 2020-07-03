namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects52=
    let getDogmaEffect id = 
      match id with 
      | 1022 -> { DogmaEffectData.id= 1022; name= "anchorDropForStructures"; description= "Anchoring this object in space."; displayName= "anchoring"; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1410 -> { DogmaEffectData.id= 1410; name= "propulsionSkillCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 1895 -> { DogmaEffectData.id= 1895; name= "miningUpgradeCPUReductionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2186 -> { DogmaEffectData.id= 2186; name= "shipBonusDroneHitpointsGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 246 -> { DogmaEffectData.id= 246; name= "sensorUpgradesSkillBoostPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2865 -> { DogmaEffectData.id= 2865; name= "velocityBonusOnline"; description= "Automatically generated effect"; displayName= "Max Velocity Bonus"; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | 343 -> { DogmaEffectData.id= 343; name= "industrialConstructionIndustrialConstructionTimeBonusPostPercentIndustrialConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3447 -> { DogmaEffectData.id= 3447; name= "shipBonusPTFalloffMB1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3835 -> { DogmaEffectData.id= 3835; name= "subsystemSkillLevelMinmatarDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4320 -> { DogmaEffectData.id= 4320; name= "subsystemBonusGallenteEngineering2DroneMWD"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4417 -> { DogmaEffectData.id= 4417; name= "shipBonusAF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4902 -> { DogmaEffectData.id= 4902; name= "MWDSignatureRadiusRoleBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4999 -> { DogmaEffectData.id= 4999; name= "shipHybridRangeBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5290 -> { DogmaEffectData.id= 5290; name= "battlecruiserSkillLevelPreMulShipBonusMBC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5387 -> { DogmaEffectData.id= 5387; name= "shipHeavyAssaultMissileAOECloudSizeCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5484 -> { DogmaEffectData.id= 5484; name= "setBonusChristmasArmorHPBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5872 -> { DogmaEffectData.id= 5872; name= "shipBonusArmorRepairAI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6163 -> { DogmaEffectData.id= 6163; name= "passiveSpeedLimit"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6260 -> { DogmaEffectData.id= 6260; name= "shipBonusEnergyNosFalloffAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6357 -> { DogmaEffectData.id= 6357; name= "shipBonusJustScramblerRangeGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6551 -> { DogmaEffectData.id= 6551; name= "shipBonusForceAuxiliaryM1RemoteDuration"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6648 -> { DogmaEffectData.id= 6648; name= "shipBonusTitanC3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6745 -> { DogmaEffectData.id= 6745; name= "behaviorWarpScramble"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 6842 -> { DogmaEffectData.id= 6842; name= "structureEngineeringRigSecurityModification"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6939 -> { DogmaEffectData.id= 6939; name= "subsystemBonusAmarrDefensive2HardenerHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7036 -> { DogmaEffectData.id= 7036; name= "shipBonusHeavyAssaultMissileEMDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7230 -> { DogmaEffectData.id= 7230; name= "shipBonusDroneTrackingGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None