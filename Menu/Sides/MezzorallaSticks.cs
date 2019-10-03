using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
   public class MezzorellaSticks: Side
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;

                }


            }
            get
            {
                return size;
            }
        }

        public MezzorellaSticks()
        {
           
                this.Price = 0.99;
                this.Calories = 540;
           
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
                return ingredients;
            }
        }
        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }
    }
}
