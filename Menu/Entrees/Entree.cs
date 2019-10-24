/*  Entree
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Create an Entree base class in the DiniDiner.Menu.Entrees namespace. 
    /// It should be an abstract class, and include Properties for **Price, Calories, **and read-only Ingredients.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem
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


    }
}
