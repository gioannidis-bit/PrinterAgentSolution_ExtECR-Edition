using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Store")]
public partial class Store
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public string? ExtDescription { get; set; }

    [StringLength(150)]
    public string? Phone1 { get; set; }

    [StringLength(50)]
    public string? Phone2 { get; set; }

    [StringLength(50)]
    public string? Phone3 { get; set; }

    [StringLength(250)]
    public string? Email { get; set; }

    [StringLength(150)]
    public string? Address { get; set; }

    [StringLength(50)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    public string? Longtitude { get; set; }

    [StringLength(250)]
    public string? ImageUri { get; set; }

    [StringLength(250)]
    public string? LogoUri { get; set; }

    public byte? Status { get; set; }

    public Guid? StoreMapId { get; set; }

    public short? StoreKitchenInstruction { get; set; }

    public long? DaStoreId { get; set; }

    [InverseProperty("Store")]
    public virtual ICollection<HotelInfo> HotelInfos { get; set; } = new List<HotelInfo>();

    [InverseProperty("Store")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    [InverseProperty("Store")]
    public virtual ICollection<StoreMessage> StoreMessages { get; set; } = new List<StoreMessage>();
}
