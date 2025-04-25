using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

public partial class Attendance
{
    [Key]
    public long Id { get; set; }

    public long? DepartmentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    public long? AttendanceTimezoneId { get; set; }

    [StringLength(200)]
    public string? Room { get; set; }

    [StringLength(200)]
    public string? FirstName { get; set; }

    [StringLength(200)]
    public string? LastName { get; set; }

    [StringLength(200)]
    public string? Board { get; set; }

    public int? Adults { get; set; }

    public int? Children { get; set; }

    [StringLength(50)]
    public string? Table { get; set; }

    [ForeignKey("AttendanceTimezoneId")]
    [InverseProperty("Attendances")]
    public virtual AttendanceTimezone? AttendanceTimezone { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Attendances")]
    public virtual Department? Department { get; set; }
}
