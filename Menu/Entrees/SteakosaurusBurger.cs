/*  SteakosaurusBurger
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Steakosaurus Burger entree. 
    /// Its price is $5.15, it contains 621 calories, and its ingredients are: whole wheat bun, steakburger pattie, pickle, ketchup, and mustard.  
    /// It should implement methods for holding the bun, pickle, ketchup, and mustard.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// a private veribale of bun
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// private varible of pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// private veriable of Ketchup
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// private veribale of Mustard
        /// </summary>
        private bool Mustard = true;


        /// <summary>
        /// overrrids the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (pickle) ingredients.Add("Pickle");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public SteakosaurusBurger() : base()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Hold the Bun for the ingredent by settting it false
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }
        /// <summary>
        /// Hold the Pickle for the ingredent by settting it false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Hold the Ketchup for the ingredent by settting it false
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }
        /// <summary>
        /// Hold the Mustard for the ingredent by settting it false
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }
        /// <summary>
        /// overrids the toString method
        /// </summary>
        /// <returns>the name of the item</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
