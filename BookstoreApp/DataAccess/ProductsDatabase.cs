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

     
        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
         

            if (products.Count == 0)
            {
                products.Add(new Product() { SKU = "ABC", Description = "Sample Product", Price = 10.0m });
            }

           

            return products;
        }


        public static void SaveProducts(List<Product> products)
            {

      
            }
        }
    }
