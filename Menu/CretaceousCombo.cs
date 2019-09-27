using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        private Size size;
        public Entree Entrees { get; set; }
        public Drink Drinks { get; set; }
        public Side Sides { get; set; }
        public Size Size
        {

            get
            {
                return size;
            }
            set
            {
                this.size = value;
                this.Drinks.Size = value;
                this.Sides.Size = value;

            }
        }
        public double Price
        {
            get
            {
                return Drinks.Price + Sides.Price + Entree.Price - 0.25;
            }

        }
        public uint Calories
        {
            get
            {
                return Drinks.Calories + Sides.Calories + Entrees.Calories;
            }
        }


        public override string ToString()
        {
            return "";
        }
    }
}
