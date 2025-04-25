using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Table")]
public partial class Table
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(350)]
    public string? SalesDescription { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    public int? MinCapacity { get; set; }

    public int? MaxCapacity { get; set; }

    public long? RegionId { get; set; }

    public byte? Status { get; set; }

    [Column("YPos")]
    [StringLength(100)]
    public string? Ypos { get; set; }

    [Column("XPos")]
    [StringLength(100)]
    public string? Xpos { get; set; }

    public bool? IsOnline { get; set; }

    public short? ReservationStatus { get; set; }

    public long? Shape { get; set; }

    public int? TurnoverTime { get; set; }

    [StringLength(500)]
    public string? ImageUri { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    [StringLength(100)]
    public string? Angle { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ErgoPlusTableNo { get; set; }

    [InverseProperty("Table")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("Table")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("RegionId")]
    [InverseProperty("Tables")]
    public virtual Region? Region { get; set; }
}
