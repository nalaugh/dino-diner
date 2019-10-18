/*  SteakosaurusBurger
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the Steakosaurus Burger entree. 
    /// Its price is $5.15, it contains 621 calories, and its ingredients are: whole wheat bun, steakburger pattie, pickle, ketchup, and mustard.  
    /// It should implement methods for holding the bun, pickle, ketchup, and mustard.
    /// </summary>
    public class SteakosaurusBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// a private veribale of bun
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// private varible of pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// private veriable of Ketchup
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// private veribale of Mustard
        /// </summary>
        private bool Mustard = true;

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
                if (!Bun) special.Add("Hold Bun");
                if (!pickle) special.Add("Hold Pickles");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                return special.ToArray();

            }
        }


        /// <summary>
        /// overrrids the ingredentc list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (pickle) ingredients.Add("Pickle");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets this itens price and Calories55
        /// </summary>
        public SteakosaurusBurger() : base()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Hold the Bun for the ingredent by settting it false
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Hold the Pickle for the ingredent by settting it false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Hold the Ketchup for the ingredent by settting it false
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Hold the Mustard for the ingredent by settting it false
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// overrids the toString method
        /// </summary>
        /// <returns>the name of the item</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
