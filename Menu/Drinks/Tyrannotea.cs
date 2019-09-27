using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size;
        /// <summary>
        /// this is tea unless the cutemer wants sweet tea
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// this has no lemon unless the cutomer wants it
        /// </summary>
        public bool Lemon { get; set; } = false;
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        
                        Price = 0.99;
                        Calories = 8;
                        if(Sweet)
                        {
                            Price = Price * 2;
                            Calories = Calories * 2;
                        }
                            break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet)
                        {
                            Price = Price * 2;
                            Calories = Calories * 2;
                        }
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet)
                        {
                            Price = Price * 2;
                            Calories = Calories * 2;
                        }
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// constucts a Tyrannotee witb default values
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
        }
        /// <summary>
        /// fills in the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            { 
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if(Lemon)
                {
                    ingredients.Add("Lemon");
                }
                if(Sweet)
                {
                    ingredients.Add("Cane Suger");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// this adds the Lemon to the tea
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }

    }
}
