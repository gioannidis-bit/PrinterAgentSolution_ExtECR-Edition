using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("PosInfo_StaffPositin_Assoc")]
public partial class PosInfoStaffPositinAssoc
{
    [Key]
    public long Id { get; set; }

    public long? PosInfoId { get; set; }

    public long? StaffPositionId { get; set; }

    [ForeignKey("PosInfoId")]
    [InverseProperty("PosInfoStaffPositinAssocs")]
    public virtual PosInfo? PosInfo { get; set; }

    [ForeignKey("StaffPositionId")]
    [InverseProperty("PosInfoStaffPositinAssocs")]
    public virtual StaffPosition? StaffPosition { get; set; }
}
