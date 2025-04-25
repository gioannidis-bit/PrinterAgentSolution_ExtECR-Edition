using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class StaffSecheduleDetail
{
    [Key]
    public long Id { get; set; }

    public long? StaffSceduleId { get; set; }

    public long? StaffId { get; set; }

    public long? StaffPositionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hour { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("StaffSecheduleDetails")]
    public virtual Staff? Staff { get; set; }

    [ForeignKey("StaffSceduleId")]
    [InverseProperty("StaffSecheduleDetails")]
    public virtual StaffSchedule? StaffScedule { get; set; }
}
