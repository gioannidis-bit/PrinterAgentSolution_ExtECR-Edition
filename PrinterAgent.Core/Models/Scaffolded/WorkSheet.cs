using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("WorkSheet")]
public partial class WorkSheet
{
    [Key]
    public long Id { get; set; }

    public long? StaffId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Day { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Hour { get; set; }

    public byte? Type { get; set; }

    public long? DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("WorkSheets")]
    public virtual Department? Department { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("WorkSheets")]
    public virtual Staff? Staff { get; set; }
}
