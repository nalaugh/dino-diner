using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
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


        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
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

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.Bun = false;
        }

        public void HoldKetchup()
        {
            this.Ketchup = false;
        }
        public void HoldMustard()
        {
            this.Mustard = false;
        }
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        public void HoldTomato()
        {
            this.tomato = false;
        }
        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldOnion()
        {
            this.Onions = false;
        }
        public void HoldMayo()
        {
            this.Mayo = false;
        }
    }
}
