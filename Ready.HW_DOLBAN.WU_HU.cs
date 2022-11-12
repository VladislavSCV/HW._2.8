using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goodtov_and_Order;

public class Goodtov
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public void Print_Info()
    {
        Console.WriteLine($"Id:{Id}, Name:{Name}, Price:{Price}, Description:{Description}.");
    }

}
public class Order
{
    public int Number { get; set; } //=66
    public Goodtov[] Goodtov1 { get; set; } //=Goodtov
    public string City { get; set; } //=Moscow
    public string Country { get; set; } //=Russia

    public void Print_Goods()
    {
        Console.WriteLine($"All Goods:...");
        foreach (var item in Goodtov1)
        {
            Console.WriteLine(item.Print_Info);
        }
    }
    public void Show_Order_Info()
    {
        Console.WriteLine($"Number:{Number},Tovar:{Goodtov1},State:{City},Country:{Country}.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Goodtov LapTop = new Goodtov();
        LapTop.Id = 13;
        LapTop.Name = "LapTop";
        LapTop.Price = 163;
        LapTop.Description = "Cool COMPUHTER";
        LapTop.Print_Info();

        Goodtov Ps4 = new Goodtov();
        Ps4.Id = 123;
        Ps4.Name = "Ps4";
        Ps4.Price = 154;
        Ps4.Description = "WOW";
        Ps4.Print_Info();
        
        Order order = new Order();
        order.Number = 895;
        order.Goodtov1 = new Goodtov[] { LapTop };
        order.City = "Moscow";
        order.Country = "Russia";


        void Print_Goods()
        {
            Console.WriteLine($"All Goods:{LapTop.Name},{Ps4.Name}");
            
        }
        Console.WriteLine("Вывод всех товаров:");
        Print_Goods();

        Console.WriteLine("Информация о заказе");
        void Show_Order_Info()
        {
            foreach (var items in order.Goodtov1)
            {
                Console.WriteLine($"Номер заказа:{order.Number}; Товары в заказе:{LapTop},{Ps4}; Город:{order.City}, Страна:{order.Country}");
            }
        }
        Show_Order_Info();
    }
}
