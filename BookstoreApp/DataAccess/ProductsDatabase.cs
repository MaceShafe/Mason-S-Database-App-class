using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.DataAccess
{
    internal static class ProductsDatabase
    {

        private static string filename = "Product.txt";
        private static string path = Environment.CurrentDirectory;
        private static string separator = "|";

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
            try
            {
                using StreamReader reader = new(
                    new FileStream(
                    Path.Combine(path, filename),
                    FileMode.OpenOrCreate, FileAccess.Read)
                    );

                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(separator);

                    if (parts.Length == 3)
                    {
                        products.Add(new Product()
                        {
                            SKU = parts[0],
                            Description = parts[1],
                            Price = Convert.ToDecimal(parts[2])
                        });
                    }
                }

                if (products.Count == 0)
                {
                    products.Add(new Product() { SKU = "ABC", Description = "Sample Product", Price = 10.0m });
                }

            } catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return products;
        }


        public static void SaveProducts(List<Product> products)
            {

            using StreamWriter sw = new StreamWriter(
                new FileStream(
                    Path.Combine(path, filename),
                    FileMode.Create,
                    FileAccess.Write)
                );

            foreach (Product product in products)
                {
                    sw.Write(product.SKU + separator);
                    sw.Write(product.Description + separator);
                    sw.WriteLine(product.Price);
                }
            }
        }
    }
