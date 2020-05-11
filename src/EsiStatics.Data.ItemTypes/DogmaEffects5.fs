namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects5=
    let getDogmaEffect id = 
      match id with 
      | 102 -> { DogmaEffectData.id= 102; name= "mineLaying"; description= ""; displayName= ""; effectCategory= 1; preExpression= 114; postExpression= 131 } |> Some
      | 1266 -> { DogmaEffectData.id= 1266; name= "interceptor2MissileVelocity"; description= ""; displayName= ""; effectCategory= 0; preExpression= 5385; postExpression= 5386 } |> Some
      | 1848 -> { DogmaEffectData.id= 1848; name= "miningForemanMindlink"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7130; postExpression= 7131 } |> Some
      | 2430 -> { DogmaEffectData.id= 2430; name= "maxVelocityMultiplier"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8949; postExpression= 8950 } |> Some
      | 2721 -> { DogmaEffectData.id= 2721; name= "drawbackPowerOutput"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9771; postExpression= 9772 } |> Some
      | 2818 -> { DogmaEffectData.id= 2818; name= "shipBonusSurveyProbeExplosionDelaySkillSurveyGF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10004; postExpression= 10005 } |> Some
      | 3109 -> { DogmaEffectData.id= 3109; name= "controlTowerGenericHullKineticResistanceBonusScrambler"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10935; postExpression= 10936 } |> Some
      | 3400 -> { DogmaEffectData.id= 3400; name= "eliteBonusBlackOpsDroneMWDSpeedBonus1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 11740; postExpression= 11741 } |> Some
      | 3788 -> { DogmaEffectData.id= 3788; name= "modifyHullResonancePostPercentExplosive"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12872; postExpression= 12873 } |> Some
      | 3885 -> { DogmaEffectData.id= 3885; name= "subsystemBonusMinmatarElectronicCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13135; postExpression= 13136 } |> Some
      | 3982 -> { DogmaEffectData.id= 3982; name= "subsystemBonusAmarrDefensiveArmorHP"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13329; postExpression= 13330 } |> Some
      | 4079 -> { DogmaEffectData.id= 4079; name= "systemHeavyAssaultMissileEmDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13636; postExpression= 13637 } |> Some
      | 4273 -> { DogmaEffectData.id= 4273; name= "subsystemBonusGallenteCore2WarpScrambleRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14147; postExpression= 14148 } |> Some
      | 4370 -> { DogmaEffectData.id= 4370; name= "caldariShipEwFalloffRangeCC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14371; postExpression= 14372 } |> Some
      | 4855 -> { DogmaEffectData.id= 4855; name= "shipLargeLaserDamageBonusBC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15677; postExpression= 15678 } |> Some
      | 490 -> { DogmaEffectData.id= 490; name= "engineeringPowerEngineeringOutputBonusPostPercentPowerOutputLocationShipGroupPowerCore"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2616; postExpression= 2617 } |> Some
      | 5049 -> { DogmaEffectData.id= 5049; name= "shipBonusArchCycleMF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16199; postExpression= 16200 } |> Some
      | 5146 -> { DogmaEffectData.id= 5146; name= "shipBonusDroneHitpoints1DF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16413; postExpression= 16414 } |> Some
      | 5243 -> { DogmaEffectData.id= 5243; name= "shipSmallMissileEMDmgCF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16641; postExpression= 16642 } |> Some
      | 5340 -> { DogmaEffectData.id= 5340; name= "shipBonusHeavyMissileKineticDamageCBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16881; postExpression= 16882 } |> Some
      | 5437 -> { DogmaEffectData.id= 5437; name= "archaeologySkillVirusBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17080; postExpression= 17081 } |> Some
      | 5534 -> { DogmaEffectData.id= 5534; name= "roleBonusSkirmishWarfare"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17338; postExpression= 17339 } |> Some
      | 5631 -> { DogmaEffectData.id= 5631; name= "shipBonusCruiseMissileExploDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17562; postExpression= 17563 } |> Some
      | 5825 -> { DogmaEffectData.id= 5825; name= "shipBonusKineticMissileDamageGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18027; postExpression= 18028 } |> Some
      | 587 -> { DogmaEffectData.id= 587; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupEnergyWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2968; postExpression= 2969 } |> Some
      | 5922 -> { DogmaEffectData.id= 5922; name= "systemWebifierStrengthMultiplier"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18280; postExpression= 18281 } |> Some
      | 6116 -> { DogmaEffectData.id= 6116; name= "missileVelocityBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 18736; postExpression= 18737 } |> Some
      | 6213 -> { DogmaEffectData.id= 6213; name= "eliteBonusCommandDestroyerMWDSigRadius3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18954; postExpression= 18955 } |> Some
      | 6310 -> { DogmaEffectData.id= 6310; name= "shipBonusExplosiveMissileDmgMD1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19152; postExpression= 19153 } |> Some
      | 6407 -> { DogmaEffectData.id= 6407; name= "structureRigEWCapacitorNeed"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6504 -> { DogmaEffectData.id= 6504; name= "shipBonusDreadnoughtC1DamageBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6601 -> { DogmaEffectData.id= 6601; name= "shipBonusCarrierG1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6698 -> { DogmaEffectData.id= 6698; name= "rigDrawbackReductionAstronautics"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19285; postExpression= 19286 } |> Some
      | 6795 -> { DogmaEffectData.id= 6795; name= "shipBonusDroneIceHarvestingORECapital5"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6892 -> { DogmaEffectData.id= 6892; name= "reactionSkillBoostManufacturingTimeBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6989 -> { DogmaEffectData.id= 6989; name= "refineryRefiningYieldBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 7086 -> { DogmaEffectData.id= 7086; name= "shipbonusPCTTrackingPC2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19511; postExpression= 19512 } |> Some
      | 7183 -> { DogmaEffectData.id= 7183; name= "implantWarpScrambleRangeBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19751; postExpression= 19752 } |> Some
      | 878 -> { DogmaEffectData.id= 878; name= "armorRepairForEntities"; description= ""; displayName= ""; effectCategory= 1; preExpression= 4039; postExpression= 131 } |> Some
      | _ -> None