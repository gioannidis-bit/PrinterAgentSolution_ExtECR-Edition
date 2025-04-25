using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class ViewRpt05InvoicePaymentsGuest
{
    public long? InvoicesId { get; set; }

    public long? TransactionId { get; set; }

    [StringLength(150)]
    public string? FirstName { get; set; }

    [StringLength(500)]
    public string? LastName { get; set; }

    [StringLength(150)]
    public string? Room { get; set; }

    [StringLength(150)]
    public string? GuestTerm { get; set; }

    public int? Kids { get; set; }

    public int? Adults { get; set; }
}
