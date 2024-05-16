using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance.MyRestaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public MenuItem(string name,int stock,double price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }
    }
}
