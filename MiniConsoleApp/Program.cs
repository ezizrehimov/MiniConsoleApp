using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Market market = new Market(2);


            while (true)
            {
                string chooseStr;
                int chooseVal;
                do
                {
                    Console.WriteLine("Secin edin 1-2-3-4: ");
                    Console.WriteLine(" 1. Product elave et\r\n 2. Product sat\r\n 3. Productlara bax\r\n 4. Menudan chix");

                    chooseStr = Console.ReadLine();
                } while (!int.TryParse(chooseStr, out chooseVal) || (chooseVal != 1 && chooseVal != 2 &&
                chooseVal != 3 && chooseVal != 4));

                switch (chooseVal)
                {
                    case 1:
                        Console.Write("No: ");
                        string no = Console.ReadLine();
                        Console.Write("Ad: ");
                        string name = Console.ReadLine();

                        string priceStr;
                        double price;
                        do
                        {
                            Console.Write("Qiymet: ");
                            priceStr = Console.ReadLine();
                        } while (!double.TryParse(priceStr, out price));


                        string countStr;
                        int count;
                        do
                        {
                            Console.Write("Say: ");
                            countStr = Console.ReadLine();
                        } while (!int.TryParse(countStr, out count));


                        Product newProduct = new Product(no, name, price, count);
                        market.AddProduct(newProduct);
                        break;


                    case 2:
                        Console.WriteLine("satmaq istediyniz mehsulun No daxil edin: ");
                        string productNo = Console.ReadLine();
                        market.SellProduct(productNo);
                        break;

                    case 3:
                        Console.WriteLine("Marketdeki butun mehsullar: ");

                        foreach (var product in market.Products)
                        {
                            product.info();
                        }
                        break;


                    case 4:
                        return;
                }




            }
        }






    }
}
