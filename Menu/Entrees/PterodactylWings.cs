/*  PterodactylWings
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Pterodactyl Wings entree. 
    /// Its price is $7.21, it contains 318 calories, and its ingredients are:  Chicken and Wing Sauce.
    /// </summary>
    public class PterodactylWings : Entree
	{

        /// <summary>
        /// overrides the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
        /// <summary>
        /// overrids the toString method
        /// </summary>
        /// <returns>the name of the item</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
