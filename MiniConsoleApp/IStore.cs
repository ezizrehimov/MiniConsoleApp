using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleApp
{
    internal interface IStore
    {

        List<Product> Products { get; }
        int ProductLimit { get; }
        double TotalIncome { get; }
        void AddProduct(Product product);
        void SellProduct(string productNo);
    }
}
