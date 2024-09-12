using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.Models
{
    internal class Invoice
    {
        public int Id { get; set; }

        public int CustomerID {  get; set; }

        public Customer Cusotmer{ get; set; }

        public DateTime InvoiceDate { get; set; }
        
        public decimal InvoiceTotal { get; set; }
    }
}
