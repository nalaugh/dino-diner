using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
       // The correct default price, calories, ice, size, and SpaceForCream properties.
       //2.The correct price and calories after changing to small, medium, and large sizes.
       //3.That invoking AddIce() results in the Ice properjv being true
       //4.That invoking LeaveSpaceForCream() results in the SpaceForCream properjv being true.
       //5.The correct ingredients are given.





        /// <summary>
        /// Check the default Price
        /// </summary>
        [Fact]
        public void DefaultPrice()
        {
            JurrassicJava jv = new JurrassicJava();
            Assert.Equal<double>(0.59, jv.Price);
        }
       /// <summary>
       /// CHecks the Default Calories 
       /// </summary>
        [Fact]
        public void DefaultCalories()
        {
            JurrassicJava jv = new JurrassicJava();
            Assert.Equal<uint>(2, jv.Calories);
        }
        /// <summary>
        /// Checks the Default Ice
        /// </summary>
        public void DefaultIce()
        {
            JurrassicJava jv = new JurrassicJava();
            Assert.False(jv.Ice);
        }
        /// <summary>
        /// Checks the Defailt Ice
        /// </summary>
        public void DefaultSize()
        {
            JurrassicJava jv = new JurrassicJava();
            Assert.Equal<Size>(Size.Small, jv.Size);
        }
        /// <summary>
        /// Checks the default if there is room for cream
        /// </summary>
        public void DefaultLeaveRoom()
        {
            JurrassicJava jv = new JurrassicJava();
            Assert.False(jv.RoomFOrCream);
        }



        /// <summary>
        /// Checks the price of a small drink
        /// </summary>
        [Fact]
        public void SmallPrice()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Medium;
            jv.Size = Size.Small;
            Assert.Equal<double>(0.59, jv.Price);
        }
        /// <summary>
        /// CHecks the calories of a small drink
        /// </summary>
        [Fact]
        public void SmallCalories()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Medium;
            jv.Size = Size.Small;
            Assert.Equal<uint>(2, jv.Calories);
        }

        /// <summary>
        /// Checks the price of a Medium drink
        /// </summary>
        [Fact]
        public void MediumPrice()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Medium;
            Assert.Equal<double>(0.99, jv.Price);
        }
        /// <summary>
        /// CHecks the calories of a Medium  drink
        /// </summary>
        [Fact]
        public void MediumCalories()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Medium;
            Assert.Equal<uint>(4, jv.Calories);
        }
        /// <summary>
        /// Checks the price of a Large drink
        /// </summary>
        [Fact]
        public void LargePrice()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Large;
            Assert.Equal<double>(1.49, jv.Price);
        }
        /// <summary>
        /// CHecks the calories of a Large drink
        /// </summary>
        [Fact]
        public void LargeCalories()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Large;
            Assert.Equal<uint>(8, jv.Calories);
        }

        /// <summary>
        /// Checks if the Lemon is addded
        /// </summary>
        [Fact]
        public void Addice()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.AddIce();
            Assert.True(jv.Ice);
        }

        /// <summary>
        /// Leaves rom for Cream
        /// </summary>
        [Fact]
        public void Leaveroom()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.RoomForCream();
            Assert.True(jv.RoomFOrCream);
        }


       
        /// <summary>
        /// CHecks the default ingedience
        /// </summary>
        [Fact]
        public void ShouldGiveIngredianceAddSweet()
        {
            JurrassicJava jv = new JurrassicJava();
            List<string> ingredients = jv.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);

        }


    }
}
