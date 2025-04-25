using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("InvoiceGroubByInvoiceTypeAndAccount")]
public partial class InvoiceGroubByInvoiceTypeAndAccount
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    public string GroupName { get; set; } = null!;

    public long InvoiceTypeType { get; set; }

    public long AccountType { get; set; }

    public long? LastNumber { get; set; }
}
