using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
   public class Menu
    {
        public List<IMenuItem> AvailableMenuItems
        {
            get;
        }
        public List<IMenuItem> AvailableEntrees { get; }
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
