using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookstoreApp.Models;

public partial class Product
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    [Column("ProductCode")]
    public string SKU { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("UnitPrice", TypeName = "money")]
    
    public decimal Price { get; set; }

    public int OnHandQuantity { get; set; }

    public byte[] Rowversion { get; set; } = null!;

    [InverseProperty("ProductCodeNavigation")]
    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; } = new List<InvoiceLineItem>();

    public override string ToString()
    {
        return $"[{SKU}] {Description} ({Price})";
    }
}
