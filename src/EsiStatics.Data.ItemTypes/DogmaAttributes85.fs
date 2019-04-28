﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes85=
    let getDogmaAttribute id = 
      match id with 
      | 1152 -> { DogmaAttributeData.id= 1152; name= "upgradeLoad"; description= "How much the upgrades installed on this ship are using of its upgrade capacity."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1249 -> { DogmaAttributeData.id= 1249; name= "eliteBonusElectronicAttackShip1"; description= "eliteBonusElectronicAttackShip1"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1443 -> { DogmaAttributeData.id= 1443; name= "subsystemBonusCaldariDefensive"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1540 -> { DogmaAttributeData.id= 1540; name= "stealthBomberLauncherPower2"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1734 -> { DogmaAttributeData.id= 1734; name= "distributionIDRogueDrone10"; description= "Distribution ID for sov upgrades in Rogue Drone space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 182 -> { DogmaAttributeData.id= 182; name= "requiredSkill1"; description= "The type ID of the skill that is required."; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1831 -> { DogmaAttributeData.id= 1831; name= "rookieDroneBonus"; description= "Bonus to drone damage, HP and mining yield"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1928 -> { DogmaAttributeData.id= 1928; name= "siphonRawMaterial"; description= "The amount of Raw Material stolen from active Moon Harvester Arrays each cycle."; published= true; unitId= Some(138); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2025 -> { DogmaAttributeData.id= 2025; name= "missileVelocityBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 1399.000000; stackable= true; highIsGood= true } |> Some
      | 2219 -> { DogmaAttributeData.id= 2219; name= "fighterHeavySlots"; description= "Number of Heavy Fighters the ship can launch.Heavy "; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2316 -> { DogmaAttributeData.id= 2316; name= "shipBonusForceAuxiliaryG3"; description= "Multiplied by Gallente Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2413 -> { DogmaAttributeData.id= 2413; name= "shipBonusTitanC4"; description= "Multiplied by Caldari Titan skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2510 -> { DogmaAttributeData.id= 2510; name= "behaviorWarpDisruptStrength"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2607 -> { DogmaAttributeData.id= 2607; name= "industrialCoreLocalLogisticsAmountBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2704 -> { DogmaAttributeData.id= 2704; name= "moonYieldMultiplier"; description= "Defines relation over moon spew volume vs time to drill/create spew"; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 279 -> { DogmaAttributeData.id= 279; name= "requiredSkill3Level"; description= "Required skill level for skill 3"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2801 -> { DogmaAttributeData.id= 2801; name= "shipBonusPBC1"; description= "Precursor Battlecruiser Skill Attribute"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 376 -> { DogmaAttributeData.id= 376; name= "refiningTimePercent"; description= "Refining time Multiplier"; published= true; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 473 -> { DogmaAttributeData.id= 473; name= "prototypingBonus"; description= "Autogenerated skill attribute, prototypingBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 570 -> { DogmaAttributeData.id= 570; name= "eliteBonusBombers"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 667 -> { DogmaAttributeData.id= 667; name= "moduleShipGroup3"; description= "This module only fits on specific ship groups.  This is one of them."; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 764 -> { DogmaAttributeData.id= 764; name= "controlTowerEwRofBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 861 -> { DogmaAttributeData.id= 861; name= "canJump"; description= "1 = ship can use jump drive"; published= false; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 958 -> { DogmaAttributeData.id= 958; name= "hardeningBonus"; description= "Autogenerated skill attribute, hardeningBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None