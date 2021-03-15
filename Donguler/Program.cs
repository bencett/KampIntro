using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Laptop";
            product1.ProductValue = 4500;
            product1.StockAmount = 28;

            Product product2 = new Product();
            product2.ProductName = "Desk";
            product2.ProductValue = 700;
            product2.StockAmount = 17;

            Product product3 = new Product();
            product3.ProductName = "Smart Phone";
            product3.ProductValue = 4500;
            product3.StockAmount = 6;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " " + product.ProductValue);
            }
            Console.WriteLine("------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " " + products[i].ProductValue);
            }
            Console.WriteLine("------------------------");

            int j = products;
            while (j<products.Length)
            {
                Console.WriteLine(products[j].ProductName + " " + products[j].ProductValue);
                j++;
            }

        }
    }
    }

    class Product
    {
        public string ProductName { get; set; }
        public int ProductValue { get; set; }
        public int StockAmount { get; set; }
    }
