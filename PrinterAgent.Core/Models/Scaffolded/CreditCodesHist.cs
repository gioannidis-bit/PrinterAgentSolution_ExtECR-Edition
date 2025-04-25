using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("CreditCodes_Hist")]
public partial class CreditCodesHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [StringLength(150)]
    public string? Code { get; set; }

    public byte? Type { get; set; }

    public long? CreditAccountId { get; set; }
}
