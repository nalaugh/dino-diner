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
            
        }
        public void OnPost()
        {
            if(search != null)
            {
                Menu.Search(search);
                Posibleingredints = Menu.PosibleIngredents;
            }
            if (menuCategory.Count > 0)
            {
                Menu.FilterCat(menuCategory);
                Posibleingredints = Menu.PosibleIngredents;
            }
            if(Ingredients.Count > 0)
            {
                Menu.IngredientsExcude(Ingredients);
                Posibleingredints = Menu.PosibleIngredents;
            }
            if (minimumPrice != null)
            {
                Menu.Minsearch((float)minimumPrice);
                Posibleingredints = Menu.PosibleIngredents;
            }
            if (maxPrice != null)
            {
                Menu.Maxsearch((float)maxPrice);
                Posibleingredints = Menu.PosibleIngredents;
            }

        }
    }
}