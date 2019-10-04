/*  Brontowurst
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Brontowurst entree.  
    /// Its price is $5.36, it contains 498 calories, and its ingredients are: brautwurst, whole-wheat bun, peppers, and onions.  
    /// It should implement methods for holding the bun, peppers, and onions.
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// private verible of bun
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// private varible of peppers
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// private verible of Onions
        /// </summary>
        private bool Onions = true;

        /// <summary>
        /// sets the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingredients.Add("Onion");
                return ingredients;

            }
        }
        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public Brontowurst()
        {
           this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Hold the Bun for the ingredent by settting it false
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }
        /// <summary>
        /// Hold the Peppers for the ingredent by settting it false
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;

        }
        /// <summary>
        /// Hold the onion for the ingredent by settting it false
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
        }
        /// <summary>
        /// overrides the to sting method
        /// </summary>
        /// <returns>the name of the item </returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
   
