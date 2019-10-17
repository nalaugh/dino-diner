using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        private double subtotalcost;
       public  ObservableCollection<IOrderItem> Item { get; set; }
       public double SubtotalCost
        {
            get
            {
                if (subtotalcost > 0)
                {
                    return subtotalcost;
                }
                else
                {
                    return 0;
                }
            }
        }
       public  double SalesTaxRate { get; protected set; }
       public double TotalCost { get; }

    }
}
