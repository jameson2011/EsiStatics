namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes56=
    let getDogmaAttribute id = 
      match id with 
      | 1026 -> { DogmaAttributeData.id= 1026; name= "warpAccuracyMaxRangePercentage"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1123 -> { DogmaAttributeData.id= 1123; name= "scanDuration"; description= "How long this probe has to scan until it can obtain results."; published= true; unitId= Some(101); defaultValue= 60000.000000; stackable= true; highIsGood= true } |> Some
      | 1220 -> { DogmaAttributeData.id= 1220; name= "droneShieldBonusBonus"; description= "Bonus to drone shield transport amount"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1317 -> { DogmaAttributeData.id= 1317; name= "maxRangeHidden"; description= "maxRangeHidden"; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1414 -> { DogmaAttributeData.id= 1414; name= "AI_ShouldUseEvasiveManeuver"; description= "The evasive maneuver level of the type. this will control what types of evasive maneuvers a NPC ship will use."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1511 -> { DogmaAttributeData.id= 1511; name= "subsystemBonusAmarrOffensive2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 153 -> { DogmaAttributeData.id= 153; name= "warpCapacitorNeed"; description= "The power cost to warp per one kg per AU (floats do not have the resolution for meters)."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1608 -> { DogmaAttributeData.id= 1608; name= "distributionID_guristas"; description= "Obsolete attribute"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1705 -> { DogmaAttributeData.id= 1705; name= "distributionIDBlood01"; description= "Distribution ID for sov upgrades in Blood Raider space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1996 -> { DogmaAttributeData.id= 1996; name= "modeMagnetometricStrengthPostDiv"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2093 -> { DogmaAttributeData.id= 2093; name= "eliteBonusLogiFrig2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2287 -> { DogmaAttributeData.id= 2287; name= "shipBonusDreadnoughtC2"; description= "Multiplied by Caldari Dreadnought skill level"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2384 -> { DogmaAttributeData.id= 2384; name= "shipBonusSupercarrierC5"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2481 -> { DogmaAttributeData.id= 2481; name= "canFitShipGroup16"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 250 -> { DogmaAttributeData.id= 250; name= "entityLootCountMin"; description= "Deprecated. The minimum number of pieces of loot dropped by this entity."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2578 -> { DogmaAttributeData.id= 2578; name= "roleBonusDroneMiningYield"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2675 -> { DogmaAttributeData.id= 2675; name= "specialSubsystemHoldCapacity"; description= "special subsystem hold capacity"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2772 -> { DogmaAttributeData.id= 2772; name= "conversionRigHPCapBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 444 -> { DogmaAttributeData.id= 444; name= "contrabandFencingChance"; description= "Chance of being caught selling contraband on market. "; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 56 -> { DogmaAttributeData.id= 56; name= "chargeRate"; description= "Number of charges consumed per activation"; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 638 -> { DogmaAttributeData.id= 638; name= "entityArmorRepairDelayChance"; description= "Chance that an entity will delay employing armor repair."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 735 -> { DogmaAttributeData.id= 735; name= "shipBonusCD2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 832 -> { DogmaAttributeData.id= 832; name= "scanSkillTargetPaintStrengthBonus"; description= "Skill attribute for increasing effectiveness on Target Painters"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 929 -> { DogmaAttributeData.id= 929; name= "ECMDuration"; description= "Duration of NPC effect"; published= true; unitId= Some(101); defaultValue= 30000.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None