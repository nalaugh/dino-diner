/*  water
*   Author: Natalie Laughlin
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent a glass of water that inherits from the Drink base class. 
    /// It should have property Lemon (bool, default false), and a AddLemon() method.  
    /// The Water class should have a price of $0.10 and 0 calories for all sizes. 
    /// Its ingredients should be "Water" and (if lemon was added) "Lemon".
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// private property of size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// this is jsut water unless the cutemer wants a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// this gets the size of the drink
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Small:
                        Price = 0.10;
                        Calories = 0;
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
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();

            }
        }

        /// <summary>
        /// enter the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
              
                return ingredients;
            }
        }
        /// <summary>
        /// constructs the water and sets the default price and Calories
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;

        }

        /// <summary>
        /// this adds the lemon
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// this overrides the tostring.
        /// </summary>
        /// <returns>the size and water</returns>
        public override string ToString()
        {
            string  s  =  size + " Water";
            return s;
        }
    }
}
