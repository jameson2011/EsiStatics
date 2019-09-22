﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects30=
    let getDogmaEffect id = 
      match id with 
      | 127 -> { DogmaEffectData.id= 127; name= "torpedoLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 114; postExpression= 131 } |> Some
      | 1291 -> { DogmaEffectData.id= 1291; name= "caldariIndustrialSkillLevelPreMulShipBonusCI2Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5446; postExpression= 5447 } |> Some
      | 1582 -> { DogmaEffectData.id= 1582; name= "jumpDriveSkillsRangeBonusSkillLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 6325; postExpression= 6326 } |> Some
      | 2649 -> { DogmaEffectData.id= 2649; name= "eliteBonusHeavyGunshipAssaultMissileLaunhcerRof2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9578; postExpression= 9579 } |> Some
      | 2746 -> { DogmaEffectData.id= 2746; name= "boosterMaxVelocityPenalty"; description= "Automatically generated effect"; displayName= "Max Velocity Penalty"; effectCategory= 0; preExpression= 9847; postExpression= 9848 } |> Some
      | 321 -> { DogmaEffectData.id= 321; name= "gallenteTechSkillBoostGallenteTechMutator"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1912; postExpression= 1913 } |> Some
      | 3425 -> { DogmaEffectData.id= 3425; name= "eliteBonusViolatorsLargeProjectileTurretTracking1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11824; postExpression= 11825 } |> Some
      | 3522 -> { DogmaEffectData.id= 3522; name= "skillNaniteOperationRepairCostLevel"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12103; postExpression= 12104 } |> Some
      | 3619 -> { DogmaEffectData.id= 3619; name= "scriptSpeedBoostFactorBonusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12432; postExpression= 12433 } |> Some
      | 4104 -> { DogmaEffectData.id= 4104; name= "subsystemBonusCaldariOffensiveHybridWeaponMaxRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13712; postExpression= 13713 } |> Some
      | 4201 -> { DogmaEffectData.id= 4201; name= "subsystemSkillLevelCaldariElectronic2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13952; postExpression= 13953 } |> Some
      | 4395 -> { DogmaEffectData.id= 4395; name= "shipBonusEliteCover2TorpedoExplosiveDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14426; postExpression= 14427 } |> Some
      | 4492 -> { DogmaEffectData.id= 4492; name= "superWeaponMinmatar"; description= ""; displayName= ""; effectCategory= 2; preExpression= 131; postExpression= 131 } |> Some
      | 4686 -> { DogmaEffectData.id= 4686; name= "NPCGroupShieldAssist"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 89 } |> Some
      | 5268 -> { DogmaEffectData.id= 5268; name= "drawbackCapRepPGNeed"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16700; postExpression= 16701 } |> Some
      | 5365 -> { DogmaEffectData.id= 5365; name= "eliteBonusViolatorsRepairSystemsArmorDamageAmount2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16929; postExpression= 16930 } |> Some
      | 5559 -> { DogmaEffectData.id= 5559; name= "shipBonusShieldBoostAmountMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17396; postExpression= 17397 } |> Some
      | 5850 -> { DogmaEffectData.id= 5850; name= "expeditionFrigateSkillLevelPostMulEliteBonusExpedition1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18086; postExpression= 18087 } |> Some
      | 6044 -> { DogmaEffectData.id= 6044; name= "gallenteCruiserSkillLevelPreMulShipBonusGC3Ship"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18591; postExpression= 18592 } |> Some
      | 6238 -> { DogmaEffectData.id= 6238; name= "shipBonusEnergyNosFalloffRS3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18991; postExpression= 18992 } |> Some
      | 6335 -> { DogmaEffectData.id= 6335; name= "shipBonusKineticArmorResistanceAD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19194; postExpression= 19195 } |> Some
      | 6626 -> { DogmaEffectData.id= 6626; name= "shipBonusCarrierC2SupportFighterBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6723 -> { DogmaEffectData.id= 6723; name= "shipBonusCloakCpuMC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19301; postExpression= 19302 } |> Some
      | 6820 -> { DogmaEffectData.id= 6820; name= "rigAdvMedShipManufactureMaterialBonus"; description= "Structure Rig Material effect on Manufacturing of advanced medium ships"; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6917 -> { DogmaEffectData.id= 6917; name= "subsystemSkillLevelGallenteDefensive3"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12978; postExpression= 12979 } |> Some
      | 7014 -> { DogmaEffectData.id= 7014; name= "eliteBonusGunshipThermalMissileDamage1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19375; postExpression= 19376 } |> Some
      | 709 -> { DogmaEffectData.id= 709; name= "interceptorSignatoreRadiusBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3475; postExpression= 3476 } |> Some
      | 7111 -> { DogmaEffectData.id= 7111; name= "systemSmallPrecursorTurretDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 19541; postExpression= 19542 } |> Some
      | 903 -> { DogmaEffectData.id= 903; name= "ammoInfluenceSignatureRadius"; description= ""; displayName= ""; effectCategory= 0; preExpression= 4133; postExpression= 4134 } |> Some
      | _ -> None