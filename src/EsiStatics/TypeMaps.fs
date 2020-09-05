namespace EsiStatics

module internal TypeMaps=
    open EsiStatics.Data.Entities

    let ofPositionData (value: PositionData) =
        Position.ofCoordinates (value.x, value.y, value.z)
        
    let ofSystemSecurity (value: SystemSecurity) =
        match value with
        | Highsec ->    SecurityLevel.Highsec
        | Lowsec ->     SecurityLevel.Lowsec
        | Nullsec ->    SecurityLevel.Nullsec
        | Wormhole ->   SecurityLevel.Wormhole
        | Abyssal ->    SecurityLevel.Abyssal

    let ofRegionData (value: RegionData) =
        { Region.Id = value.id; Name = value.name; }

    let ofConstellationData (value: ConstellationData) =
        { Constellation.Id = value.id; Name = value.name; RegionId = value.regionId; Position = ofPositionData value.position }

    let ofSolarSystemData (value: SolarSystemData) =
        { SolarSystem.Id = value.id;
                        Name = value.name; 
                        ConstellationId = value.constellationId;
                        Security = value.secStatus; 
                        Level = ofSystemSecurity value.secRating; 
                        InvasionStatus = None;
                        Position = ofPositionData value.position  }

    let ofStarData (value: StarData) =
        { Star.Id = value.id;
                Name = value.name;
                Position = Position.empty;
                SolarSystemId = value.solarSystemId;
                Age = value.age;
                Luminosity = value.luminosity;
                TypeId = value.typeId;
                Radius = value.radius |> float |> Units.toMetres;
                SpectralClass = value.spectralClass;
                Temperature = value.temperature |> float |> Units.toKelvin;
                }

    let ofPlanetData (value: PlanetData) =
        { Planet.Id = value.id;
                Name = value.name;
                Position = ofPositionData value.position;
                TypeId = value.typeId;
                SolarSystemId = value.solarSystemId;
        }

    let ofMoonData (value: MoonData) =
        { Moon.Id = value.id;
            Name = value.name;
            Position = ofPositionData value.position;
            SolarSystemId = value.solarSystemId;
            PlanetId = value.planetId;
        }


    let ofStationData (value: StationData) =
        { Station.Id = value.id;
            Name = value.name;
            Position = ofPositionData value.position;
            SolarSystemId = value.solarSystemId;
            TypeId = value.typeId;
            Services = value.services;
            MaxDockableVolume = value.maxDockableShipVolume;
        }

    let ofStargateData (value: StargateData) =
        { Stargate.Id = value.id;
            Name = value.name;
            Position = ofPositionData value.position;
            SolarSystemId = value.solarSystemId;
            DestinationSolarSystemId = value.destinationSolarSystemId;
            DestinationStargateId = value.destinationStargateId;
            TypeId = value.typeId;
        }

    let ofAsteroidBeltData (value: AsteroidBeltData) = 
        { AsteroidBelt.Id = value.id;
            Name = value.name;
            Position = ofPositionData value.position;
            SolarSystemId = value.solarSystemId;
            PlanetId = value.planetId;
        }

    let ofMarketGroupData (value: MarketGroupData)=
        {
            MarketGroup.Id = value.id;
            Name = value.name;
        }

    let ofCategoryData (value: CategoryData) =
        {
            Category.Id = value.id;
            Name = value.name;
            Published = value.published;
        }
        
    let ofGroupData (value: GroupData)=
        {
            Group.Id = value.id;
            Name = value.name;
            Published = value.published;
        }

    let ofItemTypeData (value: ItemTypeData)=
        {
            ItemType.Id = value.id;
            Name = value.name;
            Published = value.published;
            Capacity = value.capacity |> Units.toCubicMetres;
            Mass = value.mass |> Units.toKilos;
            PackagedVolume = value.packagedVolume |> Units.toCubicMetres;
            PortionSize = value.portionSize;
            Radius = value.radius |> Units.toMetres;
            Volume = value.volume |> Units.toCubicMetres;
            GraphicId = value.graphicId;
        }
        
    let ofNpcCorp (value: NameData) =
        {
            NpcCorp.Id = value.id;
                    Name = value.name;
        }