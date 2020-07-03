﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes27=
    let getDogmaAttribute id = 
      match id with 
      | 1094 -> { DogmaAttributeData.id= 1094; name= "displayCapacitorCapacityBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1191 -> { DogmaAttributeData.id= 1191; name= "maxDronePercentageBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 124 -> { DogmaAttributeData.id= 124; name= "mainColor"; description= "The main color of a ship type."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1288 -> { DogmaAttributeData.id= 1288; name= "requiredSkill6Level"; description= "Required skill level for skill 6"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1385 -> { DogmaAttributeData.id= 1385; name= "wormholeMaxJumpMass"; description= "The maximum amount of mass that can transit a wormhole in one go"; published= false; unitId= Some(2); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1482 -> { DogmaAttributeData.id= 1482; name= "damageMultiplierMultiplier"; description= "Multiplys the damage multiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1579 -> { DogmaAttributeData.id= 1579; name= "effectDeactivationDelay"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1676 -> { DogmaAttributeData.id= 1676; name= "entityGroupArmorResistanceBonus"; description= "Amount of armor resistance bonus. Used by NPCGroupArmorAssist. Negative values is a bonus so e.g. -20 is a 20% bonus"; published= true; unitId= Some(109); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1773 -> { DogmaAttributeData.id= 1773; name= "gender"; description= "Used to describe what sex a given item is meant for.    1 = Male,  2 = Unisex,  3 = Female"; published= true; unitId= Some(142); defaultValue= 2.000000; stackable= true; highIsGood= true } |> Some
      | 1870 -> { DogmaAttributeData.id= 1870; name= "covertCloakCPUAdd"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1967 -> { DogmaAttributeData.id= 1967; name= "aoeCloudSizeMultiplier"; description= ""; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2064 -> { DogmaAttributeData.id= 2064; name= "roleBonusCD"; description= "role bonus for command destroyers"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 221 -> { DogmaAttributeData.id= 221; name= "blueprintManufactureTimeMultiplier"; description= "Scales the time it takes a character to manufacture a blueprint."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2258 -> { DogmaAttributeData.id= 2258; name= "scanRadarStrengthPercentInterim"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2355 -> { DogmaAttributeData.id= 2355; name= "hiSecModifier"; description= ""; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2452 -> { DogmaAttributeData.id= 2452; name= "energyNeutralizerRangeFalloff"; description= "Falloff Range of Energy Neutralizer"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2549 -> { DogmaAttributeData.id= 2549; name= "attributeBasLargeShipManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  T1 Battleships, T1 Freighters,                                     Industrial Command Ships        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2646 -> { DogmaAttributeData.id= 2646; name= "BehaviorSiegeMassModifier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2743 -> { DogmaAttributeData.id= 2743; name= "structureFullPowerStateHitpointMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 3034 -> { DogmaAttributeData.id= 3034; name= "maxLockedTargetsMultiplier"; description= "Multiplier for maximum number of targets that can be locked."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 318 -> { DogmaAttributeData.id= 318; name= "speedFBonus"; description= "Autogenerated skill attribute, speedFBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 415 -> { DogmaAttributeData.id= 415; name= "fastTalkMutator"; description= "Autogenerated skill attribute, fastTalkMutator"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 512 -> { DogmaAttributeData.id= 512; name= "modifyTargetSpeedChance"; description= "Chance that  an entity will use a Stasis Web on a target."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 609 -> { DogmaAttributeData.id= 609; name= "chargeGroup4"; description= "One of the groups of charge this launcher can be loaded with."; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 706 -> { DogmaAttributeData.id= 706; name= "resourceOnline2Type"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 803 -> { DogmaAttributeData.id= 803; name= "implantSetSerpentis2"; description= ""; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 997 -> { DogmaAttributeData.id= 997; name= "passiveThermicDamageResistanceBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | _ -> None