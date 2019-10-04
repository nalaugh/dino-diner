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
        double Price { get; }
        uint Calories { get; }
        List<string> Ingredients { get; }
    }
}
