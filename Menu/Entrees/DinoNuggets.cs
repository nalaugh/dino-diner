/*  DinoNuggets
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Dino Nuggest entree.  
    /// Its price is $4.25, it contains 59 calories per nugget, and its ingredients are: 6 chicken nuggets.  
    /// It should implement methods for adding a nugget at an additional $0.25.
    /// </summary>
    public class DinoNuggets : Entree, IOrderItem, INotifyPropertyChanged
    {
    /// <summary>
    /// set the defalt nugget number
    /// </summary>
        private uint Nuggetcount = 6;


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
            get {
                if (Nuggetcount > 6)
                {
                    return  this.ToString();
                }
                else
                return  this.ToString(); }
        }
        /// <summary>
        /// gets the special prepartion instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(Nuggetcount>6)special.Add((Nuggetcount - 6) + " Extra Nuggets");
                return special.ToArray();

            }
        }

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
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
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
