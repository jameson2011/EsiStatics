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