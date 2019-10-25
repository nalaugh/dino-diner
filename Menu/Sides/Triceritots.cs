/*  Triceritots
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Triceritots Side that inherits from the Side base class. 
    /// It’s price is $0.99 (small), $1.45 (medium), or $1.95 (large). 
    /// Its calories are 352 (small), 410 (medium), and 590 (large).  
    /// Its ingredients are **potatoes, salt, **and vegtable oil.
    /// </summary>
    public class Triceritots : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private verible of size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// overrides the price and the calories based on the size of the side
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 552;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Description");
                        break;
                }
            }
            get
            {
                return size;
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
        /// constuctor of the drink setting default price and Calories
        /// </summary>
        public Triceritots()
        {
                this.Price = 0.99;
                this.Calories = 352; 
         }
        /// <summary>
        /// overides the list of ingredients 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Vegetable Oil", "Salt" };
                return ingredients;
            }
        }
        /// <summary>
        /// overrids the to string method
        /// </summary>
        /// <returns>the size and name of the item</returns>
        public override string ToString()
        {
            return size + " Triceritots";
        }
    }

}

