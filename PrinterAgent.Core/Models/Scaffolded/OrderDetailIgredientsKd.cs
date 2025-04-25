using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("OrderDetailIgredientsKDS")]
public partial class OrderDetailIgredientsKd
{
    [Key]
    public long Id { get; set; }

    public long OrderId { get; set; }

    public long OrderDetailId { get; set; }

    public long ProductId { get; set; }

    public long IgredientsId { get; set; }

    [StringLength(100)]
    public string Description { get; set; } = null!;

    public double Qty { get; set; }

    public long SalesTypeId { get; set; }

    [Column("KDSId")]
    public long Kdsid { get; set; }
}
