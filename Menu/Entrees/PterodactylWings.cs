/*  PterodactylWings
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Pterodactyl Wings entree. 
    /// Its price is $7.21, it contains 318 calories, and its ingredients are:  Chicken and Wing Sauce.
    /// </summary>
    public class PterodactylWings : Entree, IOrderItem, INotifyPropertyChanged
	{

        /// <summary>
        /// overrides the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// propertychange evnt handler; notifies of chagws to the price,
        /// Desciption and Special Properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //helper function for notifying of property change
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Gets the disciption
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// gets the special prepartion instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
               
                return special.ToArray();

            }
        }


        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
        }
        /// <summary>
        /// overrids the toString method
        /// </summary>
        /// <returns>the name of the item</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
