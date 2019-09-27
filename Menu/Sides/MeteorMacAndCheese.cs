using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
   public class MeteorMacAndCheese: Side
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
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// constructs the side and sets the 
        /// </summary>
        public MeteorMacAndCheese()
        {           
                this.Price = 0.99;
                this.Calories = 420;           
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
                return ingredients;
            }
        }
    }

}

