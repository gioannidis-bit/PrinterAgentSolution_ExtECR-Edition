using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PayrollNew")]
public partial class PayrollNew
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string Identification { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTo { get; set; }

    public long PosInfoId { get; set; }

    public long StaffId { get; set; }

    [StringLength(250)]
    public string? ShopId { get; set; }

    [StringLength(250)]
    public string? TotalHours { get; set; }

    public long? TotalMinutes { get; set; }

    public short? IsSend { get; set; }

    public bool? IsDeleted { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PayrollNews")]
    public virtual PosInfo PosInfo { get; set; } = null!;

    [ForeignKey("StaffId")]
    [InverseProperty("PayrollNews")]
    public virtual Staff Staff { get; set; } = null!;
}
