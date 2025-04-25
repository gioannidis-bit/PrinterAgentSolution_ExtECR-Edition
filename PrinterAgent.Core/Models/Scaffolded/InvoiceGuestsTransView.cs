using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class InvoiceGuestsTransView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    public long? InvoiceId { get; set; }

    public long? GuestId { get; set; }

    public long? TransactionId { get; set; }

    public long? DeliveryCustomerId { get; set; }
}
