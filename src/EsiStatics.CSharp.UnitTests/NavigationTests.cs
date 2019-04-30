using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using EsiStatics;
using FluentAssertions;

namespace EsiStatics.CSharp.UnitTests
{
    public class NavigationTests
    {
        
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 10, 10)]
        [InlineData(0, 5, 10)]
        public void Euclidean_SamePointe(float x, float y, float z)
        {
            var p1 = Position.FromCoordinates(x, y, z);
            var p2 = Position.FromCoordinates(x, y, z);

            var distance = Navigation.GetEuclidean(p1, p2);

            distance.Should().Be(0);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 10, 10)]
        [InlineData(0, 5, 10)]
        public void Euclidean_FromZero(float x, float y, float z)
        {
            var p1 = Position.Empty;
            var p2 = Position.FromCoordinates(x, y, z);

            var distance = Navigation.GetEuclidean(p1, p2);

            distance.Should().BeGreaterThan(0); 
        }


        [Theory]
        [InlineData(30005003, 30002089, 14)]
        [InlineData(30013489, 30005003, 18)]
        [InlineData(30013489, 30002089, 20)]
        [InlineData(30013489, 30000142, 10)]
        public void findRoute_euclidean(int start, int finish, int expected)
        {
            var s = SolarSystems.ById(start).Value;
            var f = SolarSystems.ById(finish).Value;
            
            var result = Navigation.FindDirectRoute(s, f);

            Assert.Equal(result.Length, expected);
        }
    }
}
