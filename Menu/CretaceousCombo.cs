﻿/* CretaceousCombo
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// creatse the comb with the right size calories and ingredients
    /// </summary>
    public class CretaceousCombo
    {
        /// <summary>
        /// private backer with default to small
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// creats a fied for entree
        /// </summary>
        public Entree Entrees { get; set; }
        /// <summary>
        /// creats a field of Drink
        /// </summary>
        public Drink Drinks { get; set; } = new Sodasaurus();
        /// <summary>
        /// Creats a field of side
        /// </summary>
        public Side Sides { get; set; } = new Fryceritops();
        /// <summary>
        /// sets the size of the drink and the sides
        /// </summary>
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
        /// <summary>
        /// gets the price of of all the idenms and applies a discount for the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Drinks.Price + Sides.Price + Entrees.Price - 0.25;
            }

        }
        /// <summary>
        /// this gets the tolal calories for the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drinks.Calories + Sides.Calories + Entrees.Calories;
            }
        }
        /// <summary>
        /// gets all the ingredents of a combo
        /// </summary>
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

        /// <summary>
        /// constructs a combo
        /// </summary>
        /// <param name="entree">the type of combo</param>
        public CretaceousCombo(Entree entree)
        {
            Entrees = entree;
            Sides = new Fryceritops();
            Drinks = new Sodasaurus();

        }
        /// <summary>
        /// overrides the toString method
        /// </summary>
        /// <returns>the name of the combo</returns>
        public override string ToString()
        {
            return $"{Entrees} Combo";
        }
        public string Description
        {
            get
            {
                {
                    return this.ToString();
                }
            }
        }
        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                specials.AddRange(Entrees.Special);
                specials.Add(Drinks.ToString());
                specials.AddRange(Drinks.Special);
                specials.Add(Sides.ToString());
                specials.AddRange(Sides.Special);
                return specials.ToArray();
            }
        }
    }
}
