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
                Brontowurst bs = new Brontowurst();
                DinoNuggets Dn = new DinoNuggets();
                PrehistoricPBJ pj = new PrehistoricPBJ();
                SteakosaurusBurger SB = new SteakosaurusBurger();
                TRexKingBurger king = new TRexKingBurger();
                VelociWrap Vw = new VelociWrap();
                it.Add(bs);
                it.Add(Dn);
                it.Add(pj);
                it.Add(SB);
                it.Add(king);
                it.Add(Vw);
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
                Fryceritops Fry = new Fryceritops();
                MeteorMacAndCheese Mac = new MeteorMacAndCheese();
                MezzorellaSticks mez = new MezzorellaSticks();
                Triceritots tri = new Triceritots();
                it.Add(Fry);
                it.Add(Mac);
                it.Add(mez);
                it.Add(tri);
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
                JurrassicJava jv = new JurrassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();
                it.Add(jv);
                it.Add(soda);
                it.Add(tea);
                it.Add(water);
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
                CretaceousCombo br = new CretaceousCombo(new Brontowurst());
                CretaceousCombo Dn = new CretaceousCombo(new DinoNuggets());
                CretaceousCombo Pj = new CretaceousCombo(new PrehistoricPBJ());
                CretaceousCombo pt = new CretaceousCombo(new PterodactylWings());
                CretaceousCombo St = new CretaceousCombo(new SteakosaurusBurger());
                CretaceousCombo king = new CretaceousCombo(new TRexKingBurger());
                CretaceousCombo Vw = new CretaceousCombo(new VelociWrap());
                it.Add(br);
                it.Add(Dn);
                it.Add(Pj);
                it.Add(pt);
                it.Add(St);
                it.Add(king);
                it.Add(Vw);
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
