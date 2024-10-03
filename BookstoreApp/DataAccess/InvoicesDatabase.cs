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
        private MMABooksContext database = new();


        public List<Invoice> GetInvoices()
        {
            var invoices = database.Invoices.ToList();
           

                if (invoices.Count == 0)
                {
                    invoices.Add(new Invoice() { Id = 1 ,CustomerID = 1 ,InvoiceDate = DateTime.Now, InvoiceTotal = 10 });
                    invoices.Add(new Invoice() { Id = 2, CustomerID = 1, InvoiceDate = DateTime.Now, InvoiceTotal = 34 });
                    invoices.Add(new Invoice() { Id = 3, CustomerID = 2, InvoiceDate = DateTime.Now, InvoiceTotal = 61 });
                    invoices.Add(new Invoice() { Id = 4, CustomerID = 3, InvoiceDate = DateTime.Now, InvoiceTotal = 34 });
                    invoices.Add(new Invoice() { Id = 5, CustomerID = 2, InvoiceDate = DateTime.Now, InvoiceTotal = 12 });

                }
            return invoices;

            }
        }   
    }
