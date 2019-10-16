/*  TRexKingBurger
*   Author: Natalie Laughlin
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the T-Rex King Burger entree.  
    /// Its price is $8.45, it contains 728 calories, 
    /// and its ingredients are: a whole wheat bun, three steakburger patties, lettuce, tomato, onion, pickle, ketchup, mustard, and mayo. 
    /// It should implement methods for holding the bun, lettuce, tomato, onion, pickle, ketchup, mustard, and mayo.
    /// </summary>
    public class TRexKingBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private veriable for bun
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// private veriable of pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// private veriable of Ketchup
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// private verible of Mustard
        /// </summary>
        private bool Mustard = true;
        /// <summary>
        /// private veriable of Lettuce
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// Private veribale of Onion
        /// </summary>
        private bool Onions = true;
        /// <summary>
        /// private veriable of Tomato
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// private veribale of Mayo
        /// </summary>
        private bool Mayo = true;
        /// <summary>
        /// private variable of the number patties
        /// </summary>
        public int count = 3;

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
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Onions) special.Add("Hold Onions");
                if (!tomato) special.Add("Hold Tomatos");
                if (!Mayo) special.Add("Hold Mayo");
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
                for (int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");
                if (Lettuce) ingredients.Add("Lettuce");
                if (pickle) ingredients.Add("Pickle");
                if (Onions) ingredients.Add("Onion");
                if (tomato) ingredients.Add("Tomato");
                if (Mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets this itens price and Calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        /// Hold the Lettuse for the ingredent by settting it false
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Hold the Tomatos for the ingredent by settting it false
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Hold the pickle for the ingredent by settting it false
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Hold the Onion for the ingredent by settting it false
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Hold the Mayo for the ingredent by settting it false
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// overrides the to sting method
        /// </summary>
        /// <returns>the name if the item.</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
