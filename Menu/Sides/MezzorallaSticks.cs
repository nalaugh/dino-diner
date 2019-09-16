using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
   public class MezzorellaSticks: Side
    {

        public MezzorellaSticks()
        {
            if (this.Size == Size.Small)
            {
                this.Price = 0.99;
                this.Calories = 540;
            }
            else if (this.Size == Size.Medium)
            {
                this.Price = 1.45;
                this.Calories = 610;
            }
            if (this.Size == Size.Large)
            {
                this.Price = 1.95;
                this.Calories = 720;
            }
        }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Cheese Product", "Breading", "Vegtable Oil" };
                return ingredients;
            }
        }
    }
}
