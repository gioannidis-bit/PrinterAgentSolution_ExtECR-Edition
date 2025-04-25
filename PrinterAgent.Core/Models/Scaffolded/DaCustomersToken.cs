using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("DA_CustomersTokens")]
public partial class DaCustomersToken
{
    [Key]
    public long Id { get; set; }

    public long? CustomerId { get; set; }

    public string? Token { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DaCustomersTokens")]
    public virtual DaCustomer? Customer { get; set; }
}
