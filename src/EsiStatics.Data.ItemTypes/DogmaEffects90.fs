namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects90=
    let getDogmaEffect id = 
      match id with 
      | 1060 -> { DogmaEffectData.id= 1060; name= "eliteBonusHeavyGunshipProjectileFallOff1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4670; postExpression= 4671 } |> Some
      | 1157 -> { DogmaEffectData.id= 1157; name= "controlTowerTrackingArrayLaserOptimalBonus"; description= ""; displayName= ""; effectCategory= 4; preExpression= 5028; postExpression= 5029 } |> Some
      | 1448 -> { DogmaEffectData.id= 1448; name= "ewSkillTdMaxRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5929; postExpression= 5930 } |> Some
      | 187 -> { DogmaEffectData.id= 187; name= "caldariCruiserSkillBoostCcTRangeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1331; postExpression= 1332 } |> Some
      | 2903 -> { DogmaEffectData.id= 2903; name= "missileEMDmgBonusHAM"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10265; postExpression= 10266 } |> Some
      | 3679 -> { DogmaEffectData.id= 3679; name= "eliteBonusJumpFreighterArmorHP1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12589; postExpression= 12590 } |> Some
      | 4261 -> { DogmaEffectData.id= 4261; name= "subsystemBonusCaldariEngineeringPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14123; postExpression= 14124 } |> Some
      | 4358 -> { DogmaEffectData.id= 4358; name= "ecmRangeBonusModuleEffect"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14343; postExpression= 14344 } |> Some
      | 4649 -> { DogmaEffectData.id= 4649; name= "shipCruiseAndSiegeLauncherROFBonus2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15159; postExpression= 15160 } |> Some
      | 5231 -> { DogmaEffectData.id= 5231; name= "modifyActiveArmorResonancePostPercent"; description= ""; displayName= ""; effectCategory= 1; preExpression= 7725; postExpression= 7726 } |> Some
      | 5619 -> { DogmaEffectData.id= 5619; name= "shipBonusRHMLROFCB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17542; postExpression= 17543 } |> Some
      | 575 -> { DogmaEffectData.id= 575; name= "modifyTargetSpeed2"; description= ""; displayName= "modifyTargetSpeed"; effectCategory= 2; preExpression= 3489; postExpression= 3491 } |> Some
      | 5813 -> { DogmaEffectData.id= 5813; name= "shipBonusAfterburnerSpeedFactorCF2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17991; postExpression= 17992 } |> Some
      | 5910 -> { DogmaEffectData.id= 5910; name= "advancedIndustryMaterialResearchTimeBonusPostPercent"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18247; postExpression= 18248 } |> Some
      | 6007 -> { DogmaEffectData.id= 6007; name= "shipSETCapNeedAmarrTacticalDestroyer2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18508; postExpression= 18509 } |> Some
      | 6104 -> { DogmaEffectData.id= 6104; name= "entosisDurationMultiply"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18722; postExpression= 18723 } |> Some
      | 6201 -> { DogmaEffectData.id= 6201; name= "doomsdaySlash"; description= ""; displayName= ""; effectCategory= 1; preExpression= 131; postExpression= 131 } |> Some
      | 6395 -> { DogmaEffectData.id= 6395; name= "shipBonusEwWeaponDisruptionStrengthAC1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17933; postExpression= 17934 } |> Some
      | 6492 -> { DogmaEffectData.id= 6492; name= "skillMultiplierShipBonusDreadnoughtCaldari"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6589 -> { DogmaEffectData.id= 6589; name= "skillMultiplierShipBonusSupercarrierGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6686 -> { DogmaEffectData.id= 6686; name= "structureModuleEffectWeaponDisruption"; description= ""; displayName= ""; effectCategory= 2; preExpression= 59; postExpression= 59 } |> Some
      | 672 -> { DogmaEffectData.id= 672; name= "weaponUpgradesSkillBoostCpu"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3350; postExpression= 3351 } |> Some
      | 6783 -> { DogmaEffectData.id= 6783; name= "commandBurstAoERoleBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6880 -> { DogmaEffectData.id= 6880; name= "shipBonusLauncherRoF2CB"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6977 -> { DogmaEffectData.id= 6977; name= "rigMoonSpewVolBonus"; description= "increases volume of asteroids created from moon drill"; displayName= "Drill Volume Bonus"; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7074 -> { DogmaEffectData.id= 7074; name= "smallDisintegratorSkillDmgBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19467; postExpression= 19468 } |> Some
      | 7171 -> { DogmaEffectData.id= 7171; name= "shipBonusMutadaptiveRemoteRepRangePC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19723; postExpression= 19724 } |> Some
      | _ -> None