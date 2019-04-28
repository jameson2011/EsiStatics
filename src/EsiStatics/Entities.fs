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

type INavigable =
    abstract member Id:         int
    abstract member Name:       string
    abstract member Position:   Position

    
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
        Id:         int
        Name:       string
        Position:   Position
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
        Id:             int
        Name:           string
        Position:       Position
        SolarSystemId:  int
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position
       
type Moon = 
    {
        Id:         int
        Name:       string
        Position:   Position
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position
       
type AsteroidBelt = 
    {
        Id:         int
        Name:       string
        Position:   Position
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
    }
    interface INavigable with
        member x.Id =       x.Id
        member x.Name =     x.Name
        member x.Position = x.Position