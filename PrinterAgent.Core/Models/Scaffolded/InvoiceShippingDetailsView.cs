using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class InvoiceShippingDetailsView
{
    [Column("nYear")]
    public int? NYear { get; set; }

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

    [StringLength(200)]
    public string? Floor { get; set; }

    [StringLength(1500)]
    public string? CustomerRemarks { get; set; }

    [StringLength(1500)]
    public string? StoreRemarks { get; set; }

    [StringLength(500)]
    public string? CustomerName { get; set; }

    public double? Longtitude { get; set; }

    public double? Latitude { get; set; }

    [StringLength(1500)]
    public string? Phone { get; set; }

    public long? BillingName { get; set; }

    [StringLength(500)]
    public string? BillingVatNo { get; set; }

    [Column("BillingDOY")]
    public double? BillingDoy { get; set; }

    public double? BillingJob { get; set; }

    [Column("CustomerID")]
    public long? CustomerId { get; set; }
}
