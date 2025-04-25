using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class AssignedPosition
{
    [Key]
    public long Id { get; set; }

    public long? StaffPositionId { get; set; }

    public long? StaffId { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("AssignedPositions")]
    public virtual Staff? Staff { get; set; }

    [ForeignKey("StaffPositionId")]
    [InverseProperty("AssignedPositions")]
    public virtual StaffPosition? StaffPosition { get; set; }
}
