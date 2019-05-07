using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EsiStatics.CSharp.UnitTests
{
    public class ItemTypesTests
    {

        [Fact]
        public void MarketGroups_RootsHaveNoParents()
        {
            var mgs = MarketGroups.GetRootMarketGroups().ToList();

            var parentedMgs = mgs.Where(mg => MarketGroups.GetParent(mg) != null).ToList();

            mgs.Should().HaveCountGreaterThan(0);
            parentedMgs.Should().HaveCount(0);
        }

        
        [Fact]
        public void MarketGroups_All_ReturnsMoreThanRoots()
        {
            var roots = MarketGroups.GetRootMarketGroups().ToList();
            var mgs = MarketGroups.GetMarketGroups().ToList();

            mgs.Count.Should().BeGreaterThan(roots.Count);
        }

        [Theory]
        [InlineData(4)]
        public void MarketGroups_Get_Returned(int id)
        {
            var mg = MarketGroups.GetMarketGroup(id).Value;

            mg.Should().NotBeNull();
        }

        [Theory]
        [InlineData(4)]
        public void MarketGroups_GetChildren_Returned(int id)
        {
            var mg = MarketGroups.GetMarketGroup(id).Value;

            var children = MarketGroups.GetChildMarketGroups(mg).ToList();
            children.Count.Should().BeGreaterThan(0);
        }


        [Theory]
        [InlineData(587)]
        [InlineData(570)]
        [InlineData(670)]
        public void ItemTypes_AccessRelatedEntities(int itemTypeId)
        {

            var it = ItemTypes.GetItemType(itemTypeId).Value;

            var mg = ItemTypes.GetMarketGroup(it);
            var g = ItemTypes.GetGroup(it);
            var c = Groups.GetCategory(g);

            g.Should().NotBeNull();
            c.Should().NotBeNull();
        }

        [Theory]
        [InlineData(587)]
        [InlineData(570)]
        public void ItemTypes_WalkMarketGroupParentage(int itemTypeId)
        {
            var it = ItemTypes.GetItemType(itemTypeId).Value;

            var mg = ItemTypes.GetMarketGroup(it);
            var mgs = MarketGroups.GetParents(mg.Value).ToList();

            mgs.Should().HaveCountGreaterThan(0);
        }
    }
}
