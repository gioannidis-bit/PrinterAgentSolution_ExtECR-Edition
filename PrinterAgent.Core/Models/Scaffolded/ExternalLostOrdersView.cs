using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ExternalLostOrdersView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string OrderNo { get; set; } = null!;

    public int ExtType { get; set; }
}
