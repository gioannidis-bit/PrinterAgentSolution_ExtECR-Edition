using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class TransactionType
{
    [Key]
    public long Id { get; set; }

    public short? Code { get; set; }

    public string? Description { get; set; }

    public bool? IsIncome { get; set; }

    public bool? IsDeleted { get; set; }
}
