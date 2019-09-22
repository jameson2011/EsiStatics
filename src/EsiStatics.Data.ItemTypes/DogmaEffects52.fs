namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects52=
    let getDogmaEffect id = 
      match id with 
      | 1022 -> { DogmaEffectData.id= 1022; name= "anchorDropForStructures"; description= "Anchoring this object in space."; displayName= "anchoring"; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 1410 -> { DogmaEffectData.id= 1410; name= "propulsionSkillCapNeedBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5657; postExpression= 5658 } |> Some
      | 1895 -> { DogmaEffectData.id= 1895; name= "miningUpgradeCPUReductionBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7269; postExpression= 7270 } |> Some
      | 2186 -> { DogmaEffectData.id= 2186; name= "shipBonusDroneHitpointsGB2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8152; postExpression= 8153 } |> Some
      | 246 -> { DogmaEffectData.id= 246; name= "sensorUpgradesSkillBoostPowerNeedBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1614; postExpression= 1615 } |> Some
      | 2865 -> { DogmaEffectData.id= 2865; name= "velocityBonusOnline"; description= "Automatically generated effect"; displayName= "Max Velocity Bonus"; effectCategory= 4; preExpression= 8917; postExpression= 8918 } |> Some
      | 343 -> { DogmaEffectData.id= 343; name= "industrialConstructionIndustrialConstructionTimeBonusPostPercentIndustrialConstructionTimeChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2035; postExpression= 2036 } |> Some
      | 3447 -> { DogmaEffectData.id= 3447; name= "shipBonusPTFalloffMB1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11881; postExpression= 11882 } |> Some
      | 3835 -> { DogmaEffectData.id= 3835; name= "subsystemSkillLevelMinmatarDefensive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12983; postExpression= 12984 } |> Some
      | 4320 -> { DogmaEffectData.id= 4320; name= "subsystemBonusGallenteEngineering2DroneMWD"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14249; postExpression= 14250 } |> Some
      | 4417 -> { DogmaEffectData.id= 4417; name= "shipBonusAF1TorpedoFlightTime"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14479; postExpression= 14480 } |> Some
      | 4902 -> { DogmaEffectData.id= 4902; name= "MWDSignatureRadiusRoleBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15811; postExpression= 15812 } |> Some
      | 4999 -> { DogmaEffectData.id= 4999; name= "shipHybridRangeBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16076; postExpression= 16077 } |> Some
      | 5290 -> { DogmaEffectData.id= 5290; name= "battlecruiserSkillLevelPreMulShipBonusMBC1Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16779; postExpression= 16780 } |> Some
      | 5387 -> { DogmaEffectData.id= 5387; name= "shipHeavyAssaultMissileAOECloudSizeCC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16966; postExpression= 16967 } |> Some
      | 5484 -> { DogmaEffectData.id= 5484; name= "setBonusChristmasArmorHPBonus2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17223; postExpression= 17224 } |> Some
      | 5872 -> { DogmaEffectData.id= 5872; name= "shipBonusArmorRepairAI2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18134; postExpression= 18135 } |> Some
      | 6163 -> { DogmaEffectData.id= 6163; name= "passiveSpeedLimit"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18882; postExpression= 18883 } |> Some
      | 6260 -> { DogmaEffectData.id= 6260; name= "shipBonusEnergyNosFalloffAB2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19041; postExpression= 19042 } |> Some
      | 6357 -> { DogmaEffectData.id= 6357; name= "shipBonusJustScramblerRangeGF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19216; postExpression= 19217 } |> Some
      | 6551 -> { DogmaEffectData.id= 6551; name= "shipBonusForceAuxiliaryM1RemoteDuration"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6648 -> { DogmaEffectData.id= 6648; name= "shipBonusTitanC3WarpStrength"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6745 -> { DogmaEffectData.id= 6745; name= "behaviorWarpScramble"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 6842 -> { DogmaEffectData.id= 6842; name= "structureEngineeringRigSecurityModification"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6939 -> { DogmaEffectData.id= 6939; name= "subsystemBonusAmarrDefensive2HardenerHeat"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19338; postExpression= 19339 } |> Some
      | 7036 -> { DogmaEffectData.id= 7036; name= "shipBonusHeavyAssaultMissileEMDamageCBC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19402; postExpression= 19403 } |> Some
      | 7230 -> { DogmaEffectData.id= 7230; name= "shipBonusDroneTrackingGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16970; postExpression= 16971 } |> Some
      | _ -> None