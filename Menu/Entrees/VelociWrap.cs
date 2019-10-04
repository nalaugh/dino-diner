/*  VelociWarp
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Veloci-Wrap entree.  
    /// Its price is $6.86, it contains 356 calories, 
    /// and its ingredients are: a flour tortilla, chicken breast, romaine lettuce, Ceasar dressing, and parmesan cheese.  
    /// It should implement methods to hold the dressing, lettuce, and cheese.
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// private veriable of of dressing
        /// </summary>
        private bool Dressing = true;
        /// <summary>
        /// private veribale of Lettuce 
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// private veriable of cheese
        /// </summary>
        private bool Cheese = true;
  

        /// <summary>
        /// overrids the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Hold the dreesing for the ingredent by settting it false
        /// </summary>
        public void HoldDressing()
        {
            this.Dressing = false;
        }
        /// <summary>
        /// Hold the Lettuce for the ingredent by settting it false
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        /// <summary>
        /// Hold the Cheese for the ingredent by settting it false
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
        }
        /// <summary>
        /// override the tostring metod 
        /// </summary>
        /// <returns>returnes the name of the item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
