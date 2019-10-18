using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class CretaceousComboTest
    {
        [Fact]
        public void ShouldhaveholdIceAndRoomInSpecail()
        {
            CretaceousCombo cb = new CretaceousCombo(new DinoNuggets());
            cb.Drinks.HoldIce();
           
           

            Assert.Collection<string>(cb.Special, item =>
            {
                Assert.Equal("Small Fryceritops", item);
            },
            item =>
            {
                Assert.Equal("Small Cola Sodasaurus", item);
            },
            item =>
            {
                Assert.Equal("Hold Ice", item);
            }
            );
        }
    }
}
