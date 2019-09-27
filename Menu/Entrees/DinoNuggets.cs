using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
    /// <summary>
    /// set the defalt nugget number
    /// </summary>
        private uint Nuggetcount = 6;
  
        /// <summary>
        /// sets the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < Nuggetcount; i++)
                    ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }
    /// <summary>
    /// Sets this itens price and Calories
    /// </summary>
    public DinoNuggets()
        
    {
            this.Price = (4.25 + (0.25 * (Nuggetcount-6)));
            this.Calories = 59 * (Nuggetcount);

        }
        /// <summary>
        /// Adds a nugget and changed the price and calories accoridingly
        /// </summary>
        public void AddNugget()
        {

            this.Nuggetcount++;
            this.Price = (4.25 + (0.25 * (Nuggetcount - 6)));
            this.Calories = 59 * (Nuggetcount);
        }

    }
       
   
}
