using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace BookstoreApp.DataAccess
{
    internal static class CustomerDatabase
    {

        private static string filename = "Customer.txt";
        private static string path = Environment.CurrentDirectory;
        private static string separator = "|";

        public static List<Customers> GetCustomers()
        {


            var customers = new List<Customers>();

            using StreamReader reader = new StreamReader(Path.Combine(path, filename));

            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(separator);

                if (parts.Length == 3)
                {
                    customers.Add(new Customers()
                    {
                        FirstName = parts[0],
                        LastName = parts[1],
                        Email = (parts[2])
                    });
                }
            }

            if (customers.Count == 0)
            {
                customers.Add(new Customers() { FirstName = "John", LastName = "Doe", Email = "JD@notanemail.com" });
            }

            
            return customers;
        }


        public static void SaveCustomers(List<Customers> customers)
            {

                using StreamWriter sw = new StreamWriter(Path.Combine(path, filename));

                foreach (Customers customer in customers)
                {
                    sw.Write(customer.FirstName + separator);
                    sw.Write(customer.LastName + separator);
                    sw.WriteLine(customer.Email);
                }
            }
        }
    }
