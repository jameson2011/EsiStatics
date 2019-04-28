namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes74=
    let getDogmaAttribute id = 
      match id with 
      | 1141 -> { DogmaAttributeData.id= 1141; name= "boosterArmorHPPenalty"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1238 -> { DogmaAttributeData.id= 1238; name= "commandBonusEffectiveAdd"; description= "commandBonusEffectiveAdd"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1335 -> { DogmaAttributeData.id= 1335; name= "defenderRaceID"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1432 -> { DogmaAttributeData.id= 1432; name= "subsystemBonusAmarrElectronic"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1529 -> { DogmaAttributeData.id= 1529; name= "hullMaxDamageResonance"; description= "Maximum value for hull resonances. Default = 1."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1626 -> { DogmaAttributeData.id= 1626; name= "shipBonus3MF"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 171 -> { DogmaAttributeData.id= 171; name= "customWillpowerBonus"; description= "Bonus to the willpower of a character specified by the player in character creation."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1723 -> { DogmaAttributeData.id= 1723; name= "distributionIDGurista09"; description= "Distribution ID for sov upgrades in Guristas space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1820 -> { DogmaAttributeData.id= 1820; name= "baseDefenderAllyCost"; description= "The base cost of hiring an ally into a war"; published= false; unitId= Some(133); defaultValue= 10000000.000000; stackable= true; highIsGood= true } |> Some
      | 1917 -> { DogmaAttributeData.id= 1917; name= "spewContainerLifeExtension"; description= "If present, will add the given value to the automatic computed lifetime of MiniContainers with regards to the time required to take them and the amount of containers scattered out into space."; published= true; unitId= Some(3); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2014 -> { DogmaAttributeData.id= 2014; name= "shipBonusGC3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2111 -> { DogmaAttributeData.id= 2111; name= "vulnerabilityRequired"; description= "Number of hours of vulnerability each week required. Applies only to categoryStructure."; published= true; unitId= Some(129); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2208 -> { DogmaAttributeData.id= 2208; name= "fighterAbilityEnergyNeutralizerDuration"; description= "Duration"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 2305 -> { DogmaAttributeData.id= 2305; name= "siegeLauncherROFBonus"; description= "XL Launcher ROF Bonus Percentage"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2402 -> { DogmaAttributeData.id= 2402; name= "emDamageResistanceBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2499 -> { DogmaAttributeData.id= 2499; name= "behaviorWebifierDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2596 -> { DogmaAttributeData.id= 2596; name= "warfareBuff1Multiplier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 268 -> { DogmaAttributeData.id= 268; name= "armorExplosiveDamageResonance"; description= "Multiplies EXPLOSIVE damage taken by Armor. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 2693 -> { DogmaAttributeData.id= 2693; name= "remoteShieldBoosterFalloffBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2790 -> { DogmaAttributeData.id= 2790; name= "cargoDeliveryRange"; description= "Distance which players can deposit cargo into a structure"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 365 -> { DogmaAttributeData.id= 365; name= "gallenteTechTimePercent"; description= "Production time multiplier when manufacturing Gallente tech   "; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 462 -> { DogmaAttributeData.id= 462; name= "shipBonusGF"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 559 -> { DogmaAttributeData.id= 559; name= "Inertia"; description= "Inertia is a basic multiplier of agility and the mass of the ship, it determines how fast the ship can accelerate and how fast it can fly when orbiting."; published= false; unitId= Some(2); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 656 -> { DogmaAttributeData.id= 656; name= "shipBonusAC2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 753 -> { DogmaAttributeData.id= 753; name= "controlTowerProjectileFallOffBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 850 -> { DogmaAttributeData.id= 850; name= "squadronCommandBonus"; description= "Autogenerated skill attribute, relayCPUBonus"; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 947 -> { DogmaAttributeData.id= 947; name= "entitySensorDampenMultiplier"; description= "Multiplier on max target range and scan resolution of target ship done by NPC"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None