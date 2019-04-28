namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes89=
    let getDogmaAttribute id = 
      match id with 
      | 1156 -> { DogmaAttributeData.id= 1156; name= "maxScanDeviationModifier"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1253 -> { DogmaAttributeData.id= 1253; name= "jumpHarmonics"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1350 -> { DogmaAttributeData.id= 1350; name= "activationBlockedStrenght"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1447 -> { DogmaAttributeData.id= 1447; name= "subsystemBonusMinmatarElectronic"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1544 -> { DogmaAttributeData.id= 1544; name= "maxGroupFitted"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1641 -> { DogmaAttributeData.id= 1641; name= "exportTaxMultiplier"; description= "Export tax multiplier when exporting this commodity off a planet."; published= false; unitId= Some(121); defaultValue= 1.000000; stackable= true; highIsGood= false } |> Some
      | 1738 -> { DogmaAttributeData.id= 1738; name= "distributionIDSansha04"; description= "Distribution ID for sov upgrades in Sansha space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1835 -> { DogmaAttributeData.id= 1835; name= "rookieShipVelocityBonus"; description= "Bonus to ship velocity"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 186 -> { DogmaAttributeData.id= 186; name= "warpCapacitorNeedMultiplier"; description= "Multiplier to the warping power cost."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1932 -> { DogmaAttributeData.id= 1932; name= "implantSetWarpSpeed"; description= ""; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2029 -> { DogmaAttributeData.id= 2029; name= "shipBonusTacticalDestroyerGallente3"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2126 -> { DogmaAttributeData.id= 2126; name= "fighterAbilityMissilesExplosionVelocity"; description= "Explosion Velocity"; published= true; unitId= Some(10); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2223 -> { DogmaAttributeData.id= 2223; name= "fighterSquadronOrbitRange"; description= ""; published= true; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2320 -> { DogmaAttributeData.id= 2320; name= "shipBonusForceAuxiliaryA4"; description= "Multiplied by Amarr Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2417 -> { DogmaAttributeData.id= 2417; name= "shipBonusTitanG4"; description= "Multiplied by Gallente Titan skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2514 -> { DogmaAttributeData.id= 2514; name= "npcGuidanceDisruptorDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2708 -> { DogmaAttributeData.id= 2708; name= "moonRigAsteroidDecayBonus"; description= "Moon rig bonus that delays spew asteroid decay"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2805 -> { DogmaAttributeData.id= 2805; name= "structurePowerStateArmorPlatingMultiplier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 283 -> { DogmaAttributeData.id= 283; name= "droneCapacity"; description= "This defines the total capacity of drones allowed in the drone bay of the ship"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 380 -> { DogmaAttributeData.id= 380; name= "maxActiveFactory"; description= "Max active factories that a player can operate "; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 865 -> { DogmaAttributeData.id= 865; name= "planetAnchorDistance"; description= "How many meters from the standard warp-in distance a planet can be anchored from."; published= false; unitId= Some(1); defaultValue= 100000.000000; stackable= true; highIsGood= true } |> Some
      | 89 -> { DogmaAttributeData.id= 89; name= "shieldDrainRange"; description= "Maximum range shield can be drained at."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 962 -> { DogmaAttributeData.id= 962; name= "eliteBonusReconShip1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None