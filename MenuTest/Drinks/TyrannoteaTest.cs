using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
   public class TyrannoteaTest
    {
        //1. The correct default price, calories, ice, size, lemon, and sweet properties.
        //2. The correct price and calories after changing to small, medium, and large sizes.
        //3. That invoking HoldIce() results in the Ice property being false
        //4. That invoking AddLemon() sets results in the Lemon property being true.
        //5. That setting the sweet property to true results in the right calories for each size
        //6. That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        //7. The correct ingredients are given.

        /// <summary>
        /// Checks the Default price
        /// </summary>
        [Fact]
        public void ShouldGiveDefaultSetting()
        {
            Tyrannotea ty = new Tyrannotea();
            Assert.Equal<double>(0.99, ty.Price);
            Assert.Equal<uint>(8, ty.Calories);
            Assert.True(ty.Ice);
            Assert.Equal<Size>(Size.Small, ty.Size);
            Assert.False(ty.Lemon);
            Assert.False(ty.Sweet);
        }
        /// <summary>
        /// Checks the price for small
        /// </summary>
        [Fact]
        public void ShouldGiveSmallTea()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
            Assert.Equal<double>(0.99, ty.Price);
            Assert.Equal<uint>(8, ty.Calories);
        }


        /// <summary>
        /// Checks  Medium
        /// </summary>
        [Fact]
        public void ShouldGiveMediumTea()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            Assert.Equal<double>(1.49, ty.Price);
            Assert.Equal<uint>(16, ty.Calories);
        }

        /// <summary>
        /// Checks the price for Large
        /// </summary>
        [Fact]
        public void ShouldGiveLargeTea()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            Assert.Equal<double>(1.99, ty.Price);
            Assert.Equal<uint>(32, ty.Calories);
        }


        /// <summary>
        /// Checks the price after set to sweet small
        /// </summary>
        [Fact]
        public void ShouldGiveSmallSweetTea()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
           
            Assert.Equal<double>(0.99*2, ty.Price);
            Assert.Equal<uint>(8 * 2, ty.Calories);
        }

        /// <summary>
        /// Checks the price and Calories after set to sweet Medium 
        /// </summary>
        [Fact]
        public void ShouldGiveMediumeSweetTea()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
           
            Assert.Equal<double>(1.49*2, ty.Price);

            Assert.Equal<uint>(16 * 2, ty.Calories);
        }
        /// <summary>
        /// Checks the price after set to sweet Large
        /// </summary>
        [Fact]
        public void ShouldGiveLargeSweetTea()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Large;
         
            Assert.Equal<double>(1.99*2, ty.Price);
            Assert.Equal<uint>(32 * 2, ty.Calories);
        }
        /// <summary>
        /// CHecks to see that Lemon is set to true 
        /// </summary>
        [Fact]
        public void ShouldGiveLemon()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.AddLemon();
            Assert.True(ty.Lemon);
        }
        /// <summary>
        /// CHeck to see if HoldICe sets Ice to false
        /// </summary>
        [Fact]
        public void ShouldHoldice()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.HoldIce();
            Assert.False(ty.Ice);
        }
        /// <summary>
        /// Checks price after reset small
        /// </summary>
        [Fact]
        public void ShouldGiveSmallSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(0.99, ty.Price);
            Assert.Equal<uint>(8, ty.Calories);
        }

        /// <summary>
        /// Checks price after reset Medium
        /// </summary>
        [Fact]
        public void ShouldGiveMediumSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(1.49, ty.Price);
            Assert.Equal<uint>(16, ty.Calories);

        }

        /// <summary>
        /// Checks price after reset Large
        /// </summary>
        [Fact]
        public void ShouldGiveLargeSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(1.99, ty.Price);
            Assert.Equal<uint>(32, ty.Calories);
        }

       /// <summary>
       /// Check default ingredence
       /// </summary>
        [Fact]
        public void ShouldGiveIngrediance()
        {
            Tyrannotea ty = new Tyrannotea();
            List<string> ingredients = ty.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);

        }

        /// <summary>
        /// checks ingredients after adding Lemon
        /// </summary>
        [Fact]
        public void ShouldGiveIngredianceAddLemon()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.AddLemon();
            List<string> ingredients = ty.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Lemon", ingredients);
            Assert.Equal<int>(3, ingredients.Count);

        }
        /// <summary>
        /// Checks ingredients after adding Sweet 
        /// </summary>
        [Fact]
        public void ShouldGiveIngredianceAddSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            List<string> ingredients = ty.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Contains<string>("Cane Suger", ingredients);
            Assert.Equal<int>(3, ingredients.Count);

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
        public void ShouldhaveAddLemonInSpecail()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.AddLemon();
            Assert.Collection<string>(ty.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            });
        }
        [Fact]
        public void ShouldhaveholdIceAndLemonInSpecail()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.AddLemon();
            ty.HoldIce();
           

            Assert.Collection<string>(ty.Special, item =>
            {
                Assert.Equal("Add Lemon", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            });
        }
        [Fact]
        public void ShouldShowPriceSmallPropertyChange()
        {
            Tyrannotea jv = new Tyrannotea();
            jv.Size = Size.Small;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Small;
            });
        }
        [Fact]
        public void ShouldShowPriceMediumPropertyChange()
        {
            Tyrannotea jv = new Tyrannotea();
            jv.Size = Size.Medium;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Medium;
            });
        }
        [Fact]
        public void ShouldShowPriceLargePropertyChange()
        {
            Tyrannotea jv = new Tyrannotea();
            jv.Size = Size.Large;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Large;
            });
        }

    }
}
