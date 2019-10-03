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
        public void DefaultPrice()
        {
            Water wtr = new Water();
            Assert.Equal<double>(0.10, wtr.Price);
        }
        /// <summary>
        /// Checks Default Calories 
        /// </summary>
        [Fact]
        public void DefaultCalories()
        {
            Water wtr = new Water();
            Assert.Equal<uint>(0, wtr.Calories);
        }
        /// <summary>
        /// Check default Ice
        /// </summary>
        public void DefaultIce()
        {
            Water wtr = new Water();
            Assert.True(wtr.Ice);
        }
        /// <summary>
        /// Check default Size
        /// </summary>
        public void DefaultSize()
        {
            Water wtr = new Water();
            Assert.Equal<Size>(Size.Small, wtr.Size);
        }
        /// <summary>
        /// Check dafulat Lemon
        /// </summary>
        public void DefaultLemon()
        {
            Water wtr = new Water();
            Assert.False(wtr.Lemon);
        }



        /// <summary>
        /// Checks the price of a small drink
        /// </summary>
        [Fact]
        public void SmallPrice()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            wtr.Size = Size.Small;
            Assert.Equal<double>(0.10, wtr.Price);
        }
        /// <summary>
        /// CHecks the calories of a small drink
        /// </summary>f
        [Fact]
        public void SmallCalories()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            wtr.Size = Size.Small;
            Assert.Equal<uint>(0, wtr.Calories);
        }

        /// <summary>
        /// Checks the price of a Medien drink
        /// </summary>
        [Fact]
        public void MediumPrice()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            Assert.Equal<double>(0.10, wtr.Price);
        }
        /// <summary>
        /// CHecks the calories of a medium drink
        /// </summary>
        [Fact]
        public void MediumCalories()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            Assert.Equal<uint>(0, wtr.Calories);
        }
        /// <summary>
        /// Checks the price of a Large drink
        /// </summary>
        [Fact]
        public void LargePrice()
        {
            Water wtr = new Water();
            wtr.Size = Size.Large;
            Assert.Equal<double>(0.10, wtr.Price);
        }
        /// <summary>
        /// CHecks the calories of a Large drink
        /// </summary>
        [Fact]
        public void LargeCalories()
        {
            Water wtr = new Water();
            wtr.Size = Size.Large;
            Assert.Equal<uint>(0, wtr.Calories);
        }

        /// <summary>
        /// Check to see if hold works
        /// </summary>
        [Fact]
        public void Holdice()
        {
            Water wtr = new Water();
            wtr.HoldIce();
            Assert.False(wtr.Ice);
        }

        /// <summary>
        /// checks to see if add Lemon works 
        /// </summary>
        [Fact]
        public void AddLemon()
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


    }
}
