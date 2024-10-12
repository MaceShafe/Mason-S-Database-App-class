using BookstoreApp.Models;

namespace BookstoreApp.DataAccess
{
    public class ProductsDatabaseEF : IProductsDatabase
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

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();

        }

        public void UpdateProduct(Product product)
        {
            context.SaveChanges();
        }


        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }


}
