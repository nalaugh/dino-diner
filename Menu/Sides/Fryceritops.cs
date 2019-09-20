using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        private Size size;
        /// <summary>
        /// Setting the size based on the size of the side
        /// this is done through a switch overriding the previously set priced and calories.
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;    
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// this constucts object seting the default sizes
        /// </summary>
        public Fryceritops()
        {

            this.Price = 0.99;
            this.Calories = 222;
        }
        /// <summary>
        /// this overides the ingresnts
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

    }

}

