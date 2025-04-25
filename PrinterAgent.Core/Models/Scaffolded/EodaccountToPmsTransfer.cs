using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("EODAccountToPmsTransfer")]
public partial class EodaccountToPmsTransfer
{
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

    [ForeignKey("AccountId")]
    [InverseProperty("EodaccountToPmsTransfers")]
    public virtual Account? Account { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("EodaccountToPmsTransfers")]
    public virtual PosInfo? PosInfo { get; set; }
}
