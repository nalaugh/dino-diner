using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
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
        public void DefaultPrice()
        {
            Tyrannotea ty = new Tyrannotea();
            Assert.Equal<double>(0.99, ty.Price);
        }
        /// <summary>
        /// Check the default calories
        /// </summary>
        [Fact]
        public void DefaultCalories()
        {
            Tyrannotea ty = new Tyrannotea();
            Assert.Equal<uint>(8, ty.Calories);
        }
       /// <summary>
       /// CHecks the Default Ice
       /// </summary>
        public void DefaultIce()
        {
            Tyrannotea ty = new Tyrannotea();
            Assert.True(ty.Ice);
        }
        /// <summary>
        /// Checks the deafult size
        /// </summary>
        public void DefaultSize()
        {
            Tyrannotea ty = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, ty.Size);
        }
        //Default Lemon
        public void DefaultLemon()
        {
            Tyrannotea ty = new Tyrannotea();
            Assert.False(ty.Lemon);
        }
        //Default Sweet
        public void DefaultSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            Assert.False(ty.Sweet);
        }


        //set price for small
        [Fact]
        public void SmallPrice()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
            Assert.Equal<double>(0.99, ty.Price);
        }
        //set small Calories
        [Fact]
        public void SmallCalories()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
            Assert.Equal<uint>(8, ty.Calories);
        }

        //set price for Medium
        [Fact]
        public void MediumPrice()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            Assert.Equal<double>(1.49, ty.Price);
        }
        //set Medium Calories
        [Fact]
        public void MediumCalories()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            Assert.Equal<uint>(16, ty.Calories);
        }
        //set price for Large
        [Fact]
        public void LargePrice()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            Assert.Equal<double>(1.99, ty.Price);
        }
        //set Large Calories
        [Fact]
        public void LargeCalories()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            Assert.Equal<uint>(32, ty.Calories);
        }

        //set price for small sweet
        [Fact]
        public void SmallPriceSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
           
            Assert.Equal<double>(0.99*2, ty.Price);
        }
        //set small Calories Sweet
        [Fact]
        public void SmallCaloriesSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
          
            Assert.Equal<uint>(8*2, ty.Calories);
        }

        //set price for Medium Sweet
        [Fact]
        public void MediumPriceSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
           
            Assert.Equal<double>(1.49*2, ty.Price);
        }
        //set Medium Calories Sweet
        [Fact]
        public void MediumCaloriesSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
         
            Assert.Equal<uint>(16*2, ty.Calories);
        }
        //set price for Large Sweet
        [Fact]
        public void LargePriceSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Large;
         
            Assert.Equal<double>(1.99*2, ty.Price);
        }
        //set Large Calories Sweet
        [Fact]
        public void LargeCaloriesSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Large;
            Assert.Equal<uint>(32*2, ty.Calories);
        }


        //Add Lemon
        [Fact]
        public void AddLemon()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.AddLemon(); 
        }




        //Holde ice test
        [Fact]
        public void Holdice()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.HoldIce();
            Assert.False(ty.Ice);
        }


        //set price for small swap
        [Fact]
        public void SmallPriceSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(0.99, ty.Price);
        }
        //set small Calories swap
        [Fact]
        public void SmallCaloriesSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<uint>(8, ty.Calories);
        }

        //set price for Medium Swap
        [Fact]
        public void MediumPriceSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(1.49, ty.Price);
        }
        //set Medium Calories Swap
        [Fact]
        public void MediumCaloriesSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<uint>(16, ty.Calories);
        }
        //set price for Large Swap
        [Fact]
        public void LargePriceSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(1.99, ty.Price);
        }
        //set Large Calories Swap
        [Fact]
        public void LargeCaloriesSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<uint>(32, ty.Calories);
        }


        //test Ingredence
        [Fact]
        public void ShouldGiveIngrediance()
        {
            Tyrannotea ty = new Tyrannotea();
            List<string> ingredients = ty.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);

        }

        //test Ingredence add Lemon
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
        //test Ingredence add 
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

    }
}
