namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes75=
    let getDogmaAttribute id = 
      match id with 
      | 1045 -> { DogmaAttributeData.id= 1045; name= "maxTractorVelocity"; description= "The maximum speed that the tractor beam draws objects closer at."; published= true; unitId= Some(10); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1142 -> { DogmaAttributeData.id= 1142; name= "boosterArmorRepairAmountPenalty"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1239 -> { DogmaAttributeData.id= 1239; name= "shipBonusORECapital1"; description= "shipBonusORECapital1"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1336 -> { DogmaAttributeData.id= 1336; name= "jumpClonesLeft"; description= "The remaining number of unused clone vats on the ship that are available for installation of jump clones."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1433 -> { DogmaAttributeData.id= 1433; name= "subsystemBonusAmarrDefensive"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1530 -> { DogmaAttributeData.id= 1530; name= "hullMaxDamageResonanceOld"; description= "This was created by accident and should be ignored"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 172 -> { DogmaAttributeData.id= 172; name= "customPerceptionBonus"; description= "Bonus to the perception of a character specified by the player in character creation."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1724 -> { DogmaAttributeData.id= 1724; name= "distributionIDGurista10"; description= "Distribution ID for sov upgrades in Guristas space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1821 -> { DogmaAttributeData.id= 1821; name= "skillAllyCostModifierBonus"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1918 -> { DogmaAttributeData.id= 1918; name= "virusStrengthBonus"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2015 -> { DogmaAttributeData.id= 2015; name= "shipBonusTacticalDestroyerCaldari1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2112 -> { DogmaAttributeData.id= 2112; name= "sensorDampenerResistance"; description= "Resistance against Remote Sensor Dampeners."; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2209 -> { DogmaAttributeData.id= 2209; name= "fighterAbilityEnergyNeutralizerOptimalRange"; description= "Optimal Range"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2306 -> { DogmaAttributeData.id= 2306; name= "siegeMissileDamageBonus"; description= "Missile Damage Bonus Percentage"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2403 -> { DogmaAttributeData.id= 2403; name= "explosiveDamageResistanceBonusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2500 -> { DogmaAttributeData.id= 2500; name= "behaviorWebifierRange"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2597 -> { DogmaAttributeData.id= 2597; name= "warfareBuff2Multiplier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 269 -> { DogmaAttributeData.id= 269; name= "armorKineticDamageResonance"; description= "Multiplies KINETIC damage taken by Armor. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | 2694 -> { DogmaAttributeData.id= 2694; name= "remoteArmorRepairerFalloffBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2791 -> { DogmaAttributeData.id= 2791; name= "cannotBeUnfit"; description= ""; published= true; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 366 -> { DogmaAttributeData.id= 366; name= "caldariTechTimePercent"; description= "Production time multiplier when manufacturing caldari tech   "; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 463 -> { DogmaAttributeData.id= 463; name= "shipBonusCF"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 560 -> { DogmaAttributeData.id= 560; name= "cloakingTargetingDelay"; description= "The time targeting systems take to recalibrate after cloaking."; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 657 -> { DogmaAttributeData.id= 657; name= "shipBonusCC2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 75 -> { DogmaAttributeData.id= 75; name= "hpToCapacity"; description= "DO NOT MESS WITH. How many hp are in one capacity unit"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 754 -> { DogmaAttributeData.id= 754; name= "controlTowerProjectileROFBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 851 -> { DogmaAttributeData.id= 851; name= "shieldBoostCapacitorBonus"; description= "Bonus to capacitor need for shield boosters."; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 948 -> { DogmaAttributeData.id= 948; name= "entityTrackingDisruptMultiplier"; description= "Multiplier on tracking speed and optimal range of player turrets done by NPC"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None