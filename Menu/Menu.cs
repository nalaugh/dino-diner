/*  Menu
*   Author: Natalie Laughlin
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// You will also need to define a Menu class in the DinoDiner.Menu namespace which provides a property with a getter for AvailableMenuItems (List<MenuItem>) which should return a list containing one instance of every menu item currently offered by DinoDiner.
    ///  It should also implement a property with a getter to return all available entrees(AvailableEntrees), sides(AvailableSides), drinks(AvailableDrinks), and combos(AvailableCombos).
    ///It should also override the ToString() method to display the full menu contents, separated by new line characters(\n).
    /// </summary>
    public class Menu
    {
        public List<Entree> availableEntrees;
        public List<CretaceousCombo> availableCombos;
        public List<Drink> availableDrinks;
        public List<Side> availableSides;
        private List<string> posibleIngredents;

        public List<string> PosibleIngredents
        {
            get
            {
                if (posibleIngredents == null)
                {
                    posibleIngredents = new List<string>();
                    foreach (Object b in AvailableMenuItems)
                    {
                        if (b is CretaceousCombo c)
                        {
                            foreach (string s in c.Ingredients)
                            {


                                if (!(posibleIngredents.Contains(s)))
                                {
                                    posibleIngredents.Add(s);
                                }
                            }
                        }
                        if (b is Entree d)
                        {
                            foreach (string s in d.Ingredients)
                            {


                                if (!(posibleIngredents.Contains(s)))
                                {
                                    posibleIngredents.Add(s);
                                }
                            }
                        }
                        if (b is Drink e)
                        {
                            foreach (string s in e.Ingredients)
                            {


                                if (!(posibleIngredents.Contains(s)))
                                {
                                    posibleIngredents.Add(s);
                                }
                            }
                        }
                        if (b is Side f)
                        {
                            foreach (string s in f.Ingredients)
                            {


                                if (!(posibleIngredents.Contains(s)))
                                {
                                    posibleIngredents.Add(s);
                                }
                            }
                        }
                    }
                }
                return posibleIngredents;
            }
            set
            {
                this.posibleIngredents = value;
            }


        }

        /// <summary>
        /// gets a list of all the objects 
        /// </summary>
        public List<Object> AvailableMenuItems
        {
            get
            {
                List<Object> it = new List<Object>();
                it.AddRange(AvailableCombos);
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
                if (availableEntrees == null)
                {

                    availableEntrees = new List<Entree>();
                    availableEntrees.Add(new Brontowurst());
                    availableEntrees.Add(new DinoNuggets());
                    availableEntrees.Add(new PrehistoricPBJ());
                    availableEntrees.Add(new SteakosaurusBurger());
                    availableEntrees.Add(new TRexKingBurger());
                    availableEntrees.Add(new VelociWrap());

                }
                return availableEntrees;


            }
            set
            {
                this.availableEntrees = value;
            }


        }
        /// <summary>
        /// Gets a list of all the sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                if (availableSides == null)
                {
                    availableSides = new List<Side>();
                    availableSides.Add(new Fryceritops());
                    availableSides.Add(new MeteorMacAndCheese());
                    availableSides.Add(new MezzorellaSticks());
                    availableSides.Add(new Triceritots());

                }
                return availableSides;

            }
            set
            {
                this.availableSides = value;
            }


        }
        /// <summary>
        /// gets a list of all the drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                if (availableDrinks == null)
                {
                    availableDrinks = new List<Drink>();
                    availableDrinks.Add(new JurrassicJava());
                    availableDrinks.Add(new Sodasaurus());
                    availableDrinks.Add(new Tyrannotea());
                    availableDrinks.Add(new Water());
                }
                return availableDrinks;

            }
            set
            {
                this.availableDrinks = value;
            }



        }
        /// <summary>
        /// gets a list of all the Combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                if (availableCombos == null)
                {
                    availableCombos = new List<CretaceousCombo>();
                    availableCombos.Add(new CretaceousCombo(new Brontowurst()));
                    availableCombos.Add(new CretaceousCombo(new DinoNuggets()));
                    availableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                    availableCombos.Add(new CretaceousCombo(new PterodactylWings()));
                    availableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                    availableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                    availableCombos.Add(new CretaceousCombo(new VelociWrap()));
                }

                return availableCombos;
            }
            set
            {
                this.availableCombos = value;
            }
        }
        /// <summary>
        /// overrides the toString method
        /// </summary>
        /// <returns>the name of all the items and a new line</returns>
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            foreach (Object i in AvailableMenuItems)
            {
                st.Append(i.ToString());
                st.Append("\n");
            }
            return st.ToString();
        }
        /// <summary>
        /// this searches for the item that contains the string
        /// this searches for the item that contains the strin
        /// </summary>
        /// <param name="str"></param>
        public void Search(string str)

        {
            List<Object> result = new List<Object>();
            foreach (Object m in AvailableMenuItems)
            {
                if (m is Drink b)
                {
                    if (!b.ToString().Contains(str))
                    {
                        availableDrinks.Remove(b);
                    }
                }
                if (m is Entree c)
                {
                    if (!c.ToString().Contains(str))
                    {
                        availableEntrees.Remove(c);
                    }
                }
                if (m is Side s)
                {
                    if (!s.ToString().Contains(str))
                    {
                        availableSides.Remove(s);
                    }
                }
                if (m is CretaceousCombo t)
                {
                    if (!t.ToString().Contains(str))
                    {
                        availableCombos.Remove(t);
                    }
                }

            }
        }
        /// <summary>
        /// this removes the catigories the indiviula does not want to see
        /// </summary>
        /// <param name="str"></param>
        public void FilterCat(List<string> str)

        {

            if (!str.Contains("Combo"))
            {

                foreach (CretaceousCombo d in AvailableCombos.ToArray())
                {
                    availableCombos.Remove(d);
                }

            }
            if (!str.Contains("Entree"))
            {
                foreach (Entree e in AvailableEntrees.ToArray())
                {
                    availableEntrees.Remove(e);
                }
            }
            if (!str.Contains("Drink"))
            {

                foreach (Drink d in AvailableDrinks.ToArray())
                {
                    availableDrinks.Remove(d);
                }

            }
            if (!str.Contains("Side"))
            {

                foreach (Side d in AvailableSides.ToArray())


                {
                    availableSides.Remove(d);
                }
            }
        }

        /// <summary>
        /// this removes the items that contain the listed ingredient
        /// </summary>
        /// <param name="Ingr"></param>
        public void IngredientsExcude(List<string> Ingr)
        {

            foreach (Object b in AvailableMenuItems)
            {
                if (b is CretaceousCombo c)
                {
                    foreach (string s in c.Ingredients)
                    {


                        if ((Ingr.Contains(s)))
                        {
                            availableCombos.Remove(c);
                        }
                    }
                }
                if (b is Entree d)
                {
                    foreach (string s in d.Ingredients)
                    {


                        if ((Ingr.Contains(s)))
                        {
                            availableEntrees.Remove(d);
                        }
                    }
                }
                if (b is Drink e)
                {
                    foreach (string s in e.Ingredients)
                    {


                        if ((Ingr.Contains(s)))
                        {
                            availableDrinks.Remove(e);
                        }
                    }
                }
                if (b is Side f)
                {
                    foreach (string s in f.Ingredients)
                    {


                        if ((Ingr.Contains(s)))
                        {
                            availableSides.Remove(f);
                        }
                    }
                }
            }


        }
        /// <summary>
        /// THis removes all of the items that are to cheep
        /// </summary>
        /// <param name="minPrice"></param>
        public void Minsearch(float minPrice)
        {
            foreach (Object b in AvailableMenuItems)
            {
                if (b is CretaceousCombo c)
                {

                    if (c.Price <= minPrice)
                    {
                        availableCombos.Remove(c);
                    }

                }
                if (b is Entree d)
                {

                    if (d.Price <= minPrice)
                    {
                        availableEntrees.Remove(d);
                    }

                }
                if (b is Drink e)
                {

                    if (e.Price <= minPrice)
                    {
                        availableDrinks.Remove(e);
                    }

                }
                if (b is Side f)
                {

                    if (f.Price <= minPrice)
                    {
                        availableSides.Remove(f);
                    }

                }
            }


        }
        /// <summary>
        /// this removes all the items that are to expensive
        /// </summary>
        /// <param name="maxPrice"></param>
        public void Maxsearch(float maxPrice)
        {
            foreach (Object b in AvailableMenuItems)
            {
                if (b is CretaceousCombo c)
                {

                    if (c.Price >= maxPrice)
                    {
                        availableCombos.Remove(c);
                    }

                }
                if (b is Entree d)
                {

                    if (d.Price >= maxPrice)
                    {
                        availableEntrees.Remove(d);
                    }

                }
                if (b is Drink e)
                {

                    if (e.Price >= maxPrice)
                    {
                        availableDrinks.Remove(e);
                    }

                }
                if (b is Side f)
                {

                    if (f.Price >= maxPrice)
                    {
                        availableSides.Remove(f);
                    }

                }
            }


        }
    }

}

