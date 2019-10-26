/*  IMenuItem
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// You will need to create an interface in the DinoDiner.Menu namespace, IMenuItem, 
    /// that requires a property with a getter for Price (double), Calories (uint), and Ingredients (a List<string>).
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// the price of the item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the number of calories of an item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// the ingredients in an item
        /// </summary>
        List<string> Ingredients { get; }
    }
}
