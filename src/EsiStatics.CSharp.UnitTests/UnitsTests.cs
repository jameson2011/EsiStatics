using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using EsiStatics;
using FluentAssertions;


namespace EsiStatics.CSharp.UnitTests
{
    public class UnitsTests
    {
        private const double epsilon = 0.0001;
        private Func<double, double, double> diff = (x, y) => Math.Abs(x - y);

        [Theory]
        [InlineData(1.0)]
        [InlineData(1000.0)]
        [InlineData(1000000.0)]
        public void MetresToAu(float metres)
        {
            double m = Units.ToMetres(metres);
            double au = Units.MetresToAu(m);
            double m2 = Units.AuToMetres(au);
            
            diff(m2, m).Should().BeLessOrEqualTo(epsilon);
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(1000.0)]
        [InlineData(1000000.0)]
        public void MetresToKm(float metres)
        {
            double m = Units.ToMetres(metres);
            double au = Units.MetresToKm(m);
            double m2 = Units.KmToMetres(au);

            diff(m2, m).Should().BeLessOrEqualTo(epsilon);
        }


        [Theory]
        [InlineData(1.0)]
        [InlineData(1000.0)]
        [InlineData(1000000.0)]
        public void MetresToLy(float metres)
        {
            double m = Units.ToMetres(metres);
            double au = Units.MetresToLy(m);
            double m2 = Units.LyToMetres(au);

            diff(m2, m).Should().BeLessOrEqualTo(epsilon);
        }
    }
}
