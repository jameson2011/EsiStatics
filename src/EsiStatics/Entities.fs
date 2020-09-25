namespace EsiStatics



type Position = 
    {
        [<CompiledName("X")>]
        x: float<m>; 
        [<CompiledName("Y")>]
        y: float<m>; 
        [<CompiledName("Z")>]
        z: float<m>;
    } with
    [<CompiledName("Empty")>]
    static member empty =   
        { x = 0.<m>; y = 0.<m>; z = 0.<m> }
    [<CompiledName("FromCoordinates")>]
    static member ofCoordinates (x: float, y: float, z: float) = 
        { x = Units.toMetres x; y = Units.toMetres y; z = Units.toMetres z }


type SecurityLevel =
    | Highsec
    | Lowsec
    | Nullsec
    | Wormhole
    | Abyssal

type TriglavianInvasionStatus=
    | StellarReconnaisance
    | EdencomMinorVictory
    | Redoubt
    | Bulwark
    | Fortress
    | TriglavianMinorVictory
    | FirstLiminality
    | SecondLiminality
    | FinalLiminality

type INavigable =
    abstract member Id:         int
    abstract member Name:       string
    abstract member Position:   Position


type Region = 
    {
        Id:                 int;
        Name:               string;
    }

type Constellation = 
    {
        Id:                 int;
        RegionId:           int;
        Name:               string;
        Position:           Position;
    }

    
type SolarSystem = 
    {
        Id:                 int;
        ConstellationId:    int;
        Name:               string;
        Security:           float;
        Level:              SecurityLevel;
        Position:           Position;
        InvasionStatus:     TriglavianInvasionStatus option;
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position



type Star = 
    {
        Id:             int
        Name:           string
        Position:       Position;
        SolarSystemId:  int;
        TypeId:         int; 
        Age:            int64; 
        Luminosity:     float; 
        Radius:         float<m>; 
        SpectralClass:  string; 
        Temperature:    float<K>
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position
       
type Planet = 
    {
        Id:             int
        Name:           string
        Position:       Position
        TypeId:         int;
        SolarSystemId:  int;
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position

type Station = 
    {
        Id:                 int
        Name:               string
        Position:           Position
        SolarSystemId:      int
        Services:           string [];
        TypeId:             int;
        MaxDockableVolume:  int;
        Radius:             float<m> option;
        DockingRange:       float<m> option;
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position
       
type Moon = 
    {
        Id:             int
        Name:           string
        Position:       Position
        SolarSystemId:  int
        PlanetId:       int
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position
       
type AsteroidBelt = 
    {
        Id:             int
        Name:           string
        Position:       Position
        SolarSystemId:  int
        PlanetId:       int
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position
       

type Stargate = 
    {
        Id:                         int
        Name:                       string
        Position:                   Position
        SolarSystemId:              int
        DestinationSolarSystemId:   int
        DestinationStargateId:      int
        TypeId:                     int
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position

type MarketGroup =
    {
        Id:             int;
        Name:           string;
    }

type Category =
    {
        Id:             int;
        Name:           string;
        Published:      bool; 
    }

type Group =
    {
        Id:             int;
        Name:           string;
        Published:      bool;
    }

type ItemType =
    {
        Id:             int;
        Name:           string;
        Published:      bool;
        Capacity:       float<m3>;
        Mass:           float<kg>;
        PackagedVolume: float<m3>;
        PortionSize:    int;
        Radius:         float<m>;
        Volume:         float<m3>;
        GraphicId:      int option;
    }

type NpcCorp =
    {
        Id:             int;
        Name:           string;
    }

type ItemLocation =
    | Unknown
    | NoLocation // None
    | Hangar
    | Wardrobe
    | CargoHold
    | HighSlot
    | MidSlot
    | LowSlot
    | FixedSlot
    | Capsule
    | Pilot
    | RigSlot
    | Subsystem
    | Implant
    | DroneBay
    | ShipHangar
    | ShipHold
    | SecondaryStorage
    | FleetHangar
    | FighterBay
    | FighterTube
    | SubsystemBay
    | OreHold
    | FuelBay
    | StructureServiceSlots
    | StructureFuelBay
    | GasHold
    | PlanetaryCommoditiesHold
    | MineralHold
    | SpecialisedAmmoHold
    | CommandCentreHold
    | MaterialBay
    | FrigateEscapeBay
    | CoreRoom
with static member ofId(id) = 
        match id with
        | 0 ->      ItemLocation.NoLocation
        | 3 ->      ItemLocation.Wardrobe
        | 4 ->      ItemLocation.Hangar
        | 5 ->      ItemLocation.CargoHold
        | 27 | 28 | 29 | 30 | 31 | 32 | 33 | 34 -> ItemLocation.HighSlot
        | 19 | 20 | 21 | 22 | 23 | 24 | 25 | 26 -> ItemLocation.MidSlot
        | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 -> ItemLocation.LowSlot
        | 35 ->     ItemLocation.FixedSlot
        | 56 ->     ItemLocation.Capsule
        | 57 ->     ItemLocation.Pilot
        | 92 | 93 | 94 | 95 | 96 | 97 | 98 | 99 -> ItemLocation.RigSlot
        | 125 | 126 | 127 | 128 | 129 | 130 | 131 | 132 -> ItemLocation.Subsystem
        | 89 ->     ItemLocation.Implant
        | 87 ->     ItemLocation.DroneBay
        | 90 ->     ItemLocation.ShipHangar
        | 138 | 139 | 140 | 141 | 142 ->    ItemLocation.ShipHold
        | 122 ->    ItemLocation.SecondaryStorage
        | 155 ->    ItemLocation.FleetHangar
        | 158 ->    ItemLocation.FighterBay
        | 159 | 160 | 161 | 162 | 163 ->    ItemLocation.FighterTube
        | 177 ->    ItemLocation.SubsystemBay
        | 134 ->    ItemLocation.OreHold
        | 133 ->    ItemLocation.FuelBay
        | 164 | 165 | 166 | 167 | 168 | 169 | 170 | 171 ->      ItemLocation.StructureServiceSlots
        | 172 ->    ItemLocation.StructureFuelBay
        | 135 ->    ItemLocation.GasHold
        | 149 ->    ItemLocation.PlanetaryCommoditiesHold
        | 136 ->    ItemLocation.MineralHold
        | 143 ->    ItemLocation.SpecialisedAmmoHold
        | 148 ->    ItemLocation.CommandCentreHold
        | 151 ->    ItemLocation.MaterialBay
        | 179 ->    ItemLocation.FrigateEscapeBay
        | 180 ->    ItemLocation.CoreRoom
        | _ ->      ItemLocation.Unknown
