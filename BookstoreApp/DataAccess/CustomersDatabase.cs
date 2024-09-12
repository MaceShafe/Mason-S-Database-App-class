using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace BookstoreApp.DataAccess
{
    internal static class CustomersDatabase
    {

        private static string filename = "Customer.txt";
        private static string path = Environment.CurrentDirectory;
        private static string separator = "|";

        public static List<Customer> GetCustomers()
        {


            var customers = new List<Customer>();
            try {
                using StreamReader reader = new (
                    new FileStream(
                    Path.Combine(path, filename),
                    FileMode.OpenOrCreate, FileAccess.Read)
                    );

                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(separator);

                    if (parts.Length == 4)
                    {
                        customers.Add(new Customer()
                        {
                            Id = Convert.ToInt32(parts[0]),
                            FirstName = parts[1],
                            LastName = parts[2],
                            Email = (parts[3])
                        });
                    }
                }

                if (customers.Count == 0)
                {
                    customers.Add(new Customer() { Id = 1, FirstName = "John", LastName = "Doe", Email = "JD@notanemail.com" });
                    customers.Add(new Customer() { Id = 2, FirstName = "Jane", LastName = "Doe", Email = "JD2@notanemail.com" });
                    customers.Add(new Customer() { Id = 2, FirstName = "Mark", LastName = "Leahwitz", Email = "LW@notanemail.com" });


                }


            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return customers;

        }


        public static void SaveCustomers(List<Customer> customers)
            {

            using StreamWriter sw = new StreamWriter(
                new FileStream(
                    Path.Combine(path, filename),
                    FileMode.Create, 
                    FileAccess.Write)
                );


                foreach (Customer customer in customers)
                {
                    sw.WriteLine(customer.Id + separator);
                    sw.Write(customer.FirstName + separator);
                    sw.Write(customer.LastName + separator);
                    sw.WriteLine(customer.Email);
                }
            }
        }
    }
