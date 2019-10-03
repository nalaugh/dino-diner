using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
        private Size size = Size.Small;
        /// <summary>
        /// overrides the price and the calories based on the size of the side
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 552;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        public Triceritots()
        {
                this.Price = 0.99;
                this.Calories = 352; 
         }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Vegetable Oil", "Salt" };
                return ingredients;
            }
        }
        public override string ToString()
        {
            return size + " Triceritots";
        }
    }

}

