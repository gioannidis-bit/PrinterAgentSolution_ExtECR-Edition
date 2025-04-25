using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt07InvoiceSalesType
{
    public long? InvoicesId { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }
}
