namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects6=
    let getDogmaEffect id = 
      match id with 
      | 103 -> { DogmaEffectData.id= 103; name= "defenderMissileLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 1752 -> { DogmaEffectData.id= 1752; name= "entityEwTestEffectJam"; description= ""; displayName= ""; effectCategory= 2; preExpression= 0; postExpression= 0 } |> Some
      | 1849 -> { DogmaEffectData.id= 1849; name= "miningBargeSkillLevelPostMulShipBonusORE3Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 2431 -> { DogmaEffectData.id= 2431; name= "energyManagementSkillBoostCapacitorCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 297 -> { DogmaEffectData.id= 297; name= "skillBoostFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3498 -> { DogmaEffectData.id= 3498; name= "setBonusSisters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3595 -> { DogmaEffectData.id= 3595; name= "jumpFreightersSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 3886 -> { DogmaEffectData.id= 3886; name= "subsystemBonusGallenteElectronicCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 394 -> { DogmaEffectData.id= 394; name= "navigationVelocityBonusPostPercentMaxVelocityShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 4274 -> { DogmaEffectData.id= 4274; name= "subsystemBonusMinmatarCore2StasisWebifierRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5341 -> { DogmaEffectData.id= 5341; name= "shipHybridDmg1GBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5632 -> { DogmaEffectData.id= 5632; name= "shipBonusTorpedoMissileExploDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5826 -> { DogmaEffectData.id= 5826; name= "shipBonusThermalMissileDamageGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 588 -> { DogmaEffectData.id= 588; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupProjectileWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 5923 -> { DogmaEffectData.id= 5923; name= "systemNeutBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 0; postExpression= 0 } |> Some
      | 6020 -> { DogmaEffectData.id= 6020; name= "shipBonusEnergyNeutOptimalRS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6214 -> { DogmaEffectData.id= 6214; name= "roleBonusCDLinksPGReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6408 -> { DogmaEffectData.id= 6408; name= "structureRigMaxTargets"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6505 -> { DogmaEffectData.id= 6505; name= "shipBonusDreadnoughtC2ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6602 -> { DogmaEffectData.id= 6602; name= "shipBonusCarrierM1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6699 -> { DogmaEffectData.id= 6699; name= "rigDrawbackReductionDrones"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6796 -> { DogmaEffectData.id= 6796; name= "shipModeSHTDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6893 -> { DogmaEffectData.id= 6893; name= "massReactionSkillLevelModAddReactionSlotLimitChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 6990 -> { DogmaEffectData.id= 6990; name= "npcBehaviorShieldBooster"; description= ""; displayName= ""; effectCategory= 1; preExpression= 0; postExpression= 0 } |> Some
      | 7087 -> { DogmaEffectData.id= 7087; name= "shipbonusPCTOptimalPF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 7184 -> { DogmaEffectData.id= 7184; name= "shipBonusMediumDroneHProle8"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 0; postExpression= 0 } |> Some
      | 8057 -> { DogmaEffectData.id= 8057; name= "vortonWeaponDamageSpeedMultiply"; description= ""; displayName= ""; effectCategory= 4; preExpression= 0; postExpression= 0 } |> Some
      | _ -> None