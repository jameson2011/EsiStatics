namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes18=
    let getDogmaAttribute id = 
      match id with 
      | 1085 -> { DogmaAttributeData.id= 1085; name= "hasFuelCargo"; description= "Module consumption mechanic uses fuel cargo. Ships that have this with value of 1 can have fuel cargo. Need fuelCargoCapacity set as well."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1182 -> { DogmaAttributeData.id= 1182; name= "heatAbsorbtionRateHi"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1279 -> { DogmaAttributeData.id= 1279; name= "eliteBonusViolatorsRole3"; description= "eliteBonusViolatorsRole3"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1376 -> { DogmaAttributeData.id= 1376; name= "lowSlotModifier"; description= ""; published= true; unitId= Some(139); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1473 -> { DogmaAttributeData.id= 1473; name= "scanGravimetricStrengthMultiplier"; description= "Grav ECM strength multiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1570 -> { DogmaAttributeData.id= 1570; name= "implantSetLGFederationNavy"; description= ""; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1764 -> { DogmaAttributeData.id= 1764; name= "distributionID10"; description= "Distribution ID for global sov upgrades"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 18 -> { DogmaAttributeData.id= 18; name= "charge"; description= "charge of module"; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1861 -> { DogmaAttributeData.id= 1861; name= "rookieWebAmount"; description= "Increase in Statis Webifier speed reduction"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1958 -> { DogmaAttributeData.id= 1958; name= "dscanImmune"; description= "if set to 1 the ship is immune to directional scan"; published= true; unitId= Some(137); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2055 -> { DogmaAttributeData.id= 2055; name= "fighterCapacity"; description= "This defines the total capacity of fighters allowed in the fighter bay of the ship"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 212 -> { DogmaAttributeData.id= 212; name= "missileDamageMultiplier"; description= "The characters missile use efficiency, scales the damage missiles do."; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= false; highIsGood= true } |> Some
      | 2152 -> { DogmaAttributeData.id= 2152; name= "fighterAbilityMicroWarpDriveSpeedBonus"; description= "Maximum Velocity Bonus"; published= true; unitId= Some(124); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2249 -> { DogmaAttributeData.id= 2249; name= "fighterAbilityECMStrengthRadar"; description= "Radar ECM Jammer Strength"; published= true; unitId= None; defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2346 -> { DogmaAttributeData.id= 2346; name= "siegeLocalLogisticsDurationBonus"; description= "Armor Repairer / Shield Booster Duration Bonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2540 -> { DogmaAttributeData.id= 2540; name= "attributeAmmoManufactureMaterialMultiplier"; description= "Decrease material requirement for manufacturing the following:  Ammunition, Charges, Scripts  "; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2637 -> { DogmaAttributeData.id= 2637; name= "BehaviorSiegeDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2734 -> { DogmaAttributeData.id= 2734; name= "damageMultiplierBonusMax"; description= ""; published= true; unitId= Some(127); defaultValue= 0.500000; stackable= true; highIsGood= true } |> Some
      | 309 -> { DogmaAttributeData.id= 309; name= "maxTargetRangeBonus"; description= "Bonus to Max Targeting Range"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 406 -> { DogmaAttributeData.id= 406; name= "missileFOFVelocityPercent"; description= "Missile FOF velocity percent"; published= false; unitId= None; defaultValue= 100.000000; stackable= true; highIsGood= true } |> Some
      | 503 -> { DogmaAttributeData.id= 503; name= "entityConvoyDroneMax"; description= "Maximum number of convoy drones a convoy can have for proetcion."; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 600 -> { DogmaAttributeData.id= 600; name= "warpSpeedMultiplier"; description= ""; published= true; unitId= Some(104); defaultValue= 3.000000; stackable= false; highIsGood= true } |> Some
      | 697 -> { DogmaAttributeData.id= 697; name= "resourceReinforced4Type"; description= ""; published= true; unitId= Some(116); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 794 -> { DogmaAttributeData.id= 794; name= "probesInGroup"; description= "Number of probes to analyze"; published= false; unitId= None; defaultValue= 3.000000; stackable= true; highIsGood= true } |> Some
      | 891 -> { DogmaAttributeData.id= 891; name= "freighterBonusG1"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 988 -> { DogmaAttributeData.id= 988; name= "hardeningbonus2"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None