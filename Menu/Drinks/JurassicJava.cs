using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurrassicJava : Drink
    {
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
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
            get
            {
                return size;
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
        }
        /// <summary>
        /// Adds ice if the person wants it.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }

        public override string ToString()
        {
            if (Decaff)
                return size + " Decaf Jurassic Java";
            else
                return  size + " Jurassic Java";
        }

    }
}
