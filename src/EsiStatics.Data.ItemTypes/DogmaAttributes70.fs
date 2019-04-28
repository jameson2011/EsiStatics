namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes70=
    let getDogmaAttribute id = 
      match id with 
      | 1137 -> { DogmaAttributeData.id= 1137; name= "rigSlots"; description= "The number of rig slots on the ship."; published= false; unitId= Some(122); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1234 -> { DogmaAttributeData.id= 1234; name= "surveyScannerRangeBonus"; description= "Survey Scanner Range Bonus"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1331 -> { DogmaAttributeData.id= 1331; name= "isArcheology"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1428 -> { DogmaAttributeData.id= 1428; name= "passiveHullKineticDamageResonance"; description= ""; published= true; unitId= Some(127); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1525 -> { DogmaAttributeData.id= 1525; name= "subsystemBonusMinmatarCore2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 167 -> { DogmaAttributeData.id= 167; name= "perception"; description= "The perception of a character."; published= true; unitId= Some(120); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1719 -> { DogmaAttributeData.id= 1719; name= "distributionIDGurista05"; description= "Distribution ID for sov upgrades in Guristas space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1816 -> { DogmaAttributeData.id= 1816; name= "neutReflectAmountBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 1.000000; stackable= false; highIsGood= true } |> Some
      | 1913 -> { DogmaAttributeData.id= 1913; name= "defaultJunkLootTypeID"; description= "Default junk loot to spawn into a mini container that does not contain anything fancy from a loot table."; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2010 -> { DogmaAttributeData.id= 2010; name= "entitySuperWeaponEmDamage"; description= "Used for NPCs to replicate damage for the super weapon."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2107 -> { DogmaAttributeData.id= 2107; name= "fighterMicroJumpDriveDuration"; description= "Length of activation time."; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2204 -> { DogmaAttributeData.id= 2204; name= "fighterAbilityWarpDisruptionRange"; description= "Optimal Range"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2301 -> { DogmaAttributeData.id= 2301; name= "shipBonusRole4"; description= "Ship Role Bonus. Not multiplied by skills."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2398 -> { DogmaAttributeData.id= 2398; name= "durationECMJammerBurstProjector"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2495 -> { DogmaAttributeData.id= 2495; name= "behaviorRemoteShieldBoostDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2592 -> { DogmaAttributeData.id= 2592; name= "attributeAllShipsManufactureMaterialMultiplier"; description= "bonus that affects material of all ships being manufactured, for XL rigs"; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 264 -> { DogmaAttributeData.id= 264; name= "shieldCharge"; description= "DO NOT MESS WITH. Helper attribute for entities, stands in for the shield charge.  The amount of starting shield capacity of the NPC."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2689 -> { DogmaAttributeData.id= 2689; name= "cargoCapacityAdd"; description= ""; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2786 -> { DogmaAttributeData.id= 2786; name= "npcBehaviorMaximumCombatOrbitRange"; description= "Used by Behavior NPCs to work out minimum orbit range. If the npc has an effect with a shorter range, it will use the effects range instead."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 361 -> { DogmaAttributeData.id= 361; name= "criminalConnectionsBonus"; description= "a bonus to standing towards npc with negativa security status"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 458 -> { DogmaAttributeData.id= 458; name= "droneControlDistance"; description= ""; published= true; unitId= Some(1); defaultValue= 20000.000000; stackable= true; highIsGood= true } |> Some
      | 555 -> { DogmaAttributeData.id= 555; name= "cloakVelocityBonus"; description= "Autogenerated skill attribute, cloakVelocityBonus"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 652 -> { DogmaAttributeData.id= 652; name= "signatureRadiusMultiplier"; description= ""; published= true; unitId= Some(109); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 70 -> { DogmaAttributeData.id= 70; name= "agility"; description= "The agility of the object."; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 749 -> { DogmaAttributeData.id= 749; name= "shipBonusMBC2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 846 -> { DogmaAttributeData.id= 846; name= "scanStrengthBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 943 -> { DogmaAttributeData.id= 943; name= "entitySensorDampenDuration"; description= "Duration of NPC effect"; published= false; unitId= None; defaultValue= 30000.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None