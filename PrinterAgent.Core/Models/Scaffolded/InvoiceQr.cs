using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("InvoiceQR")]
public partial class InvoiceQr
{
    [Key]
    public long Id { get; set; }

    public long? InvoiceId { get; set; }

    [Column("QR", TypeName = "image")]
    public byte[]? Qr { get; set; }

    [Column("QRUrl")]
    [StringLength(1500)]
    public string? Qrurl { get; set; }

    [StringLength(1500)]
    public string? RecFiscalServiceNumber { get; set; }

    [StringLength(1500)]
    public string? RecMark1 { get; set; }

    [StringLength(1500)]
    public string? RecMark2 { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceQrs")]
    public virtual Invoice? Invoice { get; set; }
}
