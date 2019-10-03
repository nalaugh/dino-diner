﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{

 
    public abstract class Drink : IMenuItem
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
        /// hold the ice from the drink;
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false;
        }
    }
}
