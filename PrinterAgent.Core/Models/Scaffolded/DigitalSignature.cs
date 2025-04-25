using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DigitalSignature")]
public partial class DigitalSignature
{
    [Key]
    public long Id { get; set; }

    public long? InvoiceId { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Images { get; set; }
}
