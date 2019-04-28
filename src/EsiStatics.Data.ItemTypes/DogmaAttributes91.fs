namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes91=
    let getDogmaAttribute id = 
      match id with 
      | 1158 -> { DogmaAttributeData.id= 1158; name= "untargetable"; description= "Attribute to disallow targetting."; published= false; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1255 -> { DogmaAttributeData.id= 1255; name= "droneDamageBonus"; description= "droneDamageBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 1352 -> { DogmaAttributeData.id= 1352; name= "posCargobayAcceptGroup"; description= "cargo bay container group ID"; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1449 -> { DogmaAttributeData.id= 1449; name= "subsystemBonusMinmatarOffensive"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1643 -> { DogmaAttributeData.id= 1643; name= "pinCycleTime"; description= "Base cycle time (in seconds) of an extractor pin."; published= true; unitId= Some(3); defaultValue= 300.000000; stackable= true; highIsGood= true } |> Some
      | 1740 -> { DogmaAttributeData.id= 1740; name= "distributionIDSansha06"; description= "Distribution ID for sov upgrades in Sansha space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1837 -> { DogmaAttributeData.id= 1837; name= "rookieShieldBoostBonus"; description= "Bonus to shield booster repair amount"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 188 -> { DogmaAttributeData.id= 188; name= "cargoScanResistance"; description= "Chance of being able to resist a cargo scan."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1934 -> { DogmaAttributeData.id= 1934; name= "deactivateIfOffensive"; description= "If module is offensive should it deactivate on disconnect. Default to 1"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2031 -> { DogmaAttributeData.id= 2031; name= "modeMWDVelocityPostDiv"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2128 -> { DogmaAttributeData.id= 2128; name= "fighterAbilityMissilesDamageReductionSensitivity"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2225 -> { DogmaAttributeData.id= 2225; name= "fighterAbilityEvasiveManeuversSignatureRadiusBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2322 -> { DogmaAttributeData.id= 2322; name= "shipBonusForceAuxiliaryG4"; description= "Multiplied by Gallente Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2419 -> { DogmaAttributeData.id= 2419; name= "shipBonusTitanM2"; description= "Multiplied by Minmatar Titan skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2516 -> { DogmaAttributeData.id= 2516; name= "npcTrackingDisruptorRange"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2613 -> { DogmaAttributeData.id= 2613; name= "chargeRateMultiplier"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2710 -> { DogmaAttributeData.id= 2710; name= "moonRigSpewVolumeBonus"; description= "Moon rig bonus that increases volume of moon spew in relation to extraction time"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2807 -> { DogmaAttributeData.id= 2807; name= "reactivationDelayBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 285 -> { DogmaAttributeData.id= 285; name= "excludeCorporationMembers"; description= "Indicates whether the modules ranged effects exlude  members of the users corporation."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 479 -> { DogmaAttributeData.id= 479; name= "shieldRechargeRate"; description= "Amount of time taken to fully recharge the shield."; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 673 -> { DogmaAttributeData.id= 673; name= "eliteBonusGunship1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 770 -> { DogmaAttributeData.id= 770; name= "controlTowerEwTargetSwitchDelayBonus"; description= "Bonus attribute to entity Target Switch Delay"; published= false; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 867 -> { DogmaAttributeData.id= 867; name= "jumpDriveRange"; description= "Range in light years the ship can maximum jump to."; published= true; unitId= Some(126); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 91 -> { DogmaAttributeData.id= 91; name= "powerTransferRange"; description= "Maximum range to transfer power from."; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 964 -> { DogmaAttributeData.id= 964; name= "passiveEmDamageResonanceMultiplier"; description= ""; published= false; unitId= Some(111); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | _ -> None