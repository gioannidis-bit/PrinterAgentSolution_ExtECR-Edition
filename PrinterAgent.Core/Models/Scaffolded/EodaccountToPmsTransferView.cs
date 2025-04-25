using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Keyless]
public partial class EodaccountToPmsTransferView
{
    [Column("nYear")]
    public int? NYear { get; set; }

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
