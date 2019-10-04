/*  PrehistoricPBJ
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The impelmentation of the prehistoric PB & J is provided as an example.  
    /// Its price is $6.52, it contains 483 calories, and its ingredients are: bread, peanut butter, and jelly. 
    /// It implements methods to hold the peanut butter and jelly.
    /// </summary>
    public class PrehistoricPBJ :Entree
    {
        /// <summary>
        /// private veriable of peanutbuter
        /// </summary>
        private bool peanutButter = true;
        /// <summary>
        /// private veriable of jelly
        /// </summary>
        private bool jelly = true;
  
        /// <summary>
        /// sets the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Hold the PeanutButter for the ingredent by settting it false
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Hold the Jelly for the ingredent by settting it false
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
        /// <summary>
        /// overrifes the tosting metod
        /// </summary>
        /// <returns>the name of the item</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
