using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            if (this.Size == Size.Small)
            {
                this.Price = 0.99;
                this.Calories = 222;
            }
            else if (this.Size == Size.Medium)
            {
                this.Price = 1.45;
                this.Calories = 365;
            }
            else if (this.Size == Size.Large)
            {
                this.Price = 1.95;
                this.Calories = 480;
            }
        }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegtable Oil" };
                return ingredients;
            }
        }
    }

}

