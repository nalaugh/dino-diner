using System.Collections.Generic;

namespace DinoDiner.Menu
{
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

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
