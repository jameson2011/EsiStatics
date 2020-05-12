namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes87=
    let getDogmaAttribute id = 
      match id with 
      | 1154 -> { DogmaAttributeData.id= 1154; name= "upgradeSlotsLeft"; description= "How many rigs can by fitted to this ship."; published= true; unitId= Some(122); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1251 -> { DogmaAttributeData.id= 1251; name= "securityClearance"; description= "Security Clearance Level"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1445 -> { DogmaAttributeData.id= 1445; name= "subsystemBonusCaldariPropulsion"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1639 -> { DogmaAttributeData.id= 1639; name= "exportTax"; description= "Base export tax (ISK per m3 of volume) on commodities exported from a planet via this pin."; published= true; unitId= Some(133); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 1736 -> { DogmaAttributeData.id= 1736; name= "distributionIDSansha02"; description= "Distribution ID for sov upgrades in Sansha space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1833 -> { DogmaAttributeData.id= 1833; name= "rookieArmorRepBonus"; description= "Bonus to armor repair amount"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 184 -> { DogmaAttributeData.id= 184; name= "requiredSkill3"; description= "The type ID of the skill that is required."; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1930 -> { DogmaAttributeData.id= 1930; name= "siphonWasteAmount"; description= "Amount of stolen materials that is destroyed."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2027 -> { DogmaAttributeData.id= 2027; name= "shipBonusTacticalDestroyerGallente1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2221 -> { DogmaAttributeData.id= 2221; name= "fighterAbilityECMRangeOptimal"; description= "Optimal Range"; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2318 -> { DogmaAttributeData.id= 2318; name= "shipBonusForceAuxiliaryM2"; description= "Multiplied by Minmatar Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2415 -> { DogmaAttributeData.id= 2415; name= "shipBonusTitanG2"; description= "Multiplied by Gallente Titan skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2512 -> { DogmaAttributeData.id= 2512; name= "npcGuidanceDisruptorRange"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2609 -> { DogmaAttributeData.id= 2609; name= "doomsdayEnergyNeutResistanceID"; description= ""; published= false; unitId= Some(119); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2706 -> { DogmaAttributeData.id= 2706; name= "moonAsteroidDecayTimeMultiplier"; description= "Decay time for asteroid created from moon spew"; published= false; unitId= Some(3); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2803 -> { DogmaAttributeData.id= 2803; name= "miningAmountSet"; description= "Sets how much ore gets mined"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 281 -> { DogmaAttributeData.id= 281; name= "explosionDelay"; description= "The amount of milliseconds before the object explodes."; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 378 -> { DogmaAttributeData.id= 378; name= "refiningYieldPercentage"; description= "Refining yield percentage"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 475 -> { DogmaAttributeData.id= 475; name= "entityAttackDelayMin"; description= "Minimum attack delay time for entity."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 669 -> { DogmaAttributeData.id= 669; name= "moduleReactivationDelay"; description= "Amount of time that has to be waited after the deactivation of this module until it can be reactivated."; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 766 -> { DogmaAttributeData.id= 766; name= "controlTowerHybridDamageBonus"; description= ""; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 863 -> { DogmaAttributeData.id= 863; name= "implantSetHalo"; description= ""; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 87 -> { DogmaAttributeData.id= 87; name= "shieldTransferRange"; description= "Maximum range for use of a shield transfer."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 960 -> { DogmaAttributeData.id= 960; name= "caldariNavyBonusMultiplier2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None