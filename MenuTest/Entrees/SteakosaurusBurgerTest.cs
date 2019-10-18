using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldbunShouldNotifyofSpecialPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            });
        }
        [Fact]
        public void HoldpickleShouldNotifyofSpecialPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            });
        }
        [Fact]
        public void HoldpKetchupShouldNotifyofSpecialPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            });
        }
        [Fact]
        public void HoldpMustardShouldNotifyofSpecialPropertyChange()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            });
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }
        [Fact]
        public void SHouldhaveEmptySpaciallistByDefault()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
            Assert.Empty(bw.Special);
        }
        [Fact]
        public void ShouldhaveholdBunInSpecail()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Bun", item);
            });
        }
        [Fact]
        public void ShouldhaveholdKetchupInSpecail()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
            bw.HoldKetchup();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Ketchup", item);
            });
        }
        [Fact]
        public void ShouldhaveholdMustardInSpecail()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
            bw.HoldMustard();
            Assert.Collection<string>(bw.Special, item =>
            {
                Assert.Equal("Hold Mustard", item);
            });
        }
        [Fact]
        public void ShouldholdPicklesInSpecail()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.Collection<string>(sb.Special,
                item =>
                {
                    Assert.Equal("Hold Pickles", item);
                }

                );
        }
        [Fact]
        public void ShouldhaveholdAllInSpecail()
        {
            SteakosaurusBurger bw = new SteakosaurusBurger();
            bw.HoldBun();
            bw.HoldKetchup();
            bw.HoldMustard();
            bw.HoldPickle();
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
            }
            );
        }
    }

}
