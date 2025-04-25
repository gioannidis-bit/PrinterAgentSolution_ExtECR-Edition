using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class CreditCodesView
{
    [Column("nYear")]
    public int? NYear { get; set; }

    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [StringLength(150)]
    public string? Code { get; set; }

    public byte? Type { get; set; }

    public long? CreditAccountId { get; set; }
}
