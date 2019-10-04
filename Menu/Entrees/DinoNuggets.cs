/*  DinoNuggets
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Dino Nuggest entree.  
    /// Its price is $4.25, it contains 59 calories per nugget, and its ingredients are: 6 chicken nuggets.  
    /// It should implement methods for adding a nugget at an additional $0.25.
    /// </summary>
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
        /// <summary>
        /// overrides the to string method
        /// </summary>
        /// <returns>ths nem of the item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
    
       
   
}
