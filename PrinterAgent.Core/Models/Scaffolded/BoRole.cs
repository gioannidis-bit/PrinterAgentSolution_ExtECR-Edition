using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrinterAgentService;

[Table("BO_Roles")]
public partial class BoRole
{
    [Key]
    public long Id { get; set; }

    public int? Role { get; set; }

    [StringLength(150)]
    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<BoRoleAction> BoRoleActions { get; set; } = new List<BoRoleAction>();

    [InverseProperty("Role")]
    public virtual ICollection<BoUser> BoUsers { get; set; } = new List<BoUser>();
}
