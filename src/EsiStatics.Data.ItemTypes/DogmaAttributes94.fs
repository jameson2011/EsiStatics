﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes94=
    let getDogmaAttribute id = 
      match id with 
      | 1161 -> { DogmaAttributeData.id= 1161; name= "scanFrequencyResult"; description= "Used for the scan frequency probe to give results on scan strength types instead of location. 0 = false, 1 = true"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1258 -> { DogmaAttributeData.id= 1258; name= "eliteBonusBlackOps2"; description= "eliteBonusBlackOps2"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1355 -> { DogmaAttributeData.id= 1355; name= "roleBonusTractorBeamRange"; description= "bonus to range of tractor beams"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1549 -> { DogmaAttributeData.id= 1549; name= "specialFuelBayCapacity"; description= "special fuel bay capacity"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 1646 -> { DogmaAttributeData.id= 1646; name= "specialCommandCenterHoldCapacity"; description= "Capacity of CC-only hold"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1743 -> { DogmaAttributeData.id= 1743; name= "distributionIDSansha09"; description= "Distribution ID for sov upgrades in Sansha space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1840 -> { DogmaAttributeData.id= 1840; name= "energyTransferAmountBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 191 -> { DogmaAttributeData.id= 191; name= "corporationMemberBonus"; description= "+/- modifier to the number of members that a CEO can manage within their corporation."; published= true; unitId= Some(139); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1937 -> { DogmaAttributeData.id= 1937; name= "overloadPainterStrengthBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2034 -> { DogmaAttributeData.id= 2034; name= "shieldDamageLimit"; description= ""; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2131 -> { DogmaAttributeData.id= 2131; name= "fighterAbilityMissilesDamageEM"; description= "EM Damage"; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2228 -> { DogmaAttributeData.id= 2228; name= "fighterAbilityAttackMissileDamageTherm"; description= "Thermal Damage"; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2325 -> { DogmaAttributeData.id= 2325; name= "fighterAbilityKamikazeDamageEM"; description= ""; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2422 -> { DogmaAttributeData.id= 2422; name= "boosterLastInjectionDatetime"; description= "The last allowed injection date.  After this date the booster can no longer be consumed. Formatted YYYY.MM.DD HH:MM:SS"; published= true; unitId= Some(143); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2519 -> { DogmaAttributeData.id= 2519; name= "behaviorEnergyNeutralizerDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2616 -> { DogmaAttributeData.id= 2616; name= "behaviorMicroWarpDriveMassAddition"; description= ""; published= false; unitId= Some(2); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2713 -> { DogmaAttributeData.id= 2713; name= "RefRigTimeBonus"; description= "Time Bonus for refinery rigs"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2810 -> { DogmaAttributeData.id= 2810; name= "TotalHullRepairOnTarget"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 288 -> { DogmaAttributeData.id= 288; name= "shipCPUBonus"; description= "Autogenerated skill attribute, shipCPUBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 3101 -> { DogmaAttributeData.id= 3101; name= "structureRequiresDeedType"; description= "Describes which type of deed fits in this structure"; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 385 -> { DogmaAttributeData.id= 385; name= "manufacturingTimeResearchSpeed"; description= "Research speed "; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 482 -> { DogmaAttributeData.id= 482; name= "capacitorCapacity"; description= "Capacitor capacity"; published= true; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 579 -> { DogmaAttributeData.id= 579; name= "testForEggert"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 676 -> { DogmaAttributeData.id= 676; name= "unanchoringDelay"; description= "How long it takes to unanchor this object."; published= true; unitId= Some(101); defaultValue= 60000.000000; stackable= true; highIsGood= true } |> Some
      | 773 -> { DogmaAttributeData.id= 773; name= "shipBonusORE1"; description= "ORE mining barge bonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 870 -> { DogmaAttributeData.id= 870; name= "jumpDriveRangeBonus"; description= "Jump range bonus for jump drive operation."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 967 -> { DogmaAttributeData.id= 967; name= "passiveExplosiveDamageResonanceMultiplier"; description= ""; published= false; unitId= Some(111); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | _ -> None