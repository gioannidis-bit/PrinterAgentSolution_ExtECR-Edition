using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OrderStatus")]
public partial class OrderStatus
{
    [Key]
    public long Id { get; set; }

    public long? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeChanged { get; set; }

    public long? OrderId { get; set; }

    public long? StaffId { get; set; }

    public int? ExtState { get; set; }

    public bool? IsSend { get; set; }

    [Column("DAOrderId")]
    public long? DaorderId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderStatuses")]
    public virtual Order? Order { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("OrderStatuses")]
    public virtual Staff? Staff { get; set; }
}
