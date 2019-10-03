﻿using System;
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

        /// <summary>
        /// checks the faloring
        /// </summary>
        [Fact]
        public void shouldBeAbletoSetFlavorCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }
        /// <summary>
        /// checks the faloring
        /// </summary>
        [Fact]
        public void shouldBeAbletoSetFlavorCharry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }
        /// <summary>
        /// checks the faloring
        /// </summary>
        [Fact]
        public void shouldBeAbletoSetFlavorLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }
        /// <summary>
        /// checks the faloring
        /// </summary>
        [Fact]
        public void shouldBeAbletoSetFlavorVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }
        /// <summary>
        /// checks the faloring
        /// </summary>
        [Fact]
        public void shouldBeAbletoSetFlavorOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }
        /// <summary>
        /// checks the faloring
        /// </summary>
        [Fact]
        public void shouldBeAbletoSetFlavorChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }
        /// <summary>
        /// checks the faloring
        /// </summary>
        [Fact]
        public void shouldBeAbletoSetFlavorRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }
       
        
        /// <summary>
        /// Check the defualt Price
        /// </summary>
        [Fact]
        public void DefaultPrice()
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
        public void SmallPrice()
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
        public void MediumPrice()
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
        public void LargePrice()
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
        public void Holdice()
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
       
    }
}