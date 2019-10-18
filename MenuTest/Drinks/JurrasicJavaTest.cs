using System;
using System.Collections.Generic;
using System.Text;
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
        /// Check the default for everything
        /// </summary>
        [Fact]
        public void ShouldGiveDefaultSetting()
        {
            JurrassicJava jv = new JurrassicJava();
            Assert.Equal<double>(0.59, jv.Price);
            Assert.Equal<uint>(2, jv.Calories);
            Assert.False(jv.Ice);
            Assert.Equal<Size>(Size.Small, jv.Size);
            Assert.False(jv.RoomFOrCream);
            List<string> ingredients = jv.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        /// <summary>
        /// Checks the price and Calories of a small drink
        /// </summary>
        [Fact]
        public void ShouldGiveSmallJava()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Medium;
            jv.Size = Size.Small;
            Assert.Equal<double>(0.59, jv.Price);
            Assert.Equal<uint>(2, jv.Calories);
        }
       
        /// <summary>
        /// Checks of a Medium drink
        /// </summary>
        [Fact]
        public void ShouldGiveMediumJava()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Medium;
            Assert.Equal<double>(0.99, jv.Price);
            Assert.Equal<uint>(4, jv.Calories);
        }
      
        /// <summary>
        /// Checks a Large drink
        /// </summary>
        [Fact]
        public void ShouldGiveLargeJava()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Large;
            Assert.Equal<double>(1.49, jv.Price);
            Assert.Equal<uint>(8, jv.Calories);
        }

        /// <summary>
        /// Checks if the Lemon is addded
        /// </summary>
        [Fact]
        public void ShouldAddice()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.AddIce();
            Assert.True(jv.Ice);
        }

        /// <summary>
        /// Leaves rom for Cream
        /// </summary>
        [Fact]
        public void ShouldLeaveroom()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.RoomForCream();
            Assert.True(jv.RoomFOrCream);
        }
        [Fact]
        public void SHouldhaveEmptySpaciallistByDefault()
        {
            JurrassicJava jv = new JurrassicJava();
            Assert.Empty(jv.Special);
        }
        [Fact]
        public void ShouldhaveholdIcedInSpecail()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.AddIce();
            Assert.Collection<string>(jv.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            });
        }
        [Fact]
        public void ShouldhaveLeaveRoomInSpecail()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.RoomForCream();
            Assert.Collection<string>(jv.Special, item =>
            {
                Assert.Equal("Leave Room for Cream", item);
            });
        }
        [Fact]
        public void ShouldhaveholdIceAndRoomInSpecail()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.AddIce();
            jv.RoomForCream();

            Assert.Collection<string>(jv.Special, item =>
            {
                Assert.Equal("Add Ice", item);
            },
            item =>
            {
                Assert.Equal("Leave Room for Cream", item);
            });
        }
        [Fact]
        public void ShouldShowPriceSmallPropertyChange()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Small;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Small;
            });
        }
        [Fact]
        public void ShouldShowPriceMediumPropertyChange()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Medium;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Medium;
            });
        }
        [Fact]
        public void ShouldShowPriceLargePropertyChange()
        {
            JurrassicJava jv = new JurrassicJava();
            jv.Size = Size.Large;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Large;
            });
        }


    }
}
