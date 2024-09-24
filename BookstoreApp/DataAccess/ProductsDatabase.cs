using BookstoreApp.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.DataAccess
{
    internal class ProductsDatabase
    {

        private MMABooksContext database = new();
        public List<Product> GetProducts()
        {
            var products = database.Products.ToList();
         

            if (products.Count == 0)
            {
                products.Add(new Product() { SKU = "ABC", Description = "Sample Product", Price = 10.0m });
            }

           

            return products;
        }


        public void SaveProducts(Product product)
            {
            database.Products.Add(product);
            database.SaveChanges();
      
            }
        }
    }
