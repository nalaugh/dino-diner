/*  size
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{

    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
