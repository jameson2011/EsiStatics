namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes76=
    let getDogmaAttribute id = 
      match id with 
      | 1143 -> { DogmaAttributeData.id= 1143; name= "boosterShieldCapacityPenalty"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1240 -> { DogmaAttributeData.id= 1240; name= "shipBonusORECapital2"; description= "shipBonusORECapital2"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1337 -> { DogmaAttributeData.id= 1337; name= "captureProximityRange"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1434 -> { DogmaAttributeData.id= 1434; name= "subsystemBonusAmarrOffensive"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1531 -> { DogmaAttributeData.id= 1531; name= "subsystemBonusAmarrOffensive3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1725 -> { DogmaAttributeData.id= 1725; name= "distributionIDRogueDrone01"; description= "Distribution ID for sov upgrades in Rogue Drone space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 173 -> { DogmaAttributeData.id= 173; name= "customMemoryBonus"; description= "Bonus to the memory of a character specified by the player in character creation."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1822 -> { DogmaAttributeData.id= 1822; name= "rookieSETCapBonus"; description= "Reduction in energy turret capacitor use"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1919 -> { DogmaAttributeData.id= 1919; name= "tierDifficulty"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2016 -> { DogmaAttributeData.id= 2016; name= "shipBonusTacticalDestroyerCaldari2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2113 -> { DogmaAttributeData.id= 2113; name= "weaponDisruptionResistance"; description= "Resistance against Remote Weapon Disruptors."; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2210 -> { DogmaAttributeData.id= 2210; name= "fighterAbilityEnergyNeutralizerFalloffRange"; description= "Effectiveness Falloff"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2307 -> { DogmaAttributeData.id= 2307; name= "siegeTurretDamageBonus"; description= "Turret Damage Bonus Percentage"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2404 -> { DogmaAttributeData.id= 2404; name= "kineticDamageResistanceBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2501 -> { DogmaAttributeData.id= 2501; name= "behaviorWebifierFalloff"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2598 -> { DogmaAttributeData.id= 2598; name= "warfareBuff3Multiplier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2695 -> { DogmaAttributeData.id= 2695; name= "remoteArmorRepairerOptimalBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 270 -> { DogmaAttributeData.id= 270; name= "armorThermalDamageResonance"; description= "Multiplies THERMAL damage taken by Armor. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 2792 -> { DogmaAttributeData.id= 2792; name= "preFitServiceSlot0"; description= "Module type ID to pre-fit into service slot 0"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 367 -> { DogmaAttributeData.id= 367; name= "productionTimePercent"; description= "Production time percentage"; published= true; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 464 -> { DogmaAttributeData.id= 464; name= "shipBonusAF"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 561 -> { DogmaAttributeData.id= 561; name= "shipBonusGB2"; description= "skill bonus attribute2 for gallente battleship"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 658 -> { DogmaAttributeData.id= 658; name= "shipBonusGC2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 755 -> { DogmaAttributeData.id= 755; name= "controlTowerMissileROFBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 76 -> { DogmaAttributeData.id= 76; name= "maxTargetRange"; description= "Maximum range at which the scanner can lock a target."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 852 -> { DogmaAttributeData.id= 852; name= "siegeModeWarpStatus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 949 -> { DogmaAttributeData.id= 949; name= "entityTargetPaintMultiplier"; description= "Multiplier on signature radius of player ship done by NPC"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None