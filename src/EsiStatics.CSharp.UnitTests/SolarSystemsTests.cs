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

            var id = SolarSystems.id(ss);

            id.Should().Be(solarSystemId);
        }

        [Fact]
        public void SolarSystem_Id_NullSystem_ThrowsException()
        {
            SolarSystem ss = null;

            Action a = () => SolarSystems.id(ss);

            a.Should().Throw<ArgumentNullException>();
            
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
