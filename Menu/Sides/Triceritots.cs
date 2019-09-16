using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        public Triceritots()
        {
                this.Price = 0.99;
                this.Calories = 352;

            
                this.Price = 1.45;
                this.Calories = 410;
            
                this.Price = 1.95;
                this.Calories = 590;
            


           
         }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Breading", "Vegtable Oil" };
                return ingredients;
            }
        }
    }

}

