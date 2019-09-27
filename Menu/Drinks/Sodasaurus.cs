using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{

    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;

        private Size size = Size.Small;
        /// <summary>
        /// this set the flavor the the sode the the cutomer wants
        /// </summary>
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }
        /// <summary>
        /// Set the size of the drink
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// fills in the ingrediance
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Water", "Natural Flavors", "Cane Sugar"};
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a soda with default price and caloier
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
           
        }
    }

}
