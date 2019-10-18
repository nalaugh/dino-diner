using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {
        //1.The ability to set each possible flavor
        //2.The correct default price, calories, ice, and size
        //3.The correct price and calories after changing to small, medium, and large sizes.
        //4.That invoking HoldIce() results in the Ice property being false.
        //5. The correct ingredients are given
        
            [Theory]
            [InlineData(SodasaurusFlavor.Cherry)]
        [InlineData(SodasaurusFlavor.Chocolate)]
        [InlineData(SodasaurusFlavor.Cola)]
        [InlineData(SodasaurusFlavor.Lime)]
        [InlineData(SodasaurusFlavor.Orange)]
        [InlineData(SodasaurusFlavor.RootBeer)]
        [InlineData(SodasaurusFlavor.Vanilla)]

        public void ShouldBeAbleToSetFlavor(SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = flavor;
            Assert.Equal<SodasaurusFlavor>(flavor, soda.Flavor);
        }

        
        /// <summary>
        /// Check the defualt Price
        /// </summary>
        [Fact]
        public void ShouldGiveDefaultSetting()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<uint>(112, soda.Calories);
            Assert.True(soda.Ice);
            Assert.Equal<Size>(Size.Small, soda.Size);
        }


        /// <summary>
        /// Checks the price of a small drink
        /// </summary>
        [Fact]
        public void ShouldGiveSmallSoda()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Medium;
            sode.Size = Size.Small;
            Assert.Equal<double>(1.50, sode.Price);
            Assert.Equal<uint>(112, sode.Calories);
        }

        /// <summary>
        /// Checks the price of a Medium drink
        /// </summary>
        [Fact]
        public void ShouldGiveMediumSOda()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Medium;
            Assert.Equal<double>(2.00, sode.Price);
            Assert.Equal<uint>(156, sode.Calories);
        }

        /// <summary>
        /// Checks the price of a Large drink
        /// </summary>
        [Fact]
        public void ShouldGiveLargeSoda()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Large;
            Assert.Equal<double>(2.50, sode.Price);
            Assert.Equal<uint>(208, sode.Calories);
        }

        /// <summary>
        /// Checks the see that the Ice was held 
        /// </summary>
        [Fact]
        public void ShouldHoldice()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        /// <summary>
        /// CHecks defualt ingredience 
        /// </summary>
        [Fact]
        public void ShouldGiveIngrediance()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
           
        }
        [Fact]
        public void SHouldhaveEmptySpaciallistByDefault()
        {
            Sodasaurus ty = new Sodasaurus();
            Assert.Empty(ty.Special);
        }
        [Fact]
        public void ShouldShowPriceSmallPropertyChange()
        {
            Sodasaurus jv = new Sodasaurus();
            jv.Size = Size.Small;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Small;
            });
        }
        [Fact]
        public void ShouldShowPriceMediumPropertyChange()
        {
            Sodasaurus jv = new Sodasaurus();
            jv.Size = Size.Medium;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Medium;
            });
        }
        [Fact]
        public void ShouldShowPriceLargePropertyChange()
        {
            Sodasaurus jv = new Sodasaurus();
            jv.Size = Size.Large;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Large;
            });
        }


    }
}
