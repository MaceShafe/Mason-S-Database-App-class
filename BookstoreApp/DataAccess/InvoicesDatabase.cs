using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.DataAccess
{
    internal class InvoicesDatabase
    {
        private static string filename = "Invoice.txt";
        private static string path = Environment.CurrentDirectory;
        private static string separator = "|";

        public static List<Invoice> GetInvoices()
        {
            var invoices = new List<Invoice>();
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

                    if (parts.Length == 4)
                    {
                        invoices.Add(new Invoice()
                        {
                            Id = Convert.ToInt32(parts[0]),
                            CustomerID = Convert.ToInt32(parts[1]),
                            InvoiceDate = Convert.ToDateTime(parts[2]),
                            InvoiceTotal = Convert.ToDecimal(parts[3]),
                        });
                    }

                }

                if (invoices.Count == 0)
                {
                    invoices.Add(new Invoice() { Id = 1 ,CustomerID = 1 ,InvoiceDate = DateTime.Now, InvoiceTotal = 10 });
                    invoices.Add(new Invoice() { Id = 2, CustomerID = 1, InvoiceDate = DateTime.Now, InvoiceTotal = 34 });
                    invoices.Add(new Invoice() { Id = 3, CustomerID = 2, InvoiceDate = DateTime.Now, InvoiceTotal = 61 });
                    invoices.Add(new Invoice() { Id = 4, CustomerID = 3, InvoiceDate = DateTime.Now, InvoiceTotal = 34 });
                    invoices.Add(new Invoice() { Id = 5, CustomerID = 2, InvoiceDate = DateTime.Now, InvoiceTotal = 12 });


                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return invoices;

            }
        }   
    }
