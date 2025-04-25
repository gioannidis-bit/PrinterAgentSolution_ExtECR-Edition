using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt08InvoiceRemark
{
    public long? InvoicesId { get; set; }

    [StringLength(1500)]
    public string? CustomerRemarks { get; set; }
}
