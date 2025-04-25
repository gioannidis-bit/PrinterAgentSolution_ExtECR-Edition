using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class AttendanceTimezone
{
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    public string? Code { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeFrom { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeTo { get; set; }

    [InverseProperty("AttendanceTimezone")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
}
