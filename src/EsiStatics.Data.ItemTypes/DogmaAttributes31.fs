namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes31=
    let getDogmaAttribute id = 
      match id with 
      | 1001 -> { DogmaAttributeData.id= 1001; name= "jumpPortalConsumptionMassFactor"; description= "Multiplier used to calculate amount of quantity used for jumping via portals based on mass of ship."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1098 -> { DogmaAttributeData.id= 1098; name= "displayRangeSkillBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1195 -> { DogmaAttributeData.id= 1195; name= "posAnchoredPerSolarSystemAmount"; description= "How many structures in this group can be anchored for the same alliance per solar system.  0 means there is no limit."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 128 -> { DogmaAttributeData.id= 128; name= "chargeSize"; description= "The size of the charges that can fit in the turret/whatever."; published= true; unitId= Some(117); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1292 -> { DogmaAttributeData.id= 1292; name= "implantSetORE"; description= "Harvest set bonus attribute"; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1389 -> { DogmaAttributeData.id= 1389; name= "wormholeTargetRegion4"; description= "Specific target region 4 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1486 -> { DogmaAttributeData.id= 1486; name= "overloadBonusMultiplier"; description= "Multiplier to all overload bonuses"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1583 -> { DogmaAttributeData.id= 1583; name= "devIndexMilitary"; description= "The required minimum military development index level"; published= true; unitId= Some(140); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1680 -> { DogmaAttributeData.id= 1680; name= "entityGroupPropJamActivationChance"; description= "Activation chance of NPCGroupPropJamAssist effect."; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1971 -> { DogmaAttributeData.id= 1971; name= "jumpFatigueMultiplier"; description= "Multiplier for jump fatigue distance"; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 225 -> { DogmaAttributeData.id= 225; name= "memorySkillTrainingTimeMultiplier"; description= "Scales the time it takes to train skills with Memory as the primary attribute."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2262 -> { DogmaAttributeData.id= 2262; name= "doomsdayWarningDuration"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2359 -> { DogmaAttributeData.id= 2359; name= "shipBonusCarrierA1"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2456 -> { DogmaAttributeData.id= 2456; name= "shieldCapacityBonus2"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2553 -> { DogmaAttributeData.id= 2553; name= "attributeAdvMediumShipManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  T2 Cruisers, T2 Battlecruisers, T2 Haulers, Exhumers, T3 Cruisers,T3 Subsystems        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2747 -> { DogmaAttributeData.id= 2747; name= "stasisWebRangeBonus"; description= "Percent bonus for Stasis Webifiers maximum range"; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 31 -> { DogmaAttributeData.id= 31; name= "maxArmor"; description= "The number of hit points this module can take  "; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 322 -> { DogmaAttributeData.id= 322; name= "burstSpeedMutator"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 419 -> { DogmaAttributeData.id= 419; name= "skillPointsSaved"; description= "Amount of skill points saved by clone"; published= true; unitId= None; defaultValue= 10000.000000; stackable= true; highIsGood= true } |> Some
      | 516 -> { DogmaAttributeData.id= 516; name= "chassisType"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 613 -> { DogmaAttributeData.id= 613; name= "baseArmorDamage"; description= "Just for the UI to display base damage on armor."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 710 -> { DogmaAttributeData.id= 710; name= "harvesterQuality"; description= "The quality of the material harvested."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 807 -> { DogmaAttributeData.id= 807; name= "eliteBonusIndustrial1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 904 -> { DogmaAttributeData.id= 904; name= "warcruiserCPUBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None