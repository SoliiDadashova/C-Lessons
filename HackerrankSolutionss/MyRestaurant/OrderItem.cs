using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance.MyRestaurant
{
    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public OrderItem(string name, int quantity, double totalPrice)
        {
            Name = name;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}
