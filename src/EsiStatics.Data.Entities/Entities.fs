namespace EsiStatics.Data.Entities
open System
type PositionData = { x: float; y: float; z: float }
type PlanetRefData = { planetId: int; moonIds: int[]; beltIds: int[] }
type SystemSecurity = 
| Highsec
| Lowsec
| Nullsec
| Wormhole
| Abyssal
type RegionData = { id: int; name: string; constellationIds: int[] }
type ConstellationData = { id: int; name: string; regionId: int; solarSystemIds: int[]; position: PositionData }
type SolarSystemData = { id: int; name: string; constellationId: int; position: PositionData; secRating: SystemSecurity; secClass: string; secStatus: float; stargateIds: int[]; stationIds: int[]; starIds: int[]; planetIds: PlanetRefData[] }
type PlanetData = { id: int; name: string; solarSystemId: int; position: PositionData; typeId: int }
type StarData = { id: int; name: string; solarSystemId: int; typeId: int; age: int64; luminosity: float; radius: int64; spectralClass: string; temperature: int }
type StargateData = { id: int; name: string; solarSystemId: int; position: PositionData; typeId: int; destinationSolarSystemId: int; destinationStargateId: int }
type AsteroidBeltData = { id: int; name: string; solarSystemId: int; position: PositionData }
type StationData = { id: int; name: string; solarSystemId: int; position: PositionData; typeId: int; services: string[]; maxDockableShipVolume: int }
type MoonData = { id: int; name: string; solarSystemId: int; position: PositionData }
type CategoryData = { id: int; name: string; published: bool; groupIds: int[] }
type GroupData = { id: int; name: string; categoryId: int; published: bool; typeIds: int[] }
type MarketGroupData = { id: int; name: string; parentMarketGroupId: int option; typeIds: int[]; description: string }
type DogmaAttributeValueData = { attributeId: int; value: float }
type DogmaEffectValueData = { effectId: int; isDefault: bool }
type ItemTypeData = { id: int; name: string; published: bool; description: string; marketGroupId: int; groupId: int; dogmaAttributes: DogmaAttributeValueData[]; dogmaEffects: DogmaEffectValueData[]; capacity: float; graphicId: int; mass: float; packagedVolume: float; portionSize: int; radius: float; volume: float }
type DogmaAttributeData = { id: int; name: string; description: string; published: bool; unitId: int option; defaultValue: float; stackable: bool; highIsGood: bool }
type DogmaEffectData = { id: int; name: string; description: string; displayName: string; effectCategory: int; preExpression: int; postExpression: int }