using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PrehistoricPBJ :Entrees
    {
        private bool peanutButter = true;
        private bool jelly = true;
  
        /// <summary>
        /// sets the ingredentc list
        /// </summary>
        public List<string> Ingredients
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
    }
}
