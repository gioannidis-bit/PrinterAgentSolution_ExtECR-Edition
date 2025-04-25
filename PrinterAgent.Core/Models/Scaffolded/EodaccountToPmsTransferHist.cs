using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[PrimaryKey("NYear", "Id")]
[Table("EODAccountToPmsTransfer_Hist")]
public partial class EodaccountToPmsTransferHist
{
    [Key]
    [Column("nYear")]
    public int NYear { get; set; }

    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? AccountId { get; set; }

    public long? PmsRoom { get; set; }

    [StringLength(300)]
    public string? Description { get; set; }

    public bool? Status { get; set; }

    [StringLength(100)]
    public string? PmsDepartmentId { get; set; }

    [StringLength(250)]
    public string? PmsDepDescription { get; set; }
}
