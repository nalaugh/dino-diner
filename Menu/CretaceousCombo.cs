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
        /// <summary>
        /// private backer with default to small
        /// </summary>
        private Size size = Size.Small;
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
                return Drinks.Price + Sides.Price + Entrees.Price - 0.25;
            }

        }
        public uint Calories
        {
            get
            {
                return Drinks.Calories + Sides.Calories + Entrees.Calories;
            }
        }
        public List<string> Ingredients
        {
            get
            {
                List<string> intgredients = new List<string>();
                intgredients.AddRange(Entrees.Ingredients);
                intgredients.AddRange(Drinks.Ingredients);
                intgredients.AddRange(Sides.Ingredients);
                return intgredients;

            }
        }


        public CretaceousCombo() { };
        public CretaceousCombo(Entree entree)
        {
            Entrees = entree;
            Sides = new Fryceritops();
            Drinks = new Sodasaurus();

        }
    }
}
