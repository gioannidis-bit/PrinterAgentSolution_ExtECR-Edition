using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("StaffPosition")]
public partial class StaffPosition
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [InverseProperty("StaffPosition")]
    public virtual ICollection<AssignedPosition> AssignedPositions { get; set; } = new List<AssignedPosition>();

    [InverseProperty("StaffPosition")]
    public virtual ICollection<PosInfoStaffPositinAssoc> PosInfoStaffPositinAssocs { get; set; } = new List<PosInfoStaffPositinAssoc>();
}
