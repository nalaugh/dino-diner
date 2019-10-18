﻿using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class TriceritotsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal(0.99, tt.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<uint>(352, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Triceritots tt = new Triceritots();
            Assert.Contains<string>("Potato", tt.Ingredients);
            Assert.Contains<string>("Salt", tt.Ingredients);
            Assert.Contains<string>("Vegetable Oil", tt.Ingredients);
            Assert.Equal<int>(3, tt.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Triceritots tt = new Triceritots();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal(1.45, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(410, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tt.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal(1.95, tt.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<uint>(590, tt.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Triceritots tt = new Triceritots();
            tt.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tt.Size);
        }
        [Fact]
        public void SHouldhaveEmptySpaciallistByDefault()
        {
            Triceritots tt = new Triceritots();
            Assert.Empty(tt.Special);
        }
        [Fact]
        public void ShouldShowPriceSmallPropertyChange()
        {
            Triceritots jv = new Triceritots();
            jv.Size = Size.Small;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Small;
            });
        }
        [Fact]
        public void ShouldShowPriceMediumPropertyChange()
        {
            Triceritots jv = new Triceritots();
            jv.Size = Size.Medium;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Medium;
            });
        }
        [Fact]
        public void ShouldShowPriceLargePropertyChange()
        {
            Triceritots jv = new Triceritots();
            jv.Size = Size.Large;
            Assert.PropertyChanged(jv, "Price", () =>
            {
                jv.Size = Size.Large;
            });
        }
    }
}
