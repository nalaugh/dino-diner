//plesiosaursPattie
//Author: Natalie
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{/// <summary>
/// Class assinment
/// </summary>
    public class PlesiosarusPattie : Entree
    {
        /// <summary>
        /// shows if the custemner want the bun or not
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// shows if the cutemer wants Mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Gives the discription of the entree
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Give and array of the the spcial requests
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Constructs the object of the  setting the default price and Calpries
        /// </summary>
        public PlesiosarusPattie()
        {
            this.Price = 5.50;
            this.Calories = 487;

        }
        /// <summary>
        /// Gets all the ingredents depending on the request of the cutomer
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredents = new List<string> { "Fish Pattie" };
                if (bun) ingredents.Add("Whole Wheat Bun");
                if (mayo) ingredents.Add("Mayonnaise");
                return ingredents;
            }
        }
        /// <summary>
        /// set the bun to false so it will not be added to ingredents
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// set Mayo to false so that it will not be added to the ingredentes
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

        /// <summary>
        /// overrids the toString method
        /// </summary>
        /// <returns>the name of the item</returns>
        public override string ToString()
        {
            return "Plesiosaurus Pattie";
        }
    }
}
