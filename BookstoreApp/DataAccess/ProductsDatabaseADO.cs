using BookstoreApp.Models;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace BookstoreApp.DataAccess
{
    internal class ProductsDatabaseADO : IProductsDatabase
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;

        public void AddProduct(Product product)
        {
            string insertStatement =
                "INSERT Products (ProductCode, Description, UnitPrice, OnHandQuantity" +
                "VALUES (@ProductCode, @Description, @UnitPrice, @OnHandQuantity)";


            SqlConnection connection = new(connectionString);
            SqlCommand cmd = new(insertStatement, connection);
            cmd.Parameters.AddWithValue("@ProductCode", product.SKU);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@UnitPrice", product.Price);
            cmd.Parameters.AddWithValue("@OnHandQuantity", product.OnHandQuantity);

            connection.Open();
            cmd.ExecuteNonQuery();



        }


        public Product GetProduct(string productCode)
        {
            Product product = null;

            string selectStatement = "SELECT * FROM Products WHERE ProductCode = @ProductCode";

            SqlConnection connection = new(connectionString);
            SqlCommand cmd = new(selectStatement, connection);
            cmd.Parameters.AddWithValue("@ProductCode", productCode);

         
                connection.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    product = new Product()
                    {
                        SKU = reader["ProductCode"].ToString(),
                        Description = reader["Description"].ToString(),
                        Price = (decimal)reader["UnitPrice"],
                        OnHandQuantity = (int)reader["OnHandQuantity"]
                    };

                }
            



            return product;
        }

        public List<Product> GetProducts()
        {

            List<Product> products = new List<Product>();

            string selectStatement = "SELECT * FROM Products";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new(selectStatement, connection);


                connection.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    products.Add(new Product()
                    {
                        SKU = reader["ProductCode"].ToString(),
                        Description = reader["Description"].ToString(),
                        Price = (decimal)reader["UnitPrice"],
                        OnHandQuantity = (int)reader["OnHandQuantity"]
                    });

                }



            return products;

        }

        public void UpdateProduct(Product product)
        {
            string updateStatement =
                "UPDATE Products SET"+
                "Description =@Description"+
                "UnitPrice=@UnitPrice"+
                "OnHandQuantity= @OnHandQuantity" +
                "WHERE ProductCode=@ProductCode";


            SqlConnection connection = new(connectionString);
            SqlCommand cmd = new(updateStatement, connection);
            cmd.Parameters.AddWithValue("@ProductCode", product.SKU);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@UnitPrice", product.Price);
            cmd.Parameters.AddWithValue("@OnHandQuantity", product.OnHandQuantity);

            connection.Open();
            cmd.ExecuteNonQuery();
        }

        public void DeleteProduct(Product product)
        {
            string updateStatement =
                "DELETE FROM Products" +
                "WHERE ProductCode=@ProductCode";


            SqlConnection connection = new(connectionString);
            SqlCommand cmd = new(updateStatement, connection);
            cmd.Parameters.AddWithValue("@ProductCode", product.SKU);

            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
