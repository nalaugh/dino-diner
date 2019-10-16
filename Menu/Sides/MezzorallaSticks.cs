/*  MezzorallaSticks
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the MezzorellaSticks Side that inherits from the Side base class. 
    /// It’s price is $0.99 (small), $1.45 (medium), or $1.95 (large). 
    /// Its calories are 540 (small), 610 (medium), and 720 (large). 
    /// Its ingredients are **cheese product, breading, **and vegtable oil.
    /// </summary>
    public class MezzorellaSticks: Side, IOrderItem, INotifyPropertyChanged
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
                        Calories = 720;
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
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
        /// constructs the drink
        /// </summary>
        public MezzorellaSticks()
        {
           
                this.Price = 0.99;
                this.Calories = 540;
           
        }
        /// <summary>
        /// override the ingredients list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
                return ingredients;
            }
        }
        /// <summary>
        /// overrides the tostring method
        /// </summary>
        /// <returns>the size and the name of the item</returns>
        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }
    }
}
