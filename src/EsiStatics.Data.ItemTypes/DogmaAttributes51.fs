﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes51=
    let getDogmaAttribute id = 
      match id with 
      | 1021 -> { DogmaAttributeData.id= 1021; name= "warpAccuracyMaxRange"; description= ""; published= false; unitId= None; defaultValue= 15000.000000; stackable= true; highIsGood= true } |> Some
      | 1118 -> { DogmaAttributeData.id= 1118; name= "scanStrengthDronesProbes"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1312 -> { DogmaAttributeData.id= 1312; name= "eliteBonusJumpFreighter2"; description= "eliteBonusJumpFreighter2"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1409 -> { DogmaAttributeData.id= 1409; name= "wormholeTargetSystem6"; description= "Specific target system 6 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 148 -> { DogmaAttributeData.id= 148; name= "armorHPMultiplier"; description= "Multiplier to the HP of a ships armor module."; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1506 -> { DogmaAttributeData.id= 1506; name= "shipBonusStrategicCruiserMinmatar1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1603 -> { DogmaAttributeData.id= 1603; name= "sovBillSystemCost"; description= "The sum of this attribute on the claim markers, Infrastructure hub, and each upgrade is the systems base cost. "; published= true; unitId= Some(133); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1700 -> { DogmaAttributeData.id= 1700; name= "distributionIDAngel06"; description= "Distribution ID for sov upgrades in Angel space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1797 -> { DogmaAttributeData.id= 1797; name= "clothingAlsoCoversCategory"; description= "This item of clothing covers multiple areas of the body, so the category of clothes specified by this attribute is no longer mandatory"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1894 -> { DogmaAttributeData.id= 1894; name= "entityCapacitorLevel"; description= "represents the capacity level of an entity"; published= false; unitId= Some(109); defaultValue= 1.000000; stackable= false; highIsGood= true } |> Some
      | 1991 -> { DogmaAttributeData.id= 1991; name= "modeMaxTargetRangePostDiv"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2088 -> { DogmaAttributeData.id= 2088; name= "explosiveDamageResonancePostAssignment"; description= "Sets Explosive damage taken by Hull. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2185 -> { DogmaAttributeData.id= 2185; name= "fighterAbilityStasisWebifierSpeedPenaltyInterim"; description= ""; published= false; unitId= Some(124); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2282 -> { DogmaAttributeData.id= 2282; name= "sensorStrengthBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2379 -> { DogmaAttributeData.id= 2379; name= "shipBonusSupercarrierA5"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 245 -> { DogmaAttributeData.id= 245; name= "gfxTurretID"; description= "Graphic ID of the turrets for drone type ships."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2476 -> { DogmaAttributeData.id= 2476; name= "canFitShipGroup11"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2573 -> { DogmaAttributeData.id= 2573; name= "reloadTimeBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2670 -> { DogmaAttributeData.id= 2670; name= "subsystemMRSBFittingReduction"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2767 -> { DogmaAttributeData.id= 2767; name= "shipBonusPBS2"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 439 -> { DogmaAttributeData.id= 439; name= "targetingSpeedBonus"; description= "Autogenerated skill attribute, targetingSpeedBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 51 -> { DogmaAttributeData.id= 51; name= "speed"; description= "Time in milliseconds between possible activations"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 536 -> { DogmaAttributeData.id= 536; name= "reqResearchComponetAmount"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 633 -> { DogmaAttributeData.id= 633; name= "metaLevel"; description= "Authoring has been moved to FSD  The ranking of the module within its tech level"; published= true; unitId= Some(140); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 924 -> { DogmaAttributeData.id= 924; name= "eliteBonusBarge1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None