using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {

        private bool Bun = true;
        private bool Peppers = true;
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
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
   
