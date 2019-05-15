namespace EsiStatics.Data.Entities
open System
[<Struct>]
type PositionData = { x: float; y: float; z: float }
[<Struct>]
type PlanetRefData = { planetId: int; moonIds: int[]; beltIds: int[] }
type SystemSecurity = 
| Highsec
| Lowsec
| Nullsec
| Wormhole
| Abyssal
[<Struct>]
type RegionData = { id: int; name: string; constellationIds: int[] }
[<Struct>]
type ConstellationData = { id: int; name: string; regionId: int; solarSystemIds: int[]; position: PositionData }
[<Struct>]
type SolarSystemData = { id: int; name: string; constellationId: int; position: PositionData; secRating: SystemSecurity; secClass: string; secStatus: float; stargateIds: int[]; stationIds: int[]; starIds: int[]; planets: PlanetRefData[] }
[<Struct>]
type PlanetData = { id: int; name: string; solarSystemId: int; position: PositionData; typeId: int; asteroidBeltIds: int[]; moonIds: int[] }
[<Struct>]
type StarData = { id: int; name: string; solarSystemId: int; typeId: int; age: int64; luminosity: float; radius: int64; spectralClass: string; temperature: int }
[<Struct>]
type StargateData = { id: int; name: string; solarSystemId: int; position: PositionData; typeId: int; destinationSolarSystemId: int; destinationStargateId: int }
[<Struct>]
type AsteroidBeltData = { id: int; name: string; solarSystemId: int; position: PositionData }
[<Struct>]
type StationData = { id: int; name: string; solarSystemId: int; position: PositionData; typeId: int; services: string[]; maxDockableShipVolume: int }
[<Struct>]
type MoonData = { id: int; name: string; solarSystemId: int; position: PositionData }
[<Struct>]
type CategoryData = { id: int; name: string; published: bool; groupIds: int[] }
[<Struct>]
type GroupData = { id: int; name: string; categoryId: int; published: bool; typeIds: int[] }
[<Struct>]
type MarketGroupData = { id: int; name: string; parentMarketGroupId: int option; typeIds: int[]; description: string }
[<Struct>]
type DogmaAttributeValueData = { attributeId: int; value: float }
[<Struct>]
type DogmaEffectValueData = { effectId: int; isDefault: bool }
[<Struct>]
type ItemTypeData = { id: int; name: string; published: bool; description: string; marketGroupId: int option; groupId: int; dogmaAttributes: DogmaAttributeValueData[]; dogmaEffects: DogmaEffectValueData[]; capacity: float; graphicId: int option; mass: float; packagedVolume: float; portionSize: int; radius: float; volume: float }
[<Struct>]
type DogmaAttributeData = { id: int; name: string; description: string; published: bool; unitId: int option; defaultValue: float; stackable: bool; highIsGood: bool }
[<Struct>]
type DogmaEffectData = { id: int; name: string; description: string; displayName: string; effectCategory: int; preExpression: int; postExpression: int }