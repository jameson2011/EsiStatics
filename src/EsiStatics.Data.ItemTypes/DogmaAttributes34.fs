namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes34=
    let getDogmaAttribute id = 
      match id with 
      | 1004 -> { DogmaAttributeData.id= 1004; name= "eliteBonusCommandShip2DONOTUSE"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1101 -> { DogmaAttributeData.id= 1101; name= "boosterAttribute3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1198 -> { DogmaAttributeData.id= 1198; name= "heatDissipationRateLow"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1295 -> { DogmaAttributeData.id= 1295; name= "moduleRepairRateBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 131 -> { DogmaAttributeData.id= 131; name= "kineticDamageResonanceMultiplier"; description= "Multiplier to the kinetic damage resonance of something."; published= true; unitId= Some(111); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 1392 -> { DogmaAttributeData.id= 1392; name= "wormholeTargetRegion7"; description= "Specific target region 7 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1489 -> { DogmaAttributeData.id= 1489; name= "shieldEmDamageResistanceBonus"; description= "EM resistance bonus for shields"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1586 -> { DogmaAttributeData.id= 1586; name= "devIndexResearchDevelopment"; description= "The required ISK to be present in the research and development  development index."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1683 -> { DogmaAttributeData.id= 1683; name= "ecuDecayFactor"; description= ""; published= true; unitId= None; defaultValue= 0.012000; stackable= true; highIsGood= true } |> Some
      | 1780 -> { DogmaAttributeData.id= 1780; name= "npcCustomsOfficeTaxRate"; description= ""; published= false; unitId= None; defaultValue= 0.100000; stackable= true; highIsGood= true } |> Some
      | 1974 -> { DogmaAttributeData.id= 1974; name= "gateScrambleStrength"; description= "Amount to modify ships gate scramble status by."; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2071 -> { DogmaAttributeData.id= 2071; name= "bumpingStrength"; description= "Strength at which objects are pushed away from the bumping module point of impact"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2265 -> { DogmaAttributeData.id= 2265; name= "doomsdayDamageCycleTime"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 228 -> { DogmaAttributeData.id= 228; name= "charismaSkillTrainingTimeMultiplierBonus"; description= "Bonus or penalty to the percentage time it takes to train skills with Charisma as the primary attribute."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2362 -> { DogmaAttributeData.id= 2362; name= "shipBonusCarrierA4"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2459 -> { DogmaAttributeData.id= 2459; name= "maxCharacterSkillPointLimit"; description= "The maximum amount of skill points that the character can have before the item is unusable"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2556 -> { DogmaAttributeData.id= 2556; name= "attributeAdvLargeShipManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  T2 Battleships, Jump Freighters        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2653 -> { DogmaAttributeData.id= 2653; name= "attributeThukkerEngRigMatBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2750 -> { DogmaAttributeData.id= 2750; name= "hiddenMissileDamageMultiplier"; description= "Missile damage attribute used by structures as a workaround for implementing Standup BCS stacking penalties"; published= false; unitId= Some(104); defaultValue= 1.000000; stackable= false; highIsGood= true } |> Some
      | 325 -> { DogmaAttributeData.id= 325; name= "barrageFalloffMutator"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 422 -> { DogmaAttributeData.id= 422; name= "techLevel"; description= "Authoring has been moved to FSD  Tech level of an item"; published= true; unitId= Some(140); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 519 -> { DogmaAttributeData.id= 519; name= "cloakingCapacitorNeedRatio"; description= "The percentage of capacitor capacity required to engage cloaking."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 616 -> { DogmaAttributeData.id= 616; name= "boosterShieldBoostAmountPenalty"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 713 -> { DogmaAttributeData.id= 713; name= "consumptionType"; description= "The type of resource needed to be consumed for each activation cycle of this structure."; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 907 -> { DogmaAttributeData.id= 907; name= "hasShipMaintenanceBay"; description= "Indicates whether a ship type has a ship maintenance bay."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None