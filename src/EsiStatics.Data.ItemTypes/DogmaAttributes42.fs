namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes42=
    let getDogmaAttribute id = 
      match id with 
      | 1012 -> { DogmaAttributeData.id= 1012; name= "eliteBonusInterdictors1"; description= "eliteBonusInterdictors1"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1109 -> { DogmaAttributeData.id= 1109; name= "displayTrackingSpeedModifier"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1206 -> { DogmaAttributeData.id= 1206; name= "overloadSelfDurationBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1303 -> { DogmaAttributeData.id= 1303; name= "canFitShipType2"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 139 -> { DogmaAttributeData.id= 139; name= "explosiveDamageBonus"; description= "+/- amount to the explosive damage done."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1400 -> { DogmaAttributeData.id= 1400; name= "wormholeTargetConstellation6"; description= "Specific target constellation 6 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1497 -> { DogmaAttributeData.id= 1497; name= "shieldBonusMultiplierRemote"; description= "Shield repair multiplier for remote repair"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1691 -> { DogmaAttributeData.id= 1691; name= "ecuExtractorHeadPower"; description= "Power cost for a extractor head"; published= true; unitId= Some(107); defaultValue= 500.000000; stackable= true; highIsGood= true } |> Some
      | 1788 -> { DogmaAttributeData.id= 1788; name= "bcLargeTurretCap"; description= "Used by Battlecruisers for large turret capacitor reduction"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1982 -> { DogmaAttributeData.id= 1982; name= "manufactureTimePerLevel"; description= "Skill bonus per level to manufacturing time efficiency. Only applies to skills required to manufacture the blueprint."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2079 -> { DogmaAttributeData.id= 2079; name= "armorEmDamageResonancePostAssignment"; description= "Sets Em damage taken by Armor. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2176 -> { DogmaAttributeData.id= 2176; name= "fighterAbilityAttackTurretRangeFalloff"; description= "Accuracy Falloff"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2273 -> { DogmaAttributeData.id= 2273; name= "onDeathDamageKin"; description= "Kinetic Damage when the ship dies"; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 236 -> { DogmaAttributeData.id= 236; name= "maxAttackTargetsBonus"; description= "Additional amount of attack targets that can be handled."; published= false; unitId= Some(139); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2370 -> { DogmaAttributeData.id= 2370; name= "shipBonusCarrierG4"; description= "Multiplied by Gallente Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2467 -> { DogmaAttributeData.id= 2467; name= "specialCorpseHoldCapacity"; description= "special corpse hold capacity"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2564 -> { DogmaAttributeData.id= 2564; name= "attributeInventionTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  Invention        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2661 -> { DogmaAttributeData.id= 2661; name= "reactionSlotBonus"; description= "Increase number of available/simultaneous reaction slots"; published= true; unitId= Some(139); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2758 -> { DogmaAttributeData.id= 2758; name= "canFitShipType11"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 333 -> { DogmaAttributeData.id= 333; name= "burstDmgMutator"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 430 -> { DogmaAttributeData.id= 430; name= "scoutDroneVelocityPercent"; description= ""; published= false; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 527 -> { DogmaAttributeData.id= 527; name= "reqManufacturingSkill"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 624 -> { DogmaAttributeData.id= 624; name= "WarpSBonus"; description= "Autogenerated skill attribute, WarpSBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 721 -> { DogmaAttributeData.id= 721; name= "refiningDelayMultiplier"; description= "The factor by which the character can effect the amount of time that the Refining Delay takes."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 818 -> { DogmaAttributeData.id= 818; name= "propulsionPlasmaStrengthBonus"; description= "Minmatar Propulsion Attack Strength for Warp Scramblers etc."; published= true; unitId= Some(120); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 915 -> { DogmaAttributeData.id= 915; name= "caldariNavyBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None