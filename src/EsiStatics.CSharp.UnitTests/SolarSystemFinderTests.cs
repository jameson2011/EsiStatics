using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using EsiStatics;
using FluentAssertions;

namespace EsiStatics.CSharp.UnitTests
{
    public class SolarSystemFinderTests
    {

        [Theory]
        [InlineData("Adirain", 1)]
        public void Find_ExactMatch_ReturnsMatches(string search, int expectedCount)
        {
            var f = new SolarSystemFinder();

            var results = f.Find(search).ToList();

            results.Should().HaveCount(expectedCount);
            results[0].Name.Should().Be(search);
        }


        [Theory]
        [InlineData("Adi", 3)]
        public void Find_PrefixMatch_ReturnsMatches(string search, int expectedCount)
        {
            var f = new SolarSystemFinder();

            var results = f.Find(search).ToList();

            results.Should().HaveCount(expectedCount);
            var names = results.Select(s => s.Name);
            names.All(n => n.StartsWith(search)).Should().BeTrue();
        }


        [Theory]
        [InlineData("adirain", 3)]
        public void Find_NeighoursChained(string search, int expectedCount)
        {
            var f = new SolarSystemFinder();

            var results = f.Find(search)
                .SelectMany(s => s.Neighbours(1))
                .SelectMany(xs => xs)                
                .ToList();

            results.Should().HaveCount(expectedCount);
        }
    }
}
