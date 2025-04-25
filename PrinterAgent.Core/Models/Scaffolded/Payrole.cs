using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Payrole")]
public partial class Payrole
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string Identification { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ActionDate { get; set; }

    public int Type { get; set; }

    public long PosInfoId { get; set; }

    public long StaffId { get; set; }

    [StringLength(250)]
    public string? ShopId { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("Payroles")]
    public virtual PosInfo PosInfo { get; set; } = null!;

    [ForeignKey("StaffId")]
    [InverseProperty("Payroles")]
    public virtual Staff Staff { get; set; } = null!;
}
