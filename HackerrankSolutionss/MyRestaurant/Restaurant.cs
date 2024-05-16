using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInheritance.MyRestaurant
{
    public class Restaurant
    {
        public Menu Menu { get; set; }
        public Order Order { get; set; }
        public Restaurant()
        {
            Menu = new Menu();
            Order = new Order();
        }
        public void AddMenuItem(string name, int stock, double price)
        {
            MenuItem menuItem = new MenuItem(name, stock, price);
            Menu.AddMenu(menuItem);
        }
        public void PlaceOrder(string itemName, int quantity)
        {
            MenuItem mItem = Menu.MenuItems.Find(m => m.Name == itemName);
            if (itemName != null)
            {
                if (mItem.Stock >= quantity)
                {
                    double totalPrice = quantity * mItem.Price;
                    OrderItem order = new OrderItem(itemName, quantity, totalPrice);
                    Order.AddOrderItem(order);
                    mItem.Stock -= quantity;
                    Console.WriteLine($"Your order has been received successfully: {quantity} {itemName}");
                }
                else
                {
                    Console.WriteLine($"Sorry, {itemName} is out of stock");
                }

            }
            else
            {
                Console.WriteLine("Sorry we have not that food in our menu");
            }
        }
        public void ShowMenu()
        {
            Console.WriteLine("------------------Our Menu------------------");
            foreach(var item in Menu.MenuItems)
            {
                Console.WriteLine($"{item.Name}--Price: {item.Price}$ ");
            }
            Console.WriteLine("----------------------------------------");
        }
        public void ShowOrder()
        {
            Console.WriteLine("----------------------Your Order------------------------");
            foreach(var item in Order.OrderItems)
            {
                Console.WriteLine($"{item.Name}-{item.Quantity}-----Total Price is: {item.TotalPrice}$");
            }
            Console.WriteLine("------------------------------------");
        }
    }
}
