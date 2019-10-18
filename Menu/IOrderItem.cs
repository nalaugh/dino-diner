using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
   public interface IOrderItem
    {
        string Description { get; }
        string[] Special { get; }
        double Price { get; }
    }
}
