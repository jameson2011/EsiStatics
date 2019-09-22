namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects65=
    let getDogmaEffect id = 
      match id with 
      | 1035 -> { DogmaEffectData.id= 1035; name= "eliteBonusLogisticShieldTransferCapNeed2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4584; postExpression= 4585 } |> Some
      | 1617 -> { DogmaEffectData.id= 1617; name= "shipCapitalAgilityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6420; postExpression= 6421 } |> Some
      | 162 -> { DogmaEffectData.id= 162; name= "largeEnergyTurretDamageMultiplierBonusPostPercentDamageMultiplierLocationShipModulesRequiringLargeEnergyTurret"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1174; postExpression= 1175 } |> Some
      | 1908 -> { DogmaEffectData.id= 1908; name= "reconShipSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7325; postExpression= 7326 } |> Some
      | 2296 -> { DogmaEffectData.id= 2296; name= "modifyArmorResonancePassivePostPercentPassive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7861; postExpression= 7862 } |> Some
      | 2490 -> { DogmaEffectData.id= 2490; name= "shipBonusRemoteTrackingComputerFalloffGC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9105; postExpression= 9106 } |> Some
      | 3169 -> { DogmaEffectData.id= 3169; name= "shieldTransportCpuNeedBonusEffect"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11069; postExpression= 11070 } |> Some
      | 3557 -> { DogmaEffectData.id= 3557; name= "gunneryMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 1; preExpression= 12236; postExpression= 12237 } |> Some
      | 3848 -> { DogmaEffectData.id= 3848; name= "subsystemSkillLevelAmarrPropulsion"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13056; postExpression= 13057 } |> Some
      | 4042 -> { DogmaEffectData.id= 4042; name= "systemOverloadSelfDuration"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13520; postExpression= 13521 } |> Some
      | 4527 -> { DogmaEffectData.id= 4527; name= "gunneryFalloffBonusOnline"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14834; postExpression= 14835 } |> Some
      | 453 -> { DogmaEffectData.id= 453; name= "minmatarFrigateSkillLevelPreMulShipBonusMFShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2500; postExpression= 2501 } |> Some
      | 4624 -> { DogmaEffectData.id= 4624; name= "shipBonusHybridTrackingATC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15111; postExpression= 15112 } |> Some
      | 5012 -> { DogmaEffectData.id= 5012; name= "shipShieldThermalResistanceRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16108; postExpression= 16109 } |> Some
      | 5109 -> { DogmaEffectData.id= 5109; name= "shipBonusRemoteArmorRepairCapNeedAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16333; postExpression= 16334 } |> Some
      | 5206 -> { DogmaEffectData.id= 5206; name= "shipSETOptimalBonusRookie"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16557; postExpression= 16558 } |> Some
      | 5303 -> { DogmaEffectData.id= 5303; name= "shipHybridRange1CD1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16807; postExpression= 16808 } |> Some
      | 5497 -> { DogmaEffectData.id= 5497; name= "eliteBonusCommandShipHMRoFCS1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17251; postExpression= 17252 } |> Some
      | 550 -> { DogmaEffectData.id= 550; name= "shipHTDmgBonusGB"; description= "Automatically generated effect"; displayName= "shipHTDmgBonus"; effectCategory= 0; preExpression= 2893; postExpression= 2894 } |> Some
      | 6079 -> { DogmaEffectData.id= 6079; name= "tacticalDestroyerCaldariSkillLevel2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18665; postExpression= 18666 } |> Some
      | 6176 -> { DogmaEffectData.id= 6176; name= "battlecruiserDroneSpeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18911; postExpression= 18912 } |> Some
      | 6273 -> { DogmaEffectData.id= 6273; name= "shipBonusEnergyNosOptimalEAF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19074; postExpression= 19075 } |> Some
      | 6370 -> { DogmaEffectData.id= 6370; name= "shipShieldTransferFalloffCC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4620; postExpression= 4621 } |> Some
      | 6661 -> { DogmaEffectData.id= 6661; name= "shipBonusCarrierM3FighterVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6855 -> { DogmaEffectData.id= 6855; name= "shipBonusDreadnoughtA1EnergyWarfareAmountBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 744 -> { DogmaEffectData.id= 744; name= "surveyScanspeedBonusPostPercentDurationLocationShipModulesRequiringElectronics"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3587; postExpression= 3588 } |> Some
      | _ -> None