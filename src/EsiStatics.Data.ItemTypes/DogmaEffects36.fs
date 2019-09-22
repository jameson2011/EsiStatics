namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects36=
    let getDogmaEffect id = 
      match id with 
      | 1006 -> { DogmaEffectData.id= 1006; name= "selfT2SmallHybridRailDamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4450; postExpression= 4451 } |> Some
      | 1200 -> { DogmaEffectData.id= 1200; name= "miningInfoMultiplier"; description= "Automatically generated effect"; displayName= "MiningInfoMultiplier"; effectCategory= 0; preExpression= 5190; postExpression= 5191 } |> Some
      | 1588 -> { DogmaEffectData.id= 1588; name= "capitalLauncherSkillCitadelKineticDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6356; postExpression= 6357 } |> Some
      | 1879 -> { DogmaEffectData.id= 1879; name= "entityTargetPaint"; description= ""; displayName= ""; effectCategory= 2; preExpression= 3836; postExpression= 3837 } |> Some
      | 230 -> { DogmaEffectData.id= 230; name= "afterburnerDurationBonusPostPercentDurationLocationShipModulesRequiringAfterburner"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1531; postExpression= 1532 } |> Some
      | 2849 -> { DogmaEffectData.id= 2849; name= "accessDifficultyBonusModifierRequiringHacking"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10105; postExpression= 10106 } |> Some
      | 3237 -> { DogmaEffectData.id= 3237; name= "shipRocketEmDmgAF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11256; postExpression= 11257 } |> Some
      | 3528 -> { DogmaEffectData.id= 3528; name= "drawbackCapacitorRecharge"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12129; postExpression= 12130 } |> Some
      | 4207 -> { DogmaEffectData.id= 4207; name= "subsystemSkillLevelMinmatarOffensive2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13982; postExpression= 13983 } |> Some
      | 4401 -> { DogmaEffectData.id= 4401; name= "subSystemBonusAmarrElectronic2TractorBeamVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14438; postExpression= 14439 } |> Some
      | 4789 -> { DogmaEffectData.id= 4789; name= "shipBonusSmallEnergyTurretDamageATF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 15450; postExpression= 15451 } |> Some
      | 5080 -> { DogmaEffectData.id= 5080; name= "shipMissileVelocityCF"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16281; postExpression= 16282 } |> Some
      | 521 -> { DogmaEffectData.id= 521; name= "shipHRangeBonusCC"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2783; postExpression= 2784 } |> Some
      | 5371 -> { DogmaEffectData.id= 5371; name= "entityShieldBoosting"; description= "Entity shield boosting effect for tanking NPCs"; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 5468 -> { DogmaEffectData.id= 5468; name= "shipBonusAgilityCI2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 17175; postExpression= 17176 } |> Some
      | 6147 -> { DogmaEffectData.id= 6147; name= "tacticalDestroyerGallenteSkillLevel3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18843; postExpression= 18844 } |> Some
      | 6341 -> { DogmaEffectData.id= 6341; name= "shipBonusEMArmorResistanceGD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19206; postExpression= 19207 } |> Some
      | 6535 -> { DogmaEffectData.id= 6535; name= "shipBonusForceAuxiliaryG4WarfareLinksBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6632 -> { DogmaEffectData.id= 6632; name= "skillMultiplierShipBonusTitanGallente"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6826 -> { DogmaEffectData.id= 6826; name= "rigBasCapCompManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of Basic Capital Components"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6923 -> { DogmaEffectData.id= 6923; name= "subsystemBonusMinmatarOffensive1HMLHAMVelo"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14113; postExpression= 14114 } |> Some
      | 7020 -> { DogmaEffectData.id= 7020; name= "remoteWebifierMaxRangeBonus"; description= "Stasis Webifier increase max range"; displayName= ""; effectCategory= 0; preExpression= 5539; postExpression= 5540 } |> Some
      | 7117 -> { DogmaEffectData.id= 7117; name= "roleBonusWarpSpeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3949; postExpression= 3950 } |> Some
      | 909 -> { DogmaEffectData.id= 909; name= "shipArmorHpAC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4158; postExpression= 4159 } |> Some
      | _ -> None