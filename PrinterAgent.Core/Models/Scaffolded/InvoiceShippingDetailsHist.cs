using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("InvoiceShippingDetails_Hist")]
public partial class InvoiceShippingDetailsHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? InvoicesId { get; set; }

    public long? ShippingAddressId { get; set; }

    [StringLength(300)]
    public string? ShippingAddress { get; set; }

    [StringLength(100)]
    public string? ShippingCity { get; set; }

    [StringLength(50)]
    public string? ShippingZipCode { get; set; }

    public long? BillingAddressId { get; set; }

    [StringLength(300)]
    public string? BillingAddress { get; set; }

    [StringLength(100)]
    public string? BillingCity { get; set; }

    [StringLength(50)]
    public string? BillingZipCode { get; set; }

    [StringLength(100)]
    public string? BillingName { get; set; }

    [StringLength(100)]
    public string? BillingVatNo { get; set; }

    [Column("BillingDOY")]
    [StringLength(100)]
    public string? BillingDoy { get; set; }

    [StringLength(100)]
    public string? BillingJob { get; set; }

    [StringLength(200)]
    public string? Floor { get; set; }

    [StringLength(1500)]
    public string? CustomerRemarks { get; set; }

    [StringLength(1500)]
    public string? StoreRemarks { get; set; }

    [Column("CustomerID")]
    public long? CustomerId { get; set; }

    [StringLength(500)]
    public string? CustomerName { get; set; }

    public double? Longtitude { get; set; }

    public double? Latitude { get; set; }

    [StringLength(150)]
    public string? Phone { get; set; }
}
