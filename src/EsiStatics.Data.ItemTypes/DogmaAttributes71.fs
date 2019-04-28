namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes71=
    let getDogmaAttribute id = 
      match id with 
      | 1138 -> { DogmaAttributeData.id= 1138; name= "drawback"; description= "used on rigs"; published= true; unitId= Some(105); defaultValue= 10.000000; stackable= true; highIsGood= true } |> Some
      | 1235 -> { DogmaAttributeData.id= 1235; name= "cargoScannerRangeBonus"; description= "Cargo Scanner Range Bonus"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1332 -> { DogmaAttributeData.id= 1332; name= "falloffBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 1399.000000; stackable= true; highIsGood= true } |> Some
      | 1429 -> { DogmaAttributeData.id= 1429; name= "passiveHullThermalDamageResonance"; description= ""; published= true; unitId= Some(127); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1526 -> { DogmaAttributeData.id= 1526; name= "subsystemBonusMinmatarDefensive2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1623 -> { DogmaAttributeData.id= 1623; name= "shipBonus3AF"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 168 -> { DogmaAttributeData.id= 168; name= "willpower"; description= "The willpower of a character."; published= true; unitId= Some(120); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1720 -> { DogmaAttributeData.id= 1720; name= "distributionIDGurista06"; description= "Distribution ID for sov upgrades in Guristas space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1817 -> { DogmaAttributeData.id= 1817; name= "nosReflectAmountBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 1.000000; stackable= false; highIsGood= true } |> Some
      | 1914 -> { DogmaAttributeData.id= 1914; name= "spewVelocity"; description= "The speed at which mini containers fly away from a spew container"; published= true; unitId= Some(10); defaultValue= 65.000000; stackable= true; highIsGood= true } |> Some
      | 2011 -> { DogmaAttributeData.id= 2011; name= "entitySuperWeaponKineticDamage"; description= "Used for NPCs to replicate damage for the super weapon."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2108 -> { DogmaAttributeData.id= 2108; name= "serviceModuleFuelConsumptionGroup"; description= "Fuel consumed by the structure service module"; published= false; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2205 -> { DogmaAttributeData.id= 2205; name= "fighterAbilityWarpDisruptionPointStrength"; description= "Warp Disruption Strength"; published= true; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2302 -> { DogmaAttributeData.id= 2302; name= "shipBonusRole5"; description= "Ship Role Bonus. Not multiplied by skills."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2399 -> { DogmaAttributeData.id= 2399; name= "durationSensorDampeningBurstProjector"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2496 -> { DogmaAttributeData.id= 2496; name= "behaviorRemoteShieldBoostRange"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2593 -> { DogmaAttributeData.id= 2593; name= "attributeEngRigTimeBonus"; description= "Bonus on Time decrease for engineering rigs"; published= true; unitId= Some(105); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 265 -> { DogmaAttributeData.id= 265; name= "armorHP"; description= "The number of hit points on the entities armor."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2690 -> { DogmaAttributeData.id= 2690; name= "agilityBonusAdd"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2787 -> { DogmaAttributeData.id= 2787; name= "monumentAllianceID"; description= "This is used to connect the alliance logos to the monuments that were placed as part of the outpost and conquerable station phaseout process in 2018"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 362 -> { DogmaAttributeData.id= 362; name= "socialBonus"; description= "Bonus To standing gain towards non CONCORD npcs  "; published= true; unitId= Some(105); defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 459 -> { DogmaAttributeData.id= 459; name= "droneRangeBonus"; description= "Autogenerated skill attribute, droneRangeBonus"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 556 -> { DogmaAttributeData.id= 556; name= "anchoringDelay"; description= "How long it takes to anchor or unanchor this object."; published= true; unitId= Some(101); defaultValue= 60000.000000; stackable= true; highIsGood= true } |> Some
      | 653 -> { DogmaAttributeData.id= 653; name= "aoeVelocity"; description= "Velocity of the damage cloud created on impact."; published= true; unitId= Some(10); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 750 -> { DogmaAttributeData.id= 750; name= "controlTowerLaserOptimalBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 847 -> { DogmaAttributeData.id= 847; name= "aoeVelocityBonus"; description= "Increases velocity of missile explosion"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 944 -> { DogmaAttributeData.id= 944; name= "entityTrackingDisruptDuration"; description= "Duration of NPC effect"; published= false; unitId= None; defaultValue= 30000.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None