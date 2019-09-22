namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaEffects6=
    let getDogmaEffect id = 
      match id with 
      | 103 -> { DogmaEffectData.id= 103; name= "defenderMissileLaunching"; description= ""; displayName= ""; effectCategory= 1; preExpression= 706; postExpression= 131 } |> Some
      | 1752 -> { DogmaEffectData.id= 1752; name= "entityEwTestEffectJam"; description= ""; displayName= ""; effectCategory= 2; preExpression= 5643; postExpression= 5644 } |> Some
      | 1849 -> { DogmaEffectData.id= 1849; name= "miningBargeSkillLevelPostMulShipBonusORE3Ship"; description= ""; displayName= ""; effectCategory= 0; preExpression= 7136; postExpression= 7137 } |> Some
      | 2431 -> { DogmaEffectData.id= 2431; name= "energyManagementSkillBoostCapacitorCapacityBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 8959; postExpression= 8960 } |> Some
      | 297 -> { DogmaEffectData.id= 297; name= "skillBoostFalloffBonus"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1806; postExpression= 1807 } |> Some
      | 3498 -> { DogmaEffectData.id= 3498; name= "setBonusSisters"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12019; postExpression= 12020 } |> Some
      | 3595 -> { DogmaEffectData.id= 3595; name= "jumpFreightersSkillMultiplier1"; description= ""; displayName= ""; effectCategory= 0; preExpression= 12321; postExpression= 12322 } |> Some
      | 3886 -> { DogmaEffectData.id= 3886; name= "subsystemBonusGallenteElectronicCPU"; description= ""; displayName= ""; effectCategory= 0; preExpression= 13137; postExpression= 13138 } |> Some
      | 394 -> { DogmaEffectData.id= 394; name= "navigationVelocityBonusPostPercentMaxVelocityShip"; description= ""; displayName= ""; effectCategory= 0; preExpression= 2248; postExpression= 2249 } |> Some
      | 4274 -> { DogmaEffectData.id= 4274; name= "subsystemBonusMinmatarCore2StasisWebifierRange"; description= ""; displayName= ""; effectCategory= 0; preExpression= 14149; postExpression= 14150 } |> Some
      | 5341 -> { DogmaEffectData.id= 5341; name= "shipHybridDmg1GBC1"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 16883; postExpression= 16884 } |> Some
      | 5632 -> { DogmaEffectData.id= 5632; name= "shipBonusTorpedoMissileExploDmgMB"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 17564; postExpression= 17565 } |> Some
      | 5826 -> { DogmaEffectData.id= 5826; name= "shipBonusThermalMissileDamageGC2"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18029; postExpression= 18030 } |> Some
      | 588 -> { DogmaEffectData.id= 588; name= "surgicalStrikeDamageMultiplierBonusPostPercentDamageMultiplierLocationShipGroupProjectileWeapon"; description= ""; displayName= ""; effectCategory= 0; preExpression= 3023; postExpression= 3024 } |> Some
      | 5923 -> { DogmaEffectData.id= 5923; name= "systemNeutBombs"; description= "Automatically generated effect"; displayName= ""; effectCategory= 7; preExpression= 18284; postExpression= 18285 } |> Some
      | 6020 -> { DogmaEffectData.id= 6020; name= "shipBonusEnergyNeutOptimalRS3"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18525; postExpression= 18526 } |> Some
      | 6214 -> { DogmaEffectData.id= 6214; name= "roleBonusCDLinksPGReduction"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 18959; postExpression= 18960 } |> Some
      | 6408 -> { DogmaEffectData.id= 6408; name= "structureRigMaxTargets"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6505 -> { DogmaEffectData.id= 6505; name= "shipBonusDreadnoughtC2ShieldResists"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6602 -> { DogmaEffectData.id= 6602; name= "shipBonusCarrierM1FighterDamage"; description= ""; displayName= ""; effectCategory= 0; preExpression= 59; postExpression= 59 } |> Some
      | 6699 -> { DogmaEffectData.id= 6699; name= "rigDrawbackReductionDrones"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19285; postExpression= 19286 } |> Some
      | 6796 -> { DogmaEffectData.id= 6796; name= "shipModeSHTDamagePostDiv"; description= ""; displayName= ""; effectCategory= 0; preExpression= 18518; postExpression= 18519 } |> Some
      | 6893 -> { DogmaEffectData.id= 6893; name= "massReactionSkillLevelModAddReactionSlotLimitChar"; description= ""; displayName= ""; effectCategory= 0; preExpression= 1; postExpression= 1 } |> Some
      | 6990 -> { DogmaEffectData.id= 6990; name= "npcBehaviorShieldBooster"; description= ""; displayName= ""; effectCategory= 1; preExpression= 59; postExpression= 59 } |> Some
      | 7087 -> { DogmaEffectData.id= 7087; name= "shipbonusPCTOptimalPF2"; description= ""; displayName= ""; effectCategory= 0; preExpression= 19515; postExpression= 19516 } |> Some
      | 7184 -> { DogmaEffectData.id= 7184; name= "shipBonusMediumDroneHProle8"; description= "Automatically generated effect"; displayName= ""; effectCategory= 0; preExpression= 19753; postExpression= 19754 } |> Some
      | _ -> None