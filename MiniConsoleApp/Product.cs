using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleApp
{
    internal class Product
    {
        public string No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }


        public Product(string no, string name, double price, int count)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }

        public void info()
        {
            Console.WriteLine($"No: {No}, Ad: {Name}, Qiymet: {Price}, Say: {Count}");

        }
    }
}
