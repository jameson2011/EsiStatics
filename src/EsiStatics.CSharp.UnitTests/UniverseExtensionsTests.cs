using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace EsiStatics.CSharp.UnitTests
{
    public class UniverseExtensionsTests
    {
        [Fact]
        public void Region_Constellations_ReturnsNonEmptySequence()
        {
            var r = Regions.Get(10000064).Value;
            
            var cs = r.Constellations().ToList();

            cs.Should().NotHaveCount(0);
        }

        [Fact]
        public void Region_Constellations_NullRegion_ThrowsException()
        {
            Region r = null;

            Action a = () => r.Constellations();

            a.Should().Throw<ArgumentNullException>();
        }


        [Fact]
        public void Constellation_SolarSystems_ReturnsNonEmptySequence()
        {
            var c = Constellations.Get(20000001).Value;

            var ss = c.SolarSystems().ToList();

            ss.Should().NotHaveCount(0);
        }


        [Fact]
        public void Constellation_SolarSystems_NullConstellation_ThrowsException()
        {
            Constellation c = null;

            Action a = () => c.SolarSystems();

            a.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Constellation_Region_HasSameId()
        {
            var c = Constellations.Get(20000001).Value;

            var r = c.Region();

            c.RegionId.Should().Be(r.Id);
        }


        [Fact]
        public void Constellation_Region_NullConstellation_ThrowsException()
        {
            Constellation c = null;

            Action a = () => c.Region();

            a.Should().Throw<ArgumentNullException>();
        }


        [Fact]
        public void SolarSystem_Constellation_HasSameId()
        {
            var ss = SolarSystems.Get(30005003).Value;

            var c = ss.Constellation();

            c.Id.Should().Be(ss.ConstellationId);
        }


        [Fact]
        public void SolarSystem_Constellation_NullSolarSystem_ThrowsException()
        {
            SolarSystem ss = null;

            Action a = () => ss.Constellation();

            a.Should().Throw<ArgumentNullException>();
        }


        [Theory]
        [InlineData(30005003, "Essence")]
        public void SolarSystem_ToConstellation_ToRegion_Aligns(int solarSystemId, string regionName)
        {
            
            var r = SolarSystems.Get(solarSystemId).Value.Constellation().Region();

            r.Name.Should().Be(regionName);

        }

        [Fact]
        public void SolarSystems_TraverseAll()
        {
            var systems = Regions.GetAll()
                                .SelectMany(r => r.Constellations())
                                .SelectMany(c => c.SolarSystems());

            var count = systems.Count();

            count.Should().BeGreaterOrEqualTo(8200);
        }

        [Theory]
        [InlineData(30005003, 0)]
        [InlineData(30005003, 1)]
        [InlineData(30005003, 2)]
        [InlineData(30005003, 3)]
        [InlineData(30005003, 4)]
        [InlineData(30005003, 5)]
        [InlineData(30005003, 6)]
        public void SolarSystem_Neighbours(int solarSystemId, int depth)
        {
            var sys = SolarSystems.Get(solarSystemId).Value;

            var neighbours = sys.Neighbours(depth).ToList();
            
            neighbours.Count.Should().Be(depth);
        }


        [Theory]
        [InlineData(30005003, -1)]
        [InlineData(30005003, -2)]
        public void SolarSystem_Neighbours_NegativeDepth(int solarSystemId, int depth)
        {
            var ss = SolarSystems.Get(solarSystemId).Value;

            var neighbours = ss.Neighbours(depth).ToList();

            neighbours.Count.Should().Be(0);
        }

        [Theory]
        [InlineData(30005003, 6, 2.0)]
        [InlineData(30005003, 6, 3.0)]
        [InlineData(30005003, 6, 4.0)]
        [InlineData(30005003, 6, 5.0)]
        
        [InlineData(30002089, 6, 2.0)]
        [InlineData(30002089, 6, 3.0)]
        [InlineData(30002089, 6, 4.0)]
        [InlineData(30002089, 6, 5.0)]

        public void SolarSystem_Neighbours_FindThoseWithinXLightYears(int solarSystemId, int depth, double ly)
        {
            var sys = SolarSystems.Get(solarSystemId).Value;

            var neighbours = sys.Neighbours(depth).SelectMany(xs => xs)
                                    .Where(s => s.Level == SecurityLevel.Lowsec ||
                                                s.Level == SecurityLevel.Nullsec)
                                    .Select(s => (Units.MetresToLy(Geometry.GetEuclidean(sys.Position, s.Position)), s))
                                    .Where(t => t.Item1 <= ly)
                                    .OrderBy(t => t.Item1)
                                    .ToList();

            neighbours.Count().Should().BeGreaterThan(0);
        }


        [Theory]
        [InlineData(30005003)]
        public void SolarSystem_Planets_ReturnsNonEmpty(int solarSystemId)
        {
            var ss = SolarSystems.Get(solarSystemId).Value;

            var planets = ss.Planets().ToList();

            planets.Should().NotHaveCount(0);
        }


        [Theory]
        [InlineData(30005003)]
        public void SolarSystem_Stations_ReturnsNonEmpty(int solarSystemId)
        {
            var ss = SolarSystems.Get(solarSystemId).Value;

            var stations = ss.Stations().ToList();

            stations.Should().NotHaveCount(0);
        }


        [Theory]
        [InlineData(30005003)]
        public void SolarSystem_Stargates_ReturnsNonEmpty(int solarSystemId)
        {
            var ss = SolarSystems.Get(solarSystemId).Value;

            var gates = ss.Stargates().ToList();

            gates.Should().NotHaveCount(0);
        }

        [Theory]
        [InlineData(30005003)]
        public void SolarSystem_Star_ReturnsSome(int solarSystemId)
        {
            var ss = SolarSystems.Get(solarSystemId).Value;

            var star = ss.Star().Value;

            star.Should().NotBeNull();

        }


        [Theory]
        [InlineData(40316914)]
        public void Planet_AsteroidBelts_ReturnsNonEmpty(int planetId)
        {
            var planet = Planets.Get(planetId).Value;

            var belts = planet.AsteroidBelts().ToList();

            belts.Should().NotHaveCount(0);
        }

        [Theory]
        [InlineData(40316908)]
        public void Planet_Moons_ReturnsNonEmpty(int planetId)
        {
            var planet = Planets.Get(planetId).Value;
            var moons = planet.Moons().ToList();

            moons.Should().NotHaveCount(0);
        }


        [Theory]
        [InlineData(30005003)]
        public void SolarSystem_AsteroidBelts_Warmup_ReturnsAll(int solarSystemId)
        {
            // Warm up.
            var allBelts = Regions.GetAll()
                                .SelectMany(r => r.Constellations())
                                .SelectMany(c => c.SolarSystems())
                                .SelectMany(s => s.Planets())
                                .SelectMany(p => p.AsteroidBelts())
                                .Count();

            var ss = SolarSystems.Get(solarSystemId).Value;

            var belts = ss.Planets().SelectMany(p => p.AsteroidBelts()).ToList();

            belts.Should().NotHaveCount(0);
            allBelts.Should().BeGreaterThan(50000);
        }

        [Theory]
        [InlineData(30005003)]
        public void SolarSystem_Moons_Warmup_ReturnsAll(int solarSystemId)
        {
            // Warm up.
            var allMoons = Regions.GetAll()
                                .SelectMany(r => r.Constellations())
                                .SelectMany(c => c.SolarSystems())
                                .SelectMany(s => s.Planets())
                                .SelectMany(p => p.Moons())
                                .Count();

            var ss = SolarSystems.Get(solarSystemId).Value;

            var moons = ss.Planets().SelectMany(p => p.Moons()).ToList();

            moons.Should().NotHaveCount(0);
            allMoons.Should().BeGreaterThan(300000);
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        public void SolarSystem_Celestials_UnknownReturnsEmpty(int solarSystemId)
        {
            var ss = new SolarSystem(solarSystemId, 0, "", 0, SecurityLevel.Lowsec, Position.Empty, null);

            var celestials = ss.Celestials().ToList();

            celestials.Should().HaveCount(0);
        }

        [Theory]
        [InlineData(30005003)]
        [InlineData(30002089)]
        public void SolarSystem_Celestials_ReturnsAll(int solarSystemId)
        {
            var ss = SolarSystems.Get(solarSystemId).Value;

            var celestials = ss.Celestials().ToList();

            celestials.Should().HaveCountGreaterThan(10);
        }

        [Theory]
        [InlineData(30005003)]
        [InlineData(30002089)]
        public void SolarSystem_CelestialDistances(int solarSystemId)
        {
            var ss = SolarSystems.Get(solarSystemId).Value;

            var pos = Position.FromCoordinates(1, 1, 1);

            var results = ss.CelestialDistances(pos).ToList();

            var star = ss.Star().Value;

            results.First().Item1.Id.Should().Be(star.Id);
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        public void SolarSystem_CelestialDistances_Unknown_ReturnsEmpty(int solarSystemId)
        {
            var ss = new SolarSystem(solarSystemId, 0, "", 0, SecurityLevel.Lowsec, Position.Empty, null);

            var pos = Position.FromCoordinates(1, 1, 1);

            var results = ss.CelestialDistances(pos).ToList();
            
            results.Should().HaveCount(0);
        }


        [Theory]
        [InlineData(30005003, 30002089, 14)]
        [InlineData(30013489, 30005003, 18)]
        [InlineData(30013489, 30002089, 18)]
        [InlineData(30013489, 30000142, 26)]
        [InlineData(30004714, 30000142, 45)] // 1 sec + high GC
        [InlineData(30004483, 30000142, 50)] // 100ms
        [InlineData(30001375, 30000055, 25)]
        public void SolarSystem_FindRoute(int start, int finish, int expected)
        {
            var s = SolarSystems.Get(start).Value;
            var f = SolarSystems.Get(finish).Value;

            var result = s.FindGateRoute(f);

            Assert.Equal(result.Length, expected);
        }

        [Theory]
        [InlineData(30005003, 30002089, 14)]
        [InlineData(30013489, 30005003, 25)]
        [InlineData(30013489, 30002089, 37)]
        [InlineData(30013489, 30000142, 26)]
        public void SolarSystem_FindHighsecRoute(int start, int finish, int expected)
        {
            var s = SolarSystems.Get(start).Value;
            var f = SolarSystems.Get(finish).Value;

            var result = s.FindHighsecGateRoute(f);

            Assert.Equal(expected, result.Length);
        }


        [Theory]
        [InlineData(50004356)]
        public void Stargate_DestinationSolarSystem_ReturnsSolarSystem(int stargateId)
        {
            var sg = Stargates.Get(stargateId).Value;

            var dest = sg.DestinationSolarSystem();

            dest.Id.Should().Be(sg.DestinationSolarSystemId);
        }


        [Theory]
        [InlineData(50004356)]
        public void Stargate_DestinationStargate_ReturnsStargate(int stargateId)
        {
            var sg = Stargates.Get(stargateId).Value;

            var dest = sg.DestinationStargate();

            dest.Id.Should().Be(sg.DestinationStargateId);

        }


        [Theory]
        [InlineData(50004356)]
        public void Stargate_SolarSystem_ReturnsSolarSystem(int stargateId)
        {
            var sg = Stargates.Get(stargateId).Value;

            var dest = sg.SolarSystem();

            dest.Id.Should().Be(sg.SolarSystemId);
        }
    }
}
