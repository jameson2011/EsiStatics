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
        [InlineData(64)]
        public void MarketGroups_GetItemTypes_Returned(int id)
        {
            var mg = MarketGroups.GetMarketGroup(id).Value;

            var itemTypes = MarketGroups.GetItemTypes(mg).ToList();
            itemTypes.Count.Should().BeGreaterThan(0);
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

        [Fact]
        public void Categories_GetCategories_ReturnsNonEmpty()
        {
            var cats = Categories.GetCategories().ToList();

            cats.Should().NotHaveCount(0);
        }

        [Fact]
        public void Categories_GetCategory_ReturnsMatch()
        {
            var cats = Categories.GetCategories().ToList();

            var cats2 = cats.Select(c => Categories.GetCategory(c.Id))
                            .Where(c => c != null)
                            .Select(c => c.Value)
                            .ToList();

            cats2.Should().BeEquivalentTo(cats);
        }


        [Fact]
        public void Categories_GetGroups_ReturnsMatch()
        {
            var cats = Categories.GetCategories().ToList();

            var groups = cats.Where(c => c.Published).Select(Categories.GetGroups).ToList();

            foreach(var grp in groups)
            {
                
                grp.Count().Should().NotBe(0);
            }
        }


        [Fact]
        public void Groups_GetGroups_ReturnsNonEmpty()
        {
            var grps = Groups.GetGroups().ToList();

            grps.Should().NotHaveCount(0);
        }

        [Fact]
        public void Groups_GetGroup_ReturnsMatch()
        {
            var grps = Groups.GetGroups().ToList();

            var grps2 = grps.Select(g => Groups.GetGroup(g.Id))
                            .Where(c => c != null)
                            .Select(c => c.Value)
                            .ToList();

            grps2.Should().BeEquivalentTo(grps);
        }

        [Fact]
        public void Groups_GetCategory_AlwaysReturns()
        {
            var grps = Groups.GetGroups().ToList();
            
            var cats = grps.Select(Groups.GetCategory)
                            .ToList();

            grps.Count().Should().Be(cats.Count);
        }
    }
}
