using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
   public class MeteorMacAndCheese: Side
    {
        public MeteorMacAndCheese()
        {
            if (this.Size == Size.Small)
            {
                this.Price = 0.99;
                this.Calories = 420;
            }
            else if (this.Size == Size.Medium)
            {
                this.Price = 1.45;
                this.Calories = 490;
            }
            if (this.Size == Size.Large)
            {
                this.Price = 1.95;
                this.Calories = 520;
            }
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausuage" };
                return ingredients;
            }
        }
    }

}

