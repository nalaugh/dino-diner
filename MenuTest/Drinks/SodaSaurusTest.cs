using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {
        //The ability to set each possible flavor
        //2.The correct default price, calories, ice, and size
        //3.The correct price and calories after changing to small, medium, and large sizes.
        //4.That invoking HoldIce() results in the Ice property being false.
        //5. The correct ingredients are given

        //set flavor to cola
        [Fact]
        public void shouldBeAbletoSetFlavorCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }
        //set flavor to Cherry
        [Fact]
        public void shouldBeAbletoSetFlavorCharry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }
        //set flavor to Lime
        [Fact]
        public void shouldBeAbletoSetFlavorLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }
        //set flavor to Vanilla
        [Fact]
        public void shouldBeAbletoSetFlavorVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }
        //set flavor to Orange
        [Fact]
        public void shouldBeAbletoSetFlavorOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }
        //set flavor to Chocolate
        [Fact]
        public void shouldBeAbletoSetFlavorChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }
        //set flavor to RootBeer
        [Fact]
        public void shouldBeAbletoSetFlavorRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }
       
        
        //set default price
        [Fact]
        public void DefaultPrice()
        {
            Sodasaurus sode = new Sodasaurus();
            Assert.Equal<double>(1.50, sode.Price);
        }
        //set default Calories
        [Fact]
        public void DefaultCalories()
        {
            Sodasaurus sode = new Sodasaurus();
            Assert.Equal<uint>(112, sode.Calories);
        }

        //Holde ice default
        [Fact]
        public void Holdicedefault()
        {
            Sodasaurus soda = new Sodasaurus();

            Assert.True(soda.Ice);

        }
        //default size
        public void DefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }


        //set price for small
        [Fact]
        public void SmallPrice()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Medium;
            sode.Size = Size.Small;
            Assert.Equal<double>(1.50, sode.Price);
        }
        //set small Calories
        [Fact]
        public void SmallCalories()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Medium;
            sode.Size = Size.Small;
            Assert.Equal<uint>(112, sode.Calories);
        }

        //set price for Medium
        [Fact]
        public void MediumPrice()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Medium;
            Assert.Equal<double>(2.00, sode.Price);
        }
        //set Medium Calories
        [Fact]
        public void MediumCalories()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Medium;
            Assert.Equal<uint>(156, sode.Calories);
        }
        //set price for Large
        [Fact]
        public void LargePrice()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Large;
            Assert.Equal<double>(2.50, sode.Price);
        }
        //set Large Calories
        [Fact]
        public void LargeCalories()
        {
            Sodasaurus sode = new Sodasaurus();
            sode.Size = Size.Large;
            Assert.Equal<uint>(208, sode.Calories);
        }
        //Holde ice test
        [Fact]
        public void Holdice()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        //test Ingredence
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
       
    }
}
