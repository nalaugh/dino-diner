using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entrees
    {
        private bool Bun = true;
        private bool pickle = true;
        private bool Ketchup = true;
        private bool Mustard = true;
        private bool Lettuce = true;
        private bool Onions = true;
        private bool tomato = true;
        private bool Mayo = true;
        public int count = 3;

        /// <summary>
        /// sets the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Lettuce) ingredients.Add("Lettuce");
                if (pickle) ingredients.Add("Pickle");
                if (Onions) ingredients.Add("Onion");
                if (tomato) ingredients.Add("Tomato");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Hold the Bun for the ingredent by settting it false
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
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
        /// Hold the Lettuse for the ingredent by settting it false
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        /// <summary>
        /// Hold the Tomatos for the ingredent by settting it false
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// Hold the pickle for the ingredent by settting it false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Hold the Onion for the ingredent by settting it false
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
        }
        /// <summary>
        /// Hold the Mayo for the ingredent by settting it false
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }
    }
}
