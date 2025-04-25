using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("InvoiceHtmlReceipt")]
public partial class InvoiceHtmlReceipt
{
    [Key]
    public long Id { get; set; }

    public long? InvoiceId { get; set; }

    [Column(TypeName = "image")]
    public byte[]? HtmlReceipt { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceHtmlReceipts")]
    public virtual Invoice? Invoice { get; set; }
}
