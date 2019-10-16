/*  Tyrannotea
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent Tyrannotea that inherits from Drink. 
    /// It should have properties for Sweet (a bool, default false) and Lemon (a bool, default false). 
    /// Its price is $0.99 (small), $1.49 (medium), and $1.99 (large).  Its calories are 8 (small), 16 (medium), and 32 (large). 
    /// Adding sweetener doubles these values. 
    /// It should also implement a method AddLemon() which sets the lemon to true. 
    /// Its ingredients should be "Water", "Tea", (if lemon was added) "Lemon", and (if sweet) "Cane Sugar".
    /// </summary>
    public class Tyrannotea : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private veriabl of size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// this is tea unless the cutemer wants sweet tea
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// this has no lemon unless the cutomer wants it
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// gets the size of the drink
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
                        Calories = 8;
                        if(Sweet)
                        {
                            Price = Price * 2;
                            Calories = Calories * 2;
                        }
                            break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet)
                        {
                            Price = Price * 2;
                            Calories = Calories * 2;
                        }
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet)
                        {
                            Price = Price * 2;
                            Calories = Calories * 2;
                        }
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
        /// constucts a Tyrannotee witb default values
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }
        /// <summary>
        /// fills in the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            { 
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if(Lemon)
                {
                    ingredients.Add("Lemon");
                }
                if(Sweet)
                {
                    ingredients.Add("Cane Suger");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// this adds the Lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// orverides the toString
        /// </summary>
        /// <returns>the name of the item along with if its size and wheither it's sweet or not  </returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return size + " Sweet Tyrannotea";
            }
            else

                return size + " Tyrannotea";
        }
    }
}
