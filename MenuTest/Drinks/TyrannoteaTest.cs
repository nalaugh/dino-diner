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
        public void DefaultPrice()
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
        public void SmallPrice()
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
        public void MediumPrice()
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
        public void LargePrice()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            Assert.Equal<double>(1.99, ty.Price);
            Assert.Equal<uint>(32, ty.Calories);
        }
        /// <summary>
        /// Checks the calories for Large
        /// </summary>
        [Fact]
        public void LargeCalories()
        {
            Tyrannotea ty = new Tyrannotea();

        }

        /// <summary>
        /// Checks the price after set to sweet small
        /// </summary>
        [Fact]
        public void SmallPriceSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
           
            Assert.Equal<double>(0.99*2, ty.Price);
        }
       /// <summary>
       /// CHecks the calories after set to sweet Small
       /// </summary>
        [Fact]
        public void SmallCaloriesSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
            ty.Size = Size.Small;
          
            Assert.Equal<uint>(8*2, ty.Calories);
        }

        /// <summary>
        /// Checks the price after set to sweet Medium 
        /// </summary>
        [Fact]
        public void MediumPriceSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
           
            Assert.Equal<double>(1.49*2, ty.Price);
        }
        /// <summary>
        /// CHecks the calories after set to sweet Medium
        /// </summary>
        [Fact]
        public void MediumCaloriesSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Medium;
         
            Assert.Equal<uint>(16*2, ty.Calories);
        }
        /// <summary>
        /// Checks the price after set to sweet Large
        /// </summary>
        [Fact]
        public void LargePriceSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Large;
         
            Assert.Equal<double>(1.99*2, ty.Price);
        }
        /// <summary>
        /// CHecks the calories after set to sweet Large
        /// </summary>
        [Fact]
        public void LargeCaloriesSweet()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Sweet = true;
            ty.Size = Size.Large;
            Assert.Equal<uint>(32*2, ty.Calories);
        }


        /// <summary>
        /// CHecks to see that Lemon is set to true 
        /// </summary>
        [Fact]
        public void AddLemon()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.AddLemon();
            Assert.True(ty.Lemon);
        }




        /// <summary>
        /// CHeck to see if HoldICe sets Ice to false
        /// </summary>
        [Fact]
        public void Holdice()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.HoldIce();
            Assert.False(ty.Ice);
        }


        /// <summary>
        /// Checks price after reset small
        /// </summary>
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
        /// <summary>
        /// Checks caloried after rest small
        /// </summary>
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

        /// <summary>
        /// Checks price after reset Medium
        /// </summary>
        [Fact]
        public void MediumPriceSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(1.49, ty.Price);
        }
        /// <summary>
        /// Checks caloried after rest Medium
        /// </summary>
        [Fact]
        public void MediumCaloriesSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Medium;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<uint>(16, ty.Calories);
        }
        /// <summary>
        /// Checks price after reset Large
        /// </summary>
        [Fact]
        public void LargePriceSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            ty.Sweet = true;
            ty.Sweet = false;
            Assert.Equal<double>(1.99, ty.Price);
        }
        /// <summary>
        /// Checks caloried after rest large
        /// </summary>
        [Fact]
        public void LargeCaloriesSwap()
        {
            Tyrannotea ty = new Tyrannotea();
            ty.Size = Size.Large;
            ty.Sweet = true;
            ty.Sweet = false;
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

    }
}
