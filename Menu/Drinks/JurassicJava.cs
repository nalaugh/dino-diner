/*  JurassicJava
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Implement a class to represent the JurrasicJava, that inherits from the Drink class.  
    /// Unlike other drinks, it should default to Ice as false.  
    /// It should also implement properties for RoomForCream (bool, default false), Decaf (bool, default false). 
    /// It should also implement a method LeaveRoomForCream() and AddIce().
    /// Its price is $.59 (small), $.99 (medium), and $1.49 (large) and calories are 2 (small), 4 (medium), and 8 (large). 
    /// Its ingredients should be "Water" and "Coffee".
    /// </summary>
    public class JurrassicJava : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private veriable of size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// This cup is filled to the brim unless the cutermer wants the option to add cream.
        /// </summary>
        public bool RoomFOrCream  = false;
        /// <summary>
        /// this coffee is cafinated unless the cutomer wasnt the caffien removed.
        /// </summary>
        public bool Decaff = false;
        /// <summary>
        /// Set the size of dirnk
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        NotifyOfPropertyChange("Price");
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
                if (Ice) special.Add("Add Ice");
                if (RoomFOrCream) special.Add("Leave Room for Cream");
                return special.ToArray();

            }
        }

        /// <summary>
        /// adds the ingredantes
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
               
                return ingredients;
            }
        }
        /// <summary>
        /// constructs a Jurasic Java with default price and calories holding the Ice
        /// </summary>
        public JurrassicJava()
        {
            this.Price = .59;
            this.Calories = 2;
            this.HoldIce();
        }

        /// <summary>
        /// this leaves room for cream
        /// </summary>
        public void RoomForCream()
        {
            this.RoomFOrCream = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Adds ice if the person wants it.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// overrides the toString method 
        /// </summary>
        /// <returns>the size of the drink the name and if it was Decaf or not </returns>
        public override string ToString()
        {
            if (Decaff)
                return $"{ size}  Decaf Jurassic Java";
            else
                return $"{ size} Jurassic Java";
        }

    }
}
