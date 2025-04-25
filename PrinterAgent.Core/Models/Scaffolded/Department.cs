using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("Department")]
public partial class Department
{
    [Key]
    public long Id { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [InverseProperty("Department")]
    public virtual ICollection<Combo> Combos { get; set; } = new List<Combo>();

    [InverseProperty("Department")]
    public virtual ICollection<MealConsumption> MealConsumptions { get; set; } = new List<MealConsumption>();

    [InverseProperty("Department")]
    public virtual ICollection<PosInfo> PosInfos { get; set; } = new List<PosInfo>();

    [InverseProperty("Department")]
    public virtual ICollection<StaffSchedule> StaffSchedules { get; set; } = new List<StaffSchedule>();

    [InverseProperty("Department")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [InverseProperty("PosDepartment")]
    public virtual ICollection<TransferMapping> TransferMappings { get; set; } = new List<TransferMapping>();

    [InverseProperty("Department")]
    public virtual ICollection<WorkSheet> WorkSheets { get; set; } = new List<WorkSheet>();
}
