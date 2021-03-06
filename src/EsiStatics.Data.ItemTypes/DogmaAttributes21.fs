﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes21=
    let getDogmaAttribute id = 
      match id with 
      | 1088 -> { DogmaAttributeData.id= 1088; name= "expiryTime"; description= "Internally set expiry time for objects which expire, so that the client knows when."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 118 -> { DogmaAttributeData.id= 118; name= "thermalDamage"; description= "Thermal damage done."; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1185 -> { DogmaAttributeData.id= 1185; name= "onliningRequiresSovereigntyLevel"; description= "Whether the structure requires the onliner's alliance to hold sovereignty in the system for it to be onlineable."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1282 -> { DogmaAttributeData.id= 1282; name= "implantSetThukker"; description= "Nomad set bonus attribute"; published= true; unitId= Some(104); defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1379 -> { DogmaAttributeData.id= 1379; name= "maxVelocityAdd"; description= "Maximum velocity of ship"; published= true; unitId= Some(11); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 1476 -> { DogmaAttributeData.id= 1476; name= "scanRadarStrengthMultiplier"; description= "Radar ECM strength multiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1573 -> { DogmaAttributeData.id= 1573; name= "specialAmmoHoldCapacity"; description= "special ammo hold capacity"; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 1670 -> { DogmaAttributeData.id= 1670; name= "shipBonusOreIndustrial2"; description= "Bonus 2 for ORE Industrials"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1864 -> { DogmaAttributeData.id= 1864; name= "rookieDroneMWDspeed"; description= "Increase in Drone MWD speed"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1961 -> { DogmaAttributeData.id= 1961; name= "advancedIndustrySkillIndustryJobTimeBonus"; description= "A bonus to all industry job times for the advanced industry skill"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2058 -> { DogmaAttributeData.id= 2058; name= "clothingAlsoCoversCategory2"; description= "This item of clothing covers multiple areas of the body, so the category of clothes specified by this attribute is no longer mandatory"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 21 -> { DogmaAttributeData.id= 21; name= "warpFactor"; description= "tbd instance param"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2155 -> { DogmaAttributeData.id= 2155; name= "fighterAbilityMicroJumpDriveDuration"; description= "Duration"; published= true; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2252 -> { DogmaAttributeData.id= 2252; name= "fighterAbilityECMResistanceID"; description= ""; published= false; unitId= Some(119); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2349 -> { DogmaAttributeData.id= 2349; name= "fighterAbilityLaunchBombDuration"; description= ""; published= false; unitId= Some(101); defaultValue= 0.000000; stackable= true; highIsGood= false } |> Some
      | 2446 -> { DogmaAttributeData.id= 2446; name= "refiningYieldCalAmarrIce"; description= ""; published= true; unitId= Some(127); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2543 -> { DogmaAttributeData.id= 2543; name= "attributeDroneManufactureTimeMultiplier"; description= "Decrease time requirement for manufacturing the following:  Drones, Fighters"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 2640 -> { DogmaAttributeData.id= 2640; name= "BehaviorSiegeSensorDampenerResistanceModifier"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2737 -> { DogmaAttributeData.id= 2737; name= "fighterStandupLightSlots"; description= "Number of Light Fighters the structure can launch."; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 3028 -> { DogmaAttributeData.id= 3028; name= "hydraDroneTrackingBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 312 -> { DogmaAttributeData.id= 312; name= "durationSkillBonus"; description= "Autogenerated skill attribute, DurationBonus"; published= true; unitId= Some(121); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 409 -> { DogmaAttributeData.id= 409; name= "cruiserConstructionTimeBonus"; description= "Autogenerated skill attribute, cruiserConstructionTimeBonus"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 506 -> { DogmaAttributeData.id= 506; name= "missileLaunchDuration"; description= "Cycle time for a missile launch, in milliseconds."; published= true; unitId= Some(101); defaultValue= 20000.000000; stackable= true; highIsGood= true } |> Some
      | 603 -> { DogmaAttributeData.id= 603; name= "launcherGroup3"; description= "One of the groups of launcher this charge can be loaded into."; published= true; unitId= Some(115); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 700 -> { DogmaAttributeData.id= 700; name= "resourceReinforced2Quantity"; description= ""; published= true; unitId= Some(9); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 797 -> { DogmaAttributeData.id= 797; name= "maximumRangeCap"; description= "The maximum possible target range."; published= false; unitId= Some(1); defaultValue= 300000.000000; stackable= true; highIsGood= true } |> Some
      | 894 -> { DogmaAttributeData.id= 894; name= "speedBoostBonus"; description= "Testing for fuels for speed boosters."; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 991 -> { DogmaAttributeData.id= 991; name= "activeExplosiveResistanceBonus"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | _ -> None