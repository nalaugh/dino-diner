using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool Bun = true;
        private bool pickle = true;
        private bool Ketchup = true;
        private bool Mustard = true;


        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
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

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.Bun = false;
        }

       public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }
        public void HoldMustard()
        {
            this.Mustard = false;
        }
    }
}
