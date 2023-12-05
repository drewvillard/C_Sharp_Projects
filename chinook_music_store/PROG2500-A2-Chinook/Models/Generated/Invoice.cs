﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PROG2500_A3_Chinook_Linq.Models;

[Table("Invoice")]
[Index("CustomerId", Name = "IFK_InvoiceCustomerId")]
public partial class Invoice
{
    [Key]
    public int InvoiceId { get; set; }

    public int CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [StringLength(70)]
    public string? BillingAddress { get; set; }

    [StringLength(40)]
    public string? BillingCity { get; set; }

    [StringLength(40)]
    public string? BillingState { get; set; }

    [StringLength(40)]
    public string? BillingCountry { get; set; }

    [StringLength(10)]
    public string? BillingPostalCode { get; set; }

    [Column(TypeName = "numeric(10, 2)")]
    public decimal Total { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Invoices")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceLine> InvoiceLines { get; } = new List<InvoiceLine>();
}
