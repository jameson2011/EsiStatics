namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes90=
    let getDogmaAttribute id = 
      match id with 
      | 1157 -> { DogmaAttributeData.id= 1157; name= "commandBonus2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1254 -> { DogmaAttributeData.id= 1254; name= "canNotUseStargates"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1351 -> { DogmaAttributeData.id= 1351; name= "posCargobayAcceptType"; description= "cargo typeID allowed in structures"; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1448 -> { DogmaAttributeData.id= 1448; name= "subsystemBonusMinmatarDefensive"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1642 -> { DogmaAttributeData.id= 1642; name= "pinExtractionQuantity"; description= "Base amount (in units) of commodities extracted by an extractor pin."; published= true; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 1739 -> { DogmaAttributeData.id= 1739; name= "distributionIDSansha05"; description= "Distribution ID for sov upgrades in Sansha space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1836 -> { DogmaAttributeData.id= 1836; name= "rookieSPTDamageBonus"; description= "Bonus to Small Projectile Turret damage"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 187 -> { DogmaAttributeData.id= 187; name= "repairCostMultiplier"; description= "Multiplier to adjust the cost of repairs."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1933 -> { DogmaAttributeData.id= 1933; name= "siphonPolyMaterial"; description= "Amount of Polymer Materials stolen from active Polymer Reactor Array every cycle. "; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2030 -> { DogmaAttributeData.id= 2030; name= "modeArmorRepDurationPostDiv"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2127 -> { DogmaAttributeData.id= 2127; name= "fighterAbilityMissilesDamageReductionFactor"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2224 -> { DogmaAttributeData.id= 2224; name= "fighterAbilityEvasiveManeuversSpeedBonus"; description= "Maximum Velocity Bonus"; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2321 -> { DogmaAttributeData.id= 2321; name= "shipBonusForceAuxiliaryC4"; description= "Multiplied by Caldari Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2418 -> { DogmaAttributeData.id= 2418; name= "shipBonusTitanM1"; description= "Multiplied by Minmatar Titan skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2515 -> { DogmaAttributeData.id= 2515; name= "npcTrackingDisruptorDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2612 -> { DogmaAttributeData.id= 2612; name= "AI_TankingModifierFighter"; description= "Tanking modifier applied to fighters if their owner is tanking. 1.0 is no modifier"; published= false; unitId= None; defaultValue= 1.300000; stackable= true; highIsGood= true } |> Some
      | 2709 -> { DogmaAttributeData.id= 2709; name= "moonRigSpewRadiusBonus"; description= "Rig Bonus that affects spew asteroid belt radius from moon extraction"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2806 -> { DogmaAttributeData.id= 2806; name= "NonDiminishingSkillInjectorUses"; description= "Attribute defining usage count for penaltyless skill injections"; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 284 -> { DogmaAttributeData.id= 284; name= "excludeGangMembers"; description= "Indicates whether the modules ranged effects exlude  members of the users gang."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 3097 -> { DogmaAttributeData.id= 3097; name= "lightYearDistanceMax"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 478 -> { DogmaAttributeData.id= 478; name= "shipBonusAC"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 575 -> { DogmaAttributeData.id= 575; name= "eliteBonusBattlecruiser"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 672 -> { DogmaAttributeData.id= 672; name= "entityCruiseSpeedMultiplier"; description= ""; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 769 -> { DogmaAttributeData.id= 769; name= "maxRangeBonus2"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 866 -> { DogmaAttributeData.id= 866; name= "jumpDriveConsumptionType"; description= "Type that is used for consumption from cargo hold when activating jump drive operation."; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 90 -> { DogmaAttributeData.id= 90; name= "powerTransferAmount"; description= "Amount of power to transfer."; published= true; unitId= Some(120); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 963 -> { DogmaAttributeData.id= 963; name= "eliteBonusReconShip2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None