using System;
using System.Linq;
using Xunit;
using EsiStatics;
using FluentAssertions;

namespace EsiStatics.CSharp.UnitTests
{
    public class StarTests
    {
        [Theory]
        [InlineData(-1)]
        public void Star_Unknown_ReturnsNull(int starId)
        {
            var s = Stars.Get(starId);

            s.Should().BeNull();
        }

        [Theory]
        [InlineData(40000291)]
        public void Star_Known_ReturnsSome(int starId)
        {
            var star = Stars.Get(starId).Value;

            star.Id.Should().Be(starId);
        }
    }
}
