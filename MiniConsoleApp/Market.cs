using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleApp
{
    internal class Market : IStore
    {

        private List<Product> productsList;

        public Market(int productLimit)
        {
            productsList = new List<Product>();
            ProductLimit = productLimit;
        }

        public List<Product> Products => productsList;
        public int ProductLimit { get; set; }
        public double TotalIncome { get; set; }

        public void AddProduct(Product product)
        {
            if (productsList.Count < ProductLimit && !productsList.Exists(p => p.No == product.No))
            {
                productsList.Add(product);
                Console.WriteLine("Mehsul elave edildi: " + product.Name);
            }
            else
            {
                Console.WriteLine("Mehsul elave edilmedi. Ya bu No va  ve ya limite artiq catib.");
            }
        }

        public void SellProduct(string productNo)
        {

            Product product = productsList.Find(p => p.No == productNo);

            if (product != null && product.Count > 0)
            {
                product.Count--;
                TotalIncome += product.Price;
                Console.WriteLine("Mehsul satildi: " + product.Name);

            }
            else
            {
                Console.WriteLine("Mehsul tapilmadi ve ya say kifayet deyil");
            }
        }



    }
}
