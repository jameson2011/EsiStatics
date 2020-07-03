namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes38=
    let getDogmaAttribute id = 
      match id with 
      | 1008 -> { DogmaAttributeData.id= 1008; name= "entityShieldBoostDelayChanceLarge"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1105 -> { DogmaAttributeData.id= 1105; name= "displayArmorHpBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1299 -> { DogmaAttributeData.id= 1299; name= "canFitShipGroup02"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 135 -> { DogmaAttributeData.id= 135; name= "moduleSize"; description= "The size of the module, 1 = small, 2 = medium, 3 = large.  Used for turrets and projectile weapons but will work for any module that defines it."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1396 -> { DogmaAttributeData.id= 1396; name= "wormholeTargetConstellation2"; description= "Specific target constellation 2 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1493 -> { DogmaAttributeData.id= 1493; name= "smallWeaponDamageMultiplier"; description= "Damage multiplier for small weapons"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1590 -> { DogmaAttributeData.id= 1590; name= "anchorDistanceMin"; description= "The minimum distance the object can be anchored,  from what  depends on the object."; published= false; unitId= Some(1); defaultValue= -1.000000; stackable= true; highIsGood= true } |> Some
      | 1687 -> { DogmaAttributeData.id= 1687; name= "ecuNoiseFactor"; description= ""; published= false; unitId= None; defaultValue= 0.800000; stackable= true; highIsGood= true } |> Some
      | 1881 -> { DogmaAttributeData.id= 1881; name= "canFitShipGroup08"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1978 -> { DogmaAttributeData.id= 1978; name= "resistanceKiller"; description= "Display name is misleading, this attribute is used only for Shield and Armor, but for convenience sake only this one is used."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2075 -> { DogmaAttributeData.id= 2075; name= "scanRadarStrengthBonusBonus"; description= "Bonus to Radar Strength bonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2172 -> { DogmaAttributeData.id= 2172; name= "fighterAbilityAttackTurretDamageTherm"; description= "Thermal Damage"; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2269 -> { DogmaAttributeData.id= 2269; name= "isPointTargeted"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 232 -> { DogmaAttributeData.id= 232; name= "willpowerSkillTrainingTimeMultiplierBonus"; description= "Bonus or penalty to the percentage time it takes to train skills with Willpower as the primary attribute."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2366 -> { DogmaAttributeData.id= 2366; name= "shipBonusCarrierC4"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2463 -> { DogmaAttributeData.id= 2463; name= "canFitShipType7"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2560 -> { DogmaAttributeData.id= 2560; name= "attributeBasCapCompManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  Capital Construction Components        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2657 -> { DogmaAttributeData.id= 2657; name= "specialBoosterHoldCapacity"; description= "special booster hold capacity"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2754 -> { DogmaAttributeData.id= 2754; name= "entosisAssistanceImpedanceMultiplier"; description= ""; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 3045 -> { DogmaAttributeData.id= 3045; name= "shipBonusUB1"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 329 -> { DogmaAttributeData.id= 329; name= "gangRofBonus"; description= "Autogenerated skill attribute, GangRofBonus"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 38 -> { DogmaAttributeData.id= 38; name= "capacity"; description= "The cargo space allowed"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 426 -> { DogmaAttributeData.id= 426; name= "heavyDroneDamagePercent"; description= ""; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 620 -> { DogmaAttributeData.id= 620; name= "optimalSigRadius"; description= "Prefered target signature. The base signature radius at which the turret's tracking speed is rated. "; published= true; unitId= Some(1); defaultValue= 1000.000000; stackable= true; highIsGood= true } |> Some
      | 717 -> { DogmaAttributeData.id= 717; name= "refiningYieldMultiplier"; description= "The factor by which the structure modifies the using pilot's refining yield rate."; published= true; unitId= Some(127); defaultValue= 0.500000; stackable= true; highIsGood= true } |> Some
      | 814 -> { DogmaAttributeData.id= 814; name= "shipBonusMI2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 911 -> { DogmaAttributeData.id= 911; name= "hasFleetHangars"; description= "Whether this ship has fleet hangars."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None