namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes46=
    let getDogmaAttribute id = 
      match id with 
      | 1016 -> { DogmaAttributeData.id= 1016; name= "entityShieldBoostDelayChanceMediumMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1113 -> { DogmaAttributeData.id= 1113; name= "inventionMEModifier"; description= "Modifies the mineral efficiency of invented BPCs"; published= false; unitId= Some(120); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1210 -> { DogmaAttributeData.id= 1210; name= "overloadDamageModifier"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1307 -> { DogmaAttributeData.id= 1307; name= "trackingSpeedMultiplierBonusAdditive"; description= "Additive bonus to trackingSpeedMultiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1404 -> { DogmaAttributeData.id= 1404; name= "wormholeTargetSystem1"; description= "Specific target system 1 for wormholes"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 143 -> { DogmaAttributeData.id= 143; name= "targetHostileRange"; description= "Range of the automated targeting systems hostile targeting area."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1501 -> { DogmaAttributeData.id= 1501; name= "npcRemoteArmorRepairMaxTargets"; description= "The maximum number of targets that can be repaired at once."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1598 -> { DogmaAttributeData.id= 1598; name= "sovUpgradeBlockingUpgradeID"; description= "The typeID of the upgrade that prevents this type from being installed."; published= false; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1695 -> { DogmaAttributeData.id= 1695; name= "distributionIDAngel01"; description= "Distribution ID for sov upgrades in Angel space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1792 -> { DogmaAttributeData.id= 1792; name= "shipBonusBC3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1889 -> { DogmaAttributeData.id= 1889; name= "shipBonusABC2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1986 -> { DogmaAttributeData.id= 1986; name= "shipBonusTacticalDestroyerAmarr1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2083 -> { DogmaAttributeData.id= 2083; name= "shieldEmDamageResonancePostAssignment"; description= "Sets Em damage taken by Shields. "; published= true; unitId= Some(108); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 2180 -> { DogmaAttributeData.id= 2180; name= "fighterAbilityAttackTurretTrackingSpeed"; description= "Tracking Speed / Accuracy"; published= true; unitId= Some(112); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2277 -> { DogmaAttributeData.id= 2277; name= "structureRigDoomsdayTargetAmountBonus"; description= "Bonus to Arcving Vorton Projector"; published= true; unitId= Some(138); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2374 -> { DogmaAttributeData.id= 2374; name= "shipBonusCarrierM4"; description= "Multiplied by Minmatar Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 240 -> { DogmaAttributeData.id= 240; name= "scanMagnetometricStrengthBonus"; description= "+/- modifier to the magnetometric strength of an electronic system."; published= true; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2471 -> { DogmaAttributeData.id= 2471; name= "warfareBuff2Value"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2568 -> { DogmaAttributeData.id= 2568; name= "attributeTEResearchTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  Time Efficiency Blueprint Research        "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2665 -> { DogmaAttributeData.id= 2665; name= "subsystemEnergyNeutFittingReduction"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2762 -> { DogmaAttributeData.id= 2762; name= "shipBonusPF1"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 337 -> { DogmaAttributeData.id= 337; name= "shieldCapacityBonus"; description= "Autogenerated skill attribute, shieldCapacityBonus"; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 434 -> { DogmaAttributeData.id= 434; name= "miningAmountBonus"; description= "Autogenerated skill attribute, miningAmountBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 531 -> { DogmaAttributeData.id= 531; name= "reqResearchTool"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 628 -> { DogmaAttributeData.id= 628; name= "bountySkillMultiplyer"; description= "Autogenerated skill attribute, bountySkillMultiplyer"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 725 -> { DogmaAttributeData.id= 725; name= "contrabandScanChance"; description= "The chance that a passer by will be chosen as a target of a scan for contraband."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 919 -> { DogmaAttributeData.id= 919; name= "republicFleetBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None