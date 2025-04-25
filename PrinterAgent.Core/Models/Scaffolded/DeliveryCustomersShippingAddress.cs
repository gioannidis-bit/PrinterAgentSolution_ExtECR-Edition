using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Delivery_CustomersShippingAddress")]
public partial class DeliveryCustomersShippingAddress
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("CustomerID")]
    public long CustomerId { get; set; }

    [StringLength(70)]
    public string AddressStreet { get; set; } = null!;

    [StringLength(200)]
    public string? AddressNo { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(10)]
    public string? Zipcode { get; set; }

    public int? Type { get; set; }

    [StringLength(50)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    public string? Longtitude { get; set; }

    [StringLength(200)]
    public string? Floor { get; set; }

    public bool? IsSelected { get; set; }

    public bool? IsDeleted { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ExtKey { get; set; }

    public int? ExtType { get; set; }

    [Unicode(false)]
    public string? ExtObj { get; set; }

    [StringLength(50)]
    public string? ExtId1 { get; set; }

    [StringLength(50)]
    public string? ExtId2 { get; set; }

    [StringLength(80)]
    public string? VerticalStreet { get; set; }

    [StringLength(1500)]
    public string? Notes { get; set; }

    [StringLength(250)]
    public string? Bell { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DeliveryCustomersShippingAddresses")]
    public virtual DeliveryCustomer Customer { get; set; } = null!;

    [ForeignKey("Type")]
    [InverseProperty("DeliveryCustomersShippingAddresses")]
    public virtual DeliveryAddressType? TypeNavigation { get; set; }
}
