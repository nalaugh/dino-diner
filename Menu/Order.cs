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
        /// <summary>
        /// this creats an Order collection of items with a getter and set ter
        /// </summary>
        public ObservableCollection<IOrderItem> Item { get; set; }
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
            Item = new ObservableCollection<IOrderItem>();
            Item.CollectionChanged += OnCollectionsChared;

        }

        private void OnCollectionsChared(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Item"));
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

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
