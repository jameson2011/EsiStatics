namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes55=
    let getDogmaAttribute id = 
      match id with 
      | 1025 -> { DogmaAttributeData.id= 1025; name= "warpAccuracyFactorPercentage"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1122 -> { DogmaAttributeData.id= 1122; name= "maxScanGroups"; description= "Max groups that a character can scan for with probes. Default is 0 and max groups will be 5 with a single skill adding 1 per skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1219 -> { DogmaAttributeData.id= 1219; name= "droneArmorDamageAmountBonus"; description= "Bonus to drone armor repair amount"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1316 -> { DogmaAttributeData.id= 1316; name= "trackingSpeedBonusBonus"; description= "Bonus to trackingSpeedBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1413 -> { DogmaAttributeData.id= 1413; name= "probeCanScanShips"; description= "If this is 1 then the probe can scan for ships, otherwise it can't."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1510 -> { DogmaAttributeData.id= 1510; name= "subsystemBonusCaldariOffensive2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 152 -> { DogmaAttributeData.id= 152; name= "maxPassengersBonus"; description= "+/- a number to the max passengers."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1607 -> { DogmaAttributeData.id= 1607; name= "distributionID_angel"; description= "Obsolete attribute"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 1704 -> { DogmaAttributeData.id= 1704; name= "distributionIDAngel10"; description= "Distribution ID for sov upgrades in Angel space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1995 -> { DogmaAttributeData.id= 1995; name= "modeGravimetricStrengthPostDiv"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2092 -> { DogmaAttributeData.id= 2092; name= "eliteBonusLogiFrig1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2189 -> { DogmaAttributeData.id= 2189; name= "fighterAbilityAntiFighterMissileResistance"; description= ""; published= false; unitId= Some(108); defaultValue= 0.200000; stackable= true; highIsGood= false } |> Some
      | 2286 -> { DogmaAttributeData.id= 2286; name= "shipBonusDreadnoughtC1"; description= "Multiplied by Caldari Dreadnought skill level"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2383 -> { DogmaAttributeData.id= 2383; name= "shipBonusSupercarrierC4"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2480 -> { DogmaAttributeData.id= 2480; name= "canFitShipGroup15"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 249 -> { DogmaAttributeData.id= 249; name= "entityLootValueMax"; description= "The maximum value of any loot dropped by this entity.  Thats for each unit of any given item of loot, not for the total value of all items of loot dropped."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2577 -> { DogmaAttributeData.id= 2577; name= "shipBonusICS5"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2674 -> { DogmaAttributeData.id= 2674; name= "behaviorMiningDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2771 -> { DogmaAttributeData.id= 2771; name= "explosiveDamageResonanceMax"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 443 -> { DogmaAttributeData.id= 443; name= "tradePremium"; description= "price bonus when selling to npc corps  "; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 55 -> { DogmaAttributeData.id= 55; name= "rechargeRate"; description= "Amount of time taken to fully recharge the capacitor."; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 637 -> { DogmaAttributeData.id= 637; name= "entityShieldBoostAmount"; description= "How much the shield is boosted each duration."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 734 -> { DogmaAttributeData.id= 734; name= "shipBonusCD1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 831 -> { DogmaAttributeData.id= 831; name= "ewTargetJam"; description= "Used for target jam effects to reduce max locked targets of victem to a negative value to ensure the victem looses its targets, use extreme value"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 928 -> { DogmaAttributeData.id= 928; name= "entityTargetJam"; description= "Target Jam multiplier on max locked targets for NPCs"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None