using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.Models
{
    public class Products
    {
        public int Id { get; set; }

        public string SKU { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{SKU} {Description} ({Price.ToString("c")})";
        }
    }
}
