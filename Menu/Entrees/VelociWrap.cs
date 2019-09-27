using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        private bool Dressing = true;
        private bool Lettuce = true;
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
    }
}
