﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes5=
    let getDogmaAttribute id = 
      match id with 
      | 102 -> { DogmaAttributeData.id= 102; name= "turretSlotsLeft"; description= "Remaining number of unused turret slots on the ship."; published= true; unitId= Some(141); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1169 -> { DogmaAttributeData.id= 1169; name= "scanGenericStrength"; description= "Sensor strength all types"; published= true; unitId= Some(120); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 1266 -> { DogmaAttributeData.id= 1266; name= "eliteBonusViolators2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1460 -> { DogmaAttributeData.id= 1460; name= "npcRemoteShieldBoostAmount"; description= "How many shields points does the activation of the effect bestow upon the target"; published= false; unitId= Some(120); defaultValue= 50.000000; stackable= true; highIsGood= true } |> Some
      | 1557 -> { DogmaAttributeData.id= 1557; name= "specialGasHoldCapacity"; description= "Capacity of gas-only hold"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1654 -> { DogmaAttributeData.id= 1654; name= "AI_ImmuneToSuperWeapon"; description= "Can not be attacked by doomsday devices"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1751 -> { DogmaAttributeData.id= 1751; name= "distributionIDSerpentis07"; description= "Distribution ID for sov upgrades in Serpentis space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1848 -> { DogmaAttributeData.id= 1848; name= "902"; description= "Autogenerated skill attribute, 902"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1945 -> { DogmaAttributeData.id= 1945; name= "nosOverride"; description= "NOS override allows a nosferatu module to drain the target capacitor below the current ships capacitor level."; published= false; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2042 -> { DogmaAttributeData.id= 2042; name= "entosisCPUPenalty"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2139 -> { DogmaAttributeData.id= 2139; name= "maxRangeBonusInterim"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2236 -> { DogmaAttributeData.id= 2236; name= "fighterAbilityAttackMissileRangeOptimal"; description= "Optimal Range"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2333 -> { DogmaAttributeData.id= 2333; name= "structureRoleBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2430 -> { DogmaAttributeData.id= 2430; name= "doomsdayRangeIsFixed"; description= "Determines whether the maxRange attribute is a fixed length or a maximum length of the effect"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2527 -> { DogmaAttributeData.id= 2527; name= "behaviorSensorDampenerDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2624 -> { DogmaAttributeData.id= 2624; name= "constantFifty"; description= ""; published= false; unitId= None; defaultValue= 50.000000; stackable= true; highIsGood= true } |> Some
      | 2721 -> { DogmaAttributeData.id= 2721; name= "strReactionTimeMultiplier"; description= "Time bonus for Refinery Structures"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2818 -> { DogmaAttributeData.id= 2818; name= "behaviorMicroJumpAttackJumpDistance"; description= "The length of the jump induced by the npcBehaviorMicroJumpAttack effect in meters"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 296 -> { DogmaAttributeData.id= 296; name= "acPowerBonus"; description= "Autogenerated skill attribute, acPowerBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 393 -> { DogmaAttributeData.id= 393; name= "battleshipConstructionCost"; description= "The % of battleship assembly cost a player has to pay to assemble a battleship"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 490 -> { DogmaAttributeData.id= 490; name= "shipBonusMB"; description= ""; published= false; unitId= None; defaultValue= 5.000000; stackable= true; highIsGood= true } |> Some
      | 587 -> { DogmaAttributeData.id= 587; name= "shipBonusMF2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 684 -> { DogmaAttributeData.id= 684; name= "typeContainerCapacity1"; description= "The amount of storage type 1 that can be fitted inside this structure."; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 781 -> { DogmaAttributeData.id= 781; name= "specialisationAsteroidGroup"; description= "The group at which the mining crystal is tuned to mine."; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 975 -> { DogmaAttributeData.id= 975; name= "hullExplosiveDamageResonance"; description= ""; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | _ -> None