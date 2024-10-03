using BookstoreApp.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.DataAccess
{
    public class ProductsDatabase
    {

        private MMABooksContext context = new();
        public List<Product> GetProducts()
        {
            var products = context.Products.ToList();


            if (products.Count == 0)
            {
                products.Add(new Product() { SKU = "ABC", Description = "Sample Product", Price = 10.0m });
            }



            return products;
        }

        public Product GetProduct(string productCode)
        {
            return context.Products.Find(productCode);
        }

        public void SaveProducts(Product product)
            {
            context.Products.Add(product);
            context.SaveChanges();
      
            }
        }
    }
