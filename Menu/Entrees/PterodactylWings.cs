using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
	{
        /// <summary>
        /// getter for price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// geter for calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// sets the ingredentc list
        /// </summary>
        public List<string> Ingredients
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
	}
}
