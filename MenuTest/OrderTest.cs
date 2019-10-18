using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.Collections.ObjectModel;

namespace MenuTest
{
    
    public class OrderTest 
    {
        public class MockItem : IOrderItem
        {
            public string Description => throw new NotImplementedException();

            public string[] Special => throw new NotImplementedException();

            public double Price { get; }
            public MockItem(double n)
            {
                if (n == 0)
                {
                    this.Price = 0;
                }
                else if (n > 0){
                    this.Price = 5.50;
                }
                else
                {
                    this.Price = -40;
                }
            }
        }
        [Fact]
        public void ShouldnothaveNegative()
        {
            Order order = new Order();
            order.Item = new ObservableCollection<IOrderItem>();
            order.Item.Add(new MockItem(-2));

         
            Assert.Equal<double>(0, order.SubtotalCost);
            
        }
        [Fact]
        public void ShouldnothaveZero()
        {
            Order order = new Order();
            order.Item = new ObservableCollection<IOrderItem>();
            order.Item.Add(new MockItem(0));


            Assert.Equal<double>(0, order.SubtotalCost);

        }
        [Fact]
        public void ShouldnothavePrice()
        {
            Order order = new Order();
            order.Item = new ObservableCollection<IOrderItem>();
            order.Item.Add(new MockItem(5));


            Assert.Equal<double>(5.50, order.SubtotalCost);

        }
        
    }
}
