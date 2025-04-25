using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_OrderStatus")]
public partial class DaOrderStatus
{
    [Key]
    public long Id { get; set; }

    [Column("OrderDAId")]
    public long OrderDaid { get; set; }

    public short Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StatusDate { get; set; }

    [ForeignKey("OrderDaid")]
    [InverseProperty("DaOrderStatuses")]
    public virtual DaOrder OrderDa { get; set; } = null!;
}
