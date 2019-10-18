using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }
        [Fact]
        public void HoldpMustardShouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMustard();
            });
        }
        [Fact]
        public void HoldpbundShouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldBun();
            });
        }
        [Fact]
        public void HoldpKetchupdShouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldKetchup();
            });
        }
        [Fact]
        public void HoldpLettuceShouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldLettuce();
            });
        }
        [Fact]
        public void HoldpMayodShouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldMayo();
            });
        }
        [Fact]
        public void HoldpOnionShouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldOnion();
            });
        }
        [Fact]
        public void HoldpickleshouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldPickle();
            });
        }
        [Fact]
        public void HoldTomatosShouldNotifyofSpecialPropertyChange()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.PropertyChanged(trex, "Special", () =>
            {
                trex.HoldTomato();
            });
        }

        [Fact]
        public void SHouldhaveEmptySpaciallistByDefault()
        {
            TRexKingBurger bw = new TRexKingBurger();
            Assert.Empty(bw.Special);
        }
        [Fact]
        public void ShouldhaveholdBunInSpecail()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }
        [Fact]
        public void ShouldhaveholdKetchupInSpecail()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldKetchup();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }
        [Fact]
        public void ShouldhaveholdMustardInSpecail()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldMustard();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }
        [Fact]
        public void ShouldholdPicklesInSpecial()
        {
            TRexKingBurger sb = new TRexKingBurger();
            sb.HoldPickle();
            Assert.Collection<string>(sb.Special,
                item =>
                {
                    Assert.Equal("Hold Pickles", item);
                }

                );
        }
        [Fact]
        public void ShouldholdLettuceInSpecial()
        {
            TRexKingBurger sb = new TRexKingBurger();
            sb.HoldLettuce();
            Assert.Collection<string>(sb.Special,
                item =>
                {
                    Assert.Equal("Hold Lettuce", item);
                }

                );
        }
        [Fact]
        public void ShouldholdMayoInSpecial()
        {
            TRexKingBurger sb = new TRexKingBurger();
            sb.HoldMayo();
            Assert.Collection<string>(sb.Special,
                item =>
                {
                    Assert.Equal("Hold Mayo", item);
                }

                );
        }
        [Fact]
        public void ShouldholdOnionInSpecial()
        {
            TRexKingBurger sb = new TRexKingBurger();
            sb.HoldOnion();
            Assert.Collection<string>(sb.Special,
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                }

                );
        }
        [Fact]
        public void ShouldholdTomotosInSpecial()
        {
            TRexKingBurger sb = new TRexKingBurger();
            sb.HoldTomato();
            Assert.Collection<string>(sb.Special,
                item =>
                {
                    Assert.Equal("Hold Tomatos", item);
                }

                );
        }
        [Fact]
        public void ShouldhaveholdAllInSpecail()
        {
            TRexKingBurger bw = new TRexKingBurger();
            bw.HoldBun();
            bw.HoldKetchup();
            bw.HoldMustard();
            bw.HoldPickle();
            bw.HoldTomato();
            bw.HoldMayo();
            bw.HoldOnion();
            bw.HoldLettuce();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            },
            item =>
            {
                Assert.Equal("Hold Pickles", item);
            },
            item =>
            {
                Assert.Equal("Hold Ketchup", item);
            },
            item =>
            {
                Assert.Equal("Hold Mustard", item);
            },
            item =>
            {
                Assert.Equal("Hold Lettuce", item);
            },
            item =>
            {
                Assert.Equal("Hold Onions", item);
            },
            item =>
            {
                Assert.Equal("Hold Tomatos", item);
            },
            item =>
            {
                Assert.Equal("Hold Mayo", item);
            }
            );
        }

    }

}
