using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("StaffSchedule")]
public partial class StaffSchedule
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Day { get; set; }

    public long? DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("StaffSchedules")]
    public virtual Department? Department { get; set; }

    [InverseProperty("StaffScedule")]
    public virtual ICollection<StaffSecheduleDetail> StaffSecheduleDetails { get; set; } = new List<StaffSecheduleDetail>();
}
