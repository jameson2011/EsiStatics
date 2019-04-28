namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes48=
    let getDogmaAttribute id = 
      match id with 
      | 1018 -> { DogmaAttributeData.id= 1018; name= "entityArmorRepairDelayChanceSmallMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1115 -> { DogmaAttributeData.id= 1115; name= "decryptorID"; description= "Used to show usable decryptors when starting reverse engineering based on data interface"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1212 -> { DogmaAttributeData.id= 1212; name= "requiredThermoDynamicsSkill"; description= ""; published= true; unitId= Some(140); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1309 -> { DogmaAttributeData.id= 1309; name= "scanResolutionMultiplierBonusAdditive"; description= "Additive bonus to scanResolutionMultiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1406 -> { DogmaAttributeData.id= 1406; name= "wormholeTargetSystem3"; description= "Specific target system 3 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 145 -> { DogmaAttributeData.id= 145; name= "powerOutputMultiplier"; description= "Multipier to power core output."; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1503 -> { DogmaAttributeData.id= 1503; name= "shipBonusStrategicCruiserAmarr1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1600 -> { DogmaAttributeData.id= 1600; name= "sovUpgradeRequiredOutpostUpgradeLevel"; description= "The required level of outpost upgrade required to install this upgrade"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1697 -> { DogmaAttributeData.id= 1697; name= "distributionIDAngel03"; description= "Distribution ID for sov upgrades in Angel space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1794 -> { DogmaAttributeData.id= 1794; name= "skillBonusBooster"; description= "Bonus to booster effect."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1891 -> { DogmaAttributeData.id= 1891; name= "allowedInCapIndustrialMaintenanceBay"; description= "Tells if this type (ship) can be placed in the maintenance bay of a capital industrial ship."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1988 -> { DogmaAttributeData.id= 1988; name= "shipBonusTacticalDestroyerAmarr3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2085 -> { DogmaAttributeData.id= 2085; name= "shieldKineticDamageResonancePostAssignment"; description= "Sets kinetic damage taken by Shields. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2182 -> { DogmaAttributeData.id= 2182; name= "fighterAbilityMissilesDuration"; description= "Rate of fire"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 2279 -> { DogmaAttributeData.id= 2279; name= "doomsdayAOERange"; description= "Radius of the AOE Effect"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2376 -> { DogmaAttributeData.id= 2376; name= "shipBonusSupercarrierA2"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 242 -> { DogmaAttributeData.id= 242; name= "scanSpeedMultiplier"; description= "Scales the time it takes to lock a target."; published= false; unitId= Some(111); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2473 -> { DogmaAttributeData.id= 2473; name= "warfareBuff3Value"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2570 -> { DogmaAttributeData.id= 2570; name= "attributeBPCopyTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  Blueprint Copying        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2667 -> { DogmaAttributeData.id= 2667; name= "subsystemMPTFittingReduction"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2764 -> { DogmaAttributeData.id= 2764; name= "shipBonusPC1"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 436 -> { DogmaAttributeData.id= 436; name= "standingIncreasePercent"; description= ""; published= false; unitId= Some(105); defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 48 -> { DogmaAttributeData.id= 48; name= "cpuOutput"; description= "CPU output of ship"; published= true; unitId= Some(106); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 630 -> { DogmaAttributeData.id= 630; name= "entityArmorRepairDuration"; description= "Duration between armor repair actions for entities."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 727 -> { DogmaAttributeData.id= 727; name= "destroyerROFpenality"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 921 -> { DogmaAttributeData.id= 921; name= "oreCompression"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None