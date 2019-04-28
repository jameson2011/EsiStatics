namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes66=
    let getDogmaAttribute id = 
      match id with 
      | 1133 -> { DogmaAttributeData.id= 1133; name= "entityMaxVelocitySignatureRadiusMultiplier"; description= "Used to increase signature radius of entity when it activates Max Velocity. Used to fake MWD sig radius increase."; published= false; unitId= None; defaultValue= 6.000000; stackable= true; highIsGood= true } |> Some
      | 1230 -> { DogmaAttributeData.id= 1230; name= "overloadArmorDamageAmount"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1327 -> { DogmaAttributeData.id= 1327; name= "warpScrambleRangeBonus"; description= "Warp Scramble Range Bonus"; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1424 -> { DogmaAttributeData.id= 1424; name= "passiveShieldKineticDamageResonance"; description= ""; published= true; unitId= Some(108); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 1521 -> { DogmaAttributeData.id= 1521; name= "subsystemBonusGallenteOffensive2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 163 -> { DogmaAttributeData.id= 163; name= "dummyDuration"; description= "Where you want an effect to finish instantly."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1715 -> { DogmaAttributeData.id= 1715; name= "distributionIDGurista01"; description= "Distribution ID for sov upgrades in Guristas space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1812 -> { DogmaAttributeData.id= 1812; name= "turretDamageScalingRadius"; description= "Turret damage is reduced when shooting at targets with a sig radius below this value."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1909 -> { DogmaAttributeData.id= 1909; name= "virusCoherence"; description= "The coherence of a virus."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2006 -> { DogmaAttributeData.id= 2006; name= "shipBonusTacticalDestroyerMinmatar3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2103 -> { DogmaAttributeData.id= 2103; name= "canFitShipType6"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2394 -> { DogmaAttributeData.id= 2394; name= "shipBonusSupercarrierM5"; description= "Multiplied by Minmatar Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2491 -> { DogmaAttributeData.id= 2491; name= "behaviorRemoteArmorRepairDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2588 -> { DogmaAttributeData.id= 2588; name= "industrialCoreBonusCommandBurstRange"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 260 -> { DogmaAttributeData.id= 260; name= "attackRange"; description= "The range in m when the entity starts attacking it's target."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2685 -> { DogmaAttributeData.id= 2685; name= "subsystemBonusGallenteCore3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2782 -> { DogmaAttributeData.id= 2782; name= "attributeResearchCosts"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 454 -> { DogmaAttributeData.id= 454; name= "mutaton"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 551 -> { DogmaAttributeData.id= 551; name= "rocketVelocityPercent"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 648 -> { DogmaAttributeData.id= 648; name= "shieldTUNEBonus"; description= ""; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 66 -> { DogmaAttributeData.id= 66; name= "durationBonus"; description= "Bonus to duration."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 745 -> { DogmaAttributeData.id= 745; name= "shipBonusCBC2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 842 -> { DogmaAttributeData.id= 842; name= "reactionGroup1"; description= ""; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None