namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes54=
    let getDogmaAttribute id = 
      match id with 
      | 1024 -> { DogmaAttributeData.id= 1024; name= "warpAccuracyMaxRangeMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1121 -> { DogmaAttributeData.id= 1121; name= "scanStrengthStructures"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1218 -> { DogmaAttributeData.id= 1218; name= "powerTransferPowerNeedBonus"; description= "Reduction of power grid needs of energy transfer arrays"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1315 -> { DogmaAttributeData.id= 1315; name= "maxRangeBonusBonus"; description= "Bonus to maxRangeBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1412 -> { DogmaAttributeData.id= 1412; name= "wormholeTargetSystem9"; description= "Specific target system 9 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1509 -> { DogmaAttributeData.id= 1509; name= "subsystemBonusAmarrCore2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 151 -> { DogmaAttributeData.id= 151; name= "agilityBonus"; description= "Bonus to the agility for a ship."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1606 -> { DogmaAttributeData.id= 1606; name= "distributionID_blood"; description= "Obsolete attribute"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 1703 -> { DogmaAttributeData.id= 1703; name= "distributionIDAngel09"; description= "Distribution ID for sov upgrades in Angel space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1897 -> { DogmaAttributeData.id= 1897; name= "entityCapacitorLevelModifierLarge"; description= "modifier to an entity capacitor level to represent energy drain for large ships"; published= false; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1994 -> { DogmaAttributeData.id= 1994; name= "modeLadarStrengthPostDiv"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2091 -> { DogmaAttributeData.id= 2091; name= "roleBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2188 -> { DogmaAttributeData.id= 2188; name= "fighterAbilityStasisWebifierResistanceID"; description= ""; published= false; unitId= Some(119); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2285 -> { DogmaAttributeData.id= 2285; name= "shipBonusDreadnoughtA3"; description= "Multiplied by Amarr Dreadnought skill level"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2382 -> { DogmaAttributeData.id= 2382; name= "shipBonusSupercarrierC3"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2479 -> { DogmaAttributeData.id= 2479; name= "canFitShipGroup14"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 248 -> { DogmaAttributeData.id= 248; name= "entityLootValueMin"; description= "The minimum value of any given unit of loot dropped by this entity.  Not the minimum value of all the loot, but of any given item dropped."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2576 -> { DogmaAttributeData.id= 2576; name= "attributeCapShipManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  Capital Ships"; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2673 -> { DogmaAttributeData.id= 2673; name= "behaviorMiningMaxRange"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2770 -> { DogmaAttributeData.id= 2770; name= "kineticDamageResonanceMax"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 442 -> { DogmaAttributeData.id= 442; name= "barterDiscount"; description= "skill discount when selling to npc corps"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 54 -> { DogmaAttributeData.id= 54; name= "maxRange"; description= "Distance below which range does not affect the to-hit equation."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 636 -> { DogmaAttributeData.id= 636; name= "entityShieldBoostDuration"; description= "How long between repeats."; published= false; unitId= None; defaultValue= 10000.000000; stackable= true; highIsGood= true } |> Some
      | 733 -> { DogmaAttributeData.id= 733; name= "shipBonusD2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 830 -> { DogmaAttributeData.id= 830; name= "bonusComplexAngel10"; description= "Bonus used on Unique Loot in level 10 Angel cartel Deadspace Complexes."; published= false; unitId= None; defaultValue= 5.000000; stackable= true; highIsGood= true } |> Some
      | 927 -> { DogmaAttributeData.id= 927; name= "miningUpgradeCPUReductionBonus"; description= "CPU Penalty Reduction"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None