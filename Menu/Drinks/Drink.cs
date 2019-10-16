/*  Drink
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Implement an abstract base class to represent any drink.  
    /// It should contain properties for: Price (a double), Calories (an uint), Ingredients (a List<string>), Size  (using a Size enum, default small), 
    /// and Ice (bool, default true). It should also implement a method HoldIce() which sets the Ice property to false.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// Adds ice to the drink
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Gets the disciption
        /// </summary>
        public abstract string Description
        {
            get;
        }
        /// <summary>
        /// gets the special prepartion instructions
        /// </summary>
        public abstract string[] Special
        {
            get;
         
        }



        /// <summary>
        /// hold the ice from the drink;
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
