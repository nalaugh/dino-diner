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
           // fillCombo();
           // fillDrink();
           // fillEntree();
          //  fillSide();
        }
        public void OnPost()
        {
            if(search != null)
            {
                Combo = Combo.Where(item => item.ToString().Contains(search));
                Entree = Entree.Where(item => item.ToString().Contains(search));
                Drink = Drink.Where(item => item.ToString().Contains(search));
                Side = Side.Where(item => item.ToString().Contains(search));
               // Menu.Search(search);
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
        public void fillCombo()
        {
            Combo = Menu.AvailableCombos;
        }
        public void fillEntree()
        {

            foreach (Entree i in Menu.AvailableEntrees)
            {
                Entree.Append(i);
            }
        }
        public void fillDrink()
        {

            foreach (Drink i in Menu.AvailableDrinks)
            {
                Drink.Append(i);
            }
        }
        public void fillSide()
        {

            foreach (Side i in Menu.AvailableSides)
            {
                Side.Append(i);
            }
        }
    }
}