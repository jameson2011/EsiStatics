﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes43=
    let getDogmaAttribute id = 
      match id with 
      | 1013 -> { DogmaAttributeData.id= 1013; name= "eliteBonusInterdictors2"; description= "eliteBonusInterdictors2"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1110 -> { DogmaAttributeData.id= 1110; name= "displayAoeCloudsizeModifier"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1207 -> { DogmaAttributeData.id= 1207; name= "isGlobal"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1304 -> { DogmaAttributeData.id= 1304; name= "canFitShipType3"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 140 -> { DogmaAttributeData.id= 140; name= "kineticDamageBonus"; description= "+/- amount to the kinetic damage done."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1401 -> { DogmaAttributeData.id= 1401; name= "wormholeTargetConstellation7"; description= "Specific target constellation 7 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1498 -> { DogmaAttributeData.id= 1498; name= "armorDamageAmountMultiplierRemote"; description= "Repair amount multiplier for remote repairers"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1595 -> { DogmaAttributeData.id= 1595; name= "requiresSovUpgrade1"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1692 -> { DogmaAttributeData.id= 1692; name= "metaGroupID"; description= "Authoring has been moved to FSD.  meta group of type    3: Story-line (Cosmos)  4: Faction  5: Officer (rare asteroid NPCs)  6: Deadspace    "; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1886 -> { DogmaAttributeData.id= 1886; name= "chargedArmorDamageMultiplier"; description= "Multiplier applied to armorDamageAmount when consuming a collection of charges."; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1983 -> { DogmaAttributeData.id= 1983; name= "freighterBonusO1"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2080 -> { DogmaAttributeData.id= 2080; name= "armorExplosiveDamageResonancePostAssignment"; description= "Sets Explosive damage taken by Armor. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2177 -> { DogmaAttributeData.id= 2177; name= "fighterAbilityAttackTurretDuration"; description= "Rate of fire"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 2274 -> { DogmaAttributeData.id= 2274; name= "onDeathDamageExp"; description= "Explosive Damage when the ship dies"; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 237 -> { DogmaAttributeData.id= 237; name= "maxTargetRangeMultiplier"; description= "Scales the max target range of a ships electronics."; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2371 -> { DogmaAttributeData.id= 2371; name= "shipBonusCarrierM1"; description= "Multiplied by Minmatar Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2468 -> { DogmaAttributeData.id= 2468; name= "warfareBuff1ID"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2565 -> { DogmaAttributeData.id= 2565; name= "attributeMEResearchCostMultiplier"; description= "Decrease cost requirement for manufacturing the following:  Material Efficiency Blueprint Research        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2662 -> { DogmaAttributeData.id= 2662; name= "reactionTimeMultiplier"; description= "Scales the time for reaction"; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2759 -> { DogmaAttributeData.id= 2759; name= "typeListId"; description= ""; published= false; unitId= None; defaultValue= -1.000000; stackable= true; highIsGood= true } |> Some
      | 3050 -> { DogmaAttributeData.id= 3050; name= "AmountOfFleetsPerMatch"; description= "The amount of fleets needed for a single pvp filament match "; published= false; unitId= None; defaultValue= 2.000000; stackable= false; highIsGood= false } |> Some
      | 334 -> { DogmaAttributeData.id= 334; name= "shipPowerBonus"; description= "Autogenerated skill attribute, shipPowerBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 431 -> { DogmaAttributeData.id= 431; name= "scoutDroneVelocityBonus"; description= "Autogenerated skill attribute, scoutDroneVelocityBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 528 -> { DogmaAttributeData.id= 528; name= "reqManufacturingSkillLevel"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 625 -> { DogmaAttributeData.id= 625; name= "bountyBonus"; description= "Flat Bonus To NPC Bountys"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 722 -> { DogmaAttributeData.id= 722; name= "posControlTowerPeriod"; description= "The interval for fuel consumption of a control tower"; published= true; unitId= Some(101); defaultValue= 10000.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None