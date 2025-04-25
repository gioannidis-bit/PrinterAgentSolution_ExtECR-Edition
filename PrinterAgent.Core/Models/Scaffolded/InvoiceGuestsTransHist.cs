using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("Invoice_Guests_Trans_Hist")]
public partial class InvoiceGuestsTransHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? InvoiceId { get; set; }

    public long? GuestId { get; set; }

    public long? TransactionId { get; set; }

    public long? DeliveryCustomerId { get; set; }
}
