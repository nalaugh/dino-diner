/*  Menu
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// You will also need to define a Menu class in the DinoDiner.Menu namespace which provides a property with a getter for AvailableMenuItems (List<MenuItem>) which should return a list containing one instance of every menu item currently offered by DinoDiner.
    ///  It should also implement a property with a getter to return all available entrees(AvailableEntrees), sides(AvailableSides), drinks(AvailableDrinks), and combos(AvailableCombos).
    ///It should also override the ToString() method to display the full menu contents, separated by new line characters(\n).
    /// </summary>
   public class Menu
    {
        /// <summary>
        /// gets a list of all the objects 
        /// </summary>
        public List<Object> AvailableMenuItems
        {
            get
            {
                List<Object> it = new List<Object>();
                it.AddRange(AvailableEntrees);
                it.AddRange(AvailableDrinks);
                it.AddRange(AvailableSides);
                return it;
            }
        }
        /// <summary>
        /// gets a list of all the Entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> it = new List<Entree>();
                it.Add(new Brontowurst());
                it.Add(new DinoNuggets());
                it.Add(new PrehistoricPBJ());
                it.Add(new SteakosaurusBurger());
                it.Add(new TRexKingBurger());
                it.Add(new VelociWrap());
                return it;
                
            }
        }
        /// <summary>
        /// Gets a list of all the sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> it = new List<Side>();
                it.Add(new Fryceritops());
                it.Add(new MeteorMacAndCheese());
                it.Add(new MezzorellaSticks());
                it.Add(new Triceritots());
                return it;

            }
        }
        /// <summary>
        /// gets a list of all the drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> it = new List<Drink>();
                it.Add(new JurrassicJava());
                it.Add(new Sodasaurus());
                it.Add(new Tyrannotea());
                it.Add(new Water());
                return it;

            }
        }
        /// <summary>
        /// gets a list of all the Combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> it = new List<CretaceousCombo>();
                it.Add(new CretaceousCombo(new Brontowurst()));
                it.Add(new CretaceousCombo(new DinoNuggets()));
                it.Add(new CretaceousCombo(new PrehistoricPBJ()));
                it.Add(new CretaceousCombo(new PterodactylWings()));
                it.Add(new CretaceousCombo(new SteakosaurusBurger()));
                it.Add(new CretaceousCombo(new TRexKingBurger()));
                it.Add(new CretaceousCombo(new VelociWrap()));
                return it;
            }
        }
        /// <summary>
        /// overrides the toString method
        /// </summary>
        /// <returns>the name of all the items and a new line</returns>
        public override string ToString() 
        {
            StringBuilder st = new StringBuilder();

            foreach(Object i in AvailableMenuItems)
            {
                st.Append(i.ToString());
                st.Append("\n");
            }
            return st.ToString();
        }

    }
}
