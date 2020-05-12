namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects6=
    let getDogmaEffect id = 
      match id with 
      | 103 -> { DogmaEffectData.id= 103; name= "defenderMissileLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1752 -> { DogmaEffectData.id= 1752; name= "entityEwTestEffectJam"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 1849 -> { DogmaEffectData.id= 1849; name= "miningBargeSkillLevelPostMulShipBonusORE3Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2334 -> { DogmaEffectData.id= 2334; name= "cloneJumpAcceptingTmp"; description= ""; displayName= ""; effectCategory= 1; preExpression= 6742; postExpression= 6743 } |> Some
      | 2431 -> { DogmaEffectData.id= 2431; name= "energyManagementSkillBoostCapacitorCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2722 -> { DogmaEffectData.id= 2722; name= "drawbackROFGunnery"; description= ""; displayName= ""; effectCategory= 0; preExpression= 9773; postExpression= 9774 } |> Some
      | 2819 -> { DogmaEffectData.id= 2819; name= "shipBonusSurveyProbeExplosionDelaySkillSurveyCovertOps2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10006; postExpression= 10007 } |> Some
      | 297 -> { DogmaEffectData.id= 297; name= "skillBoostFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3110 -> { DogmaEffectData.id= 3110; name= "controlTowerGenericHullExplosiveResistanceBonusScrambler"; description= ""; displayName= ""; effectCategory= 0; preExpression= 10939; postExpression= 10940 } |> Some
      | 3498 -> { DogmaEffectData.id= 3498; name= "setBonusSisters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3595 -> { DogmaEffectData.id= 3595; name= "jumpFreightersSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3692 -> { DogmaEffectData.id= 3692; name= "turretWeaponFalloffMultiplyTargetHostile2"; description= ""; displayName= ""; effectCategory= 2; preExpression= 12632; postExpression= 12633 } |> Some
      | 3789 -> { DogmaEffectData.id= 3789; name= "modifyHullResonancePostPercentEMExplosive"; description= ""; displayName= ""; effectCategory= 4; preExpression= 12874; postExpression= 12875 } |> Some
      | 3886 -> { DogmaEffectData.id= 3886; name= "subsystemBonusGallenteElectronicCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 394 -> { DogmaEffectData.id= 394; name= "navigationVelocityBonusPostPercentMaxVelocityShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4080 -> { DogmaEffectData.id= 4080; name= "systemHeavyAssaultMissileExplosiveDamage"; description= ""; displayName= ""; effectCategory= 7; preExpression= 13639; postExpression= 13640 } |> Some
      | 4274 -> { DogmaEffectData.id= 4274; name= "subsystemBonusMinmatarCore2StasisWebifierRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4371 -> { DogmaEffectData.id= 4371; name= "	ecmFalloffRangeBonusModuleEffect"; description= ""; displayName= ""; effectCategory= 4; preExpression= 14373; postExpression= 14374 } |> Some
      | 4565 -> { DogmaEffectData.id= 4565; name= "capitalLauncherSkillCruiseCitadelEmExplosive"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14976; postExpression= 14977 } |> Some
      | 4856 -> { DogmaEffectData.id= 4856; name= "shipLargeHybridTrackingBonusBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 15679; postExpression= 15680 } |> Some
      | 5050 -> { DogmaEffectData.id= 5050; name= "shipBonusHackingCycleMF"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16201; postExpression= 16202 } |> Some
      | 5147 -> { DogmaEffectData.id= 5147; name= "shipBonusDroneHitpointsDF1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 16415; postExpression= 16416 } |> Some
      | 5341 -> { DogmaEffectData.id= 5341; name= "shipHybridDmg1GBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5438 -> { DogmaEffectData.id= 5438; name= "shipTorpedoAOECloudSizeCB3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17082; postExpression= 17083 } |> Some
      | 5632 -> { DogmaEffectData.id= 5632; name= "shipBonusTorpedoMissileExploDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5826 -> { DogmaEffectData.id= 5826; name= "shipBonusThermalMissileDamageGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 588 -> { DogmaEffectData.id= 588; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupProjectileWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5923 -> { DogmaEffectData.id= 5923; name= "systemNeutBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6020 -> { DogmaEffectData.id= 6020; name= "shipBonusEnergyNeutOptimalRS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6117 -> { DogmaEffectData.id= 6117; name= "missileExplosionDelayBonus"; description= "Automatically generated effect"; displayName= ""; effectCategory= 1; preExpression= 18740; postExpression= 18741 } |> Some
      | 6214 -> { DogmaEffectData.id= 6214; name= "roleBonusCDLinksPGReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6311 -> { DogmaEffectData.id= 6311; name= "shipBonusShieldEMResistanceMD2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19154; postExpression= 19155 } |> Some
      | 6408 -> { DogmaEffectData.id= 6408; name= "structureRigMaxTargets"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6505 -> { DogmaEffectData.id= 6505; name= "shipBonusDreadnoughtC2ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6602 -> { DogmaEffectData.id= 6602; name= "shipBonusCarrierM1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6699 -> { DogmaEffectData.id= 6699; name= "rigDrawbackReductionDrones"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6796 -> { DogmaEffectData.id= 6796; name= "shipModeSHTDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6893 -> { DogmaEffectData.id= 6893; name= "massReactionSkillLevelModAddReactionSlotLimitChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6990 -> { DogmaEffectData.id= 6990; name= "npcBehaviorShieldBooster"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7087 -> { DogmaEffectData.id= 7087; name= "shipbonusPCTOptimalPF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7184 -> { DogmaEffectData.id= 7184; name= "shipBonusMediumDroneHProle8"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 782 -> { DogmaEffectData.id= 782; name= "missileGuidanceAgilityBonusPostPercentAgilityOwnerCharModulesRequiringMissileLauncherOperation"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3726; postExpression= 3727 } |> Some
      | _ -> None