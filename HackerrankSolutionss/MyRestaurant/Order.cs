using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance.MyRestaurant
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; }
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public double CalculatingTotalPrice()
        {
            double totalPrice = 0;
            foreach (OrderItem item in OrderItems)
            {
                totalPrice += item.TotalPrice;
            }
            return totalPrice;
        }

    }
}
