/* Order
 *Author Natalie Laughlin
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu 
{
    /// <summary>
    /// gets all the totals and the tax along witht the the items added into teh order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        double salesTaxRate = 0;
        List<IOrderItem> items = new List<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// this creats an Order collection of items with a getter and set ter
        /// </summary>
        public IOrderItem[] Item
        {
            get
            {
                return items.ToArray();
            }
        }
        /// <summary>
        /// this is the getter for the subtodal that prevent the value from being a negative number
        /// </summary>
       public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach(IOrderItem i in Item)
                {
                    cost += i.Price;
                }
               if (cost < 0)
                    return 0;
                return cost;
             
            }
        }
        public Order()
        {

           // Item.PropertyChanged += OnPropertyChanged;
        }
        /// <summary>
        /// Adds a new item to our oder
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyOfPropertyChanged();
        }
        public bool Remove(IOrderItem item)
        {
            bool flag =items.Remove(item);
            if (flag)
            {
                NotifyOfPropertyChanged();
            }
            return flag;
        }
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChanged();

        }

        /// <summary>
        /// this takes in the the tax rate and has a protected rate to lover the amount that is used
        /// </summary>
       public double SalesTaxRate
        {
            get
            {
                return SalesTaxRate;
            }
            protected set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Item"));
            }
        }
        
        /// <summary>
        /// hich calculates the total cost as the sum of the SubtotalCost and the SalesTaxCost.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + (SalesTaxRate * SubtotalCost);
            }

        }
           /// <summary>
           /// the proberty chaed even handeler notifies when and item chaes 
           /// </summary>

        private void NotifyOfPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Item"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
