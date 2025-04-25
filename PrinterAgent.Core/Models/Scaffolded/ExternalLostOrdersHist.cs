using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "OrderNo", "ExtType")]
[Table("ExternalLostOrders_Hist")]
public partial class ExternalLostOrdersHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    [StringLength(255)]
    [Unicode(false)]
    public string OrderNo { get; set; } = null!;

    [Key]
    public int ExtType { get; set; }
}
