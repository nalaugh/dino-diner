using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class WaterTest
    {


        /// <summary>
        /// Check default price 
        /// </summary>
        [Fact]
        public void ShouldGiveDefaultSettings()
        {
            Water wtr = new Water();
            Assert.Equal<double>(0.10, wtr.Price);
            Assert.Equal<uint>(0, wtr.Calories);
            Assert.True(wtr.Ice);
            Assert.Equal<Size>(Size.Small, wtr.Size);
            Assert.False(wtr.Lemon);
        }


        /// <summary>
        /// Checks the price of a small drink
        /// </summary>
        [Fact]
        public void ShouldGiveSmallWater()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            wtr.Size = Size.Small;
            Assert.Equal<double>(0.10, wtr.Price);
            Assert.Equal<uint>(0, wtr.Calories);
        }


        /// <summary>
        /// Checks the price of a Medien drink
        /// </summary>
        [Fact]
        public void ShouldGiveMediumWater()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            Assert.Equal<double>(0.10, wtr.Price);
            Assert.Equal<uint>(0, wtr.Calories);
        }


        /// <summary>
        /// Checks the price of a Large drink
        /// </summary>
        [Fact]
        public void ShouldGiveLargeWater()
        {
            Water wtr = new Water();
            wtr.Size = Size.Large;
            Assert.Equal<double>(0.10, wtr.Price);
            Assert.Equal<uint>(0, wtr.Calories);
        }


    /// <summary>
    /// Check to see if hold works
    /// </summary>
    [Fact]
        public void ShouldHoldice()
        {
            Water wtr = new Water();
            wtr.HoldIce();
            Assert.False(wtr.Ice);
        }

        /// <summary>
        /// checks to see if add Lemon works 
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Water wtr = new Water();
            wtr.AddLemon();

            Assert.True(wtr.Lemon);
        }



        /// <summary>
        /// Check ingredience works
        /// </summary>
        [Fact]
        public void ShouldGiveIngrediance()
        {
            Water wtr = new Water();
            List<string> ingredients = wtr.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Single(ingredients);

        }
        /// <summary>
        /// CHeck Ingredience after adding Lemon
        /// </summary>
        [Fact]
        public void ShouldGiveIngredianceLemon()
        {
            Water wtr = new Water();
            wtr.AddLemon();
            List<string> ingredients = wtr.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Equal<int>(2, ingredients.Count);

        }
        [Fact]
        public void SHouldhaveEmptySpaciallistByDefault()
        {
            Tyrannotea ty = new Tyrannotea();
            Assert.Empty(ty.Special);
        }
        [Fact]
        public void ShouldhaveholdIcedInSpecail()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.HoldIce();
            Assert.Collection<string>(ty.Special, item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }
        [Fact]
        public void ShouldhaveLeaveRoomInSpecail()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.AddLemon();
            Assert.Collection<string>(ty.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }
        [Fact]
        public void ShouldhaveholdPeanutButterdandJellyInSpecail()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.HoldIce();
            ty.AddLemon();

            Assert.Collection<string>(ty.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }


    }
}
