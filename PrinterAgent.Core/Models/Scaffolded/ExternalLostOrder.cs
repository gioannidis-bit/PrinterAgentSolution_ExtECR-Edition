using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("OrderNo", "ExtType")]
public partial class ExternalLostOrder
{
    [Key]
    [StringLength(255)]
    [Unicode(false)]
    public string OrderNo { get; set; } = null!;

    [Key]
    public int ExtType { get; set; }
}
