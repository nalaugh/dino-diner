using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        private Size size = Size.Small;
        /// <summary>
        /// this is jsut water unless the cutemer wants a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Small:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// enter the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
              
                return ingredients;
            }
        }
        /// <summary>
        /// constructs the water and sets the default price and Calories
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;

        }

        /// <summary>
        /// this adds the lemon
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
        public override string ToString()
        {
            string  s  =  size + " Water";
            return s;
        }
    }
}
