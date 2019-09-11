using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint Nuggetcount = 6;
        private uint AddNuggetcount = 0;
           public double Price { get; set; }
            public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < Nuggetcount; i++)
                    Ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }

    public DinoNuggets()
        
    {

                this.Price = (4.25 + (0.25 * AddNuggetcount));
                this.Calories = 59 * (Nuggetcount + AddNuggetcount);
    }
        public void AddNugget()
        {

            this.AddNuggetcount++;
        }

    }
       
   
}
