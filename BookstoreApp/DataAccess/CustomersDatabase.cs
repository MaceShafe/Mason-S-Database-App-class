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


        public static List<Customer> GetCustomers()
        {


            var customers = new List<Customer>();


            if (customers.Count == 0)
            {
                customers.Add(new Customer() { Id = 1, Name = "John Doe" });
                customers.Add(new Customer() { Id = 2, Name = "Jane Doe"});
                customers.Add(new Customer() { Id = 2, Name = "Mark Leahwitz"});


            }
            return customers;


        }


        public static void SaveCustomers(List<Customer> customers)
            {

            
            }
        }
    }
