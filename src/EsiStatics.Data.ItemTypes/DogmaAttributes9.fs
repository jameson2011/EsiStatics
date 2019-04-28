﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes9=
    let getDogmaAttribute id = 
      match id with 
      | 106 -> { DogmaAttributeData.id= 106; name= "droneBaySlotsLeft"; description= "The remaining amount of unused drone bay slots on the ship."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1076 -> { DogmaAttributeData.id= 1076; name= "implantBonusVelocity"; description= ""; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1173 -> { DogmaAttributeData.id= 1173; name= "structureShieldBoostValue"; description= "Value modified by remote starbase structure repair effects (should be 0 unless the structure repairs itself)"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1270 -> { DogmaAttributeData.id= 1270; name= "speedBoostFactorBonus"; description= "Afterburner and Microwarpdrive Thrust Bonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1367 -> { DogmaAttributeData.id= 1367; name= "maxSubSystems"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1464 -> { DogmaAttributeData.id= 1464; name= "npcAssistanceRange"; description= "Maximum distance to a friendly NPC so that remote repairs may be performed on it."; published= false; unitId= Some(1); defaultValue= 5000.000000; stackable= false; highIsGood= true } |> Some
      | 1561 -> { DogmaAttributeData.id= 1561; name= "specialSmallShipHoldCapacity"; description= "Capacity of frigate/destroyer hold"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1658 -> { DogmaAttributeData.id= 1658; name= "entityRemoteECMDuration"; description= "The current duration for the remote ECM ( this is recalculated each time it is activated )"; published= true; unitId= None; defaultValue= 300000.000000; stackable= true; highIsGood= true } |> Some
      | 1755 -> { DogmaAttributeData.id= 1755; name= "distributionID01"; description= "Distribution ID for global sov upgrades"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1852 -> { DogmaAttributeData.id= 1852; name= "canBeJettisoned"; description= "This attribute is not needed by default. You only need to add it if you want to stop something from being jettisoned.    The primary case for this was Station Containers.    0 = Cannot be jettisoned.  1 = Can be jettisoned."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1949 -> { DogmaAttributeData.id= 1949; name= "roleBonusOverheatDST"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 203 -> { DogmaAttributeData.id= 203; name= "miningDurationMultiplier"; description= "Factor to scale mining laser durations by."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2046 -> { DogmaAttributeData.id= 2046; name= "entitySuperWeaponMaxRange"; description= "Used for chance based accuracy hit calculation for entity super weapon."; published= false; unitId= None; defaultValue= 250000.000000; stackable= true; highIsGood= true } |> Some
      | 2143 -> { DogmaAttributeData.id= 2143; name= "aoeVelocityBonusInterim"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2337 -> { DogmaAttributeData.id= 2337; name= "fighterBonusROFPercent"; description= "Bonus to fighter ROF (%)"; published= true; unitId= Some(111); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2434 -> { DogmaAttributeData.id= 2434; name= "structureRigMaxTargetBonus"; description= ""; published= true; unitId= Some(139); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2531 -> { DogmaAttributeData.id= 2531; name= "behaviorECMDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2628 -> { DogmaAttributeData.id= 2628; name= "eliteBonusBlackOps4"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2725 -> { DogmaAttributeData.id= 2725; name= "BehaviorShieldBoosterDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 300 -> { DogmaAttributeData.id= 300; name= "ccTRangeBonus"; description= "Autogenerated skill attribute, ccTRangeBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 397 -> { DogmaAttributeData.id= 397; name= "reverseEngineeringChance"; description= "Chance of making a research breakthrough when researching a higher tech level of a blueprint"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 494 -> { DogmaAttributeData.id= 494; name= "shipBonusAI"; description= ""; published= false; unitId= None; defaultValue= 5.000000; stackable= true; highIsGood= true } |> Some
      | 591 -> { DogmaAttributeData.id= 591; name= "droneMaxVelocityBonus"; description= "Increases max velocity of all drone types."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 688 -> { DogmaAttributeData.id= 688; name= "reinforcedConsumptionRate"; description= "The number of units of a resource consumed per minute of reinforced mode."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 785 -> { DogmaAttributeData.id= 785; name= "unfitCapCost"; description= "The capacitor charge required to disengage this crystal from the unit it is installed in."; published= true; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 9 -> { DogmaAttributeData.id= 9; name= "hp"; description= "The maximum hitpoints of an object."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 979 -> { DogmaAttributeData.id= 979; name= "maxJumpClones"; description= "The maximum amount of jump clones that the character may have in existence or ship may have stored."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None