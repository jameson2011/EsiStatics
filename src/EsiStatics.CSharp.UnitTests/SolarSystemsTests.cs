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


    }
}
