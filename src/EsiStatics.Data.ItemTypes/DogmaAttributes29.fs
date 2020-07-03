namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes29=
    let getDogmaAttribute id = 
      match id with 
      | 1096 -> { DogmaAttributeData.id= 1096; name= "displayShieldCapacityBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1193 -> { DogmaAttributeData.id= 1193; name= "projECMDurationBonus"; description= "Bonus to duration of modules requiring projected ECM."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 126 -> { DogmaAttributeData.id= 126; name= "cargoScanRange"; description= "Maximum range the cargo of a ship can be scanned from."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1290 -> { DogmaAttributeData.id= 1290; name= "requiredSkill6"; description= "The type ID of the skill that is required."; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1387 -> { DogmaAttributeData.id= 1387; name= "wormholeTargetRegion2"; description= "Specific target region 2 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1484 -> { DogmaAttributeData.id= 1484; name= "maxDroneVelocityMultiplier"; description= "Maximum drone velocity multiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1581 -> { DogmaAttributeData.id= 1581; name= "eliteBonusAssaultShips1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1678 -> { DogmaAttributeData.id= 1678; name= "entityGroupSpeedActivationChance"; description= "Activation chance for NPCGroupSpeedAssist effect."; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1775 -> { DogmaAttributeData.id= 1775; name= "consumptionQuantityBonusPercent"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1872 -> { DogmaAttributeData.id= 1872; name= "canFitShipGroup05"; description= "Can be fitted to"; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1969 -> { DogmaAttributeData.id= 1969; name= "stasisWebStrengthMultiplier"; description= ""; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2066 -> { DogmaAttributeData.id= 2066; name= "mjdJumpRange"; description= "distance jumped on mjd activation"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 223 -> { DogmaAttributeData.id= 223; name= "charismaSkillTrainingTimeMultiplier"; description= "Scales the time it takes to train skills with Charisma as the primary attribute."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2260 -> { DogmaAttributeData.id= 2260; name= "doomsdayEnergyNeutAmount"; description= ""; published= true; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2357 -> { DogmaAttributeData.id= 2357; name= "nullSecModifier"; description= ""; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2454 -> { DogmaAttributeData.id= 2454; name= "disallowCloaking"; description= "if this ship attribute is NOT 0 then they will be prevented from cloaking"; published= true; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2551 -> { DogmaAttributeData.id= 2551; name= "attributeAdvSmallShipManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  T2 Frigates, T2 Destroyers, T3 Destroyers        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2648 -> { DogmaAttributeData.id= 2648; name= "BehaviorSiegeLocalLogisticsDurationModifier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2745 -> { DogmaAttributeData.id= 2745; name= "durationTargetWarpableBeacon"; description= ""; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 29 -> { DogmaAttributeData.id= 29; name= "warpInhibitor"; description= "tbd"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 3036 -> { DogmaAttributeData.id= 3036; name= "VortonArcRange"; description= "The maximum distance from the original target from which additional targets can receive arc damage"; published= true; unitId= Some(1); defaultValue= 1.000000; stackable= false; highIsGood= true } |> Some
      | 320 -> { DogmaAttributeData.id= 320; name= "powerUseBonus"; description= "Autogenerated skill attribute, powerUseBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 417 -> { DogmaAttributeData.id= 417; name= "maxNonRaceCorporationMembers"; description= "Max non  race corporationMembers"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 514 -> { DogmaAttributeData.id= 514; name= "modifyTargetSpeedRange"; description= "Range of entities Stasis Web"; published= false; unitId= Some(1); defaultValue= 20000.000000; stackable= true; highIsGood= true } |> Some
      | 611 -> { DogmaAttributeData.id= 611; name= "durationMultiplier"; description= ""; published= true; unitId= Some(111); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 708 -> { DogmaAttributeData.id= 708; name= "resourceOnline4Type"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 805 -> { DogmaAttributeData.id= 805; name= "quantity"; description= "Quantity contained."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 902 -> { DogmaAttributeData.id= 902; name= "accessDifficultyBonus"; description= "Bonus to chance of opening a container."; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 999 -> { DogmaAttributeData.id= 999; name= "eliteBonusCommandShips2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None