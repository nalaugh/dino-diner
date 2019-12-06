using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    /// <summary>
    /// this is the class that the web uses to provied any of the searches for the menu
    /// </summary>
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();
        public IEnumerable<CretaceousCombo> Combo { get; set; } 
        public IEnumerable<Entree> Entree { get; set; }  
        public IEnumerable<Drink> Drink { get; set; }
        public IEnumerable<Side> Side { get; set; }



        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> Posibleingredints { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maxPrice { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public List<string> Ingredients { get; set; } = new List<string>();




        public void OnGet()
        {
            Posibleingredints = Menu.PosibleIngredents;
            Combo = Menu.AvailableCombos;
            Drink = Menu.AvailableDrinks;
            Side = Menu.AvailableSides;
            Entree = Menu.AvailableEntrees;
    
        }
        public void OnPost()
        {
            Combo = Menu.AvailableCombos;
            Drink = Menu.AvailableDrinks;
            Side = Menu.AvailableSides;
            Entree = Menu.AvailableEntrees;
            if (search != null)
            {
                Combo = Combo.Where(item => item.ToString().Contains(search));
                Entree = Entree.Where(item => item.ToString().Contains(search));
                Drink = Drink.Where(item => item.ToString().Contains(search));
                Side = Side.Where(item => item.ToString().Contains(search));
               
                Posibleingredints = Menu.PosibleIngredents;
            }
            if (menuCategory.Count > 0)
            {
                Combo = Combo.Where(item => menuCategory.Contains("CretaceousCombo"));
                Entree = Entree.Where(item => menuCategory.Contains("Entree"));
                Drink = Drink.Where(item => menuCategory.Contains("Drink"));
                Side = Side.Where(item => menuCategory.Contains("Side"));
              
                Posibleingredints = Menu.PosibleIngredents;
            }
            if(Ingredients.Count > 0)
            {
                foreach (string i in Ingredients)
                {
                    Combo = Combo.Where(item => !item.Ingredients.Contains(i));
                    Entree = Entree.Where(item => !item.Ingredients.Contains(i));
                    Drink = Drink.Where(item => !item.Ingredients.Contains(i));
                    Side = Side.Where(item => !item.Ingredients.Contains(i));
                }
               
                Posibleingredints = Menu.PosibleIngredents;
            }
            if (minimumPrice != null)
            {
                Combo = Combo.Where(item => item.Price>minimumPrice);
                Entree = Entree.Where(item => item.Price > minimumPrice);
                Drink = Drink.Where(item => item.Price > minimumPrice);
                Side = Side.Where(item => item.Price > minimumPrice);

              
                Posibleingredints = Menu.PosibleIngredents;
            }
            if (maxPrice != null)
            {
                Combo = Combo.Where(item => item.Price < maxPrice);
                Entree = Entree.Where(item => item.Price < maxPrice);
                Drink = Drink.Where(item => item.Price < maxPrice);
                Side = Side.Where(item => item.Price < maxPrice); 
                Posibleingredints = Menu.PosibleIngredents;
            }

        }
       
    }
}