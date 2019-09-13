using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint Nuggetcount = 6;
           public double Price { get; set; }
            public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < Nuggetcount; i++)
                    ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }

    public DinoNuggets()
        
    {
            this.Price = (4.25 + (0.25 * (Nuggetcount-6)));
            this.Calories = 59 * (Nuggetcount);

        }
        public void AddNugget()
        {

            this.Nuggetcount++;
            this.Price = (4.25 + (0.25 * (Nuggetcount - 6)));
            this.Calories = 59 * (Nuggetcount);
        }

    }
       
   
}
