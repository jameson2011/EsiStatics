namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal DogmaAttributes92=
    let getDogmaAttribute id = 
      match id with 
      | 1159 -> { DogmaAttributeData.id= 1159; name= "armorHPBonusAdd"; description= ""; published= true; unitId= Some(113); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1256 -> { DogmaAttributeData.id= 1256; name= "droneHPBonus"; description= "droneHPBonus"; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1353 -> { DogmaAttributeData.id= 1353; name= "aoeDamageReductionFactor"; description= "Missile Damage Modifier. Smaller is better (Don't use less than 0.5)"; published= false; unitId= None; defaultValue= 1.000000; stackable= true; highIsGood= true } |> Some
      | 1450 -> { DogmaAttributeData.id= 1450; name= "subsystemBonusMinmatarPropulsion"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1547 -> { DogmaAttributeData.id= 1547; name= "rigSize"; description= ""; published= true; unitId= Some(117); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1644 -> { DogmaAttributeData.id= 1644; name= "extractorDepletionRange"; description= "This is the radius that the depletion at this pin effects"; published= false; unitId= Some(1); defaultValue= 10.000000; stackable= true; highIsGood= true } |> Some
      | 1741 -> { DogmaAttributeData.id= 1741; name= "distributionIDSansha07"; description= "Distribution ID for sov upgrades in Sansha space"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1838 -> { DogmaAttributeData.id= 1838; name= "miniProfessionRangeBonus"; description= "Bonus to optimal range of Codebreakers and Analyzers"; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 189 -> { DogmaAttributeData.id= 189; name= "targetGroup"; description= "Restrict activation to this one module group."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 1935 -> { DogmaAttributeData.id= 1935; name= "overloadTrackingModuleStrengthBonus"; description= ""; published= true; unitId= Some(105); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2032 -> { DogmaAttributeData.id= 2032; name= "modeMWDCapPostDiv"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2226 -> { DogmaAttributeData.id= 2226; name= "fighterAbilityAttackMissileDamageMultiplier"; description= "Damage Multiplier"; published= true; unitId= Some(104); defaultValue= 0.000000; stackable= false; highIsGood= true } |> Some
      | 2323 -> { DogmaAttributeData.id= 2323; name= "shipBonusForceAuxiliaryM4"; description= "Multiplied by Minmatar Carrier skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2420 -> { DogmaAttributeData.id= 2420; name= "shipBonusTitanM3"; description= "Multiplied by Minmatar Titan skill level."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2517 -> { DogmaAttributeData.id= 2517; name= "npcTrackingDisruptorFalloff"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2614 -> { DogmaAttributeData.id= 2614; name= "behaviorMicroWarpDriveDischarge"; description= ""; published= false; unitId= Some(114); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 2711 -> { DogmaAttributeData.id= 2711; name= "oreBasicType"; description= "Reference for grouping ores in visual displays. All variants of one ore should have the same BasicType ID"; published= false; unitId= Some(116); defaultValue= 0.000000; stackable= false; highIsGood= false } |> Some
      | 2808 -> { DogmaAttributeData.id= 2808; name= "TotalArmorRepairOnTarget"; description= ""; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 286 -> { DogmaAttributeData.id= 286; name= "excludeHostiles"; description= "Indicates whether the modules ranged effects exclude ships hostile to the user."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 383 -> { DogmaAttributeData.id= 383; name= "maxActiveFactories"; description= "Max active factories"; published= true; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 480 -> { DogmaAttributeData.id= 480; name= "maxEffectiveRange"; description= ""; published= false; unitId= Some(1); defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 771 -> { DogmaAttributeData.id= 771; name= "ammoCapacity"; description= ""; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 868 -> { DogmaAttributeData.id= 868; name= "jumpDriveConsumptionAmount"; description= "Number of units it consumes per light year."; published= true; unitId= Some(138); defaultValue= 2000.000000; stackable= false; highIsGood= false } |> Some
      | 92 -> { DogmaAttributeData.id= 92; name= "kineticDampeningFieldStrength"; description= "The strength of the kinetic dampening field.  If high may nullify projectiles."; published= false; unitId= None; defaultValue= 0.000000; stackable= true; highIsGood= true } |> Some
      | 965 -> { DogmaAttributeData.id= 965; name= "passiveThermalDamageResonanceMultiplier"; description= ""; published= false; unitId= Some(111); defaultValue= 1.000000; stackable= false; highIsGood= false } |> Some
      | _ -> None