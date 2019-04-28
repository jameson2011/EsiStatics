﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes49=
    let getDogmaAttribute id = 
      match id with 
      | 1019 -> { DogmaAttributeData.id= 1019; name= "entityArmorRepairDelayChanceMediumMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1116 -> { DogmaAttributeData.id= 1116; name= "scanProbeStrength"; description= "The strength of the probe."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1213 -> { DogmaAttributeData.id= 1213; name= "heatDamageBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1310 -> { DogmaAttributeData.id= 1310; name= "commandBonusHidden"; description= "commandBonusHidden"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1407 -> { DogmaAttributeData.id= 1407; name= "wormholeTargetSystem4"; description= "Specific target system 4 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 146 -> { DogmaAttributeData.id= 146; name= "shieldCapacityMultiplier"; description= "Multiplier to the capacity of a shield."; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1504 -> { DogmaAttributeData.id= 1504; name= "shipBonusStrategicCruiserCaldari1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1601 -> { DogmaAttributeData.id= 1601; name= "onliningRequiresSovUpgrade1"; description= "This attribute specifies a typeID which must be active in an IH for the given structure to be onlined"; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1698 -> { DogmaAttributeData.id= 1698; name= "distributionIDAngel04"; description= "Distribution ID for sov upgrades in Angel space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1795 -> { DogmaAttributeData.id= 1795; name= "reloadTime"; description= "reload time (ms)"; published= true; unitId= Some(101); defaultValue= 10000.000000; stackable= true; highIsGood= false } |> Some
      | 1892 -> { DogmaAttributeData.id= 1892; name= "entityArmorRepairAmountPerSecond"; description= "the average armor amount repaired per second"; published= false; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1989 -> { DogmaAttributeData.id= 1989; name= "roleBonusT3ProbeCPU"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2086 -> { DogmaAttributeData.id= 2086; name= "shieldThermalDamageResonancePostAssignment"; description= "Sets Thermal damage taken by Shields. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2183 -> { DogmaAttributeData.id= 2183; name= "fighterAbilityStasisWebifierDuration"; description= "Duration"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2280 -> { DogmaAttributeData.id= 2280; name= "doomsdayAOEDuration"; description= "Duration of the AOE Effect"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2377 -> { DogmaAttributeData.id= 2377; name= "shipBonusSupercarrierA3"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 243 -> { DogmaAttributeData.id= 243; name= "maxRangeMultiplier"; description= "Scales the range at which something can reach."; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2474 -> { DogmaAttributeData.id= 2474; name= "shipBonusICS3"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2571 -> { DogmaAttributeData.id= 2571; name= "commandBurstStrengthBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2668 -> { DogmaAttributeData.id= 2668; name= "subsystemMETFittingReduction"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2765 -> { DogmaAttributeData.id= 2765; name= "shipBonusPC2"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 437 -> { DogmaAttributeData.id= 437; name= "negotiationBonus"; description= "Autogenerated skill attribute, NegotiationBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 49 -> { DogmaAttributeData.id= 49; name= "cpuLoad"; description= "CPU load of ship"; published= true; unitId= Some(106); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 534 -> { DogmaAttributeData.id= 534; name= "Manufacturer_ID"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 631 -> { DogmaAttributeData.id= 631; name= "entityArmorRepairAmount"; description= "Amount of armor repaired per cycle for entities."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 728 -> { DogmaAttributeData.id= 728; name= "controlTowerLaserDamageBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None