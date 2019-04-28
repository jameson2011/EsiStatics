namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes47=
    let getDogmaAttribute id = 
      match id with 
      | 1017 -> { DogmaAttributeData.id= 1017; name= "entityShieldBoostDelayChanceLargeMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1114 -> { DogmaAttributeData.id= 1114; name= "inventionTEModifier"; description= "Modifies the time efficiency of invented BPCs"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1211 -> { DogmaAttributeData.id= 1211; name= "heatDamage"; description= ""; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 1308 -> { DogmaAttributeData.id= 1308; name= "maxTargetRangeMultiplierBonusAdditive"; description= "Additive bonus to maxTargetRangeMultiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1405 -> { DogmaAttributeData.id= 1405; name= "wormholeTargetSystem2"; description= "Specific target system 2 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 144 -> { DogmaAttributeData.id= 144; name= "capacitorRechargeRateMultiplier"; description= "Multiplier to the capacitors recharge rate."; published= true; unitId= Some(111); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 1502 -> { DogmaAttributeData.id= 1502; name= "npcRemoteShieldBoostMaxTargets"; description= "The maximum number of targets that can be shield boosted at once"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1599 -> { DogmaAttributeData.id= 1599; name= "sovUpgradeRequiredUpgradeID"; description= "The typeID of the upgrade that is required for this upgrade to be installed. "; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1696 -> { DogmaAttributeData.id= 1696; name= "distributionIDAngel02"; description= "Distribution ID for sov upgrades in Angel space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1793 -> { DogmaAttributeData.id= 1793; name= "shipBonusBC4"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1890 -> { DogmaAttributeData.id= 1890; name= "nondestructible"; description= "This will make the item non-destructible upon podding.  ONLY FOR IMPLANTS AND BOOSTERS"; published= false; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1987 -> { DogmaAttributeData.id= 1987; name= "shipBonusTacticalDestroyerAmarr2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2084 -> { DogmaAttributeData.id= 2084; name= "shieldExplosiveDamageResonancePostAssignment"; description= "Sets Explosive damage taken by shields. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2278 -> { DogmaAttributeData.id= 2278; name= "structureRigDoomsdayDamageLossTargetBonus"; description= "Reduction in damage lost per target on the Arcing Vorton Projector"; published= true; unitId= Some(127); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2375 -> { DogmaAttributeData.id= 2375; name= "shipBonusSupercarrierA1"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 241 -> { DogmaAttributeData.id= 241; name= "scanRadarStrengthBonus"; description= "+/- modifier to the radar strength of an electronic system."; published= true; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2472 -> { DogmaAttributeData.id= 2472; name= "warfareBuff3ID"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2569 -> { DogmaAttributeData.id= 2569; name= "attributeBPCopyCostMultiplier"; description= "Decrease cost requirement for manufacturing the following:  Blueprint Copying        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2666 -> { DogmaAttributeData.id= 2666; name= "subsystemMHTFittingReduction"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2763 -> { DogmaAttributeData.id= 2763; name= "shipBonusPF2"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 338 -> { DogmaAttributeData.id= 338; name= "rechargeratebonus"; description= "Autogenerated skill attribute, rechargeratebonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 435 -> { DogmaAttributeData.id= 435; name= "maxGangModules"; description= ""; published= true; unitId= Some(139); defaultValue= 3.000000; stackable= true; highIsGood= true } |> Some
      | 47 -> { DogmaAttributeData.id= 47; name= "slots"; description= "The number of slots this module requires.  Only used for launchers, bays and turrets."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 532 -> { DogmaAttributeData.id= 532; name= "reqResearchComponent"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 629 -> { DogmaAttributeData.id= 629; name= "cargoGroup"; description= "The cargo group that can be loaded into this container"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 726 -> { DogmaAttributeData.id= 726; name= "moonMiningAmount"; description= ""; published= true; unitId= Some(9); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 823 -> { DogmaAttributeData.id= 823; name= "hitsMissilesOnly"; description= "Effect for smartbombs, used to hit missiles only."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None