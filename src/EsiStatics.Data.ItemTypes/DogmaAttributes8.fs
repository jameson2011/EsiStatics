﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes8=
    let getDogmaAttribute id = 
      match id with 
      | 105 -> { DogmaAttributeData.id= 105; name= "warpScrambleStrength"; description= "Amount to modify ships warp scramble status by."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1075 -> { DogmaAttributeData.id= 1075; name= "missileNeverDoesDamage"; description= "If present on a type which is used like a missile, signifies that it should never do damage (whether it has any to do or not)."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1172 -> { DogmaAttributeData.id= 1172; name= "structureArmorBoostValue"; description= "Value modified by remote starbase structure repair effects (should be 0 unless the structure repairs itself)"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1269 -> { DogmaAttributeData.id= 1269; name= "eliteBonusViolatorsRole2"; description= "eliteBonusViolatorsRole2"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1366 -> { DogmaAttributeData.id= 1366; name= "subSystemSlot"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1560 -> { DogmaAttributeData.id= 1560; name= "specialShipHoldCapacity"; description= "Capacity of ship-only hold"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1657 -> { DogmaAttributeData.id= 1657; name= "AI_TankingModifier"; description= "Tanking modifier applied to ships. 1.0 is no modifier."; published= true; unitId= None; defaultValue= 0.700000; stackable= true; highIsGood= true } |> Some
      | 1754 -> { DogmaAttributeData.id= 1754; name= "distributionIDSerpentis10"; description= "Distribution ID for sov upgrades in Serpentis space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1851 -> { DogmaAttributeData.id= 1851; name= "sensorStrengthBonus"; description= "Bonus for Sensor Strength"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 202 -> { DogmaAttributeData.id= 202; name= "cpuMultiplier"; description= "Factor to adjust module cpu need by."; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2045 -> { DogmaAttributeData.id= 2045; name= "energyWarfareResistance"; description= "Resistance against Energy Neutralizing and Nosferatu"; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 2142 -> { DogmaAttributeData.id= 2142; name= "aoeCloudSizeBonusInterim"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2239 -> { DogmaAttributeData.id= 2239; name= "fighterAbilityTackleRange"; description= "Range"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2336 -> { DogmaAttributeData.id= 2336; name= "fighterBonusVelocityPercent"; description= "Bonus to fighter Velocity (%)"; published= true; unitId= Some(109); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2433 -> { DogmaAttributeData.id= 2433; name= "fighterAbilityKamikazeResistance"; description= ""; published= false; unitId= Some(108); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2530 -> { DogmaAttributeData.id= 2530; name= "behaviorSensorDampenerDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2627 -> { DogmaAttributeData.id= 2627; name= "eliteBonusBlackOps3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2724 -> { DogmaAttributeData.id= 2724; name= "BehaviorShieldBoosterDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2821 -> { DogmaAttributeData.id= 2821; name= "siegeHAWMissileROFBonus"; description= "Bonus to HAW Missile Launcher Rate of Fire"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 299 -> { DogmaAttributeData.id= 299; name= "cbTRangeBonus"; description= "Autogenerated skill attribute, cbTRangeBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 396 -> { DogmaAttributeData.id= 396; name= "repairCostPercent"; description= "Repair cost percent"; published= true; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 493 -> { DogmaAttributeData.id= 493; name= "shipBonusMI"; description= ""; published= false; unitId= None; defaultValue= 5.000000; stackable= true; highIsGood= true } |> Some
      | 590 -> { DogmaAttributeData.id= 590; name= "gestaltBonus1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 687 -> { DogmaAttributeData.id= 687; name= "operationConsumptionRate"; description= "The number of units of a resource consumed per minute of operation."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 784 -> { DogmaAttributeData.id= 784; name= "crystalVolatilityDamage"; description= "The amount of damage done if the crystal is damaged in the process of using it."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 8 -> { DogmaAttributeData.id= 8; name= "minRange"; description= "tbd"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 978 -> { DogmaAttributeData.id= 978; name= "maxGroupOnline"; description= "Maximum modules of same group that can be onlined at same time, 0 = no limit, 1 = 1"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None