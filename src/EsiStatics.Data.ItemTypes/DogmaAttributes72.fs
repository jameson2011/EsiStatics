namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes72=
    let getDogmaAttribute id = 
      match id with 
      | 1139 -> { DogmaAttributeData.id= 1139; name= "rigDrawbackBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 10.000000; stackable= true; highIsGood= true } |> Some
      | 1236 -> { DogmaAttributeData.id= 1236; name= "commandBonusEffective"; description= "commandBonusEffective"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1333 -> { DogmaAttributeData.id= 1333; name= "maxVelocityLimited"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1430 -> { DogmaAttributeData.id= 1430; name= "lightColor"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1527 -> { DogmaAttributeData.id= 1527; name= "armorMaxDamageResonance"; description= "Maximum value for armor resonances. Default = 1."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1624 -> { DogmaAttributeData.id= 1624; name= "shipBonus3CF"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 169 -> { DogmaAttributeData.id= 169; name= "agilityMultiplier"; description= "Multiplier to the agility of an object."; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1721 -> { DogmaAttributeData.id= 1721; name= "distributionIDGurista07"; description= "Distribution ID for sov upgrades in Guristas space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1818 -> { DogmaAttributeData.id= 1818; name= "aurumConversionRate"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1915 -> { DogmaAttributeData.id= 1915; name= "virusCoherenceBonus"; description= "Adds to the virus coherence of profession modules"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2012 -> { DogmaAttributeData.id= 2012; name= "entitySuperWeaponThermalDamage"; description= "Used for NPCs to replicate damage for the super weapon."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2109 -> { DogmaAttributeData.id= 2109; name= "serviceModuleFuelAmount"; description= "Fuel consumed at the beginning of each hour to keep a service module online."; published= true; unitId= Some(138); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2206 -> { DogmaAttributeData.id= 2206; name= "fighterAbilityWarpDisruptionPointStrengthInterim"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2303 -> { DogmaAttributeData.id= 2303; name= "shipBonusRole6"; description= "Ship Role Bonus. Not multiplied by skills."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2400 -> { DogmaAttributeData.id= 2400; name= "durationTargetIlluminationBurstProjector"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2497 -> { DogmaAttributeData.id= 2497; name= "behaviorRemoteShieldBoostFalloff"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2594 -> { DogmaAttributeData.id= 2594; name= "attributeEngRigMatBonus"; description= "Bonus on Material decrease for engineering rigs"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 266 -> { DogmaAttributeData.id= 266; name= "armorDamage"; description= "DO NOT MESS WITH. The amount of damage done to the entities armor hit points. Starting armor damage."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2691 -> { DogmaAttributeData.id= 2691; name= "mediumRemoteRepFittingMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2788 -> { DogmaAttributeData.id= 2788; name= "panicDuration"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 363 -> { DogmaAttributeData.id= 363; name= "amarrTechTimePercent"; description= "Production time multiplier when manufacturing amarr tech   "; published= true; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 460 -> { DogmaAttributeData.id= 460; name= "shipBonusMF"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 557 -> { DogmaAttributeData.id= 557; name= "maxFlightTimeBonus"; description= "Autogenerated skill attribute, max flightTimeBonus"; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 654 -> { DogmaAttributeData.id= 654; name= "aoeCloudSize"; description= "Size of the damage cloud caused by impact."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 72 -> { DogmaAttributeData.id= 72; name= "capacityBonus"; description= "Bonus to capacity (shield at least)."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 751 -> { DogmaAttributeData.id= 751; name= "controlTowerHybridOptimalBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 848 -> { DogmaAttributeData.id= 848; name= "aoeCloudSizeBonus"; description= "Booster attribute to explosion radius of missiles vs. signature radius."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 945 -> { DogmaAttributeData.id= 945; name= "entityTargetPaintDuration"; description= "Duration of NPC effect"; published= false; unitId= None; defaultValue= 30000.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None