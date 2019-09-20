using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger : Entrees
    {
        private bool Bun = true;
        private bool pickle = true;
        private bool Ketchup = true;
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
    }
}
