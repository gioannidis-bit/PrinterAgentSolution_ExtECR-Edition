using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_Addresses")]
public partial class DaAddress
{
    [Key]
    public long Id { get; set; }

    public int OwnerId { get; set; }

    [StringLength(200)]
    public string AddressStreet { get; set; } = null!;

    [StringLength(20)]
    public string AddressNo { get; set; } = null!;

    [StringLength(200)]
    public string? VerticalStreet { get; set; }

    [StringLength(200)]
    public string? Floor { get; set; }

    [StringLength(100)]
    public string? Area { get; set; }

    [StringLength(100)]
    public string City { get; set; } = null!;

    [StringLength(10)]
    public string? Zipcode { get; set; }

    public double Latitude { get; set; }

    public double Longtitude { get; set; }

    [StringLength(1500)]
    public string? Notes { get; set; }

    [StringLength(200)]
    public string? Bell { get; set; }

    public int AddressType { get; set; }

    [Column(TypeName = "text")]
    public string? ExtObj { get; set; }

    [StringLength(50)]
    public string? ExtId1 { get; set; }

    [StringLength(50)]
    public string? ExtId2 { get; set; }

    [StringLength(200)]
    public string? FriendlyName { get; set; }

    public int? AddressProximity { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(20)]
    public string? LastPhoneNumber { get; set; }

    [StringLength(1000)]
    public string? Phonetics { get; set; }

    [StringLength(1000)]
    public string? PhoneticsArea { get; set; }

    public long? LastStore { get; set; }

    [StringLength(100)]
    public string? Neighborhood { get; set; }

    [InverseProperty("ShippingAddress")]
    public virtual ICollection<DaOrder> DaOrders { get; set; } = new List<DaOrder>();

    [InverseProperty("Address")]
    public virtual ICollection<DaStore> DaStores { get; set; } = new List<DaStore>();
}
