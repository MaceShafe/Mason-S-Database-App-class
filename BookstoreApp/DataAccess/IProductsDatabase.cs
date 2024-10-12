using BookstoreApp.Models;

namespace BookstoreApp.DataAccess
{
    public interface IProductsDatabase
    {
        void AddProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProduct(string productCode);
        List<Product> GetProducts();
        void UpdateProduct(Product product);
    }
}