using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("ProtelAirLastTransaction")]
public partial class ProtelAirLastTransaction
{
    [Key]
    public long Id { get; set; }

    public long? TransactionId { get; set; }
}
