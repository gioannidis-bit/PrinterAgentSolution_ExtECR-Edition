using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OrderMonitoring")]
public partial class OrderMonitoring
{
    [Key]
    public long Id { get; set; }

    public long? OrderId { get; set; }

    [StringLength(50)]
    public string? OrderNo { get; set; }

    public long? PosId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReadyDate { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderMonitorings")]
    public virtual Order? Order { get; set; }
}
