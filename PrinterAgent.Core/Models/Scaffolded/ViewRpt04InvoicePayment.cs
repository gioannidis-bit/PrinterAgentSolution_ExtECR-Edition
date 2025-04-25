using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt04InvoicePayment
{
    public long? InvoicesId { get; set; }

    public long TransactionId { get; set; }

    public short? AccountType { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public long? GuestId { get; set; }
}
