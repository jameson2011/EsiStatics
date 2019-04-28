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
                        Position = ofPositionData value.position  }

    let ofStarData (value: StarData) =
        { Star.Id = value.id;
                Name = value.name;
                Position = Position.empty
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
        }


    let ofStationData (value: StationData) =
        { Station.Id = value.id;
            Name = value.name;
            Position = ofPositionData value.position;
            SolarSystemId = value.solarSystemId;
        }

    let ofStargateData (value: StargateData) =
        { Stargate.Id = value.id;
            Name = value.name;
            Position = ofPositionData value.position;
            SolarSystemId = value.solarSystemId;
            DestinationSolarSystemId = value.destinationSolarSystemId;
            DestinationStargateId = value.destinationStargateId;
        }

    let ofAsteroidBeltData (value: AsteroidBeltData) = 
        { AsteroidBelt.Id = value.id;
            Name = value.name;
            Position = ofPositionData value.position;
        }