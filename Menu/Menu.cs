using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// You will also need to define a Menu class in the DinoDiner.Menu namespace which provides a property with a getter for AvailableMenuItems (List<MenuItem>) which should return a list containing one instance of every menu item currently offered by DinoDiner.
    ///  It should also implement a property with a getter to return all available entrees(AvailableEntrees), sides(AvailableSides), drinks(AvailableDrinks), and combos(AvailableCombos).
    ///It should also override the ToString() method to display the full menu contents, separated by new line characters(\n).
    /// </summary>
   public class Menu
    {
        public List<IMenuItem> AvailableMenuItems
        {
            get;
        }
        public List<IMenuItem> AvailableEntrees {  get; }
        public List<IMenuItem> AvailableSides { get; }
        public List<IMenuItem> AvailableDrinks { get; }
        public List<IMenuItem> AvailableCombos { get; }

        public override string ToString()
        {
            foreach(IMenuItem i in AvailableMenuItems)
            {
                Console.WriteLine(i + "\n");
            }
            return "";
        }

    }
}
