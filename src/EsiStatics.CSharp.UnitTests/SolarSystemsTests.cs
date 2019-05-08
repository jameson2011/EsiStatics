using System;
using System.Linq;
using Xunit;
using EsiStatics;
using FluentAssertions;

namespace EsiStatics.CSharp.UnitTests
{
    public class SolarSystemsTests
    {

        [Theory]
        [InlineData(-1)]
        public void SolarSystem_UnknownId_ThrowsException(int solarSystemId)
        {
            Action a = () =>
            {
                var x = SolarSystems.ById(solarSystemId).Value;
            };

            a.Should().Throw<NullReferenceException>();
        }

        [Theory]
        [InlineData(30005003)]
        public void SolarSystem_Id_ReturnsSame(int solarSystemId)
        {
            var ss = SolarSystems.ById(solarSystemId).Value;

            
            ss.Id.Should().Be(solarSystemId);
        }

        
        [Theory]
        [InlineData(30005003, "Adirain")]
        public void SolarSystem_ById_ReturnsSystem(int solarSystemId, string expectedName)
        {
            var ss = SolarSystems.ById(solarSystemId).Value;

            ss.Name.Should().Be(expectedName);
        }

        [Theory]
        [InlineData(-1)]
        public void SolarSystem_ById_UnknownId_ReturnsNull(int solarSystemId)
        {
            var ss = SolarSystems.ById(solarSystemId);

            ss.Should().BeNull();
        }


        [Theory]
        [InlineData(30005003, 10)]
        public void SolarSystem_BeltsMoonsCrawled(int id, int expectedPlanets)
        {
            var s = SolarSystems.ById(id).Value;

            var planets = s.Planets().ToList();

            var xs = planets.Select(p => (p, p.AsteroidBelts().ToList(), p.Moons().ToList())).ToList();
            
            planets.Should().HaveCount(expectedPlanets);

            xs.Any(t => t.Item2.Count > 0).Should().BeTrue();
            xs.Any(t => t.Item3.Count > 0).Should().BeTrue();
        }
    }
}
