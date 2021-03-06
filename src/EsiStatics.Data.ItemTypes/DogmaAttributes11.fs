﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes11=
    let getDogmaAttribute id = 
      match id with 
      | 108 -> { DogmaAttributeData.id= 108; name= "detonationRange"; description= "the range in meters for an object to trigger detonation of missile. (own ship excluded)"; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 11 -> { DogmaAttributeData.id= 11; name= "powerOutput"; description= "power output of power core"; published= true; unitId= Some(107); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1175 -> { DogmaAttributeData.id= 1175; name= "heatHi"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1272 -> { DogmaAttributeData.id= 1272; name= "droneBandwidthUsed"; description= ""; published= true; unitId= Some(128); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1369 -> { DogmaAttributeData.id= 1369; name= "launcherHardPointModifier"; description= ""; published= true; unitId= Some(139); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1466 -> { DogmaAttributeData.id= 1466; name= "armorKineticDamageResistanceBonus"; description= "Kinetic damage resistance bonus for armor"; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1563 -> { DogmaAttributeData.id= 1563; name= "specialLargeShipHoldCapacity"; description= "Capacity of battleship hold"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1660 -> { DogmaAttributeData.id= 1660; name= "entityRemoteECMDurationScale"; description= "The scaling factor used for the NPC remote ECM"; published= true; unitId= None; defaultValue= 0.900000; stackable= true; highIsGood= true } |> Some
      | 1757 -> { DogmaAttributeData.id= 1757; name= "distributionID03"; description= "Distribution ID for global sov upgrades"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1854 -> { DogmaAttributeData.id= 1854; name= "doesNotEmergencyWarp"; description= "This is a devhax attribute that prevents you from e-warping on logon or logoff"; published= false; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1951 -> { DogmaAttributeData.id= 1951; name= "industryStructureCostBonusSet"; description= "Shares cost bonus with other structures in this set"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2048 -> { DogmaAttributeData.id= 2048; name= "entitySuperWeaponTrackingSpeed"; description= "Used for chance based accuracy hit calculation for entity super weapon."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 205 -> { DogmaAttributeData.id= 205; name= "accuracyMultiplier"; description= "Scales the accuracy of some targeted weapon."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2145 -> { DogmaAttributeData.id= 2145; name= "missileVelocityBonusInterim"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2242 -> { DogmaAttributeData.id= 2242; name= "fighterAbilityTackleWebSpeedPenalty"; description= "Maximum Velocity Bonus"; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2339 -> { DogmaAttributeData.id= 2339; name= "structureServiceRoleBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2436 -> { DogmaAttributeData.id= 2436; name= "structureRigPDRangeBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2533 -> { DogmaAttributeData.id= 2533; name= "behaviorECMFalloff"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2630 -> { DogmaAttributeData.id= 2630; name= "behaviorEnergyNosferatuDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2727 -> { DogmaAttributeData.id= 2727; name= "asteroidMaxRadius "; description= "max visual size for asteroids to fit moon chunk"; published= false; unitId= Some(9); defaultValue= 16255.000000; stackable= true; highIsGood= true } |> Some
      | 2824 -> { DogmaAttributeData.id= 2824; name= "damageMultiplierBonusPerCycleModifier"; description= "Modifier for Triglavian ramp-up value"; published= true; unitId= Some(105); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 302 -> { DogmaAttributeData.id= 302; name= "ciTRangeBonus"; description= "Autogenerated skill attribute, ciTRangeBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 399 -> { DogmaAttributeData.id= 399; name= "duplicatingChance"; description= "Chance of upgrading a module to next tech level "; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 496 -> { DogmaAttributeData.id= 496; name= "shipBonusGI"; description= ""; published= false; unitId= None; defaultValue= 5.000000; stackable= true; highIsGood= true } |> Some
      | 690 -> { DogmaAttributeData.id= 690; name= "packageRadius"; description= "The radius of the structure when it is in package form."; published= false; unitId= None; defaultValue= 250.000000; stackable= true; highIsGood= true } |> Some
      | 787 -> { DogmaAttributeData.id= 787; name= "minScanDeviation"; description= "Minimum scanning error"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 884 -> { DogmaAttributeData.id= 884; name= "mindlinkBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 981 -> { DogmaAttributeData.id= 981; name= "allowsCloneJumpsWhenActive"; description= "If this module is active and the ship supports it, the ship can serve as a destination for clone jumps."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None