/*  Fryceritops
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Fryceritops Side that inherits from the Side base class. 
    /// It’s price is $0.99 (small), $1.45 (medium), or $1.95 (large).  Its calories are 222 (small), 365 (medium), and 480 (large).  
    /// Its ingredients are **potatoes, salt, **and vegtable oil
    /// </summary>
    public class Fryceritops : Side, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// private verible of size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// Setting the size based on the size of the side
        /// this is done through a switch overriding the previously set priced and calories.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        NotifyOfPropertyChange("Price");
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
        /// this constucts object seting the default sizes
        /// </summary>
        /// 
        public Fryceritops()
        {

            this.Price = 0.99;
            this.Calories = 222;
        }
        /// <summary>
        /// this overides the ingresnts
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }
        /// <summary>
        /// overrides the tosting method
        /// </summary>
        /// <returns>the size and the name of the item </returns>
        public override string ToString()
        {
            return size + " Fryceritops";
        }

    }

}

