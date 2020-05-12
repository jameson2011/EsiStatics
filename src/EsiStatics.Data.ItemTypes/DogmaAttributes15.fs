namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes15=
    let getDogmaAttribute id = 
      match id with 
      | 1082 -> { DogmaAttributeData.id= 1082; name= "cpuPenaltyPercent"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 112 -> { DogmaAttributeData.id= 112; name= "energyDamageAbsorptionFactor"; description= "Percentage of energy damage that is absorbed as available power."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1179 -> { DogmaAttributeData.id= 1179; name= "heatDissipationRateHi"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1276 -> { DogmaAttributeData.id= 1276; name= "nonBrokenModuleRepairCostMultiplier"; description= ""; published= false; unitId= None; defaultValue= 5.000000; stackable= true; highIsGood= true } |> Some
      | 1373 -> { DogmaAttributeData.id= 1373; name= "rangeFactor"; description= "This is the multiplier/divisor for probe range increases and associated values under the revised probing system"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1470 -> { DogmaAttributeData.id= 1470; name= "maxVelocityMultiplier"; description= "Maximum velocity multiplier"; published= false; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 15 -> { DogmaAttributeData.id= 15; name= "powerLoad"; description= "Current load of power core"; published= true; unitId= Some(107); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1567 -> { DogmaAttributeData.id= 1567; name= "scanGravimetricStrengthModifier"; description= "+ / - modifier to a ship gravimetric strength"; published= true; unitId= Some(139); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1664 -> { DogmaAttributeData.id= 1664; name= "entityRemoteECMChanceOfActivation"; description= "Chance that the NPC remote ECM fires"; published= true; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1761 -> { DogmaAttributeData.id= 1761; name= "distributionID07"; description= "Distribution ID for global sov upgrades"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1858 -> { DogmaAttributeData.id= 1858; name= "rookieSETOptimal"; description= "Increase in Small Energy Turret optimal Range"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1955 -> { DogmaAttributeData.id= 1955; name= "industryBlueprintRank"; description= "This is a bookkeeping attribute for blueprints, which will hopefully be deprecated by the end of 2014"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 209 -> { DogmaAttributeData.id= 209; name= "scanLadarStrength"; description= "Ladar strength."; published= true; unitId= Some(120); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2149 -> { DogmaAttributeData.id= 2149; name= "fighterAbilityMissilesRange"; description= "Optimal Range"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2246 -> { DogmaAttributeData.id= 2246; name= "fighterAbilityECMStrengthGravimetric"; description= "Gravimetric ECM Jammer Strength"; published= true; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2343 -> { DogmaAttributeData.id= 2343; name= "disallowTethering"; description= "If this ship attribute is NOT 0 then they will be prevented from activating the structure tethering."; published= true; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2440 -> { DogmaAttributeData.id= 2440; name= "structureRigEwarOptimalBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2537 -> { DogmaAttributeData.id= 2537; name= "warfareBuff4Value"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2634 -> { DogmaAttributeData.id= 2634; name= "behaviorArmorRepairerDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2731 -> { DogmaAttributeData.id= 2731; name= "eliteBonusCovertOps4"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2828 -> { DogmaAttributeData.id= 2828; name= "shipBonusPDread1"; description= "skill bonus for trig dread"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 306 -> { DogmaAttributeData.id= 306; name= "maxVelocityModifier"; description= "Autogenerated skill attribute, mMaxVelocityBonus"; published= true; unitId= Some(109); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 403 -> { DogmaAttributeData.id= 403; name= "rocketDmgPercent"; description= "Rocket Dmg Percent"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 500 -> { DogmaAttributeData.id= 500; name= "shipBonusGB"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 597 -> { DogmaAttributeData.id= 597; name= "eliteBonusEscorts"; description= "bonus for escort class frigates"; published= false; unitId= None; defaultValue= 10.000000; stackable= true; highIsGood= true } |> Some
      | 694 -> { DogmaAttributeData.id= 694; name= "resourceReinforced1Type"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 791 -> { DogmaAttributeData.id= 791; name= "scanAnalyzeCount"; description= "Number of probes needed for an analyzis"; published= true; unitId= None; defaultValue= 3.000000; stackable= true; highIsGood= true } |> Some
      | 888 -> { DogmaAttributeData.id= 888; name= "freighterBonusC1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 985 -> { DogmaAttributeData.id= 985; name= "explosiveDamageResistanceBonus"; description= ""; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | _ -> None