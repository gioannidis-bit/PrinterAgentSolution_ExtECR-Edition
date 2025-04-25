using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt06InvoiceRelatedReceipt
{
    public long InvoiceId { get; set; }

    [StringLength(23)]
    [Unicode(false)]
    public string? RelatedReceipts { get; set; }
}
