/*  Sodasaurus
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent a Sodasaurus that inherits from the Drink class.  
    /// It should have an additional property of Flavor with type SodasaurusFlavor.  
    /// The price of a Sodasaurus is $1.50 (small), $2.00 (medium), and $2.50 (large).  
    /// Calories are 112 (small), 156 (medium), and 208 (large). 
    /// Its ingredients should be "Water", "Natural Flavors", and "Cane Sugar."
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// private varible of flavor
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// private veriable of size small
        /// </summary>
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
        /// <summary>
        /// overrides the ToString method 
        /// </summary>
        /// <returns>the size the flavor and the name of the item</returns>
        public override string ToString()
        {
            return size +" "+ Flavor + " Sodasaurus";
        }
    }

}
