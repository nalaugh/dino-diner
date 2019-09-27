using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class WaterTest
    {


        //set default price
        [Fact]
        public void DefaultPrice()
        {
            Water wtr = new Water();
            Assert.Equal<double>(0.10, wtr.Price);
        }
        //set default Calories
        [Fact]
        public void DefaultCalories()
        {
            Water wtr = new Water();
            Assert.Equal<uint>(0, wtr.Calories);
        }
        //Default Ice
        public void DefaultIce()
        {
            Water wtr = new Water();
            Assert.True(wtr.Ice);
        }
        //Defalt size
        public void DefaultSize()
        {
            Water wtr = new Water();
            Assert.Equal<Size>(Size.Small, wtr.Size);
        }
        //Default Lemon
        public void DefaultLemon()
        {
            Water wtr = new Water();
            Assert.False(wtr.Lemon);
        }



        //set price for small
        [Fact]
        public void SmallPrice()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            wtr.Size = Size.Small;
            Assert.Equal<double>(0.10, wtr.Price);
        }
        //set small Calories
        [Fact]
        public void SmallCalories()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            wtr.Size = Size.Small;
            Assert.Equal<uint>(0, wtr.Calories);
        }

        //set price for Medium
        [Fact]
        public void MediumPrice()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            Assert.Equal<double>(0.10, wtr.Price);
        }
        //set Medium Calories
        [Fact]
        public void MediumCalories()
        {
            Water wtr = new Water();
            wtr.Size = Size.Medium;
            Assert.Equal<uint>(0, wtr.Calories);
        }
        //set price for Large
        [Fact]
        public void LargePrice()
        {
            Water wtr = new Water();
            wtr.Size = Size.Large;
            Assert.Equal<double>(0.10, wtr.Price);
        }
        //set Large Calories
        [Fact]
        public void LargeCalories()
        {
            Water wtr = new Water();
            wtr.Size = Size.Large;
            Assert.Equal<uint>(0, wtr.Calories);
        }

        //Add ice test
        [Fact]
        public void Holdice()
        {
            Water wtr = new Water();
            wtr.HoldIce();
            Assert.False(wtr.Ice);
        }

        //Add Lemon
        [Fact]
        public void AddLemon()
        {
            Water wtr = new Water();
            wtr.AddLemon();

            Assert.True(wtr.Lemon);
        }



        //test Ingredence
        [Fact]
        public void ShouldGiveIngrediance()
        {
            Water wtr = new Water();
            List<string> ingredients = wtr.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Single(ingredients);

        }
        //test Ingredence add Lemon
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
